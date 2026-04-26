#pragma once

// Simplified C++ wrapper around JoltPhysics for mrbind binding (C and C#).
// None of the Jolt headers are exposed here — only standard C++ types.
// Based on the joltc reference binding (references/joltc/).

// ---------------------------------------------------------------------------
// Primitive math types
// ---------------------------------------------------------------------------

/// Single-precision 3D vector (velocities, forces, normals).
struct JoltVec3f {
    float x, y, z;
    JoltVec3f();
    JoltVec3f(float x, float y, float z);
};

/// Double-precision 3D vector (world-space positions).
struct JoltVec3 {
    double x, y, z;
    JoltVec3();
    JoltVec3(double x, double y, double z);
};

/// Single-precision quaternion (rotation).
struct JoltQuat {
    float x, y, z, w;
    JoltQuat();
    JoltQuat(float x, float y, float z, float w);
    static JoltQuat Identity();
    bool IsNormalized(float tolerance) const;
    JoltVec3f RotateAxisX() const;
    JoltVec3f RotateAxisY() const;
    JoltVec3f RotateAxisZ() const;
};

// ---------------------------------------------------------------------------
// Matrix types
// ---------------------------------------------------------------------------

/// Float-precision 4x4 column-major transform matrix.
/// Columns: 0=right(x), 1=up(y), 2=forward(z), 3=translation.
struct JoltMat44 {
    float e00, e10, e20, e30;  // column 0
    float e01, e11, e21, e31;  // column 1
    float e02, e12, e22, e32;  // column 2
    float e03, e13, e23, e33;  // column 3 (translation)
    JoltMat44();
    static JoltMat44 Identity();
    JoltVec3f GetTranslation() const;
    JoltQuat  GetRotation()    const;
};

/// Real-precision 4x4 transform: float 3x3 rotation + double translation.
/// Columns 0-2 are the rotation axes (float); tx/ty/tz is world-space translation.
struct JoltRMat44 {
    float  e00, e10, e20;   // column 0 (right)
    float  e01, e11, e21;   // column 1 (up)
    float  e02, e12, e22;   // column 2 (forward)
    double tx, ty, tz;      // world-space translation
    JoltRMat44();
    static JoltRMat44 Identity();
    JoltVec3  GetTranslation()  const;
    JoltVec3f GetTranslationF() const;  ///< float-precision translation
    JoltQuat  GetRotation()     const;
    JoltMat44 ToMat44()         const;  ///< cast translation to float
};

// ---------------------------------------------------------------------------
// Axis-aligned bounding box
// ---------------------------------------------------------------------------

/// World-space AABB (double-precision min/max).
struct JoltAABox {
    double minX, minY, minZ;
    double maxX, maxY, maxZ;
    JoltAABox();
    JoltAABox(double minX, double minY, double minZ,
              double maxX, double maxY, double maxZ);
    JoltVec3 GetCenter()  const;
    JoltVec3 GetExtent()  const;  ///< half-extents
    bool Contains(double x, double y, double z) const;
    bool Overlaps(const JoltAABox& other) const;
    void Encapsulate(double x, double y, double z);
};

// ---------------------------------------------------------------------------
// Collision group
// ---------------------------------------------------------------------------

/// Body collision group and sub-group IDs (no group filter = all collide).
struct JoltCollisionGroup {
    static constexpr unsigned int InvalidGroup    = 0xffffffff;
    static constexpr unsigned int InvalidSubGroup = 0xffffffff;
    unsigned int groupID    = 0xffffffff;
    unsigned int subGroupID = 0xffffffff;
    JoltCollisionGroup();
    JoltCollisionGroup(unsigned int groupID, unsigned int subGroupID);
};

// ---------------------------------------------------------------------------
// Physics material (non-owning read handle)
// ---------------------------------------------------------------------------

/// Non-owning handle to a JPH::PhysicsMaterial.
/// Obtain via JoltBodyInterface::GetMaterial(). Do not outlive the physics system.
struct JoltPhysicsMaterial {
    void* mPtr;  ///< JPH::PhysicsMaterial*; nullptr = default material
    JoltPhysicsMaterial();
    bool        IsValid()      const;
    const char* GetDebugName() const;
};

// ---------------------------------------------------------------------------
// Two-body constraint handle (non-owning)
// ---------------------------------------------------------------------------

