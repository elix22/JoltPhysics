// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>
#include <jolt/Jolt/Physics/Body/BodyID.h>
#include <jolt/Jolt/Physics/Character/CharacterBase.h>
#include <jolt/Jolt/Physics/EActivation.h>

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_CharacterBase JPH_CharacterBase; // Defined in `#include <jolt/Jolt/Physics/Character/CharacterBase.h>`.
typedef struct JPH_CharacterBaseSettings JPH_CharacterBaseSettings; // Defined in `#include <jolt/Jolt/Physics/Character/CharacterBase.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_PhysicsMaterial JPH_PhysicsMaterial; // Defined in `#include <jolt/Jolt/Physics/Collision/PhysicsMaterial.h>`.
typedef struct JPH_PhysicsSystem JPH_PhysicsSystem; // Defined in `#include <jolt/Jolt/Physics/PhysicsSystem.h>`.
typedef struct JPH_Plane JPH_Plane; // Defined in `#include <jolt/Jolt/Geometry/Plane.h>`.
typedef struct JPH_Quat JPH_Quat; // Defined in `#include <jolt/Jolt/Math/Quat.h>`.
typedef struct JPH_RefTarget_JPH_CharacterBase JPH_RefTarget_JPH_CharacterBase; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_RefTarget_JPH_CharacterBaseSettings JPH_RefTarget_JPH_CharacterBaseSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_Shape JPH_Shape; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/Shape.h>`.
typedef struct JPH_SubShapeID JPH_SubShapeID; // Defined in `#include <jolt/Jolt/Physics/Collision/Shape/SubShapeID.h>`.
typedef struct JPH_TransformedShape JPH_TransformedShape; // Defined in `#include <jolt/Jolt/Physics/Collision/TransformedShape.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Contains the configuration of a character
/// Generated from class `JPH::CharacterSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::CharacterBaseSettings`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::CharacterBaseSettings>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_CharacterSettings JPH_CharacterSettings;

/// Runtime character object.
/// This object usually represents the player or a humanoid AI. It uses a single rigid body,
/// usually with a capsule shape to simulate movement and collision for the character.
/// The character is a keyframed object, the application controls it by setting the velocity.
/// Generated from class `JPH::Character`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::CharacterBase`
///   Indirect: (non-virtual)
///     `JPH::RefTarget<JPH::CharacterBase>`
///     `JPH::NonCopyable`
typedef struct JPH_Character JPH_Character;

/// Layer that this character will be added to
/// Returns a pointer to a member variable of class `JPH::CharacterSettings` named `mLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned short *JPH_CharacterSettings_Get_mLayer(const JPH_CharacterSettings *_this);

/// Layer that this character will be added to
/// Modifies a member variable of class `JPH::CharacterSettings` named `mLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mLayer`.
/// When this function is called, this object will drop object references it held previously in `mLayer`.
JOLT_API void JPH_CharacterSettings_Set_mLayer(JPH_CharacterSettings *_this, unsigned short value);

/// Layer that this character will be added to
/// Returns a mutable pointer to a member variable of class `JPH::CharacterSettings` named `mLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned short *JPH_CharacterSettings_GetMutable_mLayer(JPH_CharacterSettings *_this);

/// Mass of the character
/// Returns a pointer to a member variable of class `JPH::CharacterSettings` named `mMass`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterSettings_Get_mMass(const JPH_CharacterSettings *_this);

/// Mass of the character
/// Modifies a member variable of class `JPH::CharacterSettings` named `mMass`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMass`.
JOLT_API void JPH_CharacterSettings_Set_mMass(JPH_CharacterSettings *_this, float value);

/// Mass of the character
/// Returns a mutable pointer to a member variable of class `JPH::CharacterSettings` named `mMass`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterSettings_GetMutable_mMass(JPH_CharacterSettings *_this);

/// Friction for the character
/// Returns a pointer to a member variable of class `JPH::CharacterSettings` named `mFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterSettings_Get_mFriction(const JPH_CharacterSettings *_this);

/// Friction for the character
/// Modifies a member variable of class `JPH::CharacterSettings` named `mFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mFriction`.
JOLT_API void JPH_CharacterSettings_Set_mFriction(JPH_CharacterSettings *_this, float value);

