// machine generated, do not edit
public static partial class JPH
{
    /// This is the base class for all our classes.
    public abstract class Object<T> : JPH.KeepAliveHolder<T>
    {
        protected bool _IsOwningVal;
        /// Returns true if this is an owning instance, and when disposed, will destroy the underlying C++ instance.
        /// If false, we assume that the underlying C++ instance will live long enough.
        public virtual bool _IsOwning => _IsOwningVal;

        internal Object(bool is_owning) {_IsOwningVal = is_owning;}
    }

    /// This is used for optional in/out parameters, since `ref` can't be nullable.
    public class InOut<T> where T: unmanaged
    {
        public T Value;

        public InOut() {}
        public InOut(T NewValue) {Value = NewValue;}
    }

    /// A reference to a C object. This is sometimes used to return optional references, since `ref` can't be nullable. Or to return references from operators, since those can't return `ref`s.
    /// This object itself isn't nullable, we return `Ref<T>?` when nullability is needed.
    public unsafe class Ref<T> where T: unmanaged
    {
        // Should never be null.
        private T *Ptr;
        // Should never be given a null pointer.
        internal Ref(T *new_ptr)
        {
            System.Diagnostics.Trace.Assert(new_ptr is not null);
            Ptr = new_ptr;
        }
        // 
        internal unsafe Ref(ref T new_ref)
        {
            fixed (T *new_ptr = &new_ref)
            {
                // Smuggling fixed pointers like this seems sketchy at first, but we deal with `ref`s created from pointers all the time, and assume they don't break.
                Ptr = new_ptr;
            }
        }

        public ref T Value => ref *Ptr;

        public static implicit operator T(Ref<T> wrapper) {return wrapper.Value;}
    }

    /// Wraps the object in a wrapper that indicates that it should be treated as a temporary object.
    /// This can be used with `_ByValue_...` function parameters, to indicate that the argument should be moved.
    /// See those structs for a longer explanation.
    public static _Moved<T> Move<T>(T new_value) {return new(new_value);}

    /// A wrapper for `T` that indicates that it's a temporary object, or should be treated as such.
    /// If you're calling a function that returns this, you can safely convert this to `T`.
    /// If you're calling a function that takes this as a parameter, use the `Move()` function to create this wrapper.
    public readonly struct _Moved<T>
    {
        public readonly T Value;
        internal _Moved(T new_value) {Value = new_value;}
        public static implicit operator T(_Moved<T> moved) {return moved.Value;}
    }

    internal enum _PassBy : int
    {
        default_construct,
        copy,
        move,
        move_and_destroy,
        default_arg,
        no_object,
    }

    /// This is the base classes that keep other classes alive.
    /// This is generic to keep static fields separate.
    public abstract class KeepAliveHolder<T>
    {
        /// Which objects need to be kept alive while this object exists?
        Dictionary<string, HashSet<object>>? _KeepAliveData;
        static Dictionary<string, HashSet<object>>? _StaticKeepAliveData;

        /// A special holder for the enclosing object when returning a reference to its subobject.
        public object? _KeepAliveEnclosingObject = null;

        /// Keeps `obj` alive as long as this object exists.
        /// If `key` is specified, it's an optional tag for this object.
        public void _KeepAlive(object obj, string key = "")
        {
            if (_KeepAliveData is null)
                _KeepAliveData = new();
            if (!_KeepAliveData.ContainsKey(key))
                _KeepAliveData[key] = new();
            _KeepAliveData[key].Add(obj);
        }
        public static void _StaticKeepAlive(object obj, string key = "")
        {
            if (_StaticKeepAliveData is null)
                _StaticKeepAliveData = new();
            if (!_StaticKeepAliveData.ContainsKey(key))
                _StaticKeepAliveData[key] = new();
            _StaticKeepAliveData[key].Add(obj);
        }

