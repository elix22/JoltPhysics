// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Core/Reference.h"

#include <Jolt/Core/Reference.h>
#include <Jolt/Physics/Character/CharacterBase.h>
#include <Jolt/Physics/Collision/GroupFilter.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


JPH_RefTarget_JPH_ShapeSettings *JPH_RefTarget_JPH_ShapeSettings_DefaultConstruct(void)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)new JPH::RefTarget<JPH::ShapeSettings>(JPH::RefTarget<JPH::ShapeSettings>());
}

JPH_RefTarget_JPH_ShapeSettings *JPH_RefTarget_JPH_ShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(new JPH::RefTarget<JPH::ShapeSettings>[num_elems]{});
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_RefTarget_JPH_ShapeSettings_OffsetPtr(const JPH_RefTarget_JPH_ShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(((const JPH::RefTarget<JPH::ShapeSettings> *)ptr) + i);
}

JPH_RefTarget_JPH_ShapeSettings *JPH_RefTarget_JPH_ShapeSettings_OffsetMutablePtr(JPH_RefTarget_JPH_ShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(((JPH::RefTarget<JPH::ShapeSettings> *)ptr) + i);
}

JPH_RefTarget_JPH_ShapeSettings *JPH_RefTarget_JPH_ShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_ShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::ShapeSettings>);
    return (JPH_RefTarget_JPH_ShapeSettings *)new JPH::RefTarget<JPH::ShapeSettings>(JPH::RefTarget<JPH::ShapeSettings>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::ShapeSettings>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::ShapeSettings>), JPH::RefTarget<JPH::ShapeSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::ShapeSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::ShapeSettings>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::ShapeSettings>))
    ));
}

void JPH_RefTarget_JPH_ShapeSettings_Destroy(const JPH_RefTarget_JPH_ShapeSettings *_this)
{
    delete ((const JPH::RefTarget<JPH::ShapeSettings> *)_this);
}

void JPH_RefTarget_JPH_ShapeSettings_DestroyArray(const JPH_RefTarget_JPH_ShapeSettings *_this)
{
    delete[] ((const JPH::RefTarget<JPH::ShapeSettings> *)_this);
}

JPH_RefTarget_JPH_ShapeSettings *JPH_RefTarget_JPH_ShapeSettings_AssignFromAnother(JPH_RefTarget_JPH_ShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_ShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::ShapeSettings>);
    return (JPH_RefTarget_JPH_ShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::ShapeSettings> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::ShapeSettings>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::ShapeSettings>), JPH::RefTarget<JPH::ShapeSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::ShapeSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::ShapeSettings>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::ShapeSettings>)))
    ));
}

void JPH_RefTarget_JPH_ShapeSettings_SetEmbedded(const JPH_RefTarget_JPH_ShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::ShapeSettings> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_ShapeSettings_GetRefCount(const JPH_RefTarget_JPH_ShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::ShapeSettings> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_ShapeSettings_AddRef(const JPH_RefTarget_JPH_ShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::ShapeSettings> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_ShapeSettings_Release(const JPH_RefTarget_JPH_ShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::ShapeSettings> *)(_this)).Release();
}

int JPH_RefTarget_JPH_ShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::ShapeSettings>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_Shape *JPH_RefTarget_JPH_Shape_DefaultConstruct(void)
{
    return (JPH_RefTarget_JPH_Shape *)new JPH::RefTarget<JPH::Shape>(JPH::RefTarget<JPH::Shape>());
}

JPH_RefTarget_JPH_Shape *JPH_RefTarget_JPH_Shape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_Shape *)(new JPH::RefTarget<JPH::Shape>[num_elems]{});
}

const JPH_RefTarget_JPH_Shape *JPH_RefTarget_JPH_Shape_OffsetPtr(const JPH_RefTarget_JPH_Shape *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_Shape *)(((const JPH::RefTarget<JPH::Shape> *)ptr) + i);
}

JPH_RefTarget_JPH_Shape *JPH_RefTarget_JPH_Shape_OffsetMutablePtr(JPH_RefTarget_JPH_Shape *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_Shape *)(((JPH::RefTarget<JPH::Shape> *)ptr) + i);
}

