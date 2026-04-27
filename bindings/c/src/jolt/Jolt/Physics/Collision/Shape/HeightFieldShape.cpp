// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/HeightFieldShape.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Core/TempAllocator.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/Shape/HeightFieldShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const JPH_Vec3 *JPH_HeightFieldShapeSettings_Get_mOffset(const JPH_HeightFieldShapeSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).mOffset);
}

JPH_Vec3 *JPH_HeightFieldShapeSettings_GetMutable_mOffset(JPH_HeightFieldShapeSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mOffset);
}

const JPH_Vec3 *JPH_HeightFieldShapeSettings_Get_mScale(const JPH_HeightFieldShapeSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).mScale);
}

JPH_Vec3 *JPH_HeightFieldShapeSettings_GetMutable_mScale(JPH_HeightFieldShapeSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mScale);
}

const unsigned int *JPH_HeightFieldShapeSettings_Get_mSampleCount(const JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).mSampleCount);
}

void JPH_HeightFieldShapeSettings_Set_mSampleCount(JPH_HeightFieldShapeSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mSampleCount = value;
}

unsigned int *JPH_HeightFieldShapeSettings_GetMutable_mSampleCount(JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mSampleCount);
}

const float *JPH_HeightFieldShapeSettings_Get_mMinHeightValue(const JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).mMinHeightValue);
}

void JPH_HeightFieldShapeSettings_Set_mMinHeightValue(JPH_HeightFieldShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mMinHeightValue = value;
}

float *JPH_HeightFieldShapeSettings_GetMutable_mMinHeightValue(JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mMinHeightValue);
}

const float *JPH_HeightFieldShapeSettings_Get_mMaxHeightValue(const JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).mMaxHeightValue);
}

void JPH_HeightFieldShapeSettings_Set_mMaxHeightValue(JPH_HeightFieldShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mMaxHeightValue = value;
}

float *JPH_HeightFieldShapeSettings_GetMutable_mMaxHeightValue(JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mMaxHeightValue);
}

const unsigned int *JPH_HeightFieldShapeSettings_Get_mMaterialsCapacity(const JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).mMaterialsCapacity);
}

void JPH_HeightFieldShapeSettings_Set_mMaterialsCapacity(JPH_HeightFieldShapeSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mMaterialsCapacity = value;
}

unsigned int *JPH_HeightFieldShapeSettings_GetMutable_mMaterialsCapacity(JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mMaterialsCapacity);
}

const unsigned int *JPH_HeightFieldShapeSettings_Get_mBlockSize(const JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).mBlockSize);
}

void JPH_HeightFieldShapeSettings_Set_mBlockSize(JPH_HeightFieldShapeSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mBlockSize = value;
}

unsigned int *JPH_HeightFieldShapeSettings_GetMutable_mBlockSize(JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mBlockSize);
}

const unsigned int *JPH_HeightFieldShapeSettings_Get_mBitsPerSample(const JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).mBitsPerSample);
}

void JPH_HeightFieldShapeSettings_Set_mBitsPerSample(JPH_HeightFieldShapeSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mBitsPerSample = value;
}

unsigned int *JPH_HeightFieldShapeSettings_GetMutable_mBitsPerSample(JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mBitsPerSample);
}

const float *JPH_HeightFieldShapeSettings_Get_mActiveEdgeCosThresholdAngle(const JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).mActiveEdgeCosThresholdAngle);
}

void JPH_HeightFieldShapeSettings_Set_mActiveEdgeCosThresholdAngle(JPH_HeightFieldShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mActiveEdgeCosThresholdAngle = value;
}

float *JPH_HeightFieldShapeSettings_GetMutable_mActiveEdgeCosThresholdAngle(JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mActiveEdgeCosThresholdAngle);
}

const uint64_t *JPH_HeightFieldShapeSettings_Get_mUserData(const JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).mUserData);
}

void JPH_HeightFieldShapeSettings_Set_mUserData(JPH_HeightFieldShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_HeightFieldShapeSettings_GetMutable_mUserData(JPH_HeightFieldShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).mUserData);
}

JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_DefaultConstruct(void)
{
    return (JPH_HeightFieldShapeSettings *)new JPH::HeightFieldShapeSettings(JPH::HeightFieldShapeSettings());
}

JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_HeightFieldShapeSettings *)(new JPH::HeightFieldShapeSettings[num_elems]{});
}

const JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_OffsetPtr(const JPH_HeightFieldShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_HeightFieldShapeSettings *)(((const JPH::HeightFieldShapeSettings *)ptr) + i);
}

JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_OffsetMutablePtr(JPH_HeightFieldShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_HeightFieldShapeSettings *)(((JPH::HeightFieldShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_HeightFieldShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_HeightFieldShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::HeightFieldShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_HeightFieldShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_HeightFieldShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::HeightFieldShapeSettings *)object)
    ));
}

const JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_HeightFieldShapeSettings *)(static_cast<const JPH::HeightFieldShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_HeightFieldShapeSettings *)(static_cast<JPH::HeightFieldShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_HeightFieldShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_HeightFieldShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::HeightFieldShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_HeightFieldShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_HeightFieldShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::HeightFieldShapeSettings *)object)
    ));
}

const JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_HeightFieldShapeSettings *)(static_cast<const JPH::HeightFieldShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_HeightFieldShapeSettings *)(static_cast<JPH::HeightFieldShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_HeightFieldShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_HeightFieldShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::HeightFieldShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_HeightFieldShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_HeightFieldShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::HeightFieldShapeSettings *)object)
    ));
}

const JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_HeightFieldShapeSettings *)(static_cast<const JPH::HeightFieldShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_HeightFieldShapeSettings *)(static_cast<JPH::HeightFieldShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_HeightFieldShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::HeightFieldShapeSettings);
    return (JPH_HeightFieldShapeSettings *)new JPH::HeightFieldShapeSettings(JPH::HeightFieldShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::HeightFieldShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::HeightFieldShapeSettings), JPH::HeightFieldShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::HeightFieldShapeSettings), JPH::HeightFieldShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::HeightFieldShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::HeightFieldShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::HeightFieldShapeSettings))
    ));
}

void JPH_HeightFieldShapeSettings_Destroy(const JPH_HeightFieldShapeSettings *_this)
{
    delete ((const JPH::HeightFieldShapeSettings *)_this);
}

void JPH_HeightFieldShapeSettings_DestroyArray(const JPH_HeightFieldShapeSettings *_this)
{
    delete[] ((const JPH::HeightFieldShapeSettings *)_this);
}

JPH_HeightFieldShapeSettings *JPH_HeightFieldShapeSettings_AssignFromAnother(JPH_HeightFieldShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_HeightFieldShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::HeightFieldShapeSettings);
    return (JPH_HeightFieldShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::HeightFieldShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::HeightFieldShapeSettings), JPH::HeightFieldShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::HeightFieldShapeSettings), JPH::HeightFieldShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::HeightFieldShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::HeightFieldShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::HeightFieldShapeSettings))
    ));
}

