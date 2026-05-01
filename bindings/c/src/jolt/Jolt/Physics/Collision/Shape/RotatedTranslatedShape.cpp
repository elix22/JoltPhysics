// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/RotatedTranslatedShape.h"

#include <Jolt/Core/Color.h>
#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Geometry/Plane.h>
#include <Jolt/Math/DMat44.h>
#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Collision/CastResult.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/RayCast.h>
#include <Jolt/Physics/Collision/Shape/DecoratedShape.h>
#include <Jolt/Physics/Collision/Shape/RotatedTranslatedShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/TransformedShape.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_RotatedTranslatedShapeSettings_Get_mPosition(const JPH_RotatedTranslatedShapeSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShapeSettings *)(_this)).mPosition);
}

JPH_Vec3 *JPH_RotatedTranslatedShapeSettings_GetMutable_mPosition(JPH_RotatedTranslatedShapeSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RotatedTranslatedShapeSettings *)(_this)).mPosition);
}

const JPH_Quat *JPH_RotatedTranslatedShapeSettings_Get_mRotation(const JPH_RotatedTranslatedShapeSettings *_this)
{
    return (const JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShapeSettings *)(_this)).mRotation);
}

JPH_Quat *JPH_RotatedTranslatedShapeSettings_GetMutable_mRotation(JPH_RotatedTranslatedShapeSettings *_this)
{
    return (JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RotatedTranslatedShapeSettings *)(_this)).mRotation);
}

const uint64_t *JPH_RotatedTranslatedShapeSettings_Get_mUserData(const JPH_RotatedTranslatedShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShapeSettings *)(_this)).mUserData);
}

void JPH_RotatedTranslatedShapeSettings_Set_mUserData(JPH_RotatedTranslatedShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RotatedTranslatedShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_RotatedTranslatedShapeSettings_GetMutable_mUserData(JPH_RotatedTranslatedShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RotatedTranslatedShapeSettings *)(_this)).mUserData);
}

JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RotatedTranslatedShapeSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RotatedTranslatedShapeSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RotatedTranslatedShapeSettings *)(new JPH::RotatedTranslatedShapeSettings[num_elems]{});
}

const JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_OffsetPtr(const JPH_RotatedTranslatedShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_RotatedTranslatedShapeSettings *)(((const JPH::RotatedTranslatedShapeSettings *)ptr) + i);
}

JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_OffsetMutablePtr(JPH_RotatedTranslatedShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_RotatedTranslatedShapeSettings *)(((JPH::RotatedTranslatedShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_RotatedTranslatedShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::RotatedTranslatedShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_RotatedTranslatedShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_RotatedTranslatedShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::RotatedTranslatedShapeSettings *)object)
    ));
}

const JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_RotatedTranslatedShapeSettings *)(static_cast<const JPH::RotatedTranslatedShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_RotatedTranslatedShapeSettings *)(static_cast<JPH::RotatedTranslatedShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_RotatedTranslatedShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::RotatedTranslatedShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_RotatedTranslatedShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_RotatedTranslatedShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::RotatedTranslatedShapeSettings *)object)
    ));
}

const JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_RotatedTranslatedShapeSettings *)(static_cast<const JPH::RotatedTranslatedShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_RotatedTranslatedShapeSettings *)(static_cast<JPH::RotatedTranslatedShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_RotatedTranslatedShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::RotatedTranslatedShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_RotatedTranslatedShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_RotatedTranslatedShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::RotatedTranslatedShapeSettings *)object)
    ));
}

const JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_RotatedTranslatedShapeSettings *)(static_cast<const JPH::RotatedTranslatedShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_RotatedTranslatedShapeSettings *)(static_cast<JPH::RotatedTranslatedShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const JPH_DecoratedShapeSettings *JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_DecoratedShapeSettings(const JPH_RotatedTranslatedShapeSettings *object)
{
    return (const JPH_DecoratedShapeSettings *)(static_cast<const JPH::DecoratedShapeSettings *>(
        ((const JPH::RotatedTranslatedShapeSettings *)object)
    ));
}

JPH_DecoratedShapeSettings *JPH_RotatedTranslatedShapeSettings_MutableUpcastTo_JPH_DecoratedShapeSettings(JPH_RotatedTranslatedShapeSettings *object)
{
    return (JPH_DecoratedShapeSettings *)(static_cast<JPH::DecoratedShapeSettings *>(
        ((JPH::RotatedTranslatedShapeSettings *)object)
    ));
}

const JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_StaticDowncastFrom_JPH_DecoratedShapeSettings(const JPH_DecoratedShapeSettings *object)
{
    return (const JPH_RotatedTranslatedShapeSettings *)(static_cast<const JPH::RotatedTranslatedShapeSettings *>(
        ((const JPH::DecoratedShapeSettings *)object)
    ));
}

JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_MutableStaticDowncastFrom_JPH_DecoratedShapeSettings(JPH_DecoratedShapeSettings *object)
{
    return (JPH_RotatedTranslatedShapeSettings *)(static_cast<JPH::RotatedTranslatedShapeSettings *>(
        ((JPH::DecoratedShapeSettings *)object)
    ));
}

JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RotatedTranslatedShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RotatedTranslatedShapeSettings);
    return (JPH_RotatedTranslatedShapeSettings *)new JPH::RotatedTranslatedShapeSettings(JPH::RotatedTranslatedShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RotatedTranslatedShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::RotatedTranslatedShapeSettings), JPH::RotatedTranslatedShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::RotatedTranslatedShapeSettings), JPH::RotatedTranslatedShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RotatedTranslatedShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RotatedTranslatedShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::RotatedTranslatedShapeSettings))
    ));
}

JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_Construct_const_JPH_ShapeSettings_ptr(const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const JPH_ShapeSettings *inShape)
{
    return (JPH_RotatedTranslatedShapeSettings *)new JPH::RotatedTranslatedShapeSettings(JPH::RotatedTranslatedShapeSettings(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((const JPH::ShapeSettings *)inShape)
    ));
}

JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_Construct_const_JPH_Shape_ptr(const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const JPH_Shape *inShape)
{
    return (JPH_RotatedTranslatedShapeSettings *)new JPH::RotatedTranslatedShapeSettings(JPH::RotatedTranslatedShapeSettings(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((const JPH::Shape *)inShape)
    ));
}

void JPH_RotatedTranslatedShapeSettings_Destroy(const JPH_RotatedTranslatedShapeSettings *_this)
{
    delete ((const JPH::RotatedTranslatedShapeSettings *)_this);
}

void JPH_RotatedTranslatedShapeSettings_DestroyArray(const JPH_RotatedTranslatedShapeSettings *_this)
{
    delete[] ((const JPH::RotatedTranslatedShapeSettings *)_this);
}

JPH_RotatedTranslatedShapeSettings *JPH_RotatedTranslatedShapeSettings_AssignFromAnother(JPH_RotatedTranslatedShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_RotatedTranslatedShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RotatedTranslatedShapeSettings);
    return (JPH_RotatedTranslatedShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RotatedTranslatedShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RotatedTranslatedShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::RotatedTranslatedShapeSettings), JPH::RotatedTranslatedShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::RotatedTranslatedShapeSettings), JPH::RotatedTranslatedShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RotatedTranslatedShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RotatedTranslatedShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::RotatedTranslatedShapeSettings))
    ));
}