JPH_RefTarget_JPH_Shape *JPH_RefTarget_JPH_Shape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Shape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::Shape>);
    return (JPH_RefTarget_JPH_Shape *)new JPH::RefTarget<JPH::Shape>(JPH::RefTarget<JPH::Shape>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::Shape>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::Shape>), JPH::RefTarget<JPH::Shape>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::Shape>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::Shape>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::Shape>))
    ));
}

void JPH_RefTarget_JPH_Shape_Destroy(const JPH_RefTarget_JPH_Shape *_this)
{
    delete ((const JPH::RefTarget<JPH::Shape> *)_this);
}

void JPH_RefTarget_JPH_Shape_DestroyArray(const JPH_RefTarget_JPH_Shape *_this)
{
    delete[] ((const JPH::RefTarget<JPH::Shape> *)_this);
}

JPH_RefTarget_JPH_Shape *JPH_RefTarget_JPH_Shape_AssignFromAnother(JPH_RefTarget_JPH_Shape *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Shape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::Shape>);
    return (JPH_RefTarget_JPH_Shape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::Shape> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::Shape>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::Shape>), JPH::RefTarget<JPH::Shape>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::Shape>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::Shape>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::Shape>)))
    ));
}

void JPH_RefTarget_JPH_Shape_SetEmbedded(const JPH_RefTarget_JPH_Shape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Shape> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_Shape_GetRefCount(const JPH_RefTarget_JPH_Shape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Shape> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_Shape_AddRef(const JPH_RefTarget_JPH_Shape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Shape> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_Shape_Release(const JPH_RefTarget_JPH_Shape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Shape> *)(_this)).Release();
}

int JPH_RefTarget_JPH_Shape_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::Shape>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_GroupFilter *JPH_RefTarget_JPH_GroupFilter_DefaultConstruct(void)
{
    return (JPH_RefTarget_JPH_GroupFilter *)new JPH::RefTarget<JPH::GroupFilter>(JPH::RefTarget<JPH::GroupFilter>());
}

JPH_RefTarget_JPH_GroupFilter *JPH_RefTarget_JPH_GroupFilter_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_GroupFilter *)(new JPH::RefTarget<JPH::GroupFilter>[num_elems]{});
}

const JPH_RefTarget_JPH_GroupFilter *JPH_RefTarget_JPH_GroupFilter_OffsetPtr(const JPH_RefTarget_JPH_GroupFilter *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_GroupFilter *)(((const JPH::RefTarget<JPH::GroupFilter> *)ptr) + i);
}

JPH_RefTarget_JPH_GroupFilter *JPH_RefTarget_JPH_GroupFilter_OffsetMutablePtr(JPH_RefTarget_JPH_GroupFilter *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_GroupFilter *)(((JPH::RefTarget<JPH::GroupFilter> *)ptr) + i);
}

JPH_RefTarget_JPH_GroupFilter *JPH_RefTarget_JPH_GroupFilter_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_GroupFilter *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::GroupFilter>);
    return (JPH_RefTarget_JPH_GroupFilter *)new JPH::RefTarget<JPH::GroupFilter>(JPH::RefTarget<JPH::GroupFilter>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::GroupFilter>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::GroupFilter>), JPH::RefTarget<JPH::GroupFilter>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::GroupFilter>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::GroupFilter>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::GroupFilter>))
    ));
}

void JPH_RefTarget_JPH_GroupFilter_Destroy(const JPH_RefTarget_JPH_GroupFilter *_this)
{
    delete ((const JPH::RefTarget<JPH::GroupFilter> *)_this);
}

void JPH_RefTarget_JPH_GroupFilter_DestroyArray(const JPH_RefTarget_JPH_GroupFilter *_this)
{
    delete[] ((const JPH::RefTarget<JPH::GroupFilter> *)_this);
}

JPH_RefTarget_JPH_GroupFilter *JPH_RefTarget_JPH_GroupFilter_AssignFromAnother(JPH_RefTarget_JPH_GroupFilter *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_GroupFilter *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::GroupFilter>);
    return (JPH_RefTarget_JPH_GroupFilter *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::GroupFilter> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::GroupFilter>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::GroupFilter>), JPH::RefTarget<JPH::GroupFilter>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::GroupFilter>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::GroupFilter>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::GroupFilter>)))
    ));
}

