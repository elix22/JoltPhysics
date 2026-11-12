// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/SubShapeID.h"

#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const unsigned int *JPH_SubShapeID_Get_MaxBits(void)
{
    return std::addressof(JPH::SubShapeID::MaxBits);
}

JPH_SubShapeID *JPH_SubShapeID_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SubShapeID;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SubShapeID*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SubShapeID *JPH_SubShapeID_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SubShapeID *)(new JPH::SubShapeID[num_elems]);
}

const JPH_SubShapeID *JPH_SubShapeID_OffsetPtr(const JPH_SubShapeID *ptr, ptrdiff_t i)
{
    return (const JPH_SubShapeID *)(((const JPH::SubShapeID *)ptr) + i);
}

JPH_SubShapeID *JPH_SubShapeID_OffsetMutablePtr(JPH_SubShapeID *ptr, ptrdiff_t i)
{
    return (JPH_SubShapeID *)(((JPH::SubShapeID *)ptr) + i);
}

JPH_SubShapeID *JPH_SubShapeID_ConstructFromAnother(const JPH_SubShapeID *_other)
{
    return (JPH_SubShapeID *)new JPH::SubShapeID(JPH::SubShapeID(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)_other))
    ));
}

void JPH_SubShapeID_Destroy(const JPH_SubShapeID *_this)
{
    delete ((const JPH::SubShapeID *)_this);
}

void JPH_SubShapeID_DestroyArray(const JPH_SubShapeID *_this)
{
    delete[] ((const JPH::SubShapeID *)_this);
}

JPH_SubShapeID *JPH_SubShapeID_AssignFromAnother(JPH_SubShapeID *_this, const JPH_SubShapeID *_other)
{
    return (JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SubShapeID *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)_other))
    ));
}

void *Jolt_new_JPH_SubShapeID_size_t(size_t inCount)
{
    return JPH::SubShapeID::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SubShapeID_void_ptr(void *inPointer)
{
    JPH::SubShapeID::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SubShapeID_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SubShapeID::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SubShapeID_size_t(size_t inCount)
{
    return JPH::SubShapeID::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SubShapeID_void_ptr(void *inPointer)
{
    JPH::SubShapeID::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SubShapeID_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SubShapeID::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SubShapeID_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SubShapeID::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SubShapeID_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SubShapeID::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SubShapeID_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SubShapeID::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SubShapeID_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SubShapeID::operator delete[](
        inPointer,
        inPlace
    );
}

unsigned int JPH_SubShapeID_PopID(const JPH_SubShapeID *_this, unsigned int inBits, JPH_SubShapeID *outRemainder)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SubShapeID *)(_this)).PopID(
        inBits,
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    );
}

unsigned int JPH_SubShapeID_GetValue(const JPH_SubShapeID *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SubShapeID *)(_this)).GetValue();
}

void JPH_SubShapeID_SetValue(JPH_SubShapeID *_this, unsigned int inValue)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SubShapeID *)(_this)).SetValue(
        inValue
    );
}

bool JPH_SubShapeID_IsEmpty(const JPH_SubShapeID *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SubShapeID *)(_this)).IsEmpty();
}

bool Jolt_equal_JPH_SubShapeID(const JPH_SubShapeID *_this, const JPH_SubShapeID *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SubShapeID *)(_this)).operator==(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::SubShapeID *)(inRHS))
    );
}

bool Jolt_not_equal_JPH_SubShapeID(const JPH_SubShapeID *_this, const JPH_SubShapeID *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SubShapeID *)(_this)).operator!=(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::SubShapeID *)(inRHS))
    );
}

JPH_SubShapeIDCreator *JPH_SubShapeIDCreator_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SubShapeIDCreator;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SubShapeIDCreator*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SubShapeIDCreator *JPH_SubShapeIDCreator_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SubShapeIDCreator *)(new JPH::SubShapeIDCreator[num_elems]);
}

const JPH_SubShapeIDCreator *JPH_SubShapeIDCreator_OffsetPtr(const JPH_SubShapeIDCreator *ptr, ptrdiff_t i)
{
    return (const JPH_SubShapeIDCreator *)(((const JPH::SubShapeIDCreator *)ptr) + i);
}

JPH_SubShapeIDCreator *JPH_SubShapeIDCreator_OffsetMutablePtr(JPH_SubShapeIDCreator *ptr, ptrdiff_t i)
{
    return (JPH_SubShapeIDCreator *)(((JPH::SubShapeIDCreator *)ptr) + i);
}

JPH_SubShapeIDCreator *JPH_SubShapeIDCreator_ConstructFromAnother(const JPH_SubShapeIDCreator *_other)
{
    return (JPH_SubShapeIDCreator *)new JPH::SubShapeIDCreator(JPH::SubShapeIDCreator(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SubShapeIDCreator(*(JPH::SubShapeIDCreator *)_other))
    ));
}

void JPH_SubShapeIDCreator_Destroy(const JPH_SubShapeIDCreator *_this)
{
    delete ((const JPH::SubShapeIDCreator *)_this);
}

void JPH_SubShapeIDCreator_DestroyArray(const JPH_SubShapeIDCreator *_this)
{
    delete[] ((const JPH::SubShapeIDCreator *)_this);
}

JPH_SubShapeIDCreator *JPH_SubShapeIDCreator_AssignFromAnother(JPH_SubShapeIDCreator *_this, const JPH_SubShapeIDCreator *_other)
{
    return (JPH_SubShapeIDCreator *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SubShapeIDCreator *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SubShapeIDCreator(*(JPH::SubShapeIDCreator *)_other))
    ));
}

JPH_SubShapeIDCreator *JPH_SubShapeIDCreator_PushID(const JPH_SubShapeIDCreator *_this, unsigned int inValue, unsigned int inBits)
{
    return (JPH_SubShapeIDCreator *)new JPH::SubShapeIDCreator(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(_this)).PushID(
        inValue,
        inBits
    ));
}

const JPH_SubShapeID *JPH_SubShapeIDCreator_GetID(const JPH_SubShapeIDCreator *_this)
{
    return (const JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(_this)).GetID());
}

unsigned int JPH_SubShapeIDCreator_GetNumBitsWritten(const JPH_SubShapeIDCreator *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(_this)).GetNumBitsWritten();
}

