// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/MeshShape.h"

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
#include <Jolt/Physics/Collision/Shape/MeshShape.h>
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


const unsigned int *JPH_MeshShapeSettings_Get_mMaxTrianglesPerLeaf(const JPH_MeshShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShapeSettings *)(_this)).mMaxTrianglesPerLeaf);
}

void JPH_MeshShapeSettings_Set_mMaxTrianglesPerLeaf(JPH_MeshShapeSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MeshShapeSettings *)(_this)).mMaxTrianglesPerLeaf = value;
}

unsigned int *JPH_MeshShapeSettings_GetMutable_mMaxTrianglesPerLeaf(JPH_MeshShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MeshShapeSettings *)(_this)).mMaxTrianglesPerLeaf);
}

const float *JPH_MeshShapeSettings_Get_mActiveEdgeCosThresholdAngle(const JPH_MeshShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShapeSettings *)(_this)).mActiveEdgeCosThresholdAngle);
}

void JPH_MeshShapeSettings_Set_mActiveEdgeCosThresholdAngle(JPH_MeshShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MeshShapeSettings *)(_this)).mActiveEdgeCosThresholdAngle = value;
}

float *JPH_MeshShapeSettings_GetMutable_mActiveEdgeCosThresholdAngle(JPH_MeshShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MeshShapeSettings *)(_this)).mActiveEdgeCosThresholdAngle);
}

const bool *JPH_MeshShapeSettings_Get_mPerTriangleUserData(const JPH_MeshShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShapeSettings *)(_this)).mPerTriangleUserData);
}

void JPH_MeshShapeSettings_Set_mPerTriangleUserData(JPH_MeshShapeSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MeshShapeSettings *)(_this)).mPerTriangleUserData = value;
}

bool *JPH_MeshShapeSettings_GetMutable_mPerTriangleUserData(JPH_MeshShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MeshShapeSettings *)(_this)).mPerTriangleUserData);
}

const JPH_MeshShapeSettings_EBuildQuality *JPH_MeshShapeSettings_Get_mBuildQuality(const JPH_MeshShapeSettings *_this)
{
    return (const JPH_MeshShapeSettings_EBuildQuality *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShapeSettings *)(_this)).mBuildQuality);
}

void JPH_MeshShapeSettings_Set_mBuildQuality(JPH_MeshShapeSettings *_this, JPH_MeshShapeSettings_EBuildQuality value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MeshShapeSettings *)(_this)).mBuildQuality = ((JPH::MeshShapeSettings::EBuildQuality)value);
}

JPH_MeshShapeSettings_EBuildQuality *JPH_MeshShapeSettings_GetMutable_mBuildQuality(JPH_MeshShapeSettings *_this)
{
    return (JPH_MeshShapeSettings_EBuildQuality *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MeshShapeSettings *)(_this)).mBuildQuality);
}

const uint64_t *JPH_MeshShapeSettings_Get_mUserData(const JPH_MeshShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShapeSettings *)(_this)).mUserData);
}

void JPH_MeshShapeSettings_Set_mUserData(JPH_MeshShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MeshShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_MeshShapeSettings_GetMutable_mUserData(JPH_MeshShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MeshShapeSettings *)(_this)).mUserData);
}

JPH_MeshShapeSettings *JPH_MeshShapeSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::MeshShapeSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_MeshShapeSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_MeshShapeSettings *JPH_MeshShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_MeshShapeSettings *)(new JPH::MeshShapeSettings[num_elems]{});
}

const JPH_MeshShapeSettings *JPH_MeshShapeSettings_OffsetPtr(const JPH_MeshShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_MeshShapeSettings *)(((const JPH::MeshShapeSettings *)ptr) + i);
}

JPH_MeshShapeSettings *JPH_MeshShapeSettings_OffsetMutablePtr(JPH_MeshShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_MeshShapeSettings *)(((JPH::MeshShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_MeshShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_MeshShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::MeshShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_MeshShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_MeshShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::MeshShapeSettings *)object)
    ));
}

