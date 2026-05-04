// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/AABoxCast.h"

#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Collision/AABoxCast.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_AABox *JPH_AABoxCast_Get_mBox(const JPH_AABoxCast *_this)
{
    return (const JPH_AABox *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABoxCast *)(_this)).mBox);
}

void JPH_AABoxCast_Set_mBox(JPH_AABoxCast *_this, const JPH_AABox *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::AABoxCast *)(_this)).mBox = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::AABox(*(JPH::AABox *)value));
}

JPH_AABox *JPH_AABoxCast_GetMutable_mBox(JPH_AABoxCast *_this)
{
    return (JPH_AABox *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::AABoxCast *)(_this)).mBox);
}

const JPH_Vec3 *JPH_AABoxCast_Get_mDirection(const JPH_AABoxCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABoxCast *)(_this)).mDirection);
}

JPH_Vec3 *JPH_AABoxCast_GetMutable_mDirection(JPH_AABoxCast *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::AABoxCast *)(_this)).mDirection);
}

JPH_AABoxCast *JPH_AABoxCast_DefaultConstruct(void)
{
    using _mrbind_T = JPH::AABoxCast;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_AABoxCast*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_AABoxCast *JPH_AABoxCast_DefaultConstructArray(size_t num_elems)
{
    return (JPH_AABoxCast *)(new JPH::AABoxCast[num_elems]{});
}

JPH_AABoxCast *JPH_AABoxCast_ConstructFrom(const JPH_AABox *mBox, const JPH_Vec3 *mDirection)
{
    return (JPH_AABoxCast *)new JPH::AABoxCast(JPH::AABoxCast{
        ((mBox ? void() : MRBINDC_THROW("Parameter `mBox` can not be null.", void)), JPH::AABox(*(JPH::AABox *)mBox)),
        ((mDirection ? void() : MRBINDC_THROW("Parameter `mDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mDirection))
    });
}

const JPH_AABoxCast *JPH_AABoxCast_OffsetPtr(const JPH_AABoxCast *ptr, ptrdiff_t i)
{
    return (const JPH_AABoxCast *)(((const JPH::AABoxCast *)ptr) + i);
}

JPH_AABoxCast *JPH_AABoxCast_OffsetMutablePtr(JPH_AABoxCast *ptr, ptrdiff_t i)
{
    return (JPH_AABoxCast *)(((JPH::AABoxCast *)ptr) + i);
}

JPH_AABoxCast *JPH_AABoxCast_ConstructFromAnother(const JPH_AABoxCast *_other)
{
    return (JPH_AABoxCast *)new JPH::AABoxCast(JPH::AABoxCast(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::AABoxCast(*(JPH::AABoxCast *)_other))
    ));
}

void JPH_AABoxCast_Destroy(const JPH_AABoxCast *_this)
{
    delete ((const JPH::AABoxCast *)_this);
}

void JPH_AABoxCast_DestroyArray(const JPH_AABoxCast *_this)
{
    delete[] ((const JPH::AABoxCast *)_this);
}

JPH_AABoxCast *JPH_AABoxCast_AssignFromAnother(JPH_AABoxCast *_this, const JPH_AABoxCast *_other)
{
    return (JPH_AABoxCast *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::AABoxCast *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::AABoxCast(*(JPH::AABoxCast *)_other))
    ));
}

void *Jolt_new_JPH_AABoxCast_size_t(size_t inCount)
{
    return JPH::AABoxCast::operator new(
        inCount
    );
}

void Jolt_delete_JPH_AABoxCast_void_ptr(void *inPointer)
{
    JPH::AABoxCast::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_AABoxCast_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::AABoxCast::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_AABoxCast_size_t(size_t inCount)
{
    return JPH::AABoxCast::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_AABoxCast_void_ptr(void *inPointer)
{
    JPH::AABoxCast::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_AABoxCast_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::AABoxCast::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_AABoxCast_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::AABoxCast::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_AABoxCast_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::AABoxCast::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_AABoxCast_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::AABoxCast::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_AABoxCast_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::AABoxCast::operator delete[](
        inPointer,
        inPlace
    );
}

