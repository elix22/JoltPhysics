// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Body/BodyID.h"

#include <Jolt/Physics/Body/BodyID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


const unsigned int *JPH_BodyID_Get_cInvalidBodyID(void)
{
    return std::addressof(JPH::BodyID::cInvalidBodyID);
}

const unsigned int *JPH_BodyID_Get_cBroadPhaseBit(void)
{
    return std::addressof(JPH::BodyID::cBroadPhaseBit);
}

const unsigned int *JPH_BodyID_Get_cMaxBodyIndex(void)
{
    return std::addressof(JPH::BodyID::cMaxBodyIndex);
}

const unsigned char *JPH_BodyID_Get_cMaxSequenceNumber(void)
{
    return std::addressof(JPH::BodyID::cMaxSequenceNumber);
}

const unsigned int *JPH_BodyID_Get_cSequenceNumberShift(void)
{
    return std::addressof(JPH::BodyID::cSequenceNumberShift);
}

JPH_BodyID JPH_BodyID_DefaultConstruct(void)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), JPH::BodyID());
}

JPH_BodyID *JPH_BodyID_DefaultConstructArray(size_t num_elems)
{
    return (JPH_BodyID *)(new JPH::BodyID[num_elems]);
}

JPH_BodyID JPH_BodyID_Construct_1(unsigned int inID)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), JPH::BodyID(
        inID
    ));
}

JPH_BodyID JPH_BodyID_Construct_2(unsigned int inID, unsigned char inSequenceNumber)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), JPH::BodyID(
        inID,
        inSequenceNumber
    ));
}

void *Jolt_new_JPH_BodyID_size_t(size_t inCount)
{
    return JPH::BodyID::operator new(
        inCount
    );
}

void Jolt_delete_JPH_BodyID_void_ptr(void *inPointer)
{
    JPH::BodyID::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_BodyID_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BodyID::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_BodyID_size_t(size_t inCount)
{
    return JPH::BodyID::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_BodyID_void_ptr(void *inPointer)
{
    JPH::BodyID::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_BodyID_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BodyID::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_BodyID_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BodyID::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_BodyID_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BodyID::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_BodyID_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BodyID::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_BodyID_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BodyID::operator delete[](
        inPointer,
        inPlace
    );
}

unsigned int JPH_BodyID_GetIndex(const JPH_BodyID *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyID *)(_this)).GetIndex();
}

unsigned char JPH_BodyID_GetSequenceNumber(const JPH_BodyID *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyID *)(_this)).GetSequenceNumber();
}

unsigned int JPH_BodyID_GetIndexAndSequenceNumber(const JPH_BodyID *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyID *)(_this)).GetIndexAndSequenceNumber();
}

bool JPH_BodyID_IsInvalid(const JPH_BodyID *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyID *)(_this)).IsInvalid();
}

bool Jolt_equal_JPH_BodyID(const JPH_BodyID *_this, const JPH_BodyID *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyID *)(_this)).operator==(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::BodyID *)(inRHS))
    );
}

bool Jolt_not_equal_JPH_BodyID(const JPH_BodyID *_this, const JPH_BodyID *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyID *)(_this)).operator!=(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::BodyID *)(inRHS))
    );
}

bool Jolt_less_JPH_BodyID(const JPH_BodyID *_this, const JPH_BodyID *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyID *)(_this)).operator<(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::BodyID *)(inRHS))
    );
}

bool Jolt_greater_JPH_BodyID(const JPH_BodyID *_this, const JPH_BodyID *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyID *)(_this)).operator>(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::BodyID *)(inRHS))
    );
}

