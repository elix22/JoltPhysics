// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/PlaneShape.h"

#include <Jolt/Core/Color.h>
#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Geometry/Plane.h>
#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Collision/CastResult.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/RayCast.h>
#include <Jolt/Physics/Collision/Shape/PlaneShape.h>
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


const float *JPH_PlaneShapeSettings_Get_cDefaultHalfExtent(void)
{
    return std::addressof(JPH::PlaneShapeSettings::cDefaultHalfExtent);
}

const JPH_Plane *JPH_PlaneShapeSettings_Get_mPlane(const JPH_PlaneShapeSettings *_this)
{
    return (const JPH_Plane *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShapeSettings *)(_this)).mPlane);
}

void JPH_PlaneShapeSettings_Set_mPlane(JPH_PlaneShapeSettings *_this, const JPH_Plane *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PlaneShapeSettings *)(_this)).mPlane = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::Plane(*(JPH::Plane *)value));
}

JPH_Plane *JPH_PlaneShapeSettings_GetMutable_mPlane(JPH_PlaneShapeSettings *_this)
{
    return (JPH_Plane *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PlaneShapeSettings *)(_this)).mPlane);
}

const float *JPH_PlaneShapeSettings_Get_mHalfExtent(const JPH_PlaneShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShapeSettings *)(_this)).mHalfExtent);
}

void JPH_PlaneShapeSettings_Set_mHalfExtent(JPH_PlaneShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PlaneShapeSettings *)(_this)).mHalfExtent = value;
}

float *JPH_PlaneShapeSettings_GetMutable_mHalfExtent(JPH_PlaneShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PlaneShapeSettings *)(_this)).mHalfExtent);
}

const uint64_t *JPH_PlaneShapeSettings_Get_mUserData(const JPH_PlaneShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShapeSettings *)(_this)).mUserData);
}

void JPH_PlaneShapeSettings_Set_mUserData(JPH_PlaneShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PlaneShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_PlaneShapeSettings_GetMutable_mUserData(JPH_PlaneShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PlaneShapeSettings *)(_this)).mUserData);
}

JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::PlaneShapeSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_PlaneShapeSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_PlaneShapeSettings *)(new JPH::PlaneShapeSettings[num_elems]);
}

const JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_OffsetPtr(const JPH_PlaneShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_PlaneShapeSettings *)(((const JPH::PlaneShapeSettings *)ptr) + i);
}

JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_OffsetMutablePtr(JPH_PlaneShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_PlaneShapeSettings *)(((JPH::PlaneShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_PlaneShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_PlaneShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::PlaneShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_PlaneShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_PlaneShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::PlaneShapeSettings *)object)
    ));
}

const JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_PlaneShapeSettings *)(static_cast<const JPH::PlaneShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_PlaneShapeSettings *)(static_cast<JPH::PlaneShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_PlaneShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_PlaneShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::PlaneShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_PlaneShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_PlaneShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::PlaneShapeSettings *)object)
    ));
}

const JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_PlaneShapeSettings *)(static_cast<const JPH::PlaneShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_PlaneShapeSettings *)(static_cast<JPH::PlaneShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_PlaneShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_PlaneShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::PlaneShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_PlaneShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_PlaneShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::PlaneShapeSettings *)object)
    ));
}

const JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_PlaneShapeSettings *)(static_cast<const JPH::PlaneShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_PlaneShapeSettings *)(static_cast<JPH::PlaneShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_PlaneShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::PlaneShapeSettings);
    return (JPH_PlaneShapeSettings *)new JPH::PlaneShapeSettings(JPH::PlaneShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::PlaneShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::PlaneShapeSettings), JPH::PlaneShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::PlaneShapeSettings), JPH::PlaneShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::PlaneShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::PlaneShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::PlaneShapeSettings))
    ));
}

JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_Construct(const JPH_Plane *inPlane, const JPH_PhysicsMaterial *inMaterial, const float *inHalfExtent)
{
    using namespace JPH;
    return (JPH_PlaneShapeSettings *)new JPH::PlaneShapeSettings(JPH::PlaneShapeSettings(
        ((inPlane ? void() : MRBINDC_THROW("Parameter `inPlane` can not be null.", void)), *(const JPH::Plane *)(inPlane)),
        ((const JPH::PhysicsMaterial *)inMaterial),
        (inHalfExtent ? *inHalfExtent : static_cast<float>(JPH::PlaneShapeSettings::cDefaultHalfExtent))
    ));
}

void JPH_PlaneShapeSettings_Destroy(const JPH_PlaneShapeSettings *_this)
{
    delete ((const JPH::PlaneShapeSettings *)_this);
}

void JPH_PlaneShapeSettings_DestroyArray(const JPH_PlaneShapeSettings *_this)
{
    delete[] ((const JPH::PlaneShapeSettings *)_this);
}

JPH_PlaneShapeSettings *JPH_PlaneShapeSettings_AssignFromAnother(JPH_PlaneShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_PlaneShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::PlaneShapeSettings);
    return (JPH_PlaneShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PlaneShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::PlaneShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::PlaneShapeSettings), JPH::PlaneShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::PlaneShapeSettings), JPH::PlaneShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::PlaneShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::PlaneShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::PlaneShapeSettings))
    ));
}

