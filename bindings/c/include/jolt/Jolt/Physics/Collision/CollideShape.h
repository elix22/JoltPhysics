// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>
#include <jolt/Jolt/Physics/Body/BodyID.h>
#include <jolt/Jolt/Physics/Collision/ActiveEdgeMode.h>
#include <jolt/Jolt/Physics/Collision/BackFaceMode.h>
#include <jolt/Jolt/Physics/Collision/CollectFacesMode.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Class that contains all information of two colliding shapes
/// Generated from class `JPH::CollideShapeResult`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::ShapeCastResult`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CollideShapeResult JPH_CollideShapeResult;

/// Settings to be passed with a collision query
/// Generated from class `JPH::CollideSettingsBase`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::CollideShapeSettings`
///     `JPH::ShapeCastSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CollideSettingsBase JPH_CollideSettingsBase;

/// Settings to be passed with a collision query
/// Generated from class `JPH::CollideShapeSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::CollideSettingsBase`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CollideShapeSettings JPH_CollideShapeSettings;

///< Contact point on the surface of shape 1 (in world space or relative to base offset)
/// Returns a pointer to a member variable of class `JPH::CollideShapeResult` named `mContactPointOn1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CollideShapeResult_Get_mContactPointOn1(const JPH_CollideShapeResult *_this);

///< Contact point on the surface of shape 1 (in world space or relative to base offset)
/// Returns a mutable pointer to a member variable of class `JPH::CollideShapeResult` named `mContactPointOn1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CollideShapeResult_GetMutable_mContactPointOn1(JPH_CollideShapeResult *_this);

///< Contact point on the surface of shape 2 (in world space or relative to base offset). If the penetration depth is 0, this will be the same as mContactPointOn1.
/// Returns a pointer to a member variable of class `JPH::CollideShapeResult` named `mContactPointOn2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CollideShapeResult_Get_mContactPointOn2(const JPH_CollideShapeResult *_this);

///< Contact point on the surface of shape 2 (in world space or relative to base offset). If the penetration depth is 0, this will be the same as mContactPointOn1.
/// Returns a mutable pointer to a member variable of class `JPH::CollideShapeResult` named `mContactPointOn2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CollideShapeResult_GetMutable_mContactPointOn2(JPH_CollideShapeResult *_this);

///< Direction to move shape 2 out of collision along the shortest path (magnitude is meaningless, in world space). You can use -mPenetrationAxis.Normalized() as contact normal.
/// Returns a pointer to a member variable of class `JPH::CollideShapeResult` named `mPenetrationAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CollideShapeResult_Get_mPenetrationAxis(const JPH_CollideShapeResult *_this);

///< Direction to move shape 2 out of collision along the shortest path (magnitude is meaningless, in world space). You can use -mPenetrationAxis.Normalized() as contact normal.
/// Returns a mutable pointer to a member variable of class `JPH::CollideShapeResult` named `mPenetrationAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CollideShapeResult_GetMutable_mPenetrationAxis(JPH_CollideShapeResult *_this);

///< Penetration depth (move shape 2 by this distance to resolve the collision). If CollideShapeSettings::mMaxSeparationDistance > 0 this number can be negative to indicate that the objects are separated by -mPenetrationDepth. The contact points are the closest points in that case.
/// Returns a pointer to a member variable of class `JPH::CollideShapeResult` named `mPenetrationDepth`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CollideShapeResult_Get_mPenetrationDepth(const JPH_CollideShapeResult *_this);

///< Penetration depth (move shape 2 by this distance to resolve the collision). If CollideShapeSettings::mMaxSeparationDistance > 0 this number can be negative to indicate that the objects are separated by -mPenetrationDepth. The contact points are the closest points in that case.
/// Modifies a member variable of class `JPH::CollideShapeResult` named `mPenetrationDepth`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mPenetrationDepth`.
JOLT_API void JPH_CollideShapeResult_Set_mPenetrationDepth(JPH_CollideShapeResult *_this, float value);

///< Penetration depth (move shape 2 by this distance to resolve the collision). If CollideShapeSettings::mMaxSeparationDistance > 0 this number can be negative to indicate that the objects are separated by -mPenetrationDepth. The contact points are the closest points in that case.
/// Returns a mutable pointer to a member variable of class `JPH::CollideShapeResult` named `mPenetrationDepth`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CollideShapeResult_GetMutable_mPenetrationDepth(JPH_CollideShapeResult *_this);

