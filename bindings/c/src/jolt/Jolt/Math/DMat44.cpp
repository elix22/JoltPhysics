// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/DMat44.h"

#include <Jolt/Math/DMat44.h>
#include <Jolt/Math/DVec3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Math/Vec4.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <iostream>
#include <memory>
#include <new>
#include <stdexcept>


JPH_DMat44 *JPH_DMat44_DefaultConstruct(void)
{
    using _mrbind_T = JPH::DMat44;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_DMat44*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_DMat44 *JPH_DMat44_DefaultConstructArray(size_t num_elems)
{
    return (JPH_DMat44 *)(new JPH::DMat44[num_elems]{});
}

const JPH_DMat44 *JPH_DMat44_OffsetPtr(const JPH_DMat44 *ptr, ptrdiff_t i)
{
    return (const JPH_DMat44 *)(((const JPH::DMat44 *)ptr) + i);
}

JPH_DMat44 *JPH_DMat44_OffsetMutablePtr(JPH_DMat44 *ptr, ptrdiff_t i)
{
    return (JPH_DMat44 *)(((JPH::DMat44 *)ptr) + i);
}

JPH_DMat44 *JPH_DMat44_ConstructFromAnother(const JPH_DMat44 *inM2)
{
    return (JPH_DMat44 *)new JPH::DMat44(JPH::DMat44(
        ((inM2 ? void() : MRBINDC_THROW("Parameter `inM2` can not be null.", void)), JPH::DMat44(*(JPH::DMat44 *)inM2))
    ));
}

JPH_DMat44 *JPH_DMat44_Construct_4_JPH_Vec4(const JPH_Vec4 *inC1, const JPH_Vec4 *inC2, const JPH_Vec4 *inC3, const JPH_DVec3 *inC4)
{
    return (JPH_DMat44 *)new JPH::DMat44(JPH::DMat44(
        ((inC1 ? void() : MRBINDC_THROW("Parameter `inC1` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inC1)),
        ((inC2 ? void() : MRBINDC_THROW("Parameter `inC2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inC2)),
        ((inC3 ? void() : MRBINDC_THROW("Parameter `inC3` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inC3)),
        ((inC4 ? void() : MRBINDC_THROW("Parameter `inC4` can not be null.", void)), *(const JPH::DVec3 *)(inC4))
    ));
}

JPH_DMat44 *JPH_DMat44_Construct_1(const JPH_Mat44 *inM)
{
    return (JPH_DMat44 *)new JPH::DMat44(JPH::DMat44(
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Mat44 *)(inM))
    ));
}

JPH_DMat44 *JPH_DMat44_Construct_2(const JPH_Mat44 *inRot, const JPH_DVec3 *inT)
{
    return (JPH_DMat44 *)new JPH::DMat44(JPH::DMat44(
        ((inRot ? void() : MRBINDC_THROW("Parameter `inRot` can not be null.", void)), *(const JPH::Mat44 *)(inRot)),
        ((inT ? void() : MRBINDC_THROW("Parameter `inT` can not be null.", void)), *(const JPH::DVec3 *)(inT))
    ));
}

void JPH_DMat44_Destroy(const JPH_DMat44 *_this)
{
    delete ((const JPH::DMat44 *)_this);
}

void JPH_DMat44_DestroyArray(const JPH_DMat44 *_this)
{
    delete[] ((const JPH::DMat44 *)_this);
}

JPH_DMat44 *JPH_DMat44_AssignFromAnother(JPH_DMat44 *_this, const JPH_DMat44 *inM2)
{
    return (JPH_DMat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DMat44 *)(_this)).operator=(
        mrbindc_details::unmove(((inM2 ? void() : MRBINDC_THROW("Parameter `inM2` can not be null.", void)), JPH::DMat44(*(JPH::DMat44 *)inM2)))
    ));
}

void *Jolt_new_JPH_DMat44_size_t(size_t inCount)
{
    return JPH::DMat44::operator new(
        inCount
    );
}

void Jolt_delete_JPH_DMat44_void_ptr(void *inPointer)
{
    JPH::DMat44::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_DMat44_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::DMat44::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_DMat44_size_t(size_t inCount)
{
    return JPH::DMat44::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_DMat44_void_ptr(void *inPointer)
{
    JPH::DMat44::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_DMat44_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::DMat44::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_DMat44_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::DMat44::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_DMat44_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DMat44::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_DMat44_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::DMat44::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_DMat44_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DMat44::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_DMat44 *JPH_DMat44_sZero(void)
{
    return (JPH_DMat44 *)new JPH::DMat44(JPH::DMat44::sZero());
}

JPH_DMat44 *JPH_DMat44_sIdentity(void)
{
    return (JPH_DMat44 *)new JPH::DMat44(JPH::DMat44::sIdentity());
}

JPH_DMat44 *JPH_DMat44_sRotation(const JPH_Quat *inQuat)
{
    return (JPH_DMat44 *)new JPH::DMat44(JPH::DMat44::sRotation(
        ((inQuat ? void() : MRBINDC_THROW("Parameter `inQuat` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inQuat))
    ));
}

JPH_DMat44 *JPH_DMat44_sTranslation(const JPH_DVec3 *inV)
{
    return (JPH_DMat44 *)new JPH::DMat44(JPH::DMat44::sTranslation(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::DVec3 *)(inV))
    ));
}

JPH_DMat44 *JPH_DMat44_sRotationTranslation(const JPH_Quat *inR, const JPH_DVec3 *inT)
{
    return (JPH_DMat44 *)new JPH::DMat44(JPH::DMat44::sRotationTranslation(
        ((inR ? void() : MRBINDC_THROW("Parameter `inR` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inR)),
        ((inT ? void() : MRBINDC_THROW("Parameter `inT` can not be null.", void)), *(const JPH::DVec3 *)(inT))
    ));
}

JPH_DMat44 *JPH_DMat44_sInverseRotationTranslation(const JPH_Quat *inR, const JPH_DVec3 *inT)
{
    return (JPH_DMat44 *)new JPH::DMat44(JPH::DMat44::sInverseRotationTranslation(
        ((inR ? void() : MRBINDC_THROW("Parameter `inR` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inR)),
        ((inT ? void() : MRBINDC_THROW("Parameter `inT` can not be null.", void)), *(const JPH::DVec3 *)(inT))
    ));
}

JPH_DMat44 *JPH_DMat44_sScale(const JPH_Vec3 *inV)
{
    return (JPH_DMat44 *)new JPH::DMat44(JPH::DMat44::sScale(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

JPH_Mat44 *JPH_DMat44_ToMat44(const JPH_DMat44 *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).ToMat44());
}

bool Jolt_equal_JPH_DMat44(const JPH_DMat44 *_this, const JPH_DMat44 *inM2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).operator==(
        ((inM2 ? void() : MRBINDC_THROW("Parameter `inM2` can not be null.", void)), *(const JPH::DMat44 *)(inM2))
    );
}

bool Jolt_not_equal_JPH_DMat44(const JPH_DMat44 *_this, const JPH_DMat44 *inM2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).operator!=(
        ((inM2 ? void() : MRBINDC_THROW("Parameter `inM2` can not be null.", void)), *(const JPH::DMat44 *)(inM2))
    );
}

bool JPH_DMat44_IsClose(const JPH_DMat44 *_this, const JPH_DMat44 *inM2, const float *inMaxDistSq)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).IsClose(
        ((inM2 ? void() : MRBINDC_THROW("Parameter `inM2` can not be null.", void)), *(const JPH::DMat44 *)(inM2)),
        (inMaxDistSq ? *inMaxDistSq : static_cast<float>(9.99999996E-13F))
    );
}

JPH_DMat44 *Jolt_mul_JPH_DMat44_JPH_Mat44(const JPH_DMat44 *_this, const JPH_Mat44 *inM)
{
    return (JPH_DMat44 *)new JPH::DMat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).operator*(
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::Mat44 *)(inM))
    ));
}

JPH_DMat44 *Jolt_mul_JPH_DMat44(const JPH_DMat44 *_this, const JPH_DMat44 *inM)
{
    return (JPH_DMat44 *)new JPH::DMat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).operator*(
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::DMat44 *)(inM))
    ));
}

JPH_DVec3 *Jolt_mul_JPH_DMat44_JPH_Vec3(const JPH_DMat44 *_this, const JPH_Vec3 *inV)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).operator*(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

JPH_DVec3 *Jolt_mul_JPH_DMat44_JPH_DVec3(const JPH_DMat44 *_this, const JPH_DVec3 *inV)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).operator*(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::DVec3 *)(inV))
    ));
}

