// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Vehicle/VehicleAntiRollBar.h"

#include <Jolt/Physics/Vehicle/VehicleAntiRollBar.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const int *JPH_VehicleAntiRollBar_Get_mLeftWheel(const JPH_VehicleAntiRollBar *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleAntiRollBar *)(_this)).mLeftWheel);
}

void JPH_VehicleAntiRollBar_Set_mLeftWheel(JPH_VehicleAntiRollBar *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleAntiRollBar *)(_this)).mLeftWheel = value;
}

int *JPH_VehicleAntiRollBar_GetMutable_mLeftWheel(JPH_VehicleAntiRollBar *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleAntiRollBar *)(_this)).mLeftWheel);
}

const int *JPH_VehicleAntiRollBar_Get_mRightWheel(const JPH_VehicleAntiRollBar *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleAntiRollBar *)(_this)).mRightWheel);
}

void JPH_VehicleAntiRollBar_Set_mRightWheel(JPH_VehicleAntiRollBar *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleAntiRollBar *)(_this)).mRightWheel = value;
}

int *JPH_VehicleAntiRollBar_GetMutable_mRightWheel(JPH_VehicleAntiRollBar *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleAntiRollBar *)(_this)).mRightWheel);
}

const float *JPH_VehicleAntiRollBar_Get_mStiffness(const JPH_VehicleAntiRollBar *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleAntiRollBar *)(_this)).mStiffness);
}

void JPH_VehicleAntiRollBar_Set_mStiffness(JPH_VehicleAntiRollBar *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleAntiRollBar *)(_this)).mStiffness = value;
}

float *JPH_VehicleAntiRollBar_GetMutable_mStiffness(JPH_VehicleAntiRollBar *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleAntiRollBar *)(_this)).mStiffness);
}

JPH_VehicleAntiRollBar *JPH_VehicleAntiRollBar_DefaultConstruct(void)
{
    using _mrbind_T = JPH::VehicleAntiRollBar;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_VehicleAntiRollBar*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_VehicleAntiRollBar *JPH_VehicleAntiRollBar_DefaultConstructArray(size_t num_elems)
{
    return (JPH_VehicleAntiRollBar *)(new JPH::VehicleAntiRollBar[num_elems]);
}

JPH_VehicleAntiRollBar *JPH_VehicleAntiRollBar_ConstructFrom(int mLeftWheel, int mRightWheel, float mStiffness)
{
    return (JPH_VehicleAntiRollBar *)new JPH::VehicleAntiRollBar(JPH::VehicleAntiRollBar{
        mLeftWheel,
        mRightWheel,
        mStiffness
    });
}

const JPH_VehicleAntiRollBar *JPH_VehicleAntiRollBar_OffsetPtr(const JPH_VehicleAntiRollBar *ptr, ptrdiff_t i)
{
    return (const JPH_VehicleAntiRollBar *)(((const JPH::VehicleAntiRollBar *)ptr) + i);
}

JPH_VehicleAntiRollBar *JPH_VehicleAntiRollBar_OffsetMutablePtr(JPH_VehicleAntiRollBar *ptr, ptrdiff_t i)
{
    return (JPH_VehicleAntiRollBar *)(((JPH::VehicleAntiRollBar *)ptr) + i);
}

JPH_VehicleAntiRollBar *JPH_VehicleAntiRollBar_ConstructFromAnother(const JPH_VehicleAntiRollBar *_other)
{
    return (JPH_VehicleAntiRollBar *)new JPH::VehicleAntiRollBar(JPH::VehicleAntiRollBar(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::VehicleAntiRollBar(*(JPH::VehicleAntiRollBar *)_other))
    ));
}

void JPH_VehicleAntiRollBar_Destroy(const JPH_VehicleAntiRollBar *_this)
{
    delete ((const JPH::VehicleAntiRollBar *)_this);
}

void JPH_VehicleAntiRollBar_DestroyArray(const JPH_VehicleAntiRollBar *_this)
{
    delete[] ((const JPH::VehicleAntiRollBar *)_this);
}

JPH_VehicleAntiRollBar *JPH_VehicleAntiRollBar_AssignFromAnother(JPH_VehicleAntiRollBar *_this, const JPH_VehicleAntiRollBar *_other)
{
    return (JPH_VehicleAntiRollBar *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleAntiRollBar *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::VehicleAntiRollBar(*(JPH::VehicleAntiRollBar *)_other))
    ));
}

void *Jolt_new_JPH_VehicleAntiRollBar_size_t(size_t inCount)
{
    return JPH::VehicleAntiRollBar::operator new(
        inCount
    );
}

void Jolt_delete_JPH_VehicleAntiRollBar_void_ptr(void *inPointer)
{
    JPH::VehicleAntiRollBar::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_VehicleAntiRollBar_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleAntiRollBar::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_VehicleAntiRollBar_size_t(size_t inCount)
{
    return JPH::VehicleAntiRollBar::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr(void *inPointer)
{
    JPH::VehicleAntiRollBar::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleAntiRollBar::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_VehicleAntiRollBar_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleAntiRollBar::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_VehicleAntiRollBar_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleAntiRollBar::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_VehicleAntiRollBar_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleAntiRollBar::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleAntiRollBar_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleAntiRollBar::operator delete[](
        inPointer,
        inPlace
    );
}

