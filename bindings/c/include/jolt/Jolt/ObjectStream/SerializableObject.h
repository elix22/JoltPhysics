// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Classes must be derived from SerializableObject if you want to be able to save pointers or
/// reference counting pointers to objects of this or derived classes. The type will automatically
/// be determined during serialization and upon deserialization it will be restored correctly.
/// Generated from class `JPH::SerializableObject`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::ConstraintSettings`
///     `JPH::GroupFilter`
///     `JPH::PathConstraintPath`
///     `JPH::PhysicsMaterial`
///     `JPH::ShapeSettings`
///     `JPH::VehicleControllerSettings`
///     `JPH::WheelSettings`
///   Indirect: (non-virtual)
///     `JPH::BoxShapeSettings`
///     `JPH::CapsuleShapeSettings`
///     `JPH::CompoundShapeSettings`
///     `JPH::ConeConstraintSettings`
///     `JPH::ConvexHullShapeSettings`
///     `JPH::ConvexShapeSettings`
///     `JPH::CylinderShapeSettings`
///     `JPH::DecoratedShapeSettings`
///     `JPH::DistanceConstraintSettings`
///     `JPH::EmptyShapeSettings`
///     `JPH::FixedConstraintSettings`
///     `JPH::GearConstraintSettings`
///     `JPH::GroupFilterTable`
///     `JPH::HeightFieldShapeSettings`
///     `JPH::HingeConstraintSettings`
///     `JPH::MeshShapeSettings`
///     `JPH::MutableCompoundShapeSettings`
///     `JPH::OffsetCenterOfMassShapeSettings`
///     `JPH::PathConstraintPathHermite`
///     `JPH::PhysicsMaterialSimple`
///     `JPH::PlaneShapeSettings`
///     `JPH::PointConstraintSettings`
///     `JPH::PulleyConstraintSettings`
///     `JPH::RackAndPinionConstraintSettings`
///     `JPH::RotatedTranslatedShapeSettings`
///     `JPH::ScaledShapeSettings`
///     `JPH::SixDOFConstraintSettings`
///     `JPH::SliderConstraintSettings`
///     `JPH::SphereShapeSettings`
///     `JPH::StaticCompoundShapeSettings`
///     `JPH::SwingTwistConstraintSettings`
///     `JPH::TaperedCapsuleShapeSettings`
///     `JPH::TaperedCylinderShapeSettings`
///     `JPH::TriangleShapeSettings`
///     `JPH::TwoBodyConstraintSettings`
///     `JPH::VehicleConstraintSettings`
///     `JPH::WheelSettingsWV`
///     `JPH::WheeledVehicleControllerSettings`
typedef struct JPH_SerializableObject JPH_SerializableObject;

/// Destroys a heap-allocated instance of `JPH_SerializableObject`. Does nothing if the pointer is null.
JOLT_API void JPH_SerializableObject_Destroy(const JPH_SerializableObject *_this);

/// Destroys a heap-allocated array of `JPH_SerializableObject`. Does nothing if the pointer is null.
JOLT_API void JPH_SerializableObject_DestroyArray(const JPH_SerializableObject *_this);

/// Generated from method `JPH::SerializableObject::operator new`.
JOLT_API void *Jolt_new_JPH_SerializableObject_size_t(size_t inCount);

/// Generated from method `JPH::SerializableObject::operator delete`.
JOLT_API void Jolt_delete_JPH_SerializableObject_void_ptr(void *inPointer);

/// Generated from method `JPH::SerializableObject::operator delete`.
JOLT_API void Jolt_delete_JPH_SerializableObject_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SerializableObject::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SerializableObject_size_t(size_t inCount);

/// Generated from method `JPH::SerializableObject::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SerializableObject_void_ptr(void *inPointer);

/// Generated from method `JPH::SerializableObject::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SerializableObject_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::SerializableObject::operator new`.
JOLT_API void *Jolt_new_JPH_SerializableObject_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SerializableObject::operator delete`.
JOLT_API void Jolt_delete_JPH_SerializableObject_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::SerializableObject::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_SerializableObject_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::SerializableObject::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_SerializableObject_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_SerializableObject_OffsetPtr(const JPH_SerializableObject *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_SerializableObject_OffsetMutablePtr(JPH_SerializableObject *ptr, ptrdiff_t i);

#ifdef __cplusplus
} // extern "C"
#endif