void *Jolt_new_JPH_PlaneShapeSettings_size_t(size_t inCount)
{
    return JPH::PlaneShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_PlaneShapeSettings_void_ptr(void *inPointer)
{
    JPH::PlaneShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_PlaneShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PlaneShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_PlaneShapeSettings_size_t(size_t inCount)
{
    return JPH::PlaneShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr(void *inPointer)
{
    JPH::PlaneShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PlaneShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_PlaneShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PlaneShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_PlaneShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PlaneShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_PlaneShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PlaneShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PlaneShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_PlaneShapeSettings_ClearCachedResult(JPH_PlaneShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PlaneShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_PlaneShapeSettings_SetEmbedded(const JPH_PlaneShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_PlaneShapeSettings_GetRefCount(const JPH_PlaneShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShapeSettings *)(_this)).GetRefCount();
}

void JPH_PlaneShapeSettings_AddRef(const JPH_PlaneShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShapeSettings *)(_this)).AddRef();
}

void JPH_PlaneShapeSettings_Release(const JPH_PlaneShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShapeSettings *)(_this)).Release();
}

int JPH_PlaneShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::PlaneShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_PlaneShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::PlaneShape::cGetTrianglesMinTrianglesRequested);
}

const bool *JPH_PlaneShape_Get_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::PlaneShape::sDrawSubmergedVolumes);
}

void JPH_PlaneShape_Set_sDrawSubmergedVolumes(bool value)
{
    JPH::PlaneShape::sDrawSubmergedVolumes = value;
}

bool *JPH_PlaneShape_GetMutable_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::PlaneShape::sDrawSubmergedVolumes);
}

JPH_PlaneShape *JPH_PlaneShape_DefaultConstruct(void)
{
    using _mrbind_T = JPH::PlaneShape;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_PlaneShape*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_PlaneShape *JPH_PlaneShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_PlaneShape *)(new JPH::PlaneShape[num_elems]);
}

const JPH_PlaneShape *JPH_PlaneShape_OffsetPtr(const JPH_PlaneShape *ptr, ptrdiff_t i)
{
    return (const JPH_PlaneShape *)(((const JPH::PlaneShape *)ptr) + i);
}

JPH_PlaneShape *JPH_PlaneShape_OffsetMutablePtr(JPH_PlaneShape *ptr, ptrdiff_t i)
{
    return (JPH_PlaneShape *)(((JPH::PlaneShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_PlaneShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_PlaneShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::PlaneShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_PlaneShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_PlaneShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::PlaneShape *)object)
    ));
}

const JPH_PlaneShape *JPH_PlaneShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_PlaneShape *)(static_cast<const JPH::PlaneShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_PlaneShape *JPH_PlaneShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_PlaneShape *)(static_cast<JPH::PlaneShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_PlaneShape_UpcastTo_JPH_NonCopyable(const JPH_PlaneShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::PlaneShape *)object)
    ));
}

JPH_NonCopyable *JPH_PlaneShape_MutableUpcastTo_JPH_NonCopyable(JPH_PlaneShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::PlaneShape *)object)
    ));
}

const JPH_PlaneShape *JPH_PlaneShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_PlaneShape *)(static_cast<const JPH::PlaneShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_PlaneShape *JPH_PlaneShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_PlaneShape *)(static_cast<JPH::PlaneShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_PlaneShape_UpcastTo_JPH_Shape(const JPH_PlaneShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::PlaneShape *)object)
    ));
}

JPH_Shape *JPH_PlaneShape_MutableUpcastTo_JPH_Shape(JPH_PlaneShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::PlaneShape *)object)
    ));
}

const JPH_PlaneShape *JPH_PlaneShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_PlaneShape *)(static_cast<const JPH::PlaneShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_PlaneShape *JPH_PlaneShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_PlaneShape *)(static_cast<JPH::PlaneShape *>(
        ((JPH::Shape *)object)
    ));
}

JPH_PlaneShape *JPH_PlaneShape_Construct_3(const JPH_Plane *inPlane, const JPH_PhysicsMaterial *inMaterial, const float *inHalfExtent)
{
    using namespace JPH;
    return (JPH_PlaneShape *)new JPH::PlaneShape(JPH::PlaneShape(
        ((inPlane ? void() : MRBINDC_THROW("Parameter `inPlane` can not be null.", void)), *(const JPH::Plane *)(inPlane)),
        ((const JPH::PhysicsMaterial *)inMaterial),
        (inHalfExtent ? *inHalfExtent : static_cast<float>(JPH::PlaneShapeSettings::cDefaultHalfExtent))
    ));
}

void JPH_PlaneShape_Destroy(const JPH_PlaneShape *_this)
{
    delete ((const JPH::PlaneShape *)_this);
}

void JPH_PlaneShape_DestroyArray(const JPH_PlaneShape *_this)
{
    delete[] ((const JPH::PlaneShape *)_this);
}

