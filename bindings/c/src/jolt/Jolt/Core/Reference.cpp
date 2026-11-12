// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Core/Reference.h"

#include <Jolt/Core/Reference.h>
#include <Jolt/Physics/Character/CharacterBase.h>
#include <Jolt/Physics/Collision/GroupFilter.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/Constraints/PathConstraintPath.h>
#include <Jolt/Physics/Ragdoll/Ragdoll.h>
#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <Jolt/Physics/Vehicle/VehicleCollisionTester.h>
#include <Jolt/Physics/Vehicle/VehicleController.h>
#include <Jolt/Physics/Vehicle/Wheel.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <Jolt/Skeleton/SkeletalAnimation.h>
#include <Jolt/Skeleton/Skeleton.h>
#include <Jolt/Skeleton/SkeletonMapper.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


JPH_RefTarget_JPH_ShapeSettings *JPH_RefTarget_JPH_ShapeSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::ShapeSettings>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_ShapeSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_ShapeSettings *JPH_RefTarget_JPH_ShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(new JPH::RefTarget<JPH::ShapeSettings>[num_elems]);
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
    using _mrbind_T = JPH::RefTarget<JPH::Shape>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_Shape*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_Shape *JPH_RefTarget_JPH_Shape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_Shape *)(new JPH::RefTarget<JPH::Shape>[num_elems]);
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

JPH_RefTarget_JPH_PhysicsMaterial *JPH_RefTarget_JPH_PhysicsMaterial_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::PhysicsMaterial>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_PhysicsMaterial*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_PhysicsMaterial *JPH_RefTarget_JPH_PhysicsMaterial_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_PhysicsMaterial *)(new JPH::RefTarget<JPH::PhysicsMaterial>[num_elems]);
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

JPH_RefTarget_JPH_CharacterBaseSettings *JPH_RefTarget_JPH_CharacterBaseSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::CharacterBaseSettings>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_CharacterBaseSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_CharacterBaseSettings *JPH_RefTarget_JPH_CharacterBaseSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_CharacterBaseSettings *)(new JPH::RefTarget<JPH::CharacterBaseSettings>[num_elems]);
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
    using _mrbind_T = JPH::RefTarget<JPH::CharacterBase>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_CharacterBase*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_CharacterBase *JPH_RefTarget_JPH_CharacterBase_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_CharacterBase *)(new JPH::RefTarget<JPH::CharacterBase>[num_elems]);
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

JPH_RefTarget_JPH_ConstraintSettings *JPH_RefTarget_JPH_ConstraintSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::ConstraintSettings>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_ConstraintSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_RefTarget_JPH_ConstraintSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(new JPH::RefTarget<JPH::ConstraintSettings>[num_elems]);
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
    using _mrbind_T = JPH::RefTarget<JPH::Constraint>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_Constraint*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_Constraint *JPH_RefTarget_JPH_Constraint_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_Constraint *)(new JPH::RefTarget<JPH::Constraint>[num_elems]);
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

JPH_RefTarget_JPH_GroupFilter *JPH_RefTarget_JPH_GroupFilter_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::GroupFilter>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_GroupFilter*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_GroupFilter *JPH_RefTarget_JPH_GroupFilter_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_GroupFilter *)(new JPH::RefTarget<JPH::GroupFilter>[num_elems]);
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

JPH_RefTarget_JPH_VehicleCollisionTester *JPH_RefTarget_JPH_VehicleCollisionTester_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::VehicleCollisionTester>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_VehicleCollisionTester*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_VehicleCollisionTester *JPH_RefTarget_JPH_VehicleCollisionTester_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_VehicleCollisionTester *)(new JPH::RefTarget<JPH::VehicleCollisionTester>[num_elems]);
}

const JPH_RefTarget_JPH_VehicleCollisionTester *JPH_RefTarget_JPH_VehicleCollisionTester_OffsetPtr(const JPH_RefTarget_JPH_VehicleCollisionTester *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_VehicleCollisionTester *)(((const JPH::RefTarget<JPH::VehicleCollisionTester> *)ptr) + i);
}

JPH_RefTarget_JPH_VehicleCollisionTester *JPH_RefTarget_JPH_VehicleCollisionTester_OffsetMutablePtr(JPH_RefTarget_JPH_VehicleCollisionTester *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_VehicleCollisionTester *)(((JPH::RefTarget<JPH::VehicleCollisionTester> *)ptr) + i);
}

