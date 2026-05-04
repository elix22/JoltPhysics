// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/SpringSettings.h"

#include <Jolt/Physics/Constraints/SpringSettings.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_ESpringMode *JPH_SpringSettings_Get_mMode(const JPH_SpringSettings *_this)
{
    return (const JPH_ESpringMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SpringSettings *)(_this)).mMode);
}

void JPH_SpringSettings_Set_mMode(JPH_SpringSettings *_this, JPH_ESpringMode value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SpringSettings *)(_this)).mMode = ((JPH::ESpringMode)value);
}

JPH_ESpringMode *JPH_SpringSettings_GetMutable_mMode(JPH_SpringSettings *_this)
{
    return (JPH_ESpringMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SpringSettings *)(_this)).mMode);
}

const float *JPH_SpringSettings_Get_mFrequency(const JPH_SpringSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SpringSettings *)(_this)).mFrequency);
}

void JPH_SpringSettings_Set_mFrequency(JPH_SpringSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SpringSettings *)(_this)).mFrequency = value;
}

float *JPH_SpringSettings_GetMutable_mFrequency(JPH_SpringSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SpringSettings *)(_this)).mFrequency);
}

const float *JPH_SpringSettings_Get_mStiffness(const JPH_SpringSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SpringSettings *)(_this)).mStiffness);
}

void JPH_SpringSettings_Set_mStiffness(JPH_SpringSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SpringSettings *)(_this)).mStiffness = value;
}

float *JPH_SpringSettings_GetMutable_mStiffness(JPH_SpringSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SpringSettings *)(_this)).mStiffness);
}

const float *JPH_SpringSettings_Get_mDamping(const JPH_SpringSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SpringSettings *)(_this)).mDamping);
}

void JPH_SpringSettings_Set_mDamping(JPH_SpringSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SpringSettings *)(_this)).mDamping = value;
}

float *JPH_SpringSettings_GetMutable_mDamping(JPH_SpringSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SpringSettings *)(_this)).mDamping);
}

JPH_SpringSettings *JPH_SpringSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SpringSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SpringSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SpringSettings *JPH_SpringSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SpringSettings *)(new JPH::SpringSettings[num_elems]);
}

const JPH_SpringSettings *JPH_SpringSettings_OffsetPtr(const JPH_SpringSettings *ptr, ptrdiff_t i)
{
    return (const JPH_SpringSettings *)(((const JPH::SpringSettings *)ptr) + i);
}

JPH_SpringSettings *JPH_SpringSettings_OffsetMutablePtr(JPH_SpringSettings *ptr, ptrdiff_t i)
{
    return (JPH_SpringSettings *)(((JPH::SpringSettings *)ptr) + i);
}

JPH_SpringSettings *JPH_SpringSettings_ConstructFromAnother(const JPH_SpringSettings *_other)
{
    return (JPH_SpringSettings *)new JPH::SpringSettings(JPH::SpringSettings(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SpringSettings(*(JPH::SpringSettings *)_other))
    ));
}

JPH_SpringSettings *JPH_SpringSettings_Construct(JPH_ESpringMode inMode, float inFrequencyOrStiffness, float inDamping)
{
    return (JPH_SpringSettings *)new JPH::SpringSettings(JPH::SpringSettings(
        ((JPH::ESpringMode)inMode),
        inFrequencyOrStiffness,
        inDamping
    ));
}

void JPH_SpringSettings_Destroy(const JPH_SpringSettings *_this)
{
    delete ((const JPH::SpringSettings *)_this);
}

void JPH_SpringSettings_DestroyArray(const JPH_SpringSettings *_this)
{
    delete[] ((const JPH::SpringSettings *)_this);
}

JPH_SpringSettings *JPH_SpringSettings_AssignFromAnother(JPH_SpringSettings *_this, const JPH_SpringSettings *_other)
{
    return (JPH_SpringSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SpringSettings *)(_this)).operator=(
        mrbindc_details::unmove(((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SpringSettings(*(JPH::SpringSettings *)_other)))
    ));
}

void *Jolt_new_JPH_SpringSettings_size_t(size_t inCount)
{
    return JPH::SpringSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SpringSettings_void_ptr(void *inPointer)
{
    JPH::SpringSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SpringSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SpringSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SpringSettings_size_t(size_t inCount)
{
    return JPH::SpringSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SpringSettings_void_ptr(void *inPointer)
{
    JPH::SpringSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SpringSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SpringSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SpringSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SpringSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SpringSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SpringSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SpringSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SpringSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SpringSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SpringSettings::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_SpringSettings_HasStiffness(const JPH_SpringSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SpringSettings *)(_this)).HasStiffness();
}

