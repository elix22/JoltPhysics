// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::ShapeSettings>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::ShapeSettings`
///   Indirect: (non-virtual)
///     `JPH::BoxShapeSettings`
///     `JPH::CapsuleShapeSettings`
///     `JPH::CompoundShapeSettings`
///     `JPH::ConvexHullShapeSettings`
///     `JPH::ConvexShapeSettings`
///     `JPH::CylinderShapeSettings`
///     `JPH::DecoratedShapeSettings`
///     `JPH::EmptyShapeSettings`
///     `JPH::HeightFieldShapeSettings`
///     `JPH::MeshShapeSettings`
///     `JPH::MutableCompoundShapeSettings`
///     `JPH::OffsetCenterOfMassShapeSettings`
///     `JPH::PlaneShapeSettings`
///     `JPH::RotatedTranslatedShapeSettings`
///     `JPH::ScaledShapeSettings`
///     `JPH::SphereShapeSettings`
///     `JPH::StaticCompoundShapeSettings`
///     `JPH::TaperedCapsuleShapeSettings`
///     `JPH::TaperedCylinderShapeSettings`
///     `JPH::TriangleShapeSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_ShapeSettings JPH_RefTarget_JPH_ShapeSettings;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::Shape>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::Shape`
///   Indirect: (non-virtual)
///     `JPH::BoxShape`
///     `JPH::CapsuleShape`
///     `JPH::CompoundShape`
///     `JPH::ConvexHullShape`
///     `JPH::ConvexShape`
///     `JPH::CylinderShape`
///     `JPH::DecoratedShape`
///     `JPH::EmptyShape`
///     `JPH::HeightFieldShape`
///     `JPH::MeshShape`
///     `JPH::MutableCompoundShape`
///     `JPH::OffsetCenterOfMassShape`
///     `JPH::PlaneShape`
///     `JPH::RotatedTranslatedShape`
///     `JPH::ScaledShape`
///     `JPH::SphereShape`
///     `JPH::StaticCompoundShape`
///     `JPH::TaperedCapsuleShape`
///     `JPH::TaperedCylinderShape`
///     `JPH::TriangleShape`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_Shape JPH_RefTarget_JPH_Shape;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::PhysicsMaterial>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::PhysicsMaterial`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_PhysicsMaterial JPH_RefTarget_JPH_PhysicsMaterial;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::CharacterBaseSettings>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::CharacterBaseSettings`
///   Indirect: (non-virtual)
///     `JPH::CharacterSettings`
///     `JPH::CharacterVirtualSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_CharacterBaseSettings JPH_RefTarget_JPH_CharacterBaseSettings;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::CharacterBase>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::CharacterBase`
///   Indirect: (non-virtual)
///     `JPH::Character`
///     `JPH::CharacterVirtual`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_CharacterBase JPH_RefTarget_JPH_CharacterBase;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::ConstraintSettings>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::ConstraintSettings`
///   Indirect: (non-virtual)
///     `JPH::ConeConstraintSettings`
///     `JPH::DistanceConstraintSettings`
///     `JPH::FixedConstraintSettings`
///     `JPH::GearConstraintSettings`
///     `JPH::HingeConstraintSettings`
///     `JPH::PointConstraintSettings`
///     `JPH::PulleyConstraintSettings`
///     `JPH::RackAndPinionConstraintSettings`
///     `JPH::SixDOFConstraintSettings`
///     `JPH::SliderConstraintSettings`
///     `JPH::SwingTwistConstraintSettings`
///     `JPH::TwoBodyConstraintSettings`
///     `JPH::VehicleConstraintSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_ConstraintSettings JPH_RefTarget_JPH_ConstraintSettings;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::Constraint>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::Constraint`
///   Indirect: (non-virtual)
///     `JPH::ConeConstraint`
///     `JPH::DistanceConstraint`
///     `JPH::FixedConstraint`
///     `JPH::GearConstraint`
///     `JPH::HingeConstraint`
///     `JPH::PointConstraint`
///     `JPH::PulleyConstraint`
///     `JPH::RackAndPinionConstraint`
///     `JPH::SixDOFConstraint`
///     `JPH::SliderConstraint`
///     `JPH::SwingTwistConstraint`
///     `JPH::TwoBodyConstraint`
///     `JPH::VehicleConstraint`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_Constraint JPH_RefTarget_JPH_Constraint;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::GroupFilter>`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_GroupFilter JPH_RefTarget_JPH_GroupFilter;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::VehicleCollisionTester>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::VehicleCollisionTester`
///   Indirect: (non-virtual)
///     `JPH::VehicleCollisionTesterCastCylinder`
///     `JPH::VehicleCollisionTesterCastSphere`
///     `JPH::VehicleCollisionTesterRay`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_VehicleCollisionTester JPH_RefTarget_JPH_VehicleCollisionTester;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::WheelSettings>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::WheelSettings`
///   Indirect: (non-virtual)
///     `JPH::WheelSettingsWV`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_WheelSettings JPH_RefTarget_JPH_WheelSettings;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::DebugRenderer::Geometry>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::DebugRenderer::Geometry`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_DebugRenderer_Geometry JPH_RefTarget_JPH_DebugRenderer_Geometry;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::VehicleControllerSettings>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::VehicleControllerSettings`
///   Indirect: (non-virtual)
///     `JPH::WheeledVehicleControllerSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_VehicleControllerSettings JPH_RefTarget_JPH_VehicleControllerSettings;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::SoftBodySharedSettings>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::SoftBodySharedSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_SoftBodySharedSettings JPH_RefTarget_JPH_SoftBodySharedSettings;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::Skeleton>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::Skeleton`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_Skeleton JPH_RefTarget_JPH_Skeleton;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::SkeletalAnimation>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::SkeletalAnimation`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_SkeletalAnimation JPH_RefTarget_JPH_SkeletalAnimation;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::RagdollSettings>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::RagdollSettings`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_RagdollSettings JPH_RefTarget_JPH_RagdollSettings;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::Ragdoll>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::Ragdoll`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_Ragdoll JPH_RefTarget_JPH_Ragdoll;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::PathConstraintPath>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::PathConstraintPath`
///   Indirect: (non-virtual)
///     `JPH::PathConstraintPathHermite`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_PathConstraintPath JPH_RefTarget_JPH_PathConstraintPath;

