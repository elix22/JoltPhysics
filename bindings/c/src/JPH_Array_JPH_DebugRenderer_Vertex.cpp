// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_DebugRenderer_Vertex.h"

#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_DebugRenderer_Vertex *Jolt_JPH_Array_JPH_DebugRenderer_Vertex_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::DebugRenderer::Vertex>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_DebugRenderer_Vertex*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_DebugRenderer_Vertex *Jolt_JPH_Array_JPH_DebugRenderer_Vertex_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_DebugRenderer_Vertex *)(new JPH::Array<JPH::DebugRenderer::Vertex>[num_elems]);
}

Jolt_JPH_Array_JPH_DebugRenderer_Vertex *Jolt_JPH_Array_JPH_DebugRenderer_Vertex_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_DebugRenderer_Vertex *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::DebugRenderer::Vertex>);
    return (Jolt_JPH_Array_JPH_DebugRenderer_Vertex *)new JPH::Array<JPH::DebugRenderer::Vertex>(JPH::Array<JPH::DebugRenderer::Vertex>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::DebugRenderer::Vertex>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::DebugRenderer::Vertex>), JPH::Array<JPH::DebugRenderer::Vertex>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::DebugRenderer::Vertex>), JPH::Array<JPH::DebugRenderer::Vertex>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::DebugRenderer::Vertex>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::DebugRenderer::Vertex>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::DebugRenderer::Vertex>))
    ));
}

void Jolt_JPH_Array_JPH_DebugRenderer_Vertex_AssignFromAnother(Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_DebugRenderer_Vertex *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::DebugRenderer::Vertex>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::DebugRenderer::Vertex>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::DebugRenderer::Vertex>), JPH::Array<JPH::DebugRenderer::Vertex>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::DebugRenderer::Vertex>), JPH::Array<JPH::DebugRenderer::Vertex>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::DebugRenderer::Vertex>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::DebugRenderer::Vertex>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::DebugRenderer::Vertex>))
    );
}

void Jolt_JPH_Array_JPH_DebugRenderer_Vertex_Destroy(const Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this)
{
    delete ((const JPH::Array<JPH::DebugRenderer::Vertex> *)_this);
}

void Jolt_JPH_Array_JPH_DebugRenderer_Vertex_DestroyArray(const Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this)
{
    delete[] ((const JPH::Array<JPH::DebugRenderer::Vertex> *)_this);
}

const Jolt_JPH_Array_JPH_DebugRenderer_Vertex *Jolt_JPH_Array_JPH_DebugRenderer_Vertex_OffsetPtr(const Jolt_JPH_Array_JPH_DebugRenderer_Vertex *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_DebugRenderer_Vertex *)(((const JPH::Array<JPH::DebugRenderer::Vertex> *)ptr) + i);
}

Jolt_JPH_Array_JPH_DebugRenderer_Vertex *Jolt_JPH_Array_JPH_DebugRenderer_Vertex_OffsetMutablePtr(Jolt_JPH_Array_JPH_DebugRenderer_Vertex *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_DebugRenderer_Vertex *)(((JPH::Array<JPH::DebugRenderer::Vertex> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_DebugRenderer_Vertex_size(const Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_DebugRenderer_Vertex_empty(const Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_DebugRenderer_Vertex_resize(Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_DebugRenderer_Vertex_resize_with_default_value(Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this, size_t new_size, const JPH_DebugRenderer_Vertex *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::DebugRenderer::Vertex *)(value))
    );
}

void Jolt_JPH_Array_JPH_DebugRenderer_Vertex_clear(Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_DebugRenderer_Vertex_capacity(const Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_DebugRenderer_Vertex_reserve(Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_DebugRenderer_Vertex_shrink_to_fit(Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).shrink_to_fit();
}

const JPH_DebugRenderer_Vertex *Jolt_JPH_Array_JPH_DebugRenderer_Vertex_at(const Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this, size_t i)
{
    return (const JPH_DebugRenderer_Vertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).at(
        i
    ));
}

JPH_DebugRenderer_Vertex *Jolt_JPH_Array_JPH_DebugRenderer_Vertex_at_mut(Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this, size_t i)
{
    return (JPH_DebugRenderer_Vertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).at(
        i
    ));
}

const JPH_DebugRenderer_Vertex *Jolt_JPH_Array_JPH_DebugRenderer_Vertex_front(const Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this)
{
    return (const JPH_DebugRenderer_Vertex *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).front());
}

JPH_DebugRenderer_Vertex *Jolt_JPH_Array_JPH_DebugRenderer_Vertex_front_mut(Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this)
{
    return (JPH_DebugRenderer_Vertex *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).front());
}

const JPH_DebugRenderer_Vertex *Jolt_JPH_Array_JPH_DebugRenderer_Vertex_back(const Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this)
{
    return (const JPH_DebugRenderer_Vertex *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).back());
}

JPH_DebugRenderer_Vertex *Jolt_JPH_Array_JPH_DebugRenderer_Vertex_back_mut(Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this)
{
    return (JPH_DebugRenderer_Vertex *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_DebugRenderer_Vertex_push_back(Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this, const JPH_DebugRenderer_Vertex *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::DebugRenderer::Vertex(*(JPH::DebugRenderer::Vertex *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_DebugRenderer_Vertex_pop_back(Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_DebugRenderer_Vertex_insert(Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this, size_t position, const JPH_DebugRenderer_Vertex *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::DebugRenderer::Vertex(*(JPH::DebugRenderer::Vertex *)new_elem)));
}

void Jolt_JPH_Array_JPH_DebugRenderer_Vertex_erase(Jolt_JPH_Array_JPH_DebugRenderer_Vertex *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Vertex> *)(_this)).begin() + ptrdiff_t(position));
}

