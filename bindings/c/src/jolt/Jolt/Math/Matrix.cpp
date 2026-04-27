// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/Matrix.h"

#include <Jolt/Math/Matrix.h>
#include <Jolt/Math/Vector.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <iostream>
#include <memory>
#include <stdexcept>
#include <type_traits>


const JPH_Vector_2 *JPH_Matrix_2_2_Get_mCol(const JPH_Matrix_2_2 *_this)
{
    return (const JPH_Vector_2 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(_this)).mCol[0]);
}

JPH_Vector_2 *JPH_Matrix_2_2_GetMutable_mCol(JPH_Matrix_2_2 *_this)
{
    return (JPH_Vector_2 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Matrix<2, 2> *)(_this)).mCol[0]);
}

size_t JPH_Matrix_2_2_GetSize_mCol(void)
{
    return std::extent_v<decltype(JPH::Matrix<2, 2>::mCol)>;
}

JPH_Matrix_2_2 *JPH_Matrix_2_2_DefaultConstruct(void)
{
    return (JPH_Matrix_2_2 *)new JPH::Matrix<2, 2>(JPH::Matrix<2, 2>());
}

JPH_Matrix_2_2 *JPH_Matrix_2_2_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Matrix_2_2 *)(new JPH::Matrix<2, 2>[num_elems]{});
}

const JPH_Matrix_2_2 *JPH_Matrix_2_2_OffsetPtr(const JPH_Matrix_2_2 *ptr, ptrdiff_t i)
{
    return (const JPH_Matrix_2_2 *)(((const JPH::Matrix<2, 2> *)ptr) + i);
}

JPH_Matrix_2_2 *JPH_Matrix_2_2_OffsetMutablePtr(JPH_Matrix_2_2 *ptr, ptrdiff_t i)
{
    return (JPH_Matrix_2_2 *)(((JPH::Matrix<2, 2> *)ptr) + i);
}

JPH_Matrix_2_2 *JPH_Matrix_2_2_ConstructFromAnother(Jolt_PassBy inM2_pass_by, JPH_Matrix_2_2 *inM2)
{
    MRBINDC_CLASSARG_GUARD(inM2, JPH::Matrix<2, 2>);
    return (JPH_Matrix_2_2 *)new JPH::Matrix<2, 2>(JPH::Matrix<2, 2>(
        (MRBINDC_CLASSARG_DEF_CTOR(inM2, JPH::Matrix<2, 2>) MRBINDC_CLASSARG_COPY(inM2, (JPH::Matrix<2, 2>), JPH::Matrix<2, 2>) MRBINDC_CLASSARG_NO_DEF_ARG(inM2, Jolt_PassBy_DefaultArgument, JPH::Matrix<2, 2>) MRBINDC_CLASSARG_NO_DEF_ARG(inM2, Jolt_PassBy_NoObject, JPH::Matrix<2, 2>) MRBINDC_CLASSARG_END(inM2, JPH::Matrix<2, 2>))
    ));
}

void JPH_Matrix_2_2_Destroy(const JPH_Matrix_2_2 *_this)
{
    delete ((const JPH::Matrix<2, 2> *)_this);
}

void JPH_Matrix_2_2_DestroyArray(const JPH_Matrix_2_2 *_this)
{
    delete[] ((const JPH::Matrix<2, 2> *)_this);
}

JPH_Matrix_2_2 *JPH_Matrix_2_2_AssignFromAnother(JPH_Matrix_2_2 *_this, Jolt_PassBy inM2_pass_by, JPH_Matrix_2_2 *inM2)
{
    MRBINDC_CLASSARG_GUARD(inM2, JPH::Matrix<2, 2>);
    return (JPH_Matrix_2_2 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Matrix<2, 2> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(inM2, JPH::Matrix<2, 2>) MRBINDC_CLASSARG_COPY(inM2, (JPH::Matrix<2, 2>), JPH::Matrix<2, 2>) MRBINDC_CLASSARG_NO_DEF_ARG(inM2, Jolt_PassBy_DefaultArgument, JPH::Matrix<2, 2>) MRBINDC_CLASSARG_NO_DEF_ARG(inM2, Jolt_PassBy_NoObject, JPH::Matrix<2, 2>) MRBINDC_CLASSARG_END(inM2, JPH::Matrix<2, 2>)))
    ));
}

unsigned int JPH_Matrix_2_2_GetRows(const JPH_Matrix_2_2 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(_this)).GetRows();
}

unsigned int JPH_Matrix_2_2_GetCols(const JPH_Matrix_2_2 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(_this)).GetCols();
}

void JPH_Matrix_2_2_SetZero(JPH_Matrix_2_2 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Matrix<2, 2> *)(_this)).SetZero();
}

JPH_Matrix_2_2 *JPH_Matrix_2_2_sZero(void)
{
    return (JPH_Matrix_2_2 *)new JPH::Matrix<2, 2>(JPH::Matrix<2, 2>::sZero());
}

bool JPH_Matrix_2_2_IsZero(const JPH_Matrix_2_2 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(_this)).IsZero();
}

void JPH_Matrix_2_2_SetIdentity(JPH_Matrix_2_2 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Matrix<2, 2> *)(_this)).SetIdentity();
}

