// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/Vector.h"

#include <Jolt/Math/Vector.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <iostream>
#include <memory>
#include <stdexcept>
#include <type_traits>


const float *JPH_Vector_2_Get_mF32(const JPH_Vector_2 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).mF32[0]);
}

float *JPH_Vector_2_GetMutable_mF32(JPH_Vector_2 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vector<2> *)(_this)).mF32[0]);
}

size_t JPH_Vector_2_GetSize_mF32(void)
{
    return std::extent_v<decltype(JPH::Vector<2>::mF32)>;
}

JPH_Vector_2 *JPH_Vector_2_DefaultConstruct(void)
{
    return (JPH_Vector_2 *)new JPH::Vector<2>(JPH::Vector<2>());
}

JPH_Vector_2 *JPH_Vector_2_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Vector_2 *)(new JPH::Vector<2>[num_elems]{});
}

const JPH_Vector_2 *JPH_Vector_2_OffsetPtr(const JPH_Vector_2 *ptr, ptrdiff_t i)
{
    return (const JPH_Vector_2 *)(((const JPH::Vector<2> *)ptr) + i);
}

JPH_Vector_2 *JPH_Vector_2_OffsetMutablePtr(JPH_Vector_2 *ptr, ptrdiff_t i)
{
    return (JPH_Vector_2 *)(((JPH::Vector<2> *)ptr) + i);
}

JPH_Vector_2 *JPH_Vector_2_ConstructFromAnother(const JPH_Vector_2 *_other)
{
    return (JPH_Vector_2 *)new JPH::Vector<2>(JPH::Vector<2>(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::Vector<2>(*(JPH::Vector<2> *)_other))
    ));
}

void JPH_Vector_2_Destroy(const JPH_Vector_2 *_this)
{
    delete ((const JPH::Vector<2> *)_this);
}

void JPH_Vector_2_DestroyArray(const JPH_Vector_2 *_this)
{
    delete[] ((const JPH::Vector<2> *)_this);
}

JPH_Vector_2 *JPH_Vector_2_AssignFromAnother(JPH_Vector_2 *_this, const JPH_Vector_2 *_other)
{
    return (JPH_Vector_2 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vector<2> *)(_this)).operator=(
        mrbindc_details::unmove(((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::Vector<2>(*(JPH::Vector<2> *)_other)))
    ));
}

unsigned int JPH_Vector_2_GetRows(const JPH_Vector_2 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).GetRows();
}

void JPH_Vector_2_SetZero(JPH_Vector_2 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vector<2> *)(_this)).SetZero();
}

JPH_Vector_2 *JPH_Vector_2_sZero(void)
{
    return (JPH_Vector_2 *)new JPH::Vector<2>(JPH::Vector<2>::sZero());
}

float JPH_Vector_2_index(const JPH_Vector_2 *_this, unsigned int inCoordinate)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).operator[](
        inCoordinate
    );
}

float *JPH_Vector_2_index_mut(JPH_Vector_2 *_this, unsigned int inCoordinate)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vector<2> *)(_this)).operator[](
        inCoordinate
    ));
}

bool Jolt_equal_JPH_Vector_2(const JPH_Vector_2 *_this, const JPH_Vector_2 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).operator==(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::Vector<2> *)(inV2))
    );
}

bool Jolt_not_equal_JPH_Vector_2(const JPH_Vector_2 *_this, const JPH_Vector_2 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).operator!=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::Vector<2> *)(inV2))
    );
}

bool JPH_Vector_2_IsZero(const JPH_Vector_2 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).IsZero();
}

bool JPH_Vector_2_IsClose(const JPH_Vector_2 *_this, const JPH_Vector_2 *inV2, const float *inMaxDistSq)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).IsClose(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::Vector<2> *)(inV2)),
        (inMaxDistSq ? *inMaxDistSq : static_cast<float>(9.99999996E-13F))
    );
}

