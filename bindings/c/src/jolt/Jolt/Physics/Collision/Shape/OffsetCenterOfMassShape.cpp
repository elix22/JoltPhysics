// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/OffsetCenterOfMassShape.h"

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
#include <Jolt/Physics/Collision/Shape/OffsetCenterOfMassShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/TransformedShape.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_OffsetCenterOfMassShapeSettings_Get_mOffset(const JPH_OffsetCenterOfMassShapeSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShapeSettings *)(_this)).mOffset);
}

JPH_Vec3 *JPH_OffsetCenterOfMassShapeSettings_GetMutable_mOffset(JPH_OffsetCenterOfMassShapeSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::OffsetCenterOfMassShapeSettings *)(_this)).mOffset);
}

const uint64_t *JPH_OffsetCenterOfMassShapeSettings_Get_mUserData(const JPH_OffsetCenterOfMassShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShapeSettings *)(_this)).mUserData);
}

void JPH_OffsetCenterOfMassShapeSettings_Set_mUserData(JPH_OffsetCenterOfMassShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::OffsetCenterOfMassShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_OffsetCenterOfMassShapeSettings_GetMutable_mUserData(JPH_OffsetCenterOfMassShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::OffsetCenterOfMassShapeSettings *)(_this)).mUserData);
}

JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::OffsetCenterOfMassShapeSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_OffsetCenterOfMassShapeSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_OffsetCenterOfMassShapeSettings *)(new JPH::OffsetCenterOfMassShapeSettings[num_elems]{});
}

const JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_OffsetPtr(const JPH_OffsetCenterOfMassShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_OffsetCenterOfMassShapeSettings *)(((const JPH::OffsetCenterOfMassShapeSettings *)ptr) + i);
}

JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_OffsetMutablePtr(JPH_OffsetCenterOfMassShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_OffsetCenterOfMassShapeSettings *)(((JPH::OffsetCenterOfMassShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_OffsetCenterOfMassShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::OffsetCenterOfMassShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_OffsetCenterOfMassShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_OffsetCenterOfMassShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::OffsetCenterOfMassShapeSettings *)object)
    ));
}

const JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_OffsetCenterOfMassShapeSettings *)(static_cast<const JPH::OffsetCenterOfMassShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_OffsetCenterOfMassShapeSettings *)(static_cast<JPH::OffsetCenterOfMassShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_OffsetCenterOfMassShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::OffsetCenterOfMassShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_OffsetCenterOfMassShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_OffsetCenterOfMassShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::OffsetCenterOfMassShapeSettings *)object)
    ));
}

const JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_OffsetCenterOfMassShapeSettings *)(static_cast<const JPH::OffsetCenterOfMassShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_OffsetCenterOfMassShapeSettings *)(static_cast<JPH::OffsetCenterOfMassShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_OffsetCenterOfMassShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::OffsetCenterOfMassShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_OffsetCenterOfMassShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_OffsetCenterOfMassShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::OffsetCenterOfMassShapeSettings *)object)
    ));
}

const JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_OffsetCenterOfMassShapeSettings *)(static_cast<const JPH::OffsetCenterOfMassShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_OffsetCenterOfMassShapeSettings *)(static_cast<JPH::OffsetCenterOfMassShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const JPH_DecoratedShapeSettings *JPH_OffsetCenterOfMassShapeSettings_UpcastTo_JPH_DecoratedShapeSettings(const JPH_OffsetCenterOfMassShapeSettings *object)
{
    return (const JPH_DecoratedShapeSettings *)(static_cast<const JPH::DecoratedShapeSettings *>(
        ((const JPH::OffsetCenterOfMassShapeSettings *)object)
    ));
}

JPH_DecoratedShapeSettings *JPH_OffsetCenterOfMassShapeSettings_MutableUpcastTo_JPH_DecoratedShapeSettings(JPH_OffsetCenterOfMassShapeSettings *object)
{
    return (JPH_DecoratedShapeSettings *)(static_cast<JPH::DecoratedShapeSettings *>(
        ((JPH::OffsetCenterOfMassShapeSettings *)object)
    ));
}

const JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_StaticDowncastFrom_JPH_DecoratedShapeSettings(const JPH_DecoratedShapeSettings *object)
{
    return (const JPH_OffsetCenterOfMassShapeSettings *)(static_cast<const JPH::OffsetCenterOfMassShapeSettings *>(
        ((const JPH::DecoratedShapeSettings *)object)
    ));
}

JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_MutableStaticDowncastFrom_JPH_DecoratedShapeSettings(JPH_DecoratedShapeSettings *object)
{
    return (JPH_OffsetCenterOfMassShapeSettings *)(static_cast<JPH::OffsetCenterOfMassShapeSettings *>(
        ((JPH::DecoratedShapeSettings *)object)
    ));
}

JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_OffsetCenterOfMassShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::OffsetCenterOfMassShapeSettings);
    return (JPH_OffsetCenterOfMassShapeSettings *)new JPH::OffsetCenterOfMassShapeSettings(JPH::OffsetCenterOfMassShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::OffsetCenterOfMassShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::OffsetCenterOfMassShapeSettings), JPH::OffsetCenterOfMassShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::OffsetCenterOfMassShapeSettings), JPH::OffsetCenterOfMassShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::OffsetCenterOfMassShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::OffsetCenterOfMassShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::OffsetCenterOfMassShapeSettings))
    ));
}

JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_ShapeSettings_ptr(const JPH_Vec3 *inOffset, const JPH_ShapeSettings *inShape)
{
    return (JPH_OffsetCenterOfMassShapeSettings *)new JPH::OffsetCenterOfMassShapeSettings(JPH::OffsetCenterOfMassShapeSettings(
        ((inOffset ? void() : MRBINDC_THROW("Parameter `inOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOffset)),
        ((const JPH::ShapeSettings *)inShape)
    ));
}

JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_Construct_const_JPH_Shape_ptr(const JPH_Vec3 *inOffset, const JPH_Shape *inShape)
{
    return (JPH_OffsetCenterOfMassShapeSettings *)new JPH::OffsetCenterOfMassShapeSettings(JPH::OffsetCenterOfMassShapeSettings(
        ((inOffset ? void() : MRBINDC_THROW("Parameter `inOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOffset)),
        ((const JPH::Shape *)inShape)
    ));
}

void JPH_OffsetCenterOfMassShapeSettings_Destroy(const JPH_OffsetCenterOfMassShapeSettings *_this)
{
    delete ((const JPH::OffsetCenterOfMassShapeSettings *)_this);
}

void JPH_OffsetCenterOfMassShapeSettings_DestroyArray(const JPH_OffsetCenterOfMassShapeSettings *_this)
{
    delete[] ((const JPH::OffsetCenterOfMassShapeSettings *)_this);
}

JPH_OffsetCenterOfMassShapeSettings *JPH_OffsetCenterOfMassShapeSettings_AssignFromAnother(JPH_OffsetCenterOfMassShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_OffsetCenterOfMassShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::OffsetCenterOfMassShapeSettings);
    return (JPH_OffsetCenterOfMassShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::OffsetCenterOfMassShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::OffsetCenterOfMassShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::OffsetCenterOfMassShapeSettings), JPH::OffsetCenterOfMassShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::OffsetCenterOfMassShapeSettings), JPH::OffsetCenterOfMassShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::OffsetCenterOfMassShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::OffsetCenterOfMassShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::OffsetCenterOfMassShapeSettings))
    ));
}