///< Sub shape ID that identifies the face on shape 1
/// Returns a pointer to a member variable of class `JPH::CollideShapeResult` named `mSubShapeID1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SubShapeID *JPH_CollideShapeResult_Get_mSubShapeID1(const JPH_CollideShapeResult *_this);

///< Sub shape ID that identifies the face on shape 1
/// Modifies a member variable of class `JPH::CollideShapeResult` named `mSubShapeID1`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSubShapeID1`.
/// When this function is called, this object will drop object references it held previously in `mSubShapeID1`.
JOLT_API void JPH_CollideShapeResult_Set_mSubShapeID1(JPH_CollideShapeResult *_this, const JPH_SubShapeID *value);

///< Sub shape ID that identifies the face on shape 1
/// Returns a mutable pointer to a member variable of class `JPH::CollideShapeResult` named `mSubShapeID1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SubShapeID *JPH_CollideShapeResult_GetMutable_mSubShapeID1(JPH_CollideShapeResult *_this);

///< Sub shape ID that identifies the face on shape 2
/// Returns a pointer to a member variable of class `JPH::CollideShapeResult` named `mSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SubShapeID *JPH_CollideShapeResult_Get_mSubShapeID2(const JPH_CollideShapeResult *_this);

///< Sub shape ID that identifies the face on shape 2
/// Modifies a member variable of class `JPH::CollideShapeResult` named `mSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSubShapeID2`.
/// When this function is called, this object will drop object references it held previously in `mSubShapeID2`.
JOLT_API void JPH_CollideShapeResult_Set_mSubShapeID2(JPH_CollideShapeResult *_this, const JPH_SubShapeID *value);

///< Sub shape ID that identifies the face on shape 2
/// Returns a mutable pointer to a member variable of class `JPH::CollideShapeResult` named `mSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SubShapeID *JPH_CollideShapeResult_GetMutable_mSubShapeID2(JPH_CollideShapeResult *_this);

///< BodyID to which shape 2 belongs to
/// Returns a pointer to a member variable of class `JPH::CollideShapeResult` named `mBodyID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_BodyID *JPH_CollideShapeResult_Get_mBodyID2(const JPH_CollideShapeResult *_this);

///< BodyID to which shape 2 belongs to
/// Modifies a member variable of class `JPH::CollideShapeResult` named `mBodyID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBodyID2`.
/// When this function is called, this object will drop object references it held previously in `mBodyID2`.
JOLT_API void JPH_CollideShapeResult_Set_mBodyID2(JPH_CollideShapeResult *_this, JPH_BodyID value);

///< BodyID to which shape 2 belongs to
/// Returns a mutable pointer to a member variable of class `JPH::CollideShapeResult` named `mBodyID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_BodyID *JPH_CollideShapeResult_GetMutable_mBodyID2(JPH_CollideShapeResult *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CollideShapeResult_Destroy()` to free it when you're done using it.
JOLT_API JPH_CollideShapeResult *JPH_CollideShapeResult_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CollideShapeResult_DestroyArray()`.
/// Use `JPH_CollideShapeResult_OffsetMutablePtr()` and `JPH_CollideShapeResult_OffsetPtr()` to access the array elements.
JOLT_API JPH_CollideShapeResult *JPH_CollideShapeResult_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CollideShapeResult *JPH_CollideShapeResult_OffsetPtr(const JPH_CollideShapeResult *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CollideShapeResult *JPH_CollideShapeResult_OffsetMutablePtr(JPH_CollideShapeResult *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::CollideShapeResult::CollideShapeResult`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CollideShapeResult_Destroy()` to free it when you're done using it.
JOLT_API JPH_CollideShapeResult *JPH_CollideShapeResult_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CollideShapeResult *_other);

/// Constructor
/// Generated from constructor `JPH::CollideShapeResult::CollideShapeResult`.
/// Parameter `inContactPointOn1` can not be null. It is a single object.
/// Parameter `inContactPointOn2` can not be null. It is a single object.
/// Parameter `inPenetrationAxis` can not be null. It is a single object.
/// Parameter `inSubShapeID1` can not be null. It is a single object.
/// Parameter `inSubShapeID2` can not be null. It is a single object.
/// Parameter `inBodyID2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CollideShapeResult_Destroy()` to free it when you're done using it.
JOLT_API JPH_CollideShapeResult *JPH_CollideShapeResult_Construct(const JPH_Vec3 *inContactPointOn1, const JPH_Vec3 *inContactPointOn2, const JPH_Vec3 *inPenetrationAxis, float inPenetrationDepth, const JPH_SubShapeID *inSubShapeID1, const JPH_SubShapeID *inSubShapeID2, const JPH_BodyID *inBodyID2);

/// Destroys a heap-allocated instance of `JPH_CollideShapeResult`. Does nothing if the pointer is null.
JOLT_API void JPH_CollideShapeResult_Destroy(const JPH_CollideShapeResult *_this);

/// Destroys a heap-allocated array of `JPH_CollideShapeResult`. Does nothing if the pointer is null.
JOLT_API void JPH_CollideShapeResult_DestroyArray(const JPH_CollideShapeResult *_this);

/// Generated from method `JPH::CollideShapeResult::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CollideShapeResult *JPH_CollideShapeResult_AssignFromAnother(JPH_CollideShapeResult *_this, Jolt_PassBy _other_pass_by, JPH_CollideShapeResult *_other);