JPH_Vec3 *JPH_DMat44_Multiply3x3_JPH_Vec3(const JPH_DMat44 *_this, const JPH_Vec3 *inV)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).Multiply3x3(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

JPH_DVec3 *JPH_DMat44_Multiply3x3_JPH_DVec3(const JPH_DMat44 *_this, const JPH_DVec3 *inV)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).Multiply3x3(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::DVec3 *)(inV))
    ));
}

JPH_Vec3 *JPH_DMat44_Multiply3x3Transposed(const JPH_DMat44 *_this, const JPH_Vec3 *inV)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).Multiply3x3Transposed(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

JPH_DMat44 *JPH_DMat44_PreScaled(const JPH_DMat44 *_this, const JPH_Vec3 *inScale)
{
    return (JPH_DMat44 *)new JPH::DMat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).PreScaled(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

JPH_DMat44 *JPH_DMat44_PostScaled(const JPH_DMat44 *_this, const JPH_Vec3 *inScale)
{
    return (JPH_DMat44 *)new JPH::DMat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).PostScaled(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

JPH_DMat44 *JPH_DMat44_PreTranslated_JPH_Vec3(const JPH_DMat44 *_this, const JPH_Vec3 *inTranslation)
{
    return (JPH_DMat44 *)new JPH::DMat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).PreTranslated(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTranslation))
    ));
}