JPH_RefTarget_JPH_VehicleCollisionTester *JPH_RefTarget_JPH_VehicleCollisionTester_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_VehicleCollisionTester *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::VehicleCollisionTester>);
    return (JPH_RefTarget_JPH_VehicleCollisionTester *)new JPH::RefTarget<JPH::VehicleCollisionTester>(JPH::RefTarget<JPH::VehicleCollisionTester>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::VehicleCollisionTester>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::VehicleCollisionTester>), JPH::RefTarget<JPH::VehicleCollisionTester>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::VehicleCollisionTester>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::VehicleCollisionTester>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::VehicleCollisionTester>))
    ));
}

void JPH_RefTarget_JPH_VehicleCollisionTester_Destroy(const JPH_RefTarget_JPH_VehicleCollisionTester *_this)
{
    delete ((const JPH::RefTarget<JPH::VehicleCollisionTester> *)_this);
}

void JPH_RefTarget_JPH_VehicleCollisionTester_DestroyArray(const JPH_RefTarget_JPH_VehicleCollisionTester *_this)
{
    delete[] ((const JPH::RefTarget<JPH::VehicleCollisionTester> *)_this);
}

JPH_RefTarget_JPH_VehicleCollisionTester *JPH_RefTarget_JPH_VehicleCollisionTester_AssignFromAnother(JPH_RefTarget_JPH_VehicleCollisionTester *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_VehicleCollisionTester *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::VehicleCollisionTester>);
    return (JPH_RefTarget_JPH_VehicleCollisionTester *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::VehicleCollisionTester> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::VehicleCollisionTester>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::VehicleCollisionTester>), JPH::RefTarget<JPH::VehicleCollisionTester>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::VehicleCollisionTester>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::VehicleCollisionTester>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::VehicleCollisionTester>)))
    ));
}

void JPH_RefTarget_JPH_VehicleCollisionTester_SetEmbedded(const JPH_RefTarget_JPH_VehicleCollisionTester *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::VehicleCollisionTester> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_VehicleCollisionTester_GetRefCount(const JPH_RefTarget_JPH_VehicleCollisionTester *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::VehicleCollisionTester> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(const JPH_RefTarget_JPH_VehicleCollisionTester *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::VehicleCollisionTester> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_VehicleCollisionTester_Release(const JPH_RefTarget_JPH_VehicleCollisionTester *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::VehicleCollisionTester> *)(_this)).Release();
}

int JPH_RefTarget_JPH_VehicleCollisionTester_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::VehicleCollisionTester>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_WheelSettings *JPH_RefTarget_JPH_WheelSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::WheelSettings>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_WheelSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_WheelSettings *JPH_RefTarget_JPH_WheelSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_WheelSettings *)(new JPH::RefTarget<JPH::WheelSettings>[num_elems]);
}

const JPH_RefTarget_JPH_WheelSettings *JPH_RefTarget_JPH_WheelSettings_OffsetPtr(const JPH_RefTarget_JPH_WheelSettings *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_WheelSettings *)(((const JPH::RefTarget<JPH::WheelSettings> *)ptr) + i);
}

JPH_RefTarget_JPH_WheelSettings *JPH_RefTarget_JPH_WheelSettings_OffsetMutablePtr(JPH_RefTarget_JPH_WheelSettings *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_WheelSettings *)(((JPH::RefTarget<JPH::WheelSettings> *)ptr) + i);
}

JPH_RefTarget_JPH_WheelSettings *JPH_RefTarget_JPH_WheelSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_WheelSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::WheelSettings>);
    return (JPH_RefTarget_JPH_WheelSettings *)new JPH::RefTarget<JPH::WheelSettings>(JPH::RefTarget<JPH::WheelSettings>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::WheelSettings>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::WheelSettings>), JPH::RefTarget<JPH::WheelSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::WheelSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::WheelSettings>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::WheelSettings>))
    ));
}

void JPH_RefTarget_JPH_WheelSettings_Destroy(const JPH_RefTarget_JPH_WheelSettings *_this)
{
    delete ((const JPH::RefTarget<JPH::WheelSettings> *)_this);
}

void JPH_RefTarget_JPH_WheelSettings_DestroyArray(const JPH_RefTarget_JPH_WheelSettings *_this)
{
    delete[] ((const JPH::RefTarget<JPH::WheelSettings> *)_this);
}

JPH_RefTarget_JPH_WheelSettings *JPH_RefTarget_JPH_WheelSettings_AssignFromAnother(JPH_RefTarget_JPH_WheelSettings *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_WheelSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::WheelSettings>);
    return (JPH_RefTarget_JPH_WheelSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::WheelSettings> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::WheelSettings>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::WheelSettings>), JPH::RefTarget<JPH::WheelSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::WheelSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::WheelSettings>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::WheelSettings>)))
    ));
}