/// Simple class to facilitate reference counting / releasing
/// Derive your class from RefTarget and you can reference it by using Ref<classname> or RefConst<classname>
///
/// Reference counting classes keep an integer which indicates how many references
/// to the object are active. Reference counting objects are derived from RefTarget
/// and staT & their life with a reference count of zero. They can then be assigned
/// to equivalents of pointers (Ref) which will increase the reference count immediately.
/// If the destructor of Ref is called or another object is assigned to the reference
/// counting pointer it will decrease the reference count of the object again. If this
/// reference count becomes zero, the object is destroyed.
///
/// This provides a very powerful mechanism to prevent memory leaks, but also gives
/// some responsibility to the programmer. The most notable point is that you cannot
/// have one object reference another and have the other reference the first one
/// back, because this way the reference count of both objects will never become
/// lower than 1, resulting in a memory leak. By carefully designing your classes
/// (and particularly identifying who owns who in the class hierarchy) you can avoid
/// these problems.
/// Generated from class `JPH::RefTarget<JPH::SkeletonMapper>`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::SkeletonMapper`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_RefTarget_JPH_SkeletonMapper JPH_RefTarget_JPH_SkeletonMapper;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_ShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_RefTarget_JPH_ShapeSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_ShapeSettings_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_ShapeSettings_OffsetMutablePtr()` and `JPH_RefTarget_JPH_ShapeSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_RefTarget_JPH_ShapeSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ShapeSettings *JPH_RefTarget_JPH_ShapeSettings_OffsetPtr(const JPH_RefTarget_JPH_ShapeSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_RefTarget_JPH_ShapeSettings_OffsetMutablePtr(JPH_RefTarget_JPH_ShapeSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::ShapeSettings>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_ShapeSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_RefTarget_JPH_ShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_ShapeSettings *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_ShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_ShapeSettings_Destroy(const JPH_RefTarget_JPH_ShapeSettings *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_ShapeSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_ShapeSettings_DestroyArray(const JPH_RefTarget_JPH_ShapeSettings *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::ShapeSettings>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_ShapeSettings *JPH_RefTarget_JPH_ShapeSettings_AssignFromAnother(JPH_RefTarget_JPH_ShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_ShapeSettings *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::ShapeSettings>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_ShapeSettings_SetEmbedded(const JPH_RefTarget_JPH_ShapeSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::ShapeSettings>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_ShapeSettings_GetRefCount(const JPH_RefTarget_JPH_ShapeSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::ShapeSettings>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_ShapeSettings_AddRef(const JPH_RefTarget_JPH_ShapeSettings *_this);

/// Generated from method `JPH::RefTarget<JPH::ShapeSettings>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_ShapeSettings_Release(const JPH_RefTarget_JPH_ShapeSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::ShapeSettings>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_ShapeSettings_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_Shape_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_RefTarget_JPH_Shape_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_Shape_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_Shape_OffsetMutablePtr()` and `JPH_RefTarget_JPH_Shape_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_RefTarget_JPH_Shape_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Shape *JPH_RefTarget_JPH_Shape_OffsetPtr(const JPH_RefTarget_JPH_Shape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_RefTarget_JPH_Shape_OffsetMutablePtr(JPH_RefTarget_JPH_Shape *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::Shape>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_Shape_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_RefTarget_JPH_Shape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Shape *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_Shape`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_Shape_Destroy(const JPH_RefTarget_JPH_Shape *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_Shape`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_Shape_DestroyArray(const JPH_RefTarget_JPH_Shape *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::Shape>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_Shape *JPH_RefTarget_JPH_Shape_AssignFromAnother(JPH_RefTarget_JPH_Shape *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Shape *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::Shape>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_Shape_SetEmbedded(const JPH_RefTarget_JPH_Shape *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::Shape>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_Shape_GetRefCount(const JPH_RefTarget_JPH_Shape *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::Shape>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_Shape_AddRef(const JPH_RefTarget_JPH_Shape *_this);