void *Jolt_new_JPH_RotatedTranslatedShapeSettings_size_t(size_t inCount)
{
    return JPH::RotatedTranslatedShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr(void *inPointer)
{
    JPH::RotatedTranslatedShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RotatedTranslatedShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_RotatedTranslatedShapeSettings_size_t(size_t inCount)
{
    return JPH::RotatedTranslatedShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr(void *inPointer)
{
    JPH::RotatedTranslatedShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RotatedTranslatedShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_RotatedTranslatedShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RotatedTranslatedShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RotatedTranslatedShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_RotatedTranslatedShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RotatedTranslatedShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RotatedTranslatedShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_RotatedTranslatedShapeSettings_ClearCachedResult(JPH_RotatedTranslatedShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RotatedTranslatedShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_RotatedTranslatedShapeSettings_SetEmbedded(const JPH_RotatedTranslatedShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_RotatedTranslatedShapeSettings_GetRefCount(const JPH_RotatedTranslatedShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShapeSettings *)(_this)).GetRefCount();
}

void JPH_RotatedTranslatedShapeSettings_AddRef(const JPH_RotatedTranslatedShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShapeSettings *)(_this)).AddRef();
}

void JPH_RotatedTranslatedShapeSettings_Release(const JPH_RotatedTranslatedShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShapeSettings *)(_this)).Release();
}

int JPH_RotatedTranslatedShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::RotatedTranslatedShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_RotatedTranslatedShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::RotatedTranslatedShape::cGetTrianglesMinTrianglesRequested);
}

const bool *JPH_RotatedTranslatedShape_Get_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::RotatedTranslatedShape::sDrawSubmergedVolumes);
}

void JPH_RotatedTranslatedShape_Set_sDrawSubmergedVolumes(bool value)
{
    JPH::RotatedTranslatedShape::sDrawSubmergedVolumes = value;
}

bool *JPH_RotatedTranslatedShape_GetMutable_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::RotatedTranslatedShape::sDrawSubmergedVolumes);
}

JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RotatedTranslatedShape;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RotatedTranslatedShape*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RotatedTranslatedShape *)(new JPH::RotatedTranslatedShape[num_elems]{});
}

const JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_OffsetPtr(const JPH_RotatedTranslatedShape *ptr, ptrdiff_t i)
{
    return (const JPH_RotatedTranslatedShape *)(((const JPH::RotatedTranslatedShape *)ptr) + i);
}

JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_OffsetMutablePtr(JPH_RotatedTranslatedShape *ptr, ptrdiff_t i)
{
    return (JPH_RotatedTranslatedShape *)(((JPH::RotatedTranslatedShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_RotatedTranslatedShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_RotatedTranslatedShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::RotatedTranslatedShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_RotatedTranslatedShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_RotatedTranslatedShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::RotatedTranslatedShape *)object)
    ));
}

const JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_RotatedTranslatedShape *)(static_cast<const JPH::RotatedTranslatedShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_RotatedTranslatedShape *)(static_cast<JPH::RotatedTranslatedShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_RotatedTranslatedShape_UpcastTo_JPH_NonCopyable(const JPH_RotatedTranslatedShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::RotatedTranslatedShape *)object)
    ));
}

JPH_NonCopyable *JPH_RotatedTranslatedShape_MutableUpcastTo_JPH_NonCopyable(JPH_RotatedTranslatedShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::RotatedTranslatedShape *)object)
    ));
}

const JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_RotatedTranslatedShape *)(static_cast<const JPH::RotatedTranslatedShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_RotatedTranslatedShape *)(static_cast<JPH::RotatedTranslatedShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_RotatedTranslatedShape_UpcastTo_JPH_Shape(const JPH_RotatedTranslatedShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::RotatedTranslatedShape *)object)
    ));
}

JPH_Shape *JPH_RotatedTranslatedShape_MutableUpcastTo_JPH_Shape(JPH_RotatedTranslatedShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::RotatedTranslatedShape *)object)
    ));
}

const JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_RotatedTranslatedShape *)(static_cast<const JPH::RotatedTranslatedShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_RotatedTranslatedShape *)(static_cast<JPH::RotatedTranslatedShape *>(
        ((JPH::Shape *)object)
    ));
}

const JPH_DecoratedShape *JPH_RotatedTranslatedShape_UpcastTo_JPH_DecoratedShape(const JPH_RotatedTranslatedShape *object)
{
    return (const JPH_DecoratedShape *)(static_cast<const JPH::DecoratedShape *>(
        ((const JPH::RotatedTranslatedShape *)object)
    ));
}

