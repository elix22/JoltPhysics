// machine generated, do not edit
public static partial class JPH
{
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
    ///     `JPH::JobSystemThreadPool`
    ///     `JPH::JobSystemWithBarrier`
    ///     `JPH::MeshShape`
    ///     `JPH::MutableCompoundShape`
    ///     `JPH::ObjectLayerPairFilterTable`
    ///     `JPH::ObjectVsBroadPhaseLayerFilterTable`
    ///     `JPH::OffsetCenterOfMassShape`
    ///     `JPH::PlaneShape`
    ///     `JPH::PointConstraint`
    ///     `JPH::ReversedShapeFilter`
    ///     `JPH::RotatedTranslatedShape`
    ///     `JPH::ScaledShape`
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
    /// This is the const half of the class.
    public class Const_NonCopyable : JPH.Object<Const_NonCopyable>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_NonCopyable_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_NonCopyable_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_NonCopyable_Destroy(_Underlying *_this);
            __JPH_NonCopyable_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_NonCopyable() {Dispose(false);}

        internal unsafe Const_NonCopyable(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_NonCopyable() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_NonCopyable_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_NonCopyable_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_NonCopyable_DefaultConstruct();
            _UnderlyingPtr = __JPH_NonCopyable_DefaultConstruct();
        }
    }

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
    ///     `JPH::JobSystemThreadPool`
    ///     `JPH::JobSystemWithBarrier`
    ///     `JPH::MeshShape`
    ///     `JPH::MutableCompoundShape`
    ///     `JPH::ObjectLayerPairFilterTable`
    ///     `JPH::ObjectVsBroadPhaseLayerFilterTable`
    ///     `JPH::OffsetCenterOfMassShape`
    ///     `JPH::PlaneShape`
    ///     `JPH::PointConstraint`
    ///     `JPH::ReversedShapeFilter`
    ///     `JPH::RotatedTranslatedShape`
    ///     `JPH::ScaledShape`
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
    /// This is the non-const half of the class.
    public class NonCopyable : Const_NonCopyable
    {
        internal unsafe NonCopyable(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe NonCopyable() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_NonCopyable_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_NonCopyable_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_NonCopyable_DefaultConstruct();
            _UnderlyingPtr = __JPH_NonCopyable_DefaultConstruct();
        }
    }

    /// This is used as a function parameter when the underlying function receives `NonCopyable` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_NonCopyable
    {
        #pragma warning disable CS0649
        internal readonly Const_NonCopyable? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_NonCopyable() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `NonCopyable` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_NonCopyable`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `NonCopyable`/`Const_NonCopyable` directly.
    public class _InOptMut_NonCopyable
    {
        public NonCopyable? Opt;

        public _InOptMut_NonCopyable() {}
        public _InOptMut_NonCopyable(NonCopyable value) {Opt = value;}
        public static implicit operator _InOptMut_NonCopyable(NonCopyable value) {return new(value);}
    }

    /// This is used for optional parameters of class `NonCopyable` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_NonCopyable`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `NonCopyable`/`Const_NonCopyable` to pass it to the function.
    public class _InOptConst_NonCopyable
    {
        public Const_NonCopyable? Opt;

        public _InOptConst_NonCopyable() {}
        public _InOptConst_NonCopyable(Const_NonCopyable value) {Opt = value;}
        public static implicit operator _InOptConst_NonCopyable(Const_NonCopyable value) {return new(value);}
    }
}
