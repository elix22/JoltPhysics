// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>
#include <jolt/Jolt/Physics/Body/BodyID.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_PhysicsMaterial JPH_PhysicsMaterial; // Defined in `#include <jolt/Jolt/Physics/Collision/PhysicsMaterial.h>`.
typedef struct JPH_PhysicsSystem JPH_PhysicsSystem; // Defined in `#include <jolt/Jolt/Physics/PhysicsSystem.h>`.
typedef struct JPH_RefTarget_JPH_CharacterBase JPH_RefTarget_JPH_CharacterBase; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_CharacterBaseSettings JPH_RefTarget_JPH_CharacterBaseSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Base class for configuration of a character
/// Generated from class `JPH::CharacterBaseSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::RefTarget<JPH::CharacterBaseSettings>`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::CharacterVirtualSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CharacterBaseSettings JPH_CharacterBaseSettings;

typedef enum JPH_CharacterBase_EGroundState
{
    ///< Character is on the ground and can move freely.
    JPH_CharacterBase_EGroundState_OnGround = 0,
    ///< Character is on a slope that is too steep and can't climb up any further. The caller should start applying downward velocity if sliding from the slope is desired.
    JPH_CharacterBase_EGroundState_OnSteepGround = 1,
    ///< Character is touching an object, but is not supported by it and should fall. The GetGroundXXX functions will return information about the touched object.
    JPH_CharacterBase_EGroundState_NotSupported = 2,
    ///< Character is in the air and is not touching anything.
    JPH_CharacterBase_EGroundState_InAir = 3,
} JPH_CharacterBase_EGroundState;

/// Base class for character class
/// Generated from class `JPH::CharacterBase`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::RefTarget<JPH::CharacterBase>`
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::CharacterVirtual`
typedef struct JPH_CharacterBase JPH_CharacterBase;

/// Vector indicating the up direction of the character
/// Returns a pointer to a member variable of class `JPH::CharacterBaseSettings` named `mUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CharacterBaseSettings_Get_mUp(const JPH_CharacterBaseSettings *_this);

/// Vector indicating the up direction of the character
/// Returns a mutable pointer to a member variable of class `JPH::CharacterBaseSettings` named `mUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CharacterBaseSettings_GetMutable_mUp(JPH_CharacterBaseSettings *_this);

/// Maximum angle of slope that character can still walk on (radians).
/// Returns a pointer to a member variable of class `JPH::CharacterBaseSettings` named `mMaxSlopeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterBaseSettings_Get_mMaxSlopeAngle(const JPH_CharacterBaseSettings *_this);

/// Maximum angle of slope that character can still walk on (radians).
/// Modifies a member variable of class `JPH::CharacterBaseSettings` named `mMaxSlopeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxSlopeAngle`.
JOLT_API void JPH_CharacterBaseSettings_Set_mMaxSlopeAngle(JPH_CharacterBaseSettings *_this, float value);

/// Maximum angle of slope that character can still walk on (radians).
/// Returns a mutable pointer to a member variable of class `JPH::CharacterBaseSettings` named `mMaxSlopeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterBaseSettings_GetMutable_mMaxSlopeAngle(JPH_CharacterBaseSettings *_this);

/// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Returns a pointer to a member variable of class `JPH::CharacterBaseSettings` named `mEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_CharacterBaseSettings_Get_mEnhancedInternalEdgeRemoval(const JPH_CharacterBaseSettings *_this);

/// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Modifies a member variable of class `JPH::CharacterBaseSettings` named `mEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnhancedInternalEdgeRemoval`.
JOLT_API void JPH_CharacterBaseSettings_Set_mEnhancedInternalEdgeRemoval(JPH_CharacterBaseSettings *_this, bool value);

/// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterBaseSettings` named `mEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_CharacterBaseSettings_GetMutable_mEnhancedInternalEdgeRemoval(JPH_CharacterBaseSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterBaseSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CharacterBaseSettings_DestroyArray()`.
/// Use `JPH_CharacterBaseSettings_OffsetMutablePtr()` and `JPH_CharacterBaseSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_OffsetPtr(const JPH_CharacterBaseSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_OffsetMutablePtr(JPH_CharacterBaseSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::CharacterBaseSettings` to its base class `JPH::RefTarget<JPH::CharacterBaseSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(const JPH_CharacterBaseSettings *object);