/// Generated from method `JPH::CollideShapeResult::operator new`.
JOLT_API void *Jolt_new_JPH_CollideShapeResult_size_t(size_t inCount);

/// Generated from method `JPH::CollideShapeResult::operator delete`.
JOLT_API void Jolt_delete_JPH_CollideShapeResult_void_ptr(void *inPointer);

/// Generated from method `JPH::CollideShapeResult::operator delete`.
JOLT_API void Jolt_delete_JPH_CollideShapeResult_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CollideShapeResult::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CollideShapeResult_size_t(size_t inCount);

/// Generated from method `JPH::CollideShapeResult::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CollideShapeResult_void_ptr(void *inPointer);

/// Generated from method `JPH::CollideShapeResult::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CollideShapeResult_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CollideShapeResult::operator new`.
JOLT_API void *Jolt_new_JPH_CollideShapeResult_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CollideShapeResult::operator delete`.
JOLT_API void Jolt_delete_JPH_CollideShapeResult_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CollideShapeResult::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CollideShapeResult_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CollideShapeResult::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CollideShapeResult_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Function required by the CollisionCollector. A smaller fraction is considered to be a 'better hit'. We use -penetration depth to get the hit with the biggest penetration depth
/// Generated from method `JPH::CollideShapeResult::GetEarlyOutFraction`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CollideShapeResult_GetEarlyOutFraction(const JPH_CollideShapeResult *_this);

/// Reverses the hit result, swapping contact point 1 with contact point 2 etc.
/// Generated from method `JPH::CollideShapeResult::Reversed`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CollideShapeResult_Destroy()` to free it when you're done using it.
JOLT_API JPH_CollideShapeResult *JPH_CollideShapeResult_Reversed(const JPH_CollideShapeResult *_this);

/// How active edges (edges that a moving object should bump into) are handled
/// Returns a pointer to a member variable of class `JPH::CollideSettingsBase` named `mActiveEdgeMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_EActiveEdgeMode *JPH_CollideSettingsBase_Get_mActiveEdgeMode(const JPH_CollideSettingsBase *_this);

/// How active edges (edges that a moving object should bump into) are handled
/// Modifies a member variable of class `JPH::CollideSettingsBase` named `mActiveEdgeMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mActiveEdgeMode`.
/// When this function is called, this object will drop object references it held previously in `mActiveEdgeMode`.
JOLT_API void JPH_CollideSettingsBase_Set_mActiveEdgeMode(JPH_CollideSettingsBase *_this, JPH_EActiveEdgeMode value);

/// How active edges (edges that a moving object should bump into) are handled
/// Returns a mutable pointer to a member variable of class `JPH::CollideSettingsBase` named `mActiveEdgeMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_EActiveEdgeMode *JPH_CollideSettingsBase_GetMutable_mActiveEdgeMode(JPH_CollideSettingsBase *_this);

