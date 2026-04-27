// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/PhysicsMaterial.h"

#include <Jolt/Core/Reference.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


JPH_PhysicsMaterial *JPH_PhysicsMaterial_DefaultConstruct(void)
{
    return (JPH_PhysicsMaterial *)new JPH::PhysicsMaterial(JPH::PhysicsMaterial());
}

JPH_PhysicsMaterial *JPH_PhysicsMaterial_DefaultConstructArray(size_t num_elems)
{
    return (JPH_PhysicsMaterial *)(new JPH::PhysicsMaterial[num_elems]{});
}

const JPH_PhysicsMaterial *JPH_PhysicsMaterial_OffsetPtr(const JPH_PhysicsMaterial *ptr, ptrdiff_t i)
{
    return (const JPH_PhysicsMaterial *)(((const JPH::PhysicsMaterial *)ptr) + i);
}

JPH_PhysicsMaterial *JPH_PhysicsMaterial_OffsetMutablePtr(JPH_PhysicsMaterial *ptr, ptrdiff_t i)
{
    return (JPH_PhysicsMaterial *)(((JPH::PhysicsMaterial *)ptr) + i);
}

const JPH_SerializableObject *JPH_PhysicsMaterial_UpcastTo_JPH_SerializableObject(const JPH_PhysicsMaterial *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::PhysicsMaterial *)object)
    ));
}

JPH_SerializableObject *JPH_PhysicsMaterial_MutableUpcastTo_JPH_SerializableObject(JPH_PhysicsMaterial *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::PhysicsMaterial *)object)
    ));
}

const JPH_PhysicsMaterial *JPH_PhysicsMaterial_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_PhysicsMaterial *)(static_cast<const JPH::PhysicsMaterial *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_PhysicsMaterial *JPH_PhysicsMaterial_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_PhysicsMaterial *)(static_cast<JPH::PhysicsMaterial *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_PhysicsMaterial *JPH_PhysicsMaterial_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(const JPH_PhysicsMaterial *object)
{
    return (const JPH_RefTarget_JPH_PhysicsMaterial *)(static_cast<const JPH::RefTarget<JPH::PhysicsMaterial> *>(
        ((const JPH::PhysicsMaterial *)object)
    ));
}

JPH_RefTarget_JPH_PhysicsMaterial *JPH_PhysicsMaterial_MutableUpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(JPH_PhysicsMaterial *object)
{
    return (JPH_RefTarget_JPH_PhysicsMaterial *)(static_cast<JPH::RefTarget<JPH::PhysicsMaterial> *>(
        ((JPH::PhysicsMaterial *)object)
    ));
}

const JPH_PhysicsMaterial *JPH_PhysicsMaterial_StaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial(const JPH_RefTarget_JPH_PhysicsMaterial *object)
{
    return (const JPH_PhysicsMaterial *)(static_cast<const JPH::PhysicsMaterial *>(
        ((const JPH::RefTarget<JPH::PhysicsMaterial> *)object)
    ));
}

JPH_PhysicsMaterial *JPH_PhysicsMaterial_MutableStaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial(JPH_RefTarget_JPH_PhysicsMaterial *object)
{
    return (JPH_PhysicsMaterial *)(static_cast<JPH::PhysicsMaterial *>(
        ((JPH::RefTarget<JPH::PhysicsMaterial> *)object)
    ));
}

void JPH_PhysicsMaterial_Destroy(const JPH_PhysicsMaterial *_this)
{
    delete ((const JPH::PhysicsMaterial *)_this);
}

void JPH_PhysicsMaterial_DestroyArray(const JPH_PhysicsMaterial *_this)
{
    delete[] ((const JPH::PhysicsMaterial *)_this);
}

void *Jolt_new_JPH_PhysicsMaterial_unsigned_long(unsigned long inCount)
{
    return JPH::PhysicsMaterial::operator new(
        inCount
    );
}

void Jolt_delete_JPH_PhysicsMaterial_void_ptr(void *inPointer)
{
    JPH::PhysicsMaterial::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_PhysicsMaterial_void_ptr_unsigned_long(void *inPointer, unsigned long inSize)
{
    JPH::PhysicsMaterial::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_PhysicsMaterial_unsigned_long(unsigned long inCount)
{
    return JPH::PhysicsMaterial::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_PhysicsMaterial_void_ptr(void *inPointer)
{
    JPH::PhysicsMaterial::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_PhysicsMaterial_void_ptr_unsigned_long(void *inPointer, unsigned long inSize)
{
    JPH::PhysicsMaterial::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_PhysicsMaterial_unsigned_long_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::PhysicsMaterial::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_PhysicsMaterial_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PhysicsMaterial::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_PhysicsMaterial_unsigned_long_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::PhysicsMaterial::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_PhysicsMaterial_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PhysicsMaterial::operator delete[](
        inPointer,
        inPlace
    );
}

const char *JPH_PhysicsMaterial_GetDebugName(const JPH_PhysicsMaterial *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsMaterial *)(_this)).GetDebugName();
}

void JPH_PhysicsMaterial_SetEmbedded(const JPH_PhysicsMaterial *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsMaterial *)(_this)).SetEmbedded();
}

unsigned int JPH_PhysicsMaterial_GetRefCount(const JPH_PhysicsMaterial *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsMaterial *)(_this)).GetRefCount();
}

void JPH_PhysicsMaterial_AddRef(const JPH_PhysicsMaterial *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsMaterial *)(_this)).AddRef();
}

void JPH_PhysicsMaterial_Release(const JPH_PhysicsMaterial *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsMaterial *)(_this)).Release();
}

int JPH_PhysicsMaterial_sInternalGetRefCountOffset(void)
{
    return JPH::PhysicsMaterial::sInternalGetRefCountOffset();
}

