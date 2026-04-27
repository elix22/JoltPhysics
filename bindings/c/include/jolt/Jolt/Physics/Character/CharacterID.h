// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif


/// ID of a character. Used primarily to identify deleted characters and to sort deterministically.
/// Generated from class `JPH::CharacterID`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CharacterID JPH_CharacterID;

///< The value for an invalid character ID
/// Returns a pointer to a member variable of class `JPH::CharacterID` named `cInvalidCharacterID`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const unsigned int *JPH_CharacterID_Get_cInvalidCharacterID(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterID_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterID *JPH_CharacterID_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CharacterID_DestroyArray()`.
/// Use `JPH_CharacterID_OffsetMutablePtr()` and `JPH_CharacterID_OffsetPtr()` to access the array elements.
JOLT_API JPH_CharacterID *JPH_CharacterID_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CharacterID *JPH_CharacterID_OffsetPtr(const JPH_CharacterID *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CharacterID *JPH_CharacterID_OffsetMutablePtr(JPH_CharacterID *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::CharacterID::CharacterID`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterID_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterID *JPH_CharacterID_ConstructFromAnother(const JPH_CharacterID *_other);

/// Construct with specific value, make sure you don't use the same value twice!
/// Generated from constructor `JPH::CharacterID::CharacterID`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterID_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterID *JPH_CharacterID_Construct(unsigned int inID);

/// Destroys a heap-allocated instance of `JPH_CharacterID`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterID_Destroy(const JPH_CharacterID *_this);

/// Destroys a heap-allocated array of `JPH_CharacterID`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterID_DestroyArray(const JPH_CharacterID *_this);

/// Generated from method `JPH::CharacterID::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CharacterID *JPH_CharacterID_AssignFromAnother(JPH_CharacterID *_this, const JPH_CharacterID *_other);

/// Generated from method `JPH::CharacterID::operator new`.
JOLT_API void *Jolt_new_JPH_CharacterID_size_t(unsigned long inCount);

/// Generated from method `JPH::CharacterID::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterID_void_ptr(void *inPointer);

/// Generated from method `JPH::CharacterID::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterID_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::CharacterID::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CharacterID_size_t(unsigned long inCount);

/// Generated from method `JPH::CharacterID::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterID_void_ptr(void *inPointer);

/// Generated from method `JPH::CharacterID::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterID_void_ptr_size_t(void *inPointer, unsigned long inSize);

/// Generated from method `JPH::CharacterID::operator new`.
JOLT_API void *Jolt_new_JPH_CharacterID_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::CharacterID::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterID_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CharacterID::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CharacterID_size_t_void_ptr(unsigned long inCount, void *inPointer);

/// Generated from method `JPH::CharacterID::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterID_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Get the numeric value of the ID
/// Generated from method `JPH::CharacterID::GetValue`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CharacterID_GetValue(const JPH_CharacterID *_this);

/// Check if the ID is valid
/// Generated from method `JPH::CharacterID::IsInvalid`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_CharacterID_IsInvalid(const JPH_CharacterID *_this);

/// Equals check
/// Generated from method `JPH::CharacterID::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_CharacterID(const JPH_CharacterID *_this, const JPH_CharacterID *inRHS);

/// Not equals check
/// Generated from method `JPH::CharacterID::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_CharacterID(const JPH_CharacterID *_this, const JPH_CharacterID *inRHS);

/// Smaller than operator, can be used for sorting characters
/// Generated from method `JPH::CharacterID::operator<`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_less_JPH_CharacterID(const JPH_CharacterID *_this, const JPH_CharacterID *inRHS);

/// Greater than operator, can be used for sorting characters
/// Generated from method `JPH::CharacterID::operator>`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_greater_JPH_CharacterID(const JPH_CharacterID *_this, const JPH_CharacterID *inRHS);

/// Get the hash for this character ID
/// Generated from method `JPH::CharacterID::GetHash`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_CharacterID_GetHash(const JPH_CharacterID *_this);

/// Generate the next available character ID
/// Generated from method `JPH::CharacterID::sNextCharacterID`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterID_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterID *JPH_CharacterID_sNextCharacterID(void);

/// Set the next available character ID, can be used after destroying all character to prepare for a second deterministic run
/// Generated from method `JPH::CharacterID::sSetNextCharacterID`.
/// Parameter `inNextValue` has a default argument: `1`, pass a null pointer to use it.
JOLT_API void JPH_CharacterID_sSetNextCharacterID(const unsigned int *inNextValue);

#ifdef __cplusplus
} // extern "C"
#endif
