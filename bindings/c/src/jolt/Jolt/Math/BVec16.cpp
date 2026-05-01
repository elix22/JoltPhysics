// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/BVec16.h"

#include <Jolt/Math/BVec16.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <iostream>
#include <memory>
#include <new>
#include <stdexcept>


JPH_BVec16 *JPH_BVec16_DefaultConstruct(void)
{
    using _mrbind_T = JPH::BVec16;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_BVec16*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_BVec16 *JPH_BVec16_DefaultConstructArray(size_t num_elems)
{
    return (JPH_BVec16 *)(new JPH::BVec16[num_elems]{});
}

const JPH_BVec16 *JPH_BVec16_OffsetPtr(const JPH_BVec16 *ptr, ptrdiff_t i)
{
    return (const JPH_BVec16 *)(((const JPH::BVec16 *)ptr) + i);
}

JPH_BVec16 *JPH_BVec16_OffsetMutablePtr(JPH_BVec16 *ptr, ptrdiff_t i)
{
    return (JPH_BVec16 *)(((JPH::BVec16 *)ptr) + i);
}

JPH_BVec16 *JPH_BVec16_ConstructFromAnother(const JPH_BVec16 *inRHS)
{
    return (JPH_BVec16 *)new JPH::BVec16(JPH::BVec16(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::BVec16(*(JPH::BVec16 *)inRHS))
    ));
}

JPH_BVec16 *JPH_BVec16_Construct_16(unsigned char inB0, unsigned char inB1, unsigned char inB2, unsigned char inB3, unsigned char inB4, unsigned char inB5, unsigned char inB6, unsigned char inB7, unsigned char inB8, unsigned char inB9, unsigned char inB10, unsigned char inB11, unsigned char inB12, unsigned char inB13, unsigned char inB14, unsigned char inB15)
{
    return (JPH_BVec16 *)new JPH::BVec16(JPH::BVec16(
        inB0,
        inB1,
        inB2,
        inB3,
        inB4,
        inB5,
        inB6,
        inB7,
        inB8,
        inB9,
        inB10,
        inB11,
        inB12,
        inB13,
        inB14,
        inB15
    ));
}

JPH_BVec16 *JPH_BVec16_Construct_2(uint64_t inV0, uint64_t inV1)
{
    return (JPH_BVec16 *)new JPH::BVec16(JPH::BVec16(
        inV0,
        inV1
    ));
}

void JPH_BVec16_Destroy(const JPH_BVec16 *_this)
{
    delete ((const JPH::BVec16 *)_this);
}

void JPH_BVec16_DestroyArray(const JPH_BVec16 *_this)
{
    delete[] ((const JPH::BVec16 *)_this);
}

JPH_BVec16 *JPH_BVec16_AssignFromAnother(JPH_BVec16 *_this, const JPH_BVec16 *inRHS)
{
    return (JPH_BVec16 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BVec16 *)(_this)).operator=(
        mrbindc_details::unmove(((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), JPH::BVec16(*(JPH::BVec16 *)inRHS)))
    ));
}

void *Jolt_new_JPH_BVec16_size_t(size_t inCount)
{
    return JPH::BVec16::operator new(
        inCount
    );
}

void Jolt_delete_JPH_BVec16_void_ptr(void *inPointer)
{
    JPH::BVec16::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_BVec16_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BVec16::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_BVec16_size_t(size_t inCount)
{
    return JPH::BVec16::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_BVec16_void_ptr(void *inPointer)
{
    JPH::BVec16::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_BVec16_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BVec16::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_BVec16_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BVec16::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_BVec16_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BVec16::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_BVec16_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BVec16::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_BVec16_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BVec16::operator delete[](
        inPointer,
        inPlace
    );
}

bool Jolt_equal_JPH_BVec16(const JPH_BVec16 *_this, const JPH_BVec16 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BVec16 *)(_this)).operator==(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::BVec16(*(JPH::BVec16 *)inV2))
    );
}

bool Jolt_not_equal_JPH_BVec16(const JPH_BVec16 *_this, const JPH_BVec16 *inV2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BVec16 *)(_this)).operator!=(
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::BVec16(*(JPH::BVec16 *)inV2))
    );
}

JPH_BVec16 *JPH_BVec16_sZero(void)
{
    return (JPH_BVec16 *)new JPH::BVec16(JPH::BVec16::sZero());
}

JPH_BVec16 *JPH_BVec16_sReplicate(unsigned char inV)
{
    return (JPH_BVec16 *)new JPH::BVec16(JPH::BVec16::sReplicate(
        inV
    ));
}

JPH_BVec16 *JPH_BVec16_sLoadByte16(const unsigned char *inV)
{
    return (JPH_BVec16 *)new JPH::BVec16(JPH::BVec16::sLoadByte16(
        inV
    ));
}

JPH_BVec16 *JPH_BVec16_sEquals(const JPH_BVec16 *inV1, const JPH_BVec16 *inV2)
{
    return (JPH_BVec16 *)new JPH::BVec16(JPH::BVec16::sEquals(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::BVec16(*(JPH::BVec16 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::BVec16(*(JPH::BVec16 *)inV2))
    ));
}

JPH_BVec16 *JPH_BVec16_sOr(const JPH_BVec16 *inV1, const JPH_BVec16 *inV2)
{
    return (JPH_BVec16 *)new JPH::BVec16(JPH::BVec16::sOr(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::BVec16(*(JPH::BVec16 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::BVec16(*(JPH::BVec16 *)inV2))
    ));
}

JPH_BVec16 *JPH_BVec16_sXor(const JPH_BVec16 *inV1, const JPH_BVec16 *inV2)
{
    return (JPH_BVec16 *)new JPH::BVec16(JPH::BVec16::sXor(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::BVec16(*(JPH::BVec16 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::BVec16(*(JPH::BVec16 *)inV2))
    ));
}

JPH_BVec16 *JPH_BVec16_sAnd(const JPH_BVec16 *inV1, const JPH_BVec16 *inV2)
{
    return (JPH_BVec16 *)new JPH::BVec16(JPH::BVec16::sAnd(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::BVec16(*(JPH::BVec16 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::BVec16(*(JPH::BVec16 *)inV2))
    ));
}

JPH_BVec16 *JPH_BVec16_sNot(const JPH_BVec16 *inV1)
{
    return (JPH_BVec16 *)new JPH::BVec16(JPH::BVec16::sNot(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::BVec16(*(JPH::BVec16 *)inV1))
    ));
}

unsigned char JPH_BVec16_index(const JPH_BVec16 *_this, unsigned int inCoordinate)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BVec16 *)(_this)).operator[](
        inCoordinate
    );
}

unsigned char *JPH_BVec16_index_mut(JPH_BVec16 *_this, unsigned int inCoordinate)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BVec16 *)(_this)).operator[](
        inCoordinate
    ));
}

bool JPH_BVec16_TestAnyTrue(const JPH_BVec16 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BVec16 *)(_this)).TestAnyTrue();
}

bool JPH_BVec16_TestAllTrue(const JPH_BVec16 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BVec16 *)(_this)).TestAllTrue();
}

int JPH_BVec16_GetTrues(const JPH_BVec16 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BVec16 *)(_this)).GetTrues();
}

Jolt_std_ostream *Jolt_print_JPH_BVec16(Jolt_std_ostream *inStream, const JPH_BVec16 *inV)
{
    return (Jolt_std_ostream *)std::addressof(operator<<(
        ((inStream ? void() : MRBINDC_THROW("Parameter `inStream` can not be null.", void)), *(std::ostream *)(inStream)),
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::BVec16(*(JPH::BVec16 *)inV))
    ));
}

