// machine generated, do not edit
#pragma once

#include <exports.h>
#include <jolt/Jolt/Physics/Body/BodyID.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.


/// Structure that holds a ray cast or other object cast hit
/// Generated from class `JPH::BroadPhaseCastResult`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::RayCastResult`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_BroadPhaseCastResult JPH_BroadPhaseCastResult;

/// Specialization of cast result against a shape
/// Generated from class `JPH::RayCastResult`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::BroadPhaseCastResult`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RayCastResult JPH_RayCastResult;

///< Body that was hit
/// Returns a pointer to a member variable of class `JPH::BroadPhaseCastResult` named `mBodyID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_BodyID *JPH_BroadPhaseCastResult_Get_mBodyID(const JPH_BroadPhaseCastResult *_this);

///< Body that was hit
/// Modifies a member variable of class `JPH::BroadPhaseCastResult` named `mBodyID`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBodyID`.
/// When this function is called, this object will drop object references it held previously in `mBodyID`.
JOLT_API void JPH_BroadPhaseCastResult_Set_mBodyID(JPH_BroadPhaseCastResult *_this, JPH_BodyID value);

///< Body that was hit
/// Returns a mutable pointer to a member variable of class `JPH::BroadPhaseCastResult` named `mBodyID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_BodyID *JPH_BroadPhaseCastResult_GetMutable_mBodyID(JPH_BroadPhaseCastResult *_this);

///< Hit fraction of the ray/object [0, 1], HitPoint = Start + mFraction * (End - Start)
/// Returns a pointer to a member variable of class `JPH::BroadPhaseCastResult` named `mFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_BroadPhaseCastResult_Get_mFraction(const JPH_BroadPhaseCastResult *_this);

///< Hit fraction of the ray/object [0, 1], HitPoint = Start + mFraction * (End - Start)
/// Modifies a member variable of class `JPH::BroadPhaseCastResult` named `mFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mFraction`.
JOLT_API void JPH_BroadPhaseCastResult_Set_mFraction(JPH_BroadPhaseCastResult *_this, float value);

///< Hit fraction of the ray/object [0, 1], HitPoint = Start + mFraction * (End - Start)
/// Returns a mutable pointer to a member variable of class `JPH::BroadPhaseCastResult` named `mFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_BroadPhaseCastResult_GetMutable_mFraction(JPH_BroadPhaseCastResult *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BroadPhaseCastResult_Destroy()` to free it when you're done using it.
JOLT_API JPH_BroadPhaseCastResult *JPH_BroadPhaseCastResult_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_BroadPhaseCastResult_DestroyArray()`.
/// Use `JPH_BroadPhaseCastResult_OffsetMutablePtr()` and `JPH_BroadPhaseCastResult_OffsetPtr()` to access the array elements.
JOLT_API JPH_BroadPhaseCastResult *JPH_BroadPhaseCastResult_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::BroadPhaseCastResult` elementwise.
/// The reference to the parameter `mBodyID` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BroadPhaseCastResult_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_BroadPhaseCastResult *JPH_BroadPhaseCastResult_ConstructFrom(JPH_BodyID mBodyID, float mFraction);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseCastResult *JPH_BroadPhaseCastResult_OffsetPtr(const JPH_BroadPhaseCastResult *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_BroadPhaseCastResult *JPH_BroadPhaseCastResult_OffsetMutablePtr(JPH_BroadPhaseCastResult *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::BroadPhaseCastResult::BroadPhaseCastResult`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BroadPhaseCastResult_Destroy()` to free it when you're done using it.
JOLT_API JPH_BroadPhaseCastResult *JPH_BroadPhaseCastResult_ConstructFromAnother(const JPH_BroadPhaseCastResult *_other);

/// Destroys a heap-allocated instance of `JPH_BroadPhaseCastResult`. Does nothing if the pointer is null.
JOLT_API void JPH_BroadPhaseCastResult_Destroy(const JPH_BroadPhaseCastResult *_this);

/// Destroys a heap-allocated array of `JPH_BroadPhaseCastResult`. Does nothing if the pointer is null.
JOLT_API void JPH_BroadPhaseCastResult_DestroyArray(const JPH_BroadPhaseCastResult *_this);