void JPH_RefTarget_JPH_GroupFilter_SetEmbedded(const JPH_RefTarget_JPH_GroupFilter *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::GroupFilter> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_GroupFilter_GetRefCount(const JPH_RefTarget_JPH_GroupFilter *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::GroupFilter> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_GroupFilter_AddRef(const JPH_RefTarget_JPH_GroupFilter *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::GroupFilter> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_GroupFilter_Release(const JPH_RefTarget_JPH_GroupFilter *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::GroupFilter> *)(_this)).Release();
}

int JPH_RefTarget_JPH_GroupFilter_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::GroupFilter>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_PhysicsMaterial *JPH_RefTarget_JPH_PhysicsMaterial_DefaultConstruct(void)
{
    return (JPH_RefTarget_JPH_PhysicsMaterial *)new JPH::RefTarget<JPH::PhysicsMaterial>(JPH::RefTarget<JPH::PhysicsMaterial>());
}

JPH_RefTarget_JPH_PhysicsMaterial *JPH_RefTarget_JPH_PhysicsMaterial_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_PhysicsMaterial *)(new JPH::RefTarget<JPH::PhysicsMaterial>[num_elems]{});
}

const JPH_RefTarget_JPH_PhysicsMaterial *JPH_RefTarget_JPH_PhysicsMaterial_OffsetPtr(const JPH_RefTarget_JPH_PhysicsMaterial *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_PhysicsMaterial *)(((const JPH::RefTarget<JPH::PhysicsMaterial> *)ptr) + i);
}

JPH_RefTarget_JPH_PhysicsMaterial *JPH_RefTarget_JPH_PhysicsMaterial_OffsetMutablePtr(JPH_RefTarget_JPH_PhysicsMaterial *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_PhysicsMaterial *)(((JPH::RefTarget<JPH::PhysicsMaterial> *)ptr) + i);
}

JPH_RefTarget_JPH_PhysicsMaterial *JPH_RefTarget_JPH_PhysicsMaterial_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_PhysicsMaterial *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::PhysicsMaterial>);
    return (JPH_RefTarget_JPH_PhysicsMaterial *)new JPH::RefTarget<JPH::PhysicsMaterial>(JPH::RefTarget<JPH::PhysicsMaterial>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::PhysicsMaterial>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::PhysicsMaterial>), JPH::RefTarget<JPH::PhysicsMaterial>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::PhysicsMaterial>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::PhysicsMaterial>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::PhysicsMaterial>))
    ));
}

void JPH_RefTarget_JPH_PhysicsMaterial_Destroy(const JPH_RefTarget_JPH_PhysicsMaterial *_this)
{
    delete ((const JPH::RefTarget<JPH::PhysicsMaterial> *)_this);
}

void JPH_RefTarget_JPH_PhysicsMaterial_DestroyArray(const JPH_RefTarget_JPH_PhysicsMaterial *_this)
{
    delete[] ((const JPH::RefTarget<JPH::PhysicsMaterial> *)_this);
}

JPH_RefTarget_JPH_PhysicsMaterial *JPH_RefTarget_JPH_PhysicsMaterial_AssignFromAnother(JPH_RefTarget_JPH_PhysicsMaterial *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_PhysicsMaterial *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::PhysicsMaterial>);
    return (JPH_RefTarget_JPH_PhysicsMaterial *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::PhysicsMaterial> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::PhysicsMaterial>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::PhysicsMaterial>), JPH::RefTarget<JPH::PhysicsMaterial>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::PhysicsMaterial>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::PhysicsMaterial>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::PhysicsMaterial>)))
    ));
}

