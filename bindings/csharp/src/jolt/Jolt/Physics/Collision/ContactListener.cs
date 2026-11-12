// machine generated, do not edit
public static partial class JPH
{
    /// Manifold class, describes the contact surface between two bodies
    /// Generated from class `JPH::ContactManifold`.
    /// This is the const half of the class.
    public class Const_ContactManifold : JPH.Object<Const_ContactManifold>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ContactManifold_Destroy(_Underlying *_this);
            __JPH_ContactManifold_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ContactManifold() {Dispose(false);}

        ///< Offset to which all the contact points are relative
        public unsafe JPH.Const_Vec3 mBaseOffset
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_Get_mBaseOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_Get_mBaseOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_ContactManifold_Get_mBaseOffset(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_ContactManifold_Get_mBaseOffset(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Normal for this manifold, direction along which to move body 2 out of collision along the shortest path
        public unsafe JPH.Const_Vec3 mWorldSpaceNormal
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_Get_mWorldSpaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_Get_mWorldSpaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_ContactManifold_Get_mWorldSpaceNormal(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_ContactManifold_Get_mWorldSpaceNormal(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Penetration depth (move shape 2 by this distance to resolve the collision). If this value is negative, this is a speculative contact point and may not actually result in a velocity change as during solving the bodies may not actually collide.
        public unsafe float mPenetrationDepth
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_Get_mPenetrationDepth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_Get_mPenetrationDepth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ContactManifold_Get_mPenetrationDepth(_Underlying *_this);
                return *__JPH_ContactManifold_Get_mPenetrationDepth(_UnderlyingPtr);
            }
        }

        ///< Sub shapes that formed this manifold (note that when multiple manifolds are combined because they're coplanar, we lose some information here because we only keep track of one sub shape pair that we encounter, see description at Body::SetUseManifoldReduction)
        public unsafe JPH.Const_SubShapeID mSubShapeID1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_Get_mSubShapeID1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_Get_mSubShapeID1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_SubShapeID._Underlying *__JPH_ContactManifold_Get_mSubShapeID1(_Underlying *_this);
                JPH.Const_SubShapeID __ret;
                __ret = new(__JPH_ContactManifold_Get_mSubShapeID1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_SubShapeID mSubShapeID2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_Get_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_Get_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_SubShapeID._Underlying *__JPH_ContactManifold_Get_mSubShapeID2(_Underlying *_this);
                JPH.Const_SubShapeID __ret;
                __ret = new(__JPH_ContactManifold_Get_mSubShapeID2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_ContactManifold(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_ContactManifold() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactManifold._Underlying *__JPH_ContactManifold_DefaultConstruct();
            _UnderlyingPtr = __JPH_ContactManifold_DefaultConstruct();
        }

        /// Generated from constructor `JPH::ContactManifold::ContactManifold`.
        public unsafe Const_ContactManifold(JPH._ByValue_ContactManifold _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactManifold._Underlying *__JPH_ContactManifold_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.ContactManifold._Underlying *_other);
            _UnderlyingPtr = __JPH_ContactManifold_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::ContactManifold::ContactManifold`.
        public Const_ContactManifold(Const_ContactManifold _other) : this(new _ByValue_ContactManifold(_other)) {}

        /// Generated from constructor `JPH::ContactManifold::ContactManifold`.
        public Const_ContactManifold(ContactManifold _other) : this((Const_ContactManifold)_other) {}

        /// Swaps shape 1 and 2
        /// Generated from method `JPH::ContactManifold::SwapShapes`.
        public unsafe JPH.ContactManifold SwapShapes()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_SwapShapes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_SwapShapes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactManifold._Underlying *__JPH_ContactManifold_SwapShapes(_Underlying *_this);
            return new(__JPH_ContactManifold_SwapShapes(_UnderlyingPtr), is_owning: true);
        }

        /// Access to the world space contact positions
        /// Generated from method `JPH::ContactManifold::GetWorldSpaceContactPointOn1`.
        public unsafe JPH.Vec3 GetWorldSpaceContactPointOn1(uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_GetWorldSpaceContactPointOn1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_GetWorldSpaceContactPointOn1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_ContactManifold_GetWorldSpaceContactPointOn1(_Underlying *_this, uint inIndex);
            return new(__JPH_ContactManifold_GetWorldSpaceContactPointOn1(_UnderlyingPtr, inIndex), is_owning: true);
        }

        /// Generated from method `JPH::ContactManifold::GetWorldSpaceContactPointOn2`.
        public unsafe JPH.Vec3 GetWorldSpaceContactPointOn2(uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_GetWorldSpaceContactPointOn2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_GetWorldSpaceContactPointOn2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_ContactManifold_GetWorldSpaceContactPointOn2(_Underlying *_this, uint inIndex);
            return new(__JPH_ContactManifold_GetWorldSpaceContactPointOn2(_UnderlyingPtr, inIndex), is_owning: true);
        }
    }

    /// Manifold class, describes the contact surface between two bodies
    /// Generated from class `JPH::ContactManifold`.
    /// This is the non-const half of the class.
    public class ContactManifold : Const_ContactManifold
    {
        ///< Offset to which all the contact points are relative
        public new unsafe JPH.Vec3 mBaseOffset
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_GetMutable_mBaseOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_GetMutable_mBaseOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_ContactManifold_GetMutable_mBaseOffset(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_ContactManifold_GetMutable_mBaseOffset(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Normal for this manifold, direction along which to move body 2 out of collision along the shortest path
        public new unsafe JPH.Vec3 mWorldSpaceNormal
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_GetMutable_mWorldSpaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_GetMutable_mWorldSpaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_ContactManifold_GetMutable_mWorldSpaceNormal(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_ContactManifold_GetMutable_mWorldSpaceNormal(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Penetration depth (move shape 2 by this distance to resolve the collision). If this value is negative, this is a speculative contact point and may not actually result in a velocity change as during solving the bodies may not actually collide.
        public new unsafe ref float mPenetrationDepth
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_GetMutable_mPenetrationDepth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_GetMutable_mPenetrationDepth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ContactManifold_GetMutable_mPenetrationDepth(_Underlying *_this);
                return ref *__JPH_ContactManifold_GetMutable_mPenetrationDepth(_UnderlyingPtr);
            }
        }

        ///< Sub shapes that formed this manifold (note that when multiple manifolds are combined because they're coplanar, we lose some information here because we only keep track of one sub shape pair that we encounter, see description at Body::SetUseManifoldReduction)
        public new unsafe JPH.SubShapeID mSubShapeID1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_GetMutable_mSubShapeID1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_GetMutable_mSubShapeID1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SubShapeID._Underlying *__JPH_ContactManifold_GetMutable_mSubShapeID1(_Underlying *_this);
                JPH.SubShapeID __ret;
                __ret = new(__JPH_ContactManifold_GetMutable_mSubShapeID1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.SubShapeID mSubShapeID2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_GetMutable_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_GetMutable_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SubShapeID._Underlying *__JPH_ContactManifold_GetMutable_mSubShapeID2(_Underlying *_this);
                JPH.SubShapeID __ret;
                __ret = new(__JPH_ContactManifold_GetMutable_mSubShapeID2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe ContactManifold(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe ContactManifold() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactManifold._Underlying *__JPH_ContactManifold_DefaultConstruct();
            _UnderlyingPtr = __JPH_ContactManifold_DefaultConstruct();
        }

        /// Generated from constructor `JPH::ContactManifold::ContactManifold`.
        public unsafe ContactManifold(JPH._ByValue_ContactManifold _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactManifold._Underlying *__JPH_ContactManifold_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.ContactManifold._Underlying *_other);
            _UnderlyingPtr = __JPH_ContactManifold_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::ContactManifold::ContactManifold`.
        public ContactManifold(Const_ContactManifold _other) : this(new _ByValue_ContactManifold(_other)) {}

        /// Generated from constructor `JPH::ContactManifold::ContactManifold`.
        public ContactManifold(ContactManifold _other) : this((Const_ContactManifold)_other) {}

        /// Generated from method `JPH::ContactManifold::operator=`.
        public unsafe JPH.ContactManifold Assign(JPH._ByValue_ContactManifold _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactManifold_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactManifold_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactManifold._Underlying *__JPH_ContactManifold_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.ContactManifold._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_ContactManifold_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `ContactManifold` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `ContactManifold`/`Const_ContactManifold` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_ContactManifold
    {
        #pragma warning disable CS0649
        internal readonly Const_ContactManifold? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_ContactManifold() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_ContactManifold(Const_ContactManifold new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_ContactManifold(Const_ContactManifold arg) {return new(arg);}
        public _ByValue_ContactManifold(JPH._Moved<ContactManifold> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_ContactManifold(JPH._Moved<ContactManifold> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `ContactManifold` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ContactManifold`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ContactManifold`/`Const_ContactManifold` directly.
    public class _InOptMut_ContactManifold
    {
        public ContactManifold? Opt;

        public _InOptMut_ContactManifold() {}
        public _InOptMut_ContactManifold(ContactManifold value) {Opt = value;}
        public static implicit operator _InOptMut_ContactManifold(ContactManifold value) {return new(value);}
    }

    /// This is used for optional parameters of class `ContactManifold` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ContactManifold`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ContactManifold`/`Const_ContactManifold` to pass it to the function.
    public class _InOptConst_ContactManifold
    {
        public Const_ContactManifold? Opt;

        public _InOptConst_ContactManifold() {}
        public _InOptConst_ContactManifold(Const_ContactManifold value) {Opt = value;}
        public static implicit operator _InOptConst_ContactManifold(Const_ContactManifold value) {return new(value);}
    }

    /// When a contact point is added or persisted, the callback gets a chance to override certain properties of the contact constraint.
    /// The values are filled in with their defaults by the system so the callback doesn't need to modify anything, but it can if it wants to.
    /// Generated from class `JPH::ContactSettings`.
    /// This is the const half of the class.
    public class Const_ContactSettings : JPH.Object<Const_ContactSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ContactSettings_Destroy(_Underlying *_this);
            __JPH_ContactSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ContactSettings() {Dispose(false);}

        ///< Combined friction for the body pair (see: PhysicsSystem::SetCombineFriction)
        public unsafe float mCombinedFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_Get_mCombinedFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_Get_mCombinedFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ContactSettings_Get_mCombinedFriction(_Underlying *_this);
                return *__JPH_ContactSettings_Get_mCombinedFriction(_UnderlyingPtr);
            }
        }

        ///< Combined restitution for the body pair (see: PhysicsSystem::SetCombineRestitution)
        public unsafe float mCombinedRestitution
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_Get_mCombinedRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_Get_mCombinedRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ContactSettings_Get_mCombinedRestitution(_Underlying *_this);
                return *__JPH_ContactSettings_Get_mCombinedRestitution(_UnderlyingPtr);
            }
        }

        ///< Scale factor for the inverse mass of body 1 (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
        public unsafe float mInvMassScale1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_Get_mInvMassScale1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_Get_mInvMassScale1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ContactSettings_Get_mInvMassScale1(_Underlying *_this);
                return *__JPH_ContactSettings_Get_mInvMassScale1(_UnderlyingPtr);
            }
        }

        ///< Scale factor for the inverse inertia of body 1 (usually same as mInvMassScale1)
        public unsafe float mInvInertiaScale1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_Get_mInvInertiaScale1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_Get_mInvInertiaScale1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ContactSettings_Get_mInvInertiaScale1(_Underlying *_this);
                return *__JPH_ContactSettings_Get_mInvInertiaScale1(_UnderlyingPtr);
            }
        }

        ///< Scale factor for the inverse mass of body 2 (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
        public unsafe float mInvMassScale2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_Get_mInvMassScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_Get_mInvMassScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ContactSettings_Get_mInvMassScale2(_Underlying *_this);
                return *__JPH_ContactSettings_Get_mInvMassScale2(_UnderlyingPtr);
            }
        }

        ///< Scale factor for the inverse inertia of body 2 (usually same as mInvMassScale2)
        public unsafe float mInvInertiaScale2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_Get_mInvInertiaScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_Get_mInvInertiaScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ContactSettings_Get_mInvInertiaScale2(_Underlying *_this);
                return *__JPH_ContactSettings_Get_mInvInertiaScale2(_UnderlyingPtr);
            }
        }

        ///< If the contact should be treated as a sensor vs body contact (no collision response)
        public unsafe bool mIsSensor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_Get_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_Get_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_ContactSettings_Get_mIsSensor(_Underlying *_this);
                return *__JPH_ContactSettings_Get_mIsSensor(_UnderlyingPtr);
            }
        }

        ///< Relative linear surface velocity between the bodies (world space surface velocity of body 2 - world space surface velocity of body 1), can be used to create a conveyor belt effect
        public unsafe JPH.Const_Vec3 mRelativeLinearSurfaceVelocity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_Get_mRelativeLinearSurfaceVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_Get_mRelativeLinearSurfaceVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_ContactSettings_Get_mRelativeLinearSurfaceVelocity(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_ContactSettings_Get_mRelativeLinearSurfaceVelocity(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Relative angular surface velocity between the bodies (world space angular surface velocity of body 2 - world space angular surface velocity of body 1). Note that this angular velocity is relative to the center of mass of body 1, so if you want it relative to body 2's center of mass you need to add body 2 angular velocity x (body 1 world space center of mass - body 2 world space center of mass) to mRelativeLinearSurfaceVelocity.
        public unsafe JPH.Const_Vec3 mRelativeAngularSurfaceVelocity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_Get_mRelativeAngularSurfaceVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_Get_mRelativeAngularSurfaceVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_ContactSettings_Get_mRelativeAngularSurfaceVelocity(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_ContactSettings_Get_mRelativeAngularSurfaceVelocity(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_ContactSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_ContactSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactSettings._Underlying *__JPH_ContactSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_ContactSettings_DefaultConstruct();
        }

        /// Constructs `JPH::ContactSettings` elementwise.
        public unsafe Const_ContactSettings(float mCombinedFriction, float mCombinedRestitution, float mInvMassScale1, float mInvInertiaScale1, float mInvMassScale2, float mInvInertiaScale2, bool mIsSensor, JPH.Const_Vec3 mRelativeLinearSurfaceVelocity, JPH.Const_Vec3 mRelativeAngularSurfaceVelocity) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactSettings._Underlying *__JPH_ContactSettings_ConstructFrom(float mCombinedFriction, float mCombinedRestitution, float mInvMassScale1, float mInvInertiaScale1, float mInvMassScale2, float mInvInertiaScale2, byte mIsSensor, JPH.Vec3._Underlying *mRelativeLinearSurfaceVelocity, JPH.Vec3._Underlying *mRelativeAngularSurfaceVelocity);
            _UnderlyingPtr = __JPH_ContactSettings_ConstructFrom(mCombinedFriction, mCombinedRestitution, mInvMassScale1, mInvInertiaScale1, mInvMassScale2, mInvInertiaScale2, mIsSensor ? (byte)1 : (byte)0, mRelativeLinearSurfaceVelocity._UnderlyingPtr, mRelativeAngularSurfaceVelocity._UnderlyingPtr);
            _KeepAlive(mRelativeLinearSurfaceVelocity);
            _KeepAlive(mRelativeAngularSurfaceVelocity);
        }

        /// Generated from constructor `JPH::ContactSettings::ContactSettings`.
        public unsafe Const_ContactSettings(JPH.Const_ContactSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactSettings._Underlying *__JPH_ContactSettings_ConstructFromAnother(JPH.ContactSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_ContactSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::ContactSettings::ContactSettings`.
        public Const_ContactSettings(ContactSettings _other) : this((Const_ContactSettings)_other) {}
    }

    /// When a contact point is added or persisted, the callback gets a chance to override certain properties of the contact constraint.
    /// The values are filled in with their defaults by the system so the callback doesn't need to modify anything, but it can if it wants to.
    /// Generated from class `JPH::ContactSettings`.
    /// This is the non-const half of the class.
    public class ContactSettings : Const_ContactSettings
    {
        ///< Combined friction for the body pair (see: PhysicsSystem::SetCombineFriction)
        public new unsafe ref float mCombinedFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mCombinedFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mCombinedFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ContactSettings_GetMutable_mCombinedFriction(_Underlying *_this);
                return ref *__JPH_ContactSettings_GetMutable_mCombinedFriction(_UnderlyingPtr);
            }
        }

        ///< Combined restitution for the body pair (see: PhysicsSystem::SetCombineRestitution)
        public new unsafe ref float mCombinedRestitution
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mCombinedRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mCombinedRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ContactSettings_GetMutable_mCombinedRestitution(_Underlying *_this);
                return ref *__JPH_ContactSettings_GetMutable_mCombinedRestitution(_UnderlyingPtr);
            }
        }

        ///< Scale factor for the inverse mass of body 1 (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
        public new unsafe ref float mInvMassScale1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mInvMassScale1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mInvMassScale1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ContactSettings_GetMutable_mInvMassScale1(_Underlying *_this);
                return ref *__JPH_ContactSettings_GetMutable_mInvMassScale1(_UnderlyingPtr);
            }
        }

        ///< Scale factor for the inverse inertia of body 1 (usually same as mInvMassScale1)
        public new unsafe ref float mInvInertiaScale1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mInvInertiaScale1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mInvInertiaScale1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ContactSettings_GetMutable_mInvInertiaScale1(_Underlying *_this);
                return ref *__JPH_ContactSettings_GetMutable_mInvInertiaScale1(_UnderlyingPtr);
            }
        }

        ///< Scale factor for the inverse mass of body 2 (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
        public new unsafe ref float mInvMassScale2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mInvMassScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mInvMassScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ContactSettings_GetMutable_mInvMassScale2(_Underlying *_this);
                return ref *__JPH_ContactSettings_GetMutable_mInvMassScale2(_UnderlyingPtr);
            }
        }

        ///< Scale factor for the inverse inertia of body 2 (usually same as mInvMassScale2)
        public new unsafe ref float mInvInertiaScale2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mInvInertiaScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mInvInertiaScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ContactSettings_GetMutable_mInvInertiaScale2(_Underlying *_this);
                return ref *__JPH_ContactSettings_GetMutable_mInvInertiaScale2(_UnderlyingPtr);
            }
        }

        ///< If the contact should be treated as a sensor vs body contact (no collision response)
        public new unsafe ref bool mIsSensor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_ContactSettings_GetMutable_mIsSensor(_Underlying *_this);
                return ref *__JPH_ContactSettings_GetMutable_mIsSensor(_UnderlyingPtr);
            }
        }

        ///< Relative linear surface velocity between the bodies (world space surface velocity of body 2 - world space surface velocity of body 1), can be used to create a conveyor belt effect
        public new unsafe JPH.Vec3 mRelativeLinearSurfaceVelocity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mRelativeLinearSurfaceVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mRelativeLinearSurfaceVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_ContactSettings_GetMutable_mRelativeLinearSurfaceVelocity(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_ContactSettings_GetMutable_mRelativeLinearSurfaceVelocity(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Relative angular surface velocity between the bodies (world space angular surface velocity of body 2 - world space angular surface velocity of body 1). Note that this angular velocity is relative to the center of mass of body 1, so if you want it relative to body 2's center of mass you need to add body 2 angular velocity x (body 1 world space center of mass - body 2 world space center of mass) to mRelativeLinearSurfaceVelocity.
        public new unsafe JPH.Vec3 mRelativeAngularSurfaceVelocity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mRelativeAngularSurfaceVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_GetMutable_mRelativeAngularSurfaceVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_ContactSettings_GetMutable_mRelativeAngularSurfaceVelocity(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_ContactSettings_GetMutable_mRelativeAngularSurfaceVelocity(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe ContactSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe ContactSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactSettings._Underlying *__JPH_ContactSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_ContactSettings_DefaultConstruct();
        }

        /// Constructs `JPH::ContactSettings` elementwise.
        public unsafe ContactSettings(float mCombinedFriction, float mCombinedRestitution, float mInvMassScale1, float mInvInertiaScale1, float mInvMassScale2, float mInvInertiaScale2, bool mIsSensor, JPH.Const_Vec3 mRelativeLinearSurfaceVelocity, JPH.Const_Vec3 mRelativeAngularSurfaceVelocity) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactSettings._Underlying *__JPH_ContactSettings_ConstructFrom(float mCombinedFriction, float mCombinedRestitution, float mInvMassScale1, float mInvInertiaScale1, float mInvMassScale2, float mInvInertiaScale2, byte mIsSensor, JPH.Vec3._Underlying *mRelativeLinearSurfaceVelocity, JPH.Vec3._Underlying *mRelativeAngularSurfaceVelocity);
            _UnderlyingPtr = __JPH_ContactSettings_ConstructFrom(mCombinedFriction, mCombinedRestitution, mInvMassScale1, mInvInertiaScale1, mInvMassScale2, mInvInertiaScale2, mIsSensor ? (byte)1 : (byte)0, mRelativeLinearSurfaceVelocity._UnderlyingPtr, mRelativeAngularSurfaceVelocity._UnderlyingPtr);
            _KeepAlive(mRelativeLinearSurfaceVelocity);
            _KeepAlive(mRelativeAngularSurfaceVelocity);
        }

        /// Generated from constructor `JPH::ContactSettings::ContactSettings`.
        public unsafe ContactSettings(JPH.Const_ContactSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactSettings._Underlying *__JPH_ContactSettings_ConstructFromAnother(JPH.ContactSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_ContactSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::ContactSettings::ContactSettings`.
        public ContactSettings(ContactSettings _other) : this((Const_ContactSettings)_other) {}

        /// Generated from method `JPH::ContactSettings::operator=`.
        public unsafe JPH.ContactSettings Assign(JPH.Const_ContactSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactSettings._Underlying *__JPH_ContactSettings_AssignFromAnother(_Underlying *_this, JPH.ContactSettings._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_ContactSettings_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `ContactSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ContactSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ContactSettings`/`Const_ContactSettings` directly.
    public class _InOptMut_ContactSettings
    {
        public ContactSettings? Opt;

        public _InOptMut_ContactSettings() {}
        public _InOptMut_ContactSettings(ContactSettings value) {Opt = value;}
        public static implicit operator _InOptMut_ContactSettings(ContactSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `ContactSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ContactSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ContactSettings`/`Const_ContactSettings` to pass it to the function.
    public class _InOptConst_ContactSettings
    {
        public Const_ContactSettings? Opt;

        public _InOptConst_ContactSettings() {}
        public _InOptConst_ContactSettings(Const_ContactSettings value) {Opt = value;}
        public static implicit operator _InOptConst_ContactSettings(Const_ContactSettings value) {return new(value);}
    }

    /// Return value for the OnContactValidate callback. Determines if the contact is being processed or not.
    /// Results are ordered so that the strongest accept has the lowest number and the strongest reject the highest number (which allows for easy combining of results)
    public enum ValidateResult : int
    {
        ///< Accept this and any further contact points for this body pair
        AcceptAllContactsForThisBodyPair = 0,
        ///< Accept this contact only (and continue calling this callback for every contact manifold for the same body pair)
        AcceptContact = 1,
        ///< Reject this contact only (but process any other contact manifolds for the same body pair)
        RejectContact = 2,
        ///< Rejects this and any further contact points for this body pair
        RejectAllContactsForThisBodyPair = 3,
    }

    /// A listener class that receives collision contact events. It can be registered through PhysicsSystem::SetContactListener.
    /// Only a single contact listener can be registered. A common pattern is to create a contact listener that casts Body::GetUserData
    /// to a game object and then forwards the call to a handler specific for that game object.
    /// Typically this is done on both objects involved in a collision event.
    ///
    /// Note that contact listener callbacks are called from multiple threads at the same time when all bodies are locked, this means you cannot
    /// use PhysicsSystem::GetBodyInterface / PhysicsSystem::GetBodyLockInterface but must use PhysicsSystem::GetBodyInterfaceNoLock / PhysicsSystem::GetBodyLockInterfaceNoLock instead.
    /// If you use a locking interface, the simulation will deadlock. You're only allowed to read from the bodies and you can't change physics state.
    /// During OnContactRemoved you cannot access the bodies at all, see the comments at that function.
    ///
    /// While a callback can come from multiple threads, all callbacks relating to a single body pair are serialized.
    /// For EMotionQuality::Discrete bodies, during every 'collision step' in a PhysicsSystem::Update, you will receive at most one OnContactAdded/Persisted/Removed call per body/sub shape pair.
    /// For EMotionQuality::LinearCast bodies, you may get an OnContactAdded followed by an OnContactPersisted for the same body/sub shape pair.
    /// This happens when a body collides both in the discrete and the continuous collision detection stage.
    /// Generated from class `JPH::ContactListener`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `ContactListenerTrampoline`
    ///     `EstimateResponseContactListener`
    ///     `SimpleContactEventListener`
    /// This is the const half of the class.
    public class Const_ContactListener : JPH.Object<Const_ContactListener>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ContactListener_Destroy(_Underlying *_this);
            __JPH_ContactListener_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ContactListener() {Dispose(false);}

        internal unsafe Const_ContactListener(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_ContactListener() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactListener._Underlying *__JPH_ContactListener_DefaultConstruct();
            _UnderlyingPtr = __JPH_ContactListener_DefaultConstruct();
        }

        /// Generated from constructor `JPH::ContactListener::ContactListener`.
        public unsafe Const_ContactListener(JPH._ByValue_ContactListener _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactListener._Underlying *__JPH_ContactListener_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.ContactListener._Underlying *_other);
            _UnderlyingPtr = __JPH_ContactListener_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::ContactListener::ContactListener`.
        public Const_ContactListener(Const_ContactListener _other) : this(new _ByValue_ContactListener(_other)) {}

        /// Generated from constructor `JPH::ContactListener::ContactListener`.
        public Const_ContactListener(ContactListener _other) : this((Const_ContactListener)_other) {}
    }

    /// A listener class that receives collision contact events. It can be registered through PhysicsSystem::SetContactListener.
    /// Only a single contact listener can be registered. A common pattern is to create a contact listener that casts Body::GetUserData
    /// to a game object and then forwards the call to a handler specific for that game object.
    /// Typically this is done on both objects involved in a collision event.
    ///
    /// Note that contact listener callbacks are called from multiple threads at the same time when all bodies are locked, this means you cannot
    /// use PhysicsSystem::GetBodyInterface / PhysicsSystem::GetBodyLockInterface but must use PhysicsSystem::GetBodyInterfaceNoLock / PhysicsSystem::GetBodyLockInterfaceNoLock instead.
    /// If you use a locking interface, the simulation will deadlock. You're only allowed to read from the bodies and you can't change physics state.
    /// During OnContactRemoved you cannot access the bodies at all, see the comments at that function.
    ///
    /// While a callback can come from multiple threads, all callbacks relating to a single body pair are serialized.
    /// For EMotionQuality::Discrete bodies, during every 'collision step' in a PhysicsSystem::Update, you will receive at most one OnContactAdded/Persisted/Removed call per body/sub shape pair.
    /// For EMotionQuality::LinearCast bodies, you may get an OnContactAdded followed by an OnContactPersisted for the same body/sub shape pair.
    /// This happens when a body collides both in the discrete and the continuous collision detection stage.
    /// Generated from class `JPH::ContactListener`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `ContactListenerTrampoline`
    ///     `EstimateResponseContactListener`
    ///     `SimpleContactEventListener`
    /// This is the non-const half of the class.
    public class ContactListener : Const_ContactListener
    {
        internal unsafe ContactListener(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe ContactListener() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactListener._Underlying *__JPH_ContactListener_DefaultConstruct();
            _UnderlyingPtr = __JPH_ContactListener_DefaultConstruct();
        }

        /// Generated from constructor `JPH::ContactListener::ContactListener`.
        public unsafe ContactListener(JPH._ByValue_ContactListener _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactListener._Underlying *__JPH_ContactListener_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.ContactListener._Underlying *_other);
            _UnderlyingPtr = __JPH_ContactListener_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::ContactListener::ContactListener`.
        public ContactListener(Const_ContactListener _other) : this(new _ByValue_ContactListener(_other)) {}

        /// Generated from constructor `JPH::ContactListener::ContactListener`.
        public ContactListener(ContactListener _other) : this((Const_ContactListener)_other) {}

        /// Generated from method `JPH::ContactListener::operator=`.
        public unsafe JPH.ContactListener Assign(JPH._ByValue_ContactListener _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactListener_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactListener_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ContactListener._Underlying *__JPH_ContactListener_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.ContactListener._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_ContactListener_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Called after detecting a collision between a body pair, but before calling OnContactAdded and before adding the contact constraint.
        /// If the function rejects the contact, the contact will not be processed by the simulation.
        /// This is a rather expensive time to reject a contact point since a lot of the collision detection has happened already, make sure you
        /// filter out the majority of undesired body pairs through the ObjectLayerPairFilter that is registered on the PhysicsSystem.
        ///
        /// This function may not be called again the next update if a contact persists and no new contact pairs between sub shapes are found.
        ///
        /// Note that this callback is called when all bodies are locked, so don't use any locking functions! See detailed class description of ContactListener.
        ///
        /// Body 1 will have a motion type that is larger or equal than body 2's motion type (order from large to small: dynamic -> kinematic -> static). When motion types are equal, they are ordered by BodyID.
        ///
        /// The collision result (inCollisionResult) is reported relative to inBaseOffset.
        /// Generated from method `JPH::ContactListener::OnContactValidate`.
        public unsafe JPH.ValidateResult OnContactValidate(JPH.Const_Body inBody1, JPH.Const_Body inBody2, JPH.Const_Vec3 inBaseOffset, JPH.Const_CollideShapeResult inCollisionResult)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactListener_OnContactValidate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactListener_OnContactValidate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ValidateResult __JPH_ContactListener_OnContactValidate(_Underlying *_this, JPH.Const_Body._Underlying *inBody1, JPH.Const_Body._Underlying *inBody2, JPH.Vec3._Underlying *inBaseOffset, JPH.Const_CollideShapeResult._Underlying *inCollisionResult);
            return __JPH_ContactListener_OnContactValidate(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inBaseOffset._UnderlyingPtr, inCollisionResult._UnderlyingPtr);
        }

        /// Called whenever a new contact point is detected.
        ///
        /// Note that this callback is called when all bodies are locked, so don't use any locking functions! See detailed class description of ContactListener.
        ///
        /// Body 1 and 2 will be sorted such that body 1 ID < body 2 ID, so body 1 may not be dynamic.
        ///
        /// Note that only active bodies will report contacts, as soon as a body goes to sleep the contacts between that body and all other
        /// bodies will receive an OnContactRemoved callback, if this is the case then Body::IsActive() will return false during the callback.
        ///
        /// When contacts are added, the constraint solver has not run yet, so the collision impulse is unknown at that point.
        /// The velocities of inBody1 and inBody2 are the velocities before the contact has been resolved, so you can use this to
        /// estimate the collision impulse to e.g. determine the volume of the impact sound to play (see: EstimateCollisionResponse).
        /// Generated from method `JPH::ContactListener::OnContactAdded`.
        public unsafe void OnContactAdded(JPH.Const_Body inBody1, JPH.Const_Body inBody2, JPH.Const_ContactManifold inManifold, JPH.ContactSettings ioSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactListener_OnContactAdded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactListener_OnContactAdded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ContactListener_OnContactAdded(_Underlying *_this, JPH.Const_Body._Underlying *inBody1, JPH.Const_Body._Underlying *inBody2, JPH.Const_ContactManifold._Underlying *inManifold, JPH.ContactSettings._Underlying *ioSettings);
            __JPH_ContactListener_OnContactAdded(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inManifold._UnderlyingPtr, ioSettings._UnderlyingPtr);
        }

        /// Called whenever a contact is detected that was also detected last update.
        ///
        /// Note that this callback is called when all bodies are locked, so don't use any locking functions! See detailed class description of ContactListener.
        ///
        /// Body 1 and 2 will be sorted such that body 1 ID < body 2 ID, so body 1 may not be dynamic.
        ///
        /// If the structure of the shape of a body changes between simulation steps (e.g. by adding/removing a child shape of a compound shape),
        /// it is possible that the same sub shape ID used to identify the removed child shape is now reused for a different child shape. The physics
        /// system cannot detect this, so may send a 'contact persisted' callback even though the contact is now on a different child shape. You can
        /// detect this by keeping the old shape (before adding/removing a part) around until the next PhysicsSystem::Update (when the OnContactPersisted
        /// callbacks are triggered) and resolving the sub shape ID against both the old and new shape to see if they still refer to the same child shape.
        /// Generated from method `JPH::ContactListener::OnContactPersisted`.
        public unsafe void OnContactPersisted(JPH.Const_Body inBody1, JPH.Const_Body inBody2, JPH.Const_ContactManifold inManifold, JPH.ContactSettings ioSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactListener_OnContactPersisted", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactListener_OnContactPersisted", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ContactListener_OnContactPersisted(_Underlying *_this, JPH.Const_Body._Underlying *inBody1, JPH.Const_Body._Underlying *inBody2, JPH.Const_ContactManifold._Underlying *inManifold, JPH.ContactSettings._Underlying *ioSettings);
            __JPH_ContactListener_OnContactPersisted(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inManifold._UnderlyingPtr, ioSettings._UnderlyingPtr);
        }

        /// Called whenever a contact was detected last update but is not detected anymore.
        ///
        /// You cannot access the bodies at the time of this callback because:
        /// - All bodies are locked at the time of this callback.
        /// - Some properties of the bodies are being modified from another thread at the same time.
        /// - The body may have been removed and destroyed (you'll receive an OnContactRemoved callback in the PhysicsSystem::Update after the body has been removed).
        ///
        /// Cache what you need in the OnContactAdded and OnContactPersisted callbacks and store it in a separate structure to use during this callback.
        /// Alternatively, you could just record that the contact was removed and process it after PhysicsSystem::Update.
        ///
        /// Body 1 and 2 will be sorted such that body 1 ID < body 2 ID, so body 1 may not be dynamic.
        ///
        /// The sub shape IDs were created in the previous simulation step, so if the structure of a shape changes (e.g. by adding/removing a child shape of a compound shape),
        /// the sub shape ID may not be valid / may not point to the same sub shape anymore.
        /// If you want to know if this is the last contact between the two bodies, use PhysicsSystem::WereBodiesInContact.
        /// Generated from method `JPH::ContactListener::OnContactRemoved`.
        public unsafe void OnContactRemoved(JPH.Const_SubShapeIDPair inSubShapePair)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ContactListener_OnContactRemoved", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ContactListener_OnContactRemoved", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ContactListener_OnContactRemoved(_Underlying *_this, JPH.Const_SubShapeIDPair._Underlying *inSubShapePair);
            __JPH_ContactListener_OnContactRemoved(_UnderlyingPtr, inSubShapePair._UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `ContactListener` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `ContactListener`/`Const_ContactListener` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_ContactListener
    {
        #pragma warning disable CS0649
        internal readonly Const_ContactListener? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_ContactListener() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_ContactListener(Const_ContactListener new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_ContactListener(Const_ContactListener arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `ContactListener` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ContactListener`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ContactListener`/`Const_ContactListener` directly.
    public class _InOptMut_ContactListener
    {
        public ContactListener? Opt;

        public _InOptMut_ContactListener() {}
        public _InOptMut_ContactListener(ContactListener value) {Opt = value;}
        public static implicit operator _InOptMut_ContactListener(ContactListener value) {return new(value);}
    }

    /// This is used for optional parameters of class `ContactListener` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ContactListener`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ContactListener`/`Const_ContactListener` to pass it to the function.
    public class _InOptConst_ContactListener
    {
        public Const_ContactListener? Opt;

        public _InOptConst_ContactListener() {}
        public _InOptConst_ContactListener(Const_ContactListener value) {Opt = value;}
        public static implicit operator _InOptConst_ContactListener(Const_ContactListener value) {return new(value);}
    }
}