/// If colliding faces should be collected or only the collision point
/// Returns a pointer to a member variable of class `JPH::CollideSettingsBase` named `mCollectFacesMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_ECollectFacesMode *JPH_CollideSettingsBase_Get_mCollectFacesMode(const JPH_CollideSettingsBase *_this);

/// If colliding faces should be collected or only the collision point
/// Modifies a member variable of class `JPH::CollideSettingsBase` named `mCollectFacesMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mCollectFacesMode`.
/// When this function is called, this object will drop object references it held previously in `mCollectFacesMode`.
JOLT_API void JPH_CollideSettingsBase_Set_mCollectFacesMode(JPH_CollideSettingsBase *_this, JPH_ECollectFacesMode value);

/// If colliding faces should be collected or only the collision point
/// Returns a mutable pointer to a member variable of class `JPH::CollideSettingsBase` named `mCollectFacesMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_ECollectFacesMode *JPH_CollideSettingsBase_GetMutable_mCollectFacesMode(JPH_CollideSettingsBase *_this);

/// If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter)
/// Returns a pointer to a member variable of class `JPH::CollideSettingsBase` named `mCollisionTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CollideSettingsBase_Get_mCollisionTolerance(const JPH_CollideSettingsBase *_this);

/// If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter)
/// Modifies a member variable of class `JPH::CollideSettingsBase` named `mCollisionTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCollisionTolerance`.
JOLT_API void JPH_CollideSettingsBase_Set_mCollisionTolerance(JPH_CollideSettingsBase *_this, float value);

/// If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter)
/// Returns a mutable pointer to a member variable of class `JPH::CollideSettingsBase` named `mCollisionTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CollideSettingsBase_GetMutable_mCollisionTolerance(JPH_CollideSettingsBase *_this);

/// A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless)
/// Returns a pointer to a member variable of class `JPH::CollideSettingsBase` named `mPenetrationTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CollideSettingsBase_Get_mPenetrationTolerance(const JPH_CollideSettingsBase *_this);

/// A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless)
/// Modifies a member variable of class `JPH::CollideSettingsBase` named `mPenetrationTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mPenetrationTolerance`.
JOLT_API void JPH_CollideSettingsBase_Set_mPenetrationTolerance(JPH_CollideSettingsBase *_this, float value);

/// A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless)
/// Returns a mutable pointer to a member variable of class `JPH::CollideSettingsBase` named `mPenetrationTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CollideSettingsBase_GetMutable_mPenetrationTolerance(JPH_CollideSettingsBase *_this);

/// When mActiveEdgeMode is CollideOnlyWithActive a movement direction can be provided. When hitting an inactive edge, the system will select the triangle normal as penetration depth only if it impedes the movement less than with the calculated penetration depth.
/// Returns a pointer to a member variable of class `JPH::CollideSettingsBase` named `mActiveEdgeMovementDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CollideSettingsBase_Get_mActiveEdgeMovementDirection(const JPH_CollideSettingsBase *_this);

/// When mActiveEdgeMode is CollideOnlyWithActive a movement direction can be provided. When hitting an inactive edge, the system will select the triangle normal as penetration depth only if it impedes the movement less than with the calculated penetration depth.
/// Returns a mutable pointer to a member variable of class `JPH::CollideSettingsBase` named `mActiveEdgeMovementDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CollideSettingsBase_GetMutable_mActiveEdgeMovementDirection(JPH_CollideSettingsBase *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CollideSettingsBase_Destroy()` to free it when you're done using it.
JOLT_API JPH_CollideSettingsBase *JPH_CollideSettingsBase_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CollideSettingsBase_DestroyArray()`.
/// Use `JPH_CollideSettingsBase_OffsetMutablePtr()` and `JPH_CollideSettingsBase_OffsetPtr()` to access the array elements.
JOLT_API JPH_CollideSettingsBase *JPH_CollideSettingsBase_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::CollideSettingsBase` elementwise.
/// The reference to the parameter `mActiveEdgeMode` might be preserved in the constructed object.
/// The reference to the parameter `mCollectFacesMode` might be preserved in the constructed object.
/// Parameter `mActiveEdgeMovementDirection` can not be null. It is a single object.
/// The reference to the parameter `mActiveEdgeMovementDirection` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CollideSettingsBase_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CollideSettingsBase *JPH_CollideSettingsBase_ConstructFrom(JPH_EActiveEdgeMode mActiveEdgeMode, JPH_ECollectFacesMode mCollectFacesMode, float mCollisionTolerance, float mPenetrationTolerance, const JPH_Vec3 *mActiveEdgeMovementDirection);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CollideSettingsBase *JPH_CollideSettingsBase_OffsetPtr(const JPH_CollideSettingsBase *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CollideSettingsBase *JPH_CollideSettingsBase_OffsetMutablePtr(JPH_CollideSettingsBase *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::CollideSettingsBase::CollideSettingsBase`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CollideSettingsBase_Destroy()` to free it when you're done using it.
JOLT_API JPH_CollideSettingsBase *JPH_CollideSettingsBase_ConstructFromAnother(const JPH_CollideSettingsBase *_other);

