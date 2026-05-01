// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/RayCast.h"

#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Collision/BackFaceMode.h>
#include <Jolt/Physics/Collision/RayCast.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Get_mOrigin(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)(_this)).mOrigin);
}

JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetMutable_mOrigin(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)(_this)).mOrigin);
}

const JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Get_mDirection(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)(_this)).mDirection);
}

JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetMutable_mDirection(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)(_this)).mDirection);
}

JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *)(new JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>[num_elems]{});
}

const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_OffsetPtr(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *ptr, ptrdiff_t i)
{
    return (const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *)(((const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)ptr) + i);
}

JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_OffsetMutablePtr(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *ptr, ptrdiff_t i)
{
    return (JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *)(((JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)ptr) + i);
}

JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_ConstructFromAnother(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_other)
{
    return (JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *)new JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>(JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>(*(JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)_other))
    ));
}

JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Construct(const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection)
{
    return (JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *)new JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>(JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>(
        ((inOrigin ? void() : MRBINDC_THROW("Parameter `inOrigin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOrigin)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    ));
}

void JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Destroy(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this)
{
    delete ((const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)_this);
}

void JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_DestroyArray(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this)
{
    delete[] ((const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)_this);
}

JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_AssignFromAnother(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this, const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_other)
{
    return (JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)(_this)).operator=(
        mrbindc_details::unmove(((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>(*(JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)_other)))
    ));
}

void *Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t(size_t inCount)
{
    return JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator new(
        inCount
    );
}

void Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr(void *inPointer)
{
    JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t(size_t inCount)
{
    return JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr(void *inPointer)
{
    JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Transformed(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this, const JPH_Mat44 *inTransform)
{
    return (JPH_RayCast *)new JPH::RayCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)(_this)).Transformed(
        ((inTransform ? void() : MRBINDC_THROW("Parameter `inTransform` can not be null.", void)), *(const JPH::Mat44 *)(inTransform))
    ));
}

JPH_RayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Translated(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this, const JPH_Vec3 *inTranslation)
{
    return (JPH_RayCast *)new JPH::RayCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)(_this)).Translated(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTranslation))
    ));
}

JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetPointOnRay(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *_this, float inFraction)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)(_this)).GetPointOnRay(
        inFraction
    ));
}

const JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Get_mOrigin(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)(_this)).mOrigin);
}

JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetMutable_mOrigin(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)(_this)).mOrigin);
}

const JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Get_mDirection(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)(_this)).mDirection);
}

JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetMutable_mDirection(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)(_this)).mDirection);
}

JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *)(new JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>[num_elems]{});
}

const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_OffsetPtr(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *ptr, ptrdiff_t i)
{
    return (const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *)(((const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)ptr) + i);
}

JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_OffsetMutablePtr(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *ptr, ptrdiff_t i)
{
    return (JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *)(((JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)ptr) + i);
}

JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_ConstructFromAnother(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_other)
{
    return (JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *)new JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>(JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>(*(JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)_other))
    ));
}

JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Construct(const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection)
{
    return (JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *)new JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>(JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>(
        ((inOrigin ? void() : MRBINDC_THROW("Parameter `inOrigin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOrigin)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    ));
}

void JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Destroy(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this)
{
    delete ((const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)_this);
}

void JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_DestroyArray(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this)
{
    delete[] ((const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)_this);
}

JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_AssignFromAnother(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this, const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_other)
{
    return (JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)(_this)).operator=(
        mrbindc_details::unmove(((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>(*(JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)_other)))
    ));
}

void *Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t(size_t inCount)
{
    return JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator new(
        inCount
    );
}

void Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr(void *inPointer)
{
    JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t(size_t inCount)
{
    return JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr(void *inPointer)
{
    JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Transformed(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this, const JPH_Mat44 *inTransform)
{
    return (JPH_RRayCast *)new JPH::RRayCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)(_this)).Transformed(
        ((inTransform ? void() : MRBINDC_THROW("Parameter `inTransform` can not be null.", void)), *(const JPH::Mat44 *)(inTransform))
    ));
}

JPH_RRayCast *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Translated(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this, const JPH_Vec3 *inTranslation)
{
    return (JPH_RRayCast *)new JPH::RRayCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)(_this)).Translated(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTranslation))
    ));
}

JPH_Vec3 *JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetPointOnRay(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *_this, float inFraction)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)(_this)).GetPointOnRay(
        inFraction
    ));
}

const JPH_Vec3 *JPH_RayCast_Get_mOrigin(const JPH_RayCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCast *)(_this)).mOrigin);
}