JPH_DecoratedShape *JPH_RotatedTranslatedShape_MutableUpcastTo_JPH_DecoratedShape(JPH_RotatedTranslatedShape *object)
{
    return (JPH_DecoratedShape *)(static_cast<JPH::DecoratedShape *>(
        ((JPH::RotatedTranslatedShape *)object)
    ));
}

const JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_StaticDowncastFrom_JPH_DecoratedShape(const JPH_DecoratedShape *object)
{
    return (const JPH_RotatedTranslatedShape *)(static_cast<const JPH::RotatedTranslatedShape *>(
        ((const JPH::DecoratedShape *)object)
    ));
}

JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_MutableStaticDowncastFrom_JPH_DecoratedShape(JPH_DecoratedShape *object)
{
    return (JPH_RotatedTranslatedShape *)(static_cast<JPH::RotatedTranslatedShape *>(
        ((JPH::DecoratedShape *)object)
    ));
}

JPH_RotatedTranslatedShape *JPH_RotatedTranslatedShape_Construct_3(const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const JPH_Shape *inShape)
{
    return (JPH_RotatedTranslatedShape *)new JPH::RotatedTranslatedShape(JPH::RotatedTranslatedShape(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((const JPH::Shape *)inShape)
    ));
}

void JPH_RotatedTranslatedShape_Destroy(const JPH_RotatedTranslatedShape *_this)
{
    delete ((const JPH::RotatedTranslatedShape *)_this);
}

void JPH_RotatedTranslatedShape_DestroyArray(const JPH_RotatedTranslatedShape *_this)
{
    delete[] ((const JPH::RotatedTranslatedShape *)_this);
}