const JPH_MeshShapeSettings *JPH_MeshShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_MeshShapeSettings *)(static_cast<const JPH::MeshShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_MeshShapeSettings *JPH_MeshShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_MeshShapeSettings *)(static_cast<JPH::MeshShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_MeshShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_MeshShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::MeshShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_MeshShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_MeshShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::MeshShapeSettings *)object)
    ));
}

const JPH_MeshShapeSettings *JPH_MeshShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_MeshShapeSettings *)(static_cast<const JPH::MeshShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_MeshShapeSettings *JPH_MeshShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_MeshShapeSettings *)(static_cast<JPH::MeshShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_MeshShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_MeshShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::MeshShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_MeshShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_MeshShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::MeshShapeSettings *)object)
    ));
}

const JPH_MeshShapeSettings *JPH_MeshShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_MeshShapeSettings *)(static_cast<const JPH::MeshShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_MeshShapeSettings *JPH_MeshShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_MeshShapeSettings *)(static_cast<JPH::MeshShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

JPH_MeshShapeSettings *JPH_MeshShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_MeshShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::MeshShapeSettings);
    return (JPH_MeshShapeSettings *)new JPH::MeshShapeSettings(JPH::MeshShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::MeshShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::MeshShapeSettings), JPH::MeshShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::MeshShapeSettings), JPH::MeshShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::MeshShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::MeshShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::MeshShapeSettings))
    ));
}

void JPH_MeshShapeSettings_Destroy(const JPH_MeshShapeSettings *_this)
{
    delete ((const JPH::MeshShapeSettings *)_this);
}

void JPH_MeshShapeSettings_DestroyArray(const JPH_MeshShapeSettings *_this)
{
    delete[] ((const JPH::MeshShapeSettings *)_this);
}

JPH_MeshShapeSettings *JPH_MeshShapeSettings_AssignFromAnother(JPH_MeshShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_MeshShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::MeshShapeSettings);
    return (JPH_MeshShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MeshShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::MeshShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::MeshShapeSettings), JPH::MeshShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::MeshShapeSettings), JPH::MeshShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::MeshShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::MeshShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::MeshShapeSettings))
    ));
}

void *Jolt_new_JPH_MeshShapeSettings_size_t(size_t inCount)
{
    return JPH::MeshShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_MeshShapeSettings_void_ptr(void *inPointer)
{
    JPH::MeshShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_MeshShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::MeshShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_MeshShapeSettings_size_t(size_t inCount)
{
    return JPH::MeshShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_MeshShapeSettings_void_ptr(void *inPointer)
{
    JPH::MeshShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_MeshShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::MeshShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_MeshShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::MeshShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_MeshShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MeshShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_MeshShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::MeshShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_MeshShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MeshShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_MeshShapeSettings_Sanitize(JPH_MeshShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MeshShapeSettings *)(_this)).Sanitize();
}

void JPH_MeshShapeSettings_ClearCachedResult(JPH_MeshShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MeshShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_MeshShapeSettings_SetEmbedded(const JPH_MeshShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_MeshShapeSettings_GetRefCount(const JPH_MeshShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShapeSettings *)(_this)).GetRefCount();
}

void JPH_MeshShapeSettings_AddRef(const JPH_MeshShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShapeSettings *)(_this)).AddRef();
}

void JPH_MeshShapeSettings_Release(const JPH_MeshShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShapeSettings *)(_this)).Release();
}

int JPH_MeshShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::MeshShapeSettings::sInternalGetRefCountOffset();
}

const bool *JPH_MeshShape_Get_sDrawTriangleGroups(void)
{
    return std::addressof(JPH::MeshShape::sDrawTriangleGroups);
}

void JPH_MeshShape_Set_sDrawTriangleGroups(bool value)
{
    JPH::MeshShape::sDrawTriangleGroups = value;
}