        /// Discards the objects kept alive by this object.
        /// If `key` is not empty, only discards the objects with the same key. Otherwise discards all of them.
        /// This intentionally doesn't discard `_KeepAliveEnclosingObject`.
        public void _DiscardKeepAlive(string key = "")
        {
            if (_KeepAliveData is null)
                return;
            if (key == "")
            {
                _KeepAliveData.Clear(); // I could also make it null, but I don't think it's worth it.
                return;
            }
            HashSet<object>? set;
            if (_KeepAliveData.TryGetValue(key, out set))
                set.Clear(); // Or we could `.Remove(key)`, but keeping a slot in the map looks better to me.
        }
        public static void _StaticDiscardKeepAlive(string key = "")
        {
            if (_StaticKeepAliveData is null)
                return;
            if (key == "")
            {
                _StaticKeepAliveData.Clear(); // I could also make it null, but I don't think it's worth it.
                return;
            }
            HashSet<object>? set;
            if (_StaticKeepAliveData.TryGetValue(key, out set))
                set.Clear(); // Or we could `.Remove(key)`, but keeping a slot in the map looks better to me.
        }
    }

    internal unsafe delegate void StdFunctionPostCallCallbackDelegate(void *userdata, void *value);

    /// This is used by the `std::function<...>` wrappers to clean up the object returned from a call.
    internal static unsafe void StdFunctionPostCallCallback(void *userdata, void *value)
    {
        if (value is not null)
            System.Runtime.InteropServices.GCHandle.FromIntPtr((nint)value).Free();
    }

    internal unsafe delegate void StdFunctionUserdataCallbackDelegate(void **this_userdata, void *other_userdata);

    /// This is used by the `std::function<...>` wrappers to manage the userdata pointer, which in our case always represents a `GCHandle` to the underlying C# callable.
    internal static unsafe void StdFunctionUserdataCallback(void **this_userdata, void *other_userdata)
    {
        if (*this_userdata is not null)
        {
            // We're either getting copy-assigned or destroyed.
            // Either way, we must destroy the existing handle.
            System.Runtime.InteropServices.GCHandle.FromIntPtr((nint)(*this_userdata)).Free();

            if (other_userdata is null)
                return; // We're getting destroyed, nothing else to do.
        }

        // Now we're either getting either copy-constructed or copy-assigned. Duplicate the provided handle.
        *this_userdata = (void *)System.Runtime.InteropServices.GCHandle.ToIntPtr(System.Runtime.InteropServices.GCHandle.Alloc(System.Runtime.InteropServices.GCHandle.FromIntPtr((nint)other_userdata).Target));
    }

    /// An internal function for allocating memory through C++.
    internal static unsafe void *_Alloc(nuint size)
    {
        #if __IOS__
        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_Alloc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_Alloc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static void *__Jolt_Alloc(nuint size);
        return __Jolt_Alloc(size);
    }

    /// An internal function for deallocating memory through C++.
    internal static unsafe void _Free(void *ptr)
    {
        #if __IOS__
        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_Free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_Free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static void __Jolt_Free(void *ptr);
        __Jolt_Free(ptr);
    }


    public struct ArrayFloat2
    {
        public unsafe fixed float _elem[2];
        public unsafe ref float this[nint i] => ref _elem[i];
    }

    public struct ArrayFloat6
    {
        public unsafe fixed float _elem[6];
        public unsafe ref float this[nint i] => ref _elem[i];
    }

    public struct ArrayUnsignedChar4
    {
        public unsafe fixed byte _elem[4];
        public unsafe ref byte this[nint i] => ref _elem[i];
    }

    public struct ArrayUnsignedChar4160
    {
        public unsafe fixed byte _elem[4160];
        public unsafe ref byte this[nint i] => ref _elem[i];
    }

    public struct ArrayUnsignedChar4288
    {
        public unsafe fixed byte _elem[4288];
        public unsafe ref byte this[nint i] => ref _elem[i];
    }

    public struct ArrayUnsignedInt2
    {
        public unsafe fixed uint _elem[2];
        public unsafe ref uint this[nint i] => ref _elem[i];
    }

    public struct ArrayUnsignedInt3
    {
        public unsafe fixed uint _elem[3];
        public unsafe ref uint this[nint i] => ref _elem[i];
    }