/// Generated from method `JPH::RefTarget<JPH::Shape>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_Shape_Release(const JPH_RefTarget_JPH_Shape *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::Shape>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_Shape_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_PhysicsMaterial_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_PhysicsMaterial *JPH_RefTarget_JPH_PhysicsMaterial_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_PhysicsMaterial_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_PhysicsMaterial_OffsetMutablePtr()` and `JPH_RefTarget_JPH_PhysicsMaterial_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_PhysicsMaterial *JPH_RefTarget_JPH_PhysicsMaterial_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_PhysicsMaterial *JPH_RefTarget_JPH_PhysicsMaterial_OffsetPtr(const JPH_RefTarget_JPH_PhysicsMaterial *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_PhysicsMaterial *JPH_RefTarget_JPH_PhysicsMaterial_OffsetMutablePtr(JPH_RefTarget_JPH_PhysicsMaterial *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::PhysicsMaterial>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_PhysicsMaterial_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_PhysicsMaterial *JPH_RefTarget_JPH_PhysicsMaterial_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_PhysicsMaterial *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_PhysicsMaterial`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_PhysicsMaterial_Destroy(const JPH_RefTarget_JPH_PhysicsMaterial *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_PhysicsMaterial`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_PhysicsMaterial_DestroyArray(const JPH_RefTarget_JPH_PhysicsMaterial *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::PhysicsMaterial>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_PhysicsMaterial *JPH_RefTarget_JPH_PhysicsMaterial_AssignFromAnother(JPH_RefTarget_JPH_PhysicsMaterial *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_PhysicsMaterial *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::PhysicsMaterial>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_PhysicsMaterial_SetEmbedded(const JPH_RefTarget_JPH_PhysicsMaterial *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::PhysicsMaterial>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_PhysicsMaterial_GetRefCount(const JPH_RefTarget_JPH_PhysicsMaterial *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::PhysicsMaterial>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_PhysicsMaterial_AddRef(const JPH_RefTarget_JPH_PhysicsMaterial *_this);

/// Generated from method `JPH::RefTarget<JPH::PhysicsMaterial>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_PhysicsMaterial_Release(const JPH_RefTarget_JPH_PhysicsMaterial *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::PhysicsMaterial>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_PhysicsMaterial_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_CharacterBaseSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_CharacterBaseSettings *JPH_RefTarget_JPH_CharacterBaseSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_CharacterBaseSettings_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_CharacterBaseSettings_OffsetMutablePtr()` and `JPH_RefTarget_JPH_CharacterBaseSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_CharacterBaseSettings *JPH_RefTarget_JPH_CharacterBaseSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_CharacterBaseSettings *JPH_RefTarget_JPH_CharacterBaseSettings_OffsetPtr(const JPH_RefTarget_JPH_CharacterBaseSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_CharacterBaseSettings *JPH_RefTarget_JPH_CharacterBaseSettings_OffsetMutablePtr(JPH_RefTarget_JPH_CharacterBaseSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::CharacterBaseSettings>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_CharacterBaseSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_CharacterBaseSettings *JPH_RefTarget_JPH_CharacterBaseSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_CharacterBaseSettings *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_CharacterBaseSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_CharacterBaseSettings_Destroy(const JPH_RefTarget_JPH_CharacterBaseSettings *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_CharacterBaseSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_CharacterBaseSettings_DestroyArray(const JPH_RefTarget_JPH_CharacterBaseSettings *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::CharacterBaseSettings>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_CharacterBaseSettings *JPH_RefTarget_JPH_CharacterBaseSettings_AssignFromAnother(JPH_RefTarget_JPH_CharacterBaseSettings *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_CharacterBaseSettings *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::CharacterBaseSettings>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_CharacterBaseSettings_SetEmbedded(const JPH_RefTarget_JPH_CharacterBaseSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::CharacterBaseSettings>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_CharacterBaseSettings_GetRefCount(const JPH_RefTarget_JPH_CharacterBaseSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::CharacterBaseSettings>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_CharacterBaseSettings_AddRef(const JPH_RefTarget_JPH_CharacterBaseSettings *_this);

/// Generated from method `JPH::RefTarget<JPH::CharacterBaseSettings>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_CharacterBaseSettings_Release(const JPH_RefTarget_JPH_CharacterBaseSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::CharacterBaseSettings>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_CharacterBaseSettings_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_CharacterBase_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_CharacterBase *JPH_RefTarget_JPH_CharacterBase_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_CharacterBase_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_CharacterBase_OffsetMutablePtr()` and `JPH_RefTarget_JPH_CharacterBase_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_CharacterBase *JPH_RefTarget_JPH_CharacterBase_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_CharacterBase *JPH_RefTarget_JPH_CharacterBase_OffsetPtr(const JPH_RefTarget_JPH_CharacterBase *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_CharacterBase *JPH_RefTarget_JPH_CharacterBase_OffsetMutablePtr(JPH_RefTarget_JPH_CharacterBase *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::CharacterBase>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_CharacterBase_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_CharacterBase *JPH_RefTarget_JPH_CharacterBase_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_CharacterBase *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_CharacterBase`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_CharacterBase_Destroy(const JPH_RefTarget_JPH_CharacterBase *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_CharacterBase`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_CharacterBase_DestroyArray(const JPH_RefTarget_JPH_CharacterBase *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::CharacterBase>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_CharacterBase *JPH_RefTarget_JPH_CharacterBase_AssignFromAnother(JPH_RefTarget_JPH_CharacterBase *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_CharacterBase *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::CharacterBase>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_CharacterBase_SetEmbedded(const JPH_RefTarget_JPH_CharacterBase *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::CharacterBase>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_CharacterBase_GetRefCount(const JPH_RefTarget_JPH_CharacterBase *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::CharacterBase>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_CharacterBase_AddRef(const JPH_RefTarget_JPH_CharacterBase *_this);