void *Jolt_new_JPH_PlaneShape_size_t(size_t inCount)
{
    return JPH::PlaneShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_PlaneShape_void_ptr(void *inPointer)
{
    JPH::PlaneShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_PlaneShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PlaneShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_PlaneShape_size_t(size_t inCount)
{
    return JPH::PlaneShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_PlaneShape_void_ptr(void *inPointer)
{
    JPH::PlaneShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_PlaneShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PlaneShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_PlaneShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PlaneShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_PlaneShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PlaneShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_PlaneShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PlaneShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_PlaneShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PlaneShape::operator delete[](
        inPointer,
        inPlace
    );
}

const JPH_Plane *JPH_PlaneShape_GetPlane(const JPH_PlaneShape *_this)
{
    return (const JPH_Plane *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetPlane());
}

float JPH_PlaneShape_GetHalfExtent(const JPH_PlaneShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetHalfExtent();
}

bool JPH_PlaneShape_MustBeStatic(const JPH_PlaneShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).MustBeStatic();
}

JPH_AABox *JPH_PlaneShape_GetLocalBounds(const JPH_PlaneShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetLocalBounds());
}

unsigned int JPH_PlaneShape_GetSubShapeIDBitsRecursive(const JPH_PlaneShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetSubShapeIDBitsRecursive();
}

float JPH_PlaneShape_GetInnerRadius(const JPH_PlaneShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetInnerRadius();
}

const JPH_PhysicsMaterial *JPH_PlaneShape_GetMaterial_1(const JPH_PlaneShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetMaterial(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

JPH_Vec3 *JPH_PlaneShape_GetSurfaceNormal(const JPH_PlaneShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

void JPH_PlaneShape_Draw(const JPH_PlaneShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).Draw(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inUseMaterialColors,
        inDrawWireframe
    );
}

bool JPH_PlaneShape_CastRay_3(const JPH_PlaneShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).CastRay(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RayCast *)(inRay)),
        ((inSubShapeIDCreator ? void() : MRBINDC_THROW("Parameter `inSubShapeIDCreator` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(inSubShapeIDCreator)),
        ((ioHit ? void() : MRBINDC_THROW("Parameter `ioHit` can not be null.", void)), *(JPH::RayCastResult *)(ioHit))
    );
}

void JPH_PlaneShape_GetTrianglesStart(const JPH_PlaneShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_PlaneShape_GetTrianglesNext(const JPH_PlaneShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

void JPH_PlaneShape_GetSubmergedVolume(const JPH_PlaneShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy)),
        ((inBaseOffset ? void() : MRBINDC_THROW("Parameter `inBaseOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBaseOffset))
    );
}

JPH_Shape_Stats *JPH_PlaneShape_GetStats(const JPH_PlaneShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetStats());
}

float JPH_PlaneShape_GetVolume(const JPH_PlaneShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetVolume();
}

void JPH_PlaneShape_SetMaterial(JPH_PlaneShape *_this, const JPH_PhysicsMaterial *inMaterial)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PlaneShape *)(_this)).SetMaterial(
        ((const JPH::PhysicsMaterial *)inMaterial)
    );
}

const JPH_PhysicsMaterial *JPH_PlaneShape_GetMaterial_0(const JPH_PlaneShape *_this)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetMaterial());
}

void JPH_PlaneShape_sRegister(void)
{
    JPH::PlaneShape::sRegister();
}

uint64_t JPH_PlaneShape_GetUserData(const JPH_PlaneShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetUserData();
}

void JPH_PlaneShape_SetUserData(JPH_PlaneShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PlaneShape *)(_this)).SetUserData(
        inUserData
    );
}

JPH_Vec3 *JPH_PlaneShape_GetCenterOfMass(const JPH_PlaneShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetCenterOfMass());
}

const JPH_Shape *JPH_PlaneShape_GetLeafShape(const JPH_PlaneShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_PlaneShape_GetSubShapeUserData(const JPH_PlaneShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

JPH_TransformedShape *JPH_PlaneShape_GetSubShapeTransformedShape(const JPH_PlaneShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder)
{
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetSubShapeTransformedShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

void JPH_PlaneShape_DrawGetSupportFunction(const JPH_PlaneShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).DrawGetSupportFunction(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inDrawSupportDirection
    );
}

void JPH_PlaneShape_DrawGetSupportingFace(const JPH_PlaneShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).DrawGetSupportingFace(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

bool JPH_PlaneShape_IsValidScale(const JPH_PlaneShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_PlaneShape_MakeScaleValid(const JPH_PlaneShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_PlaneShape_SetEmbedded(const JPH_PlaneShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).SetEmbedded();
}

unsigned int JPH_PlaneShape_GetRefCount(const JPH_PlaneShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).GetRefCount();
}

void JPH_PlaneShape_AddRef(const JPH_PlaneShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).AddRef();
}

void JPH_PlaneShape_Release(const JPH_PlaneShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PlaneShape *)(_this)).Release();
}

int JPH_PlaneShape_sInternalGetRefCountOffset(void)
{
    return JPH::PlaneShape::sInternalGetRefCountOffset();
}