JPH_Vec3 *JPH_RayCast_GetMutable_mOrigin(JPH_RayCast *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCast *)(_this)).mOrigin);
}

const JPH_Vec3 *JPH_RayCast_Get_mDirection(const JPH_RayCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCast *)(_this)).mDirection);
}

JPH_Vec3 *JPH_RayCast_GetMutable_mDirection(JPH_RayCast *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCast *)(_this)).mDirection);
}

JPH_RayCast *JPH_RayCast_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RayCast;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RayCast*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RayCast *JPH_RayCast_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RayCast *)(new JPH::RayCast[num_elems]{});
}

const JPH_RayCast *JPH_RayCast_OffsetPtr(const JPH_RayCast *ptr, ptrdiff_t i)
{
    return (const JPH_RayCast *)(((const JPH::RayCast *)ptr) + i);
}

JPH_RayCast *JPH_RayCast_OffsetMutablePtr(JPH_RayCast *ptr, ptrdiff_t i)
{
    return (JPH_RayCast *)(((JPH::RayCast *)ptr) + i);
}

const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(const JPH_RayCast *object)
{
    return (const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *)(static_cast<const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *>(
        ((const JPH::RayCast *)object)
    ));
}

JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *JPH_RayCast_MutableUpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(JPH_RayCast *object)
{
    return (JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *)(static_cast<JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *>(
        ((JPH::RayCast *)object)
    ));
}

const JPH_RayCast *JPH_RayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *object)
{
    return (const JPH_RayCast *)(static_cast<const JPH::RayCast *>(
        ((const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)object)
    ));
}

JPH_RayCast *JPH_RayCast_MutableStaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast *object)
{
    return (JPH_RayCast *)(static_cast<JPH::RayCast *>(
        ((JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast> *)object)
    ));
}

JPH_RayCast *JPH_RayCast_ConstructFromAnother(const JPH_RayCast *_other)
{
    return (JPH_RayCast *)new JPH::RayCast(JPH::RayCast(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::RayCast(*(JPH::RayCast *)_other))
    ));
}

JPH_RayCast *JPH_RayCast_Construct(const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection)
{
    return (JPH_RayCast *)new JPH::RayCast(JPH::RayCast(
        ((inOrigin ? void() : MRBINDC_THROW("Parameter `inOrigin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOrigin)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    ));
}

void JPH_RayCast_Destroy(const JPH_RayCast *_this)
{
    delete ((const JPH::RayCast *)_this);
}

void JPH_RayCast_DestroyArray(const JPH_RayCast *_this)
{
    delete[] ((const JPH::RayCast *)_this);
}

JPH_RayCast *JPH_RayCast_AssignFromAnother(JPH_RayCast *_this, const JPH_RayCast *_other)
{
    return (JPH_RayCast *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCast *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::RayCast(*(JPH::RayCast *)_other))
    ));
}

JPH_RayCast *JPH_RayCast_Transformed(const JPH_RayCast *_this, const JPH_Mat44 *inTransform)
{
    return (JPH_RayCast *)new JPH::RayCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCast *)(_this)).Transformed(
        ((inTransform ? void() : MRBINDC_THROW("Parameter `inTransform` can not be null.", void)), *(const JPH::Mat44 *)(inTransform))
    ));
}

JPH_RayCast *JPH_RayCast_Translated(const JPH_RayCast *_this, const JPH_Vec3 *inTranslation)
{
    return (JPH_RayCast *)new JPH::RayCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCast *)(_this)).Translated(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTranslation))
    ));
}

JPH_Vec3 *JPH_RayCast_GetPointOnRay(const JPH_RayCast *_this, float inFraction)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCast *)(_this)).GetPointOnRay(
        inFraction
    ));
}

const JPH_Vec3 *JPH_RRayCast_Get_mOrigin(const JPH_RRayCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RRayCast *)(_this)).mOrigin);
}

JPH_Vec3 *JPH_RRayCast_GetMutable_mOrigin(JPH_RRayCast *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RRayCast *)(_this)).mOrigin);
}

const JPH_Vec3 *JPH_RRayCast_Get_mDirection(const JPH_RRayCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RRayCast *)(_this)).mDirection);
}

JPH_Vec3 *JPH_RRayCast_GetMutable_mDirection(JPH_RRayCast *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RRayCast *)(_this)).mDirection);
}

JPH_RRayCast *JPH_RRayCast_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RRayCast;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RRayCast*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RRayCast *JPH_RRayCast_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RRayCast *)(new JPH::RRayCast[num_elems]{});
}