/// Generated from method `JPH::RefTarget<JPH::CharacterBase>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_CharacterBase_Release(const JPH_RefTarget_JPH_CharacterBase *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::CharacterBase>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_CharacterBase_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_ConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_RefTarget_JPH_ConstraintSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_ConstraintSettings_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_ConstraintSettings_OffsetMutablePtr()` and `JPH_RefTarget_JPH_ConstraintSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_RefTarget_JPH_ConstraintSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_ConstraintSettings *JPH_RefTarget_JPH_ConstraintSettings_OffsetPtr(const JPH_RefTarget_JPH_ConstraintSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_RefTarget_JPH_ConstraintSettings_OffsetMutablePtr(JPH_RefTarget_JPH_ConstraintSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::ConstraintSettings>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_ConstraintSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_RefTarget_JPH_ConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_ConstraintSettings *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_ConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_ConstraintSettings_Destroy(const JPH_RefTarget_JPH_ConstraintSettings *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_ConstraintSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_ConstraintSettings_DestroyArray(const JPH_RefTarget_JPH_ConstraintSettings *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::ConstraintSettings>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_ConstraintSettings *JPH_RefTarget_JPH_ConstraintSettings_AssignFromAnother(JPH_RefTarget_JPH_ConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_ConstraintSettings *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::ConstraintSettings>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_ConstraintSettings_SetEmbedded(const JPH_RefTarget_JPH_ConstraintSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::ConstraintSettings>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_ConstraintSettings_GetRefCount(const JPH_RefTarget_JPH_ConstraintSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::ConstraintSettings>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_ConstraintSettings_AddRef(const JPH_RefTarget_JPH_ConstraintSettings *_this);

/// Generated from method `JPH::RefTarget<JPH::ConstraintSettings>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_ConstraintSettings_Release(const JPH_RefTarget_JPH_ConstraintSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::ConstraintSettings>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_ConstraintSettings_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_Constraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_RefTarget_JPH_Constraint_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_Constraint_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_Constraint_OffsetMutablePtr()` and `JPH_RefTarget_JPH_Constraint_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_RefTarget_JPH_Constraint_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Constraint *JPH_RefTarget_JPH_Constraint_OffsetPtr(const JPH_RefTarget_JPH_Constraint *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_RefTarget_JPH_Constraint_OffsetMutablePtr(JPH_RefTarget_JPH_Constraint *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::Constraint>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_Constraint_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_RefTarget_JPH_Constraint_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Constraint *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_Constraint`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_Constraint_Destroy(const JPH_RefTarget_JPH_Constraint *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_Constraint`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_Constraint_DestroyArray(const JPH_RefTarget_JPH_Constraint *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::Constraint>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_Constraint *JPH_RefTarget_JPH_Constraint_AssignFromAnother(JPH_RefTarget_JPH_Constraint *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Constraint *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::Constraint>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_Constraint_SetEmbedded(const JPH_RefTarget_JPH_Constraint *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::Constraint>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_Constraint_GetRefCount(const JPH_RefTarget_JPH_Constraint *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::Constraint>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_Constraint_AddRef(const JPH_RefTarget_JPH_Constraint *_this);

/// Generated from method `JPH::RefTarget<JPH::Constraint>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_Constraint_Release(const JPH_RefTarget_JPH_Constraint *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::Constraint>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_Constraint_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_GroupFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_GroupFilter *JPH_RefTarget_JPH_GroupFilter_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_GroupFilter_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_GroupFilter_OffsetMutablePtr()` and `JPH_RefTarget_JPH_GroupFilter_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_GroupFilter *JPH_RefTarget_JPH_GroupFilter_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_GroupFilter *JPH_RefTarget_JPH_GroupFilter_OffsetPtr(const JPH_RefTarget_JPH_GroupFilter *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_GroupFilter *JPH_RefTarget_JPH_GroupFilter_OffsetMutablePtr(JPH_RefTarget_JPH_GroupFilter *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::GroupFilter>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_GroupFilter_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_GroupFilter *JPH_RefTarget_JPH_GroupFilter_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_GroupFilter *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_GroupFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_GroupFilter_Destroy(const JPH_RefTarget_JPH_GroupFilter *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_GroupFilter`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_GroupFilter_DestroyArray(const JPH_RefTarget_JPH_GroupFilter *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::GroupFilter>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_GroupFilter *JPH_RefTarget_JPH_GroupFilter_AssignFromAnother(JPH_RefTarget_JPH_GroupFilter *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_GroupFilter *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::GroupFilter>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_GroupFilter_SetEmbedded(const JPH_RefTarget_JPH_GroupFilter *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::GroupFilter>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_GroupFilter_GetRefCount(const JPH_RefTarget_JPH_GroupFilter *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::GroupFilter>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_GroupFilter_AddRef(const JPH_RefTarget_JPH_GroupFilter *_this);