/// Upcasts an instance of `JPH::CharacterBaseSettings` to its base class `JPH::RefTarget<JPH::CharacterBaseSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_MutableUpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(JPH_CharacterBaseSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::CharacterBaseSettings>` to a derived class `JPH::CharacterBaseSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(const JPH_RefTarget_JPH_CharacterBaseSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::CharacterBaseSettings>` to a derived class `JPH::CharacterBaseSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(JPH_RefTarget_JPH_CharacterBaseSettings *object);

/// Generated from constructor `JPH::CharacterBaseSettings::CharacterBaseSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterBaseSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CharacterBaseSettings *_other);

/// Destroys a heap-allocated instance of `JPH_CharacterBaseSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterBaseSettings_Destroy(const JPH_CharacterBaseSettings *_this);

/// Destroys a heap-allocated array of `JPH_CharacterBaseSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterBaseSettings_DestroyArray(const JPH_CharacterBaseSettings *_this);

/// Generated from method `JPH::CharacterBaseSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_AssignFromAnother(JPH_CharacterBaseSettings *_this, Jolt_PassBy _other_pass_by, JPH_CharacterBaseSettings *_other);

/// Generated from method `JPH::CharacterBaseSettings::operator new`.
JOLT_API void *Jolt_new_JPH_CharacterBaseSettings_size_t(size_t inCount);

/// Generated from method `JPH::CharacterBaseSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterBaseSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::CharacterBaseSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterBaseSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CharacterBaseSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CharacterBaseSettings_size_t(size_t inCount);