const JPH_RRayCast *JPH_RRayCast_OffsetPtr(const JPH_RRayCast *ptr, ptrdiff_t i)
{
    return (const JPH_RRayCast *)(((const JPH::RRayCast *)ptr) + i);
}

JPH_RRayCast *JPH_RRayCast_OffsetMutablePtr(JPH_RRayCast *ptr, ptrdiff_t i)
{
    return (JPH_RRayCast *)(((JPH::RRayCast *)ptr) + i);
}

const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RRayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(const JPH_RRayCast *object)
{
    return (const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *)(static_cast<const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *>(
        ((const JPH::RRayCast *)object)
    ));
}

JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *JPH_RRayCast_MutableUpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(JPH_RRayCast *object)
{
    return (JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *)(static_cast<JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *>(
        ((JPH::RRayCast *)object)
    ));
}

const JPH_RRayCast *JPH_RRayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(const JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *object)
{
    return (const JPH_RRayCast *)(static_cast<const JPH::RRayCast *>(
        ((const JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)object)
    ));
}

JPH_RRayCast *JPH_RRayCast_MutableStaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast *object)
{
    return (JPH_RRayCast *)(static_cast<JPH::RRayCast *>(
        ((JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast> *)object)
    ));
}

JPH_RRayCast *JPH_RRayCast_ConstructFromAnother(const JPH_RRayCast *_other)
{
    return (JPH_RRayCast *)new JPH::RRayCast(JPH::RRayCast(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::RRayCast(*(JPH::RRayCast *)_other))
    ));
}

JPH_RRayCast *JPH_RRayCast_Construct_2(const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection)
{
    return (JPH_RRayCast *)new JPH::RRayCast(JPH::RRayCast(
        ((inOrigin ? void() : MRBINDC_THROW("Parameter `inOrigin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOrigin)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    ));
}

JPH_RRayCast *JPH_RRayCast_Construct_1(const JPH_RayCast *inRay)
{
    return (JPH_RRayCast *)new JPH::RRayCast(JPH::RRayCast(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RayCast *)(inRay))
    ));
}

void JPH_RRayCast_Destroy(const JPH_RRayCast *_this)
{
    delete ((const JPH::RRayCast *)_this);
}

void JPH_RRayCast_DestroyArray(const JPH_RRayCast *_this)
{
    delete[] ((const JPH::RRayCast *)_this);
}

JPH_RayCast *JPH_RRayCast_ConvertTo_JPH_RayCast(const JPH_RRayCast *_this)
{
    return (JPH_RayCast *)new JPH::RayCast((JPH::RayCast)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RRayCast *)(_this))));
}

JPH_RRayCast *JPH_RRayCast_AssignFromAnother(JPH_RRayCast *_this, const JPH_RRayCast *_other)
{
    return (JPH_RRayCast *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RRayCast *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::RRayCast(*(JPH::RRayCast *)_other))
    ));
}

JPH_RRayCast *JPH_RRayCast_Transformed(const JPH_RRayCast *_this, const JPH_Mat44 *inTransform)
{
    return (JPH_RRayCast *)new JPH::RRayCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RRayCast *)(_this)).Transformed(
        ((inTransform ? void() : MRBINDC_THROW("Parameter `inTransform` can not be null.", void)), *(const JPH::Mat44 *)(inTransform))
    ));
}

JPH_RRayCast *JPH_RRayCast_Translated(const JPH_RRayCast *_this, const JPH_Vec3 *inTranslation)
{
    return (JPH_RRayCast *)new JPH::RRayCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RRayCast *)(_this)).Translated(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTranslation))
    ));
}

JPH_Vec3 *JPH_RRayCast_GetPointOnRay(const JPH_RRayCast *_this, float inFraction)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RRayCast *)(_this)).GetPointOnRay(
        inFraction
    ));
}

const JPH_EBackFaceMode *JPH_RayCastSettings_Get_mBackFaceModeTriangles(const JPH_RayCastSettings *_this)
{
    return (const JPH_EBackFaceMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastSettings *)(_this)).mBackFaceModeTriangles);
}

void JPH_RayCastSettings_Set_mBackFaceModeTriangles(JPH_RayCastSettings *_this, JPH_EBackFaceMode value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastSettings *)(_this)).mBackFaceModeTriangles = ((JPH::EBackFaceMode)value);
}