/// Generated from method `JPH::RefTarget<JPH::GroupFilter>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_GroupFilter_Release(const JPH_RefTarget_JPH_GroupFilter *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::GroupFilter>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_GroupFilter_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_VehicleCollisionTester_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_VehicleCollisionTester *JPH_RefTarget_JPH_VehicleCollisionTester_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_VehicleCollisionTester_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_VehicleCollisionTester_OffsetMutablePtr()` and `JPH_RefTarget_JPH_VehicleCollisionTester_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_VehicleCollisionTester *JPH_RefTarget_JPH_VehicleCollisionTester_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_VehicleCollisionTester *JPH_RefTarget_JPH_VehicleCollisionTester_OffsetPtr(const JPH_RefTarget_JPH_VehicleCollisionTester *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_VehicleCollisionTester *JPH_RefTarget_JPH_VehicleCollisionTester_OffsetMutablePtr(JPH_RefTarget_JPH_VehicleCollisionTester *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::VehicleCollisionTester>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_VehicleCollisionTester_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_VehicleCollisionTester *JPH_RefTarget_JPH_VehicleCollisionTester_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_VehicleCollisionTester *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_VehicleCollisionTester`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_VehicleCollisionTester_Destroy(const JPH_RefTarget_JPH_VehicleCollisionTester *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_VehicleCollisionTester`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_VehicleCollisionTester_DestroyArray(const JPH_RefTarget_JPH_VehicleCollisionTester *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::VehicleCollisionTester>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_VehicleCollisionTester *JPH_RefTarget_JPH_VehicleCollisionTester_AssignFromAnother(JPH_RefTarget_JPH_VehicleCollisionTester *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_VehicleCollisionTester *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::VehicleCollisionTester>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_VehicleCollisionTester_SetEmbedded(const JPH_RefTarget_JPH_VehicleCollisionTester *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::VehicleCollisionTester>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_VehicleCollisionTester_GetRefCount(const JPH_RefTarget_JPH_VehicleCollisionTester *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::VehicleCollisionTester>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(const JPH_RefTarget_JPH_VehicleCollisionTester *_this);

/// Generated from method `JPH::RefTarget<JPH::VehicleCollisionTester>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_VehicleCollisionTester_Release(const JPH_RefTarget_JPH_VehicleCollisionTester *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::VehicleCollisionTester>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_VehicleCollisionTester_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_WheelSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_WheelSettings *JPH_RefTarget_JPH_WheelSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_WheelSettings_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_WheelSettings_OffsetMutablePtr()` and `JPH_RefTarget_JPH_WheelSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_WheelSettings *JPH_RefTarget_JPH_WheelSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_WheelSettings *JPH_RefTarget_JPH_WheelSettings_OffsetPtr(const JPH_RefTarget_JPH_WheelSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_WheelSettings *JPH_RefTarget_JPH_WheelSettings_OffsetMutablePtr(JPH_RefTarget_JPH_WheelSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::WheelSettings>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_WheelSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_WheelSettings *JPH_RefTarget_JPH_WheelSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_WheelSettings *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_WheelSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_WheelSettings_Destroy(const JPH_RefTarget_JPH_WheelSettings *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_WheelSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_WheelSettings_DestroyArray(const JPH_RefTarget_JPH_WheelSettings *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::WheelSettings>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_WheelSettings *JPH_RefTarget_JPH_WheelSettings_AssignFromAnother(JPH_RefTarget_JPH_WheelSettings *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_WheelSettings *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::WheelSettings>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_WheelSettings_SetEmbedded(const JPH_RefTarget_JPH_WheelSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::WheelSettings>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_WheelSettings_GetRefCount(const JPH_RefTarget_JPH_WheelSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::WheelSettings>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_WheelSettings_AddRef(const JPH_RefTarget_JPH_WheelSettings *_this);

/// Generated from method `JPH::RefTarget<JPH::WheelSettings>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_WheelSettings_Release(const JPH_RefTarget_JPH_WheelSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::WheelSettings>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_WheelSettings_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_DebugRenderer_Geometry_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_RefTarget_JPH_DebugRenderer_Geometry_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_DebugRenderer_Geometry_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_DebugRenderer_Geometry_OffsetMutablePtr()` and `JPH_RefTarget_JPH_DebugRenderer_Geometry_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_RefTarget_JPH_DebugRenderer_Geometry_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_RefTarget_JPH_DebugRenderer_Geometry_OffsetPtr(const JPH_RefTarget_JPH_DebugRenderer_Geometry *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_RefTarget_JPH_DebugRenderer_Geometry_OffsetMutablePtr(JPH_RefTarget_JPH_DebugRenderer_Geometry *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::DebugRenderer::Geometry>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_DebugRenderer_Geometry_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_RefTarget_JPH_DebugRenderer_Geometry_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_DebugRenderer_Geometry *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_DebugRenderer_Geometry`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_DebugRenderer_Geometry_Destroy(const JPH_RefTarget_JPH_DebugRenderer_Geometry *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_DebugRenderer_Geometry`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_DebugRenderer_Geometry_DestroyArray(const JPH_RefTarget_JPH_DebugRenderer_Geometry *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::DebugRenderer::Geometry>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_RefTarget_JPH_DebugRenderer_Geometry_AssignFromAnother(JPH_RefTarget_JPH_DebugRenderer_Geometry *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_DebugRenderer_Geometry *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::DebugRenderer::Geometry>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_DebugRenderer_Geometry_SetEmbedded(const JPH_RefTarget_JPH_DebugRenderer_Geometry *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::DebugRenderer::Geometry>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_DebugRenderer_Geometry_GetRefCount(const JPH_RefTarget_JPH_DebugRenderer_Geometry *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::DebugRenderer::Geometry>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef(const JPH_RefTarget_JPH_DebugRenderer_Geometry *_this);

