// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Core/Factory.h"

#include <Jolt/Core/Factory.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


JPH_Factory *const *JPH_Factory_Get_sInstance(void)
{
    return (JPH_Factory *const *)std::addressof(JPH::Factory::sInstance);
}

void JPH_Factory_Set_sInstance(JPH_Factory *value)
{
    JPH::Factory::sInstance = ((JPH::Factory *)value);
}

JPH_Factory **JPH_Factory_GetMutable_sInstance(void)
{
    return (JPH_Factory **)std::addressof(JPH::Factory::sInstance);
}

JPH_Factory *JPH_Factory_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Factory;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_Factory*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_Factory *JPH_Factory_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Factory *)(new JPH::Factory[num_elems]);
}

const JPH_Factory *JPH_Factory_OffsetPtr(const JPH_Factory *ptr, ptrdiff_t i)
{
    return (const JPH_Factory *)(((const JPH::Factory *)ptr) + i);
}

JPH_Factory *JPH_Factory_OffsetMutablePtr(JPH_Factory *ptr, ptrdiff_t i)
{
    return (JPH_Factory *)(((JPH::Factory *)ptr) + i);
}

JPH_Factory *JPH_Factory_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_Factory *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::Factory);
    return (JPH_Factory *)new JPH::Factory(JPH::Factory(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::Factory) MRBINDC_CLASSARG_COPY(_other, (JPH::Factory), JPH::Factory) MRBINDC_CLASSARG_MOVE(_other, (JPH::Factory), JPH::Factory) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::Factory) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::Factory) MRBINDC_CLASSARG_END(_other, JPH::Factory))
    ));
}

void JPH_Factory_Destroy(const JPH_Factory *_this)
{
    delete ((const JPH::Factory *)_this);
}

void JPH_Factory_DestroyArray(const JPH_Factory *_this)
{
    delete[] ((const JPH::Factory *)_this);
}

JPH_Factory *JPH_Factory_AssignFromAnother(JPH_Factory *_this, Jolt_PassBy _other_pass_by, JPH_Factory *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::Factory);
    return (JPH_Factory *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Factory *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::Factory) MRBINDC_CLASSARG_COPY(_other, (JPH::Factory), JPH::Factory) MRBINDC_CLASSARG_MOVE(_other, (JPH::Factory), JPH::Factory) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::Factory) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::Factory) MRBINDC_CLASSARG_END(_other, JPH::Factory))
    ));
}

void *Jolt_new_JPH_Factory_size_t(size_t inCount)
{
    return JPH::Factory::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Factory_void_ptr(void *inPointer)
{
    JPH::Factory::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Factory_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Factory::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Factory_size_t(size_t inCount)
{
    return JPH::Factory::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Factory_void_ptr(void *inPointer)
{
    JPH::Factory::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Factory_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Factory::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Factory_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Factory::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Factory_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Factory::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Factory_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Factory::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Factory_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Factory::operator delete[](
        inPointer,
        inPlace
    );
}

void *JPH_Factory_CreateObject(JPH_Factory *_this, const char *inName)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Factory *)(_this)).CreateObject(
        inName
    );
}

void JPH_Factory_Clear(JPH_Factory *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Factory *)(_this)).Clear();
}