void JPH_RefTarget_JPH_WheelSettings_SetEmbedded(const JPH_RefTarget_JPH_WheelSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::WheelSettings> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_WheelSettings_GetRefCount(const JPH_RefTarget_JPH_WheelSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::WheelSettings> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_WheelSettings_AddRef(const JPH_RefTarget_JPH_WheelSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::WheelSettings> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_WheelSettings_Release(const JPH_RefTarget_JPH_WheelSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::WheelSettings> *)(_this)).Release();
}

int JPH_RefTarget_JPH_WheelSettings_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::WheelSettings>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_RefTarget_JPH_DebugRenderer_Geometry_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::DebugRenderer::Geometry>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_DebugRenderer_Geometry*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_RefTarget_JPH_DebugRenderer_Geometry_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_DebugRenderer_Geometry *)(new JPH::RefTarget<JPH::DebugRenderer::Geometry>[num_elems]);
}

const JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_RefTarget_JPH_DebugRenderer_Geometry_OffsetPtr(const JPH_RefTarget_JPH_DebugRenderer_Geometry *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_DebugRenderer_Geometry *)(((const JPH::RefTarget<JPH::DebugRenderer::Geometry> *)ptr) + i);
}

JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_RefTarget_JPH_DebugRenderer_Geometry_OffsetMutablePtr(JPH_RefTarget_JPH_DebugRenderer_Geometry *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_DebugRenderer_Geometry *)(((JPH::RefTarget<JPH::DebugRenderer::Geometry> *)ptr) + i);
}

JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_RefTarget_JPH_DebugRenderer_Geometry_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_DebugRenderer_Geometry *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::DebugRenderer::Geometry>);
    return (JPH_RefTarget_JPH_DebugRenderer_Geometry *)new JPH::RefTarget<JPH::DebugRenderer::Geometry>(JPH::RefTarget<JPH::DebugRenderer::Geometry>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::DebugRenderer::Geometry>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::DebugRenderer::Geometry>), JPH::RefTarget<JPH::DebugRenderer::Geometry>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::DebugRenderer::Geometry>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::DebugRenderer::Geometry>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::DebugRenderer::Geometry>))
    ));
}

void JPH_RefTarget_JPH_DebugRenderer_Geometry_Destroy(const JPH_RefTarget_JPH_DebugRenderer_Geometry *_this)
{
    delete ((const JPH::RefTarget<JPH::DebugRenderer::Geometry> *)_this);
}

void JPH_RefTarget_JPH_DebugRenderer_Geometry_DestroyArray(const JPH_RefTarget_JPH_DebugRenderer_Geometry *_this)
{
    delete[] ((const JPH::RefTarget<JPH::DebugRenderer::Geometry> *)_this);
}

JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_RefTarget_JPH_DebugRenderer_Geometry_AssignFromAnother(JPH_RefTarget_JPH_DebugRenderer_Geometry *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_DebugRenderer_Geometry *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::DebugRenderer::Geometry>);
    return (JPH_RefTarget_JPH_DebugRenderer_Geometry *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::DebugRenderer::Geometry> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::DebugRenderer::Geometry>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::DebugRenderer::Geometry>), JPH::RefTarget<JPH::DebugRenderer::Geometry>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::DebugRenderer::Geometry>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::DebugRenderer::Geometry>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::DebugRenderer::Geometry>)))
    ));
}

void JPH_RefTarget_JPH_DebugRenderer_Geometry_SetEmbedded(const JPH_RefTarget_JPH_DebugRenderer_Geometry *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::DebugRenderer::Geometry> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_DebugRenderer_Geometry_GetRefCount(const JPH_RefTarget_JPH_DebugRenderer_Geometry *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::DebugRenderer::Geometry> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef(const JPH_RefTarget_JPH_DebugRenderer_Geometry *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::DebugRenderer::Geometry> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_DebugRenderer_Geometry_Release(const JPH_RefTarget_JPH_DebugRenderer_Geometry *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::DebugRenderer::Geometry> *)(_this)).Release();
}

int JPH_RefTarget_JPH_DebugRenderer_Geometry_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::DebugRenderer::Geometry>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_VehicleControllerSettings *JPH_RefTarget_JPH_VehicleControllerSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::VehicleControllerSettings>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_VehicleControllerSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_VehicleControllerSettings *JPH_RefTarget_JPH_VehicleControllerSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_VehicleControllerSettings *)(new JPH::RefTarget<JPH::VehicleControllerSettings>[num_elems]);
}

const JPH_RefTarget_JPH_VehicleControllerSettings *JPH_RefTarget_JPH_VehicleControllerSettings_OffsetPtr(const JPH_RefTarget_JPH_VehicleControllerSettings *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_VehicleControllerSettings *)(((const JPH::RefTarget<JPH::VehicleControllerSettings> *)ptr) + i);
}

