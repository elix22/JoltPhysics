// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/ObjectStream/SerializableObject.h"

#include <Jolt/ObjectStream/SerializableObject.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


void JPH_SerializableObject_Destroy(const JPH_SerializableObject *_this)
{
    delete ((const JPH::SerializableObject *)_this);
}

void JPH_SerializableObject_DestroyArray(const JPH_SerializableObject *_this)
{
    delete[] ((const JPH::SerializableObject *)_this);
}

void *Jolt_new_JPH_SerializableObject_size_t(unsigned long inCount)
{
    return JPH::SerializableObject::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SerializableObject_void_ptr(void *inPointer)
{
    JPH::SerializableObject::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SerializableObject_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SerializableObject::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SerializableObject_size_t(unsigned long inCount)
{
    return JPH::SerializableObject::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SerializableObject_void_ptr(void *inPointer)
{
    JPH::SerializableObject::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SerializableObject_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SerializableObject::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SerializableObject_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SerializableObject::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SerializableObject_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SerializableObject::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SerializableObject_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SerializableObject::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SerializableObject_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SerializableObject::operator delete[](
        inPointer,
        inPlace
    );
}

const JPH_SerializableObject *JPH_SerializableObject_OffsetPtr(const JPH_SerializableObject *ptr, ptrdiff_t i)
{
    return (const JPH_SerializableObject *)(((const JPH::SerializableObject *)ptr) + i);
}

JPH_SerializableObject *JPH_SerializableObject_OffsetMutablePtr(JPH_SerializableObject *ptr, ptrdiff_t i)
{
    return (JPH_SerializableObject *)(((JPH::SerializableObject *)ptr) + i);
}