/// Non-owning handle to a JPH::TwoBodyConstraint.
/// Obtain via JoltPhysicsSystem::GetConstraintHandle() or JoltBodyInterface::ActivateConstraint().
struct JoltTwoBodyConstraint {
    void* mPtr;  ///< JPH::TwoBodyConstraint*; nullptr = invalid
    JoltTwoBodyConstraint();
    bool IsValid()            const;
    bool GetEnabled()         const;
    void SetEnabled(bool enabled);
};

// ---------------------------------------------------------------------------
// Motion / activation / layer / body-type / motion-quality constants
// ---------------------------------------------------------------------------

/// JoltMotionType values (passed as int to API functions).
static const int JoltMotionType_Static    = 0;
static const int JoltMotionType_Kinematic = 1;
static const int JoltMotionType_Dynamic   = 2;

/// JoltActivation values (passed as int to API functions).
static const int JoltActivation_Activate     = 0;
static const int JoltActivation_DontActivate = 1;

/// JoltObjectLayer values (passed as unsigned int to API functions).
static const unsigned int JoltObjectLayer_NonMoving = 0;
static const unsigned int JoltObjectLayer_Moving    = 1;

/// JoltBodyType values (passed as int to API functions).
static const int JoltBodyType_RigidBody = 0;
static const int JoltBodyType_SoftBody  = 1;

/// JoltMotionQuality values (passed as int to API functions).
static const int JoltMotionQuality_Discrete   = 0;
static const int JoltMotionQuality_LinearCast = 1;

// ---------------------------------------------------------------------------
// Body ID
// ---------------------------------------------------------------------------

/// Opaque handle to a physics body.
struct JoltBodyID {
    unsigned int value;
    JoltBodyID();
    bool IsValid() const;
    bool IsInvalid() const;
};

// ---------------------------------------------------------------------------
// Body ID list (for batch add / remove operations)
// ---------------------------------------------------------------------------

/// Growable list of JoltBodyIDs. Used with batch add/remove on JoltBodyInterface.
struct JoltBodyIDList {
public:
    JoltBodyIDList();
    ~JoltBodyIDList();
    void     Add(JoltBodyID id);
    void     Clear();
    int      Count() const;
    JoltBodyID Get(int index) const;

    void* mData;  // points to internal std::vector; do not use directly
};

/// Opaque handle to a constraint.
struct JoltConstraintID {
    unsigned int value;
    JoltConstraintID();
    bool IsValid() const;
};

// ---------------------------------------------------------------------------
// BodyInterface — non-owning view into JoltPhysicsSystem's body interface.
// The JoltPhysicsSystem must outlive any JoltBodyInterface obtained from it.
// ---------------------------------------------------------------------------

struct JoltBodyCreationSettings;       // forward declaration — defined below
struct JoltShape;                      // forward declaration — defined below
struct JoltSoftBodyCreationSettings;   // forward declaration — defined below

/// Wraps JPH::BodyInterface. Obtain via JoltPhysicsSystem::GetBodyInterface().
struct JoltBodyInterface {
public:
    bool IsValid() const;

    // ---- Body lifetime -------------------------------------------------------

    /// Create a body but do not add it to the simulation yet.
    /// Returns an invalid ID when out of bodies.
    JoltBodyID CreateBody(JoltBodyCreationSettings* settings);

    /// Create a body with a specific ID (for deterministic/replicated simulations).
    /// Returns an invalid ID when the body ID is invalid or already in use.
    JoltBodyID CreateBodyWithID(JoltBodyID targetID, JoltBodyCreationSettings* settings);

    /// Create a body and immediately add it to the simulation.
    JoltBodyID CreateAndAddBody(JoltBodyCreationSettings* settings, int activation);

    void AddBody(JoltBodyID id, int activation);
    void RemoveBody(JoltBodyID id);

    /// Destroy a body that has already been removed from the simulation.
    void DestroyBody(JoltBodyID id);

    /// Remove and destroy in one call.
    void RemoveAndDestroyBody(JoltBodyID id);

    bool IsAdded(JoltBodyID id) const;

    // ---- Batch add / remove -------------------------------------------------

