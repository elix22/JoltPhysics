// machine generated, do not edit
public static partial class JPH
{
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
    ///     `JPH::MotorcycleControllerSettings`
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
    ///     `JPH::TrackedVehicleControllerSettings`
    ///     `JPH::TriangleShapeSettings`
    ///     `JPH::TwoBodyConstraintSettings`
    ///     `JPH::VehicleConstraintSettings`
    ///     `JPH::WheelSettingsTV`
    ///     `JPH::WheelSettingsWV`
    ///     `JPH::WheeledVehicleControllerSettings`
    /// This is the const half of the class.
    public class Const_SerializableObject : JPH.Object<Const_SerializableObject>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SerializableObject_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SerializableObject_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SerializableObject_Destroy(_Underlying *_this);
            __JPH_SerializableObject_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SerializableObject() {Dispose(false);}

        internal unsafe Const_SerializableObject(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `JPH::SerializableObject::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SerializableObject_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SerializableObject_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SerializableObject_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_SerializableObject_size_t(inCount);
        }

        /// Generated from method `JPH::SerializableObject::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SerializableObject_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SerializableObject_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SerializableObject_void_ptr(void *inPointer);
            __Jolt_delete_JPH_SerializableObject_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SerializableObject::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SerializableObject_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SerializableObject_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SerializableObject_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_SerializableObject_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SerializableObject::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SerializableObject_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SerializableObject_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SerializableObject_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_SerializableObject_size_t(inCount);
        }

        /// Generated from method `JPH::SerializableObject::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SerializableObject_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SerializableObject_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SerializableObject_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_SerializableObject_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SerializableObject::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SerializableObject_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SerializableObject_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SerializableObject_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_SerializableObject_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SerializableObject::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SerializableObject_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SerializableObject_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SerializableObject_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_SerializableObject_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SerializableObject::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SerializableObject_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SerializableObject_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SerializableObject_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_SerializableObject_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::SerializableObject::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SerializableObject_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SerializableObject_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SerializableObject_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_SerializableObject_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SerializableObject::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SerializableObject_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SerializableObject_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SerializableObject_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_SerializableObject_void_ptr_void_ptr(inPointer, inPlace);
        }
    }

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
    ///     `JPH::MotorcycleControllerSettings`
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
    ///     `JPH::TrackedVehicleControllerSettings`
    ///     `JPH::TriangleShapeSettings`
    ///     `JPH::TwoBodyConstraintSettings`
    ///     `JPH::VehicleConstraintSettings`
    ///     `JPH::WheelSettingsTV`
    ///     `JPH::WheelSettingsWV`
    ///     `JPH::WheeledVehicleControllerSettings`
    /// This is the non-const half of the class.
    public class SerializableObject : Const_SerializableObject
    {
        internal unsafe SerializableObject(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}
    }

    /// This is used for optional parameters of class `SerializableObject` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SerializableObject`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SerializableObject`/`Const_SerializableObject` directly.
    public class _InOptMut_SerializableObject
    {
        public SerializableObject? Opt;

        public _InOptMut_SerializableObject() {}
        public _InOptMut_SerializableObject(SerializableObject value) {Opt = value;}
        public static implicit operator _InOptMut_SerializableObject(SerializableObject value) {return new(value);}
    }

    /// This is used for optional parameters of class `SerializableObject` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SerializableObject`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SerializableObject`/`Const_SerializableObject` to pass it to the function.
    public class _InOptConst_SerializableObject
    {
        public Const_SerializableObject? Opt;

        public _InOptConst_SerializableObject() {}
        public _InOptConst_SerializableObject(Const_SerializableObject value) {Opt = value;}
        public static implicit operator _InOptConst_SerializableObject(Const_SerializableObject value) {return new(value);}
    }
}
