// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// Axis aligned box
        /// Generated from class `JPH::AABox`.
        /// This is the const half of the class.
        public class Const_AABox : Jolt.Object<Const_AABox>, System.IDisposable, System.IEquatable<Jolt.JPH.Const_AABox>
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_AABox_Destroy(_Underlying *_this);
                __JPH_AABox_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_AABox() {Dispose(false);}

            internal unsafe Const_AABox(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_AABox() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.AABox._Underlying *__JPH_AABox_DefaultConstruct();
                _UnderlyingPtr = __JPH_AABox_DefaultConstruct();
            }

            /// Generated from constructor `JPH::AABox::AABox`.
            public unsafe Const_AABox(Jolt.JPH.Const_AABox _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.AABox._Underlying *__JPH_AABox_ConstructFromAnother(Jolt.JPH.AABox._Underlying *_other);
                _UnderlyingPtr = __JPH_AABox_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::AABox::AABox`.
            public Const_AABox(AABox _other) : this((Const_AABox)_other) {}

            /// Generated from method `JPH::AABox::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_AABox_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_AABox_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_AABox_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_AABox_unsigned_long(inCount);
            }

            /// Generated from method `JPH::AABox::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_AABox_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_AABox_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_AABox_void_ptr(void *inPointer);
                __Jolt_delete_JPH_AABox_void_ptr(inPointer);
            }

            /// Generated from method `JPH::AABox::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_AABox_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_AABox_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_AABox_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_AABox_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::AABox::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_AABox_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_AABox_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_AABox_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_AABox_unsigned_long(inCount);
            }

            /// Generated from method `JPH::AABox::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_AABox_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_AABox_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_AABox_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_AABox_void_ptr(inPointer);
            }

            /// Generated from method `JPH::AABox::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_AABox_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_AABox_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_AABox_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_AABox_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::AABox::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_AABox_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_AABox_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_AABox_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_AABox_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::AABox::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_AABox_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_AABox_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_AABox_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_AABox_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::AABox::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_AABox_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_AABox_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_AABox_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_AABox_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::AABox::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_AABox_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_AABox_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_AABox_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_AABox_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Get bounding box of size FLT_MAX
            /// Generated from method `JPH::AABox::sBiggest`.
            public static unsafe Jolt.JPH.AABox SBiggest()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_sBiggest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_sBiggest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.AABox._Underlying *__JPH_AABox_sBiggest();
                return new(__JPH_AABox_sBiggest(), is_owning: true);
            }

            /// Comparison operators
            /// Generated from method `JPH::AABox::operator==`.
            public static unsafe bool operator==(Jolt.JPH.Const_AABox _this, Jolt.JPH.Const_AABox inRHS)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __Jolt_equal_JPH_AABox(Jolt.JPH.Const_AABox._Underlying *_this, Jolt.JPH.Const_AABox._Underlying *inRHS);
                return __Jolt_equal_JPH_AABox(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
            }

            public static unsafe bool operator!=(Jolt.JPH.Const_AABox _this, Jolt.JPH.Const_AABox inRHS)
            {
                return !(_this == inRHS);
            }

            /// Check if the bounding box is valid (max >= min)
            /// Generated from method `JPH::AABox::IsValid`.
            public unsafe bool IsValid()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_AABox_IsValid(_Underlying *_this);
                return __JPH_AABox_IsValid(_UnderlyingPtr) != 0;
            }

            /// Intersect this bounding box with inOther, returns the intersection
            /// Generated from method `JPH::AABox::Intersect`.
            public unsafe Jolt.JPH.AABox Intersect(Jolt.JPH.Const_AABox inOther)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Intersect", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Intersect", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.AABox._Underlying *__JPH_AABox_Intersect(_Underlying *_this, Jolt.JPH.Const_AABox._Underlying *inOther);
                return new(__JPH_AABox_Intersect(_UnderlyingPtr, inOther._UnderlyingPtr), is_owning: true);
            }

            /// Get surface area of bounding box
            /// Generated from method `JPH::AABox::GetSurfaceArea`.
            public unsafe float GetSurfaceArea()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_GetSurfaceArea", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_GetSurfaceArea", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_AABox_GetSurfaceArea(_Underlying *_this);
                return __JPH_AABox_GetSurfaceArea(_UnderlyingPtr);
            }

            /// Get volume of bounding box
            /// Generated from method `JPH::AABox::GetVolume`.
            public unsafe float GetVolume()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_AABox_GetVolume(_Underlying *_this);
                return __JPH_AABox_GetVolume(_UnderlyingPtr);
            }

            /// Check if this box contains another box
            /// Generated from method `JPH::AABox::Contains`.
            public unsafe bool Contains(Jolt.JPH.Const_AABox inOther)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Contains_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Contains_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_AABox_Contains_JPH_AABox(_Underlying *_this, Jolt.JPH.Const_AABox._Underlying *inOther);
                return __JPH_AABox_Contains_JPH_AABox(_UnderlyingPtr, inOther._UnderlyingPtr) != 0;
            }

            /// Check if this box overlaps with another box
            /// Generated from method `JPH::AABox::Overlaps`.
            public unsafe bool Overlaps(Jolt.JPH.Const_AABox inOther)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Overlaps_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Overlaps_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_AABox_Overlaps_JPH_AABox(_Underlying *_this, Jolt.JPH.Const_AABox._Underlying *inOther);
                return __JPH_AABox_Overlaps_JPH_AABox(_UnderlyingPtr, inOther._UnderlyingPtr) != 0;
            }

            // IEquatable:

            public bool Equals(Jolt.JPH.Const_AABox? inRHS)
            {
                if (inRHS is null)
                    return false;
                return this == inRHS;
            }

            public override bool Equals(object? other)
            {
                if (other is null)
                    return false;
                if (other is Jolt.JPH.Const_AABox)
                    return this == (Jolt.JPH.Const_AABox)other;
                return false;
            }
        }

        /// Axis aligned box
        /// Generated from class `JPH::AABox`.
        /// This is the non-const half of the class.
        public class AABox : Const_AABox
        {
            internal unsafe AABox(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe AABox() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.AABox._Underlying *__JPH_AABox_DefaultConstruct();
                _UnderlyingPtr = __JPH_AABox_DefaultConstruct();
            }

            /// Generated from constructor `JPH::AABox::AABox`.
            public unsafe AABox(Jolt.JPH.Const_AABox _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.AABox._Underlying *__JPH_AABox_ConstructFromAnother(Jolt.JPH.AABox._Underlying *_other);
                _UnderlyingPtr = __JPH_AABox_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::AABox::AABox`.
            public AABox(AABox _other) : this((Const_AABox)_other) {}

            /// Generated from method `JPH::AABox::operator=`.
            public unsafe Jolt.JPH.AABox Assign(Jolt.JPH.Const_AABox _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.AABox._Underlying *__JPH_AABox_AssignFromAnother(_Underlying *_this, Jolt.JPH.AABox._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_AABox_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }

            /// Reset the bounding box to an empty bounding box
            /// Generated from method `JPH::AABox::SetEmpty`.
            public unsafe void SetEmpty()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_SetEmpty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_SetEmpty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_AABox_SetEmpty(_Underlying *_this);
                __JPH_AABox_SetEmpty(_UnderlyingPtr);
            }

            /// Encapsulate bounding box in bounding box
            /// Generated from method `JPH::AABox::Encapsulate`.
            public unsafe void Encapsulate(Jolt.JPH.Const_AABox inRHS)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Encapsulate_1_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Encapsulate_1_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_AABox_Encapsulate_1_JPH_AABox(_Underlying *_this, Jolt.JPH.Const_AABox._Underlying *inRHS);
                __JPH_AABox_Encapsulate_1_JPH_AABox(_UnderlyingPtr, inRHS._UnderlyingPtr);
            }

            /// Make sure that each edge of the bounding box has a minimal length
            /// Generated from method `JPH::AABox::EnsureMinimalEdgeLength`.
            public unsafe void EnsureMinimalEdgeLength(float inMinEdgeLength)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_EnsureMinimalEdgeLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_EnsureMinimalEdgeLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_AABox_EnsureMinimalEdgeLength(_Underlying *_this, float inMinEdgeLength);
                __JPH_AABox_EnsureMinimalEdgeLength(_UnderlyingPtr, inMinEdgeLength);
            }
        }

        /// This is used for optional parameters of class `AABox` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_AABox`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `AABox`/`Const_AABox` directly.
        public class _InOptMut_AABox
        {
            public AABox? Opt;

            public _InOptMut_AABox() {}
            public _InOptMut_AABox(AABox value) {Opt = value;}
            public static implicit operator _InOptMut_AABox(AABox value) {return new(value);}
        }

        /// This is used for optional parameters of class `AABox` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_AABox`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `AABox`/`Const_AABox` to pass it to the function.
        public class _InOptConst_AABox
        {
            public Const_AABox? Opt;

            public _InOptConst_AABox() {}
            public _InOptConst_AABox(Const_AABox value) {Opt = value;}
            public static implicit operator _InOptConst_AABox(Const_AABox value) {return new(value);}
        }
    }
}