    /// Prepare adding bodies in batch; safe to call from a background thread.
    /// Returns an opaque state handle — pass to AddBodiesFinalize or AddBodiesAbort.
    /// The JoltBodyIDList must remain unmodified until Finalize/Abort is called.
    void* AddBodiesPrepare(JoltBodyIDList* bodies);

    /// Finalize a batch add; atomically inserts all bodies into the simulation.
    void AddBodiesFinalize(JoltBodyIDList* bodies, void* addState, int activation);

    /// Abort a prepared batch add without inserting bodies.
    void AddBodiesAbort(JoltBodyIDList* bodies, void* addState);

    /// Remove multiple bodies from the simulation in one call.
    void RemoveBodies(JoltBodyIDList* bodies);

    /// Destroy multiple bodies (must all be removed from the simulation first).
    void DestroyBodies(JoltBodyIDList* bodies);

    // ---- Shape ---------------------------------------------------------------

    /// Replace the shape on a body.
    /// updateMassProperties: recompute mass/inertia from new shape.
    void SetShape(JoltBodyID id, JoltShape* shape, bool updateMassProperties, int activation) const;

    /// Notify systems that a MutableCompoundShape was changed in-place.
    /// prevComX/Y/Z: center of mass before the change.
    void NotifyShapeChanged(JoltBodyID id,
                            double prevComX, double prevComY, double prevComZ,
                            bool updateMassProperties, int activation) const;

    // ---- Position / rotation -------------------------------------------------

    void     SetPosition(JoltBodyID id, double x, double y, double z, int activation);
    JoltVec3 GetPosition(JoltBodyID id) const;
    JoltVec3 GetCenterOfMassPosition(JoltBodyID id) const;
    void     SetRotation(JoltBodyID id, float qx, float qy, float qz, float qw, int activation);
    JoltQuat GetRotation(JoltBodyID id) const;
    void     GetPositionAndRotation(JoltBodyID id,
                                    JoltVec3& outPosition, JoltQuat& outRotation) const;
    void     SetPositionAndRotation(JoltBodyID id,
                                    double x, double y, double z,
                                    float qx, float qy, float qz, float qw,
                                    int activation);
    /// Like SetPositionAndRotation but only updates when the change is above a small threshold.
    void     SetPositionAndRotationWhenChanged(JoltBodyID id,
                                               double x, double y, double z,
                                               float qx, float qy, float qz, float qw,
                                               int activation);
    void     MoveKinematic(JoltBodyID id,
                           double x, double y, double z,
                           float qx, float qy, float qz, float qw,
                           float deltaTime);
    void     SetPositionRotationAndVelocity(JoltBodyID id,
                                            double x, double y, double z,
                                            float qx, float qy, float qz, float qw,
                                            float lvx, float lvy, float lvz,
                                            float avx, float avy, float avz);

    // ---- Velocity ------------------------------------------------------------

    void      SetLinearVelocity(JoltBodyID id, float vx, float vy, float vz);
    JoltVec3f GetLinearVelocity(JoltBodyID id) const;
    void      AddLinearVelocity(JoltBodyID id, float vx, float vy, float vz);
    void      SetAngularVelocity(JoltBodyID id, float vx, float vy, float vz);
    JoltVec3f GetAngularVelocity(JoltBodyID id) const;
    void      SetLinearAndAngularVelocity(JoltBodyID id,
                                          float lvx, float lvy, float lvz,
                                          float avx, float avy, float avz);
    void      GetLinearAndAngularVelocity(JoltBodyID id,
                                          JoltVec3f& outLinear,
                                          JoltVec3f& outAngular) const;
    void      AddLinearAndAngularVelocity(JoltBodyID id,
                                          float lvx, float lvy, float lvz,
                                          float avx, float avy, float avz);
    JoltVec3f GetPointVelocity(JoltBodyID id, double px, double py, double pz) const;

    // ---- Forces / impulses ---------------------------------------------------

    void AddForce(JoltBodyID id, float fx, float fy, float fz);
    void AddForceAtPosition(JoltBodyID id,
                            float fx, float fy, float fz,
                            double px, double py, double pz);
    void AddTorque(JoltBodyID id, float tx, float ty, float tz);
    void AddForceAndTorque(JoltBodyID id,
                           float fx, float fy, float fz,
                           float tx, float ty, float tz);
    void AddImpulse(JoltBodyID id, float ix, float iy, float iz);
    void AddImpulseAtPosition(JoltBodyID id,
                              float ix, float iy, float iz,
                              double px, double py, double pz);
    void AddAngularImpulse(JoltBodyID id, float ix, float iy, float iz);

