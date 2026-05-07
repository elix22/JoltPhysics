// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_DebugRenderer_LOD.h"

#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_DebugRenderer_LOD *Jolt_JPH_Array_JPH_DebugRenderer_LOD_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::DebugRenderer::LOD>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_DebugRenderer_LOD*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_DebugRenderer_LOD *Jolt_JPH_Array_JPH_DebugRenderer_LOD_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_DebugRenderer_LOD *)(new JPH::Array<JPH::DebugRenderer::LOD>[num_elems]);
}

Jolt_JPH_Array_JPH_DebugRenderer_LOD *Jolt_JPH_Array_JPH_DebugRenderer_LOD_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_DebugRenderer_LOD *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::DebugRenderer::LOD>);
    return (Jolt_JPH_Array_JPH_DebugRenderer_LOD *)new JPH::Array<JPH::DebugRenderer::LOD>(JPH::Array<JPH::DebugRenderer::LOD>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::DebugRenderer::LOD>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::DebugRenderer::LOD>), JPH::Array<JPH::DebugRenderer::LOD>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::DebugRenderer::LOD>), JPH::Array<JPH::DebugRenderer::LOD>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::DebugRenderer::LOD>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::DebugRenderer::LOD>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::DebugRenderer::LOD>))
    ));
}

void Jolt_JPH_Array_JPH_DebugRenderer_LOD_AssignFromAnother(Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_DebugRenderer_LOD *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::DebugRenderer::LOD>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::DebugRenderer::LOD>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::DebugRenderer::LOD>), JPH::Array<JPH::DebugRenderer::LOD>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::DebugRenderer::LOD>), JPH::Array<JPH::DebugRenderer::LOD>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::DebugRenderer::LOD>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::DebugRenderer::LOD>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::DebugRenderer::LOD>))
    );
}

void Jolt_JPH_Array_JPH_DebugRenderer_LOD_Destroy(const Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this)
{
    delete ((const JPH::Array<JPH::DebugRenderer::LOD> *)_this);
}

void Jolt_JPH_Array_JPH_DebugRenderer_LOD_DestroyArray(const Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this)
{
    delete[] ((const JPH::Array<JPH::DebugRenderer::LOD> *)_this);
}

const Jolt_JPH_Array_JPH_DebugRenderer_LOD *Jolt_JPH_Array_JPH_DebugRenderer_LOD_OffsetPtr(const Jolt_JPH_Array_JPH_DebugRenderer_LOD *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_DebugRenderer_LOD *)(((const JPH::Array<JPH::DebugRenderer::LOD> *)ptr) + i);
}

Jolt_JPH_Array_JPH_DebugRenderer_LOD *Jolt_JPH_Array_JPH_DebugRenderer_LOD_OffsetMutablePtr(Jolt_JPH_Array_JPH_DebugRenderer_LOD *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_DebugRenderer_LOD *)(((JPH::Array<JPH::DebugRenderer::LOD> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_DebugRenderer_LOD_size(const Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_DebugRenderer_LOD_empty(const Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_DebugRenderer_LOD_resize(Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_DebugRenderer_LOD_resize_with_default_value(Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this, size_t new_size, const JPH_DebugRenderer_LOD *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::DebugRenderer::LOD *)(value))
    );
}

void Jolt_JPH_Array_JPH_DebugRenderer_LOD_clear(Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_DebugRenderer_LOD_capacity(const Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_DebugRenderer_LOD_reserve(Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_DebugRenderer_LOD_shrink_to_fit(Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).shrink_to_fit();
}

const JPH_DebugRenderer_LOD *Jolt_JPH_Array_JPH_DebugRenderer_LOD_at(const Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this, size_t i)
{
    return (const JPH_DebugRenderer_LOD *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).at(
        i
    ));
}

JPH_DebugRenderer_LOD *Jolt_JPH_Array_JPH_DebugRenderer_LOD_at_mut(Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this, size_t i)
{
    return (JPH_DebugRenderer_LOD *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).at(
        i
    ));
}

const JPH_DebugRenderer_LOD *Jolt_JPH_Array_JPH_DebugRenderer_LOD_front(const Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this)
{
    return (const JPH_DebugRenderer_LOD *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).front());
}

JPH_DebugRenderer_LOD *Jolt_JPH_Array_JPH_DebugRenderer_LOD_front_mut(Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this)
{
    return (JPH_DebugRenderer_LOD *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).front());
}

const JPH_DebugRenderer_LOD *Jolt_JPH_Array_JPH_DebugRenderer_LOD_back(const Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this)
{
    return (const JPH_DebugRenderer_LOD *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).back());
}

JPH_DebugRenderer_LOD *Jolt_JPH_Array_JPH_DebugRenderer_LOD_back_mut(Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this)
{
    return (JPH_DebugRenderer_LOD *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_DebugRenderer_LOD_push_back(Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this, Jolt_PassBy new_elem_pass_by, JPH_DebugRenderer_LOD *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::DebugRenderer::LOD);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).push_back(
        (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_COPY(new_elem, (JPH::DebugRenderer::LOD), JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::DebugRenderer::LOD), JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_END(new_elem, JPH::DebugRenderer::LOD))
    );
}

void Jolt_JPH_Array_JPH_DebugRenderer_LOD_pop_back(Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_DebugRenderer_LOD_insert(Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this, size_t position, Jolt_PassBy new_elem_pass_by, JPH_DebugRenderer_LOD *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::DebugRenderer::LOD);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).begin() + ptrdiff_t(position), (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_COPY(new_elem, (JPH::DebugRenderer::LOD), JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::DebugRenderer::LOD), JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::DebugRenderer::LOD) MRBINDC_CLASSARG_END(new_elem, JPH::DebugRenderer::LOD)));
}

void Jolt_JPH_Array_JPH_DebugRenderer_LOD_erase(Jolt_JPH_Array_JPH_DebugRenderer_LOD *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::LOD> *)(_this)).begin() + ptrdiff_t(position));
}