JPH_AABox *JPH_RotatedTranslatedShape_GetWorldSpaceBounds_JPH_DMat44(const JPH_RotatedTranslatedShape *_this, const JPH_DMat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::DMat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void *Jolt_new_JPH_RotatedTranslatedShape_size_t(size_t inCount)
{
    return JPH::RotatedTranslatedShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_RotatedTranslatedShape_void_ptr(void *inPointer)
{
    JPH::RotatedTranslatedShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_RotatedTranslatedShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RotatedTranslatedShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_RotatedTranslatedShape_size_t(size_t inCount)
{
    return JPH::RotatedTranslatedShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr(void *inPointer)
{
    JPH::RotatedTranslatedShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RotatedTranslatedShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_RotatedTranslatedShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RotatedTranslatedShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_RotatedTranslatedShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RotatedTranslatedShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_RotatedTranslatedShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RotatedTranslatedShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RotatedTranslatedShape::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_Quat *JPH_RotatedTranslatedShape_GetRotation(const JPH_RotatedTranslatedShape *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetRotation());
}

JPH_Vec3 *JPH_RotatedTranslatedShape_GetPosition(const JPH_RotatedTranslatedShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetPosition());
}

JPH_Vec3 *JPH_RotatedTranslatedShape_GetCenterOfMass(const JPH_RotatedTranslatedShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetCenterOfMass());
}

JPH_AABox *JPH_RotatedTranslatedShape_GetLocalBounds(const JPH_RotatedTranslatedShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetLocalBounds());
}

JPH_AABox *JPH_RotatedTranslatedShape_GetWorldSpaceBounds_JPH_Mat44(const JPH_RotatedTranslatedShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

float JPH_RotatedTranslatedShape_GetInnerRadius(const JPH_RotatedTranslatedShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetInnerRadius();
}

JPH_TransformedShape *JPH_RotatedTranslatedShape_GetSubShapeTransformedShape(const JPH_RotatedTranslatedShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder)
{
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetSubShapeTransformedShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

JPH_Vec3 *JPH_RotatedTranslatedShape_GetSurfaceNormal(const JPH_RotatedTranslatedShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

void JPH_RotatedTranslatedShape_GetSubmergedVolume(const JPH_RotatedTranslatedShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy)),
        ((inBaseOffset ? void() : MRBINDC_THROW("Parameter `inBaseOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBaseOffset))
    );
}

void JPH_RotatedTranslatedShape_Draw(const JPH_RotatedTranslatedShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).Draw(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inUseMaterialColors,
        inDrawWireframe
    );
}

void JPH_RotatedTranslatedShape_DrawGetSupportFunction(const JPH_RotatedTranslatedShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).DrawGetSupportFunction(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inDrawSupportDirection
    );
}

void JPH_RotatedTranslatedShape_DrawGetSupportingFace(const JPH_RotatedTranslatedShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).DrawGetSupportingFace(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

bool JPH_RotatedTranslatedShape_CastRay_3(const JPH_RotatedTranslatedShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).CastRay(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RayCast *)(inRay)),
        ((inSubShapeIDCreator ? void() : MRBINDC_THROW("Parameter `inSubShapeIDCreator` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(inSubShapeIDCreator)),
        ((ioHit ? void() : MRBINDC_THROW("Parameter `ioHit` can not be null.", void)), *(JPH::RayCastResult *)(ioHit))
    );
}

void JPH_RotatedTranslatedShape_GetTrianglesStart(const JPH_RotatedTranslatedShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_RotatedTranslatedShape_GetTrianglesNext(const JPH_RotatedTranslatedShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

JPH_Shape_Stats *JPH_RotatedTranslatedShape_GetStats(const JPH_RotatedTranslatedShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetStats());
}

float JPH_RotatedTranslatedShape_GetVolume(const JPH_RotatedTranslatedShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetVolume();
}

bool JPH_RotatedTranslatedShape_IsValidScale(const JPH_RotatedTranslatedShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_RotatedTranslatedShape_MakeScaleValid(const JPH_RotatedTranslatedShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

JPH_Vec3 *JPH_RotatedTranslatedShape_TransformScale(const JPH_RotatedTranslatedShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).TransformScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_RotatedTranslatedShape_sRegister(void)
{
    JPH::RotatedTranslatedShape::sRegister();
}

const JPH_Shape *JPH_RotatedTranslatedShape_GetInnerShape(const JPH_RotatedTranslatedShape *_this)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetInnerShape());
}

bool JPH_RotatedTranslatedShape_MustBeStatic(const JPH_RotatedTranslatedShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).MustBeStatic();
}

unsigned int JPH_RotatedTranslatedShape_GetSubShapeIDBitsRecursive(const JPH_RotatedTranslatedShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetSubShapeIDBitsRecursive();
}

const JPH_Shape *JPH_RotatedTranslatedShape_GetLeafShape(const JPH_RotatedTranslatedShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

const JPH_PhysicsMaterial *JPH_RotatedTranslatedShape_GetMaterial(const JPH_RotatedTranslatedShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetMaterial(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

uint64_t JPH_RotatedTranslatedShape_GetSubShapeUserData(const JPH_RotatedTranslatedShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

uint64_t JPH_RotatedTranslatedShape_GetUserData(const JPH_RotatedTranslatedShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetUserData();
}

void JPH_RotatedTranslatedShape_SetUserData(JPH_RotatedTranslatedShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RotatedTranslatedShape *)(_this)).SetUserData(
        inUserData
    );
}

void JPH_RotatedTranslatedShape_SetEmbedded(const JPH_RotatedTranslatedShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).SetEmbedded();
}

unsigned int JPH_RotatedTranslatedShape_GetRefCount(const JPH_RotatedTranslatedShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).GetRefCount();
}

void JPH_RotatedTranslatedShape_AddRef(const JPH_RotatedTranslatedShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).AddRef();
}

void JPH_RotatedTranslatedShape_Release(const JPH_RotatedTranslatedShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RotatedTranslatedShape *)(_this)).Release();
}

int JPH_RotatedTranslatedShape_sInternalGetRefCountOffset(void)
{
    return JPH::RotatedTranslatedShape::sInternalGetRefCountOffset();
}