void *Jolt_new_JPH_HeightFieldShapeSettings_size_t(unsigned long inCount)
{
    return JPH::HeightFieldShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr(void *inPointer)
{
    JPH::HeightFieldShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::HeightFieldShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_HeightFieldShapeSettings_size_t(unsigned long inCount)
{
    return JPH::HeightFieldShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr(void *inPointer)
{
    JPH::HeightFieldShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::HeightFieldShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_HeightFieldShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::HeightFieldShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_HeightFieldShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::HeightFieldShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_HeightFieldShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::HeightFieldShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_HeightFieldShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::HeightFieldShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_HeightFieldShapeSettings_DetermineMinAndMaxSample(const JPH_HeightFieldShapeSettings *_this, float *outMinValue, float *outMaxValue, float *outQuantizationScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).DetermineMinAndMaxSample(
        ((outMinValue ? void() : MRBINDC_THROW("Parameter `outMinValue` can not be null.", void)), *outMinValue),
        ((outMaxValue ? void() : MRBINDC_THROW("Parameter `outMaxValue` can not be null.", void)), *outMaxValue),
        ((outQuantizationScale ? void() : MRBINDC_THROW("Parameter `outQuantizationScale` can not be null.", void)), *outQuantizationScale)
    );
}

unsigned int JPH_HeightFieldShapeSettings_CalculateBitsPerSampleForError(const JPH_HeightFieldShapeSettings *_this, float inMaxError)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).CalculateBitsPerSampleForError(
        inMaxError
    );
}

void JPH_HeightFieldShapeSettings_ClearCachedResult(JPH_HeightFieldShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_HeightFieldShapeSettings_SetEmbedded(const JPH_HeightFieldShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_HeightFieldShapeSettings_GetRefCount(const JPH_HeightFieldShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).GetRefCount();
}

void JPH_HeightFieldShapeSettings_AddRef(const JPH_HeightFieldShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).AddRef();
}

void JPH_HeightFieldShapeSettings_Release(const JPH_HeightFieldShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(_this)).Release();
}

int JPH_HeightFieldShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::HeightFieldShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_HeightFieldShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::HeightFieldShape::cGetTrianglesMinTrianglesRequested);
}

JPH_HeightFieldShape *JPH_HeightFieldShape_DefaultConstruct(void)
{
    return (JPH_HeightFieldShape *)new JPH::HeightFieldShape(JPH::HeightFieldShape());
}

JPH_HeightFieldShape *JPH_HeightFieldShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_HeightFieldShape *)(new JPH::HeightFieldShape[num_elems]{});
}

const JPH_HeightFieldShape *JPH_HeightFieldShape_OffsetPtr(const JPH_HeightFieldShape *ptr, ptrdiff_t i)
{
    return (const JPH_HeightFieldShape *)(((const JPH::HeightFieldShape *)ptr) + i);
}

JPH_HeightFieldShape *JPH_HeightFieldShape_OffsetMutablePtr(JPH_HeightFieldShape *ptr, ptrdiff_t i)
{
    return (JPH_HeightFieldShape *)(((JPH::HeightFieldShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_HeightFieldShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_HeightFieldShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::HeightFieldShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_HeightFieldShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_HeightFieldShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::HeightFieldShape *)object)
    ));
}

const JPH_HeightFieldShape *JPH_HeightFieldShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_HeightFieldShape *)(static_cast<const JPH::HeightFieldShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_HeightFieldShape *JPH_HeightFieldShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_HeightFieldShape *)(static_cast<JPH::HeightFieldShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_HeightFieldShape_UpcastTo_JPH_NonCopyable(const JPH_HeightFieldShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::HeightFieldShape *)object)
    ));
}

JPH_NonCopyable *JPH_HeightFieldShape_MutableUpcastTo_JPH_NonCopyable(JPH_HeightFieldShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::HeightFieldShape *)object)
    ));
}

const JPH_HeightFieldShape *JPH_HeightFieldShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_HeightFieldShape *)(static_cast<const JPH::HeightFieldShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_HeightFieldShape *JPH_HeightFieldShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_HeightFieldShape *)(static_cast<JPH::HeightFieldShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_HeightFieldShape_UpcastTo_JPH_Shape(const JPH_HeightFieldShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::HeightFieldShape *)object)
    ));
}

JPH_Shape *JPH_HeightFieldShape_MutableUpcastTo_JPH_Shape(JPH_HeightFieldShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::HeightFieldShape *)object)
    ));
}

const JPH_HeightFieldShape *JPH_HeightFieldShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_HeightFieldShape *)(static_cast<const JPH::HeightFieldShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_HeightFieldShape *JPH_HeightFieldShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_HeightFieldShape *)(static_cast<JPH::HeightFieldShape *>(
        ((JPH::Shape *)object)
    ));
}