/// Friction for the character
/// Returns a mutable pointer to a member variable of class `JPH::CharacterSettings` named `mFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterSettings_GetMutable_mFriction(JPH_CharacterSettings *_this);

/// Value to multiply gravity with for this character
/// Returns a pointer to a member variable of class `JPH::CharacterSettings` named `mGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterSettings_Get_mGravityFactor(const JPH_CharacterSettings *_this);

/// Value to multiply gravity with for this character
/// Modifies a member variable of class `JPH::CharacterSettings` named `mGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mGravityFactor`.
JOLT_API void JPH_CharacterSettings_Set_mGravityFactor(JPH_CharacterSettings *_this, float value);

/// Value to multiply gravity with for this character
/// Returns a mutable pointer to a member variable of class `JPH::CharacterSettings` named `mGravityFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterSettings_GetMutable_mGravityFactor(JPH_CharacterSettings *_this);

/// Vector indicating the up direction of the character
/// Returns a pointer to a member variable of class `JPH::CharacterSettings` named `mUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Vec3 *JPH_CharacterSettings_Get_mUp(const JPH_CharacterSettings *_this);

/// Vector indicating the up direction of the character
/// Returns a mutable pointer to a member variable of class `JPH::CharacterSettings` named `mUp`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Vec3 *JPH_CharacterSettings_GetMutable_mUp(JPH_CharacterSettings *_this);

/// Plane, defined in local space relative to the character. Every contact behind this plane can support the
/// character, every contact in front of this plane is treated as only colliding with the player.
/// Default: Accept any contact.
/// Returns a pointer to a member variable of class `JPH::CharacterSettings` named `mSupportingVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Plane *JPH_CharacterSettings_Get_mSupportingVolume(const JPH_CharacterSettings *_this);

/// Plane, defined in local space relative to the character. Every contact behind this plane can support the
/// character, every contact in front of this plane is treated as only colliding with the player.
/// Default: Accept any contact.
/// Modifies a member variable of class `JPH::CharacterSettings` named `mSupportingVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mSupportingVolume`.
/// When this function is called, this object will drop object references it held previously in `mSupportingVolume`.
JOLT_API void JPH_CharacterSettings_Set_mSupportingVolume(JPH_CharacterSettings *_this, const JPH_Plane *value);

/// Plane, defined in local space relative to the character. Every contact behind this plane can support the
/// character, every contact in front of this plane is treated as only colliding with the player.
/// Default: Accept any contact.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterSettings` named `mSupportingVolume`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Plane *JPH_CharacterSettings_GetMutable_mSupportingVolume(JPH_CharacterSettings *_this);

/// Maximum angle of slope that character can still walk on (radians).
/// Returns a pointer to a member variable of class `JPH::CharacterSettings` named `mMaxSlopeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_CharacterSettings_Get_mMaxSlopeAngle(const JPH_CharacterSettings *_this);

/// Maximum angle of slope that character can still walk on (radians).
/// Modifies a member variable of class `JPH::CharacterSettings` named `mMaxSlopeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mMaxSlopeAngle`.
JOLT_API void JPH_CharacterSettings_Set_mMaxSlopeAngle(JPH_CharacterSettings *_this, float value);

/// Maximum angle of slope that character can still walk on (radians).
/// Returns a mutable pointer to a member variable of class `JPH::CharacterSettings` named `mMaxSlopeAngle`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_CharacterSettings_GetMutable_mMaxSlopeAngle(JPH_CharacterSettings *_this);

/// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Returns a pointer to a member variable of class `JPH::CharacterSettings` named `mEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const bool *JPH_CharacterSettings_Get_mEnhancedInternalEdgeRemoval(const JPH_CharacterSettings *_this);

/// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Modifies a member variable of class `JPH::CharacterSettings` named `mEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mEnhancedInternalEdgeRemoval`.
JOLT_API void JPH_CharacterSettings_Set_mEnhancedInternalEdgeRemoval(JPH_CharacterSettings *_this, bool value);

/// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
/// Returns a mutable pointer to a member variable of class `JPH::CharacterSettings` named `mEnhancedInternalEdgeRemoval`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API bool *JPH_CharacterSettings_GetMutable_mEnhancedInternalEdgeRemoval(JPH_CharacterSettings *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterSettings *JPH_CharacterSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_CharacterSettings_DestroyArray()`.
/// Use `JPH_CharacterSettings_OffsetMutablePtr()` and `JPH_CharacterSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_CharacterSettings *JPH_CharacterSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_CharacterSettings *JPH_CharacterSettings_OffsetPtr(const JPH_CharacterSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_CharacterSettings *JPH_CharacterSettings_OffsetMutablePtr(JPH_CharacterSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::CharacterSettings` to its base class `JPH::RefTarget<JPH::CharacterBaseSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_CharacterBaseSettings *JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(const JPH_CharacterSettings *object);

