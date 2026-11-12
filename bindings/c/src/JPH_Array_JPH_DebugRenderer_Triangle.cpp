// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_DebugRenderer_Triangle.h"

#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_DebugRenderer_Triangle *Jolt_JPH_Array_JPH_DebugRenderer_Triangle_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::DebugRenderer::Triangle>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_DebugRenderer_Triangle*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_DebugRenderer_Triangle *Jolt_JPH_Array_JPH_DebugRenderer_Triangle_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_DebugRenderer_Triangle *)(new JPH::Array<JPH::DebugRenderer::Triangle>[num_elems]);
}

Jolt_JPH_Array_JPH_DebugRenderer_Triangle *Jolt_JPH_Array_JPH_DebugRenderer_Triangle_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_DebugRenderer_Triangle *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::DebugRenderer::Triangle>);
    return (Jolt_JPH_Array_JPH_DebugRenderer_Triangle *)new JPH::Array<JPH::DebugRenderer::Triangle>(JPH::Array<JPH::DebugRenderer::Triangle>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::DebugRenderer::Triangle>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::DebugRenderer::Triangle>), JPH::Array<JPH::DebugRenderer::Triangle>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::DebugRenderer::Triangle>), JPH::Array<JPH::DebugRenderer::Triangle>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::DebugRenderer::Triangle>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::DebugRenderer::Triangle>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::DebugRenderer::Triangle>))
    ));
}

void Jolt_JPH_Array_JPH_DebugRenderer_Triangle_AssignFromAnother(Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_DebugRenderer_Triangle *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::DebugRenderer::Triangle>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::DebugRenderer::Triangle>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::DebugRenderer::Triangle>), JPH::Array<JPH::DebugRenderer::Triangle>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::DebugRenderer::Triangle>), JPH::Array<JPH::DebugRenderer::Triangle>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::DebugRenderer::Triangle>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::DebugRenderer::Triangle>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::DebugRenderer::Triangle>))
    );
}

void Jolt_JPH_Array_JPH_DebugRenderer_Triangle_Destroy(const Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this)
{
    delete ((const JPH::Array<JPH::DebugRenderer::Triangle> *)_this);
}

void Jolt_JPH_Array_JPH_DebugRenderer_Triangle_DestroyArray(const Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this)
{
    delete[] ((const JPH::Array<JPH::DebugRenderer::Triangle> *)_this);
}

const Jolt_JPH_Array_JPH_DebugRenderer_Triangle *Jolt_JPH_Array_JPH_DebugRenderer_Triangle_OffsetPtr(const Jolt_JPH_Array_JPH_DebugRenderer_Triangle *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_DebugRenderer_Triangle *)(((const JPH::Array<JPH::DebugRenderer::Triangle> *)ptr) + i);
}

Jolt_JPH_Array_JPH_DebugRenderer_Triangle *Jolt_JPH_Array_JPH_DebugRenderer_Triangle_OffsetMutablePtr(Jolt_JPH_Array_JPH_DebugRenderer_Triangle *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_DebugRenderer_Triangle *)(((JPH::Array<JPH::DebugRenderer::Triangle> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_DebugRenderer_Triangle_size(const Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_DebugRenderer_Triangle_empty(const Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_DebugRenderer_Triangle_resize(Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_DebugRenderer_Triangle_resize_with_default_value(Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this, size_t new_size, const JPH_DebugRenderer_Triangle *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::DebugRenderer::Triangle *)(value))
    );
}

void Jolt_JPH_Array_JPH_DebugRenderer_Triangle_clear(Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_DebugRenderer_Triangle_capacity(const Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_DebugRenderer_Triangle_reserve(Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_DebugRenderer_Triangle_shrink_to_fit(Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).shrink_to_fit();
}

const JPH_DebugRenderer_Triangle *Jolt_JPH_Array_JPH_DebugRenderer_Triangle_at(const Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this, size_t i)
{
    return (const JPH_DebugRenderer_Triangle *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).at(
        i
    ));
}

JPH_DebugRenderer_Triangle *Jolt_JPH_Array_JPH_DebugRenderer_Triangle_at_mut(Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this, size_t i)
{
    return (JPH_DebugRenderer_Triangle *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).at(
        i
    ));
}

const JPH_DebugRenderer_Triangle *Jolt_JPH_Array_JPH_DebugRenderer_Triangle_front(const Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this)
{
    return (const JPH_DebugRenderer_Triangle *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).front());
}

JPH_DebugRenderer_Triangle *Jolt_JPH_Array_JPH_DebugRenderer_Triangle_front_mut(Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this)
{
    return (JPH_DebugRenderer_Triangle *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).front());
}

const JPH_DebugRenderer_Triangle *Jolt_JPH_Array_JPH_DebugRenderer_Triangle_back(const Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this)
{
    return (const JPH_DebugRenderer_Triangle *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).back());
}

JPH_DebugRenderer_Triangle *Jolt_JPH_Array_JPH_DebugRenderer_Triangle_back_mut(Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this)
{
    return (JPH_DebugRenderer_Triangle *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_DebugRenderer_Triangle_push_back(Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this, const JPH_DebugRenderer_Triangle *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).push_back(
        ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::DebugRenderer::Triangle(*(JPH::DebugRenderer::Triangle *)new_elem))
    );
}

void Jolt_JPH_Array_JPH_DebugRenderer_Triangle_pop_back(Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_DebugRenderer_Triangle_insert(Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this, size_t position, const JPH_DebugRenderer_Triangle *new_elem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).begin() + ptrdiff_t(position), ((new_elem ? void() : MRBINDC_THROW("Parameter `new_elem` can not be null.", void)), JPH::DebugRenderer::Triangle(*(JPH::DebugRenderer::Triangle *)new_elem)));
}

void Jolt_JPH_Array_JPH_DebugRenderer_Triangle_erase(Jolt_JPH_Array_JPH_DebugRenderer_Triangle *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::DebugRenderer::Triangle> *)(_this)).begin() + ptrdiff_t(position));
}

