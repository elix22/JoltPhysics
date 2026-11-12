// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Vec4 JPH_Vec4; // Defined in `#include <jolt/Jolt/Math/Vec4.h>`.


/// Class that holds an RGBA color with 8-bits per component
/// Generated from class `JPH::Color`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_Color JPH_Color;

/// Predefined colors
/// Returns a pointer to a member variable of class `JPH::Color` named `sBlack`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Color *JPH_Color_Get_sBlack(void);

/// Returns a pointer to a member variable of class `JPH::Color` named `sDarkRed`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Color *JPH_Color_Get_sDarkRed(void);

/// Returns a pointer to a member variable of class `JPH::Color` named `sRed`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Color *JPH_Color_Get_sRed(void);

/// Returns a pointer to a member variable of class `JPH::Color` named `sDarkGreen`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Color *JPH_Color_Get_sDarkGreen(void);

/// Returns a pointer to a member variable of class `JPH::Color` named `sGreen`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Color *JPH_Color_Get_sGreen(void);

/// Returns a pointer to a member variable of class `JPH::Color` named `sDarkBlue`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Color *JPH_Color_Get_sDarkBlue(void);

/// Returns a pointer to a member variable of class `JPH::Color` named `sBlue`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Color *JPH_Color_Get_sBlue(void);

/// Returns a pointer to a member variable of class `JPH::Color` named `sYellow`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Color *JPH_Color_Get_sYellow(void);

/// Returns a pointer to a member variable of class `JPH::Color` named `sPurple`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Color *JPH_Color_Get_sPurple(void);

/// Returns a pointer to a member variable of class `JPH::Color` named `sCyan`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Color *JPH_Color_Get_sCyan(void);

/// Returns a pointer to a member variable of class `JPH::Color` named `sOrange`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Color *JPH_Color_Get_sOrange(void);

/// Returns a pointer to a member variable of class `JPH::Color` named `sDarkOrange`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Color *JPH_Color_Get_sDarkOrange(void);

/// Returns a pointer to a member variable of class `JPH::Color` named `sGrey`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Color *JPH_Color_Get_sGrey(void);

/// Returns a pointer to a member variable of class `JPH::Color` named `sLightGrey`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Color *JPH_Color_Get_sLightGrey(void);

/// Returns a pointer to a member variable of class `JPH::Color` named `sWhite`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_Color *JPH_Color_Get_sWhite(void);

///< Combined value for red, green, blue and alpha
/// Returns a pointer to a member variable of class `JPH::Color` named `mU32`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const unsigned int *JPH_Color_Get_mU32(const JPH_Color *_this);

///< Combined value for red, green, blue and alpha
/// Modifies a member variable of class `JPH::Color` named `mU32`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mU32`.
/// When this function is called, this object will drop object references it held previously in `mU32`.
JOLT_API void JPH_Color_Set_mU32(JPH_Color *_this, unsigned int value);

///< Combined value for red, green, blue and alpha
/// Returns a mutable pointer to a member variable of class `JPH::Color` named `mU32`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API unsigned int *JPH_Color_GetMutable_mU32(JPH_Color *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Color_Destroy()` to free it when you're done using it.
JOLT_API JPH_Color *JPH_Color_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_Color_DestroyArray()`.
/// Use `JPH_Color_OffsetMutablePtr()` and `JPH_Color_OffsetPtr()` to access the array elements.
JOLT_API JPH_Color *JPH_Color_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_Color *JPH_Color_OffsetPtr(const JPH_Color *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_Color *JPH_Color_OffsetMutablePtr(JPH_Color *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::Color::Color`.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Color_Destroy()` to free it when you're done using it.
JOLT_API JPH_Color *JPH_Color_ConstructFromAnother(const JPH_Color *inRHS);

/// Generated from constructor `JPH::Color::Color`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Color_Destroy()` to free it when you're done using it.
JOLT_API JPH_Color *JPH_Color_Construct_1(unsigned int inColor);

/// Generated from constructor `JPH::Color::Color`.
/// Parameter `inAlpha` has a default argument: `255`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Color_Destroy()` to free it when you're done using it.
JOLT_API JPH_Color *JPH_Color_Construct_4(unsigned char inRed, unsigned char inGreen, unsigned char inBlue, const unsigned char *inAlpha);

/// Generated from constructor `JPH::Color::Color`.
/// Parameter `inRHS` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Color_Destroy()` to free it when you're done using it.
JOLT_API JPH_Color *JPH_Color_Construct_2(const JPH_Color *inRHS, unsigned char inAlpha);

/// Destroys a heap-allocated instance of `JPH_Color`. Does nothing if the pointer is null.
JOLT_API void JPH_Color_Destroy(const JPH_Color *_this);

/// Destroys a heap-allocated array of `JPH_Color`. Does nothing if the pointer is null.
JOLT_API void JPH_Color_DestroyArray(const JPH_Color *_this);

/// Generated from method `JPH::Color::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// The reference to things referred to by the parameter `inRHS` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_Color *JPH_Color_AssignFromAnother(JPH_Color *_this, const JPH_Color *inRHS);

/// Comparison
/// Generated from method `JPH::Color::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_equal_JPH_Color(const JPH_Color *_this, const JPH_Color *inRHS);

/// Generated from method `JPH::Color::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
JOLT_API bool Jolt_not_equal_JPH_Color(const JPH_Color *_this, const JPH_Color *inRHS);

/// Convert to uint32
/// Generated from method `JPH::Color::GetUInt32`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_Color_GetUInt32(const JPH_Color *_this);

/// Element access, 0 = red, 1 = green, 2 = blue, 3 = alpha
/// Generated from method `JPH::Color::operator()`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned char JPH_Color_call(const JPH_Color *_this, unsigned int inIdx);

/// Generated from method `JPH::Color::operator()`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API unsigned char *JPH_Color_call_mut(JPH_Color *_this, unsigned int inIdx);

/// Multiply two colors
/// Generated from method `JPH::Color::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inRHS` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Color_Destroy()` to free it when you're done using it.
JOLT_API JPH_Color *Jolt_mul_JPH_Color(const JPH_Color *_this, const JPH_Color *inRHS);

/// Multiply color with intensity in the range [0, 1]
/// Generated from method `JPH::Color::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Color_Destroy()` to free it when you're done using it.
JOLT_API JPH_Color *Jolt_mul_JPH_Color_float(const JPH_Color *_this, float inIntensity);

/// Convert to Vec4 with range [0, 1]
/// Generated from method `JPH::Color::ToVec4`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec4_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec4 *JPH_Color_ToVec4(const JPH_Color *_this);

/// Get grayscale intensity of color
/// Generated from method `JPH::Color::GetIntensity`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned char JPH_Color_GetIntensity(const JPH_Color *_this);

/// Get a visually distinct color
/// Generated from method `JPH::Color::sGetDistinctColor`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Color_Destroy()` to free it when you're done using it.
JOLT_API JPH_Color *JPH_Color_sGetDistinctColor(int inIndex);

/// Get a color value on the gradient from green through yellow to red
/// @param inValue Value in the range [0, 1], 0 = green, 0.5 = yellow, 1 = red
/// Generated from method `JPH::Color::sGreenRedGradient`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Color_Destroy()` to free it when you're done using it.
JOLT_API JPH_Color *JPH_Color_sGreenRedGradient(float inValue);

#ifdef __cplusplus
} // extern "C"
#endif
