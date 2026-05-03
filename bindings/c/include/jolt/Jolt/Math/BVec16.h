// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct Jolt_std_ostream Jolt_std_ostream; // Defined in `#include <iostream.h>`.


/// A vector consisting of 16 bytes
/// Generated from class `JPH::BVec16`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_BVec16 JPH_BVec16;

/// Returns a pointer to a member variable of class `JPH::BVec16` named `mU8`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned char *JPH_BVec16_Get_mU8(const JPH_BVec16 *_this);

/// Returns a mutable pointer to a member variable of class `JPH::BVec16` named `mU8`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned char *JPH_BVec16_GetMutable_mU8(JPH_BVec16 *_this);

/// Returns the size of the array member of class `JPH::BVec16` named `mU8`. The size is `16`.
JOLT_API size_t JPH_BVec16_GetSize_mU8(void);

/// Returns a pointer to a member variable of class `JPH::BVec16` named `mU64`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const uint64_t *JPH_BVec16_Get_mU64(const JPH_BVec16 *_this);

/// Returns a mutable pointer to a member variable of class `JPH::BVec16` named `mU64`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API uint64_t *JPH_BVec16_GetMutable_mU64(JPH_BVec16 *_this);

/// Returns the size of the array member of class `JPH::BVec16` named `mU64`. The size is `2`.
JOLT_API size_t JPH_BVec16_GetSize_mU64(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BVec16_Destroy()` to free it when you're done using it.
JOLT_API JPH_BVec16 *JPH_BVec16_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_BVec16_DestroyArray()`.
/// Use `JPH_BVec16_OffsetMutablePtr()` and `JPH_BVec16_OffsetPtr()` to access the array elements.
JOLT_API JPH_BVec16 *JPH_BVec16_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_BVec16 *JPH_BVec16_OffsetPtr(const JPH_BVec16 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_BVec16 *JPH_BVec16_OffsetMutablePtr(JPH_BVec16 *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::BVec16::BVec16`.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BVec16_Destroy()` to free it when you're done using it.
JOLT_API JPH_BVec16 *JPH_BVec16_ConstructFromAnother(const JPH_BVec16 *inRHS);

/// Create a vector from 16 bytes
/// Generated from constructor `JPH::BVec16::BVec16`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BVec16_Destroy()` to free it when you're done using it.
JOLT_API JPH_BVec16 *JPH_BVec16_Construct_16(unsigned char inB0, unsigned char inB1, unsigned char inB2, unsigned char inB3, unsigned char inB4, unsigned char inB5, unsigned char inB6, unsigned char inB7, unsigned char inB8, unsigned char inB9, unsigned char inB10, unsigned char inB11, unsigned char inB12, unsigned char inB13, unsigned char inB14, unsigned char inB15);

/// Create a vector from two uint64's
/// Generated from constructor `JPH::BVec16::BVec16`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BVec16_Destroy()` to free it when you're done using it.
JOLT_API JPH_BVec16 *JPH_BVec16_Construct_2(uint64_t inV0, uint64_t inV1);

/// Destroys a heap-allocated instance of `JPH_BVec16`. Does nothing if the pointer is null.
JOLT_API void JPH_BVec16_Destroy(const JPH_BVec16 *_this);

/// Destroys a heap-allocated array of `JPH_BVec16`. Does nothing if the pointer is null.
JOLT_API void JPH_BVec16_DestroyArray(const JPH_BVec16 *_this);

/// Generated from method `JPH::BVec16::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_BVec16 *JPH_BVec16_AssignFromAnother(JPH_BVec16 *_this, const JPH_BVec16 *inRHS);

/// Generated from method `JPH::BVec16::operator new`.
JOLT_API void *Jolt_new_JPH_BVec16_size_t(size_t inCount);

/// Generated from method `JPH::BVec16::operator delete`.
JOLT_API void Jolt_delete_JPH_BVec16_void_ptr(void *inPointer);

/// Generated from method `JPH::BVec16::operator delete`.
JOLT_API void Jolt_delete_JPH_BVec16_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::BVec16::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BVec16_size_t(size_t inCount);

/// Generated from method `JPH::BVec16::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BVec16_void_ptr(void *inPointer);

/// Generated from method `JPH::BVec16::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BVec16_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::BVec16::operator new`.
JOLT_API void *Jolt_new_JPH_BVec16_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::BVec16::operator delete`.
JOLT_API void Jolt_delete_JPH_BVec16_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::BVec16::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BVec16_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::BVec16::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BVec16_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Comparison
/// Generated from method `JPH::BVec16::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_BVec16(const JPH_BVec16 *_this, const JPH_BVec16 *inV2);

/// Generated from method `JPH::BVec16::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_BVec16(const JPH_BVec16 *_this, const JPH_BVec16 *inV2);

/// Vector with all zeros
/// Generated from method `JPH::BVec16::sZero`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BVec16_Destroy()` to free it when you're done using it.
JOLT_API JPH_BVec16 *JPH_BVec16_sZero(void);

/// Replicate int inV across all components
/// Generated from method `JPH::BVec16::sReplicate`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BVec16_Destroy()` to free it when you're done using it.
JOLT_API JPH_BVec16 *JPH_BVec16_sReplicate(unsigned char inV);

/// Load 16 bytes from memory
/// Generated from method `JPH::BVec16::sLoadByte16`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BVec16_Destroy()` to free it when you're done using it.
JOLT_API JPH_BVec16 *JPH_BVec16_sLoadByte16(const unsigned char *inV);

/// Equals (component wise), highest bit of each component that is set is considered true
/// Generated from method `JPH::BVec16::sEquals`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BVec16_Destroy()` to free it when you're done using it.
JOLT_API JPH_BVec16 *JPH_BVec16_sEquals(const JPH_BVec16 *inV1, const JPH_BVec16 *inV2);

/// Logical or (component wise)
/// Generated from method `JPH::BVec16::sOr`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BVec16_Destroy()` to free it when you're done using it.
JOLT_API JPH_BVec16 *JPH_BVec16_sOr(const JPH_BVec16 *inV1, const JPH_BVec16 *inV2);

/// Logical xor (component wise)
/// Generated from method `JPH::BVec16::sXor`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BVec16_Destroy()` to free it when you're done using it.
JOLT_API JPH_BVec16 *JPH_BVec16_sXor(const JPH_BVec16 *inV1, const JPH_BVec16 *inV2);

/// Logical and (component wise)
/// Generated from method `JPH::BVec16::sAnd`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BVec16_Destroy()` to free it when you're done using it.
JOLT_API JPH_BVec16 *JPH_BVec16_sAnd(const JPH_BVec16 *inV1, const JPH_BVec16 *inV2);

/// Logical not (component wise)
/// Generated from method `JPH::BVec16::sNot`.
/// Parameter `inV1` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_BVec16_Destroy()` to free it when you're done using it.
JOLT_API JPH_BVec16 *JPH_BVec16_sNot(const JPH_BVec16 *inV1);

/// Get component by index
/// Generated from method `JPH::BVec16::operator[]`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned char JPH_BVec16_index(const JPH_BVec16 *_this, unsigned int inCoordinate);

/// Generated from method `JPH::BVec16::operator[]`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API unsigned char *JPH_BVec16_index_mut(JPH_BVec16 *_this, unsigned int inCoordinate);

/// Test if any of the components are true (true is when highest bit of component is set)
/// Generated from method `JPH::BVec16::TestAnyTrue`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_BVec16_TestAnyTrue(const JPH_BVec16 *_this);

/// Test if all components are true (true is when highest bit of component is set)
/// Generated from method `JPH::BVec16::TestAllTrue`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_BVec16_TestAllTrue(const JPH_BVec16 *_this);

/// Store if mU8[0] is true in bit 0, mU8[1] in bit 1, etc. (true is when highest bit of component is set)
/// Generated from method `JPH::BVec16::GetTrues`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API int JPH_BVec16_GetTrues(const JPH_BVec16 *_this);

/// To String
/// Generated from function `JPH::operator<<`.
/// Parameter `inStream` can not be null. It is a single object.
/// Parameter `inV` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_std_ostream *Jolt_print_JPH_BVec16(Jolt_std_ostream *inStream, const JPH_BVec16 *inV);

#ifdef __cplusplus
} // extern "C"
#endif
