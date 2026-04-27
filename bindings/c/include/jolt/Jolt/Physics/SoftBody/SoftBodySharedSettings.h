// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_RefTarget_JPH_SoftBodySharedSettings JPH_RefTarget_JPH_SoftBodySharedSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.


/// Which type of bend constraint should be created
typedef enum JPH_SoftBodySharedSettings_EBendType
{
    ///< No bend constraints will be created
    JPH_SoftBodySharedSettings_EBendType_None = 0,
    ///< A simple distance constraint
    JPH_SoftBodySharedSettings_EBendType_Distance = 1,
    ///< A dihedral bend constraint (most expensive, but also supports triangles that are initially not in the same plane)
    JPH_SoftBodySharedSettings_EBendType_Dihedral = 2,
} JPH_SoftBodySharedSettings_EBendType;

/// The type of long range attachment constraint to create
typedef enum JPH_SoftBodySharedSettings_ELRAType
{
    ///< Don't create a LRA constraint
    JPH_SoftBodySharedSettings_ELRAType_None = 0,
    ///< Create a LRA constraint based on Euclidean distance between the closest kinematic vertex and this vertex
    JPH_SoftBodySharedSettings_ELRAType_EuclideanDistance = 1,
    ///< Create a LRA constraint based on the geodesic distance between the closest kinematic vertex and this vertex (follows the edge constraints)
    JPH_SoftBodySharedSettings_ELRAType_GeodesicDistance = 2,
} JPH_SoftBodySharedSettings_ELRAType;

/// Per vertex attributes used during the CreateConstraints function.
/// For an edge or shear constraint, the compliance is averaged between the two attached vertices.
/// For a bend constraint, the compliance is averaged between the two vertices on the shared edge.
/// Generated from class `JPH::SoftBodySharedSettings::VertexAttributes`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodySharedSettings_VertexAttributes JPH_SoftBodySharedSettings_VertexAttributes;

/// Information about the optimization of the soft body, the indices of certain elements may have changed.
/// Generated from class `JPH::SoftBodySharedSettings::OptimizationResults`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodySharedSettings_OptimizationResults JPH_SoftBodySharedSettings_OptimizationResults;

/// A vertex is a particle, the data in this structure is only used during creation of the soft body and not during simulation
/// Generated from class `JPH::SoftBodySharedSettings::Vertex`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodySharedSettings_Vertex JPH_SoftBodySharedSettings_Vertex;

/// A face defines the surface of the body
/// Generated from class `JPH::SoftBodySharedSettings::Face`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodySharedSettings_Face JPH_SoftBodySharedSettings_Face;

/// An edge keeps two vertices at a constant distance using a spring: |x1 - x2| = rest length
/// Generated from class `JPH::SoftBodySharedSettings::Edge`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodySharedSettings_Edge JPH_SoftBodySharedSettings_Edge;

/**
* A dihedral bend constraint keeps the angle between two triangles constant along their shared edge.
*
*        x2
*       /  \
*      / t0 \
*     x0----x1
*      \ t1 /
*       \  /
*        x3
*
* x0..x3 are the vertices, t0 and t1 are the triangles that share the edge x0..x1
*
* Based on:
* - "Position Based Dynamics" - Matthias Muller et al.
* - "Strain Based Dynamics" - Matthias Muller et al.
* - "Simulation of Clothing with Folds and Wrinkles" - R. Bridson et al.
*/
/// Generated from class `JPH::SoftBodySharedSettings::DihedralBend`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodySharedSettings_DihedralBend JPH_SoftBodySharedSettings_DihedralBend;

/// Volume constraint, keeps the volume of a tetrahedron constant
/// Generated from class `JPH::SoftBodySharedSettings::Volume`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodySharedSettings_Volume JPH_SoftBodySharedSettings_Volume;

/// An inverse bind matrix take a skinned vertex from its bind pose into joint local space
/// Generated from class `JPH::SoftBodySharedSettings::InvBind`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodySharedSettings_InvBind JPH_SoftBodySharedSettings_InvBind;

/// A joint and its skin weight
/// Generated from class `JPH::SoftBodySharedSettings::SkinWeight`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodySharedSettings_SkinWeight JPH_SoftBodySharedSettings_SkinWeight;

/// A constraint that skins a vertex to joints and limits the distance that the simulated vertex can travel from this vertex
/// Generated from class `JPH::SoftBodySharedSettings::Skinned`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodySharedSettings_Skinned JPH_SoftBodySharedSettings_Skinned;

/// A long range attachment constraint, this is a constraint that sets a max distance between a kinematic vertex and a dynamic vertex
/// See: "Long Range Attachments - A Method to Simulate Inextensible Clothing in Computer Games", Tae-Yong Kim, Nuttapong Chentanez and Matthias Mueller-Fischer
/// Generated from class `JPH::SoftBodySharedSettings::LRA`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodySharedSettings_LRA JPH_SoftBodySharedSettings_LRA;

/// A discrete Cosserat rod connects two particles with a rigid rod that has fixed length and inertia.
/// A rod can be used instead of an Edge to constraint two vertices. The orientation of the rod can be
/// used to orient geometry attached to the rod (e.g. a plant leaf). Note that each rod needs to be constrained
/// by at least one RodBendTwist constraint in order to constrain the rotation of the rod. If you don't do
/// this then the orientation is likely to rotate around the rod axis with constant velocity.
/// Based on "Position and Orientation Based Cosserat Rods" - Kugelstadt and Schoemer - SIGGRAPH 2016
/// See: https://www.researchgate.net/publication/325597548_Position_and_Orientation_Based_Cosserat_Rods
/// Generated from class `JPH::SoftBodySharedSettings::RodStretchShear`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodySharedSettings_RodStretchShear JPH_SoftBodySharedSettings_RodStretchShear;

/// A constraint that connects two Cosserat rods and limits bend and twist between the rods.
/// Generated from class `JPH::SoftBodySharedSettings::RodBendTwist`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodySharedSettings_RodBendTwist JPH_SoftBodySharedSettings_RodBendTwist;

/// This class defines the setup of all particles and their constraints.
/// It is used during the simulation and can be shared between multiple soft bodies.
/// Generated from class `JPH::SoftBodySharedSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::RefTarget<JPH::SoftBodySharedSettings>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SoftBodySharedSettings JPH_SoftBodySharedSettings;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodySharedSettings_DestroyArray()`.
/// Use `JPH_SoftBodySharedSettings_OffsetMutablePtr()` and `JPH_SoftBodySharedSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_OffsetPtr(const JPH_SoftBodySharedSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_OffsetMutablePtr(JPH_SoftBodySharedSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::SoftBodySharedSettings` to its base class `JPH::RefTarget<JPH::SoftBodySharedSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(const JPH_SoftBodySharedSettings *object);

/// Upcasts an instance of `JPH::SoftBodySharedSettings` to its base class `JPH::RefTarget<JPH::SoftBodySharedSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_MutableUpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(JPH_SoftBodySharedSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::SoftBodySharedSettings>` to a derived class `JPH::SoftBodySharedSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_StaticDowncastFrom_JPH_RefTarget_JPH_SoftBodySharedSettings(const JPH_RefTarget_JPH_SoftBodySharedSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::SoftBodySharedSettings>` to a derived class `JPH::SoftBodySharedSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_SoftBodySharedSettings(JPH_RefTarget_JPH_SoftBodySharedSettings *object);

/// Generated from constructor `JPH::SoftBodySharedSettings::SoftBodySharedSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SoftBodySharedSettings *_other);

/// Destroys a heap-allocated instance of `JPH_SoftBodySharedSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_Destroy(const JPH_SoftBodySharedSettings *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodySharedSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_DestroyArray(const JPH_SoftBodySharedSettings *_this);

/// Generated from method `JPH::SoftBodySharedSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_AssignFromAnother(JPH_SoftBodySharedSettings *_this, Jolt_PassBy _other_pass_by, JPH_SoftBodySharedSettings *_other);