JPH_RefTarget_JPH_VehicleControllerSettings *JPH_RefTarget_JPH_VehicleControllerSettings_OffsetMutablePtr(JPH_RefTarget_JPH_VehicleControllerSettings *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_VehicleControllerSettings *)(((JPH::RefTarget<JPH::VehicleControllerSettings> *)ptr) + i);
}

JPH_RefTarget_JPH_VehicleControllerSettings *JPH_RefTarget_JPH_VehicleControllerSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_VehicleControllerSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::VehicleControllerSettings>);
    return (JPH_RefTarget_JPH_VehicleControllerSettings *)new JPH::RefTarget<JPH::VehicleControllerSettings>(JPH::RefTarget<JPH::VehicleControllerSettings>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::VehicleControllerSettings>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::VehicleControllerSettings>), JPH::RefTarget<JPH::VehicleControllerSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::VehicleControllerSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::VehicleControllerSettings>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::VehicleControllerSettings>))
    ));
}

void JPH_RefTarget_JPH_VehicleControllerSettings_Destroy(const JPH_RefTarget_JPH_VehicleControllerSettings *_this)
{
    delete ((const JPH::RefTarget<JPH::VehicleControllerSettings> *)_this);
}

void JPH_RefTarget_JPH_VehicleControllerSettings_DestroyArray(const JPH_RefTarget_JPH_VehicleControllerSettings *_this)
{
    delete[] ((const JPH::RefTarget<JPH::VehicleControllerSettings> *)_this);
}

JPH_RefTarget_JPH_VehicleControllerSettings *JPH_RefTarget_JPH_VehicleControllerSettings_AssignFromAnother(JPH_RefTarget_JPH_VehicleControllerSettings *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_VehicleControllerSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::VehicleControllerSettings>);
    return (JPH_RefTarget_JPH_VehicleControllerSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::VehicleControllerSettings> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::VehicleControllerSettings>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::VehicleControllerSettings>), JPH::RefTarget<JPH::VehicleControllerSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::VehicleControllerSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::VehicleControllerSettings>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::VehicleControllerSettings>)))
    ));
}

void JPH_RefTarget_JPH_VehicleControllerSettings_SetEmbedded(const JPH_RefTarget_JPH_VehicleControllerSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::VehicleControllerSettings> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_VehicleControllerSettings_GetRefCount(const JPH_RefTarget_JPH_VehicleControllerSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::VehicleControllerSettings> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(const JPH_RefTarget_JPH_VehicleControllerSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::VehicleControllerSettings> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_VehicleControllerSettings_Release(const JPH_RefTarget_JPH_VehicleControllerSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::VehicleControllerSettings> *)(_this)).Release();
}

int JPH_RefTarget_JPH_VehicleControllerSettings_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::VehicleControllerSettings>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_RefTarget_JPH_SoftBodySharedSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::SoftBodySharedSettings>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_SoftBodySharedSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_RefTarget_JPH_SoftBodySharedSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_SoftBodySharedSettings *)(new JPH::RefTarget<JPH::SoftBodySharedSettings>[num_elems]);
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

JPH_RefTarget_JPH_Skeleton *JPH_RefTarget_JPH_Skeleton_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::Skeleton>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_Skeleton*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_Skeleton *JPH_RefTarget_JPH_Skeleton_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_Skeleton *)(new JPH::RefTarget<JPH::Skeleton>[num_elems]);
}

const JPH_RefTarget_JPH_Skeleton *JPH_RefTarget_JPH_Skeleton_OffsetPtr(const JPH_RefTarget_JPH_Skeleton *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_Skeleton *)(((const JPH::RefTarget<JPH::Skeleton> *)ptr) + i);
}

JPH_RefTarget_JPH_Skeleton *JPH_RefTarget_JPH_Skeleton_OffsetMutablePtr(JPH_RefTarget_JPH_Skeleton *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_Skeleton *)(((JPH::RefTarget<JPH::Skeleton> *)ptr) + i);
}

JPH_RefTarget_JPH_Skeleton *JPH_RefTarget_JPH_Skeleton_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Skeleton *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::Skeleton>);
    return (JPH_RefTarget_JPH_Skeleton *)new JPH::RefTarget<JPH::Skeleton>(JPH::RefTarget<JPH::Skeleton>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::Skeleton>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::Skeleton>), JPH::RefTarget<JPH::Skeleton>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::Skeleton>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::Skeleton>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::Skeleton>))
    ));
}