/// Upcasts an instance of `JPH::CharacterSettings` to its base class `JPH::RefTarget<JPH::CharacterBaseSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_CharacterBaseSettings *JPH_CharacterSettings_MutableUpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(JPH_CharacterSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::CharacterBaseSettings>` to a derived class `JPH::CharacterSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterSettings *JPH_CharacterSettings_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(const JPH_RefTarget_JPH_CharacterBaseSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::CharacterBaseSettings>` to a derived class `JPH::CharacterSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterSettings *JPH_CharacterSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(JPH_RefTarget_JPH_CharacterBaseSettings *object);

/// Upcasts an instance of `JPH::CharacterSettings` to its base class `JPH::CharacterBaseSettings`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterBaseSettings *JPH_CharacterSettings_UpcastTo_JPH_CharacterBaseSettings(const JPH_CharacterSettings *object);

/// Upcasts an instance of `JPH::CharacterSettings` to its base class `JPH::CharacterBaseSettings`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterBaseSettings *JPH_CharacterSettings_MutableUpcastTo_JPH_CharacterBaseSettings(JPH_CharacterSettings *object);

/// Downcasts an instance of `JPH::CharacterBaseSettings` to a derived class `JPH::CharacterSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterSettings *JPH_CharacterSettings_StaticDowncastFrom_JPH_CharacterBaseSettings(const JPH_CharacterBaseSettings *object);

/// Downcasts an instance of `JPH::CharacterBaseSettings` to a derived class `JPH::CharacterSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterSettings *JPH_CharacterSettings_MutableStaticDowncastFrom_JPH_CharacterBaseSettings(JPH_CharacterBaseSettings *object);

/// Generated from constructor `JPH::CharacterSettings::CharacterSettings`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterSettings *JPH_CharacterSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CharacterSettings *_other);

/// Destroys a heap-allocated instance of `JPH_CharacterSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterSettings_Destroy(const JPH_CharacterSettings *_this);

/// Destroys a heap-allocated array of `JPH_CharacterSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_CharacterSettings_DestroyArray(const JPH_CharacterSettings *_this);

/// Generated from method `JPH::CharacterSettings::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_CharacterSettings *JPH_CharacterSettings_AssignFromAnother(JPH_CharacterSettings *_this, Jolt_PassBy _other_pass_by, JPH_CharacterSettings *_other);

/// Generated from method `JPH::CharacterSettings::operator new`.
JOLT_API void *Jolt_new_JPH_CharacterSettings_size_t(size_t inCount);

/// Generated from method `JPH::CharacterSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::CharacterSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CharacterSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CharacterSettings_size_t(size_t inCount);