void JPH_HeightFieldShape_Destroy(const JPH_HeightFieldShape *_this)
{
    delete ((const JPH::HeightFieldShape *)_this);
}

void JPH_HeightFieldShape_DestroyArray(const JPH_HeightFieldShape *_this)
{
    delete[] ((const JPH::HeightFieldShape *)_this);
}

void *Jolt_new_JPH_HeightFieldShape_size_t(unsigned long inCount)
{
    return JPH::HeightFieldShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_HeightFieldShape_void_ptr(void *inPointer)
{
    JPH::HeightFieldShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_HeightFieldShape_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::HeightFieldShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_HeightFieldShape_size_t(unsigned long inCount)
{
    return JPH::HeightFieldShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_HeightFieldShape_void_ptr(void *inPointer)
{
    JPH::HeightFieldShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_HeightFieldShape_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::HeightFieldShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_HeightFieldShape_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::HeightFieldShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_HeightFieldShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::HeightFieldShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_HeightFieldShape_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::HeightFieldShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_HeightFieldShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::HeightFieldShape::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_HeightFieldShape_MustBeStatic(const JPH_HeightFieldShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).MustBeStatic();
}

unsigned int JPH_HeightFieldShape_GetSampleCount(const JPH_HeightFieldShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetSampleCount();
}

unsigned int JPH_HeightFieldShape_GetBlockSize(const JPH_HeightFieldShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetBlockSize();
}

JPH_AABox *JPH_HeightFieldShape_GetLocalBounds(const JPH_HeightFieldShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetLocalBounds());
}

unsigned int JPH_HeightFieldShape_GetSubShapeIDBitsRecursive(const JPH_HeightFieldShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetSubShapeIDBitsRecursive();
}

float JPH_HeightFieldShape_GetInnerRadius(const JPH_HeightFieldShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetInnerRadius();
}

const JPH_PhysicsMaterial *JPH_HeightFieldShape_GetMaterial_1(const JPH_HeightFieldShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetMaterial(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

const JPH_PhysicsMaterial *JPH_HeightFieldShape_GetMaterial_2(const JPH_HeightFieldShape *_this, unsigned int inX, unsigned int inY)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetMaterial(
        inX,
        inY
    ));
}

JPH_Vec3 *JPH_HeightFieldShape_GetSurfaceNormal(const JPH_HeightFieldShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

void JPH_HeightFieldShape_GetTrianglesStart(const JPH_HeightFieldShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_HeightFieldShape_GetTrianglesNext(const JPH_HeightFieldShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

JPH_Vec3 *JPH_HeightFieldShape_GetPosition(const JPH_HeightFieldShape *_this, unsigned int inX, unsigned int inY)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetPosition(
        inX,
        inY
    ));
}

bool JPH_HeightFieldShape_IsNoCollision(const JPH_HeightFieldShape *_this, unsigned int inX, unsigned int inY)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).IsNoCollision(
        inX,
        inY
    );
}

bool JPH_HeightFieldShape_ProjectOntoSurface(const JPH_HeightFieldShape *_this, const JPH_Vec3 *inLocalPosition, JPH_Vec3 *outSurfacePosition, JPH_SubShapeID *outSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).ProjectOntoSurface(
        ((inLocalPosition ? void() : MRBINDC_THROW("Parameter `inLocalPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalPosition)),
        ((outSurfacePosition ? void() : MRBINDC_THROW("Parameter `outSurfacePosition` can not be null.", void)), *(JPH::Vec3 *)(outSurfacePosition)),
        ((outSubShapeID ? void() : MRBINDC_THROW("Parameter `outSubShapeID` can not be null.", void)), *(JPH::SubShapeID *)(outSubShapeID))
    );
}

void JPH_HeightFieldShape_GetSubShapeCoordinates(const JPH_HeightFieldShape *_this, const JPH_SubShapeID *inSubShapeID, unsigned int *outX, unsigned int *outY, unsigned int *outTriangleIndex)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetSubShapeCoordinates(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outX ? void() : MRBINDC_THROW("Parameter `outX` can not be null.", void)), *outX),
        ((outY ? void() : MRBINDC_THROW("Parameter `outY` can not be null.", void)), *outY),
        ((outTriangleIndex ? void() : MRBINDC_THROW("Parameter `outTriangleIndex` can not be null.", void)), *outTriangleIndex)
    );
}