/// Generated from method `JPH::BroadPhaseCastResult::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_BroadPhaseCastResult *JPH_BroadPhaseCastResult_AssignFromAnother(JPH_BroadPhaseCastResult *_this, const JPH_BroadPhaseCastResult *_other);

/// Generated from method `JPH::BroadPhaseCastResult::operator new`.
JOLT_API void *Jolt_new_JPH_BroadPhaseCastResult_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::BroadPhaseCastResult::operator delete`.
JOLT_API void Jolt_delete_JPH_BroadPhaseCastResult_void_ptr(void *inPointer);

/// Generated from method `JPH::BroadPhaseCastResult::operator delete`.
JOLT_API void Jolt_delete_JPH_BroadPhaseCastResult_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::BroadPhaseCastResult::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BroadPhaseCastResult_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::BroadPhaseCastResult::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr(void *inPointer);

/// Generated from method `JPH::BroadPhaseCastResult::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::BroadPhaseCastResult::operator new`.
JOLT_API void *Jolt_new_JPH_BroadPhaseCastResult_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::BroadPhaseCastResult::operator delete`.
JOLT_API void Jolt_delete_JPH_BroadPhaseCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::BroadPhaseCastResult::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BroadPhaseCastResult_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::BroadPhaseCastResult::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Function required by the CollisionCollector. A smaller fraction is considered to be a 'better hit'. For rays/cast shapes we can just use the collision fraction.
/// Generated from method `JPH::BroadPhaseCastResult::GetEarlyOutFraction`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_BroadPhaseCastResult_GetEarlyOutFraction(const JPH_BroadPhaseCastResult *_this);

/// Reset this result so it can be reused for a new cast.
/// Generated from method `JPH::BroadPhaseCastResult::Reset`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_BroadPhaseCastResult_Reset(JPH_BroadPhaseCastResult *_this);

///< Sub shape ID of shape that we collided against
/// Returns a pointer to a member variable of class `JPH::RayCastResult` named `mSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_SubShapeID *JPH_RayCastResult_Get_mSubShapeID2(const JPH_RayCastResult *_this);

///< Sub shape ID of shape that we collided against
/// Modifies a member variable of class `JPH::RayCastResult` named `mSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSubShapeID2`.
/// When this function is called, this object will drop object references it held previously in `mSubShapeID2`.
JOLT_API void JPH_RayCastResult_Set_mSubShapeID2(JPH_RayCastResult *_this, const JPH_SubShapeID *value);

///< Sub shape ID of shape that we collided against
/// Returns a mutable pointer to a member variable of class `JPH::RayCastResult` named `mSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_SubShapeID *JPH_RayCastResult_GetMutable_mSubShapeID2(JPH_RayCastResult *_this);

///< Body that was hit
/// Returns a pointer to a member variable of class `JPH::RayCastResult` named `mBodyID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_BodyID *JPH_RayCastResult_Get_mBodyID(const JPH_RayCastResult *_this);

///< Body that was hit
/// Modifies a member variable of class `JPH::RayCastResult` named `mBodyID`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBodyID`.
/// When this function is called, this object will drop object references it held previously in `mBodyID`.
JOLT_API void JPH_RayCastResult_Set_mBodyID(JPH_RayCastResult *_this, JPH_BodyID value);

///< Body that was hit
/// Returns a mutable pointer to a member variable of class `JPH::RayCastResult` named `mBodyID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_BodyID *JPH_RayCastResult_GetMutable_mBodyID(JPH_RayCastResult *_this);

///< Hit fraction of the ray/object [0, 1], HitPoint = Start + mFraction * (End - Start)
/// Returns a pointer to a member variable of class `JPH::RayCastResult` named `mFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_RayCastResult_Get_mFraction(const JPH_RayCastResult *_this);

///< Hit fraction of the ray/object [0, 1], HitPoint = Start + mFraction * (End - Start)
/// Modifies a member variable of class `JPH::RayCastResult` named `mFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mFraction`.
JOLT_API void JPH_RayCastResult_Set_mFraction(JPH_RayCastResult *_this, float value);