/// Destroys a heap-allocated instance of `JPH_CollideSettingsBase`. Does nothing if the pointer is null.
JOLT_API void JPH_CollideSettingsBase_Destroy(const JPH_CollideSettingsBase *_this);

/// Destroys a heap-allocated array of `JPH_CollideSettingsBase`. Does nothing if the pointer is null.
JOLT_API void JPH_CollideSettingsBase_DestroyArray(const JPH_CollideSettingsBase *_this);

/// Generated from method `JPH::CollideSettingsBase::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CollideSettingsBase *JPH_CollideSettingsBase_AssignFromAnother(JPH_CollideSettingsBase *_this, const JPH_CollideSettingsBase *_other);

/// Generated from method `JPH::CollideSettingsBase::operator new`.
JOLT_API void *Jolt_new_JPH_CollideSettingsBase_size_t(size_t inCount);

/// Generated from method `JPH::CollideSettingsBase::operator delete`.
JOLT_API void Jolt_delete_JPH_CollideSettingsBase_void_ptr(void *inPointer);

/// Generated from method `JPH::CollideSettingsBase::operator delete`.
JOLT_API void Jolt_delete_JPH_CollideSettingsBase_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CollideSettingsBase::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CollideSettingsBase_size_t(size_t inCount);

/// Generated from method `JPH::CollideSettingsBase::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CollideSettingsBase_void_ptr(void *inPointer);

/// Generated from method `JPH::CollideSettingsBase::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CollideSettingsBase_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CollideSettingsBase::operator new`.
JOLT_API void *Jolt_new_JPH_CollideSettingsBase_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CollideSettingsBase::operator delete`.
JOLT_API void Jolt_delete_JPH_CollideSettingsBase_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CollideSettingsBase::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CollideSettingsBase_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CollideSettingsBase::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CollideSettingsBase_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// When > 0 contacts in the vicinity of the query shape can be found. All nearest contacts that are not further away than this distance will be found.
/// Note that in this case CollideShapeResult::mPenetrationDepth can become negative to indicate that objects are not overlapping. (unit: meter)
/// Returns a pointer to a member variable of class `JPH::CollideShapeSettings` named `mMaxSeparationDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CollideShapeSettings_Get_mMaxSeparationDistance(const JPH_CollideShapeSettings *_this);

/// When > 0 contacts in the vicinity of the query shape can be found. All nearest contacts that are not further away than this distance will be found.
/// Note that in this case CollideShapeResult::mPenetrationDepth can become negative to indicate that objects are not overlapping. (unit: meter)
/// Modifies a member variable of class `JPH::CollideShapeSettings` named `mMaxSeparationDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxSeparationDistance`.
JOLT_API void JPH_CollideShapeSettings_Set_mMaxSeparationDistance(JPH_CollideShapeSettings *_this, float value);

/// When > 0 contacts in the vicinity of the query shape can be found. All nearest contacts that are not further away than this distance will be found.
/// Note that in this case CollideShapeResult::mPenetrationDepth can become negative to indicate that objects are not overlapping. (unit: meter)
/// Returns a mutable pointer to a member variable of class `JPH::CollideShapeSettings` named `mMaxSeparationDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CollideShapeSettings_GetMutable_mMaxSeparationDistance(JPH_CollideShapeSettings *_this);

