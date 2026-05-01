// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// @brief A sub shape id contains a path to an element (usually a triangle or other primitive type) of a compound shape
///
/// Each sub shape knows how many bits it needs to encode its ID, so knows how many bits to take from the sub shape ID.
///
/// For example:
/// * We have a CompoundShape A with 5 child shapes (identify sub shape using 3 bits AAA)
/// * One of its child shapes is CompoundShape B which has 3 child shapes (identify sub shape using 2 bits BB)
/// * One of its child shapes is MeshShape C which contains enough triangles to need 7 bits to identify a triangle (identify sub shape using 7 bits CCCCCCC, note that MeshShape is block based and sorts triangles spatially, you can't assume that the first triangle will have bit pattern 0000000).
///
/// The bit pattern of the sub shape ID to identify a triangle in MeshShape C will then be CCCCCCCBBAAA.
///
/// A sub shape ID will become invalid when the structure of the shape changes. For example, if a child shape is removed from a compound shape, the sub shape ID will no longer be valid.
/// This can be a problem when caching sub shape IDs from one frame to the next. See comments at ContactListener::OnContactPersisted / OnContactRemoved.
/// Generated from class `JPH::SubShapeID`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SubShapeID JPH_SubShapeID;

/// A sub shape id creator can be used to create a new sub shape id by recursing through the shape
/// hierarchy and pushing new ID's onto the chain
/// Generated from class `JPH::SubShapeIDCreator`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_SubShapeIDCreator JPH_SubShapeIDCreator;

/// How many bits we can store in this ID
/// Returns a pointer to a member variable of class `JPH::SubShapeID` named `MaxBits`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_SubShapeID_Get_MaxBits(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SubShapeID_Destroy()` to free it when you're done using it.
JOLT_API JPH_SubShapeID *JPH_SubShapeID_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SubShapeID_DestroyArray()`.
/// Use `JPH_SubShapeID_OffsetMutablePtr()` and `JPH_SubShapeID_OffsetPtr()` to access the array elements.
JOLT_API JPH_SubShapeID *JPH_SubShapeID_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SubShapeID *JPH_SubShapeID_OffsetPtr(const JPH_SubShapeID *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SubShapeID *JPH_SubShapeID_OffsetMutablePtr(JPH_SubShapeID *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SubShapeID::SubShapeID`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SubShapeID_Destroy()` to free it when you're done using it.
JOLT_API JPH_SubShapeID *JPH_SubShapeID_ConstructFromAnother(const JPH_SubShapeID *_other);

/// Destroys a heap-allocated instance of `JPH_SubShapeID`. Does nothing if the pointer is null.
JOLT_API void JPH_SubShapeID_Destroy(const JPH_SubShapeID *_this);

/// Destroys a heap-allocated array of `JPH_SubShapeID`. Does nothing if the pointer is null.
JOLT_API void JPH_SubShapeID_DestroyArray(const JPH_SubShapeID *_this);

/// Generated from method `JPH::SubShapeID::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SubShapeID *JPH_SubShapeID_AssignFromAnother(JPH_SubShapeID *_this, const JPH_SubShapeID *_other);

/// Generated from method `JPH::SubShapeID::operator new`.
JOLT_API void *Jolt_new_JPH_SubShapeID_size_t(size_t inCount);

/// Generated from method `JPH::SubShapeID::operator delete`.
JOLT_API void Jolt_delete_JPH_SubShapeID_void_ptr(void *inPointer);

/// Generated from method `JPH::SubShapeID::operator delete`.
JOLT_API void Jolt_delete_JPH_SubShapeID_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SubShapeID::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SubShapeID_size_t(size_t inCount);

/// Generated from method `JPH::SubShapeID::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SubShapeID_void_ptr(void *inPointer);