void JPH_RefTarget_JPH_Skeleton_Destroy(const JPH_RefTarget_JPH_Skeleton *_this)
{
    delete ((const JPH::RefTarget<JPH::Skeleton> *)_this);
}

void JPH_RefTarget_JPH_Skeleton_DestroyArray(const JPH_RefTarget_JPH_Skeleton *_this)
{
    delete[] ((const JPH::RefTarget<JPH::Skeleton> *)_this);
}

JPH_RefTarget_JPH_Skeleton *JPH_RefTarget_JPH_Skeleton_AssignFromAnother(JPH_RefTarget_JPH_Skeleton *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Skeleton *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::Skeleton>);
    return (JPH_RefTarget_JPH_Skeleton *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::Skeleton> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::Skeleton>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::Skeleton>), JPH::RefTarget<JPH::Skeleton>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::Skeleton>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::Skeleton>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::Skeleton>)))
    ));
}

void JPH_RefTarget_JPH_Skeleton_SetEmbedded(const JPH_RefTarget_JPH_Skeleton *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Skeleton> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_Skeleton_GetRefCount(const JPH_RefTarget_JPH_Skeleton *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Skeleton> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_Skeleton_AddRef(const JPH_RefTarget_JPH_Skeleton *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Skeleton> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_Skeleton_Release(const JPH_RefTarget_JPH_Skeleton *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Skeleton> *)(_this)).Release();
}

int JPH_RefTarget_JPH_Skeleton_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::Skeleton>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_SkeletalAnimation *JPH_RefTarget_JPH_SkeletalAnimation_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::SkeletalAnimation>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_SkeletalAnimation*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_SkeletalAnimation *JPH_RefTarget_JPH_SkeletalAnimation_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_SkeletalAnimation *)(new JPH::RefTarget<JPH::SkeletalAnimation>[num_elems]);
}

const JPH_RefTarget_JPH_SkeletalAnimation *JPH_RefTarget_JPH_SkeletalAnimation_OffsetPtr(const JPH_RefTarget_JPH_SkeletalAnimation *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_SkeletalAnimation *)(((const JPH::RefTarget<JPH::SkeletalAnimation> *)ptr) + i);
}

JPH_RefTarget_JPH_SkeletalAnimation *JPH_RefTarget_JPH_SkeletalAnimation_OffsetMutablePtr(JPH_RefTarget_JPH_SkeletalAnimation *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_SkeletalAnimation *)(((JPH::RefTarget<JPH::SkeletalAnimation> *)ptr) + i);
}

JPH_RefTarget_JPH_SkeletalAnimation *JPH_RefTarget_JPH_SkeletalAnimation_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_SkeletalAnimation *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::SkeletalAnimation>);
    return (JPH_RefTarget_JPH_SkeletalAnimation *)new JPH::RefTarget<JPH::SkeletalAnimation>(JPH::RefTarget<JPH::SkeletalAnimation>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::SkeletalAnimation>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::SkeletalAnimation>), JPH::RefTarget<JPH::SkeletalAnimation>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::SkeletalAnimation>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::SkeletalAnimation>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::SkeletalAnimation>))
    ));
}

void JPH_RefTarget_JPH_SkeletalAnimation_Destroy(const JPH_RefTarget_JPH_SkeletalAnimation *_this)
{
    delete ((const JPH::RefTarget<JPH::SkeletalAnimation> *)_this);
}

void JPH_RefTarget_JPH_SkeletalAnimation_DestroyArray(const JPH_RefTarget_JPH_SkeletalAnimation *_this)
{
    delete[] ((const JPH::RefTarget<JPH::SkeletalAnimation> *)_this);
}

JPH_RefTarget_JPH_SkeletalAnimation *JPH_RefTarget_JPH_SkeletalAnimation_AssignFromAnother(JPH_RefTarget_JPH_SkeletalAnimation *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_SkeletalAnimation *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::SkeletalAnimation>);
    return (JPH_RefTarget_JPH_SkeletalAnimation *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::SkeletalAnimation> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::SkeletalAnimation>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::SkeletalAnimation>), JPH::RefTarget<JPH::SkeletalAnimation>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::SkeletalAnimation>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::SkeletalAnimation>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::SkeletalAnimation>)))
    ));
}