///< Hit fraction of the ray/object [0, 1], HitPoint = Start + mFraction * (End - Start)
/// Returns a mutable pointer to a member variable of class `JPH::RayCastResult` named `mFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_RayCastResult_GetMutable_mFraction(JPH_RayCastResult *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCastResult_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCastResult *JPH_RayCastResult_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RayCastResult_DestroyArray()`.
/// Use `JPH_RayCastResult_OffsetMutablePtr()` and `JPH_RayCastResult_OffsetPtr()` to access the array elements.
JOLT_API JPH_RayCastResult *JPH_RayCastResult_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RayCastResult *JPH_RayCastResult_OffsetPtr(const JPH_RayCastResult *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RayCastResult *JPH_RayCastResult_OffsetMutablePtr(JPH_RayCastResult *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::RayCastResult` to its base class `JPH::BroadPhaseCastResult`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_BroadPhaseCastResult *JPH_RayCastResult_UpcastTo_JPH_BroadPhaseCastResult(const JPH_RayCastResult *object);

/// Upcasts an instance of `JPH::RayCastResult` to its base class `JPH::BroadPhaseCastResult`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_BroadPhaseCastResult *JPH_RayCastResult_MutableUpcastTo_JPH_BroadPhaseCastResult(JPH_RayCastResult *object);

/// Downcasts an instance of `JPH::BroadPhaseCastResult` to a derived class `JPH::RayCastResult`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RayCastResult *JPH_RayCastResult_StaticDowncastFrom_JPH_BroadPhaseCastResult(const JPH_BroadPhaseCastResult *object);

/// Downcasts an instance of `JPH::BroadPhaseCastResult` to a derived class `JPH::RayCastResult`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RayCastResult *JPH_RayCastResult_MutableStaticDowncastFrom_JPH_BroadPhaseCastResult(JPH_BroadPhaseCastResult *object);

/// Generated from constructor `JPH::RayCastResult::RayCastResult`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCastResult_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCastResult *JPH_RayCastResult_ConstructFromAnother(const JPH_RayCastResult *_other);

/// Destroys a heap-allocated instance of `JPH_RayCastResult`. Does nothing if the pointer is null.
JOLT_API void JPH_RayCastResult_Destroy(const JPH_RayCastResult *_this);

/// Destroys a heap-allocated array of `JPH_RayCastResult`. Does nothing if the pointer is null.
JOLT_API void JPH_RayCastResult_DestroyArray(const JPH_RayCastResult *_this);

/// Generated from method `JPH::RayCastResult::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RayCastResult *JPH_RayCastResult_AssignFromAnother(JPH_RayCastResult *_this, const JPH_RayCastResult *_other);

/// Generated from method `JPH::RayCastResult::operator new`.
JOLT_API void *Jolt_new_JPH_RayCastResult_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::RayCastResult::operator delete`.
JOLT_API void Jolt_delete_JPH_RayCastResult_void_ptr(void *inPointer);

/// Generated from method `JPH::RayCastResult::operator delete`.
JOLT_API void Jolt_delete_JPH_RayCastResult_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::RayCastResult::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RayCastResult_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::RayCastResult::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RayCastResult_void_ptr(void *inPointer);

/// Generated from method `JPH::RayCastResult::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RayCastResult_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::RayCastResult::operator new`.
JOLT_API void *Jolt_new_JPH_RayCastResult_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::RayCastResult::operator delete`.
JOLT_API void Jolt_delete_JPH_RayCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::RayCastResult::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RayCastResult_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::RayCastResult::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RayCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Function required by the CollisionCollector. A smaller fraction is considered to be a 'better hit'. For rays/cast shapes we can just use the collision fraction.
/// Generated from method `JPH::RayCastResult::GetEarlyOutFraction`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_RayCastResult_GetEarlyOutFraction(const JPH_RayCastResult *_this);

/// Reset this result so it can be reused for a new cast.
/// Generated from method `JPH::RayCastResult::Reset`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RayCastResult_Reset(JPH_RayCastResult *_this);

#ifdef __cplusplus
} // extern "C"
#endif
