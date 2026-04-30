// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Class that makes another class non-copyable. Usage: Inherit from NonCopyable.
/// Generated from class `JPH::NonCopyable`.
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::Body`
///     `JPH::BodyFilter`
///     `JPH::BodyInterface`
///     `JPH::BroadPhaseLayerFilter`
///     `JPH::BroadPhaseLayerInterface`
///     `JPH::BroadPhaseQuery`
///     `JPH::CharacterBase`
///     `JPH::CharacterVsCharacterCollision`
///     `JPH::Constraint`
///     `JPH::JobSystem`
///     `JPH::JobSystem::Barrier`
///     `JPH::NarrowPhaseQuery`
///     `JPH::ObjectLayerFilter`
///     `JPH::ObjectLayerPairFilter`
///     `JPH::ObjectVsBroadPhaseLayerFilter`
///     `JPH::PhysicsSystem`
///     `JPH::Shape`
///     `JPH::ShapeFilter`
///     `JPH::TempAllocator`
///   Indirect: (non-virtual)
///     `JPH::BoxShape`
///     `JPH::BroadPhaseLayerInterfaceTable`
///     `JPH::CapsuleShape`
///     `JPH::CharacterVirtual`
///     `JPH::CharacterVsCharacterCollisionSimple`
///     `JPH::CompoundShape`
///     `JPH::ConvexHullShape`
///     `JPH::ConvexShape`
///     `JPH::CylinderShape`
///     `JPH::DecoratedShape`
///     `JPH::DefaultBroadPhaseLayerFilter`
///     `JPH::DefaultObjectLayerFilter`
///     `JPH::DistanceConstraint`
///     `JPH::EmptyShape`
///     `JPH::FixedConstraint`
///     `JPH::HeightFieldShape`
///     `JPH::HingeConstraint`
///     `JPH::IgnoreMultipleBodiesFilter`
///     `JPH::IgnoreSingleBodyFilter`
///     `JPH::JobSystemSingleThreaded`
///     `JPH::JobSystemThreadPool`
///     `JPH::JobSystemWithBarrier`
///     `JPH::MeshShape`
///     `JPH::MutableCompoundShape`
///     `JPH::ObjectLayerPairFilterMask`
///     `JPH::ObjectLayerPairFilterTable`
///     `JPH::ObjectVsBroadPhaseLayerFilterTable`
///     `JPH::OffsetCenterOfMassShape`
///     `JPH::PlaneShape`
///     `JPH::PointConstraint`
///     `JPH::ReversedShapeFilter`
///     `JPH::RotatedTranslatedShape`
///     `JPH::ScaledShape`
///     `JPH::SixDOFConstraint`
///     `JPH::SliderConstraint`
///     `JPH::SpecifiedBroadPhaseLayerFilter`
///     `JPH::SpecifiedObjectLayerFilter`
///     `JPH::SphereShape`
///     `JPH::StaticCompoundShape`
///     `JPH::TaperedCapsuleShape`
///     `JPH::TaperedCylinderShape`
///     `JPH::TempAllocatorImpl`
///     `JPH::TempAllocatorImplWithMallocFallback`
///     `JPH::TempAllocatorMalloc`
///     `JPH::TriangleShape`
///     `JPH::TwoBodyConstraint`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_NonCopyable JPH_NonCopyable;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_NonCopyable_Destroy()` to free it when you're done using it.
JOLT_API JPH_NonCopyable *JPH_NonCopyable_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_NonCopyable_DestroyArray()`.
/// Use `JPH_NonCopyable_OffsetMutablePtr()` and `JPH_NonCopyable_OffsetPtr()` to access the array elements.
JOLT_API JPH_NonCopyable *JPH_NonCopyable_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_NonCopyable_OffsetPtr(const JPH_NonCopyable *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_NonCopyable_OffsetMutablePtr(JPH_NonCopyable *ptr, ptrdiff_t i);

/// Destroys a heap-allocated instance of `JPH_NonCopyable`. Does nothing if the pointer is null.
JOLT_API void JPH_NonCopyable_Destroy(const JPH_NonCopyable *_this);

/// Destroys a heap-allocated array of `JPH_NonCopyable`. Does nothing if the pointer is null.
JOLT_API void JPH_NonCopyable_DestroyArray(const JPH_NonCopyable *_this);

#ifdef __cplusplus
} // extern "C"
#endif