void JPH_RefTarget_JPH_SkeletalAnimation_SetEmbedded(const JPH_RefTarget_JPH_SkeletalAnimation *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::SkeletalAnimation> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_SkeletalAnimation_GetRefCount(const JPH_RefTarget_JPH_SkeletalAnimation *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::SkeletalAnimation> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_SkeletalAnimation_AddRef(const JPH_RefTarget_JPH_SkeletalAnimation *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::SkeletalAnimation> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_SkeletalAnimation_Release(const JPH_RefTarget_JPH_SkeletalAnimation *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::SkeletalAnimation> *)(_this)).Release();
}

int JPH_RefTarget_JPH_SkeletalAnimation_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::SkeletalAnimation>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_RagdollSettings *JPH_RefTarget_JPH_RagdollSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::RagdollSettings>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_RagdollSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_RagdollSettings *JPH_RefTarget_JPH_RagdollSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_RagdollSettings *)(new JPH::RefTarget<JPH::RagdollSettings>[num_elems]);
}

const JPH_RefTarget_JPH_RagdollSettings *JPH_RefTarget_JPH_RagdollSettings_OffsetPtr(const JPH_RefTarget_JPH_RagdollSettings *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_RagdollSettings *)(((const JPH::RefTarget<JPH::RagdollSettings> *)ptr) + i);
}

JPH_RefTarget_JPH_RagdollSettings *JPH_RefTarget_JPH_RagdollSettings_OffsetMutablePtr(JPH_RefTarget_JPH_RagdollSettings *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_RagdollSettings *)(((JPH::RefTarget<JPH::RagdollSettings> *)ptr) + i);
}

JPH_RefTarget_JPH_RagdollSettings *JPH_RefTarget_JPH_RagdollSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_RagdollSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::RagdollSettings>);
    return (JPH_RefTarget_JPH_RagdollSettings *)new JPH::RefTarget<JPH::RagdollSettings>(JPH::RefTarget<JPH::RagdollSettings>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::RagdollSettings>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::RagdollSettings>), JPH::RefTarget<JPH::RagdollSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::RagdollSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::RagdollSettings>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::RagdollSettings>))
    ));
}

void JPH_RefTarget_JPH_RagdollSettings_Destroy(const JPH_RefTarget_JPH_RagdollSettings *_this)
{
    delete ((const JPH::RefTarget<JPH::RagdollSettings> *)_this);
}

void JPH_RefTarget_JPH_RagdollSettings_DestroyArray(const JPH_RefTarget_JPH_RagdollSettings *_this)
{
    delete[] ((const JPH::RefTarget<JPH::RagdollSettings> *)_this);
}

JPH_RefTarget_JPH_RagdollSettings *JPH_RefTarget_JPH_RagdollSettings_AssignFromAnother(JPH_RefTarget_JPH_RagdollSettings *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_RagdollSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::RagdollSettings>);
    return (JPH_RefTarget_JPH_RagdollSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::RagdollSettings> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::RagdollSettings>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::RagdollSettings>), JPH::RefTarget<JPH::RagdollSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::RagdollSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::RagdollSettings>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::RagdollSettings>)))
    ));
}

void JPH_RefTarget_JPH_RagdollSettings_SetEmbedded(const JPH_RefTarget_JPH_RagdollSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::RagdollSettings> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_RagdollSettings_GetRefCount(const JPH_RefTarget_JPH_RagdollSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::RagdollSettings> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_RagdollSettings_AddRef(const JPH_RefTarget_JPH_RagdollSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::RagdollSettings> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_RagdollSettings_Release(const JPH_RefTarget_JPH_RagdollSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::RagdollSettings> *)(_this)).Release();
}

int JPH_RefTarget_JPH_RagdollSettings_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::RagdollSettings>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_Ragdoll *JPH_RefTarget_JPH_Ragdoll_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::Ragdoll>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_Ragdoll*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_Ragdoll *JPH_RefTarget_JPH_Ragdoll_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_Ragdoll *)(new JPH::RefTarget<JPH::Ragdoll>[num_elems]);
}

const JPH_RefTarget_JPH_Ragdoll *JPH_RefTarget_JPH_Ragdoll_OffsetPtr(const JPH_RefTarget_JPH_Ragdoll *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_Ragdoll *)(((const JPH::RefTarget<JPH::Ragdoll> *)ptr) + i);
}

JPH_RefTarget_JPH_Ragdoll *JPH_RefTarget_JPH_Ragdoll_OffsetMutablePtr(JPH_RefTarget_JPH_Ragdoll *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_Ragdoll *)(((JPH::RefTarget<JPH::Ragdoll> *)ptr) + i);
}

JPH_RefTarget_JPH_Ragdoll *JPH_RefTarget_JPH_Ragdoll_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Ragdoll *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::Ragdoll>);
    return (JPH_RefTarget_JPH_Ragdoll *)new JPH::RefTarget<JPH::Ragdoll>(JPH::RefTarget<JPH::Ragdoll>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::Ragdoll>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::Ragdoll>), JPH::RefTarget<JPH::Ragdoll>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::Ragdoll>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::Ragdoll>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::Ragdoll>))
    ));
}

