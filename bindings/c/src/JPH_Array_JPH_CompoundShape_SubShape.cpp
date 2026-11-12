// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "JPH_Array_JPH_CompoundShape_SubShape.h"

#include <Jolt/Physics/Collision/Shape/CompoundShape.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_JPH_Array_JPH_CompoundShape_SubShape *Jolt_JPH_Array_JPH_CompoundShape_SubShape_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Array<JPH::CompoundShape::SubShape>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_JPH_Array_JPH_CompoundShape_SubShape*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_JPH_Array_JPH_CompoundShape_SubShape *Jolt_JPH_Array_JPH_CompoundShape_SubShape_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_JPH_Array_JPH_CompoundShape_SubShape *)(new JPH::Array<JPH::CompoundShape::SubShape>[num_elems]);
}

Jolt_JPH_Array_JPH_CompoundShape_SubShape *Jolt_JPH_Array_JPH_CompoundShape_SubShape_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_CompoundShape_SubShape *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::CompoundShape::SubShape>);
    return (Jolt_JPH_Array_JPH_CompoundShape_SubShape *)new JPH::Array<JPH::CompoundShape::SubShape>(JPH::Array<JPH::CompoundShape::SubShape>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::CompoundShape::SubShape>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::CompoundShape::SubShape>), JPH::Array<JPH::CompoundShape::SubShape>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::CompoundShape::SubShape>), JPH::Array<JPH::CompoundShape::SubShape>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::CompoundShape::SubShape>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::CompoundShape::SubShape>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::CompoundShape::SubShape>))
    ));
}

void Jolt_JPH_Array_JPH_CompoundShape_SubShape_AssignFromAnother(Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this, Jolt_PassBy other_pass_by, Jolt_JPH_Array_JPH_CompoundShape_SubShape *other)
{
    MRBINDC_CLASSARG_GUARD(other, JPH::Array<JPH::CompoundShape::SubShape>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, JPH::Array<JPH::CompoundShape::SubShape>) MRBINDC_CLASSARG_COPY(other, (JPH::Array<JPH::CompoundShape::SubShape>), JPH::Array<JPH::CompoundShape::SubShape>) MRBINDC_CLASSARG_MOVE(other, (JPH::Array<JPH::CompoundShape::SubShape>), JPH::Array<JPH::CompoundShape::SubShape>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::CompoundShape::SubShape>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, JPH::Array<JPH::CompoundShape::SubShape>) MRBINDC_CLASSARG_END(other, JPH::Array<JPH::CompoundShape::SubShape>))
    );
}

void Jolt_JPH_Array_JPH_CompoundShape_SubShape_Destroy(const Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this)
{
    delete ((const JPH::Array<JPH::CompoundShape::SubShape> *)_this);
}

void Jolt_JPH_Array_JPH_CompoundShape_SubShape_DestroyArray(const Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this)
{
    delete[] ((const JPH::Array<JPH::CompoundShape::SubShape> *)_this);
}

const Jolt_JPH_Array_JPH_CompoundShape_SubShape *Jolt_JPH_Array_JPH_CompoundShape_SubShape_OffsetPtr(const Jolt_JPH_Array_JPH_CompoundShape_SubShape *ptr, ptrdiff_t i)
{
    return (const Jolt_JPH_Array_JPH_CompoundShape_SubShape *)(((const JPH::Array<JPH::CompoundShape::SubShape> *)ptr) + i);
}

Jolt_JPH_Array_JPH_CompoundShape_SubShape *Jolt_JPH_Array_JPH_CompoundShape_SubShape_OffsetMutablePtr(Jolt_JPH_Array_JPH_CompoundShape_SubShape *ptr, ptrdiff_t i)
{
    return (Jolt_JPH_Array_JPH_CompoundShape_SubShape *)(((JPH::Array<JPH::CompoundShape::SubShape> *)ptr) + i);
}

size_t Jolt_JPH_Array_JPH_CompoundShape_SubShape_size(const Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).size();
}

