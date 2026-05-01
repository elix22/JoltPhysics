// machine generated, do not edit
#pragma once

#include <exports.h>
#include <jolt/Jolt/Physics/Collision/BackFaceMode.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Structure that holds a single ray cast
/// Generated from class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::RayCast`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast;

/// Structure that holds a single ray cast
/// Generated from class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::RRayCast`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast;

/// Generated from class `JPH::RayCast`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RayCast JPH_RayCast;

/// Generated from class `JPH::RRayCast`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RRayCast JPH_RRayCast;

/// Settings to be passed with a ray cast
/// Generated from class `JPH::RayCastSettings`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RayCastSettings JPH_RayCastSettings;

///< Origin of the ray
/// Returns a pointer to a member variable of class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>` named `mOrigin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Get_mOrigin(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this);

///< Origin of the ray
/// Returns a mutable pointer to a member variable of class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>` named `mOrigin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetMutable_mOrigin(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this);

///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
/// Returns a pointer to a member variable of class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>` named `mDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Get_mDirection(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this);

///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
/// Returns a mutable pointer to a member variable of class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>` named `mDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetMutable_mDirection(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_DestroyArray()`.
/// Use `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_OffsetMutablePtr()` and `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_OffsetPtr()` to access the array elements.
JOLT_API JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_OffsetPtr(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_OffsetMutablePtr(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::RayCastT`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_ConstructFromAnother(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_other);

/// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::RayCastT`.
/// Parameter `inOrigin` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Construct(const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection);

/// Destroys a heap-allocated instance of `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast`. Does nothing if the pointer is null.
JOLT_API void JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Destroy(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this);

/// Destroys a heap-allocated array of `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast`. Does nothing if the pointer is null.
JOLT_API void JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_DestroyArray(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_AssignFromAnother(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this, const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_other);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator new`.
JOLT_API void *Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t(size_t inCount);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete`.
JOLT_API void Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr(void *inPointer);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete`.
JOLT_API void Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t(size_t inCount);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr(void *inPointer);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator new`.
JOLT_API void *Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete`.
JOLT_API void Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Transform this ray using inTransform
/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::Transformed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTransform` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Transformed(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this, const JPH_Mat44 *inTransform);

/// Translate ray using inTranslation
/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::Translated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Translated(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this, const JPH_Vec3 *inTranslation);

/// Get point with fraction inFraction on ray (0 = start of ray, 1 = end of ray)
/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::GetPointOnRay`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetPointOnRay(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this, float inFraction);

///< Origin of the ray
/// Returns a pointer to a member variable of class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>` named `mOrigin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Get_mOrigin(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this);

///< Origin of the ray
/// Returns a mutable pointer to a member variable of class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>` named `mOrigin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetMutable_mOrigin(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this);

///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
/// Returns a pointer to a member variable of class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>` named `mDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Get_mDirection(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this);

///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
/// Returns a mutable pointer to a member variable of class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>` named `mDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetMutable_mDirection(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_DestroyArray()`.
/// Use `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_OffsetMutablePtr()` and `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_OffsetPtr()` to access the array elements.
JOLT_API JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_OffsetPtr(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_OffsetMutablePtr(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::RayCastT`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_ConstructFromAnother(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_other);

/// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::RayCastT`.
/// Parameter `inOrigin` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Construct(const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection);

/// Destroys a heap-allocated instance of `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast`. Does nothing if the pointer is null.
JOLT_API void JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Destroy(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this);

/// Destroys a heap-allocated array of `JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast`. Does nothing if the pointer is null.
JOLT_API void JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_DestroyArray(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_AssignFromAnother(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this, const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_other);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator new`.
JOLT_API void *Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t(size_t inCount);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete`.
JOLT_API void Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr(void *inPointer);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete`.
JOLT_API void Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t(size_t inCount);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr(void *inPointer);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator new`.
JOLT_API void *Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete`.
JOLT_API void Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Transform this ray using inTransform
/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::Transformed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTransform` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RRayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Transformed(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this, const JPH_Mat44 *inTransform);

/// Translate ray using inTranslation
/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::Translated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RRayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Translated(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this, const JPH_Vec3 *inTranslation);

/// Get point with fraction inFraction on ray (0 = start of ray, 1 = end of ray)
/// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::GetPointOnRay`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetPointOnRay(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this, float inFraction);

///< Origin of the ray
/// Returns a pointer to a member variable of class `JPH::RayCast` named `mOrigin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RayCast_Get_mOrigin(const JPH_RayCast *_this);

///< Origin of the ray
/// Returns a mutable pointer to a member variable of class `JPH::RayCast` named `mOrigin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_RayCast_GetMutable_mOrigin(JPH_RayCast *_this);

///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
/// Returns a pointer to a member variable of class `JPH::RayCast` named `mDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RayCast_Get_mDirection(const JPH_RayCast *_this);

///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
/// Returns a mutable pointer to a member variable of class `JPH::RayCast` named `mDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_RayCast_GetMutable_mDirection(JPH_RayCast *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCast *JPH_RayCast_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RayCast_DestroyArray()`.
/// Use `JPH_RayCast_OffsetMutablePtr()` and `JPH_RayCast_OffsetPtr()` to access the array elements.
JOLT_API JPH_RayCast *JPH_RayCast_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RayCast *JPH_RayCast_OffsetPtr(const JPH_RayCast *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RayCast *JPH_RayCast_OffsetMutablePtr(JPH_RayCast *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::RayCast` to its base class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(const JPH_RayCast *object);

/// Upcasts an instance of `JPH::RayCast` to its base class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCast_MutableUpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(JPH_RayCast *object);

/// Downcasts an instance of `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>` to a derived class `JPH::RayCast`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RayCast *JPH_RayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *object);

/// Downcasts an instance of `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>` to a derived class `JPH::RayCast`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RayCast *JPH_RayCast_MutableStaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *object);

/// Generated from constructor `JPH::RayCast::RayCast`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCast *JPH_RayCast_ConstructFromAnother(const JPH_RayCast *_other);

/// Generated from constructor `JPH::RayCast::RayCast`.
/// Parameter `inOrigin` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCast *JPH_RayCast_Construct(const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection);

/// Destroys a heap-allocated instance of `JPH_RayCast`. Does nothing if the pointer is null.
JOLT_API void JPH_RayCast_Destroy(const JPH_RayCast *_this);

/// Destroys a heap-allocated array of `JPH_RayCast`. Does nothing if the pointer is null.
JOLT_API void JPH_RayCast_DestroyArray(const JPH_RayCast *_this);

/// Generated from method `JPH::RayCast::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RayCast *JPH_RayCast_AssignFromAnother(JPH_RayCast *_this, const JPH_RayCast *_other);

/// Transform this ray using inTransform
/// Generated from method `JPH::RayCast::Transformed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTransform` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCast *JPH_RayCast_Transformed(const JPH_RayCast *_this, const JPH_Mat44 *inTransform);

/// Translate ray using inTranslation
/// Generated from method `JPH::RayCast::Translated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCast *JPH_RayCast_Translated(const JPH_RayCast *_this, const JPH_Vec3 *inTranslation);

/// Get point with fraction inFraction on ray (0 = start of ray, 1 = end of ray)
/// Generated from method `JPH::RayCast::GetPointOnRay`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_RayCast_GetPointOnRay(const JPH_RayCast *_this, float inFraction);

///< Origin of the ray
/// Returns a pointer to a member variable of class `JPH::RRayCast` named `mOrigin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RRayCast_Get_mOrigin(const JPH_RRayCast *_this);

///< Origin of the ray
/// Returns a mutable pointer to a member variable of class `JPH::RRayCast` named `mOrigin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_RRayCast_GetMutable_mOrigin(JPH_RRayCast *_this);

///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
/// Returns a pointer to a member variable of class `JPH::RRayCast` named `mDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_RRayCast_Get_mDirection(const JPH_RRayCast *_this);

///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
/// Returns a mutable pointer to a member variable of class `JPH::RRayCast` named `mDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_RRayCast_GetMutable_mDirection(JPH_RRayCast *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RRayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RRayCast *JPH_RRayCast_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RRayCast_DestroyArray()`.
/// Use `JPH_RRayCast_OffsetMutablePtr()` and `JPH_RRayCast_OffsetPtr()` to access the array elements.
JOLT_API JPH_RRayCast *JPH_RRayCast_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RRayCast *JPH_RRayCast_OffsetPtr(const JPH_RRayCast *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RRayCast *JPH_RRayCast_OffsetMutablePtr(JPH_RRayCast *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::RRayCast` to its base class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RRayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(const JPH_RRayCast *object);

/// Upcasts an instance of `JPH::RRayCast` to its base class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RRayCast_MutableUpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(JPH_RRayCast *object);

/// Downcasts an instance of `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>` to a derived class `JPH::RRayCast`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RRayCast *JPH_RRayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *object);

/// Downcasts an instance of `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>` to a derived class `JPH::RRayCast`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RRayCast *JPH_RRayCast_MutableStaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *object);

/// Generated from constructor `JPH::RRayCast::RRayCast`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RRayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RRayCast *JPH_RRayCast_ConstructFromAnother(const JPH_RRayCast *_other);

/// Generated from constructor `JPH::RRayCast::RRayCast`.
/// Parameter `inOrigin` can not be null. It is a single object.
/// Parameter `inDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RRayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RRayCast *JPH_RRayCast_Construct_2(const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection);

/// Convert from RayCast, converts single to double precision
/// Generated from constructor `JPH::RRayCast::RRayCast`.
/// Parameter `inRay` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RRayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RRayCast *JPH_RRayCast_Construct_1(const JPH_RayCast *inRay);

/// Destroys a heap-allocated instance of `JPH_RRayCast`. Does nothing if the pointer is null.
JOLT_API void JPH_RRayCast_Destroy(const JPH_RRayCast *_this);

/// Destroys a heap-allocated array of `JPH_RRayCast`. Does nothing if the pointer is null.
JOLT_API void JPH_RRayCast_DestroyArray(const JPH_RRayCast *_this);

/// Convert to RayCast, which implies casting from double precision to single precision
/// Generated from conversion operator `JPH::RRayCast::operator JPH::RayCast`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCast *JPH_RRayCast_ConvertTo_JPH_RayCast(const JPH_RRayCast *_this);

/// Generated from method `JPH::RRayCast::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RRayCast *JPH_RRayCast_AssignFromAnother(JPH_RRayCast *_this, const JPH_RRayCast *_other);

/// Transform this ray using inTransform
/// Generated from method `JPH::RRayCast::Transformed`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTransform` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RRayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RRayCast *JPH_RRayCast_Transformed(const JPH_RRayCast *_this, const JPH_Mat44 *inTransform);

/// Translate ray using inTranslation
/// Generated from method `JPH::RRayCast::Translated`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTranslation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RRayCast_Destroy()` to free it when you're done using it.
JOLT_API JPH_RRayCast *JPH_RRayCast_Translated(const JPH_RRayCast *_this, const JPH_Vec3 *inTranslation);

/// Get point with fraction inFraction on ray (0 = start of ray, 1 = end of ray)
/// Generated from method `JPH::RRayCast::GetPointOnRay`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_RRayCast_GetPointOnRay(const JPH_RRayCast *_this, float inFraction);

/// How backfacing triangles should be treated (should we report back facing hits for triangle based shapes, e.g. MeshShape/HeightFieldShape?)
/// Returns a pointer to a member variable of class `JPH::RayCastSettings` named `mBackFaceModeTriangles`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_EBackFaceMode *JPH_RayCastSettings_Get_mBackFaceModeTriangles(const JPH_RayCastSettings *_this);

/// How backfacing triangles should be treated (should we report back facing hits for triangle based shapes, e.g. MeshShape/HeightFieldShape?)
/// Modifies a member variable of class `JPH::RayCastSettings` named `mBackFaceModeTriangles`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBackFaceModeTriangles`.
/// When this function is called, this object will drop object references it held previously in `mBackFaceModeTriangles`.
JOLT_API void JPH_RayCastSettings_Set_mBackFaceModeTriangles(JPH_RayCastSettings *_this, JPH_EBackFaceMode value);

/// How backfacing triangles should be treated (should we report back facing hits for triangle based shapes, e.g. MeshShape/HeightFieldShape?)
/// Returns a mutable pointer to a member variable of class `JPH::RayCastSettings` named `mBackFaceModeTriangles`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_EBackFaceMode *JPH_RayCastSettings_GetMutable_mBackFaceModeTriangles(JPH_RayCastSettings *_this);

/// How backfacing convex objects should be treated (should we report back facing hits for convex shapes?)
/// Returns a pointer to a member variable of class `JPH::RayCastSettings` named `mBackFaceModeConvex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_EBackFaceMode *JPH_RayCastSettings_Get_mBackFaceModeConvex(const JPH_RayCastSettings *_this);

/// How backfacing convex objects should be treated (should we report back facing hits for convex shapes?)
/// Modifies a member variable of class `JPH::RayCastSettings` named `mBackFaceModeConvex`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBackFaceModeConvex`.
/// When this function is called, this object will drop object references it held previously in `mBackFaceModeConvex`.
JOLT_API void JPH_RayCastSettings_Set_mBackFaceModeConvex(JPH_RayCastSettings *_this, JPH_EBackFaceMode value);

/// How backfacing convex objects should be treated (should we report back facing hits for convex shapes?)
/// Returns a mutable pointer to a member variable of class `JPH::RayCastSettings` named `mBackFaceModeConvex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_EBackFaceMode *JPH_RayCastSettings_GetMutable_mBackFaceModeConvex(JPH_RayCastSettings *_this);

/// If convex shapes should be treated as solid. When true, a ray starting inside a convex shape will generate a hit at fraction 0.
/// Returns a pointer to a member variable of class `JPH::RayCastSettings` named `mTreatConvexAsSolid`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_RayCastSettings_Get_mTreatConvexAsSolid(const JPH_RayCastSettings *_this);

/// If convex shapes should be treated as solid. When true, a ray starting inside a convex shape will generate a hit at fraction 0.
/// Modifies a member variable of class `JPH::RayCastSettings` named `mTreatConvexAsSolid`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mTreatConvexAsSolid`.
JOLT_API void JPH_RayCastSettings_Set_mTreatConvexAsSolid(JPH_RayCastSettings *_this, bool value);

/// If convex shapes should be treated as solid. When true, a ray starting inside a convex shape will generate a hit at fraction 0.
/// Returns a mutable pointer to a member variable of class `JPH::RayCastSettings` named `mTreatConvexAsSolid`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_RayCastSettings_GetMutable_mTreatConvexAsSolid(JPH_RayCastSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCastSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCastSettings *JPH_RayCastSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RayCastSettings_DestroyArray()`.
/// Use `JPH_RayCastSettings_OffsetMutablePtr()` and `JPH_RayCastSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_RayCastSettings *JPH_RayCastSettings_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::RayCastSettings` elementwise.
/// The reference to the parameter `mBackFaceModeTriangles` might be preserved in the constructed object.
/// The reference to the parameter `mBackFaceModeConvex` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCastSettings_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RayCastSettings *JPH_RayCastSettings_ConstructFrom(JPH_EBackFaceMode mBackFaceModeTriangles, JPH_EBackFaceMode mBackFaceModeConvex, bool mTreatConvexAsSolid);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RayCastSettings *JPH_RayCastSettings_OffsetPtr(const JPH_RayCastSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RayCastSettings *JPH_RayCastSettings_OffsetMutablePtr(JPH_RayCastSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RayCastSettings::RayCastSettings`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RayCastSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RayCastSettings *JPH_RayCastSettings_ConstructFromAnother(const JPH_RayCastSettings *_other);

/// Destroys a heap-allocated instance of `JPH_RayCastSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RayCastSettings_Destroy(const JPH_RayCastSettings *_this);

/// Destroys a heap-allocated array of `JPH_RayCastSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RayCastSettings_DestroyArray(const JPH_RayCastSettings *_this);

/// Generated from method `JPH::RayCastSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RayCastSettings *JPH_RayCastSettings_AssignFromAnother(JPH_RayCastSettings *_this, const JPH_RayCastSettings *_other);

/// Generated from method `JPH::RayCastSettings::operator new`.
JOLT_API void *Jolt_new_JPH_RayCastSettings_size_t(size_t inCount);

/// Generated from method `JPH::RayCastSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_RayCastSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::RayCastSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_RayCastSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RayCastSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RayCastSettings_size_t(size_t inCount);

/// Generated from method `JPH::RayCastSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RayCastSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::RayCastSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RayCastSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::RayCastSettings::operator new`.
JOLT_API void *Jolt_new_JPH_RayCastSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RayCastSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_RayCastSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::RayCastSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_RayCastSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::RayCastSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_RayCastSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Set the backfacing mode for all shapes
/// Generated from method `JPH::RayCastSettings::SetBackFaceMode`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RayCastSettings_SetBackFaceMode(JPH_RayCastSettings *_this, JPH_EBackFaceMode inMode);

#ifdef __cplusplus
} // extern "C"
#endif