bool *JPH_MeshShape_GetMutable_sDrawTriangleGroups(void)
{
    return std::addressof(JPH::MeshShape::sDrawTriangleGroups);
}

const bool *JPH_MeshShape_Get_sDrawTriangleOutlines(void)
{
    return std::addressof(JPH::MeshShape::sDrawTriangleOutlines);
}

void JPH_MeshShape_Set_sDrawTriangleOutlines(bool value)
{
    JPH::MeshShape::sDrawTriangleOutlines = value;
}

bool *JPH_MeshShape_GetMutable_sDrawTriangleOutlines(void)
{
    return std::addressof(JPH::MeshShape::sDrawTriangleOutlines);
}

const int *JPH_MeshShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::MeshShape::cGetTrianglesMinTrianglesRequested);
}

const bool *JPH_MeshShape_Get_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::MeshShape::sDrawSubmergedVolumes);
}

void JPH_MeshShape_Set_sDrawSubmergedVolumes(bool value)
{
    JPH::MeshShape::sDrawSubmergedVolumes = value;
}

bool *JPH_MeshShape_GetMutable_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::MeshShape::sDrawSubmergedVolumes);
}

JPH_MeshShape *JPH_MeshShape_DefaultConstruct(void)
{
    using _mrbind_T = JPH::MeshShape;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_MeshShape*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_MeshShape *JPH_MeshShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_MeshShape *)(new JPH::MeshShape[num_elems]{});
}

const JPH_MeshShape *JPH_MeshShape_OffsetPtr(const JPH_MeshShape *ptr, ptrdiff_t i)
{
    return (const JPH_MeshShape *)(((const JPH::MeshShape *)ptr) + i);
}

JPH_MeshShape *JPH_MeshShape_OffsetMutablePtr(JPH_MeshShape *ptr, ptrdiff_t i)
{
    return (JPH_MeshShape *)(((JPH::MeshShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_MeshShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_MeshShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::MeshShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_MeshShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_MeshShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::MeshShape *)object)
    ));
}

const JPH_MeshShape *JPH_MeshShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_MeshShape *)(static_cast<const JPH::MeshShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_MeshShape *JPH_MeshShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_MeshShape *)(static_cast<JPH::MeshShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_MeshShape_UpcastTo_JPH_NonCopyable(const JPH_MeshShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::MeshShape *)object)
    ));
}

JPH_NonCopyable *JPH_MeshShape_MutableUpcastTo_JPH_NonCopyable(JPH_MeshShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::MeshShape *)object)
    ));
}

const JPH_MeshShape *JPH_MeshShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_MeshShape *)(static_cast<const JPH::MeshShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_MeshShape *JPH_MeshShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_MeshShape *)(static_cast<JPH::MeshShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_MeshShape_UpcastTo_JPH_Shape(const JPH_MeshShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::MeshShape *)object)
    ));
}

JPH_Shape *JPH_MeshShape_MutableUpcastTo_JPH_Shape(JPH_MeshShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::MeshShape *)object)
    ));
}

const JPH_MeshShape *JPH_MeshShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_MeshShape *)(static_cast<const JPH::MeshShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_MeshShape *JPH_MeshShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_MeshShape *)(static_cast<JPH::MeshShape *>(
        ((JPH::Shape *)object)
    ));
}

void JPH_MeshShape_Destroy(const JPH_MeshShape *_this)
{
    delete ((const JPH::MeshShape *)_this);
}

void JPH_MeshShape_DestroyArray(const JPH_MeshShape *_this)
{
    delete[] ((const JPH::MeshShape *)_this);
}