JPH_DMat44 *JPH_DMat44_PreTranslated_JPH_DVec3(const JPH_DMat44 *_this, const JPH_DVec3 *inTranslation)
{
    return (JPH_DMat44 *)new JPH::DMat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).PreTranslated(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), *(const JPH::DVec3 *)(inTranslation))
    ));
}

JPH_DMat44 *JPH_DMat44_PostTranslated_JPH_Vec3(const JPH_DMat44 *_this, const JPH_Vec3 *inTranslation)
{
    return (JPH_DMat44 *)new JPH::DMat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).PostTranslated(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTranslation))
    ));
}

JPH_DMat44 *JPH_DMat44_PostTranslated_JPH_DVec3(const JPH_DMat44 *_this, const JPH_DVec3 *inTranslation)
{
    return (JPH_DMat44 *)new JPH::DMat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).PostTranslated(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), *(const JPH::DVec3 *)(inTranslation))
    ));
}

JPH_Vec3 *JPH_DMat44_GetAxisX(const JPH_DMat44 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).GetAxisX());
}

void JPH_DMat44_SetAxisX(JPH_DMat44 *_this, const JPH_Vec3 *inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DMat44 *)(_this)).SetAxisX(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    );
}

JPH_Vec3 *JPH_DMat44_GetAxisY(const JPH_DMat44 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).GetAxisY());
}

void JPH_DMat44_SetAxisY(JPH_DMat44 *_this, const JPH_Vec3 *inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DMat44 *)(_this)).SetAxisY(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    );
}

JPH_Vec3 *JPH_DMat44_GetAxisZ(const JPH_DMat44 *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).GetAxisZ());
}

void JPH_DMat44_SetAxisZ(JPH_DMat44 *_this, const JPH_Vec3 *inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DMat44 *)(_this)).SetAxisZ(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    );
}

JPH_DVec3 *JPH_DMat44_GetTranslation(const JPH_DMat44 *_this)
{
    return (JPH_DVec3 *)new JPH::DVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).GetTranslation());
}

void JPH_DMat44_SetTranslation(JPH_DMat44 *_this, const JPH_DVec3 *inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DMat44 *)(_this)).SetTranslation(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), *(const JPH::DVec3 *)(inV))
    );
}

JPH_Vec3 *JPH_DMat44_GetColumn3(const JPH_DMat44 *_this, unsigned int inCol)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).GetColumn3(
        inCol
    ));
}

void JPH_DMat44_SetColumn3(JPH_DMat44 *_this, unsigned int inCol, const JPH_Vec3 *inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DMat44 *)(_this)).SetColumn3(
        inCol,
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    );
}

JPH_Vec4 *JPH_DMat44_GetColumn4(const JPH_DMat44 *_this, unsigned int inCol)
{
    return (JPH_Vec4 *)new JPH::Vec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).GetColumn4(
        inCol
    ));
}

void JPH_DMat44_SetColumn4(JPH_DMat44 *_this, unsigned int inCol, const JPH_Vec4 *inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DMat44 *)(_this)).SetColumn4(
        inCol,
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV))
    );
}

JPH_Mat44 *JPH_DMat44_Transposed3x3(const JPH_DMat44 *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).Transposed3x3());
}

JPH_DMat44 *JPH_DMat44_Inversed(const JPH_DMat44 *_this)
{
    return (JPH_DMat44 *)new JPH::DMat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).Inversed());
}

JPH_DMat44 *JPH_DMat44_InversedRotationTranslation(const JPH_DMat44 *_this)
{
    return (JPH_DMat44 *)new JPH::DMat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).InversedRotationTranslation());
}

JPH_Mat44 *JPH_DMat44_GetRotation(const JPH_DMat44 *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).GetRotation());
}

void JPH_DMat44_SetRotation(JPH_DMat44 *_this, const JPH_Mat44 *inRotation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DMat44 *)(_this)).SetRotation(
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), *(const JPH::Mat44 *)(inRotation))
    );
}

JPH_Quat *JPH_DMat44_GetQuaternion(const JPH_DMat44 *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).GetQuaternion());
}

JPH_Mat44 *JPH_DMat44_GetDirectionPreservingMatrix(const JPH_DMat44 *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).GetDirectionPreservingMatrix());
}

JPH_DMat44 *JPH_DMat44_Decompose(const JPH_DMat44 *_this, JPH_Vec3 *outScale)
{
    return (JPH_DMat44 *)new JPH::DMat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DMat44 *)(_this)).Decompose(
        ((outScale ? void() : MRBINDC_THROW("Parameter `outScale` can not be null.", void)), *(JPH::Vec3 *)(outScale))
    ));
}

Jolt_std_ostream *Jolt_print_JPH_DMat44(Jolt_std_ostream *inStream, const JPH_DMat44 *inM)
{
    return (Jolt_std_ostream *)std::addressof(operator<<(
        ((inStream ? void() : MRBINDC_THROW("Parameter `inStream` can not be null.", void)), *(std::ostream *)(inStream)),
        ((inM ? void() : MRBINDC_THROW("Parameter `inM` can not be null.", void)), *(const JPH::DMat44 *)(inM))
    ));
}