/// Generated from method `JPH::SoftBodySharedSettings::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SoftBodySharedSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Automatically create constraints based on the faces of the soft body
/// @param inVertexAttributes A list of attributes for each vertex (1-on-1 with mVertices, note that if the list is smaller than mVertices the last element will be repeated). This defines the properties of the constraints that are created.
/// @param inVertexAttributesLength The length of inVertexAttributes
/// @param inBendType The type of bend constraint to create
/// @param inAngleTolerance Shear edges are created when two connected triangles form a quad (are roughly in the same plane and form a square with roughly 90 degree angles). This defines the tolerance (in radians).
/// Generated from method `JPH::SoftBodySharedSettings::CreateConstraints`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBendType` has a default argument: `EBendType::Distance`, pass a null pointer to use it.
/// Parameter `inAngleTolerance` has a default argument: `DegreesToRadians(8.0f)`, pass a null pointer to use it.
JOLT_API void JPH_SoftBodySharedSettings_CreateConstraints(JPH_SoftBodySharedSettings *_this, const JPH_SoftBodySharedSettings_VertexAttributes *inVertexAttributes, unsigned int inVertexAttributesLength, const JPH_SoftBodySharedSettings_EBendType *inBendType, const float *inAngleTolerance);

/// Calculate the initial lengths of all springs of the edges of this soft body (if you use CreateConstraint, this is already done)
/// Generated from method `JPH::SoftBodySharedSettings::CalculateEdgeLengths`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodySharedSettings_CalculateEdgeLengths(JPH_SoftBodySharedSettings *_this);

/// Calculate the properties of the rods
/// Note that this can swap mVertex of the RodStretchShear constraints if two rods are connected through a RodBendTwist constraint but point in opposite directions.
/// Generated from method `JPH::SoftBodySharedSettings::CalculateRodProperties`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodySharedSettings_CalculateRodProperties(JPH_SoftBodySharedSettings *_this);

/// Calculate the max lengths for the long range attachment constraints based on Euclidean distance (if you use CreateConstraints, this is already done)
/// @param inMaxDistanceMultiplier Multiplier for the max distance of the LRA constraint, e.g. 1.01 means the max distance is 1% longer than the calculated distance in the rest pose.
/// Generated from method `JPH::SoftBodySharedSettings::CalculateLRALengths`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMaxDistanceMultiplier` has a default argument: `1.0f`, pass a null pointer to use it.
JOLT_API void JPH_SoftBodySharedSettings_CalculateLRALengths(JPH_SoftBodySharedSettings *_this, const float *inMaxDistanceMultiplier);

/// Calculate the constants for the bend constraints (if you use CreateConstraints, this is already done)
/// Generated from method `JPH::SoftBodySharedSettings::CalculateBendConstraintConstants`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodySharedSettings_CalculateBendConstraintConstants(JPH_SoftBodySharedSettings *_this);

/// Calculates the initial volume of all tetrahedra of this soft body
/// Generated from method `JPH::SoftBodySharedSettings::CalculateVolumeConstraintVolumes`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodySharedSettings_CalculateVolumeConstraintVolumes(JPH_SoftBodySharedSettings *_this);

/// Calculate information needed to be able to calculate the skinned constraint normals at run-time
/// Generated from method `JPH::SoftBodySharedSettings::CalculateSkinnedConstraintNormals`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodySharedSettings_CalculateSkinnedConstraintNormals(JPH_SoftBodySharedSettings *_this);

/// Optimize the soft body settings for simulation. This will reorder constraints so they can be executed in parallel.
/// Generated from method `JPH::SoftBodySharedSettings::Optimize`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outResults` can not be null. It is a single object.
JOLT_API void JPH_SoftBodySharedSettings_Optimize_1(JPH_SoftBodySharedSettings *_this, JPH_SoftBodySharedSettings_OptimizationResults *outResults);

/// Optimize the soft body settings without results
/// Generated from method `JPH::SoftBodySharedSettings::Optimize`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodySharedSettings_Optimize_0(JPH_SoftBodySharedSettings *_this);