    /// Apply a buoyancy impulse. Returns true when the body is in the fluid.
    /// surfaceNX/Y/Z: world-space surface normal pointing away from fluid.
    /// fluidVX/Y/Z: velocity of the fluid (usually zero for still water).
    /// gravX/Y/Z: gravity vector (e.g. 0,-9.81,0).
    bool ApplyBuoyancyImpulse(JoltBodyID id,
                               double surfacePosX, double surfacePosY, double surfacePosZ,
                               float surfaceNX, float surfaceNY, float surfaceNZ,
                               float buoyancy, float linearDrag, float angularDrag,
                               float fluidVX, float fluidVY, float fluidVZ,
                               float gravX, float gravY, float gravZ,
                               float deltaTime);

    // ---- Body properties -----------------------------------------------------

    /// Returns JoltBodyType_RigidBody or JoltBodyType_SoftBody.
    int  GetBodyType(JoltBodyID id) const;
    void SetMotionType(JoltBodyID id, int motionType, int activation);
    /// Returns JoltMotionType_*.
    int  GetMotionType(JoltBodyID id) const;
    void SetMotionQuality(JoltBodyID id, int motionQuality);
    /// Returns JoltMotionQuality_*.
    int  GetMotionQuality(JoltBodyID id) const;
    void         SetObjectLayer(JoltBodyID id, unsigned int layer);
    unsigned int GetObjectLayer(JoltBodyID id) const;
    void  SetFriction(JoltBodyID id, float friction);
    float GetFriction(JoltBodyID id) const;
    void  SetRestitution(JoltBodyID id, float restitution);
    float GetRestitution(JoltBodyID id) const;
    void  SetGravityFactor(JoltBodyID id, float factor);
    float GetGravityFactor(JoltBodyID id) const;
    void  SetMaxLinearVelocity(JoltBodyID id, float v);
    float GetMaxLinearVelocity(JoltBodyID id) const;
    void  SetMaxAngularVelocity(JoltBodyID id, float v);
    float GetMaxAngularVelocity(JoltBodyID id) const;
    void SetIsSensor(JoltBodyID id, bool isSensor);
    bool IsSensor(JoltBodyID id) const;
    void SetUseManifoldReduction(JoltBodyID id, bool useReduction);
    bool GetUseManifoldReduction(JoltBodyID id) const;
    unsigned long long GetUserData(JoltBodyID id) const;
    void               SetUserData(JoltBodyID id, unsigned long long userData);

    // ---- Activation ----------------------------------------------------------

    void ActivateBody(JoltBodyID id);
    void ActivateBodies(JoltBodyIDList* bodies);
    void DeactivateBody(JoltBodyID id);
    void DeactivateBodies(JoltBodyIDList* bodies);
    bool IsActive(JoltBodyID id) const;
    void ResetSleepTimer(JoltBodyID id);

    // ---- Misc ----------------------------------------------------------------

    void InvalidateContactCache(JoltBodyID id);

    // ---- Transforms ----------------------------------------------------------

    JoltRMat44 GetWorldTransform(JoltBodyID id) const;
    JoltRMat44 GetCenterOfMassTransform(JoltBodyID id) const;
    JoltMat44  GetInverseInertia(JoltBodyID id) const;

    // ---- Collision group -----------------------------------------------------

    void               SetCollisionGroup(JoltBodyID id, const JoltCollisionGroup& group);
    JoltCollisionGroup GetCollisionGroup(JoltBodyID id) const;

    // ---- Broad-phase activation -----------------------------------------------

    /// Activate all bodies whose bounding box overlaps box, across all object layers.
    void ActivateBodiesInAABox(const JoltAABox& box);

    // ---- Material ------------------------------------------------------------

    /// Get the material for the body's root sub-shape (works for simple, non-compound shapes).
    JoltPhysicsMaterial GetMaterial(JoltBodyID id) const;

    // ---- Constraints ---------------------------------------------------------

    /// Activate non-static bodies attached to a constraint.
    void ActivateConstraint(const JoltTwoBodyConstraint& constraint);

