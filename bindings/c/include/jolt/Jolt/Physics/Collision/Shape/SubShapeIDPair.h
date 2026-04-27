// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_BodyID JPH_BodyID; // Defined in `#include <jolt/Jolt/Physics/Body/BodyID.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.


/// A pair of bodies and their sub shape ID's. Can be used as a key in a map to find a contact point.
/// Generated from class `JPH::SubShapeIDPair`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SubShapeIDPair JPH_SubShapeIDPair;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SubShapeIDPair_Destroy()` to free it when you're done using it.
JOLT_API JPH_SubShapeIDPair *JPH_SubShapeIDPair_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SubShapeIDPair_DestroyArray()`.
/// Use `JPH_SubShapeIDPair_OffsetMutablePtr()` and `JPH_SubShapeIDPair_OffsetPtr()` to access the array elements.
JOLT_API JPH_SubShapeIDPair *JPH_SubShapeIDPair_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SubShapeIDPair *JPH_SubShapeIDPair_OffsetPtr(const JPH_SubShapeIDPair *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SubShapeIDPair *JPH_SubShapeIDPair_OffsetMutablePtr(JPH_SubShapeIDPair *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SubShapeIDPair::SubShapeIDPair`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SubShapeIDPair_Destroy()` to free it when you're done using it.
JOLT_API JPH_SubShapeIDPair *JPH_SubShapeIDPair_ConstructFromAnother(const JPH_SubShapeIDPair *_other);

/// Generated from constructor `JPH::SubShapeIDPair::SubShapeIDPair`.
/// Parameter `inBody1ID` can not be null. It is a single object.
/// Parameter `inSubShapeID1` can not be null. It is a single object.
/// Parameter `inBody2ID` can not be null. It is a single object.
/// Parameter `inSubShapeID2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SubShapeIDPair_Destroy()` to free it when you're done using it.
JOLT_API JPH_SubShapeIDPair *JPH_SubShapeIDPair_Construct(const JPH_BodyID *inBody1ID, const JPH_SubShapeID *inSubShapeID1, const JPH_BodyID *inBody2ID, const JPH_SubShapeID *inSubShapeID2);

/// Destroys a heap-allocated instance of `JPH_SubShapeIDPair`. Does nothing if the pointer is null.
JOLT_API void JPH_SubShapeIDPair_Destroy(const JPH_SubShapeIDPair *_this);

/// Destroys a heap-allocated array of `JPH_SubShapeIDPair`. Does nothing if the pointer is null.
JOLT_API void JPH_SubShapeIDPair_DestroyArray(const JPH_SubShapeIDPair *_this);

/// Generated from method `JPH::SubShapeIDPair::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SubShapeIDPair *JPH_SubShapeIDPair_AssignFromAnother(JPH_SubShapeIDPair *_this, const JPH_SubShapeIDPair *_other);

/// Generated from method `JPH::SubShapeIDPair::operator new`.
JOLT_API void *Jolt_new_JPH_SubShapeIDPair_size_t(unsigned long inCount);

/// Generated from method `JPH::SubShapeIDPair::operator delete`.
JOLT_API void Jolt_delete_JPH_SubShapeIDPair_void_ptr(void *inPointer);

/// Generated from method `JPH::SubShapeIDPair::operator delete`.
JOLT_API void Jolt_delete_JPH_SubShapeIDPair_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SubShapeIDPair::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SubShapeIDPair_size_t(unsigned long inCount);

/// Generated from method `JPH::SubShapeIDPair::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SubShapeIDPair_void_ptr(void *inPointer);

/// Generated from method `JPH::SubShapeIDPair::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SubShapeIDPair_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::SubShapeIDPair::operator new`.
JOLT_API void *Jolt_new_JPH_SubShapeIDPair_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SubShapeIDPair::operator delete`.
JOLT_API void Jolt_delete_JPH_SubShapeIDPair_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SubShapeIDPair::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SubShapeIDPair_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::SubShapeIDPair::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SubShapeIDPair_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Equality operator
/// Generated from method `JPH::SubShapeIDPair::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_SubShapeIDPair(const JPH_SubShapeIDPair *_this, const JPH_SubShapeIDPair *inRHS);

/// Less than operator, used to consistently order contact points for a deterministic simulation
/// Generated from method `JPH::SubShapeIDPair::operator<`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_less_JPH_SubShapeIDPair(const JPH_SubShapeIDPair *_this, const JPH_SubShapeIDPair *inRHS);

/// Generated from method `JPH::SubShapeIDPair::GetBody1ID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_BodyID *JPH_SubShapeIDPair_GetBody1ID(const JPH_SubShapeIDPair *_this);

/// Generated from method `JPH::SubShapeIDPair::GetSubShapeID1`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_SubShapeID *JPH_SubShapeIDPair_GetSubShapeID1(const JPH_SubShapeIDPair *_this);

/// Generated from method `JPH::SubShapeIDPair::GetBody2ID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_BodyID *JPH_SubShapeIDPair_GetBody2ID(const JPH_SubShapeIDPair *_this);

/// Generated from method `JPH::SubShapeIDPair::GetSubShapeID2`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_SubShapeID *JPH_SubShapeIDPair_GetSubShapeID2(const JPH_SubShapeIDPair *_this);

/// Generated from method `JPH::SubShapeIDPair::GetHash`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_SubShapeIDPair_GetHash(const JPH_SubShapeIDPair *_this);

#ifdef __cplusplus
} // extern "C"
#endif
