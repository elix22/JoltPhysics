// machine generated, do not edit
public static partial class JPH
{
    /// Class that holds an RGBA color with 8-bits per component
    /// Generated from class `JPH::Color`.
    /// This is the const half of the class.
    public class Const_Color : JPH.Object<Const_Color>, System.IDisposable, System.IEquatable<JPH.Const_Color>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Color_Destroy(_Underlying *_this);
            __JPH_Color_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Color() {Dispose(false);}

        /// Predefined colors
        public static unsafe JPH.Const_Color SBlack
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Get_sBlack", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Get_sBlack", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__JPH_Color_Get_sBlack();
                return new(__JPH_Color_Get_sBlack(), is_owning: false);
            }
        }

        public static unsafe JPH.Const_Color SDarkRed
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Get_sDarkRed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Get_sDarkRed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__JPH_Color_Get_sDarkRed();
                return new(__JPH_Color_Get_sDarkRed(), is_owning: false);
            }
        }

        public static unsafe JPH.Const_Color SRed
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Get_sRed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Get_sRed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__JPH_Color_Get_sRed();
                return new(__JPH_Color_Get_sRed(), is_owning: false);
            }
        }

        public static unsafe JPH.Const_Color SDarkGreen
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Get_sDarkGreen", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Get_sDarkGreen", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__JPH_Color_Get_sDarkGreen();
                return new(__JPH_Color_Get_sDarkGreen(), is_owning: false);
            }
        }

        public static unsafe JPH.Const_Color SGreen
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Get_sGreen", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Get_sGreen", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__JPH_Color_Get_sGreen();
                return new(__JPH_Color_Get_sGreen(), is_owning: false);
            }
        }

        public static unsafe JPH.Const_Color SDarkBlue
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Get_sDarkBlue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Get_sDarkBlue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__JPH_Color_Get_sDarkBlue();
                return new(__JPH_Color_Get_sDarkBlue(), is_owning: false);
            }
        }

        public static unsafe JPH.Const_Color SBlue
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Get_sBlue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Get_sBlue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__JPH_Color_Get_sBlue();
                return new(__JPH_Color_Get_sBlue(), is_owning: false);
            }
        }

        public static unsafe JPH.Const_Color SYellow
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Get_sYellow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Get_sYellow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__JPH_Color_Get_sYellow();
                return new(__JPH_Color_Get_sYellow(), is_owning: false);
            }
        }

        public static unsafe JPH.Const_Color SPurple
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Get_sPurple", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Get_sPurple", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__JPH_Color_Get_sPurple();
                return new(__JPH_Color_Get_sPurple(), is_owning: false);
            }
        }

        public static unsafe JPH.Const_Color SCyan
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Get_sCyan", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Get_sCyan", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__JPH_Color_Get_sCyan();
                return new(__JPH_Color_Get_sCyan(), is_owning: false);
            }
        }

        public static unsafe JPH.Const_Color SOrange
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Get_sOrange", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Get_sOrange", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__JPH_Color_Get_sOrange();
                return new(__JPH_Color_Get_sOrange(), is_owning: false);
            }
        }

        public static unsafe JPH.Const_Color SDarkOrange
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Get_sDarkOrange", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Get_sDarkOrange", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__JPH_Color_Get_sDarkOrange();
                return new(__JPH_Color_Get_sDarkOrange(), is_owning: false);
            }
        }

        public static unsafe JPH.Const_Color SGrey
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Get_sGrey", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Get_sGrey", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__JPH_Color_Get_sGrey();
                return new(__JPH_Color_Get_sGrey(), is_owning: false);
            }
        }

        public static unsafe JPH.Const_Color SLightGrey
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Get_sLightGrey", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Get_sLightGrey", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__JPH_Color_Get_sLightGrey();
                return new(__JPH_Color_Get_sLightGrey(), is_owning: false);
            }
        }

        public static unsafe JPH.Const_Color SWhite
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Get_sWhite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Get_sWhite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Color._Underlying *__JPH_Color_Get_sWhite();
                return new(__JPH_Color_Get_sWhite(), is_owning: false);
            }
        }

        internal unsafe Const_Color(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Color() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__JPH_Color_DefaultConstruct();
            _UnderlyingPtr = __JPH_Color_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Color::Color`.
        public unsafe Const_Color(JPH.Const_Color inRHS) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__JPH_Color_ConstructFromAnother(JPH.Color._Underlying *inRHS);
            _UnderlyingPtr = __JPH_Color_ConstructFromAnother(inRHS._UnderlyingPtr);
            _KeepAlive(inRHS);
        }

        /// Generated from constructor `JPH::Color::Color`.
        public Const_Color(Color inRHS) : this((Const_Color)inRHS) {}

        /// Generated from constructor `JPH::Color::Color`.
        public unsafe Const_Color(uint inColor) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__JPH_Color_Construct_1(uint inColor);
            _UnderlyingPtr = __JPH_Color_Construct_1(inColor);
        }

        /// Generated from constructor `JPH::Color::Color`.
        /// Parameter `inAlpha` defaults to `255`.
        public unsafe Const_Color(byte inRed, byte inGreen, byte inBlue, byte? inAlpha = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__JPH_Color_Construct_4(byte inRed, byte inGreen, byte inBlue, byte *inAlpha);
            byte __deref_inAlpha = inAlpha.GetValueOrDefault();
            _UnderlyingPtr = __JPH_Color_Construct_4(inRed, inGreen, inBlue, inAlpha.HasValue ? &__deref_inAlpha : null);
        }

        /// Generated from constructor `JPH::Color::Color`.
        public unsafe Const_Color(JPH.Const_Color inRHS, byte inAlpha) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__JPH_Color_Construct_2(JPH.Color._Underlying *inRHS, byte inAlpha);
            _UnderlyingPtr = __JPH_Color_Construct_2(inRHS._UnderlyingPtr, inAlpha);
        }

        /// Comparison
        /// Generated from method `JPH::Color::operator==`.
        public static unsafe bool operator==(JPH.Const_Color _this, JPH.Const_Color inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_Color", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_Color", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_equal_JPH_Color(JPH.Const_Color._Underlying *_this, JPH.Color._Underlying *inRHS);
            return __Jolt_equal_JPH_Color(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(JPH.Const_Color _this, JPH.Const_Color inRHS)
        {
            return !(_this == inRHS);
        }

        /// Convert to uint32
        /// Generated from method `JPH::Color::GetUInt32`.
        public unsafe uint GetUInt32()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_GetUInt32", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_GetUInt32", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_Color_GetUInt32(_Underlying *_this);
            return __JPH_Color_GetUInt32(_UnderlyingPtr);
        }

        /// Element access, 0 = red, 1 = green, 2 = blue, 3 = alpha
        /// Generated from method `JPH::Color::operator()`.
        public unsafe byte Call(uint inIdx)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Color_call(_Underlying *_this, uint inIdx);
            return __JPH_Color_call(_UnderlyingPtr, inIdx);
        }

        /// Multiply two colors
        /// Generated from method `JPH::Color::operator*`.
        public static unsafe JPH.Color operator*(JPH.Const_Color _this, JPH.Const_Color inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Color", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Color", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__Jolt_mul_JPH_Color(JPH.Const_Color._Underlying *_this, JPH.Const_Color._Underlying *inRHS);
            return new(__Jolt_mul_JPH_Color(_this._UnderlyingPtr, inRHS._UnderlyingPtr), is_owning: true);
        }

        /// Multiply color with intensity in the range [0, 1]
        /// Generated from method `JPH::Color::operator*`.
        public static unsafe JPH.Color operator*(JPH.Const_Color _this, float inIntensity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Color_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Color_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__Jolt_mul_JPH_Color_float(JPH.Const_Color._Underlying *_this, float inIntensity);
            return new(__Jolt_mul_JPH_Color_float(_this._UnderlyingPtr, inIntensity), is_owning: true);
        }

        /// Convert to Vec4 with range [0, 1]
        /// Generated from method `JPH::Color::ToVec4`.
        public unsafe JPH.Vec4 ToVec4()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_ToVec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_ToVec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec4._Underlying *__JPH_Color_ToVec4(_Underlying *_this);
            return new(__JPH_Color_ToVec4(_UnderlyingPtr), is_owning: true);
        }

        /// Get grayscale intensity of color
        /// Generated from method `JPH::Color::GetIntensity`.
        public unsafe byte GetIntensity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_GetIntensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_GetIntensity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Color_GetIntensity(_Underlying *_this);
            return __JPH_Color_GetIntensity(_UnderlyingPtr);
        }

        /// Get a visually distinct color
        /// Generated from method `JPH::Color::sGetDistinctColor`.
        public static unsafe JPH.Color SGetDistinctColor(int inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_sGetDistinctColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_sGetDistinctColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__JPH_Color_sGetDistinctColor(int inIndex);
            return new(__JPH_Color_sGetDistinctColor(inIndex), is_owning: true);
        }

        /// Get a color value on the gradient from green through yellow to red
        /// @param inValue Value in the range [0, 1], 0 = green, 0.5 = yellow, 1 = red
        /// Generated from method `JPH::Color::sGreenRedGradient`.
        public static unsafe JPH.Color SGreenRedGradient(float inValue)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_sGreenRedGradient", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_sGreenRedGradient", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__JPH_Color_sGreenRedGradient(float inValue);
            return new(__JPH_Color_sGreenRedGradient(inValue), is_owning: true);
        }

        // IEquatable:

        public bool Equals(JPH.Const_Color? inRHS)
        {
            if (inRHS is null)
                return false;
            return this == inRHS;
        }

        public override bool Equals(object? other)
        {
            if (other is null)
                return false;
            if (other is JPH.Const_Color)
                return this == (JPH.Const_Color)other;
            return false;
        }
    }

    /// Class that holds an RGBA color with 8-bits per component
    /// Generated from class `JPH::Color`.
    /// This is the non-const half of the class.
    public class Color : Const_Color
    {
        internal unsafe Color(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Color() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__JPH_Color_DefaultConstruct();
            _UnderlyingPtr = __JPH_Color_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Color::Color`.
        public unsafe Color(JPH.Const_Color inRHS) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__JPH_Color_ConstructFromAnother(JPH.Color._Underlying *inRHS);
            _UnderlyingPtr = __JPH_Color_ConstructFromAnother(inRHS._UnderlyingPtr);
            _KeepAlive(inRHS);
        }

        /// Generated from constructor `JPH::Color::Color`.
        public Color(Color inRHS) : this((Const_Color)inRHS) {}

        /// Generated from constructor `JPH::Color::Color`.
        public unsafe Color(uint inColor) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__JPH_Color_Construct_1(uint inColor);
            _UnderlyingPtr = __JPH_Color_Construct_1(inColor);
        }

        /// Generated from constructor `JPH::Color::Color`.
        /// Parameter `inAlpha` defaults to `255`.
        public unsafe Color(byte inRed, byte inGreen, byte inBlue, byte? inAlpha = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__JPH_Color_Construct_4(byte inRed, byte inGreen, byte inBlue, byte *inAlpha);
            byte __deref_inAlpha = inAlpha.GetValueOrDefault();
            _UnderlyingPtr = __JPH_Color_Construct_4(inRed, inGreen, inBlue, inAlpha.HasValue ? &__deref_inAlpha : null);
        }

        /// Generated from constructor `JPH::Color::Color`.
        public unsafe Color(JPH.Const_Color inRHS, byte inAlpha) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__JPH_Color_Construct_2(JPH.Color._Underlying *inRHS, byte inAlpha);
            _UnderlyingPtr = __JPH_Color_Construct_2(inRHS._UnderlyingPtr, inAlpha);
        }

        /// Generated from method `JPH::Color::operator=`.
        public unsafe JPH.Color Assign(JPH.Const_Color inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Color._Underlying *__JPH_Color_AssignFromAnother(_Underlying *_this, JPH.Color._Underlying *inRHS);
            JPH.Color __ret;
            __ret = new(__JPH_Color_AssignFromAnother(_UnderlyingPtr, inRHS._UnderlyingPtr), is_owning: false);
            _DiscardKeepAlive();
            _KeepAlive(inRHS);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Generated from method `JPH::Color::operator()`.
        public unsafe new ref byte Call(uint inIdx)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Color_call_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Color_call_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte *__JPH_Color_call_mut(_Underlying *_this, uint inIdx);
            return ref *__JPH_Color_call_mut(_UnderlyingPtr, inIdx);
        }
    }

    /// This is used for optional parameters of class `Color` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Color`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Color`/`Const_Color` directly.
    public class _InOptMut_Color
    {
        public Color? Opt;

        public _InOptMut_Color() {}
        public _InOptMut_Color(Color value) {Opt = value;}
        public static implicit operator _InOptMut_Color(Color value) {return new(value);}
    }

    /// This is used for optional parameters of class `Color` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Color`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Color`/`Const_Color` to pass it to the function.
    public class _InOptConst_Color
    {
        public Const_Color? Opt;

        public _InOptConst_Color() {}
        public _InOptConst_Color(Const_Color value) {Opt = value;}
        public static implicit operator _InOptConst_Color(Const_Color value) {return new(value);}
    }
}