void *Jolt_new_JPH_OffsetCenterOfMassShapeSettings_size_t(size_t inCount)
{
    return JPH::OffsetCenterOfMassShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr(void *inPointer)
{
    JPH::OffsetCenterOfMassShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::OffsetCenterOfMassShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_OffsetCenterOfMassShapeSettings_size_t(size_t inCount)
{
    return JPH::OffsetCenterOfMassShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr(void *inPointer)
{
    JPH::OffsetCenterOfMassShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::OffsetCenterOfMassShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_OffsetCenterOfMassShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::OffsetCenterOfMassShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_OffsetCenterOfMassShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::OffsetCenterOfMassShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_OffsetCenterOfMassShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::OffsetCenterOfMassShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_OffsetCenterOfMassShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::OffsetCenterOfMassShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_OffsetCenterOfMassShapeSettings_ClearCachedResult(JPH_OffsetCenterOfMassShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::OffsetCenterOfMassShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_OffsetCenterOfMassShapeSettings_SetEmbedded(const JPH_OffsetCenterOfMassShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_OffsetCenterOfMassShapeSettings_GetRefCount(const JPH_OffsetCenterOfMassShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShapeSettings *)(_this)).GetRefCount();
}

void JPH_OffsetCenterOfMassShapeSettings_AddRef(const JPH_OffsetCenterOfMassShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShapeSettings *)(_this)).AddRef();
}

void JPH_OffsetCenterOfMassShapeSettings_Release(const JPH_OffsetCenterOfMassShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShapeSettings *)(_this)).Release();
}

int JPH_OffsetCenterOfMassShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::OffsetCenterOfMassShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_OffsetCenterOfMassShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::OffsetCenterOfMassShape::cGetTrianglesMinTrianglesRequested);
}

JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_DefaultConstruct(void)
{
    using _mrbind_T = JPH::OffsetCenterOfMassShape;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_OffsetCenterOfMassShape*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_OffsetCenterOfMassShape *)(new JPH::OffsetCenterOfMassShape[num_elems]{});
}

const JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_OffsetPtr(const JPH_OffsetCenterOfMassShape *ptr, ptrdiff_t i)
{
    return (const JPH_OffsetCenterOfMassShape *)(((const JPH::OffsetCenterOfMassShape *)ptr) + i);
}

JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_OffsetMutablePtr(JPH_OffsetCenterOfMassShape *ptr, ptrdiff_t i)
{
    return (JPH_OffsetCenterOfMassShape *)(((JPH::OffsetCenterOfMassShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_OffsetCenterOfMassShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_OffsetCenterOfMassShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::OffsetCenterOfMassShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_OffsetCenterOfMassShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_OffsetCenterOfMassShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::OffsetCenterOfMassShape *)object)
    ));
}

const JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_OffsetCenterOfMassShape *)(static_cast<const JPH::OffsetCenterOfMassShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_OffsetCenterOfMassShape *)(static_cast<JPH::OffsetCenterOfMassShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_OffsetCenterOfMassShape_UpcastTo_JPH_NonCopyable(const JPH_OffsetCenterOfMassShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::OffsetCenterOfMassShape *)object)
    ));
}

JPH_NonCopyable *JPH_OffsetCenterOfMassShape_MutableUpcastTo_JPH_NonCopyable(JPH_OffsetCenterOfMassShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::OffsetCenterOfMassShape *)object)
    ));
}

const JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_OffsetCenterOfMassShape *)(static_cast<const JPH::OffsetCenterOfMassShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_OffsetCenterOfMassShape *)(static_cast<JPH::OffsetCenterOfMassShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_OffsetCenterOfMassShape_UpcastTo_JPH_Shape(const JPH_OffsetCenterOfMassShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::OffsetCenterOfMassShape *)object)
    ));
}

JPH_Shape *JPH_OffsetCenterOfMassShape_MutableUpcastTo_JPH_Shape(JPH_OffsetCenterOfMassShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::OffsetCenterOfMassShape *)object)
    ));
}

const JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_OffsetCenterOfMassShape *)(static_cast<const JPH::OffsetCenterOfMassShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_OffsetCenterOfMassShape *)(static_cast<JPH::OffsetCenterOfMassShape *>(
        ((JPH::Shape *)object)
    ));
}

