// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Character/CharacterID.h"

#include <Jolt/Physics/Character/CharacterID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const unsigned int *JPH_CharacterID_Get_cInvalidCharacterID(void)
{
    return std::addressof(JPH::CharacterID::cInvalidCharacterID);
}

JPH_CharacterID *JPH_CharacterID_DefaultConstruct(void)
{
    using _mrbind_T = JPH::CharacterID;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_CharacterID*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_CharacterID *JPH_CharacterID_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CharacterID *)(new JPH::CharacterID[num_elems]{});
}

const JPH_CharacterID *JPH_CharacterID_OffsetPtr(const JPH_CharacterID *ptr, ptrdiff_t i)
{
    return (const JPH_CharacterID *)(((const JPH::CharacterID *)ptr) + i);
}

JPH_CharacterID *JPH_CharacterID_OffsetMutablePtr(JPH_CharacterID *ptr, ptrdiff_t i)
{
    return (JPH_CharacterID *)(((JPH::CharacterID *)ptr) + i);
}

JPH_CharacterID *JPH_CharacterID_ConstructFromAnother(const JPH_CharacterID *_other)
{
    return (JPH_CharacterID *)new JPH::CharacterID(JPH::CharacterID(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::CharacterID(*(JPH::CharacterID *)_other))
    ));
}

JPH_CharacterID *JPH_CharacterID_Construct(unsigned int inID)
{
    return (JPH_CharacterID *)new JPH::CharacterID(JPH::CharacterID(
        inID
    ));
}

void JPH_CharacterID_Destroy(const JPH_CharacterID *_this)
{
    delete ((const JPH::CharacterID *)_this);
}

void JPH_CharacterID_DestroyArray(const JPH_CharacterID *_this)
{
    delete[] ((const JPH::CharacterID *)_this);
}

JPH_CharacterID *JPH_CharacterID_AssignFromAnother(JPH_CharacterID *_this, const JPH_CharacterID *_other)
{
    return (JPH_CharacterID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterID *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::CharacterID(*(JPH::CharacterID *)_other))
    ));
}

void *Jolt_new_JPH_CharacterID_size_t(size_t inCount)
{
    return JPH::CharacterID::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CharacterID_void_ptr(void *inPointer)
{
    JPH::CharacterID::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CharacterID_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CharacterID::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CharacterID_size_t(size_t inCount)
{
    return JPH::CharacterID::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CharacterID_void_ptr(void *inPointer)
{
    JPH::CharacterID::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CharacterID_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CharacterID::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CharacterID_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CharacterID::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CharacterID_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CharacterID::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CharacterID_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CharacterID::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CharacterID_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CharacterID::operator delete[](
        inPointer,
        inPlace
    );
}

unsigned int JPH_CharacterID_GetValue(const JPH_CharacterID *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterID *)(_this)).GetValue();
}

bool JPH_CharacterID_IsInvalid(const JPH_CharacterID *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterID *)(_this)).IsInvalid();
}

bool Jolt_equal_JPH_CharacterID(const JPH_CharacterID *_this, const JPH_CharacterID *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterID *)(_this)).operator==(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::CharacterID *)(inRHS))
    );
}

bool Jolt_not_equal_JPH_CharacterID(const JPH_CharacterID *_this, const JPH_CharacterID *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterID *)(_this)).operator!=(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::CharacterID *)(inRHS))
    );
}

bool Jolt_less_JPH_CharacterID(const JPH_CharacterID *_this, const JPH_CharacterID *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterID *)(_this)).operator<(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::CharacterID *)(inRHS))
    );
}

bool Jolt_greater_JPH_CharacterID(const JPH_CharacterID *_this, const JPH_CharacterID *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterID *)(_this)).operator>(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::CharacterID *)(inRHS))
    );
}

uint64_t JPH_CharacterID_GetHash(const JPH_CharacterID *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterID *)(_this)).GetHash();
}

JPH_CharacterID *JPH_CharacterID_sNextCharacterID(void)
{
    return (JPH_CharacterID *)new JPH::CharacterID(JPH::CharacterID::sNextCharacterID());
}

void JPH_CharacterID_sSetNextCharacterID(const unsigned int *inNextValue)
{
    using namespace JPH;
    JPH::CharacterID::sSetNextCharacterID(
        (inNextValue ? *inNextValue : static_cast<unsigned int>(1))
    );
}