/// How backfacing triangles should be treated
/// Returns a pointer to a member variable of class `JPH::CollideShapeSettings` named `mBackFaceMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_EBackFaceMode *JPH_CollideShapeSettings_Get_mBackFaceMode(const JPH_CollideShapeSettings *_this);

/// How backfacing triangles should be treated
/// Modifies a member variable of class `JPH::CollideShapeSettings` named `mBackFaceMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBackFaceMode`.
/// When this function is called, this object will drop object references it held previously in `mBackFaceMode`.
JOLT_API void JPH_CollideShapeSettings_Set_mBackFaceMode(JPH_CollideShapeSettings *_this, JPH_EBackFaceMode value);

/// How backfacing triangles should be treated
/// Returns a mutable pointer to a member variable of class `JPH::CollideShapeSettings` named `mBackFaceMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_EBackFaceMode *JPH_CollideShapeSettings_GetMutable_mBackFaceMode(JPH_CollideShapeSettings *_this);

/// How active edges (edges that a moving object should bump into) are handled
/// Returns a pointer to a member variable of class `JPH::CollideShapeSettings` named `mActiveEdgeMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_EActiveEdgeMode *JPH_CollideShapeSettings_Get_mActiveEdgeMode(const JPH_CollideShapeSettings *_this);

/// How active edges (edges that a moving object should bump into) are handled
/// Modifies a member variable of class `JPH::CollideShapeSettings` named `mActiveEdgeMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mActiveEdgeMode`.
/// When this function is called, this object will drop object references it held previously in `mActiveEdgeMode`.
JOLT_API void JPH_CollideShapeSettings_Set_mActiveEdgeMode(JPH_CollideShapeSettings *_this, JPH_EActiveEdgeMode value);

/// How active edges (edges that a moving object should bump into) are handled
/// Returns a mutable pointer to a member variable of class `JPH::CollideShapeSettings` named `mActiveEdgeMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_EActiveEdgeMode *JPH_CollideShapeSettings_GetMutable_mActiveEdgeMode(JPH_CollideShapeSettings *_this);

/// If colliding faces should be collected or only the collision point
/// Returns a pointer to a member variable of class `JPH::CollideShapeSettings` named `mCollectFacesMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_ECollectFacesMode *JPH_CollideShapeSettings_Get_mCollectFacesMode(const JPH_CollideShapeSettings *_this);

/// If colliding faces should be collected or only the collision point
/// Modifies a member variable of class `JPH::CollideShapeSettings` named `mCollectFacesMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mCollectFacesMode`.
/// When this function is called, this object will drop object references it held previously in `mCollectFacesMode`.
JOLT_API void JPH_CollideShapeSettings_Set_mCollectFacesMode(JPH_CollideShapeSettings *_this, JPH_ECollectFacesMode value);

/// If colliding faces should be collected or only the collision point
/// Returns a mutable pointer to a member variable of class `JPH::CollideShapeSettings` named `mCollectFacesMode`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_ECollectFacesMode *JPH_CollideShapeSettings_GetMutable_mCollectFacesMode(JPH_CollideShapeSettings *_this);

/// If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter)
/// Returns a pointer to a member variable of class `JPH::CollideShapeSettings` named `mCollisionTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CollideShapeSettings_Get_mCollisionTolerance(const JPH_CollideShapeSettings *_this);

/// If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter)
/// Modifies a member variable of class `JPH::CollideShapeSettings` named `mCollisionTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mCollisionTolerance`.
JOLT_API void JPH_CollideShapeSettings_Set_mCollisionTolerance(JPH_CollideShapeSettings *_this, float value);

/// If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter)
/// Returns a mutable pointer to a member variable of class `JPH::CollideShapeSettings` named `mCollisionTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CollideShapeSettings_GetMutable_mCollisionTolerance(JPH_CollideShapeSettings *_this);

/// A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless)
/// Returns a pointer to a member variable of class `JPH::CollideShapeSettings` named `mPenetrationTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CollideShapeSettings_Get_mPenetrationTolerance(const JPH_CollideShapeSettings *_this);

