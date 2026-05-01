// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Core/Color.h"

#include <Jolt/Core/Color.h>
#include <Jolt/Math/Vec4.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Color *JPH_Color_Get_sBlack(void)
{
    return (const JPH_Color *)std::addressof(JPH::Color::sBlack);
}

const JPH_Color *JPH_Color_Get_sDarkRed(void)
{
    return (const JPH_Color *)std::addressof(JPH::Color::sDarkRed);
}

const JPH_Color *JPH_Color_Get_sRed(void)
{
    return (const JPH_Color *)std::addressof(JPH::Color::sRed);
}

const JPH_Color *JPH_Color_Get_sDarkGreen(void)
{
    return (const JPH_Color *)std::addressof(JPH::Color::sDarkGreen);
}

const JPH_Color *JPH_Color_Get_sGreen(void)
{
    return (const JPH_Color *)std::addressof(JPH::Color::sGreen);
}

const JPH_Color *JPH_Color_Get_sDarkBlue(void)
{
    return (const JPH_Color *)std::addressof(JPH::Color::sDarkBlue);
}

const JPH_Color *JPH_Color_Get_sBlue(void)
{
    return (const JPH_Color *)std::addressof(JPH::Color::sBlue);
}

const JPH_Color *JPH_Color_Get_sYellow(void)
{
    return (const JPH_Color *)std::addressof(JPH::Color::sYellow);
}

const JPH_Color *JPH_Color_Get_sPurple(void)
{
    return (const JPH_Color *)std::addressof(JPH::Color::sPurple);
}

const JPH_Color *JPH_Color_Get_sCyan(void)
{
    return (const JPH_Color *)std::addressof(JPH::Color::sCyan);
}

const JPH_Color *JPH_Color_Get_sOrange(void)
{
    return (const JPH_Color *)std::addressof(JPH::Color::sOrange);
}

const JPH_Color *JPH_Color_Get_sDarkOrange(void)
{
    return (const JPH_Color *)std::addressof(JPH::Color::sDarkOrange);
}

const JPH_Color *JPH_Color_Get_sGrey(void)
{
    return (const JPH_Color *)std::addressof(JPH::Color::sGrey);
}

const JPH_Color *JPH_Color_Get_sLightGrey(void)
{
    return (const JPH_Color *)std::addressof(JPH::Color::sLightGrey);
}

const JPH_Color *JPH_Color_Get_sWhite(void)
{
    return (const JPH_Color *)std::addressof(JPH::Color::sWhite);
}

JPH_Color *JPH_Color_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Color;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_Color*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_Color *JPH_Color_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Color *)(new JPH::Color[num_elems]{});
}

const JPH_Color *JPH_Color_OffsetPtr(const JPH_Color *ptr, ptrdiff_t i)
{
    return (const JPH_Color *)(((const JPH::Color *)ptr) + i);
}

JPH_Color *JPH_Color_OffsetMutablePtr(JPH_Color *ptr, ptrdiff_t i)
{
    return (JPH_Color *)(((JPH::Color *)ptr) + i);
}

JPH_Color *JPH_Color_ConstructFromAnother(const JPH_Color *inRHS)
{
    return (JPH_Color *)new JPH::Color(JPH::Color(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Color(*(JPH::Color *)inRHS))
    ));
}

JPH_Color *JPH_Color_Construct_1(unsigned int inColor)
{
    return (JPH_Color *)new JPH::Color(JPH::Color(
        inColor
    ));
}

JPH_Color *JPH_Color_Construct_4(unsigned char inRed, unsigned char inGreen, unsigned char inBlue, const unsigned char *inAlpha)
{
    using namespace JPH;
    return (JPH_Color *)new JPH::Color(JPH::Color(
        inRed,
        inGreen,
        inBlue,
        (inAlpha ? *inAlpha : static_cast<unsigned char>(255))
    ));
}

JPH_Color *JPH_Color_Construct_2(const JPH_Color *inRHS, unsigned char inAlpha)
{
    return (JPH_Color *)new JPH::Color(JPH::Color(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Color(*(JPH::Color *)inRHS)),
        inAlpha
    ));
}

void JPH_Color_Destroy(const JPH_Color *_this)
{
    delete ((const JPH::Color *)_this);
}

void JPH_Color_DestroyArray(const JPH_Color *_this)
{
    delete[] ((const JPH::Color *)_this);
}

JPH_Color *JPH_Color_AssignFromAnother(JPH_Color *_this, const JPH_Color *inRHS)
{
    return (JPH_Color *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Color *)(_this)).operator=(
        mrbindc_details::unmove(((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Color(*(JPH::Color *)inRHS)))
    ));
}

bool Jolt_equal_JPH_Color(const JPH_Color *_this, const JPH_Color *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Color *)(_this)).operator==(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Color(*(JPH::Color *)inRHS))
    );
}

bool Jolt_not_equal_JPH_Color(const JPH_Color *_this, const JPH_Color *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Color *)(_this)).operator!=(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::Color(*(JPH::Color *)inRHS))
    );
}

unsigned int JPH_Color_GetUInt32(const JPH_Color *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Color *)(_this)).GetUInt32();
}

unsigned char JPH_Color_call(const JPH_Color *_this, unsigned int inIdx)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Color *)(_this)).operator()(
        inIdx
    );
}

unsigned char *JPH_Color_call_mut(JPH_Color *_this, unsigned int inIdx)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Color *)(_this)).operator()(
        inIdx
    ));
}

JPH_Color *Jolt_mul_JPH_Color(const JPH_Color *_this, const JPH_Color *inRHS)
{
    return (JPH_Color *)new JPH::Color(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Color *)(_this)).operator*(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::Color *)(inRHS))
    ));
}

JPH_Color *Jolt_mul_JPH_Color_float(const JPH_Color *_this, float inIntensity)
{
    return (JPH_Color *)new JPH::Color(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Color *)(_this)).operator*(
        inIntensity
    ));
}

JPH_Vec4 *JPH_Color_ToVec4(const JPH_Color *_this)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Color *)(_this)).ToVec4());
}

unsigned char JPH_Color_GetIntensity(const JPH_Color *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Color *)(_this)).GetIntensity();
}

JPH_Color *JPH_Color_sGetDistinctColor(int inIndex)
{
    return (JPH_Color *)new JPH::Color(JPH::Color::sGetDistinctColor(
        inIndex
    ));
}

JPH_Color *JPH_Color_sGreenRedGradient(float inValue)
{
    return (JPH_Color *)new JPH::Color(JPH::Color::sGreenRedGradient(
        inValue
    ));
}