    public struct ArrayUnsignedInt4
    {
        public unsafe fixed uint _elem[4];
        public unsafe ref uint this[nint i] => ref _elem[i];
    }

    public unsafe struct ArrayDebugRendererVertex3
    {
        internal JPH.DebugRenderer.Vertex._Underlying *Ptr;

        internal ArrayDebugRendererVertex3(JPH.DebugRenderer.Vertex._Underlying *new_ptr) {Ptr = new_ptr;}

        public JPH.DebugRenderer.Vertex this[nint i]
        {
            get
            {
                System.Diagnostics.Trace.Assert(i >= 0 && i < 3);
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_OffsetPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_OffsetPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Vertex._Underlying *__JPH_DebugRenderer_Vertex_OffsetPtr(JPH.DebugRenderer.Vertex._Underlying *ptr, nint i);
                return new(__JPH_DebugRenderer_Vertex_OffsetPtr(Ptr, i), is_owning: false);
            }
        }
    }

    public unsafe struct ArrayMotorSettings6
    {
        internal JPH.MotorSettings._Underlying *Ptr;

        internal ArrayMotorSettings6(JPH.MotorSettings._Underlying *new_ptr) {Ptr = new_ptr;}

        public JPH.MotorSettings this[nint i]
        {
            get
            {
                System.Diagnostics.Trace.Assert(i >= 0 && i < 6);
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_OffsetPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_OffsetPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.MotorSettings._Underlying *__JPH_MotorSettings_OffsetPtr(JPH.MotorSettings._Underlying *ptr, nint i);
                return new(__JPH_MotorSettings_OffsetPtr(Ptr, i), is_owning: false);
            }
        }
    }

    public unsafe struct ArraySoftBodySharedSettingsSkinWeight4
    {
        internal JPH.SoftBodySharedSettings.SkinWeight._Underlying *Ptr;

        internal ArraySoftBodySharedSettingsSkinWeight4(JPH.SoftBodySharedSettings.SkinWeight._Underlying *new_ptr) {Ptr = new_ptr;}

        public JPH.SoftBodySharedSettings.SkinWeight this[nint i]
        {
            get
            {
                System.Diagnostics.Trace.Assert(i >= 0 && i < 4);
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_OffsetPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_OffsetPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.SkinWeight._Underlying *__JPH_SoftBodySharedSettings_SkinWeight_OffsetPtr(JPH.SoftBodySharedSettings.SkinWeight._Underlying *ptr, nint i);
                return new(__JPH_SoftBodySharedSettings_SkinWeight_OffsetPtr(Ptr, i), is_owning: false);
            }
        }
    }

    public unsafe struct ArraySpringSettings3
    {
        internal JPH.SpringSettings._Underlying *Ptr;

        internal ArraySpringSettings3(JPH.SpringSettings._Underlying *new_ptr) {Ptr = new_ptr;}

        public JPH.SpringSettings this[nint i]
        {
            get
            {
                System.Diagnostics.Trace.Assert(i >= 0 && i < 3);
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_OffsetPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_OffsetPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SpringSettings._Underlying *__JPH_SpringSettings_OffsetPtr(JPH.SpringSettings._Underlying *ptr, nint i);
                return new(__JPH_SpringSettings_OffsetPtr(Ptr, i), is_owning: false);
            }
        }
    }

    public unsafe struct ArrayVector2_2
    {
        internal JPH.Vector_2._Underlying *Ptr;

        internal ArrayVector2_2(JPH.Vector_2._Underlying *new_ptr) {Ptr = new_ptr;}

        public JPH.Vector_2 this[nint i]
        {
            get
            {
                System.Diagnostics.Trace.Assert(i >= 0 && i < 2);
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vector_2_OffsetPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vector_2_OffsetPtr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vector_2._Underlying *__JPH_Vector_2_OffsetPtr(JPH.Vector_2._Underlying *ptr, nint i);
                return new(__JPH_Vector_2_OffsetPtr(Ptr, i), is_owning: false);
            }
        }
    }
}