/// A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless)
/// Modifies a member variable of class `JPH::CollideShapeSettings` named `mPenetrationTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mPenetrationTolerance`.
JOLT_API void JPH_CollideShapeSettings_Set_mPenetrationTolerance(JPH_CollideShapeSettings *_this, float value);

/// A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless)
/// Returns a mutable pointer to a member variable of class `JPH::CollideShapeSettings` named `mPenetrationTolerance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CollideShapeSettings_GetMutable_mPenetrationTolerance(JPH_CollideShapeSettings *_this);

/// When mActiveEdgeMode is CollideOnlyWithActive a movement direction can be provided. When hitting an inactive edge, the system will select the triangle normal as penetration depth only if it impedes the movement less than with the calculated penetration depth.
/// Returns a pointer to a member variable of class `JPH::CollideShapeSettings` named `mActiveEdgeMovementDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CollideShapeSettings_Get_mActiveEdgeMovementDirection(const JPH_CollideShapeSettings *_this);

/// When mActiveEdgeMode is CollideOnlyWithActive a movement direction can be provided. When hitting an inactive edge, the system will select the triangle normal as penetration depth only if it impedes the movement less than with the calculated penetration depth.
/// Returns a mutable pointer to a member variable of class `JPH::CollideShapeSettings` named `mActiveEdgeMovementDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CollideShapeSettings_GetMutable_mActiveEdgeMovementDirection(JPH_CollideShapeSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CollideShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CollideShapeSettings *JPH_CollideShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CollideShapeSettings_DestroyArray()`.
/// Use `JPH_CollideShapeSettings_OffsetMutablePtr()` and `JPH_CollideShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_CollideShapeSettings *JPH_CollideShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CollideShapeSettings *JPH_CollideShapeSettings_OffsetPtr(const JPH_CollideShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CollideShapeSettings *JPH_CollideShapeSettings_OffsetMutablePtr(JPH_CollideShapeSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::CollideShapeSettings` to its base class `JPH::CollideSettingsBase`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CollideSettingsBase *JPH_CollideShapeSettings_UpcastTo_JPH_CollideSettingsBase(const JPH_CollideShapeSettings *object);

/// Upcasts an instance of `JPH::CollideShapeSettings` to its base class `JPH::CollideSettingsBase`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CollideSettingsBase *JPH_CollideShapeSettings_MutableUpcastTo_JPH_CollideSettingsBase(JPH_CollideShapeSettings *object);

/// Downcasts an instance of `JPH::CollideSettingsBase` to a derived class `JPH::CollideShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CollideShapeSettings *JPH_CollideShapeSettings_StaticDowncastFrom_JPH_CollideSettingsBase(const JPH_CollideSettingsBase *object);

/// Downcasts an instance of `JPH::CollideSettingsBase` to a derived class `JPH::CollideShapeSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CollideShapeSettings *JPH_CollideShapeSettings_MutableStaticDowncastFrom_JPH_CollideSettingsBase(JPH_CollideSettingsBase *object);

/// Generated from constructor `JPH::CollideShapeSettings::CollideShapeSettings`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CollideShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CollideShapeSettings *JPH_CollideShapeSettings_ConstructFromAnother(const JPH_CollideShapeSettings *_other);

/// Destroys a heap-allocated instance of `JPH_CollideShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CollideShapeSettings_Destroy(const JPH_CollideShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_CollideShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CollideShapeSettings_DestroyArray(const JPH_CollideShapeSettings *_this);

/// Generated from method `JPH::CollideShapeSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CollideShapeSettings *JPH_CollideShapeSettings_AssignFromAnother(JPH_CollideShapeSettings *_this, const JPH_CollideShapeSettings *_other);

/// Generated from method `JPH::CollideShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_CollideShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::CollideShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CollideShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::CollideShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CollideShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CollideShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CollideShapeSettings_size_t(size_t inCount);

/// Generated from method `JPH::CollideShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CollideShapeSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::CollideShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CollideShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CollideShapeSettings::operator new`.
JOLT_API void *Jolt_new_JPH_CollideShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CollideShapeSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CollideShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CollideShapeSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CollideShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CollideShapeSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CollideShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

#ifdef __cplusplus
} // extern "C"
#endif
