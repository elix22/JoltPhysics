// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_CharacterVirtual_Contact JPH_CharacterVirtual_Contact; // Defined in `#include <jolt/Jolt/Physics/Character/CharacterVirtual.h>`.


/// Generated from C++ container `JPH::Array<JPH::CharacterVirtual::Contact>`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct Jolt_JPH_Array_JPH_CharacterVirtual_Contact Jolt_JPH_Array_JPH_CharacterVirtual_Contact;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `Jolt_JPH_Array_JPH_CharacterVirtual_Contact_Destroy()` to free it when you're done using it.
JOLT_API Jolt_JPH_Array_JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `Jolt_JPH_Array_JPH_CharacterVirtual_Contact_DestroyArray()`.
/// Use `Jolt_JPH_Array_JPH_CharacterVirtual_Contact_OffsetMutablePtr()` and `Jolt_JPH_Array_JPH_CharacterVirtual_Contact_OffsetPtr()` to access the array elements.
JOLT_API Jolt_JPH_Array_JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_DefaultConstructArray(size_t num_elems);

/// Constructs a copy of another instance. The source remains alive.
/// The reference to the parameter `other` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `Jolt_JPH_Array_JPH_CharacterVirtual_Contact_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API Jolt_JPH_Array_JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_CharacterVirtual_Contact *other);

/// Assigns the contents from another instance. Both objects remain alive after the call.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `other` might be preserved in this object.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_AssignFromAnother(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_CharacterVirtual_Contact *other);

/// Destroys a heap-allocated instance of `Jolt_JPH_Array_JPH_CharacterVirtual_Contact`. Does nothing if the pointer is null.
JOLT_API void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_Destroy(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this);

/// Destroys a heap-allocated array of `Jolt_JPH_Array_JPH_CharacterVirtual_Contact`. Does nothing if the pointer is null.
JOLT_API void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_DestroyArray(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_OffsetPtr(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API Jolt_JPH_Array_JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_OffsetMutablePtr(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *ptr, ptrdiff_t i);

/// The number of elements.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API size_t Jolt_JPH_Array_JPH_CharacterVirtual_Contact_size(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this);

/// Returns true if the size is zero.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool Jolt_JPH_Array_JPH_CharacterVirtual_Contact_empty(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this);

/// Resizes the container. The new elements if any are zeroed.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_resize(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, size_t new_size);

/// Resizes the container. The new elements if any are set to the specified value.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_resize_with_default_value(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, size_t new_size, const JPH_CharacterVirtual_Contact *value);

/// Removes all elements from the container.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_clear(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this);

/// The memory capacity, measued in the number of elements.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API size_t Jolt_JPH_Array_JPH_CharacterVirtual_Contact_capacity(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this);

/// Reserves memory for a certain number of elements. Never shrinks the memory.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_reserve(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, size_t new_capacity);

/// Shrinks the capacity to match the size.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_shrink_to_fit(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this);

/// The element at a specific index, read-only.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_at(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, size_t i);

/// The element at a specific index, mutable.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_at_mut(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, size_t i);

/// The first element or null if empty, read-only.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_front(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this);

/// The first element or null if empty, mutable.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_front_mut(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this);

/// The last element or null if empty, read-only.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_back(const Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this);

/// The last element or null if empty, mutable.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_CharacterVirtual_Contact *Jolt_JPH_Array_JPH_CharacterVirtual_Contact_back_mut(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this);

/// Inserts a new element at the end.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `new_elem` can not be null. It is a single object.
/// The reference to the parameter `new_elem` might be preserved in this object.
JOLT_API void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_push_back(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, const JPH_CharacterVirtual_Contact *new_elem);

/// Removes one element from the end.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_pop_back(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this);

/// Inserts a new element right before the specified position.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `new_elem` can not be null. It is a single object.
/// The reference to the parameter `new_elem` might be preserved in this object.
JOLT_API void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_insert(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, size_t position, const JPH_CharacterVirtual_Contact *new_elem);

/// Erases the element at the specified position.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void Jolt_JPH_Array_JPH_CharacterVirtual_Contact_erase(Jolt_JPH_Array_JPH_CharacterVirtual_Contact *_this, size_t position);

#ifdef __cplusplus
} // extern "C"
#endif