    // ---- Soft body -----------------------------------------------------------

    JoltBodyID CreateSoftBody(JoltSoftBodyCreationSettings* settings);
    JoltBodyID CreateAndAddSoftBody(JoltSoftBodyCreationSettings* settings, int activation);

private:
    void* mImpl;  // non-owning; points to JoltPhysicsSystem::Impl
    friend struct JoltPhysicsSystem;
    explicit JoltBodyInterface(void* impl);
};

// ---------------------------------------------------------------------------
// Shapes
// ---------------------------------------------------------------------------

/// Base class for all collision shapes.
/// Shapes are ref-counted; call Release() when you no longer need the handle.
struct JoltShape {
public:
    virtual ~JoltShape();
    void Release();
    bool IsValid() const;
    void* getHandle() const;
protected:
    void* mHandle;
    bool mOwning;
    JoltShape();
};

/// Axis-aligned box shape.
struct JoltBoxShape : public JoltShape {
public:
    JoltBoxShape(double halfX, double halfY, double halfZ,
                 float convexRadius);
    JoltBoxShape(double halfX, double halfY, double halfZ);
};

/// Sphere shape.
struct JoltSphereShape : public JoltShape {
public:
    JoltSphereShape(float radius);
};

/// Capsule shape (cylinder with hemispherical caps).  halfHeight is the
/// half-height of the cylinder part only (total body height = 2*(halfHeight+radius)).
struct JoltCapsuleShape : public JoltShape {
public:
    JoltCapsuleShape(float halfHeight, float radius);
};

/// Upright cylinder shape.
struct JoltCylinderShape : public JoltShape {
public:
    JoltCylinderShape(float halfHeight, float radius,
                      float convexRadius);
    JoltCylinderShape(float halfHeight, float radius);
};

/// A shape rotated and translated relative to a child shape.
struct JoltRotatedTranslatedShape : public JoltShape {
public:
    JoltRotatedTranslatedShape(JoltShape* inner,
                                double posX, double posY, double posZ,
                                float qx, float qy, float qz, float qw);
};

// ---------------------------------------------------------------------------
// Body creation settings
// ---------------------------------------------------------------------------

/// Parameters used when adding a body to the physics system.
struct JoltBodyCreationSettings {
public:
    /// Create settings for a body with the given shape.
    /// layer should be one of JoltObjectLayer values (0=NonMoving, 1=Moving).
    JoltBodyCreationSettings(JoltShape* shape,
                              double posX, double posY, double posZ,
                              float qx, float qy, float qz, float qw,
                              int motionType,
                              unsigned int objectLayer);

    /// Shorthand: identity rotation.
    JoltBodyCreationSettings(JoltShape* shape,
                              double posX, double posY, double posZ,
                              int motionType,
                              unsigned int objectLayer);

    ~JoltBodyCreationSettings();

    void SetPosition(double x, double y, double z);
    void SetRotation(float qx, float qy, float qz, float qw);
    void SetLinearVelocity(float vx, float vy, float vz);
    void SetAngularVelocity(float vx, float vy, float vz);
    void SetFriction(float f);
    void SetRestitution(float r);
    void SetGravityFactor(float f);
    void SetIsSensor(bool isSensor);
    void SetObjectLayer(unsigned int layer);

    void* mHandle;
};

// ---------------------------------------------------------------------------
// Soft body
// ---------------------------------------------------------------------------

/// Defines the mesh topology of a soft body: vertices, faces, edge constraints.
/// Shared (ref-counted) between multiple soft body instances.
/// Build order: AddVertex → AddFace → AddEdgeConstraint (or CalculateEdgeLengths) → Optimize.
struct JoltSoftBodySharedSettings {
public:
    JoltSoftBodySharedSettings();
    ~JoltSoftBodySharedSettings();

    /// Add a particle at (x,y,z). invMass=0 pins it (kinematic vertex).
    void AddVertex(float x, float y, float z, float invMass);

    /// Add a triangular face by vertex indices.
    void AddFace(unsigned int v0, unsigned int v1, unsigned int v2);

    /// Add an explicit edge-length spring between two vertices.
    /// compliance: 0 = perfectly rigid, larger = softer.
    /// restLength: target length; pass <=0 to auto-compute from current vertex positions.
    void AddEdgeConstraint(unsigned int v0, unsigned int v1,
                           float compliance, float restLength);