/// Generated from method `JPH::CharacterBaseSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::CharacterBaseSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CharacterBaseSettings::operator new`.
JOLT_API void *Jolt_new_JPH_CharacterBaseSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CharacterBaseSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterBaseSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CharacterBaseSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CharacterBaseSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CharacterBaseSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::CharacterBaseSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterBaseSettings_SetEmbedded(const JPH_CharacterBaseSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::CharacterBaseSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CharacterBaseSettings_GetRefCount(const JPH_CharacterBaseSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::CharacterBaseSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterBaseSettings_AddRef(const JPH_CharacterBaseSettings *_this);

/// Generated from method `JPH::CharacterBaseSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterBaseSettings_Release(const JPH_CharacterBaseSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::CharacterBaseSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_CharacterBaseSettings_sInternalGetRefCountOffset(void);

/// Constructor
/// Generated from constructor `JPH::CharacterBase::CharacterBase`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterBase_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterBase *JPH_CharacterBase_Construct(const JPH_CharacterBaseSettings *inSettings, JPH_PhysicsSystem *inSystem);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CharacterBase *JPH_CharacterBase_OffsetPtr(const JPH_CharacterBase *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CharacterBase *JPH_CharacterBase_OffsetMutablePtr(JPH_CharacterBase *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::CharacterBase` to its base class `JPH::RefTarget<JPH::CharacterBase>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_CharacterBase *JPH_CharacterBase_UpcastTo_JPH_RefTarget_JPH_CharacterBase(const JPH_CharacterBase *object);

/// Upcasts an instance of `JPH::CharacterBase` to its base class `JPH::RefTarget<JPH::CharacterBase>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_CharacterBase *JPH_CharacterBase_MutableUpcastTo_JPH_RefTarget_JPH_CharacterBase(JPH_CharacterBase *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::CharacterBase>` to a derived class `JPH::CharacterBase`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterBase *JPH_CharacterBase_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(const JPH_RefTarget_JPH_CharacterBase *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::CharacterBase>` to a derived class `JPH::CharacterBase`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterBase *JPH_CharacterBase_MutableStaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(JPH_RefTarget_JPH_CharacterBase *object);

/// Upcasts an instance of `JPH::CharacterBase` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_CharacterBase_UpcastTo_JPH_NonCopyable(const JPH_CharacterBase *object);

/// Upcasts an instance of `JPH::CharacterBase` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_CharacterBase_MutableUpcastTo_JPH_NonCopyable(JPH_CharacterBase *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::CharacterBase`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterBase *JPH_CharacterBase_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::CharacterBase`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterBase *JPH_CharacterBase_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Destroys a heap-allocated instance of `JPH_CharacterBase`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterBase_Destroy(const JPH_CharacterBase *_this);

/// Destroys a heap-allocated array of `JPH_CharacterBase`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterBase_DestroyArray(const JPH_CharacterBase *_this);

/// Generated from method `JPH::CharacterBase::operator new`.
JOLT_API void *Jolt_new_JPH_CharacterBase_size_t(size_t inCount);

/// Generated from method `JPH::CharacterBase::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterBase_void_ptr(void *inPointer);

/// Generated from method `JPH::CharacterBase::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterBase_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CharacterBase::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CharacterBase_size_t(size_t inCount);

/// Generated from method `JPH::CharacterBase::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterBase_void_ptr(void *inPointer);

/// Generated from method `JPH::CharacterBase::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterBase_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CharacterBase::operator new`.
JOLT_API void *Jolt_new_JPH_CharacterBase_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CharacterBase::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterBase_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CharacterBase::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CharacterBase_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CharacterBase::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterBase_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Set the maximum angle of slope that character can still walk on (radians)
/// Generated from method `JPH::CharacterBase::SetMaxSlopeAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterBase_SetMaxSlopeAngle(JPH_CharacterBase *_this, float inMaxSlopeAngle);

/// Generated from method `JPH::CharacterBase::GetCosMaxSlopeAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_CharacterBase_GetCosMaxSlopeAngle(const JPH_CharacterBase *_this);

/// Set the up vector for the character
/// Generated from method `JPH::CharacterBase::SetUp`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inUp` can not be null. It is a single object.
JOLT_API void JPH_CharacterBase_SetUp(JPH_CharacterBase *_this, const JPH_Vec3 *inUp);

/// Generated from method `JPH::CharacterBase::GetUp`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_CharacterBase_GetUp(const JPH_CharacterBase *_this);

/// Check if the normal of the ground surface is too steep to walk on
/// Generated from method `JPH::CharacterBase::IsSlopeTooSteep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inNormal` can not be null. It is a single object.
JOLT_API bool JPH_CharacterBase_IsSlopeTooSteep(const JPH_CharacterBase *_this, const JPH_Vec3 *inNormal);

/// Get the current shape that the character is using.
/// Generated from method `JPH::CharacterBase::GetShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_CharacterBase_GetShape(const JPH_CharacterBase *_this);

/// Debug function to convert enum values to string
/// Generated from method `JPH::CharacterBase::sToString`.
JOLT_API const char *JPH_CharacterBase_sToString(JPH_CharacterBase_EGroundState inState);

/// Current ground state
/// Generated from method `JPH::CharacterBase::GetGroundState`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_CharacterBase_EGroundState JPH_CharacterBase_GetGroundState(const JPH_CharacterBase *_this);

/// Returns true if the player is supported by normal or steep ground
/// Generated from method `JPH::CharacterBase::IsSupported`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_CharacterBase_IsSupported(const JPH_CharacterBase *_this);

/// Get the contact point with the ground
/// Generated from method `JPH::CharacterBase::GetGroundPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_CharacterBase_GetGroundPosition(const JPH_CharacterBase *_this);

/// Get the contact normal with the ground
/// Generated from method `JPH::CharacterBase::GetGroundNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_CharacterBase_GetGroundNormal(const JPH_CharacterBase *_this);

/// Velocity in world space of ground
/// Generated from method `JPH::CharacterBase::GetGroundVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_CharacterBase_GetGroundVelocity(const JPH_CharacterBase *_this);

/// Material that the character is standing on
/// Generated from method `JPH::CharacterBase::GetGroundMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_CharacterBase_GetGroundMaterial(const JPH_CharacterBase *_this);

/// BodyID of the object the character is standing on. Note may have been removed!
/// Generated from method `JPH::CharacterBase::GetGroundBodyID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_BodyID JPH_CharacterBase_GetGroundBodyID(const JPH_CharacterBase *_this);

/// Sub part of the body that we're standing on.
/// Generated from method `JPH::CharacterBase::GetGroundSubShapeID`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SubShapeID_Destroy()` to free it when you're done using it.
JOLT_API JPH_SubShapeID *JPH_CharacterBase_GetGroundSubShapeID(const JPH_CharacterBase *_this);

/// User data value of the body that we're standing on
/// Generated from method `JPH::CharacterBase::GetGroundUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_CharacterBase_GetGroundUserData(const JPH_CharacterBase *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::CharacterBase::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterBase_SetEmbedded(const JPH_CharacterBase *_this);

/// Get current refcount of this object
/// Generated from method `JPH::CharacterBase::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CharacterBase_GetRefCount(const JPH_CharacterBase *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::CharacterBase::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterBase_AddRef(const JPH_CharacterBase *_this);

/// Generated from method `JPH::CharacterBase::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterBase_Release(const JPH_CharacterBase *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::CharacterBase::sInternalGetRefCountOffset`.
JOLT_API int JPH_CharacterBase_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