void JPH_RefTarget_JPH_PhysicsMaterial_SetEmbedded(const JPH_RefTarget_JPH_PhysicsMaterial *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::PhysicsMaterial> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_PhysicsMaterial_GetRefCount(const JPH_RefTarget_JPH_PhysicsMaterial *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::PhysicsMaterial> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_PhysicsMaterial_AddRef(const JPH_RefTarget_JPH_PhysicsMaterial *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::PhysicsMaterial> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_PhysicsMaterial_Release(const JPH_RefTarget_JPH_PhysicsMaterial *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::PhysicsMaterial> *)(_this)).Release();
}

int JPH_RefTarget_JPH_PhysicsMaterial_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::PhysicsMaterial>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_RefTarget_JPH_ConstraintSettings_DefaultConstruct(void)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)new JPH::RefTarget<JPH::ConstraintSettings>(JPH::RefTarget<JPH::ConstraintSettings>());
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_RefTarget_JPH_ConstraintSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(new JPH::RefTarget<JPH::ConstraintSettings>[num_elems]{});
}

const JPH_RefTarget_JPH_ConstraintSettings *JPH_RefTarget_JPH_ConstraintSettings_OffsetPtr(const JPH_RefTarget_JPH_ConstraintSettings *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_ConstraintSettings *)(((const JPH::RefTarget<JPH::ConstraintSettings> *)ptr) + i);
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_RefTarget_JPH_ConstraintSettings_OffsetMutablePtr(JPH_RefTarget_JPH_ConstraintSettings *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(((JPH::RefTarget<JPH::ConstraintSettings> *)ptr) + i);
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_RefTarget_JPH_ConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_ConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::ConstraintSettings>);
    return (JPH_RefTarget_JPH_ConstraintSettings *)new JPH::RefTarget<JPH::ConstraintSettings>(JPH::RefTarget<JPH::ConstraintSettings>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::ConstraintSettings>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::ConstraintSettings>), JPH::RefTarget<JPH::ConstraintSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::ConstraintSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::ConstraintSettings>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::ConstraintSettings>))
    ));
}

void JPH_RefTarget_JPH_ConstraintSettings_Destroy(const JPH_RefTarget_JPH_ConstraintSettings *_this)
{
    delete ((const JPH::RefTarget<JPH::ConstraintSettings> *)_this);
}

void JPH_RefTarget_JPH_ConstraintSettings_DestroyArray(const JPH_RefTarget_JPH_ConstraintSettings *_this)
{
    delete[] ((const JPH::RefTarget<JPH::ConstraintSettings> *)_this);
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_RefTarget_JPH_ConstraintSettings_AssignFromAnother(JPH_RefTarget_JPH_ConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_ConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::ConstraintSettings>);
    return (JPH_RefTarget_JPH_ConstraintSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::ConstraintSettings> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::ConstraintSettings>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::ConstraintSettings>), JPH::RefTarget<JPH::ConstraintSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::ConstraintSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::ConstraintSettings>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::ConstraintSettings>)))
    ));
}

void JPH_RefTarget_JPH_ConstraintSettings_SetEmbedded(const JPH_RefTarget_JPH_ConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::ConstraintSettings> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_ConstraintSettings_GetRefCount(const JPH_RefTarget_JPH_ConstraintSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::ConstraintSettings> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_ConstraintSettings_AddRef(const JPH_RefTarget_JPH_ConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::ConstraintSettings> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_ConstraintSettings_Release(const JPH_RefTarget_JPH_ConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::ConstraintSettings> *)(_this)).Release();
}

int JPH_RefTarget_JPH_ConstraintSettings_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::ConstraintSettings>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_Constraint *JPH_RefTarget_JPH_Constraint_DefaultConstruct(void)
{
    return (JPH_RefTarget_JPH_Constraint *)new JPH::RefTarget<JPH::Constraint>(JPH::RefTarget<JPH::Constraint>());
}

JPH_RefTarget_JPH_Constraint *JPH_RefTarget_JPH_Constraint_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_Constraint *)(new JPH::RefTarget<JPH::Constraint>[num_elems]{});
}

const JPH_RefTarget_JPH_Constraint *JPH_RefTarget_JPH_Constraint_OffsetPtr(const JPH_RefTarget_JPH_Constraint *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_Constraint *)(((const JPH::RefTarget<JPH::Constraint> *)ptr) + i);
}

JPH_RefTarget_JPH_Constraint *JPH_RefTarget_JPH_Constraint_OffsetMutablePtr(JPH_RefTarget_JPH_Constraint *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_Constraint *)(((JPH::RefTarget<JPH::Constraint> *)ptr) + i);
}