    /// Convenience: add edge with auto-computed rest length.
    void AddEdgeConstraintAuto(unsigned int v0, unsigned int v1, float compliance);

    /// Compute rest lengths for all edges whose mRestLength == 1.0 (the default).
    void CalculateEdgeLengths();

    /// Must be called once after building. Reorders constraints for parallel solving.
    void Optimize();

    int GetVertexCount() const;
    int GetFaceCount()   const;
    int GetEdgeCount()   const;

    void* mHandle;  ///< internal SBSSHandle*; do not use directly
};

/// Parameters for creating a soft body.
struct JoltSoftBodyCreationSettings {
public:
    JoltSoftBodyCreationSettings(JoltSoftBodySharedSettings* settings,
                                  double posX, double posY, double posZ,
                                  float qx, float qy, float qz, float qw,
                                  unsigned int objectLayer);

    /// Convenience: identity rotation.
    JoltSoftBodyCreationSettings(JoltSoftBodySharedSettings* settings,
                                  double posX, double posY, double posZ,
                                  unsigned int objectLayer);

    ~JoltSoftBodyCreationSettings();

    void SetPosition(double x, double y, double z);
    void SetRotation(float qx, float qy, float qz, float qw);
    void SetObjectLayer(unsigned int layer);
    void SetMakeRotationIdentity(bool v);  ///< bake rotation into verts for accuracy
    void SetNumIterations(unsigned int n); ///< position solver iterations (default 5)

    void* mHandle;  ///< internal SBCSHandle*; do not use directly
};

// ---------------------------------------------------------------------------
// Physics system
// ---------------------------------------------------------------------------

/// The main Jolt physics simulation. Manages a job system, temp allocator,
/// and the full PhysicsSystem internally. The Jolt library itself is
/// initialised automatically on first construction and cleaned up on last
/// destruction.
struct JoltPhysicsSystem {
public:
    /// Construct with default settings (65536 bodies, 65536 pairs,
    /// 65536 contacts, 2-layer NON_MOVING/MOVING setup).
    JoltPhysicsSystem();

    /// Construct with explicit capacities.
    JoltPhysicsSystem(unsigned int maxBodies,
                      unsigned int maxBodyPairs,
                      unsigned int maxContactConstraints);

    ~JoltPhysicsSystem();

    // ---- Simulation ----------------------------------------------------------

    void SetGravity(double x, double y, double z);
    JoltVec3 GetGravity() const;

    /// Advance the simulation. deltaTime is typically 1/60.
    /// collisionSteps: increase for fast-moving objects (normally 1).
    void Update(float deltaTime, int collisionSteps);

    /// Optimise the broad phase. Call after loading a static level before
    /// starting to simulate.
    void OptimizeBroadPhase();

    // ---- Body management -----------------------------------------------------

    /// Create a body from settings and add it to the simulation.
    JoltBodyID CreateAndAddBody(JoltBodyCreationSettings* settings,
                                int activation);

    /// Remove a body from the simulation (body data preserved, can re-add).
    void RemoveBody(JoltBodyID id);

    /// Permanently destroy a body. ID is invalid after this call.
    void DestroyBody(JoltBodyID id);

    /// Remove and destroy in one call.
    void RemoveAndDestroyBody(JoltBodyID id);

    // ---- Body queries --------------------------------------------------------

    JoltVec3  GetBodyPosition(JoltBodyID id) const;
    JoltQuat  GetBodyRotation(JoltBodyID id) const;
    JoltVec3f GetBodyLinearVelocity(JoltBodyID id) const;
    JoltVec3f GetBodyAngularVelocity(JoltBodyID id) const;
    bool      IsBodyActive(JoltBodyID id) const;

    // ---- Body control --------------------------------------------------------