void *Jolt_new_JPH_MeshShape_size_t(size_t inCount)
{
    return JPH::MeshShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_MeshShape_void_ptr(void *inPointer)
{
    JPH::MeshShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_MeshShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::MeshShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_MeshShape_size_t(size_t inCount)
{
    return JPH::MeshShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_MeshShape_void_ptr(void *inPointer)
{
    JPH::MeshShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_MeshShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::MeshShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_MeshShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::MeshShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_MeshShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MeshShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_MeshShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::MeshShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_MeshShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MeshShape::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_MeshShape_MustBeStatic(const JPH_MeshShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).MustBeStatic();
}

JPH_AABox *JPH_MeshShape_GetLocalBounds(const JPH_MeshShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetLocalBounds());
}

unsigned int JPH_MeshShape_GetSubShapeIDBitsRecursive(const JPH_MeshShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetSubShapeIDBitsRecursive();
}

float JPH_MeshShape_GetInnerRadius(const JPH_MeshShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetInnerRadius();
}

const JPH_PhysicsMaterial *JPH_MeshShape_GetMaterial(const JPH_MeshShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetMaterial(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

unsigned int JPH_MeshShape_GetMaterialIndex(const JPH_MeshShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetMaterialIndex(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

JPH_Vec3 *JPH_MeshShape_GetSurfaceNormal(const JPH_MeshShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

void JPH_MeshShape_Draw(const JPH_MeshShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).Draw(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inUseMaterialColors,
        inDrawWireframe
    );
}

bool JPH_MeshShape_CastRay_3(const JPH_MeshShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).CastRay(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RayCast *)(inRay)),
        ((inSubShapeIDCreator ? void() : MRBINDC_THROW("Parameter `inSubShapeIDCreator` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(inSubShapeIDCreator)),
        ((ioHit ? void() : MRBINDC_THROW("Parameter `ioHit` can not be null.", void)), *(JPH::RayCastResult *)(ioHit))
    );
}

void JPH_MeshShape_GetTrianglesStart(const JPH_MeshShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_MeshShape_GetTrianglesNext(const JPH_MeshShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

void JPH_MeshShape_GetSubmergedVolume(const JPH_MeshShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy)),
        ((inBaseOffset ? void() : MRBINDC_THROW("Parameter `inBaseOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBaseOffset))
    );
}

JPH_Shape_Stats *JPH_MeshShape_GetStats(const JPH_MeshShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetStats());
}

float JPH_MeshShape_GetVolume(const JPH_MeshShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetVolume();
}

unsigned int JPH_MeshShape_GetTriangleUserData(const JPH_MeshShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetTriangleUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

void JPH_MeshShape_sRegister(void)
{
    JPH::MeshShape::sRegister();
}

uint64_t JPH_MeshShape_GetUserData(const JPH_MeshShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetUserData();
}

void JPH_MeshShape_SetUserData(JPH_MeshShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MeshShape *)(_this)).SetUserData(
        inUserData
    );
}

JPH_Vec3 *JPH_MeshShape_GetCenterOfMass(const JPH_MeshShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetCenterOfMass());
}

const JPH_Shape *JPH_MeshShape_GetLeafShape(const JPH_MeshShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_MeshShape_GetSubShapeUserData(const JPH_MeshShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

JPH_TransformedShape *JPH_MeshShape_GetSubShapeTransformedShape(const JPH_MeshShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder)
{
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetSubShapeTransformedShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

void JPH_MeshShape_DrawGetSupportFunction(const JPH_MeshShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).DrawGetSupportFunction(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inDrawSupportDirection
    );
}

void JPH_MeshShape_DrawGetSupportingFace(const JPH_MeshShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).DrawGetSupportingFace(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

bool JPH_MeshShape_IsValidScale(const JPH_MeshShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_MeshShape_MakeScaleValid(const JPH_MeshShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_MeshShape_SetEmbedded(const JPH_MeshShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).SetEmbedded();
}

unsigned int JPH_MeshShape_GetRefCount(const JPH_MeshShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).GetRefCount();
}

void JPH_MeshShape_AddRef(const JPH_MeshShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).AddRef();
}

void JPH_MeshShape_Release(const JPH_MeshShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MeshShape *)(_this)).Release();
}

int JPH_MeshShape_sInternalGetRefCountOffset(void)
{
    return JPH::MeshShape::sInternalGetRefCountOffset();
}