/// Generated from method `JPH::SubShapeID::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SubShapeID_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SubShapeID::operator new`.
JOLT_API void *Jolt_new_JPH_SubShapeID_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SubShapeID::operator delete`.
JOLT_API void Jolt_delete_JPH_SubShapeID_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SubShapeID::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SubShapeID_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SubShapeID::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SubShapeID_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Get the next id in the chain of ids (pops parents before children)
/// Generated from method `JPH::SubShapeID::PopID`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outRemainder` can not be null. It is a single object.
JOLT_API unsigned int JPH_SubShapeID_PopID(const JPH_SubShapeID *_this, unsigned int inBits, JPH_SubShapeID *outRemainder);

/// Get the value of the path to the sub shape ID
/// Generated from method `JPH::SubShapeID::GetValue`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SubShapeID_GetValue(const JPH_SubShapeID *_this);

/// Set the value of the sub shape ID (use with care!)
/// Generated from method `JPH::SubShapeID::SetValue`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_SubShapeID_SetValue(JPH_SubShapeID *_this, unsigned int inValue);

/// Check if there is any bits of subshape ID left.
/// Note that this is not a 100% guarantee as the subshape ID could consist of all 1 bits. Use for asserts only.
/// Generated from method `JPH::SubShapeID::IsEmpty`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_SubShapeID_IsEmpty(const JPH_SubShapeID *_this);

/// Check equal
/// Generated from method `JPH::SubShapeID::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_SubShapeID(const JPH_SubShapeID *_this, const JPH_SubShapeID *inRHS);

/// Check not-equal
/// Generated from method `JPH::SubShapeID::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_SubShapeID(const JPH_SubShapeID *_this, const JPH_SubShapeID *inRHS);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SubShapeIDCreator_Destroy()` to free it when you're done using it.
JOLT_API JPH_SubShapeIDCreator *JPH_SubShapeIDCreator_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_SubShapeIDCreator_DestroyArray()`.
/// Use `JPH_SubShapeIDCreator_OffsetMutablePtr()` and `JPH_SubShapeIDCreator_OffsetPtr()` to access the array elements.
JOLT_API JPH_SubShapeIDCreator *JPH_SubShapeIDCreator_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SubShapeIDCreator *JPH_SubShapeIDCreator_OffsetPtr(const JPH_SubShapeIDCreator *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SubShapeIDCreator *JPH_SubShapeIDCreator_OffsetMutablePtr(JPH_SubShapeIDCreator *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::SubShapeIDCreator::SubShapeIDCreator`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SubShapeIDCreator_Destroy()` to free it when you're done using it.
JOLT_API JPH_SubShapeIDCreator *JPH_SubShapeIDCreator_ConstructFromAnother(const JPH_SubShapeIDCreator *_other);

/// Destroys a heap-allocated instance of `JPH_SubShapeIDCreator`. Does nothing if the pointer is null.
JOLT_API void JPH_SubShapeIDCreator_Destroy(const JPH_SubShapeIDCreator *_this);

/// Destroys a heap-allocated array of `JPH_SubShapeIDCreator`. Does nothing if the pointer is null.
JOLT_API void JPH_SubShapeIDCreator_DestroyArray(const JPH_SubShapeIDCreator *_this);

/// Generated from method `JPH::SubShapeIDCreator::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_SubShapeIDCreator *JPH_SubShapeIDCreator_AssignFromAnother(JPH_SubShapeIDCreator *_this, const JPH_SubShapeIDCreator *_other);

/// Add a new id to the chain of id's and return it
/// Generated from method `JPH::SubShapeIDCreator::PushID`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SubShapeIDCreator_Destroy()` to free it when you're done using it.
JOLT_API JPH_SubShapeIDCreator *JPH_SubShapeIDCreator_PushID(const JPH_SubShapeIDCreator *_this, unsigned int inValue, unsigned int inBits);

// Get the resulting sub shape ID
/// Generated from method `JPH::SubShapeIDCreator::GetID`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_SubShapeID *JPH_SubShapeIDCreator_GetID(const JPH_SubShapeIDCreator *_this);

/// Get the number of bits that have been written to the sub shape ID so far
/// Generated from method `JPH::SubShapeIDCreator::GetNumBitsWritten`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_SubShapeIDCreator_GetNumBitsWritten(const JPH_SubShapeIDCreator *_this);

#ifdef __cplusplus
} // extern "C"
#endif