JPH_RefTarget_JPH_Constraint *JPH_RefTarget_JPH_Constraint_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Constraint *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::Constraint>);
    return (JPH_RefTarget_JPH_Constraint *)new JPH::RefTarget<JPH::Constraint>(JPH::RefTarget<JPH::Constraint>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::Constraint>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::Constraint>), JPH::RefTarget<JPH::Constraint>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::Constraint>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::Constraint>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::Constraint>))
    ));
}

void JPH_RefTarget_JPH_Constraint_Destroy(const JPH_RefTarget_JPH_Constraint *_this)
{
    delete ((const JPH::RefTarget<JPH::Constraint> *)_this);
}

void JPH_RefTarget_JPH_Constraint_DestroyArray(const JPH_RefTarget_JPH_Constraint *_this)
{
    delete[] ((const JPH::RefTarget<JPH::Constraint> *)_this);
}

JPH_RefTarget_JPH_Constraint *JPH_RefTarget_JPH_Constraint_AssignFromAnother(JPH_RefTarget_JPH_Constraint *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Constraint *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::Constraint>);
    return (JPH_RefTarget_JPH_Constraint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::Constraint> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::Constraint>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::Constraint>), JPH::RefTarget<JPH::Constraint>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::Constraint>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::Constraint>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::Constraint>)))
    ));
}

void JPH_RefTarget_JPH_Constraint_SetEmbedded(const JPH_RefTarget_JPH_Constraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Constraint> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_Constraint_GetRefCount(const JPH_RefTarget_JPH_Constraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Constraint> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_Constraint_AddRef(const JPH_RefTarget_JPH_Constraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Constraint> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_Constraint_Release(const JPH_RefTarget_JPH_Constraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Constraint> *)(_this)).Release();
}

int JPH_RefTarget_JPH_Constraint_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::Constraint>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_RefTarget_JPH_SoftBodySharedSettings_DefaultConstruct(void)
{
    return (JPH_RefTarget_JPH_SoftBodySharedSettings *)new JPH::RefTarget<JPH::SoftBodySharedSettings>(JPH::RefTarget<JPH::SoftBodySharedSettings>());
}

JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_RefTarget_JPH_SoftBodySharedSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_SoftBodySharedSettings *)(new JPH::RefTarget<JPH::SoftBodySharedSettings>[num_elems]{});
}

const JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_RefTarget_JPH_SoftBodySharedSettings_OffsetPtr(const JPH_RefTarget_JPH_SoftBodySharedSettings *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_SoftBodySharedSettings *)(((const JPH::RefTarget<JPH::SoftBodySharedSettings> *)ptr) + i);
}

JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_RefTarget_JPH_SoftBodySharedSettings_OffsetMutablePtr(JPH_RefTarget_JPH_SoftBodySharedSettings *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_SoftBodySharedSettings *)(((JPH::RefTarget<JPH::SoftBodySharedSettings> *)ptr) + i);
}

JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_RefTarget_JPH_SoftBodySharedSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_SoftBodySharedSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::SoftBodySharedSettings>);
    return (JPH_RefTarget_JPH_SoftBodySharedSettings *)new JPH::RefTarget<JPH::SoftBodySharedSettings>(JPH::RefTarget<JPH::SoftBodySharedSettings>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::SoftBodySharedSettings>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::SoftBodySharedSettings>), JPH::RefTarget<JPH::SoftBodySharedSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::SoftBodySharedSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::SoftBodySharedSettings>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::SoftBodySharedSettings>))
    ));
}

void JPH_RefTarget_JPH_SoftBodySharedSettings_Destroy(const JPH_RefTarget_JPH_SoftBodySharedSettings *_this)
{
    delete ((const JPH::RefTarget<JPH::SoftBodySharedSettings> *)_this);
}

void JPH_RefTarget_JPH_SoftBodySharedSettings_DestroyArray(const JPH_RefTarget_JPH_SoftBodySharedSettings *_this)
{
    delete[] ((const JPH::RefTarget<JPH::SoftBodySharedSettings> *)_this);
}

JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_RefTarget_JPH_SoftBodySharedSettings_AssignFromAnother(JPH_RefTarget_JPH_SoftBodySharedSettings *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_SoftBodySharedSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::SoftBodySharedSettings>);
    return (JPH_RefTarget_JPH_SoftBodySharedSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::SoftBodySharedSettings> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::SoftBodySharedSettings>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::SoftBodySharedSettings>), JPH::RefTarget<JPH::SoftBodySharedSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::SoftBodySharedSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::SoftBodySharedSettings>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::SoftBodySharedSettings>)))
    ));
}

void JPH_RefTarget_JPH_SoftBodySharedSettings_SetEmbedded(const JPH_RefTarget_JPH_SoftBodySharedSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::SoftBodySharedSettings> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_SoftBodySharedSettings_GetRefCount(const JPH_RefTarget_JPH_SoftBodySharedSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::SoftBodySharedSettings> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef(const JPH_RefTarget_JPH_SoftBodySharedSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::SoftBodySharedSettings> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_SoftBodySharedSettings_Release(const JPH_RefTarget_JPH_SoftBodySharedSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::SoftBodySharedSettings> *)(_this)).Release();
}

int JPH_RefTarget_JPH_SoftBodySharedSettings_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::SoftBodySharedSettings>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_CharacterBaseSettings *JPH_RefTarget_JPH_CharacterBaseSettings_DefaultConstruct(void)
{
    return (JPH_RefTarget_JPH_CharacterBaseSettings *)new JPH::RefTarget<JPH::CharacterBaseSettings>(JPH::RefTarget<JPH::CharacterBaseSettings>());
}

JPH_RefTarget_JPH_CharacterBaseSettings *JPH_RefTarget_JPH_CharacterBaseSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_CharacterBaseSettings *)(new JPH::RefTarget<JPH::CharacterBaseSettings>[num_elems]{});
}

const JPH_RefTarget_JPH_CharacterBaseSettings *JPH_RefTarget_JPH_CharacterBaseSettings_OffsetPtr(const JPH_RefTarget_JPH_CharacterBaseSettings *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_CharacterBaseSettings *)(((const JPH::RefTarget<JPH::CharacterBaseSettings> *)ptr) + i);
}

JPH_RefTarget_JPH_CharacterBaseSettings *JPH_RefTarget_JPH_CharacterBaseSettings_OffsetMutablePtr(JPH_RefTarget_JPH_CharacterBaseSettings *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_CharacterBaseSettings *)(((JPH::RefTarget<JPH::CharacterBaseSettings> *)ptr) + i);
}

JPH_RefTarget_JPH_CharacterBaseSettings *JPH_RefTarget_JPH_CharacterBaseSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_CharacterBaseSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::CharacterBaseSettings>);
    return (JPH_RefTarget_JPH_CharacterBaseSettings *)new JPH::RefTarget<JPH::CharacterBaseSettings>(JPH::RefTarget<JPH::CharacterBaseSettings>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::CharacterBaseSettings>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::CharacterBaseSettings>), JPH::RefTarget<JPH::CharacterBaseSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::CharacterBaseSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::CharacterBaseSettings>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::CharacterBaseSettings>))
    ));
}

void JPH_RefTarget_JPH_CharacterBaseSettings_Destroy(const JPH_RefTarget_JPH_CharacterBaseSettings *_this)
{
    delete ((const JPH::RefTarget<JPH::CharacterBaseSettings> *)_this);
}

void JPH_RefTarget_JPH_CharacterBaseSettings_DestroyArray(const JPH_RefTarget_JPH_CharacterBaseSettings *_this)
{
    delete[] ((const JPH::RefTarget<JPH::CharacterBaseSettings> *)_this);
}

JPH_RefTarget_JPH_CharacterBaseSettings *JPH_RefTarget_JPH_CharacterBaseSettings_AssignFromAnother(JPH_RefTarget_JPH_CharacterBaseSettings *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_CharacterBaseSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::CharacterBaseSettings>);
    return (JPH_RefTarget_JPH_CharacterBaseSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::CharacterBaseSettings> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::CharacterBaseSettings>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::CharacterBaseSettings>), JPH::RefTarget<JPH::CharacterBaseSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::CharacterBaseSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::CharacterBaseSettings>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::CharacterBaseSettings>)))
    ));
}