/// Add a face to this soft body
/// Generated from method `JPH::SoftBodySharedSettings::AddFace`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inFace` can not be null. It is a single object.
JOLT_API void JPH_SoftBodySharedSettings_AddFace(JPH_SoftBodySharedSettings *_this, const JPH_SoftBodySharedSettings_Face *inFace);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::SoftBodySharedSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodySharedSettings_SetEmbedded(const JPH_SoftBodySharedSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::SoftBodySharedSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodySharedSettings_GetRefCount(const JPH_SoftBodySharedSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::SoftBodySharedSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodySharedSettings_AddRef(const JPH_SoftBodySharedSettings *_this);

/// Generated from method `JPH::SoftBodySharedSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodySharedSettings_Release(const JPH_SoftBodySharedSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::SoftBodySharedSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_SoftBodySharedSettings_sInternalGetRefCountOffset(void);

///< The compliance of the normal edges. Set to FLT_MAX to disable regular edges for any edge involving this vertex.
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::VertexAttributes` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_VertexAttributes_Get_mCompliance(const JPH_SoftBodySharedSettings_VertexAttributes *_this);

///< The compliance of the normal edges. Set to FLT_MAX to disable regular edges for any edge involving this vertex.
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::VertexAttributes` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCompliance`.
JOLT_API void JPH_SoftBodySharedSettings_VertexAttributes_Set_mCompliance(JPH_SoftBodySharedSettings_VertexAttributes *_this, float value);

///< The compliance of the normal edges. Set to FLT_MAX to disable regular edges for any edge involving this vertex.
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::VertexAttributes` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mCompliance(JPH_SoftBodySharedSettings_VertexAttributes *_this);

///< The compliance of the shear edges. Set to FLT_MAX to disable shear edges for any edge involving this vertex.
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::VertexAttributes` named `mShearCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_VertexAttributes_Get_mShearCompliance(const JPH_SoftBodySharedSettings_VertexAttributes *_this);

///< The compliance of the shear edges. Set to FLT_MAX to disable shear edges for any edge involving this vertex.
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::VertexAttributes` named `mShearCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mShearCompliance`.
JOLT_API void JPH_SoftBodySharedSettings_VertexAttributes_Set_mShearCompliance(JPH_SoftBodySharedSettings_VertexAttributes *_this, float value);

///< The compliance of the shear edges. Set to FLT_MAX to disable shear edges for any edge involving this vertex.
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::VertexAttributes` named `mShearCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mShearCompliance(JPH_SoftBodySharedSettings_VertexAttributes *_this);

///< The compliance of the bend edges. Set to FLT_MAX to disable bend edges for any bend constraint involving this vertex.
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::VertexAttributes` named `mBendCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_VertexAttributes_Get_mBendCompliance(const JPH_SoftBodySharedSettings_VertexAttributes *_this);

///< The compliance of the bend edges. Set to FLT_MAX to disable bend edges for any bend constraint involving this vertex.
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::VertexAttributes` named `mBendCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mBendCompliance`.
JOLT_API void JPH_SoftBodySharedSettings_VertexAttributes_Set_mBendCompliance(JPH_SoftBodySharedSettings_VertexAttributes *_this, float value);

///< The compliance of the bend edges. Set to FLT_MAX to disable bend edges for any bend constraint involving this vertex.
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::VertexAttributes` named `mBendCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mBendCompliance(JPH_SoftBodySharedSettings_VertexAttributes *_this);

///< The type of long range attachment constraint to create.
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::VertexAttributes` named `mLRAType`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SoftBodySharedSettings_ELRAType *JPH_SoftBodySharedSettings_VertexAttributes_Get_mLRAType(const JPH_SoftBodySharedSettings_VertexAttributes *_this);

///< The type of long range attachment constraint to create.
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::VertexAttributes` named `mLRAType`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mLRAType`.
/// When this function is called, this object will drop object references it held previously in `mLRAType`.
JOLT_API void JPH_SoftBodySharedSettings_VertexAttributes_Set_mLRAType(JPH_SoftBodySharedSettings_VertexAttributes *_this, JPH_SoftBodySharedSettings_ELRAType value);

///< The type of long range attachment constraint to create.
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::VertexAttributes` named `mLRAType`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SoftBodySharedSettings_ELRAType *JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mLRAType(JPH_SoftBodySharedSettings_VertexAttributes *_this);

///< Multiplier for the max distance of the LRA constraint, e.g. 1.01 means the max distance is 1% longer than the calculated distance in the rest pose.
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::VertexAttributes` named `mLRAMaxDistanceMultiplier`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_VertexAttributes_Get_mLRAMaxDistanceMultiplier(const JPH_SoftBodySharedSettings_VertexAttributes *_this);

///< Multiplier for the max distance of the LRA constraint, e.g. 1.01 means the max distance is 1% longer than the calculated distance in the rest pose.
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::VertexAttributes` named `mLRAMaxDistanceMultiplier`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLRAMaxDistanceMultiplier`.
JOLT_API void JPH_SoftBodySharedSettings_VertexAttributes_Set_mLRAMaxDistanceMultiplier(JPH_SoftBodySharedSettings_VertexAttributes *_this, float value);

///< Multiplier for the max distance of the LRA constraint, e.g. 1.01 means the max distance is 1% longer than the calculated distance in the rest pose.
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::VertexAttributes` named `mLRAMaxDistanceMultiplier`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mLRAMaxDistanceMultiplier(JPH_SoftBodySharedSettings_VertexAttributes *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_VertexAttributes_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_VertexAttributes *JPH_SoftBodySharedSettings_VertexAttributes_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodySharedSettings_VertexAttributes_DestroyArray()`.
/// Use `JPH_SoftBodySharedSettings_VertexAttributes_OffsetMutablePtr()` and `JPH_SoftBodySharedSettings_VertexAttributes_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodySharedSettings_VertexAttributes *JPH_SoftBodySharedSettings_VertexAttributes_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodySharedSettings_VertexAttributes *JPH_SoftBodySharedSettings_VertexAttributes_OffsetPtr(const JPH_SoftBodySharedSettings_VertexAttributes *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodySharedSettings_VertexAttributes *JPH_SoftBodySharedSettings_VertexAttributes_OffsetMutablePtr(JPH_SoftBodySharedSettings_VertexAttributes *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodySharedSettings::VertexAttributes::VertexAttributes`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_VertexAttributes_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_VertexAttributes *JPH_SoftBodySharedSettings_VertexAttributes_ConstructFromAnother(const JPH_SoftBodySharedSettings_VertexAttributes *_other);

/// Generated from constructor `JPH::SoftBodySharedSettings::VertexAttributes::VertexAttributes`.
/// Parameter `inLRAType` has a default argument: `ELRAType::None`, pass a null pointer to use it.
/// Parameter `inLRAMaxDistanceMultiplier` has a default argument: `1.0f`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_VertexAttributes_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_VertexAttributes *JPH_SoftBodySharedSettings_VertexAttributes_Construct(float inCompliance, float inShearCompliance, float inBendCompliance, const JPH_SoftBodySharedSettings_ELRAType *inLRAType, const float *inLRAMaxDistanceMultiplier);

/// Destroys a heap-allocated instance of `JPH_SoftBodySharedSettings_VertexAttributes`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_VertexAttributes_Destroy(const JPH_SoftBodySharedSettings_VertexAttributes *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodySharedSettings_VertexAttributes`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_VertexAttributes_DestroyArray(const JPH_SoftBodySharedSettings_VertexAttributes *_this);

/// Generated from method `JPH::SoftBodySharedSettings::VertexAttributes::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodySharedSettings_VertexAttributes *JPH_SoftBodySharedSettings_VertexAttributes_AssignFromAnother(JPH_SoftBodySharedSettings_VertexAttributes *_this, const JPH_SoftBodySharedSettings_VertexAttributes *_other);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_OptimizationResults_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_OptimizationResults *JPH_SoftBodySharedSettings_OptimizationResults_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodySharedSettings_OptimizationResults_DestroyArray()`.
/// Use `JPH_SoftBodySharedSettings_OptimizationResults_OffsetMutablePtr()` and `JPH_SoftBodySharedSettings_OptimizationResults_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodySharedSettings_OptimizationResults *JPH_SoftBodySharedSettings_OptimizationResults_DefaultConstructArray(size_t num_elems);

/// Generated from constructor `JPH::SoftBodySharedSettings::OptimizationResults::OptimizationResults`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_OptimizationResults_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_OptimizationResults *JPH_SoftBodySharedSettings_OptimizationResults_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SoftBodySharedSettings_OptimizationResults *_other);

/// Destroys a heap-allocated instance of `JPH_SoftBodySharedSettings_OptimizationResults`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_OptimizationResults_Destroy(const JPH_SoftBodySharedSettings_OptimizationResults *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodySharedSettings_OptimizationResults`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_OptimizationResults_DestroyArray(const JPH_SoftBodySharedSettings_OptimizationResults *_this);

/// Generated from method `JPH::SoftBodySharedSettings::OptimizationResults::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodySharedSettings_OptimizationResults *JPH_SoftBodySharedSettings_OptimizationResults_AssignFromAnother(JPH_SoftBodySharedSettings_OptimizationResults *_this, Jolt_PassBy _other_pass_by, JPH_SoftBodySharedSettings_OptimizationResults *_other);

///< Initial inverse of the mass of the vertex
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Vertex` named `mInvMass`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_Vertex_Get_mInvMass(const JPH_SoftBodySharedSettings_Vertex *_this);

///< Initial inverse of the mass of the vertex
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::Vertex` named `mInvMass`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInvMass`.
JOLT_API void JPH_SoftBodySharedSettings_Vertex_Set_mInvMass(JPH_SoftBodySharedSettings_Vertex *_this, float value);

///< Initial inverse of the mass of the vertex
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::Vertex` named `mInvMass`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_Vertex_GetMutable_mInvMass(JPH_SoftBodySharedSettings_Vertex *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Vertex_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_Vertex *JPH_SoftBodySharedSettings_Vertex_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodySharedSettings_Vertex_DestroyArray()`.
/// Use `JPH_SoftBodySharedSettings_Vertex_OffsetMutablePtr()` and `JPH_SoftBodySharedSettings_Vertex_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodySharedSettings_Vertex *JPH_SoftBodySharedSettings_Vertex_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodySharedSettings_Vertex *JPH_SoftBodySharedSettings_Vertex_OffsetPtr(const JPH_SoftBodySharedSettings_Vertex *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodySharedSettings_Vertex *JPH_SoftBodySharedSettings_Vertex_OffsetMutablePtr(JPH_SoftBodySharedSettings_Vertex *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodySharedSettings::Vertex::Vertex`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Vertex_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_Vertex *JPH_SoftBodySharedSettings_Vertex_ConstructFromAnother(const JPH_SoftBodySharedSettings_Vertex *_other);

/// Destroys a heap-allocated instance of `JPH_SoftBodySharedSettings_Vertex`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_Vertex_Destroy(const JPH_SoftBodySharedSettings_Vertex *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodySharedSettings_Vertex`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_Vertex_DestroyArray(const JPH_SoftBodySharedSettings_Vertex *_this);

/// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodySharedSettings_Vertex *JPH_SoftBodySharedSettings_Vertex_AssignFromAnother(JPH_SoftBodySharedSettings_Vertex *_this, const JPH_SoftBodySharedSettings_Vertex *_other);

/// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_Vertex_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_Vertex_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_Vertex_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_Vertex_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr_void_ptr(void *inPointer, void *inPlace);

///< Indices of the vertices that form the face
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Face` named `mVertex`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SoftBodySharedSettings_Face_Get_mVertex(const JPH_SoftBodySharedSettings_Face *_this);

///< Indices of the vertices that form the face
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::Face` named `mVertex`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SoftBodySharedSettings_Face_GetMutable_mVertex(JPH_SoftBodySharedSettings_Face *_this);

/// Returns the size of the array member of class `JPH::SoftBodySharedSettings::Face` named `mVertex`. The size is `3`.
JOLT_API size_t JPH_SoftBodySharedSettings_Face_GetSize_mVertex(void);

///< Index of the material of the face in SoftBodySharedSettings::mMaterials
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Face` named `mMaterialIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SoftBodySharedSettings_Face_Get_mMaterialIndex(const JPH_SoftBodySharedSettings_Face *_this);

///< Index of the material of the face in SoftBodySharedSettings::mMaterials
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::Face` named `mMaterialIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mMaterialIndex`.
/// When this function is called, this object will drop object references it held previously in `mMaterialIndex`.
JOLT_API void JPH_SoftBodySharedSettings_Face_Set_mMaterialIndex(JPH_SoftBodySharedSettings_Face *_this, unsigned int value);

///< Index of the material of the face in SoftBodySharedSettings::mMaterials
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::Face` named `mMaterialIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SoftBodySharedSettings_Face_GetMutable_mMaterialIndex(JPH_SoftBodySharedSettings_Face *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Face_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_Face *JPH_SoftBodySharedSettings_Face_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodySharedSettings_Face_DestroyArray()`.
/// Use `JPH_SoftBodySharedSettings_Face_OffsetMutablePtr()` and `JPH_SoftBodySharedSettings_Face_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodySharedSettings_Face *JPH_SoftBodySharedSettings_Face_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodySharedSettings_Face *JPH_SoftBodySharedSettings_Face_OffsetPtr(const JPH_SoftBodySharedSettings_Face *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodySharedSettings_Face *JPH_SoftBodySharedSettings_Face_OffsetMutablePtr(JPH_SoftBodySharedSettings_Face *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodySharedSettings::Face::Face`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Face_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_Face *JPH_SoftBodySharedSettings_Face_ConstructFromAnother(const JPH_SoftBodySharedSettings_Face *_other);

/// Generated from constructor `JPH::SoftBodySharedSettings::Face::Face`.
/// Parameter `inMaterialIndex` has a default argument: `0`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Face_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_Face *JPH_SoftBodySharedSettings_Face_Construct(unsigned int inVertex1, unsigned int inVertex2, unsigned int inVertex3, const unsigned int *inMaterialIndex);

/// Destroys a heap-allocated instance of `JPH_SoftBodySharedSettings_Face`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_Face_Destroy(const JPH_SoftBodySharedSettings_Face *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodySharedSettings_Face`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_Face_DestroyArray(const JPH_SoftBodySharedSettings_Face *_this);

/// Generated from method `JPH::SoftBodySharedSettings::Face::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodySharedSettings_Face *JPH_SoftBodySharedSettings_Face_AssignFromAnother(JPH_SoftBodySharedSettings_Face *_this, const JPH_SoftBodySharedSettings_Face *_other);

/// Generated from method `JPH::SoftBodySharedSettings::Face::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_Face_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::Face::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Face::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::Face::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_Face_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::Face::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Face::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::Face::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_Face_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Face::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SoftBodySharedSettings::Face::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_Face_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Face::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Check if this is a degenerate face (a face which points to the same vertex twice)
/// Generated from method `JPH::SoftBodySharedSettings::Face::IsDegenerate`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SoftBodySharedSettings_Face_IsDegenerate(const JPH_SoftBodySharedSettings_Face *_this);

///< Indices of the vertices that form the edge
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Edge` named `mVertex`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SoftBodySharedSettings_Edge_Get_mVertex(const JPH_SoftBodySharedSettings_Edge *_this);

///< Indices of the vertices that form the edge
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::Edge` named `mVertex`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SoftBodySharedSettings_Edge_GetMutable_mVertex(JPH_SoftBodySharedSettings_Edge *_this);

/// Returns the size of the array member of class `JPH::SoftBodySharedSettings::Edge` named `mVertex`. The size is `2`.
JOLT_API size_t JPH_SoftBodySharedSettings_Edge_GetSize_mVertex(void);

///< Rest length of the spring, calculated by CalculateEdgeLengths
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Edge` named `mRestLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_Edge_Get_mRestLength(const JPH_SoftBodySharedSettings_Edge *_this);

///< Rest length of the spring, calculated by CalculateEdgeLengths
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::Edge` named `mRestLength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mRestLength`.
JOLT_API void JPH_SoftBodySharedSettings_Edge_Set_mRestLength(JPH_SoftBodySharedSettings_Edge *_this, float value);

///< Rest length of the spring, calculated by CalculateEdgeLengths
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::Edge` named `mRestLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_Edge_GetMutable_mRestLength(JPH_SoftBodySharedSettings_Edge *_this);

///< Inverse of the stiffness of the spring
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Edge` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_Edge_Get_mCompliance(const JPH_SoftBodySharedSettings_Edge *_this);

///< Inverse of the stiffness of the spring
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::Edge` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCompliance`.
JOLT_API void JPH_SoftBodySharedSettings_Edge_Set_mCompliance(JPH_SoftBodySharedSettings_Edge *_this, float value);

///< Inverse of the stiffness of the spring
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::Edge` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_Edge_GetMutable_mCompliance(JPH_SoftBodySharedSettings_Edge *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Edge_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_Edge *JPH_SoftBodySharedSettings_Edge_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodySharedSettings_Edge_DestroyArray()`.
/// Use `JPH_SoftBodySharedSettings_Edge_OffsetMutablePtr()` and `JPH_SoftBodySharedSettings_Edge_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodySharedSettings_Edge *JPH_SoftBodySharedSettings_Edge_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodySharedSettings_Edge *JPH_SoftBodySharedSettings_Edge_OffsetPtr(const JPH_SoftBodySharedSettings_Edge *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodySharedSettings_Edge *JPH_SoftBodySharedSettings_Edge_OffsetMutablePtr(JPH_SoftBodySharedSettings_Edge *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodySharedSettings::Edge::Edge`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Edge_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_Edge *JPH_SoftBodySharedSettings_Edge_ConstructFromAnother(const JPH_SoftBodySharedSettings_Edge *_other);

/// Generated from constructor `JPH::SoftBodySharedSettings::Edge::Edge`.
/// Parameter `inCompliance` has a default argument: `0.0f`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Edge_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_Edge *JPH_SoftBodySharedSettings_Edge_Construct(unsigned int inVertex1, unsigned int inVertex2, const float *inCompliance);

/// Destroys a heap-allocated instance of `JPH_SoftBodySharedSettings_Edge`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_Edge_Destroy(const JPH_SoftBodySharedSettings_Edge *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodySharedSettings_Edge`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_Edge_DestroyArray(const JPH_SoftBodySharedSettings_Edge *_this);

/// Generated from method `JPH::SoftBodySharedSettings::Edge::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodySharedSettings_Edge *JPH_SoftBodySharedSettings_Edge_AssignFromAnother(JPH_SoftBodySharedSettings_Edge *_this, const JPH_SoftBodySharedSettings_Edge *_other);

/// Generated from method `JPH::SoftBodySharedSettings::Edge::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_Edge_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::Edge::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Edge::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::Edge::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_Edge_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::Edge::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Edge::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::Edge::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_Edge_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Edge::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SoftBodySharedSettings::Edge::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_Edge_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Edge::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Return the lowest vertex index of this constraint
/// Generated from method `JPH::SoftBodySharedSettings::Edge::GetMinVertexIndex`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodySharedSettings_Edge_GetMinVertexIndex(const JPH_SoftBodySharedSettings_Edge *_this);

///< Indices of the vertices of the 2 triangles that share an edge (the first 2 vertices are the shared edge)
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::DihedralBend` named `mVertex`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SoftBodySharedSettings_DihedralBend_Get_mVertex(const JPH_SoftBodySharedSettings_DihedralBend *_this);

///< Indices of the vertices of the 2 triangles that share an edge (the first 2 vertices are the shared edge)
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::DihedralBend` named `mVertex`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mVertex(JPH_SoftBodySharedSettings_DihedralBend *_this);

/// Returns the size of the array member of class `JPH::SoftBodySharedSettings::DihedralBend` named `mVertex`. The size is `4`.
JOLT_API size_t JPH_SoftBodySharedSettings_DihedralBend_GetSize_mVertex(void);

///< Inverse of the stiffness of the constraint
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::DihedralBend` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_DihedralBend_Get_mCompliance(const JPH_SoftBodySharedSettings_DihedralBend *_this);

///< Inverse of the stiffness of the constraint
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::DihedralBend` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCompliance`.
JOLT_API void JPH_SoftBodySharedSettings_DihedralBend_Set_mCompliance(JPH_SoftBodySharedSettings_DihedralBend *_this, float value);

///< Inverse of the stiffness of the constraint
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::DihedralBend` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mCompliance(JPH_SoftBodySharedSettings_DihedralBend *_this);

///< Initial angle between the normals of the triangles (pi - dihedral angle), calculated by CalculateBendConstraintConstants
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::DihedralBend` named `mInitialAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_DihedralBend_Get_mInitialAngle(const JPH_SoftBodySharedSettings_DihedralBend *_this);

///< Initial angle between the normals of the triangles (pi - dihedral angle), calculated by CalculateBendConstraintConstants
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::DihedralBend` named `mInitialAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInitialAngle`.
JOLT_API void JPH_SoftBodySharedSettings_DihedralBend_Set_mInitialAngle(JPH_SoftBodySharedSettings_DihedralBend *_this, float value);

///< Initial angle between the normals of the triangles (pi - dihedral angle), calculated by CalculateBendConstraintConstants
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::DihedralBend` named `mInitialAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mInitialAngle(JPH_SoftBodySharedSettings_DihedralBend *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_DihedralBend_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_DihedralBend *JPH_SoftBodySharedSettings_DihedralBend_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodySharedSettings_DihedralBend_DestroyArray()`.
/// Use `JPH_SoftBodySharedSettings_DihedralBend_OffsetMutablePtr()` and `JPH_SoftBodySharedSettings_DihedralBend_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodySharedSettings_DihedralBend *JPH_SoftBodySharedSettings_DihedralBend_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodySharedSettings_DihedralBend *JPH_SoftBodySharedSettings_DihedralBend_OffsetPtr(const JPH_SoftBodySharedSettings_DihedralBend *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodySharedSettings_DihedralBend *JPH_SoftBodySharedSettings_DihedralBend_OffsetMutablePtr(JPH_SoftBodySharedSettings_DihedralBend *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodySharedSettings::DihedralBend::DihedralBend`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_DihedralBend_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_DihedralBend *JPH_SoftBodySharedSettings_DihedralBend_ConstructFromAnother(const JPH_SoftBodySharedSettings_DihedralBend *_other);

/// Generated from constructor `JPH::SoftBodySharedSettings::DihedralBend::DihedralBend`.
/// Parameter `inCompliance` has a default argument: `0.0f`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_DihedralBend_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_DihedralBend *JPH_SoftBodySharedSettings_DihedralBend_Construct(unsigned int inVertex1, unsigned int inVertex2, unsigned int inVertex3, unsigned int inVertex4, const float *inCompliance);

/// Destroys a heap-allocated instance of `JPH_SoftBodySharedSettings_DihedralBend`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_DihedralBend_Destroy(const JPH_SoftBodySharedSettings_DihedralBend *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodySharedSettings_DihedralBend`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_DihedralBend_DestroyArray(const JPH_SoftBodySharedSettings_DihedralBend *_this);

/// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodySharedSettings_DihedralBend *JPH_SoftBodySharedSettings_DihedralBend_AssignFromAnother(JPH_SoftBodySharedSettings_DihedralBend *_this, const JPH_SoftBodySharedSettings_DihedralBend *_other);

/// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_DihedralBend_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_DihedralBend_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_DihedralBend_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_DihedralBend_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Return the lowest vertex index of this constraint
/// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::GetMinVertexIndex`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodySharedSettings_DihedralBend_GetMinVertexIndex(const JPH_SoftBodySharedSettings_DihedralBend *_this);

///< Indices of the vertices that form the tetrahedron
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Volume` named `mVertex`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SoftBodySharedSettings_Volume_Get_mVertex(const JPH_SoftBodySharedSettings_Volume *_this);

///< Indices of the vertices that form the tetrahedron
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::Volume` named `mVertex`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SoftBodySharedSettings_Volume_GetMutable_mVertex(JPH_SoftBodySharedSettings_Volume *_this);

/// Returns the size of the array member of class `JPH::SoftBodySharedSettings::Volume` named `mVertex`. The size is `4`.
JOLT_API size_t JPH_SoftBodySharedSettings_Volume_GetSize_mVertex(void);

///< 6 times the rest volume of the tetrahedron, calculated by CalculateVolumeConstraintVolumes
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Volume` named `mSixRestVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_Volume_Get_mSixRestVolume(const JPH_SoftBodySharedSettings_Volume *_this);

///< 6 times the rest volume of the tetrahedron, calculated by CalculateVolumeConstraintVolumes
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::Volume` named `mSixRestVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mSixRestVolume`.
JOLT_API void JPH_SoftBodySharedSettings_Volume_Set_mSixRestVolume(JPH_SoftBodySharedSettings_Volume *_this, float value);

///< 6 times the rest volume of the tetrahedron, calculated by CalculateVolumeConstraintVolumes
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::Volume` named `mSixRestVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_Volume_GetMutable_mSixRestVolume(JPH_SoftBodySharedSettings_Volume *_this);

///< Inverse of the stiffness of the constraint
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Volume` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_Volume_Get_mCompliance(const JPH_SoftBodySharedSettings_Volume *_this);

///< Inverse of the stiffness of the constraint
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::Volume` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCompliance`.
JOLT_API void JPH_SoftBodySharedSettings_Volume_Set_mCompliance(JPH_SoftBodySharedSettings_Volume *_this, float value);

///< Inverse of the stiffness of the constraint
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::Volume` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_Volume_GetMutable_mCompliance(JPH_SoftBodySharedSettings_Volume *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Volume_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_Volume *JPH_SoftBodySharedSettings_Volume_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodySharedSettings_Volume_DestroyArray()`.
/// Use `JPH_SoftBodySharedSettings_Volume_OffsetMutablePtr()` and `JPH_SoftBodySharedSettings_Volume_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodySharedSettings_Volume *JPH_SoftBodySharedSettings_Volume_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodySharedSettings_Volume *JPH_SoftBodySharedSettings_Volume_OffsetPtr(const JPH_SoftBodySharedSettings_Volume *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodySharedSettings_Volume *JPH_SoftBodySharedSettings_Volume_OffsetMutablePtr(JPH_SoftBodySharedSettings_Volume *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodySharedSettings::Volume::Volume`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Volume_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_Volume *JPH_SoftBodySharedSettings_Volume_ConstructFromAnother(const JPH_SoftBodySharedSettings_Volume *_other);

/// Generated from constructor `JPH::SoftBodySharedSettings::Volume::Volume`.
/// Parameter `inCompliance` has a default argument: `0.0f`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Volume_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_Volume *JPH_SoftBodySharedSettings_Volume_Construct(unsigned int inVertex1, unsigned int inVertex2, unsigned int inVertex3, unsigned int inVertex4, const float *inCompliance);

/// Destroys a heap-allocated instance of `JPH_SoftBodySharedSettings_Volume`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_Volume_Destroy(const JPH_SoftBodySharedSettings_Volume *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodySharedSettings_Volume`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_Volume_DestroyArray(const JPH_SoftBodySharedSettings_Volume *_this);

/// Generated from method `JPH::SoftBodySharedSettings::Volume::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodySharedSettings_Volume *JPH_SoftBodySharedSettings_Volume_AssignFromAnother(JPH_SoftBodySharedSettings_Volume *_this, const JPH_SoftBodySharedSettings_Volume *_other);

/// Generated from method `JPH::SoftBodySharedSettings::Volume::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_Volume_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::Volume::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Volume::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::Volume::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_Volume_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::Volume::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Volume::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::Volume::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_Volume_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Volume::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SoftBodySharedSettings::Volume::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_Volume_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Volume::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Return the lowest vertex index of this constraint
/// Generated from method `JPH::SoftBodySharedSettings::Volume::GetMinVertexIndex`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodySharedSettings_Volume_GetMinVertexIndex(const JPH_SoftBodySharedSettings_Volume *_this);

///< Joint index to which this is attached
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::InvBind` named `mJointIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SoftBodySharedSettings_InvBind_Get_mJointIndex(const JPH_SoftBodySharedSettings_InvBind *_this);

///< Joint index to which this is attached
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::InvBind` named `mJointIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mJointIndex`.
/// When this function is called, this object will drop object references it held previously in `mJointIndex`.
JOLT_API void JPH_SoftBodySharedSettings_InvBind_Set_mJointIndex(JPH_SoftBodySharedSettings_InvBind *_this, unsigned int value);

///< Joint index to which this is attached
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::InvBind` named `mJointIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SoftBodySharedSettings_InvBind_GetMutable_mJointIndex(JPH_SoftBodySharedSettings_InvBind *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_InvBind_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_InvBind *JPH_SoftBodySharedSettings_InvBind_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodySharedSettings_InvBind_DestroyArray()`.
/// Use `JPH_SoftBodySharedSettings_InvBind_OffsetMutablePtr()` and `JPH_SoftBodySharedSettings_InvBind_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodySharedSettings_InvBind *JPH_SoftBodySharedSettings_InvBind_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodySharedSettings_InvBind *JPH_SoftBodySharedSettings_InvBind_OffsetPtr(const JPH_SoftBodySharedSettings_InvBind *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodySharedSettings_InvBind *JPH_SoftBodySharedSettings_InvBind_OffsetMutablePtr(JPH_SoftBodySharedSettings_InvBind *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodySharedSettings::InvBind::InvBind`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_InvBind_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_InvBind *JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother(const JPH_SoftBodySharedSettings_InvBind *_other);

/// Destroys a heap-allocated instance of `JPH_SoftBodySharedSettings_InvBind`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_InvBind_Destroy(const JPH_SoftBodySharedSettings_InvBind *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodySharedSettings_InvBind`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_InvBind_DestroyArray(const JPH_SoftBodySharedSettings_InvBind *_this);

/// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodySharedSettings_InvBind *JPH_SoftBodySharedSettings_InvBind_AssignFromAnother(JPH_SoftBodySharedSettings_InvBind *_this, const JPH_SoftBodySharedSettings_InvBind *_other);

/// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_InvBind_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_InvBind_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_InvBind_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_InvBind_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr_void_ptr(void *inPointer, void *inPlace);

///< Index in mInvBindMatrices
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::SkinWeight` named `mInvBindIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SoftBodySharedSettings_SkinWeight_Get_mInvBindIndex(const JPH_SoftBodySharedSettings_SkinWeight *_this);

///< Index in mInvBindMatrices
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::SkinWeight` named `mInvBindIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mInvBindIndex`.
/// When this function is called, this object will drop object references it held previously in `mInvBindIndex`.
JOLT_API void JPH_SoftBodySharedSettings_SkinWeight_Set_mInvBindIndex(JPH_SoftBodySharedSettings_SkinWeight *_this, unsigned int value);

///< Index in mInvBindMatrices
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::SkinWeight` named `mInvBindIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SoftBodySharedSettings_SkinWeight_GetMutable_mInvBindIndex(JPH_SoftBodySharedSettings_SkinWeight *_this);

///< Weight with which it is skinned
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::SkinWeight` named `mWeight`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_SkinWeight_Get_mWeight(const JPH_SoftBodySharedSettings_SkinWeight *_this);

///< Weight with which it is skinned
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::SkinWeight` named `mWeight`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mWeight`.
JOLT_API void JPH_SoftBodySharedSettings_SkinWeight_Set_mWeight(JPH_SoftBodySharedSettings_SkinWeight *_this, float value);

///< Weight with which it is skinned
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::SkinWeight` named `mWeight`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_SkinWeight_GetMutable_mWeight(JPH_SoftBodySharedSettings_SkinWeight *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_SkinWeight_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_SkinWeight_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodySharedSettings_SkinWeight_DestroyArray()`.
/// Use `JPH_SoftBodySharedSettings_SkinWeight_OffsetMutablePtr()` and `JPH_SoftBodySharedSettings_SkinWeight_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_SkinWeight_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_SkinWeight_OffsetPtr(const JPH_SoftBodySharedSettings_SkinWeight *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_SkinWeight_OffsetMutablePtr(JPH_SoftBodySharedSettings_SkinWeight *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodySharedSettings::SkinWeight::SkinWeight`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_SkinWeight_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_SkinWeight_ConstructFromAnother(const JPH_SoftBodySharedSettings_SkinWeight *_other);

/// Generated from constructor `JPH::SoftBodySharedSettings::SkinWeight::SkinWeight`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_SkinWeight_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_SkinWeight_Construct(unsigned int inInvBindIndex, float inWeight);

/// Destroys a heap-allocated instance of `JPH_SoftBodySharedSettings_SkinWeight`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_SkinWeight_Destroy(const JPH_SoftBodySharedSettings_SkinWeight *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodySharedSettings_SkinWeight`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_SkinWeight_DestroyArray(const JPH_SoftBodySharedSettings_SkinWeight *_this);

/// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_SkinWeight_AssignFromAnother(JPH_SoftBodySharedSettings_SkinWeight *_this, const JPH_SoftBodySharedSettings_SkinWeight *_other);

/// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_SkinWeight_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_SkinWeight_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_SkinWeight_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_SkinWeight_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Maximum number of skin weights
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `cMaxSkinWeights`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_SoftBodySharedSettings_Skinned_Get_cMaxSkinWeights(void);

///< Index in mVertices which indicates which vertex is being skinned
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SoftBodySharedSettings_Skinned_Get_mVertex(const JPH_SoftBodySharedSettings_Skinned *_this);

///< Index in mVertices which indicates which vertex is being skinned
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mVertex`.
/// When this function is called, this object will drop object references it held previously in `mVertex`.
JOLT_API void JPH_SoftBodySharedSettings_Skinned_Set_mVertex(JPH_SoftBodySharedSettings_Skinned *_this, unsigned int value);

///< Index in mVertices which indicates which vertex is being skinned
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SoftBodySharedSettings_Skinned_GetMutable_mVertex(JPH_SoftBodySharedSettings_Skinned *_this);

///< Skin weights, the bind pose of the vertex is assumed to be stored in Vertex::mPosition. The first weight that is zero indicates the end of the list. Weights should add up to 1.
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mWeights`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_Skinned_Get_mWeights(const JPH_SoftBodySharedSettings_Skinned *_this);

///< Skin weights, the bind pose of the vertex is assumed to be stored in Vertex::mPosition. The first weight that is zero indicates the end of the list. Weights should add up to 1.
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mWeights`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_Skinned_GetMutable_mWeights(JPH_SoftBodySharedSettings_Skinned *_this);

/// Returns the size of the array member of class `JPH::SoftBodySharedSettings::Skinned` named `mWeights`. The size is `4`.
JOLT_API size_t JPH_SoftBodySharedSettings_Skinned_GetSize_mWeights(void);

///< Maximum distance that this vertex can reach from the skinned vertex, disabled when FLT_MAX. 0 when you want to hard skin the vertex to the skinned vertex.
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mMaxDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_Skinned_Get_mMaxDistance(const JPH_SoftBodySharedSettings_Skinned *_this);

///< Maximum distance that this vertex can reach from the skinned vertex, disabled when FLT_MAX. 0 when you want to hard skin the vertex to the skinned vertex.
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mMaxDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxDistance`.
JOLT_API void JPH_SoftBodySharedSettings_Skinned_Set_mMaxDistance(JPH_SoftBodySharedSettings_Skinned *_this, float value);

///< Maximum distance that this vertex can reach from the skinned vertex, disabled when FLT_MAX. 0 when you want to hard skin the vertex to the skinned vertex.
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mMaxDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_Skinned_GetMutable_mMaxDistance(JPH_SoftBodySharedSettings_Skinned *_this);

///< Disabled if mBackStopDistance >= mMaxDistance. The faces surrounding mVertex determine an average normal. mBackStopDistance behind the vertex in the opposite direction of this normal, the back stop sphere starts. The simulated vertex will be pushed out of this sphere and it can be used to approximate the volume of the skinned mesh behind the skinned vertex.
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mBackStopDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_Skinned_Get_mBackStopDistance(const JPH_SoftBodySharedSettings_Skinned *_this);

///< Disabled if mBackStopDistance >= mMaxDistance. The faces surrounding mVertex determine an average normal. mBackStopDistance behind the vertex in the opposite direction of this normal, the back stop sphere starts. The simulated vertex will be pushed out of this sphere and it can be used to approximate the volume of the skinned mesh behind the skinned vertex.
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mBackStopDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mBackStopDistance`.
JOLT_API void JPH_SoftBodySharedSettings_Skinned_Set_mBackStopDistance(JPH_SoftBodySharedSettings_Skinned *_this, float value);

///< Disabled if mBackStopDistance >= mMaxDistance. The faces surrounding mVertex determine an average normal. mBackStopDistance behind the vertex in the opposite direction of this normal, the back stop sphere starts. The simulated vertex will be pushed out of this sphere and it can be used to approximate the volume of the skinned mesh behind the skinned vertex.
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mBackStopDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_Skinned_GetMutable_mBackStopDistance(JPH_SoftBodySharedSettings_Skinned *_this);

///< Radius of the backstop sphere. By default this is a fairly large radius so the sphere approximates a plane.
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mBackStopRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_Skinned_Get_mBackStopRadius(const JPH_SoftBodySharedSettings_Skinned *_this);

///< Radius of the backstop sphere. By default this is a fairly large radius so the sphere approximates a plane.
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mBackStopRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mBackStopRadius`.
JOLT_API void JPH_SoftBodySharedSettings_Skinned_Set_mBackStopRadius(JPH_SoftBodySharedSettings_Skinned *_this, float value);

///< Radius of the backstop sphere. By default this is a fairly large radius so the sphere approximates a plane.
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mBackStopRadius`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_Skinned_GetMutable_mBackStopRadius(JPH_SoftBodySharedSettings_Skinned *_this);

///< Information needed to calculate the normal of this vertex, lowest 24 bit is start index in mSkinnedConstraintNormals, highest 8 bit is number of faces (generated by CalculateSkinnedConstraintNormals)
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mNormalInfo`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SoftBodySharedSettings_Skinned_Get_mNormalInfo(const JPH_SoftBodySharedSettings_Skinned *_this);

///< Information needed to calculate the normal of this vertex, lowest 24 bit is start index in mSkinnedConstraintNormals, highest 8 bit is number of faces (generated by CalculateSkinnedConstraintNormals)
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mNormalInfo`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mNormalInfo`.
/// When this function is called, this object will drop object references it held previously in `mNormalInfo`.
JOLT_API void JPH_SoftBodySharedSettings_Skinned_Set_mNormalInfo(JPH_SoftBodySharedSettings_Skinned *_this, unsigned int value);

///< Information needed to calculate the normal of this vertex, lowest 24 bit is start index in mSkinnedConstraintNormals, highest 8 bit is number of faces (generated by CalculateSkinnedConstraintNormals)
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::Skinned` named `mNormalInfo`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SoftBodySharedSettings_Skinned_GetMutable_mNormalInfo(JPH_SoftBodySharedSettings_Skinned *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Skinned_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_Skinned *JPH_SoftBodySharedSettings_Skinned_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodySharedSettings_Skinned_DestroyArray()`.
/// Use `JPH_SoftBodySharedSettings_Skinned_OffsetMutablePtr()` and `JPH_SoftBodySharedSettings_Skinned_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodySharedSettings_Skinned *JPH_SoftBodySharedSettings_Skinned_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodySharedSettings_Skinned *JPH_SoftBodySharedSettings_Skinned_OffsetPtr(const JPH_SoftBodySharedSettings_Skinned *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodySharedSettings_Skinned *JPH_SoftBodySharedSettings_Skinned_OffsetMutablePtr(JPH_SoftBodySharedSettings_Skinned *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodySharedSettings::Skinned::Skinned`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Skinned_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_Skinned *JPH_SoftBodySharedSettings_Skinned_ConstructFromAnother(const JPH_SoftBodySharedSettings_Skinned *_other);

/// Generated from constructor `JPH::SoftBodySharedSettings::Skinned::Skinned`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_Skinned_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_Skinned *JPH_SoftBodySharedSettings_Skinned_Construct(unsigned int inVertex, float inMaxDistance, float inBackStopDistance, float inBackStopRadius);

/// Destroys a heap-allocated instance of `JPH_SoftBodySharedSettings_Skinned`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_Skinned_Destroy(const JPH_SoftBodySharedSettings_Skinned *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodySharedSettings_Skinned`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_Skinned_DestroyArray(const JPH_SoftBodySharedSettings_Skinned *_this);

/// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodySharedSettings_Skinned *JPH_SoftBodySharedSettings_Skinned_AssignFromAnother(JPH_SoftBodySharedSettings_Skinned *_this, const JPH_SoftBodySharedSettings_Skinned *_other);

/// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_Skinned_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_Skinned_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_Skinned_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_Skinned_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Normalize the weights so that they add up to 1
/// Generated from method `JPH::SoftBodySharedSettings::Skinned::NormalizeWeights`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SoftBodySharedSettings_Skinned_NormalizeWeights(JPH_SoftBodySharedSettings_Skinned *_this);

///< The vertices that are connected. The first vertex should be kinematic, the 2nd dynamic.
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::LRA` named `mVertex`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SoftBodySharedSettings_LRA_Get_mVertex(const JPH_SoftBodySharedSettings_LRA *_this);

///< The vertices that are connected. The first vertex should be kinematic, the 2nd dynamic.
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::LRA` named `mVertex`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SoftBodySharedSettings_LRA_GetMutable_mVertex(JPH_SoftBodySharedSettings_LRA *_this);

/// Returns the size of the array member of class `JPH::SoftBodySharedSettings::LRA` named `mVertex`. The size is `2`.
JOLT_API size_t JPH_SoftBodySharedSettings_LRA_GetSize_mVertex(void);

///< The maximum distance between the vertices, calculated by CalculateLRALengths
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::LRA` named `mMaxDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_LRA_Get_mMaxDistance(const JPH_SoftBodySharedSettings_LRA *_this);

///< The maximum distance between the vertices, calculated by CalculateLRALengths
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::LRA` named `mMaxDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxDistance`.
JOLT_API void JPH_SoftBodySharedSettings_LRA_Set_mMaxDistance(JPH_SoftBodySharedSettings_LRA *_this, float value);

///< The maximum distance between the vertices, calculated by CalculateLRALengths
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::LRA` named `mMaxDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_LRA_GetMutable_mMaxDistance(JPH_SoftBodySharedSettings_LRA *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_LRA_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_LRA *JPH_SoftBodySharedSettings_LRA_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodySharedSettings_LRA_DestroyArray()`.
/// Use `JPH_SoftBodySharedSettings_LRA_OffsetMutablePtr()` and `JPH_SoftBodySharedSettings_LRA_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodySharedSettings_LRA *JPH_SoftBodySharedSettings_LRA_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodySharedSettings_LRA *JPH_SoftBodySharedSettings_LRA_OffsetPtr(const JPH_SoftBodySharedSettings_LRA *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodySharedSettings_LRA *JPH_SoftBodySharedSettings_LRA_OffsetMutablePtr(JPH_SoftBodySharedSettings_LRA *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodySharedSettings::LRA::LRA`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_LRA_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_LRA *JPH_SoftBodySharedSettings_LRA_ConstructFromAnother(const JPH_SoftBodySharedSettings_LRA *_other);

/// Generated from constructor `JPH::SoftBodySharedSettings::LRA::LRA`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_LRA_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_LRA *JPH_SoftBodySharedSettings_LRA_Construct(unsigned int inVertex1, unsigned int inVertex2, float inMaxDistance);

/// Destroys a heap-allocated instance of `JPH_SoftBodySharedSettings_LRA`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_LRA_Destroy(const JPH_SoftBodySharedSettings_LRA *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodySharedSettings_LRA`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_LRA_DestroyArray(const JPH_SoftBodySharedSettings_LRA *_this);

/// Generated from method `JPH::SoftBodySharedSettings::LRA::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodySharedSettings_LRA *JPH_SoftBodySharedSettings_LRA_AssignFromAnother(JPH_SoftBodySharedSettings_LRA *_this, const JPH_SoftBodySharedSettings_LRA *_other);

/// Generated from method `JPH::SoftBodySharedSettings::LRA::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_LRA_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::LRA::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::LRA::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::LRA::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_LRA_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::LRA::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::LRA::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::LRA::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_LRA_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::LRA::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SoftBodySharedSettings::LRA::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_LRA_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::LRA::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Return the lowest vertex index of this constraint
/// Generated from method `JPH::SoftBodySharedSettings::LRA::GetMinVertexIndex`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodySharedSettings_LRA_GetMinVertexIndex(const JPH_SoftBodySharedSettings_LRA *_this);

///< Indices of the vertices that form the rod
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::RodStretchShear` named `mVertex`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SoftBodySharedSettings_RodStretchShear_Get_mVertex(const JPH_SoftBodySharedSettings_RodStretchShear *_this);

///< Indices of the vertices that form the rod
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::RodStretchShear` named `mVertex`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mVertex(JPH_SoftBodySharedSettings_RodStretchShear *_this);

/// Returns the size of the array member of class `JPH::SoftBodySharedSettings::RodStretchShear` named `mVertex`. The size is `2`.
JOLT_API size_t JPH_SoftBodySharedSettings_RodStretchShear_GetSize_mVertex(void);

///< Fixed length of the rod, calculated by CalculateRodProperties
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::RodStretchShear` named `mLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_RodStretchShear_Get_mLength(const JPH_SoftBodySharedSettings_RodStretchShear *_this);

///< Fixed length of the rod, calculated by CalculateRodProperties
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::RodStretchShear` named `mLength`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mLength`.
JOLT_API void JPH_SoftBodySharedSettings_RodStretchShear_Set_mLength(JPH_SoftBodySharedSettings_RodStretchShear *_this, float value);

///< Fixed length of the rod, calculated by CalculateRodProperties
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::RodStretchShear` named `mLength`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mLength(JPH_SoftBodySharedSettings_RodStretchShear *_this);

///< Inverse of the mass of the rod (0 for static rods), calculated by CalculateRodProperties but can be overridden afterwards
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::RodStretchShear` named `mInvMass`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_RodStretchShear_Get_mInvMass(const JPH_SoftBodySharedSettings_RodStretchShear *_this);

///< Inverse of the mass of the rod (0 for static rods), calculated by CalculateRodProperties but can be overridden afterwards
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::RodStretchShear` named `mInvMass`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mInvMass`.
JOLT_API void JPH_SoftBodySharedSettings_RodStretchShear_Set_mInvMass(JPH_SoftBodySharedSettings_RodStretchShear *_this, float value);

///< Inverse of the mass of the rod (0 for static rods), calculated by CalculateRodProperties but can be overridden afterwards
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::RodStretchShear` named `mInvMass`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mInvMass(JPH_SoftBodySharedSettings_RodStretchShear *_this);

///< Inverse of the stiffness of the rod
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::RodStretchShear` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_RodStretchShear_Get_mCompliance(const JPH_SoftBodySharedSettings_RodStretchShear *_this);

///< Inverse of the stiffness of the rod
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::RodStretchShear` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCompliance`.
JOLT_API void JPH_SoftBodySharedSettings_RodStretchShear_Set_mCompliance(JPH_SoftBodySharedSettings_RodStretchShear *_this, float value);

///< Inverse of the stiffness of the rod
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::RodStretchShear` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mCompliance(JPH_SoftBodySharedSettings_RodStretchShear *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_RodStretchShear_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_RodStretchShear *JPH_SoftBodySharedSettings_RodStretchShear_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodySharedSettings_RodStretchShear_DestroyArray()`.
/// Use `JPH_SoftBodySharedSettings_RodStretchShear_OffsetMutablePtr()` and `JPH_SoftBodySharedSettings_RodStretchShear_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodySharedSettings_RodStretchShear *JPH_SoftBodySharedSettings_RodStretchShear_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodySharedSettings_RodStretchShear *JPH_SoftBodySharedSettings_RodStretchShear_OffsetPtr(const JPH_SoftBodySharedSettings_RodStretchShear *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodySharedSettings_RodStretchShear *JPH_SoftBodySharedSettings_RodStretchShear_OffsetMutablePtr(JPH_SoftBodySharedSettings_RodStretchShear *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodySharedSettings::RodStretchShear::RodStretchShear`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_RodStretchShear_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_RodStretchShear *JPH_SoftBodySharedSettings_RodStretchShear_ConstructFromAnother(const JPH_SoftBodySharedSettings_RodStretchShear *_other);

/// Generated from constructor `JPH::SoftBodySharedSettings::RodStretchShear::RodStretchShear`.
/// Parameter `inCompliance` has a default argument: `0.0f`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_RodStretchShear_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_RodStretchShear *JPH_SoftBodySharedSettings_RodStretchShear_Construct(unsigned int inVertex1, unsigned int inVertex2, const float *inCompliance);

/// Destroys a heap-allocated instance of `JPH_SoftBodySharedSettings_RodStretchShear`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_RodStretchShear_Destroy(const JPH_SoftBodySharedSettings_RodStretchShear *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodySharedSettings_RodStretchShear`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_RodStretchShear_DestroyArray(const JPH_SoftBodySharedSettings_RodStretchShear *_this);

/// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodySharedSettings_RodStretchShear *JPH_SoftBodySharedSettings_RodStretchShear_AssignFromAnother(JPH_SoftBodySharedSettings_RodStretchShear *_this, const JPH_SoftBodySharedSettings_RodStretchShear *_other);

/// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_RodStretchShear_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_RodStretchShear_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_RodStretchShear_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_RodStretchShear_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Return the lowest vertex index of this constraint
/// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::GetMinVertexIndex`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SoftBodySharedSettings_RodStretchShear_GetMinVertexIndex(const JPH_SoftBodySharedSettings_RodStretchShear *_this);

///< Indices of rods that are constrained (index in mRodStretchShearConstraints)
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::RodBendTwist` named `mRod`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_SoftBodySharedSettings_RodBendTwist_Get_mRod(const JPH_SoftBodySharedSettings_RodBendTwist *_this);

///< Indices of rods that are constrained (index in mRodStretchShearConstraints)
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::RodBendTwist` named `mRod`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mRod(JPH_SoftBodySharedSettings_RodBendTwist *_this);

/// Returns the size of the array member of class `JPH::SoftBodySharedSettings::RodBendTwist` named `mRod`. The size is `2`.
JOLT_API size_t JPH_SoftBodySharedSettings_RodBendTwist_GetSize_mRod(void);

///< Inverse of the stiffness of the rod
/// Returns a pointer to a member variable of class `JPH::SoftBodySharedSettings::RodBendTwist` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_SoftBodySharedSettings_RodBendTwist_Get_mCompliance(const JPH_SoftBodySharedSettings_RodBendTwist *_this);

///< Inverse of the stiffness of the rod
/// Modifies a member variable of class `JPH::SoftBodySharedSettings::RodBendTwist` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCompliance`.
JOLT_API void JPH_SoftBodySharedSettings_RodBendTwist_Set_mCompliance(JPH_SoftBodySharedSettings_RodBendTwist *_this, float value);

///< Inverse of the stiffness of the rod
/// Returns a mutable pointer to a member variable of class `JPH::SoftBodySharedSettings::RodBendTwist` named `mCompliance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mCompliance(JPH_SoftBodySharedSettings_RodBendTwist *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_RodBendTwist_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_RodBendTwist *JPH_SoftBodySharedSettings_RodBendTwist_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SoftBodySharedSettings_RodBendTwist_DestroyArray()`.
/// Use `JPH_SoftBodySharedSettings_RodBendTwist_OffsetMutablePtr()` and `JPH_SoftBodySharedSettings_RodBendTwist_OffsetPtr()` to access the array elements.
JOLT_API JPH_SoftBodySharedSettings_RodBendTwist *JPH_SoftBodySharedSettings_RodBendTwist_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SoftBodySharedSettings_RodBendTwist *JPH_SoftBodySharedSettings_RodBendTwist_OffsetPtr(const JPH_SoftBodySharedSettings_RodBendTwist *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SoftBodySharedSettings_RodBendTwist *JPH_SoftBodySharedSettings_RodBendTwist_OffsetMutablePtr(JPH_SoftBodySharedSettings_RodBendTwist *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SoftBodySharedSettings::RodBendTwist::RodBendTwist`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_RodBendTwist_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_RodBendTwist *JPH_SoftBodySharedSettings_RodBendTwist_ConstructFromAnother(const JPH_SoftBodySharedSettings_RodBendTwist *_other);

/// Generated from constructor `JPH::SoftBodySharedSettings::RodBendTwist::RodBendTwist`.
/// Parameter `inCompliance` has a default argument: `0.0f`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SoftBodySharedSettings_RodBendTwist_Destroy()` to free it when you're done using it.
JOLT_API JPH_SoftBodySharedSettings_RodBendTwist *JPH_SoftBodySharedSettings_RodBendTwist_Construct(unsigned int inRod1, unsigned int inRod2, const float *inCompliance);

/// Destroys a heap-allocated instance of `JPH_SoftBodySharedSettings_RodBendTwist`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_RodBendTwist_Destroy(const JPH_SoftBodySharedSettings_RodBendTwist *_this);

/// Destroys a heap-allocated array of `JPH_SoftBodySharedSettings_RodBendTwist`. Does nothing if the pointer is null.
JOLT_API void JPH_SoftBodySharedSettings_RodBendTwist_DestroyArray(const JPH_SoftBodySharedSettings_RodBendTwist *_this);

/// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SoftBodySharedSettings_RodBendTwist *JPH_SoftBodySharedSettings_RodBendTwist_AssignFromAnother(JPH_SoftBodySharedSettings_RodBendTwist *_this, const JPH_SoftBodySharedSettings_RodBendTwist *_other);

/// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_RodBendTwist_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_RodBendTwist_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr(void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator new`.
JOLT_API void *Jolt_new_JPH_SoftBodySharedSettings_RodBendTwist_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator delete`.
JOLT_API void Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SoftBodySharedSettings_RodBendTwist_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_void_ptr(void *inPointer, void *inPlace);

#ifdef __cplusplus
} // extern "C"
#endif