JPH_Vector_2 *Jolt_mul_JPH_Vector_2_float(const JPH_Vector_2 *_this, float inV2)
{
    return (JPH_Vector_2 *)new JPH::Vector<2>(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).operator*(
        inV2
    ));
}

JPH_Vector_2 *JPH_Vector_2_mul_assign(JPH_Vector_2 *_this, float inV2)
{
    return (JPH_Vector_2 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vector<2> *)(_this)).operator*=(
        inV2
    ));
}

JPH_Vector_2 *Jolt_div_JPH_Vector_2_float(const JPH_Vector_2 *_this, float inV2)
{
    return (JPH_Vector_2 *)new JPH::Vector<2>(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).operator/(
        inV2
    ));
}

JPH_Vector_2 *JPH_Vector_2_div_assign(JPH_Vector_2 *_this, float inV2)
{
    return (JPH_Vector_2 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vector<2> *)(_this)).operator/=(
        inV2
    ));
}

JPH_Vector_2 *Jolt_add_JPH_Vector_2(const JPH_Vector_2 *_this, const JPH_Vector_2 *inV2)
{
    return (JPH_Vector_2 *)new JPH::Vector<2>(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).operator+(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::Vector<2> *)(inV2))
    ));
}

JPH_Vector_2 *JPH_Vector_2_add_assign(JPH_Vector_2 *_this, const JPH_Vector_2 *inV2)
{
    return (JPH_Vector_2 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vector<2> *)(_this)).operator+=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::Vector<2> *)(inV2))
    ));
}

JPH_Vector_2 *Jolt_neg_JPH_Vector_2(const JPH_Vector_2 *_this)
{
    return (JPH_Vector_2 *)new JPH::Vector<2>(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).operator-());
}

JPH_Vector_2 *Jolt_sub_JPH_Vector_2(const JPH_Vector_2 *_this, const JPH_Vector_2 *inV2)
{
    return (JPH_Vector_2 *)new JPH::Vector<2>(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).operator-(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::Vector<2> *)(inV2))
    ));
}

JPH_Vector_2 *JPH_Vector_2_sub_assign(JPH_Vector_2 *_this, const JPH_Vector_2 *inV2)
{
    return (JPH_Vector_2 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vector<2> *)(_this)).operator-=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::Vector<2> *)(inV2))
    ));
}

float JPH_Vector_2_Dot(const JPH_Vector_2 *_this, const JPH_Vector_2 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).Dot(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::Vector<2> *)(inV2))
    );
}

float JPH_Vector_2_LengthSq(const JPH_Vector_2 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).LengthSq();
}

float JPH_Vector_2_Length(const JPH_Vector_2 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).Length();
}

bool JPH_Vector_2_IsNormalized(JPH_Vector_2 *_this, const float *inToleranceSq)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Vector<2> *)(_this)).IsNormalized(
        (inToleranceSq ? *inToleranceSq : static_cast<float>(9.99999997E-7F))
    );
}

JPH_Vector_2 *JPH_Vector_2_Normalized(const JPH_Vector_2 *_this)
{
    return (JPH_Vector_2 *)new JPH::Vector<2>(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Vector<2> *)(_this)).Normalized());
}

JPH_Vector_2 *Jolt_mul_float_JPH_Vector_2(float inV1, const JPH_Vector_2 *inV2)
{
    return (JPH_Vector_2 *)new JPH::Vector<2>(operator*(
        inV1,
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::Vector<2> *)(inV2))
    ));
}

Jolt_std_ostream *Jolt_print_JPH_Vector_2(Jolt_std_ostream *inStream, const JPH_Vector_2 *inV)
{
    return (Jolt_std_ostream *)std::addressof(operator<<(
        ((inStream ? void() : MRBINDC_THROW("Parameter `inStream` can not be null.", void)), *(std::ostream *)(inStream)),
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::Vector<2> *)(inV))
    ));
}