float JPH_HeightFieldShape_GetMinHeightValue(const JPH_HeightFieldShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetMinHeightValue();
}

float JPH_HeightFieldShape_GetMaxHeightValue(const JPH_HeightFieldShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetMaxHeightValue();
}

void JPH_HeightFieldShape_GetHeights(const JPH_HeightFieldShape *_this, unsigned int inX, unsigned int inY, unsigned int inSizeX, unsigned int inSizeY, float *outHeights, long inHeightsStride)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetHeights(
        inX,
        inY,
        inSizeX,
        inSizeY,
        outHeights,
        inHeightsStride
    );
}

void JPH_HeightFieldShape_SetHeights(JPH_HeightFieldShape *_this, unsigned int inX, unsigned int inY, unsigned int inSizeX, unsigned int inSizeY, const float *inHeights, long inHeightsStride, JPH_TempAllocator *inAllocator, const float *inActiveEdgeCosThresholdAngle)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShape *)(_this)).SetHeights(
        inX,
        inY,
        inSizeX,
        inSizeY,
        inHeights,
        inHeightsStride,
        ((inAllocator ? void() : MRBINDC_THROW("Parameter `inAllocator` can not be null.", void)), *(JPH::TempAllocator *)(inAllocator)),
        (inActiveEdgeCosThresholdAngle ? *inActiveEdgeCosThresholdAngle : static_cast<float>(0.996195018F))
    );
}

void JPH_HeightFieldShape_GetMaterials(const JPH_HeightFieldShape *_this, unsigned int inX, unsigned int inY, unsigned int inSizeX, unsigned int inSizeY, unsigned char *outMaterials, long inMaterialsStride)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetMaterials(
        inX,
        inY,
        inSizeX,
        inSizeY,
        outMaterials,
        inMaterialsStride
    );
}

JPH_Shape_Stats *JPH_HeightFieldShape_GetStats(const JPH_HeightFieldShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetStats());
}

float JPH_HeightFieldShape_GetVolume(const JPH_HeightFieldShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetVolume();
}

void JPH_HeightFieldShape_sRegister(void)
{
    JPH::HeightFieldShape::sRegister();
}

uint64_t JPH_HeightFieldShape_GetUserData(const JPH_HeightFieldShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetUserData();
}

void JPH_HeightFieldShape_SetUserData(JPH_HeightFieldShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HeightFieldShape *)(_this)).SetUserData(
        inUserData
    );
}

JPH_Vec3 *JPH_HeightFieldShape_GetCenterOfMass(const JPH_HeightFieldShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetCenterOfMass());
}

const JPH_Shape *JPH_HeightFieldShape_GetLeafShape(const JPH_HeightFieldShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_HeightFieldShape_GetSubShapeUserData(const JPH_HeightFieldShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

bool JPH_HeightFieldShape_IsValidScale(const JPH_HeightFieldShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_HeightFieldShape_MakeScaleValid(const JPH_HeightFieldShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

void JPH_HeightFieldShape_SetEmbedded(const JPH_HeightFieldShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).SetEmbedded();
}

unsigned int JPH_HeightFieldShape_GetRefCount(const JPH_HeightFieldShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).GetRefCount();
}

void JPH_HeightFieldShape_AddRef(const JPH_HeightFieldShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).AddRef();
}

void JPH_HeightFieldShape_Release(const JPH_HeightFieldShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HeightFieldShape *)(_this)).Release();
}

int JPH_HeightFieldShape_sInternalGetRefCountOffset(void)
{
    return JPH::HeightFieldShape::sInternalGetRefCountOffset();
}