const JPH_DecoratedShape *JPH_OffsetCenterOfMassShape_UpcastTo_JPH_DecoratedShape(const JPH_OffsetCenterOfMassShape *object)
{
    return (const JPH_DecoratedShape *)(static_cast<const JPH::DecoratedShape *>(
        ((const JPH::OffsetCenterOfMassShape *)object)
    ));
}

JPH_DecoratedShape *JPH_OffsetCenterOfMassShape_MutableUpcastTo_JPH_DecoratedShape(JPH_OffsetCenterOfMassShape *object)
{
    return (JPH_DecoratedShape *)(static_cast<JPH::DecoratedShape *>(
        ((JPH::OffsetCenterOfMassShape *)object)
    ));
}

const JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_StaticDowncastFrom_JPH_DecoratedShape(const JPH_DecoratedShape *object)
{
    return (const JPH_OffsetCenterOfMassShape *)(static_cast<const JPH::OffsetCenterOfMassShape *>(
        ((const JPH::DecoratedShape *)object)
    ));
}

JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_MutableStaticDowncastFrom_JPH_DecoratedShape(JPH_DecoratedShape *object)
{
    return (JPH_OffsetCenterOfMassShape *)(static_cast<JPH::OffsetCenterOfMassShape *>(
        ((JPH::DecoratedShape *)object)
    ));
}