/// Generated from method `JPH::RefTarget<JPH::DebugRenderer::Geometry>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_DebugRenderer_Geometry_Release(const JPH_RefTarget_JPH_DebugRenderer_Geometry *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::DebugRenderer::Geometry>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_DebugRenderer_Geometry_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_VehicleControllerSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_VehicleControllerSettings *JPH_RefTarget_JPH_VehicleControllerSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_VehicleControllerSettings_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_VehicleControllerSettings_OffsetMutablePtr()` and `JPH_RefTarget_JPH_VehicleControllerSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_VehicleControllerSettings *JPH_RefTarget_JPH_VehicleControllerSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_VehicleControllerSettings *JPH_RefTarget_JPH_VehicleControllerSettings_OffsetPtr(const JPH_RefTarget_JPH_VehicleControllerSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_VehicleControllerSettings *JPH_RefTarget_JPH_VehicleControllerSettings_OffsetMutablePtr(JPH_RefTarget_JPH_VehicleControllerSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::VehicleControllerSettings>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_VehicleControllerSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_VehicleControllerSettings *JPH_RefTarget_JPH_VehicleControllerSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_VehicleControllerSettings *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_VehicleControllerSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_VehicleControllerSettings_Destroy(const JPH_RefTarget_JPH_VehicleControllerSettings *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_VehicleControllerSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_VehicleControllerSettings_DestroyArray(const JPH_RefTarget_JPH_VehicleControllerSettings *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::VehicleControllerSettings>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_VehicleControllerSettings *JPH_RefTarget_JPH_VehicleControllerSettings_AssignFromAnother(JPH_RefTarget_JPH_VehicleControllerSettings *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_VehicleControllerSettings *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::VehicleControllerSettings>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_VehicleControllerSettings_SetEmbedded(const JPH_RefTarget_JPH_VehicleControllerSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::VehicleControllerSettings>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_VehicleControllerSettings_GetRefCount(const JPH_RefTarget_JPH_VehicleControllerSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::VehicleControllerSettings>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(const JPH_RefTarget_JPH_VehicleControllerSettings *_this);

/// Generated from method `JPH::RefTarget<JPH::VehicleControllerSettings>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_VehicleControllerSettings_Release(const JPH_RefTarget_JPH_VehicleControllerSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::VehicleControllerSettings>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_VehicleControllerSettings_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_SoftBodySharedSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_RefTarget_JPH_SoftBodySharedSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_SoftBodySharedSettings_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_SoftBodySharedSettings_OffsetMutablePtr()` and `JPH_RefTarget_JPH_SoftBodySharedSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_RefTarget_JPH_SoftBodySharedSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_RefTarget_JPH_SoftBodySharedSettings_OffsetPtr(const JPH_RefTarget_JPH_SoftBodySharedSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_RefTarget_JPH_SoftBodySharedSettings_OffsetMutablePtr(JPH_RefTarget_JPH_SoftBodySharedSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::SoftBodySharedSettings>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_SoftBodySharedSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_RefTarget_JPH_SoftBodySharedSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_SoftBodySharedSettings *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_SoftBodySharedSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_SoftBodySharedSettings_Destroy(const JPH_RefTarget_JPH_SoftBodySharedSettings *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_SoftBodySharedSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_SoftBodySharedSettings_DestroyArray(const JPH_RefTarget_JPH_SoftBodySharedSettings *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::SoftBodySharedSettings>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_RefTarget_JPH_SoftBodySharedSettings_AssignFromAnother(JPH_RefTarget_JPH_SoftBodySharedSettings *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_SoftBodySharedSettings *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::SoftBodySharedSettings>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_SoftBodySharedSettings_SetEmbedded(const JPH_RefTarget_JPH_SoftBodySharedSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::SoftBodySharedSettings>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_SoftBodySharedSettings_GetRefCount(const JPH_RefTarget_JPH_SoftBodySharedSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::SoftBodySharedSettings>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef(const JPH_RefTarget_JPH_SoftBodySharedSettings *_this);

/// Generated from method `JPH::RefTarget<JPH::SoftBodySharedSettings>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_SoftBodySharedSettings_Release(const JPH_RefTarget_JPH_SoftBodySharedSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::SoftBodySharedSettings>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_SoftBodySharedSettings_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_Skeleton_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_Skeleton *JPH_RefTarget_JPH_Skeleton_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_Skeleton_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_Skeleton_OffsetMutablePtr()` and `JPH_RefTarget_JPH_Skeleton_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_Skeleton *JPH_RefTarget_JPH_Skeleton_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Skeleton *JPH_RefTarget_JPH_Skeleton_OffsetPtr(const JPH_RefTarget_JPH_Skeleton *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Skeleton *JPH_RefTarget_JPH_Skeleton_OffsetMutablePtr(JPH_RefTarget_JPH_Skeleton *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::Skeleton>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_Skeleton_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_Skeleton *JPH_RefTarget_JPH_Skeleton_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Skeleton *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_Skeleton`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_Skeleton_Destroy(const JPH_RefTarget_JPH_Skeleton *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_Skeleton`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_Skeleton_DestroyArray(const JPH_RefTarget_JPH_Skeleton *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::Skeleton>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_Skeleton *JPH_RefTarget_JPH_Skeleton_AssignFromAnother(JPH_RefTarget_JPH_Skeleton *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Skeleton *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::Skeleton>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_Skeleton_SetEmbedded(const JPH_RefTarget_JPH_Skeleton *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::Skeleton>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_Skeleton_GetRefCount(const JPH_RefTarget_JPH_Skeleton *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::Skeleton>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_Skeleton_AddRef(const JPH_RefTarget_JPH_Skeleton *_this);

