// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/PhysicsMaterialSimple.h"

#include <Jolt/Core/Color.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/PhysicsMaterialSimple.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_DefaultConstruct(void)
{
    using _mrbind_T = JPH::PhysicsMaterialSimple;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_PhysicsMaterialSimple*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_DefaultConstructArray(size_t num_elems)
{
    return (JPH_PhysicsMaterialSimple *)(new JPH::PhysicsMaterialSimple[num_elems]{});
}

const JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_OffsetPtr(const JPH_PhysicsMaterialSimple *ptr, ptrdiff_t i)
{
    return (const JPH_PhysicsMaterialSimple *)(((const JPH::PhysicsMaterialSimple *)ptr) + i);
}

JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_OffsetMutablePtr(JPH_PhysicsMaterialSimple *ptr, ptrdiff_t i)
{
    return (JPH_PhysicsMaterialSimple *)(((JPH::PhysicsMaterialSimple *)ptr) + i);
}

const JPH_SerializableObject *JPH_PhysicsMaterialSimple_UpcastTo_JPH_SerializableObject(const JPH_PhysicsMaterialSimple *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::PhysicsMaterialSimple *)object)
    ));
}

JPH_SerializableObject *JPH_PhysicsMaterialSimple_MutableUpcastTo_JPH_SerializableObject(JPH_PhysicsMaterialSimple *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::PhysicsMaterialSimple *)object)
    ));
}

const JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_PhysicsMaterialSimple *)(static_cast<const JPH::PhysicsMaterialSimple *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_PhysicsMaterialSimple *)(static_cast<JPH::PhysicsMaterialSimple *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_PhysicsMaterial *JPH_PhysicsMaterialSimple_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(const JPH_PhysicsMaterialSimple *object)
{
    return (const JPH_RefTarget_JPH_PhysicsMaterial *)(static_cast<const JPH::RefTarget<JPH::PhysicsMaterial> *>(
        ((const JPH::PhysicsMaterialSimple *)object)
    ));
}

JPH_RefTarget_JPH_PhysicsMaterial *JPH_PhysicsMaterialSimple_MutableUpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(JPH_PhysicsMaterialSimple *object)
{
    return (JPH_RefTarget_JPH_PhysicsMaterial *)(static_cast<JPH::RefTarget<JPH::PhysicsMaterial> *>(
        ((JPH::PhysicsMaterialSimple *)object)
    ));
}

const JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial(const JPH_RefTarget_JPH_PhysicsMaterial *object)
{
    return (const JPH_PhysicsMaterialSimple *)(static_cast<const JPH::PhysicsMaterialSimple *>(
        ((const JPH::RefTarget<JPH::PhysicsMaterial> *)object)
    ));
}

JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_MutableStaticDowncastFrom_JPH_RefTarget_JPH_PhysicsMaterial(JPH_RefTarget_JPH_PhysicsMaterial *object)
{
    return (JPH_PhysicsMaterialSimple *)(static_cast<JPH::PhysicsMaterialSimple *>(
        ((JPH::RefTarget<JPH::PhysicsMaterial> *)object)
    ));
}

const JPH_PhysicsMaterial *JPH_PhysicsMaterialSimple_UpcastTo_JPH_PhysicsMaterial(const JPH_PhysicsMaterialSimple *object)
{
    return (const JPH_PhysicsMaterial *)(static_cast<const JPH::PhysicsMaterial *>(
        ((const JPH::PhysicsMaterialSimple *)object)
    ));
}

JPH_PhysicsMaterial *JPH_PhysicsMaterialSimple_MutableUpcastTo_JPH_PhysicsMaterial(JPH_PhysicsMaterialSimple *object)
{
    return (JPH_PhysicsMaterial *)(static_cast<JPH::PhysicsMaterial *>(
        ((JPH::PhysicsMaterialSimple *)object)
    ));
}

const JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_StaticDowncastFrom_JPH_PhysicsMaterial(const JPH_PhysicsMaterial *object)
{
    return (const JPH_PhysicsMaterialSimple *)(static_cast<const JPH::PhysicsMaterialSimple *>(
        ((const JPH::PhysicsMaterial *)object)
    ));
}

JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_MutableStaticDowncastFrom_JPH_PhysicsMaterial(JPH_PhysicsMaterial *object)
{
    return (JPH_PhysicsMaterialSimple *)(static_cast<JPH::PhysicsMaterialSimple *>(
        ((JPH::PhysicsMaterial *)object)
    ));
}

JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_PhysicsMaterialSimple *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::PhysicsMaterialSimple);
    return (JPH_PhysicsMaterialSimple *)new JPH::PhysicsMaterialSimple(JPH::PhysicsMaterialSimple(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::PhysicsMaterialSimple) MRBINDC_CLASSARG_COPY(_other, (JPH::PhysicsMaterialSimple), JPH::PhysicsMaterialSimple) MRBINDC_CLASSARG_MOVE(_other, (JPH::PhysicsMaterialSimple), JPH::PhysicsMaterialSimple) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::PhysicsMaterialSimple) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::PhysicsMaterialSimple) MRBINDC_CLASSARG_END(_other, JPH::PhysicsMaterialSimple))
    ));
}

