// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Minimal helpers for Jolt global lifecycle.
/// These are the only hand-implemented methods; their C/C# bindings are machine-generated.
/// Generated from class `JoltHelpers`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltHelpers JoltHelpers;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltHelpers_Destroy()` to free it when you're done using it.
JOLT_API JoltHelpers *JoltHelpers_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltHelpers_DestroyArray()`.
/// Use `JoltHelpers_OffsetMutablePtr()` and `JoltHelpers_OffsetPtr()` to access the array elements.
JOLT_API JoltHelpers *JoltHelpers_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltHelpers *JoltHelpers_OffsetPtr(const JoltHelpers *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltHelpers *JoltHelpers_OffsetMutablePtr(JoltHelpers *ptr, ptrdiff_t i);

/// Generated from constructor `JoltHelpers::JoltHelpers`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltHelpers_Destroy()` to free it when you're done using it.
JOLT_API JoltHelpers *JoltHelpers_ConstructFromAnother(const JoltHelpers *_other);

/// Destroys a heap-allocated instance of `JoltHelpers`. Does nothing if the pointer is null.
JOLT_API void JoltHelpers_Destroy(const JoltHelpers *_this);

/// Destroys a heap-allocated array of `JoltHelpers`. Does nothing if the pointer is null.
JOLT_API void JoltHelpers_DestroyArray(const JoltHelpers *_this);

/// Generated from method `JoltHelpers::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltHelpers *JoltHelpers_AssignFromAnother(JoltHelpers *_this, const JoltHelpers *_other);

/// Initialize Jolt: set Trace, RegisterDefaultAllocator, create Factory, RegisterTypes.
/// Generated from method `JoltHelpers::Init`.
JOLT_API void JoltHelpers_Init(void);

/// Generated from method `JoltHelpers::Shutdown`.
JOLT_API void JoltHelpers_Shutdown(void);

#ifdef __cplusplus
} // extern "C"
#endif