/// Generated from method `JPH::RefTarget<JPH::Skeleton>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_Skeleton_Release(const JPH_RefTarget_JPH_Skeleton *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::Skeleton>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_Skeleton_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_SkeletalAnimation_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_SkeletalAnimation *JPH_RefTarget_JPH_SkeletalAnimation_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_SkeletalAnimation_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_SkeletalAnimation_OffsetMutablePtr()` and `JPH_RefTarget_JPH_SkeletalAnimation_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_SkeletalAnimation *JPH_RefTarget_JPH_SkeletalAnimation_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_SkeletalAnimation *JPH_RefTarget_JPH_SkeletalAnimation_OffsetPtr(const JPH_RefTarget_JPH_SkeletalAnimation *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_SkeletalAnimation *JPH_RefTarget_JPH_SkeletalAnimation_OffsetMutablePtr(JPH_RefTarget_JPH_SkeletalAnimation *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::SkeletalAnimation>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_SkeletalAnimation_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_SkeletalAnimation *JPH_RefTarget_JPH_SkeletalAnimation_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_SkeletalAnimation *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_SkeletalAnimation`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_SkeletalAnimation_Destroy(const JPH_RefTarget_JPH_SkeletalAnimation *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_SkeletalAnimation`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_SkeletalAnimation_DestroyArray(const JPH_RefTarget_JPH_SkeletalAnimation *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::SkeletalAnimation>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_SkeletalAnimation *JPH_RefTarget_JPH_SkeletalAnimation_AssignFromAnother(JPH_RefTarget_JPH_SkeletalAnimation *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_SkeletalAnimation *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::SkeletalAnimation>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_SkeletalAnimation_SetEmbedded(const JPH_RefTarget_JPH_SkeletalAnimation *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::SkeletalAnimation>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_SkeletalAnimation_GetRefCount(const JPH_RefTarget_JPH_SkeletalAnimation *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::SkeletalAnimation>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_SkeletalAnimation_AddRef(const JPH_RefTarget_JPH_SkeletalAnimation *_this);

/// Generated from method `JPH::RefTarget<JPH::SkeletalAnimation>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_SkeletalAnimation_Release(const JPH_RefTarget_JPH_SkeletalAnimation *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::SkeletalAnimation>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_SkeletalAnimation_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_RagdollSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_RagdollSettings *JPH_RefTarget_JPH_RagdollSettings_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_RagdollSettings_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_RagdollSettings_OffsetMutablePtr()` and `JPH_RefTarget_JPH_RagdollSettings_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_RagdollSettings *JPH_RefTarget_JPH_RagdollSettings_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_RagdollSettings *JPH_RefTarget_JPH_RagdollSettings_OffsetPtr(const JPH_RefTarget_JPH_RagdollSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_RagdollSettings *JPH_RefTarget_JPH_RagdollSettings_OffsetMutablePtr(JPH_RefTarget_JPH_RagdollSettings *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::RagdollSettings>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_RagdollSettings_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_RagdollSettings *JPH_RefTarget_JPH_RagdollSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_RagdollSettings *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_RagdollSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_RagdollSettings_Destroy(const JPH_RefTarget_JPH_RagdollSettings *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_RagdollSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_RagdollSettings_DestroyArray(const JPH_RefTarget_JPH_RagdollSettings *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::RagdollSettings>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_RagdollSettings *JPH_RefTarget_JPH_RagdollSettings_AssignFromAnother(JPH_RefTarget_JPH_RagdollSettings *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_RagdollSettings *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::RagdollSettings>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_RagdollSettings_SetEmbedded(const JPH_RefTarget_JPH_RagdollSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::RagdollSettings>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_RagdollSettings_GetRefCount(const JPH_RefTarget_JPH_RagdollSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::RagdollSettings>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_RagdollSettings_AddRef(const JPH_RefTarget_JPH_RagdollSettings *_this);

/// Generated from method `JPH::RefTarget<JPH::RagdollSettings>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_RagdollSettings_Release(const JPH_RefTarget_JPH_RagdollSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::RagdollSettings>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_RagdollSettings_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_Ragdoll_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_Ragdoll *JPH_RefTarget_JPH_Ragdoll_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_Ragdoll_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_Ragdoll_OffsetMutablePtr()` and `JPH_RefTarget_JPH_Ragdoll_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_Ragdoll *JPH_RefTarget_JPH_Ragdoll_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_Ragdoll *JPH_RefTarget_JPH_Ragdoll_OffsetPtr(const JPH_RefTarget_JPH_Ragdoll *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_Ragdoll *JPH_RefTarget_JPH_Ragdoll_OffsetMutablePtr(JPH_RefTarget_JPH_Ragdoll *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::Ragdoll>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_Ragdoll_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_Ragdoll *JPH_RefTarget_JPH_Ragdoll_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Ragdoll *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_Ragdoll`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_Ragdoll_Destroy(const JPH_RefTarget_JPH_Ragdoll *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_Ragdoll`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_Ragdoll_DestroyArray(const JPH_RefTarget_JPH_Ragdoll *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::Ragdoll>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_Ragdoll *JPH_RefTarget_JPH_Ragdoll_AssignFromAnother(JPH_RefTarget_JPH_Ragdoll *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Ragdoll *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::Ragdoll>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_Ragdoll_SetEmbedded(const JPH_RefTarget_JPH_Ragdoll *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::Ragdoll>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_Ragdoll_GetRefCount(const JPH_RefTarget_JPH_Ragdoll *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::Ragdoll>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_Ragdoll_AddRef(const JPH_RefTarget_JPH_Ragdoll *_this);