void JPH_RefTarget_JPH_Ragdoll_Destroy(const JPH_RefTarget_JPH_Ragdoll *_this)
{
    delete ((const JPH::RefTarget<JPH::Ragdoll> *)_this);
}

void JPH_RefTarget_JPH_Ragdoll_DestroyArray(const JPH_RefTarget_JPH_Ragdoll *_this)
{
    delete[] ((const JPH::RefTarget<JPH::Ragdoll> *)_this);
}

JPH_RefTarget_JPH_Ragdoll *JPH_RefTarget_JPH_Ragdoll_AssignFromAnother(JPH_RefTarget_JPH_Ragdoll *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_Ragdoll *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::Ragdoll>);
    return (JPH_RefTarget_JPH_Ragdoll *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::Ragdoll> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::Ragdoll>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::Ragdoll>), JPH::RefTarget<JPH::Ragdoll>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::Ragdoll>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::Ragdoll>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::Ragdoll>)))
    ));
}

void JPH_RefTarget_JPH_Ragdoll_SetEmbedded(const JPH_RefTarget_JPH_Ragdoll *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Ragdoll> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_Ragdoll_GetRefCount(const JPH_RefTarget_JPH_Ragdoll *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Ragdoll> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_Ragdoll_AddRef(const JPH_RefTarget_JPH_Ragdoll *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Ragdoll> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_Ragdoll_Release(const JPH_RefTarget_JPH_Ragdoll *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::Ragdoll> *)(_this)).Release();
}

int JPH_RefTarget_JPH_Ragdoll_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::Ragdoll>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_SkeletonMapper *JPH_RefTarget_JPH_SkeletonMapper_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::SkeletonMapper>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_SkeletonMapper*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_SkeletonMapper *JPH_RefTarget_JPH_SkeletonMapper_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_SkeletonMapper *)(new JPH::RefTarget<JPH::SkeletonMapper>[num_elems]);
}

const JPH_RefTarget_JPH_SkeletonMapper *JPH_RefTarget_JPH_SkeletonMapper_OffsetPtr(const JPH_RefTarget_JPH_SkeletonMapper *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_SkeletonMapper *)(((const JPH::RefTarget<JPH::SkeletonMapper> *)ptr) + i);
}

JPH_RefTarget_JPH_SkeletonMapper *JPH_RefTarget_JPH_SkeletonMapper_OffsetMutablePtr(JPH_RefTarget_JPH_SkeletonMapper *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_SkeletonMapper *)(((JPH::RefTarget<JPH::SkeletonMapper> *)ptr) + i);
}

JPH_RefTarget_JPH_SkeletonMapper *JPH_RefTarget_JPH_SkeletonMapper_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_SkeletonMapper *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::SkeletonMapper>);
    return (JPH_RefTarget_JPH_SkeletonMapper *)new JPH::RefTarget<JPH::SkeletonMapper>(JPH::RefTarget<JPH::SkeletonMapper>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::SkeletonMapper>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::SkeletonMapper>), JPH::RefTarget<JPH::SkeletonMapper>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::SkeletonMapper>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::SkeletonMapper>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::SkeletonMapper>))
    ));
}

void JPH_RefTarget_JPH_SkeletonMapper_Destroy(const JPH_RefTarget_JPH_SkeletonMapper *_this)
{
    delete ((const JPH::RefTarget<JPH::SkeletonMapper> *)_this);
}

void JPH_RefTarget_JPH_SkeletonMapper_DestroyArray(const JPH_RefTarget_JPH_SkeletonMapper *_this)
{
    delete[] ((const JPH::RefTarget<JPH::SkeletonMapper> *)_this);
}

JPH_RefTarget_JPH_SkeletonMapper *JPH_RefTarget_JPH_SkeletonMapper_AssignFromAnother(JPH_RefTarget_JPH_SkeletonMapper *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_SkeletonMapper *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::SkeletonMapper>);
    return (JPH_RefTarget_JPH_SkeletonMapper *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::SkeletonMapper> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::SkeletonMapper>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::SkeletonMapper>), JPH::RefTarget<JPH::SkeletonMapper>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::SkeletonMapper>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::SkeletonMapper>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::SkeletonMapper>)))
    ));
}

void JPH_RefTarget_JPH_SkeletonMapper_SetEmbedded(const JPH_RefTarget_JPH_SkeletonMapper *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::SkeletonMapper> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_SkeletonMapper_GetRefCount(const JPH_RefTarget_JPH_SkeletonMapper *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::SkeletonMapper> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_SkeletonMapper_AddRef(const JPH_RefTarget_JPH_SkeletonMapper *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::SkeletonMapper> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_SkeletonMapper_Release(const JPH_RefTarget_JPH_SkeletonMapper *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::SkeletonMapper> *)(_this)).Release();
}

int JPH_RefTarget_JPH_SkeletonMapper_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::SkeletonMapper>::sInternalGetRefCountOffset();
}