bool Jolt_JPH_Array_JPH_CompoundShape_SubShape_empty(const Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).empty();
}

void Jolt_JPH_Array_JPH_CompoundShape_SubShape_resize(Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this, size_t new_size)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).resize(
        new_size
    );
}

void Jolt_JPH_Array_JPH_CompoundShape_SubShape_resize_with_default_value(Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this, size_t new_size, const JPH_CompoundShape_SubShape *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).resize(
        new_size,
        ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), *(const JPH::CompoundShape::SubShape *)(value))
    );
}

void Jolt_JPH_Array_JPH_CompoundShape_SubShape_clear(Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).clear();
}

size_t Jolt_JPH_Array_JPH_CompoundShape_SubShape_capacity(const Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).capacity();
}

void Jolt_JPH_Array_JPH_CompoundShape_SubShape_reserve(Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this, size_t new_capacity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).reserve(
        new_capacity
    );
}

void Jolt_JPH_Array_JPH_CompoundShape_SubShape_shrink_to_fit(Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).shrink_to_fit();
}

const JPH_CompoundShape_SubShape *Jolt_JPH_Array_JPH_CompoundShape_SubShape_at(const Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this, size_t i)
{
    return (const JPH_CompoundShape_SubShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).at(
        i
    ));
}

JPH_CompoundShape_SubShape *Jolt_JPH_Array_JPH_CompoundShape_SubShape_at_mut(Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this, size_t i)
{
    return (JPH_CompoundShape_SubShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).at(
        i
    ));
}

const JPH_CompoundShape_SubShape *Jolt_JPH_Array_JPH_CompoundShape_SubShape_front(const Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this)
{
    return (const JPH_CompoundShape_SubShape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).front());
}

JPH_CompoundShape_SubShape *Jolt_JPH_Array_JPH_CompoundShape_SubShape_front_mut(Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this)
{
    return (JPH_CompoundShape_SubShape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).front());
}

const JPH_CompoundShape_SubShape *Jolt_JPH_Array_JPH_CompoundShape_SubShape_back(const Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this)
{
    return (const JPH_CompoundShape_SubShape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).back());
}

JPH_CompoundShape_SubShape *Jolt_JPH_Array_JPH_CompoundShape_SubShape_back_mut(Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this)
{
    return (JPH_CompoundShape_SubShape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).empty() ? nullptr : &((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).back());
}

void Jolt_JPH_Array_JPH_CompoundShape_SubShape_push_back(Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this, Jolt_PassBy new_elem_pass_by, JPH_CompoundShape_SubShape *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::CompoundShape::SubShape);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).push_back(
        (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_COPY(new_elem, (JPH::CompoundShape::SubShape), JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::CompoundShape::SubShape), JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_END(new_elem, JPH::CompoundShape::SubShape))
    );
}

void Jolt_JPH_Array_JPH_CompoundShape_SubShape_pop_back(Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).pop_back();
}

void Jolt_JPH_Array_JPH_CompoundShape_SubShape_insert(Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this, size_t position, Jolt_PassBy new_elem_pass_by, JPH_CompoundShape_SubShape *new_elem)
{
    MRBINDC_CLASSARG_GUARD(new_elem, JPH::CompoundShape::SubShape);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).insert(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).begin() + ptrdiff_t(position), (MRBINDC_CLASSARG_DEF_CTOR(new_elem, JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_COPY(new_elem, (JPH::CompoundShape::SubShape), JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_MOVE(new_elem, (JPH::CompoundShape::SubShape), JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_DefaultArgument, JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_NO_DEF_ARG(new_elem, Jolt_PassBy_NoObject, JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_END(new_elem, JPH::CompoundShape::SubShape)));
}

void Jolt_JPH_Array_JPH_CompoundShape_SubShape_erase(Jolt_JPH_Array_JPH_CompoundShape_SubShape *_this, size_t position)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).erase(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Array<JPH::CompoundShape::SubShape> *)(_this)).begin() + ptrdiff_t(position));
}