JPH_Matrix_2_2 *JPH_Matrix_2_2_sIdentity(void)
{
    return (JPH_Matrix_2_2 *)new JPH::Matrix<2, 2>(JPH::Matrix<2, 2>::sIdentity());
}

bool JPH_Matrix_2_2_IsIdentity(const JPH_Matrix_2_2 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(_this)).IsIdentity();
}

void JPH_Matrix_2_2_SetDiagonal(JPH_Matrix_2_2 *_this, const JPH_Vector_2 *inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Matrix<2, 2> *)(_this)).SetDiagonal(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::Vector<2> *)(inV))
    );
}

JPH_Matrix_2_2 *JPH_Matrix_2_2_sDiagonal(const JPH_Vector_2 *inV)
{
    return (JPH_Matrix_2_2 *)new JPH::Matrix<2, 2>(JPH::Matrix<2, 2>::sDiagonal(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::Vector<2> *)(inV))
    ));
}

float JPH_Matrix_2_2_call(const JPH_Matrix_2_2 *_this, unsigned int inRow, unsigned int inColumn)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(_this)).operator()(
        inRow,
        inColumn
    );
}

float *JPH_Matrix_2_2_call_mut(JPH_Matrix_2_2 *_this, unsigned int inRow, unsigned int inColumn)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Matrix<2, 2> *)(_this)).operator()(
        inRow,
        inColumn
    ));
}

bool Jolt_equal_JPH_Matrix_2_2(const JPH_Matrix_2_2 *_this, const JPH_Matrix_2_2 *inM2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(_this)).operator==(
        ((inM2 ? void() : MRBINDC_THROW("Parameter `inM2` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(inM2))
    );
}

bool Jolt_not_equal_JPH_Matrix_2_2(const JPH_Matrix_2_2 *_this, const JPH_Matrix_2_2 *inM2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(_this)).operator!=(
        ((inM2 ? void() : MRBINDC_THROW("Parameter `inM2` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(inM2))
    );
}

JPH_Vector_2 *Jolt_mul_JPH_Matrix_2_2_JPH_Vector_2(const JPH_Matrix_2_2 *_this, const JPH_Vector_2 *inV)
{
    return (JPH_Vector_2 *)new JPH::Vector<2>(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(_this)).operator*(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::Vector<2> *)(inV))
    ));
}

JPH_Matrix_2_2 *Jolt_mul_JPH_Matrix_2_2_float(const JPH_Matrix_2_2 *_this, float inV)
{
    return (JPH_Matrix_2_2 *)new JPH::Matrix<2, 2>(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(_this)).operator*(
        inV
    ));
}

JPH_Matrix_2_2 *Jolt_add_JPH_Matrix_2_2(const JPH_Matrix_2_2 *_this, const JPH_Matrix_2_2 *inM)
{
    return (JPH_Matrix_2_2 *)new JPH::Matrix<2, 2>(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(_this)).operator+(
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(inM))
    ));
}

JPH_Matrix_2_2 *Jolt_sub_JPH_Matrix_2_2(const JPH_Matrix_2_2 *_this, const JPH_Matrix_2_2 *inM)
{
    return (JPH_Matrix_2_2 *)new JPH::Matrix<2, 2>(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(_this)).operator-(
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(inM))
    ));
}

JPH_Matrix_2_2 *JPH_Matrix_2_2_Transposed(const JPH_Matrix_2_2 *_this)
{
    return (JPH_Matrix_2_2 *)new JPH::Matrix<2, 2>(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(_this)).Transposed());
}

bool JPH_Matrix_2_2_SetInversed(JPH_Matrix_2_2 *_this, const JPH_Matrix_2_2 *inM)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Matrix<2, 2> *)(_this)).SetInversed(
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(inM))
    );
}

JPH_Matrix_2_2 *JPH_Matrix_2_2_Inversed(const JPH_Matrix_2_2 *_this)
{
    return (JPH_Matrix_2_2 *)new JPH::Matrix<2, 2>(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(_this)).Inversed());
}

const JPH_Vector_2 *JPH_Matrix_2_2_GetColumn(const JPH_Matrix_2_2 *_this, int inIdx)
{
    return (const JPH_Vector_2 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(_this)).GetColumn(
        inIdx
    ));
}

JPH_Vector_2 *JPH_Matrix_2_2_GetColumn_mut(JPH_Matrix_2_2 *_this, int inIdx)
{
    return (JPH_Vector_2 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Matrix<2, 2> *)(_this)).GetColumn(
        inIdx
    ));
}

JPH_Matrix_2_2 *Jolt_mul_float_JPH_Matrix_2_2(float inV, const JPH_Matrix_2_2 *inM)
{
    return (JPH_Matrix_2_2 *)new JPH::Matrix<2, 2>(operator*(
        inV,
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(inM))
    ));
}

Jolt_std_ostream *Jolt_print_JPH_Matrix_2_2(Jolt_std_ostream *inStream, const JPH_Matrix_2_2 *inM)
{
    return (Jolt_std_ostream *)std::addressof(operator<<(
        ((inStream ? void() : MRBINDC_THROW("Parameter `inStream` can not be null.", void)), *(std::ostream *)(inStream)),
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Matrix<2, 2> *)(inM))
    ));
}