JPH_RefTarget_JPH_PathConstraintPath *JPH_RefTarget_JPH_PathConstraintPath_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RefTarget<JPH::PathConstraintPath>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RefTarget_JPH_PathConstraintPath*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RefTarget_JPH_PathConstraintPath *JPH_RefTarget_JPH_PathConstraintPath_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RefTarget_JPH_PathConstraintPath *)(new JPH::RefTarget<JPH::PathConstraintPath>[num_elems]);
}

const JPH_RefTarget_JPH_PathConstraintPath *JPH_RefTarget_JPH_PathConstraintPath_OffsetPtr(const JPH_RefTarget_JPH_PathConstraintPath *ptr, ptrdiff_t i)
{
    return (const JPH_RefTarget_JPH_PathConstraintPath *)(((const JPH::RefTarget<JPH::PathConstraintPath> *)ptr) + i);
}

JPH_RefTarget_JPH_PathConstraintPath *JPH_RefTarget_JPH_PathConstraintPath_OffsetMutablePtr(JPH_RefTarget_JPH_PathConstraintPath *ptr, ptrdiff_t i)
{
    return (JPH_RefTarget_JPH_PathConstraintPath *)(((JPH::RefTarget<JPH::PathConstraintPath> *)ptr) + i);
}

JPH_RefTarget_JPH_PathConstraintPath *JPH_RefTarget_JPH_PathConstraintPath_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_PathConstraintPath *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::PathConstraintPath>);
    return (JPH_RefTarget_JPH_PathConstraintPath *)new JPH::RefTarget<JPH::PathConstraintPath>(JPH::RefTarget<JPH::PathConstraintPath>(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::PathConstraintPath>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::PathConstraintPath>), JPH::RefTarget<JPH::PathConstraintPath>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::PathConstraintPath>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::PathConstraintPath>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::PathConstraintPath>))
    ));
}

void JPH_RefTarget_JPH_PathConstraintPath_Destroy(const JPH_RefTarget_JPH_PathConstraintPath *_this)
{
    delete ((const JPH::RefTarget<JPH::PathConstraintPath> *)_this);
}

void JPH_RefTarget_JPH_PathConstraintPath_DestroyArray(const JPH_RefTarget_JPH_PathConstraintPath *_this)
{
    delete[] ((const JPH::RefTarget<JPH::PathConstraintPath> *)_this);
}

JPH_RefTarget_JPH_PathConstraintPath *JPH_RefTarget_JPH_PathConstraintPath_AssignFromAnother(JPH_RefTarget_JPH_PathConstraintPath *_this, Jolt_PassBy _other_pass_by, JPH_RefTarget_JPH_PathConstraintPath *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RefTarget<JPH::PathConstraintPath>);
    return (JPH_RefTarget_JPH_PathConstraintPath *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RefTarget<JPH::PathConstraintPath> *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RefTarget<JPH::PathConstraintPath>) MRBINDC_CLASSARG_COPY(_other, (JPH::RefTarget<JPH::PathConstraintPath>), JPH::RefTarget<JPH::PathConstraintPath>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RefTarget<JPH::PathConstraintPath>) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RefTarget<JPH::PathConstraintPath>) MRBINDC_CLASSARG_END(_other, JPH::RefTarget<JPH::PathConstraintPath>)))
    ));
}

void JPH_RefTarget_JPH_PathConstraintPath_SetEmbedded(const JPH_RefTarget_JPH_PathConstraintPath *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::PathConstraintPath> *)(_this)).SetEmbedded();
}

unsigned int JPH_RefTarget_JPH_PathConstraintPath_GetRefCount(const JPH_RefTarget_JPH_PathConstraintPath *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::PathConstraintPath> *)(_this)).GetRefCount();
}

void JPH_RefTarget_JPH_PathConstraintPath_AddRef(const JPH_RefTarget_JPH_PathConstraintPath *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::PathConstraintPath> *)(_this)).AddRef();
}

void JPH_RefTarget_JPH_PathConstraintPath_Release(const JPH_RefTarget_JPH_PathConstraintPath *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RefTarget<JPH::PathConstraintPath> *)(_this)).Release();
}

int JPH_RefTarget_JPH_PathConstraintPath_sInternalGetRefCountOffset(void)
{
    return JPH::RefTarget<JPH::PathConstraintPath>::sInternalGetRefCountOffset();
}