/// Generated from method `JPH::CharacterSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::CharacterSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::CharacterSettings::operator new`.
JOLT_API void *Jolt_new_JPH_CharacterSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CharacterSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_CharacterSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::CharacterSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_CharacterSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::CharacterSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_CharacterSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::CharacterSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterSettings_SetEmbedded(const JPH_CharacterSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::CharacterSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_CharacterSettings_GetRefCount(const JPH_CharacterSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::CharacterSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterSettings_AddRef(const JPH_CharacterSettings *_this);

/// Generated from method `JPH::CharacterSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_CharacterSettings_Release(const JPH_CharacterSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::CharacterSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_CharacterSettings_sInternalGetRefCountOffset(void);

/// Constructor
/// @param inSettings The settings for the character
/// @param inPosition Initial position for the character
/// @param inRotation Initial rotation for the character (usually only around Y)
/// @param inUserData Application specific value
/// @param inSystem Physics system that this character will be added to later
/// Generated from constructor `JPH::Character::Character`.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Character_Destroy()` to free it when you're done using it.
JOLT_API JPH_Character *JPH_Character_Construct(const JPH_CharacterSettings *inSettings, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, uint64_t inUserData, JPH_PhysicsSystem *inSystem);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Character *JPH_Character_OffsetPtr(const JPH_Character *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Character *JPH_Character_OffsetMutablePtr(JPH_Character *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::Character` to its base class `JPH::RefTarget<JPH::CharacterBase>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_CharacterBase *JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase(const JPH_Character *object);

/// Upcasts an instance of `JPH::Character` to its base class `JPH::RefTarget<JPH::CharacterBase>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_CharacterBase *JPH_Character_MutableUpcastTo_JPH_RefTarget_JPH_CharacterBase(JPH_Character *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::CharacterBase>` to a derived class `JPH::Character`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Character *JPH_Character_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(const JPH_RefTarget_JPH_CharacterBase *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::CharacterBase>` to a derived class `JPH::Character`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Character *JPH_Character_MutableStaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(JPH_RefTarget_JPH_CharacterBase *object);

/// Upcasts an instance of `JPH::Character` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_Character_UpcastTo_JPH_NonCopyable(const JPH_Character *object);

/// Upcasts an instance of `JPH::Character` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_Character_MutableUpcastTo_JPH_NonCopyable(JPH_Character *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::Character`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Character *JPH_Character_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::Character`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Character *JPH_Character_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::Character` to its base class `JPH::CharacterBase`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_CharacterBase *JPH_Character_UpcastTo_JPH_CharacterBase(const JPH_Character *object);

/// Upcasts an instance of `JPH::Character` to its base class `JPH::CharacterBase`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_CharacterBase *JPH_Character_MutableUpcastTo_JPH_CharacterBase(JPH_Character *object);

/// Downcasts an instance of `JPH::CharacterBase` to a derived class `JPH::Character`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_Character *JPH_Character_StaticDowncastFrom_JPH_CharacterBase(const JPH_CharacterBase *object);

/// Downcasts an instance of `JPH::CharacterBase` to a derived class `JPH::Character`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_Character *JPH_Character_MutableStaticDowncastFrom_JPH_CharacterBase(JPH_CharacterBase *object);

/// Destroys a heap-allocated instance of `JPH_Character`. Does nothing if the pointer is null.
JOLT_API void JPH_Character_Destroy(const JPH_Character *_this);

/// Destroys a heap-allocated array of `JPH_Character`. Does nothing if the pointer is null.
JOLT_API void JPH_Character_DestroyArray(const JPH_Character *_this);

/// Generated from method `JPH::Character::operator new`.
JOLT_API void *Jolt_new_JPH_Character_size_t(size_t inCount);

/// Generated from method `JPH::Character::operator delete`.
JOLT_API void Jolt_delete_JPH_Character_void_ptr(void *inPointer);

/// Generated from method `JPH::Character::operator delete`.
JOLT_API void Jolt_delete_JPH_Character_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Character::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Character_size_t(size_t inCount);

/// Generated from method `JPH::Character::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Character_void_ptr(void *inPointer);

/// Generated from method `JPH::Character::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Character_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::Character::operator new`.
JOLT_API void *Jolt_new_JPH_Character_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Character::operator delete`.
JOLT_API void Jolt_delete_JPH_Character_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::Character::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_Character_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::Character::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_Character_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Add bodies and constraints to the system and optionally activate the bodies
/// Generated from method `JPH::Character::AddToPhysicsSystem`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inActivationMode` has a default argument: `EActivation::Activate`, pass a null pointer to use it.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Character_AddToPhysicsSystem(JPH_Character *_this, const JPH_EActivation *inActivationMode, const bool *inLockBodies);

/// Remove bodies and constraints from the system
/// Generated from method `JPH::Character::RemoveFromPhysicsSystem`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Character_RemoveFromPhysicsSystem(JPH_Character *_this, const bool *inLockBodies);

/// Wake up the character
/// Generated from method `JPH::Character::Activate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Character_Activate(JPH_Character *_this, const bool *inLockBodies);

/// Needs to be called after every PhysicsSystem::Update
/// @param inMaxSeparationDistance Max distance between the floor and the character to still consider the character standing on the floor
/// @param inLockBodies If the collision query should use the locking body interface (true) or the non locking body interface (false)
/// Generated from method `JPH::Character::PostSimulation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Character_PostSimulation(JPH_Character *_this, float inMaxSeparationDistance, const bool *inLockBodies);

/// Control the velocity of the character
/// Generated from method `JPH::Character::SetLinearAndAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
/// Parameter `inAngularVelocity` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Character_SetLinearAndAngularVelocity(JPH_Character *_this, const JPH_Vec3 *inLinearVelocity, const JPH_Vec3 *inAngularVelocity, const bool *inLockBodies);

/// Get the linear velocity of the character (m / s)
/// Generated from method `JPH::Character::GetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Character_GetLinearVelocity(const JPH_Character *_this, const bool *inLockBodies);

/// Set the linear velocity of the character (m / s)
/// Generated from method `JPH::Character::SetLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Character_SetLinearVelocity(JPH_Character *_this, const JPH_Vec3 *inLinearVelocity, const bool *inLockBodies);

/// Add world space linear velocity to current velocity (m / s)
/// Generated from method `JPH::Character::AddLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLinearVelocity` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Character_AddLinearVelocity(JPH_Character *_this, const JPH_Vec3 *inLinearVelocity, const bool *inLockBodies);

/// Add impulse to the center of mass of the character
/// Generated from method `JPH::Character::AddImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inImpulse` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Character_AddImpulse(JPH_Character *_this, const JPH_Vec3 *inImpulse, const bool *inLockBodies);

/// Get the body associated with this character
/// Generated from method `JPH::Character::GetBodyID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_BodyID JPH_Character_GetBodyID(const JPH_Character *_this);

/// Get position / rotation of the body
/// Generated from method `JPH::Character::GetPositionAndRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `outPosition` can not be null. It is a single object.
/// Parameter `outRotation` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Character_GetPositionAndRotation(const JPH_Character *_this, JPH_Vec3 *outPosition, JPH_Quat *outRotation, const bool *inLockBodies);

/// Set the position / rotation of the body, optionally activating it.
/// Generated from method `JPH::Character::SetPositionAndRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inActivationMode` has a default argument: `EActivation::Activate`, pass a null pointer to use it.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Character_SetPositionAndRotation(const JPH_Character *_this, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const JPH_EActivation *inActivationMode, const bool *inLockBodies);

/// Get the position of the character
/// Generated from method `JPH::Character::GetPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Character_GetPosition(const JPH_Character *_this, const bool *inLockBodies);

/// Set the position of the character, optionally activating it.
/// Generated from method `JPH::Character::SetPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inActivationMode` has a default argument: `EActivation::Activate`, pass a null pointer to use it.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Character_SetPosition(JPH_Character *_this, const JPH_Vec3 *inPosition, const JPH_EActivation *inActivationMode, const bool *inLockBodies);

/// Get the rotation of the character
/// Generated from method `JPH::Character::GetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Quat_Destroy()` to free it when you're done using it.
JOLT_API JPH_Quat *JPH_Character_GetRotation(const JPH_Character *_this, const bool *inLockBodies);

/// Set the rotation of the character, optionally activating it.
/// Generated from method `JPH::Character::SetRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRotation` can not be null. It is a single object.
/// Parameter `inActivationMode` has a default argument: `EActivation::Activate`, pass a null pointer to use it.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Character_SetRotation(JPH_Character *_this, const JPH_Quat *inRotation, const JPH_EActivation *inActivationMode, const bool *inLockBodies);

/// Position of the center of mass of the underlying rigid body
/// Generated from method `JPH::Character::GetCenterOfMassPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Character_GetCenterOfMassPosition(const JPH_Character *_this, const bool *inLockBodies);

/// Calculate the world transform of the character
/// Generated from method `JPH::Character::GetWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Mat44_Destroy()` to free it when you're done using it.
JOLT_API JPH_Mat44 *JPH_Character_GetWorldTransform(const JPH_Character *_this, const bool *inLockBodies);

/// Get the layer of the character
/// Generated from method `JPH::Character::GetLayer`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned short JPH_Character_GetLayer(const JPH_Character *_this);

/// Update the layer of the character
/// Generated from method `JPH::Character::SetLayer`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API void JPH_Character_SetLayer(JPH_Character *_this, unsigned short inLayer, const bool *inLockBodies);

/// Switch the shape of the character (e.g. for stance). When inMaxPenetrationDepth is not FLT_MAX, it checks
/// if the new shape collides before switching shape. Returns true if the switch succeeded.
/// Generated from method `JPH::Character::SetShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
JOLT_API bool JPH_Character_SetShape(JPH_Character *_this, const JPH_Shape *inShape, float inMaxPenetrationDepth, const bool *inLockBodies);

/// Get the transformed shape that represents the volume of the character, can be used for collision checks.
/// Generated from method `JPH::Character::GetTransformedShape`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_TransformedShape_Destroy()` to free it when you're done using it.
JOLT_API JPH_TransformedShape *JPH_Character_GetTransformedShape(const JPH_Character *_this, const bool *inLockBodies);

/// Get the character settings that can recreate this character
/// Generated from method `JPH::Character::GetCharacterSettings`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inLockBodies` has a default argument: `true`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_CharacterSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_CharacterSettings *JPH_Character_GetCharacterSettings(const JPH_Character *_this, const bool *inLockBodies);

/// Set the maximum angle of slope that character can still walk on (radians)
/// Generated from method `JPH::Character::SetMaxSlopeAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Character_SetMaxSlopeAngle(JPH_Character *_this, float inMaxSlopeAngle);

/// Generated from method `JPH::Character::GetCosMaxSlopeAngle`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API float JPH_Character_GetCosMaxSlopeAngle(const JPH_Character *_this);

/// Set the up vector for the character
/// Generated from method `JPH::Character::SetUp`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inUp` can not be null. It is a single object.
JOLT_API void JPH_Character_SetUp(JPH_Character *_this, const JPH_Vec3 *inUp);

/// Generated from method `JPH::Character::GetUp`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Character_GetUp(const JPH_Character *_this);

/// Check if the normal of the ground surface is too steep to walk on
/// Generated from method `JPH::Character::IsSlopeTooSteep`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inNormal` can not be null. It is a single object.
JOLT_API bool JPH_Character_IsSlopeTooSteep(const JPH_Character *_this, const JPH_Vec3 *inNormal);

/// Get the current shape that the character is using.
/// Generated from method `JPH::Character::GetShape`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_Shape *JPH_Character_GetShape(const JPH_Character *_this);

/// Debug function to convert enum values to string
/// Generated from method `JPH::Character::sToString`.
JOLT_API const char *JPH_Character_sToString(JPH_CharacterBase_EGroundState inState);

/// Current ground state
/// Generated from method `JPH::Character::GetGroundState`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_CharacterBase_EGroundState JPH_Character_GetGroundState(const JPH_Character *_this);

/// Returns true if the player is supported by normal or steep ground
/// Generated from method `JPH::Character::IsSupported`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API bool JPH_Character_IsSupported(const JPH_Character *_this);

/// Get the contact point with the ground
/// Generated from method `JPH::Character::GetGroundPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Character_GetGroundPosition(const JPH_Character *_this);

/// Get the contact normal with the ground
/// Generated from method `JPH::Character::GetGroundNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Character_GetGroundNormal(const JPH_Character *_this);

/// Velocity in world space of ground
/// Generated from method `JPH::Character::GetGroundVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *JPH_Character_GetGroundVelocity(const JPH_Character *_this);

/// Material that the character is standing on
/// Generated from method `JPH::Character::GetGroundMaterial`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API const JPH_PhysicsMaterial *JPH_Character_GetGroundMaterial(const JPH_Character *_this);

/// BodyID of the object the character is standing on. Note may have been removed!
/// Generated from method `JPH::Character::GetGroundBodyID`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API JPH_BodyID JPH_Character_GetGroundBodyID(const JPH_Character *_this);

/// Sub part of the body that we're standing on.
/// Generated from method `JPH::Character::GetGroundSubShapeID`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_SubShapeID_Destroy()` to free it when you're done using it.
JOLT_API JPH_SubShapeID *JPH_Character_GetGroundSubShapeID(const JPH_Character *_this);

/// User data value of the body that we're standing on
/// Generated from method `JPH::Character::GetGroundUserData`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API uint64_t JPH_Character_GetGroundUserData(const JPH_Character *_this);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::Character::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Character_SetEmbedded(const JPH_Character *_this);

/// Get current refcount of this object
/// Generated from method `JPH::Character::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_Character_GetRefCount(const JPH_Character *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::Character::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Character_AddRef(const JPH_Character *_this);

/// Generated from method `JPH::Character::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_Character_Release(const JPH_Character *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::Character::sInternalGetRefCountOffset`.
JOLT_API int JPH_Character_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