/// Generated from method `JPH::RefTarget<JPH::Ragdoll>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_Ragdoll_Release(const JPH_RefTarget_JPH_Ragdoll *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::Ragdoll>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_Ragdoll_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_PathConstraintPath_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_PathConstraintPath *JPH_RefTarget_JPH_PathConstraintPath_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_PathConstraintPath_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_PathConstraintPath_OffsetMutablePtr()` and `JPH_RefTarget_JPH_PathConstraintPath_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_PathConstraintPath *JPH_RefTarget_JPH_PathConstraintPath_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_PathConstraintPath *JPH_RefTarget_JPH_PathConstraintPath_OffsetPtr(const JPH_RefTarget_JPH_PathConstraintPath *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_PathConstraintPath *JPH_RefTarget_JPH_PathConstraintPath_OffsetMutablePtr(JPH_RefTarget_JPH_PathConstraintPath *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::PathConstraintPath>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_PathConstraintPath_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_PathConstraintPath *JPH_RefTarget_JPH_PathConstraintPath_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_PathConstraintPath *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_PathConstraintPath`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_PathConstraintPath_Destroy(const JPH_RefTarget_JPH_PathConstraintPath *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_PathConstraintPath`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_PathConstraintPath_DestroyArray(const JPH_RefTarget_JPH_PathConstraintPath *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::PathConstraintPath>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_PathConstraintPath *JPH_RefTarget_JPH_PathConstraintPath_AssignFromAnother(JPH_RefTarget_JPH_PathConstraintPath *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_PathConstraintPath *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::PathConstraintPath>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_PathConstraintPath_SetEmbedded(const JPH_RefTarget_JPH_PathConstraintPath *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::PathConstraintPath>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_PathConstraintPath_GetRefCount(const JPH_RefTarget_JPH_PathConstraintPath *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::PathConstraintPath>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_PathConstraintPath_AddRef(const JPH_RefTarget_JPH_PathConstraintPath *_this);

/// Generated from method `JPH::RefTarget<JPH::PathConstraintPath>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_PathConstraintPath_Release(const JPH_RefTarget_JPH_PathConstraintPath *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::PathConstraintPath>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_PathConstraintPath_sInternalGetRefCountOffset(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_SkeletonMapper_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_SkeletonMapper *JPH_RefTarget_JPH_SkeletonMapper_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_RefTarget_JPH_SkeletonMapper_DestroyArray()`.
/// Use `JPH_RefTarget_JPH_SkeletonMapper_OffsetMutablePtr()` and `JPH_RefTarget_JPH_SkeletonMapper_OffsetPtr()` to access the array elements.
JOLT_API JPH_RefTarget_JPH_SkeletonMapper *JPH_RefTarget_JPH_SkeletonMapper_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_SkeletonMapper *JPH_RefTarget_JPH_SkeletonMapper_OffsetPtr(const JPH_RefTarget_JPH_SkeletonMapper *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_SkeletonMapper *JPH_RefTarget_JPH_SkeletonMapper_OffsetMutablePtr(JPH_RefTarget_JPH_SkeletonMapper *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::RefTarget<JPH::SkeletonMapper>::RefTarget`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_RefTarget_JPH_SkeletonMapper_Destroy()` to free it when you're done using it.
JOLT_API JPH_RefTarget_JPH_SkeletonMapper *JPH_RefTarget_JPH_SkeletonMapper_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_SkeletonMapper *_other);

/// Destroys a heap-allocated instance of `JPH_RefTarget_JPH_SkeletonMapper`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_SkeletonMapper_Destroy(const JPH_RefTarget_JPH_SkeletonMapper *_this);

/// Destroys a heap-allocated array of `JPH_RefTarget_JPH_SkeletonMapper`. Does nothing if the pointer is null.
JOLT_API void JPH_RefTarget_JPH_SkeletonMapper_DestroyArray(const JPH_RefTarget_JPH_SkeletonMapper *_this);

/// Assignment operator
/// Generated from method `JPH::RefTarget<JPH::SkeletonMapper>::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_RefTarget_JPH_SkeletonMapper *JPH_RefTarget_JPH_SkeletonMapper_AssignFromAnother(JPH_RefTarget_JPH_SkeletonMapper *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_SkeletonMapper *_other);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::RefTarget<JPH::SkeletonMapper>::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_SkeletonMapper_SetEmbedded(const JPH_RefTarget_JPH_SkeletonMapper *_this);

/// Get current refcount of this object
/// Generated from method `JPH::RefTarget<JPH::SkeletonMapper>::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_RefTarget_JPH_SkeletonMapper_GetRefCount(const JPH_RefTarget_JPH_SkeletonMapper *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::RefTarget<JPH::SkeletonMapper>::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_SkeletonMapper_AddRef(const JPH_RefTarget_JPH_SkeletonMapper *_this);

/// Generated from method `JPH::RefTarget<JPH::SkeletonMapper>::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_RefTarget_JPH_SkeletonMapper_Release(const JPH_RefTarget_JPH_SkeletonMapper *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::RefTarget<JPH::SkeletonMapper>::sInternalGetRefCountOffset`.
JOLT_API int JPH_RefTarget_JPH_SkeletonMapper_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