JPH_EBackFaceMode *JPH_RayCastSettings_GetMutable_mBackFaceModeTriangles(JPH_RayCastSettings *_this)
{
    return (JPH_EBackFaceMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastSettings *)(_this)).mBackFaceModeTriangles);
}

const JPH_EBackFaceMode *JPH_RayCastSettings_Get_mBackFaceModeConvex(const JPH_RayCastSettings *_this)
{
    return (const JPH_EBackFaceMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastSettings *)(_this)).mBackFaceModeConvex);
}

void JPH_RayCastSettings_Set_mBackFaceModeConvex(JPH_RayCastSettings *_this, JPH_EBackFaceMode value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastSettings *)(_this)).mBackFaceModeConvex = ((JPH::EBackFaceMode)value);
}

JPH_EBackFaceMode *JPH_RayCastSettings_GetMutable_mBackFaceModeConvex(JPH_RayCastSettings *_this)
{
    return (JPH_EBackFaceMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastSettings *)(_this)).mBackFaceModeConvex);
}

const bool *JPH_RayCastSettings_Get_mTreatConvexAsSolid(const JPH_RayCastSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastSettings *)(_this)).mTreatConvexAsSolid);
}

void JPH_RayCastSettings_Set_mTreatConvexAsSolid(JPH_RayCastSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastSettings *)(_this)).mTreatConvexAsSolid = value;
}

bool *JPH_RayCastSettings_GetMutable_mTreatConvexAsSolid(JPH_RayCastSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastSettings *)(_this)).mTreatConvexAsSolid);
}

JPH_RayCastSettings *JPH_RayCastSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RayCastSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RayCastSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RayCastSettings *JPH_RayCastSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RayCastSettings *)(new JPH::RayCastSettings[num_elems]{});
}

JPH_RayCastSettings *JPH_RayCastSettings_ConstructFrom(JPH_EBackFaceMode mBackFaceModeTriangles, JPH_EBackFaceMode mBackFaceModeConvex, bool mTreatConvexAsSolid)
{
    return (JPH_RayCastSettings *)new JPH::RayCastSettings(JPH::RayCastSettings{
        ((JPH::EBackFaceMode)mBackFaceModeTriangles),
        ((JPH::EBackFaceMode)mBackFaceModeConvex),
        mTreatConvexAsSolid
    });
}

const JPH_RayCastSettings *JPH_RayCastSettings_OffsetPtr(const JPH_RayCastSettings *ptr, ptrdiff_t i)
{
    return (const JPH_RayCastSettings *)(((const JPH::RayCastSettings *)ptr) + i);
}

JPH_RayCastSettings *JPH_RayCastSettings_OffsetMutablePtr(JPH_RayCastSettings *ptr, ptrdiff_t i)
{
    return (JPH_RayCastSettings *)(((JPH::RayCastSettings *)ptr) + i);
}

JPH_RayCastSettings *JPH_RayCastSettings_ConstructFromAnother(const JPH_RayCastSettings *_other)
{
    return (JPH_RayCastSettings *)new JPH::RayCastSettings(JPH::RayCastSettings(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::RayCastSettings(*(JPH::RayCastSettings *)_other))
    ));
}

void JPH_RayCastSettings_Destroy(const JPH_RayCastSettings *_this)
{
    delete ((const JPH::RayCastSettings *)_this);
}

void JPH_RayCastSettings_DestroyArray(const JPH_RayCastSettings *_this)
{
    delete[] ((const JPH::RayCastSettings *)_this);
}

JPH_RayCastSettings *JPH_RayCastSettings_AssignFromAnother(JPH_RayCastSettings *_this, const JPH_RayCastSettings *_other)
{
    return (JPH_RayCastSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastSettings *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::RayCastSettings(*(JPH::RayCastSettings *)_other))
    ));
}

void *Jolt_new_JPH_RayCastSettings_size_t(size_t inCount)
{
    return JPH::RayCastSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_RayCastSettings_void_ptr(void *inPointer)
{
    JPH::RayCastSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_RayCastSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RayCastSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_RayCastSettings_size_t(size_t inCount)
{
    return JPH::RayCastSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_RayCastSettings_void_ptr(void *inPointer)
{
    JPH::RayCastSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_RayCastSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RayCastSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_RayCastSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RayCastSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_RayCastSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RayCastSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_RayCastSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RayCastSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_RayCastSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RayCastSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_RayCastSettings_SetBackFaceMode(JPH_RayCastSettings *_this, JPH_EBackFaceMode inMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastSettings *)(_this)).SetBackFaceMode(
        ((JPH::EBackFaceMode)inMode)
    );
}