    void SetBodyPosition(JoltBodyID id, double x, double y, double z,
                         int activation);
    void SetBodyRotation(JoltBodyID id,
                         float qx, float qy, float qz, float qw,
                         int activation);
    void SetBodyPositionAndRotation(JoltBodyID id,
                                    double x, double y, double z,
                                    float qx, float qy, float qz, float qw,
                                    int activation);
    void SetBodyLinearVelocity(JoltBodyID id,
                               float vx, float vy, float vz);
    void SetBodyAngularVelocity(JoltBodyID id,
                                float vx, float vy, float vz);
    void SetBodyLinearAndAngularVelocity(JoltBodyID id,
                                         float lvx, float lvy, float lvz,
                                         float avx, float avy, float avz);
    void AddForce(JoltBodyID id, float fx, float fy, float fz);
    void AddForceAtPosition(JoltBodyID id,
                            float fx, float fy, float fz,
                            double px, double py, double pz);
    void AddTorque(JoltBodyID id, float tx, float ty, float tz);
    void AddImpulse(JoltBodyID id, float ix, float iy, float iz);
    void AddAngularImpulse(JoltBodyID id, float ix, float iy, float iz);
    void ActivateBody(JoltBodyID id);
    void DeactivateBody(JoltBodyID id);

    // ---- Body properties -----------------------------------------------------

    void  SetFriction(JoltBodyID id, float friction);
    float GetFriction(JoltBodyID id) const;
    void  SetRestitution(JoltBodyID id, float restitution);
    float GetRestitution(JoltBodyID id) const;
    void  SetGravityFactor(JoltBodyID id, float factor);
    float GetGravityFactor(JoltBodyID id) const;

    // ---- Constraint helpers --------------------------------------------------

    /// Connect two bodies at fixed relative positions/orientations.
    JoltConstraintID AddFixedConstraint(JoltBodyID body1, JoltBodyID body2);

    /// Distance constraint: keep two bodies between [minDist, maxDist].
    JoltConstraintID AddDistanceConstraint(JoltBodyID body1, JoltBodyID body2,
                                            float minDist, float maxDist);

    /// Point constraint: two bodies share a common world-space pivot.
    JoltConstraintID AddPointConstraint(JoltBodyID body1, JoltBodyID body2,
                                         double pivotX, double pivotY, double pivotZ);

    /// Hinge constraint: bodies rotate about a shared axis.
    JoltConstraintID AddHingeConstraint(JoltBodyID body1, JoltBodyID body2,
                                         double pivotX, double pivotY, double pivotZ,
                                         float axisX, float axisY, float axisZ);

    /// Remove and destroy a constraint.
    void DestroyConstraint(JoltConstraintID id);

    /// Enable or disable an existing constraint.
    void SetConstraintEnabled(JoltConstraintID id, bool enabled);

    // ---- Soft body -----------------------------------------------------------

    JoltBodyID CreateAndAddSoftBody(JoltSoftBodyCreationSettings* settings, int activation);

    // ---- Constraint handle ---------------------------------------------------

    /// Get a non-owning handle to a constraint created via AddFixedConstraint etc.
    JoltTwoBodyConstraint GetConstraintHandle(JoltConstraintID id);

    // ---- Body interface accessor ---------------------------------------------

    /// Returns a non-owning handle to the body interface.
    /// The JoltPhysicsSystem must outlive the returned JoltBodyInterface.
    JoltBodyInterface GetBodyInterface();

    // ---- Statistics ----------------------------------------------------------

    unsigned int GetNumBodies() const;
    unsigned int GetNumActiveBodies() const;

    struct Impl;  // defined in jolt_helper.cpp; opaque outside that TU

private:
    Impl* mImpl;
};

// ---------------------------------------------------------------------------
// Convenience: JoltWorld kept for backward compatibility
// ---------------------------------------------------------------------------

/// Simplified wrapper kept for backward compatibility. Prefer JoltPhysicsSystem
/// for new code.
struct JoltWorld {
public:
    JoltWorld();
    ~JoltWorld();

    void SetGravity(double x, double y, double z);

    JoltBodyID AddStaticBox(double halfX, double halfY, double halfZ,
                             double posX, double posY, double posZ);

    JoltBodyID AddDynamicSphere(double radius,
                                 double posX, double posY, double posZ);

    void Update(double deltaTime);
    void OptimizeBroadPhase();

    JoltVec3 GetBodyPosition(JoltBodyID id) const;
    bool     IsBodyActive(JoltBodyID id) const;

    void RemoveBody(JoltBodyID id);
    void DestroyBody(JoltBodyID id);

private:
    struct Impl;
    Impl* mImpl;
};