void JPH_RefTarget_JPH_CharacterBaseSettings_SetEmbedded(const JPH_RefTarget_JPH_CharacterBaseSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::CharacterBaseSettings> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_CharacterBaseSettings_GetRefCount(const JPH_RefTarget_JPH_CharacterBaseSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::CharacterBaseSettings> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_CharacterBaseSettings_AddRef(const JPH_RefTarget_JPH_CharacterBaseSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::CharacterBaseSettings> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_CharacterBaseSettings_Release(const JPH_RefTarget_JPH_CharacterBaseSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::CharacterBaseSettings> *)(_this)).Release();
}

int JPH_RefTarget_JPH_CharacterBaseSettings_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::CharacterBaseSettings>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_CharacterBase *JPH_RefTarget_JPH_CharacterBase_DefaultConstruct(void)
{
    return (JPH_RefTarget_JPH_CharacterBase *)new JPH::RefTarget<JPH::CharacterBase>(JPH::RefTarget<JPH::CharacterBase>());
}

JPH_RefTarget_JPH_CharacterBase *JPH_RefTarget_JPH_CharacterBase_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_CharacterBase *)(new JPH::RefTarget<JPH::CharacterBase>[num_elems]{});
}

const JPH_RefTarget_JPH_CharacterBase *JPH_RefTarget_JPH_CharacterBase_OffsetPtr(const JPH_RefTarget_JPH_CharacterBase *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_CharacterBase *)(((const JPH::RefTarget<JPH::CharacterBase> *)ptr) + i);
}

JPH_RefTarget_JPH_CharacterBase *JPH_RefTarget_JPH_CharacterBase_OffsetMutablePtr(JPH_RefTarget_JPH_CharacterBase *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_CharacterBase *)(((JPH::RefTarget<JPH::CharacterBase> *)ptr) + i);
}

JPH_RefTarget_JPH_CharacterBase *JPH_RefTarget_JPH_CharacterBase_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_CharacterBase *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::CharacterBase>);
    return (JPH_RefTarget_JPH_CharacterBase *)new JPH::RefTarget<JPH::CharacterBase>(JPH::RefTarget<JPH::CharacterBase>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::CharacterBase>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::CharacterBase>), JPH::RefTarget<JPH::CharacterBase>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::CharacterBase>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::CharacterBase>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::CharacterBase>))
    ));
}

void JPH_RefTarget_JPH_CharacterBase_Destroy(const JPH_RefTarget_JPH_CharacterBase *_this)
{
    delete ((const JPH::RefTarget<JPH::CharacterBase> *)_this);
}

void JPH_RefTarget_JPH_CharacterBase_DestroyArray(const JPH_RefTarget_JPH_CharacterBase *_this)
{
    delete[] ((const JPH::RefTarget<JPH::CharacterBase> *)_this);
}

JPH_RefTarget_JPH_CharacterBase *JPH_RefTarget_JPH_CharacterBase_AssignFromAnother(JPH_RefTarget_JPH_CharacterBase *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_CharacterBase *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::CharacterBase>);
    return (JPH_RefTarget_JPH_CharacterBase *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::CharacterBase> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::CharacterBase>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::CharacterBase>), JPH::RefTarget<JPH::CharacterBase>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::CharacterBase>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::CharacterBase>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::CharacterBase>)))
    ));
}

void JPH_RefTarget_JPH_CharacterBase_SetEmbedded(const JPH_RefTarget_JPH_CharacterBase *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::CharacterBase> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_CharacterBase_GetRefCount(const JPH_RefTarget_JPH_CharacterBase *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::CharacterBase> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_CharacterBase_AddRef(const JPH_RefTarget_JPH_CharacterBase *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::CharacterBase> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_CharacterBase_Release(const JPH_RefTarget_JPH_CharacterBase *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::CharacterBase> *)(_this)).Release();
}

int JPH_RefTarget_JPH_CharacterBase_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::CharacterBase>::sInternalGetRefCountOffset();
}