JPH_OffsetCenterOfMassShape *JPH_OffsetCenterOfMassShape_Construct_const_JPH_Shape_ptr(const JPH_Shape *inShape, const JPH_Vec3 *inOffset)
{
    return (JPH_OffsetCenterOfMassShape *)new JPH::OffsetCenterOfMassShape(JPH::OffsetCenterOfMassShape(
        ((const JPH::Shape *)inShape),
        ((inOffset ? void() : MRBINDC_THROW("Parameter `inOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOffset))
    ));
}

void JPH_OffsetCenterOfMassShape_Destroy(const JPH_OffsetCenterOfMassShape *_this)
{
    delete ((const JPH::OffsetCenterOfMassShape *)_this);
}

void JPH_OffsetCenterOfMassShape_DestroyArray(const JPH_OffsetCenterOfMassShape *_this)
{
    delete[] ((const JPH::OffsetCenterOfMassShape *)_this);
}

JPH_AABox *JPH_OffsetCenterOfMassShape_GetWorldSpaceBounds_JPH_DMat44(const JPH_OffsetCenterOfMassShape *_this, const JPH_DMat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::DMat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void *Jolt_new_JPH_OffsetCenterOfMassShape_size_t(size_t inCount)
{
    return JPH::OffsetCenterOfMassShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr(void *inPointer)
{
    JPH::OffsetCenterOfMassShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::OffsetCenterOfMassShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_OffsetCenterOfMassShape_size_t(size_t inCount)
{
    return JPH::OffsetCenterOfMassShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr(void *inPointer)
{
    JPH::OffsetCenterOfMassShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::OffsetCenterOfMassShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_OffsetCenterOfMassShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::OffsetCenterOfMassShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_OffsetCenterOfMassShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::OffsetCenterOfMassShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_OffsetCenterOfMassShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::OffsetCenterOfMassShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_OffsetCenterOfMassShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::OffsetCenterOfMassShape::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_Vec3 *JPH_OffsetCenterOfMassShape_GetOffset(const JPH_OffsetCenterOfMassShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetOffset());
}

JPH_Vec3 *JPH_OffsetCenterOfMassShape_GetCenterOfMass(const JPH_OffsetCenterOfMassShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetCenterOfMass());
}

JPH_AABox *JPH_OffsetCenterOfMassShape_GetLocalBounds(const JPH_OffsetCenterOfMassShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetLocalBounds());
}

JPH_AABox *JPH_OffsetCenterOfMassShape_GetWorldSpaceBounds_JPH_Mat44(const JPH_OffsetCenterOfMassShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetWorldSpaceBounds(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

float JPH_OffsetCenterOfMassShape_GetInnerRadius(const JPH_OffsetCenterOfMassShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetInnerRadius();
}

JPH_TransformedShape *JPH_OffsetCenterOfMassShape_GetSubShapeTransformedShape(const JPH_OffsetCenterOfMassShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder)
{
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetSubShapeTransformedShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

JPH_Vec3 *JPH_OffsetCenterOfMassShape_GetSurfaceNormal(const JPH_OffsetCenterOfMassShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

void JPH_OffsetCenterOfMassShape_GetSubmergedVolume(const JPH_OffsetCenterOfMassShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy))
    );
}

bool JPH_OffsetCenterOfMassShape_CastRay_3(const JPH_OffsetCenterOfMassShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).CastRay(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RayCast *)(inRay)),
        ((inSubShapeIDCreator ? void() : MRBINDC_THROW("Parameter `inSubShapeIDCreator` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(inSubShapeIDCreator)),
        ((ioHit ? void() : MRBINDC_THROW("Parameter `ioHit` can not be null.", void)), *(JPH::RayCastResult *)(ioHit))
    );
}

void JPH_OffsetCenterOfMassShape_GetTrianglesStart(const JPH_OffsetCenterOfMassShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_OffsetCenterOfMassShape_GetTrianglesNext(const JPH_OffsetCenterOfMassShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

JPH_Shape_Stats *JPH_OffsetCenterOfMassShape_GetStats(const JPH_OffsetCenterOfMassShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetStats());
}

float JPH_OffsetCenterOfMassShape_GetVolume(const JPH_OffsetCenterOfMassShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetVolume();
}

void JPH_OffsetCenterOfMassShape_sRegister(void)
{
    JPH::OffsetCenterOfMassShape::sRegister();
}

const JPH_Shape *JPH_OffsetCenterOfMassShape_GetInnerShape(const JPH_OffsetCenterOfMassShape *_this)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetInnerShape());
}

bool JPH_OffsetCenterOfMassShape_MustBeStatic(const JPH_OffsetCenterOfMassShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).MustBeStatic();
}

unsigned int JPH_OffsetCenterOfMassShape_GetSubShapeIDBitsRecursive(const JPH_OffsetCenterOfMassShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetSubShapeIDBitsRecursive();
}

const JPH_Shape *JPH_OffsetCenterOfMassShape_GetLeafShape(const JPH_OffsetCenterOfMassShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

const JPH_PhysicsMaterial *JPH_OffsetCenterOfMassShape_GetMaterial(const JPH_OffsetCenterOfMassShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetMaterial(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

uint64_t JPH_OffsetCenterOfMassShape_GetSubShapeUserData(const JPH_OffsetCenterOfMassShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

bool JPH_OffsetCenterOfMassShape_IsValidScale(const JPH_OffsetCenterOfMassShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_OffsetCenterOfMassShape_MakeScaleValid(const JPH_OffsetCenterOfMassShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

uint64_t JPH_OffsetCenterOfMassShape_GetUserData(const JPH_OffsetCenterOfMassShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetUserData();
}

void JPH_OffsetCenterOfMassShape_SetUserData(JPH_OffsetCenterOfMassShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::OffsetCenterOfMassShape *)(_this)).SetUserData(
        inUserData
    );
}

void JPH_OffsetCenterOfMassShape_SetEmbedded(const JPH_OffsetCenterOfMassShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).SetEmbedded();
}

unsigned int JPH_OffsetCenterOfMassShape_GetRefCount(const JPH_OffsetCenterOfMassShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).GetRefCount();
}

void JPH_OffsetCenterOfMassShape_AddRef(const JPH_OffsetCenterOfMassShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).AddRef();
}

void JPH_OffsetCenterOfMassShape_Release(const JPH_OffsetCenterOfMassShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::OffsetCenterOfMassShape *)(_this)).Release();
}

int JPH_OffsetCenterOfMassShape_sInternalGetRefCountOffset(void)
{
    return JPH::OffsetCenterOfMassShape::sInternalGetRefCountOffset();
}

