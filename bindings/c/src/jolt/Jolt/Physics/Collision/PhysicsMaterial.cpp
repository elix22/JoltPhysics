// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/PhysicsMaterial.h"

#include <Jolt/Core/Color.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <new>
#include <stdexcept>


JPH_PhysicsMaterial *JPH_PhysicsMaterial_DefaultConstruct(void)
{
    using _mrbind_T = JPH::PhysicsMaterial;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_PhysicsMaterial*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_PhysicsMaterial *JPH_PhysicsMaterial_DefaultConstructArray(size_t num_elems)
{
    return (JPH_PhysicsMaterial *)(new JPH::PhysicsMaterial[num_elems]);
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

void *Jolt_new_JPH_PhysicsMaterial_size_t(size_t inCount)
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

void Jolt_delete_JPH_PhysicsMaterial_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PhysicsMaterial::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_PhysicsMaterial_size_t(size_t inCount)
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

void Jolt_delete_array_JPH_PhysicsMaterial_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PhysicsMaterial::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_PhysicsMaterial_size_t_void_ptr(size_t inCount, void *inPointer)
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

void *Jolt_new_array_JPH_PhysicsMaterial_size_t_void_ptr(size_t inCount, void *inPointer)
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

JPH_Color *JPH_PhysicsMaterial_GetDebugColor(const JPH_PhysicsMaterial *_this)
{
    return (JPH_Color *)new JPH::Color(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsMaterial *)(_this)).GetDebugColor());
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

