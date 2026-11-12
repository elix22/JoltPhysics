// machine generated, do not edit
#pragma once

#include <exports.h>
#include <jolt/Jolt/Physics/Body/BodyID.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.


/// Structure that holds the result of colliding a point against a shape
/// Generated from class `JPH::CollidePointResult`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CollidePointResult JPH_CollidePointResult;

///< Body that was hit
/// Returns a pointer to a member variable of class `JPH::CollidePointResult` named `mBodyID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_BodyID *JPH_CollidePointResult_Get_mBodyID(const JPH_CollidePointResult *_this);

///< Body that was hit
/// Modifies a member variable of class `JPH::CollidePointResult` named `mBodyID`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBodyID`.
/// When this function is called, this object will drop object references it held previously in `mBodyID`.
JOLT_API void JPH_CollidePointResult_Set_mBodyID(JPH_CollidePointResult *_this, JPH_BodyID value);

///< Body that was hit
/// Returns a mutable pointer to a member variable of class `JPH::CollidePointResult` named `mBodyID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_BodyID *JPH_CollidePointResult_GetMutable_mBodyID(JPH_CollidePointResult *_this);

///< Sub shape ID of shape that we collided against
/// Returns a pointer to a member variable of class `JPH::CollidePointResult` named `mSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SubShapeID *JPH_CollidePointResult_Get_mSubShapeID2(const JPH_CollidePointResult *_this);

///< Sub shape ID of shape that we collided against
/// Modifies a member variable of class `JPH::CollidePointResult` named `mSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSubShapeID2`.
/// When this function is called, this object will drop object references it held previously in `mSubShapeID2`.
JOLT_API void JPH_CollidePointResult_Set_mSubShapeID2(JPH_CollidePointResult *_this, const JPH_SubShapeID *value);

///< Sub shape ID of shape that we collided against
/// Returns a mutable pointer to a member variable of class `JPH::CollidePointResult` named `mSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SubShapeID *JPH_CollidePointResult_GetMutable_mSubShapeID2(JPH_CollidePointResult *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CollidePointResult_Destroy()` to free it when you're done using it.
JOLT_API JPH_CollidePointResult *JPH_CollidePointResult_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CollidePointResult_DestroyArray()`.
/// Use `JPH_CollidePointResult_OffsetMutablePtr()` and `JPH_CollidePointResult_OffsetPtr()` to access the array elements.
JOLT_API JPH_CollidePointResult *JPH_CollidePointResult_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::CollidePointResult` elementwise.
/// The reference to the parameter `mBodyID` might be preserved in the constructed object.
/// Parameter `mSubShapeID2` can not be null. It is a single object.
/// The reference to the parameter `mSubShapeID2` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CollidePointResult_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CollidePointResult *JPH_CollidePointResult_ConstructFrom(JPH_BodyID mBodyID, const JPH_SubShapeID *mSubShapeID2);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CollidePointResult *JPH_CollidePointResult_OffsetPtr(const JPH_CollidePointResult *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CollidePointResult *JPH_CollidePointResult_OffsetMutablePtr(JPH_CollidePointResult *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::CollidePointResult::CollidePointResult`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CollidePointResult_Destroy()` to free it when you're done using it.
JOLT_API JPH_CollidePointResult *JPH_CollidePointResult_ConstructFromAnother(const JPH_CollidePointResult *_other);

/// Destroys a heap-allocated instance of `JPH_CollidePointResult`. Does nothing if the pointer is null.
JOLT_API void JPH_CollidePointResult_Destroy(const JPH_CollidePointResult *_this);

/// Destroys a heap-allocated array of `JPH_CollidePointResult`. Does nothing if the pointer is null.
JOLT_API void JPH_CollidePointResult_DestroyArray(const JPH_CollidePointResult *_this);

/// Generated from method `JPH::CollidePointResult::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CollidePointResult *JPH_CollidePointResult_AssignFromAnother(JPH_CollidePointResult *_this, const JPH_CollidePointResult *_other);

/// Generated from method `JPH::CollidePointResult::operator new`.
JOLT_API void *Jolt_new_JPH_CollidePointResult_size_t(size_t inCount);

/// Generated from method `JPH::CollidePointResult::operator delete`.
JOLT_API void Jolt_delete_JPH_CollidePointResult_void_ptr(void *inPointer);

/// Generated from method `JPH::CollidePointResult::operator delete`.
JOLT_API void Jolt_delete_JPH_CollidePointResult_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CollidePointResult::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CollidePointResult_size_t(size_t inCount);

/// Generated from method `JPH::CollidePointResult::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CollidePointResult_void_ptr(void *inPointer);

/// Generated from method `JPH::CollidePointResult::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CollidePointResult_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CollidePointResult::operator new`.
JOLT_API void *Jolt_new_JPH_CollidePointResult_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CollidePointResult::operator delete`.
JOLT_API void Jolt_delete_JPH_CollidePointResult_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CollidePointResult::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CollidePointResult_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CollidePointResult::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CollidePointResult_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Function required by the CollisionCollector. A smaller fraction is considered to be a 'better hit'. For point queries there is no sensible return value.
/// Generated from method `JPH::CollidePointResult::GetEarlyOutFraction`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CollidePointResult_GetEarlyOutFraction(const JPH_CollidePointResult *_this);

#ifdef __cplusplus
} // extern "C"
#endif
