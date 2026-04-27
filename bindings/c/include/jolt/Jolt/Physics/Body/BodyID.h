// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// ID of a body. This is a way of reasoning about bodies in a multithreaded simulation while avoiding race conditions.
/// Generated from class `JPH::BodyID`.
typedef struct JPH_BodyID
{
    unsigned char _data[4];
} JPH_BodyID;

///< The value for an invalid body ID
/// Returns a pointer to a member variable of class `JPH::BodyID` named `cInvalidBodyID`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_BodyID_Get_cInvalidBodyID(void);

///< This bit is used by the broadphase
/// Returns a pointer to a member variable of class `JPH::BodyID` named `cBroadPhaseBit`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_BodyID_Get_cBroadPhaseBit(void);

///< Maximum value for body index (also the maximum amount of bodies supported - 1)
/// Returns a pointer to a member variable of class `JPH::BodyID` named `cMaxBodyIndex`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_BodyID_Get_cMaxBodyIndex(void);

///< Maximum value for the sequence number
/// Returns a pointer to a member variable of class `JPH::BodyID` named `cMaxSequenceNumber`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned char *JPH_BodyID_Get_cMaxSequenceNumber(void);

///< Number of bits to shift to get the sequence number
/// Returns a pointer to a member variable of class `JPH::BodyID` named `cSequenceNumberShift`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_BodyID_Get_cSequenceNumberShift(void);

/// Constructs an empty (default-constructed) instance.
JOLT_API JPH_BodyID JPH_BodyID_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `Jolt_FreeArray()`.
/// Use `JPH_BodyID_OffsetMutablePtr()` and `JPH_BodyID_OffsetPtr()` to access the array elements.
JOLT_API JPH_BodyID *JPH_BodyID_DefaultConstructArray(size_t num_elems);

/// Construct from index and sequence number combined in a single uint32 (use with care!)
/// Generated from constructor `JPH::BodyID::BodyID`.
JOLT_API JPH_BodyID JPH_BodyID_Construct_1(unsigned int inID);

/// Construct from index and sequence number
/// Generated from constructor `JPH::BodyID::BodyID`.
JOLT_API JPH_BodyID JPH_BodyID_Construct_2(unsigned int inID, unsigned char inSequenceNumber);

/// Generated from method `JPH::BodyID::operator new`.
JOLT_API void *Jolt_new_JPH_BodyID_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::BodyID::operator delete`.
JOLT_API void Jolt_delete_JPH_BodyID_void_ptr(void *inPointer);

/// Generated from method `JPH::BodyID::operator delete`.
JOLT_API void Jolt_delete_JPH_BodyID_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::BodyID::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BodyID_unsigned_long(unsigned long inCount);

/// Generated from method `JPH::BodyID::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BodyID_void_ptr(void *inPointer);

/// Generated from method `JPH::BodyID::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BodyID_void_ptr_unsigned_long(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::BodyID::operator new`.
JOLT_API void *Jolt_new_JPH_BodyID_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::BodyID::operator delete`.
JOLT_API void Jolt_delete_JPH_BodyID_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::BodyID::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_BodyID_unsigned_long_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::BodyID::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_BodyID_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Get index in body array
/// Generated from method `JPH::BodyID::GetIndex`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_BodyID_GetIndex(const JPH_BodyID *_this);

/// Get sequence number of body.
/// The sequence number can be used to check if a body ID with the same body index has been reused by another body.
/// It is mainly used in multi threaded situations where a body is removed and its body index is immediately reused by a body created from another thread.
/// Functions querying the broadphase can (after acquiring a body lock) detect that the body has been removed (we assume that this won't happen more than 128 times in a row).
/// Generated from method `JPH::BodyID::GetSequenceNumber`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned char JPH_BodyID_GetSequenceNumber(const JPH_BodyID *_this);

/// Returns the index and sequence number combined in an uint32
/// Generated from method `JPH::BodyID::GetIndexAndSequenceNumber`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_BodyID_GetIndexAndSequenceNumber(const JPH_BodyID *_this);

/// Check if the ID is valid
/// Generated from method `JPH::BodyID::IsInvalid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_BodyID_IsInvalid(const JPH_BodyID *_this);

/// Equals check
/// Generated from method `JPH::BodyID::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_BodyID(const JPH_BodyID *_this, const JPH_BodyID *inRHS);

/// Not equals check
/// Generated from method `JPH::BodyID::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_BodyID(const JPH_BodyID *_this, const JPH_BodyID *inRHS);

/// Smaller than operator, can be used for sorting bodies
/// Generated from method `JPH::BodyID::operator<`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_less_JPH_BodyID(const JPH_BodyID *_this, const JPH_BodyID *inRHS);

/// Greater than operator, can be used for sorting bodies
/// Generated from method `JPH::BodyID::operator>`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_greater_JPH_BodyID(const JPH_BodyID *_this, const JPH_BodyID *inRHS);

#ifdef __cplusplus
} // extern "C"
#endif