void JPH_PhysicsMaterialSimple_Destroy(const JPH_PhysicsMaterialSimple *_this)
{
    delete ((const JPH::PhysicsMaterialSimple *)_this);
}

void JPH_PhysicsMaterialSimple_DestroyArray(const JPH_PhysicsMaterialSimple *_this)
{
    delete[] ((const JPH::PhysicsMaterialSimple *)_this);
}

JPH_PhysicsMaterialSimple *JPH_PhysicsMaterialSimple_AssignFromAnother(JPH_PhysicsMaterialSimple *_this, Jolt_PassBy _other_pass_by, JPH_PhysicsMaterialSimple *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::PhysicsMaterialSimple);
    return (JPH_PhysicsMaterialSimple *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsMaterialSimple *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::PhysicsMaterialSimple) MRBINDC_CLASSARG_COPY(_other, (JPH::PhysicsMaterialSimple), JPH::PhysicsMaterialSimple) MRBINDC_CLASSARG_MOVE(_other, (JPH::PhysicsMaterialSimple), JPH::PhysicsMaterialSimple) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::PhysicsMaterialSimple) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::PhysicsMaterialSimple) MRBINDC_CLASSARG_END(_other, JPH::PhysicsMaterialSimple))
    ));
}

void *Jolt_new_JPH_PhysicsMaterialSimple_size_t(size_t inCount)
{
    return JPH::PhysicsMaterialSimple::operator new(
        inCount
    );
}

void Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr(void *inPointer)
{
    JPH::PhysicsMaterialSimple::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PhysicsMaterialSimple::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_PhysicsMaterialSimple_size_t(size_t inCount)
{
    return JPH::PhysicsMaterialSimple::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr(void *inPointer)
{
    JPH::PhysicsMaterialSimple::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PhysicsMaterialSimple::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_PhysicsMaterialSimple_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PhysicsMaterialSimple::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_PhysicsMaterialSimple_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PhysicsMaterialSimple::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_PhysicsMaterialSimple_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PhysicsMaterialSimple::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_PhysicsMaterialSimple_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PhysicsMaterialSimple::operator delete[](
        inPointer,
        inPlace
    );
}

const char *JPH_PhysicsMaterialSimple_GetDebugName(const JPH_PhysicsMaterialSimple *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsMaterialSimple *)(_this)).GetDebugName();
}

JPH_Color *JPH_PhysicsMaterialSimple_GetDebugColor(const JPH_PhysicsMaterialSimple *_this)
{
    return (JPH_Color *)new JPH::Color(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsMaterialSimple *)(_this)).GetDebugColor());
}

void JPH_PhysicsMaterialSimple_SetEmbedded(const JPH_PhysicsMaterialSimple *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsMaterialSimple *)(_this)).SetEmbedded();
}

unsigned int JPH_PhysicsMaterialSimple_GetRefCount(const JPH_PhysicsMaterialSimple *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsMaterialSimple *)(_this)).GetRefCount();
}

void JPH_PhysicsMaterialSimple_AddRef(const JPH_PhysicsMaterialSimple *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsMaterialSimple *)(_this)).AddRef();
}

void JPH_PhysicsMaterialSimple_Release(const JPH_PhysicsMaterialSimple *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsMaterialSimple *)(_this)).Release();
}

int JPH_PhysicsMaterialSimple_sInternalGetRefCountOffset(void)
{
    return JPH::PhysicsMaterialSimple::sInternalGetRefCountOffset();
}

