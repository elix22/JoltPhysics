// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/MutableCompoundShape.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/Shape/CompoundShape.h>
#include <Jolt/Physics/Collision/Shape/MutableCompoundShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const uint64_t *JPH_MutableCompoundShapeSettings_Get_mUserData(const JPH_MutableCompoundShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShapeSettings *)(_this)).mUserData);
}

void JPH_MutableCompoundShapeSettings_Set_mUserData(JPH_MutableCompoundShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MutableCompoundShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_MutableCompoundShapeSettings_GetMutable_mUserData(JPH_MutableCompoundShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MutableCompoundShapeSettings *)(_this)).mUserData);
}

JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_DefaultConstruct(void)
{
    return (JPH_MutableCompoundShapeSettings *)new JPH::MutableCompoundShapeSettings(JPH::MutableCompoundShapeSettings());
}

JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_MutableCompoundShapeSettings *)(new JPH::MutableCompoundShapeSettings[num_elems]{});
}

const JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_OffsetPtr(const JPH_MutableCompoundShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_MutableCompoundShapeSettings *)(((const JPH::MutableCompoundShapeSettings *)ptr) + i);
}

JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_OffsetMutablePtr(JPH_MutableCompoundShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_MutableCompoundShapeSettings *)(((JPH::MutableCompoundShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_MutableCompoundShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_MutableCompoundShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::MutableCompoundShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_MutableCompoundShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_MutableCompoundShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::MutableCompoundShapeSettings *)object)
    ));
}

const JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_MutableCompoundShapeSettings *)(static_cast<const JPH::MutableCompoundShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_MutableCompoundShapeSettings *)(static_cast<JPH::MutableCompoundShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_MutableCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_MutableCompoundShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::MutableCompoundShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_MutableCompoundShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_MutableCompoundShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::MutableCompoundShapeSettings *)object)
    ));
}

const JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_MutableCompoundShapeSettings *)(static_cast<const JPH::MutableCompoundShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_MutableCompoundShapeSettings *)(static_cast<JPH::MutableCompoundShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_MutableCompoundShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_MutableCompoundShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::MutableCompoundShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_MutableCompoundShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_MutableCompoundShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::MutableCompoundShapeSettings *)object)
    ));
}

const JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_MutableCompoundShapeSettings *)(static_cast<const JPH::MutableCompoundShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_MutableCompoundShapeSettings *)(static_cast<JPH::MutableCompoundShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const JPH_CompoundShapeSettings *JPH_MutableCompoundShapeSettings_UpcastTo_JPH_CompoundShapeSettings(const JPH_MutableCompoundShapeSettings *object)
{
    return (const JPH_CompoundShapeSettings *)(static_cast<const JPH::CompoundShapeSettings *>(
        ((const JPH::MutableCompoundShapeSettings *)object)
    ));
}

JPH_CompoundShapeSettings *JPH_MutableCompoundShapeSettings_MutableUpcastTo_JPH_CompoundShapeSettings(JPH_MutableCompoundShapeSettings *object)
{
    return (JPH_CompoundShapeSettings *)(static_cast<JPH::CompoundShapeSettings *>(
        ((JPH::MutableCompoundShapeSettings *)object)
    ));
}

const JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_StaticDowncastFrom_JPH_CompoundShapeSettings(const JPH_CompoundShapeSettings *object)
{
    return (const JPH_MutableCompoundShapeSettings *)(static_cast<const JPH::MutableCompoundShapeSettings *>(
        ((const JPH::CompoundShapeSettings *)object)
    ));
}

JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_MutableStaticDowncastFrom_JPH_CompoundShapeSettings(JPH_CompoundShapeSettings *object)
{
    return (JPH_MutableCompoundShapeSettings *)(static_cast<JPH::MutableCompoundShapeSettings *>(
        ((JPH::CompoundShapeSettings *)object)
    ));
}

JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_MutableCompoundShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::MutableCompoundShapeSettings);
    return (JPH_MutableCompoundShapeSettings *)new JPH::MutableCompoundShapeSettings(JPH::MutableCompoundShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::MutableCompoundShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::MutableCompoundShapeSettings), JPH::MutableCompoundShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::MutableCompoundShapeSettings), JPH::MutableCompoundShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::MutableCompoundShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::MutableCompoundShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::MutableCompoundShapeSettings))
    ));
}

void JPH_MutableCompoundShapeSettings_Destroy(const JPH_MutableCompoundShapeSettings *_this)
{
    delete ((const JPH::MutableCompoundShapeSettings *)_this);
}

void JPH_MutableCompoundShapeSettings_DestroyArray(const JPH_MutableCompoundShapeSettings *_this)
{
    delete[] ((const JPH::MutableCompoundShapeSettings *)_this);
}

JPH_MutableCompoundShapeSettings *JPH_MutableCompoundShapeSettings_AssignFromAnother(JPH_MutableCompoundShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_MutableCompoundShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::MutableCompoundShapeSettings);
    return (JPH_MutableCompoundShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MutableCompoundShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::MutableCompoundShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::MutableCompoundShapeSettings), JPH::MutableCompoundShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::MutableCompoundShapeSettings), JPH::MutableCompoundShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::MutableCompoundShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::MutableCompoundShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::MutableCompoundShapeSettings))
    ));
}

void *Jolt_new_JPH_MutableCompoundShapeSettings_size_t(unsigned long inCount)
{
    return JPH::MutableCompoundShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_MutableCompoundShapeSettings_void_ptr(void *inPointer)
{
    JPH::MutableCompoundShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_MutableCompoundShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::MutableCompoundShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_MutableCompoundShapeSettings_size_t(unsigned long inCount)
{
    return JPH::MutableCompoundShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_MutableCompoundShapeSettings_void_ptr(void *inPointer)
{
    JPH::MutableCompoundShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_MutableCompoundShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::MutableCompoundShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_MutableCompoundShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::MutableCompoundShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_MutableCompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MutableCompoundShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_MutableCompoundShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::MutableCompoundShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_MutableCompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MutableCompoundShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_MutableCompoundShapeSettings_ClearCachedResult(JPH_MutableCompoundShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MutableCompoundShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_MutableCompoundShapeSettings_SetEmbedded(const JPH_MutableCompoundShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_MutableCompoundShapeSettings_GetRefCount(const JPH_MutableCompoundShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShapeSettings *)(_this)).GetRefCount();
}

void JPH_MutableCompoundShapeSettings_AddRef(const JPH_MutableCompoundShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShapeSettings *)(_this)).AddRef();
}

void JPH_MutableCompoundShapeSettings_Release(const JPH_MutableCompoundShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShapeSettings *)(_this)).Release();
}

int JPH_MutableCompoundShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::MutableCompoundShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_MutableCompoundShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::MutableCompoundShape::cGetTrianglesMinTrianglesRequested);
}

JPH_MutableCompoundShape *JPH_MutableCompoundShape_DefaultConstruct(void)
{
    return (JPH_MutableCompoundShape *)new JPH::MutableCompoundShape(JPH::MutableCompoundShape());
}

JPH_MutableCompoundShape *JPH_MutableCompoundShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_MutableCompoundShape *)(new JPH::MutableCompoundShape[num_elems]{});
}

const JPH_MutableCompoundShape *JPH_MutableCompoundShape_OffsetPtr(const JPH_MutableCompoundShape *ptr, ptrdiff_t i)
{
    return (const JPH_MutableCompoundShape *)(((const JPH::MutableCompoundShape *)ptr) + i);
}

JPH_MutableCompoundShape *JPH_MutableCompoundShape_OffsetMutablePtr(JPH_MutableCompoundShape *ptr, ptrdiff_t i)
{
    return (JPH_MutableCompoundShape *)(((JPH::MutableCompoundShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_MutableCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_MutableCompoundShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::MutableCompoundShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_MutableCompoundShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_MutableCompoundShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::MutableCompoundShape *)object)
    ));
}

const JPH_MutableCompoundShape *JPH_MutableCompoundShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_MutableCompoundShape *)(static_cast<const JPH::MutableCompoundShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_MutableCompoundShape *JPH_MutableCompoundShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_MutableCompoundShape *)(static_cast<JPH::MutableCompoundShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_MutableCompoundShape_UpcastTo_JPH_NonCopyable(const JPH_MutableCompoundShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::MutableCompoundShape *)object)
    ));
}

JPH_NonCopyable *JPH_MutableCompoundShape_MutableUpcastTo_JPH_NonCopyable(JPH_MutableCompoundShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::MutableCompoundShape *)object)
    ));
}

const JPH_MutableCompoundShape *JPH_MutableCompoundShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_MutableCompoundShape *)(static_cast<const JPH::MutableCompoundShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_MutableCompoundShape *JPH_MutableCompoundShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_MutableCompoundShape *)(static_cast<JPH::MutableCompoundShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_MutableCompoundShape_UpcastTo_JPH_Shape(const JPH_MutableCompoundShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::MutableCompoundShape *)object)
    ));
}

JPH_Shape *JPH_MutableCompoundShape_MutableUpcastTo_JPH_Shape(JPH_MutableCompoundShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::MutableCompoundShape *)object)
    ));
}

const JPH_MutableCompoundShape *JPH_MutableCompoundShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_MutableCompoundShape *)(static_cast<const JPH::MutableCompoundShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_MutableCompoundShape *JPH_MutableCompoundShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_MutableCompoundShape *)(static_cast<JPH::MutableCompoundShape *>(
        ((JPH::Shape *)object)
    ));
}

const JPH_CompoundShape *JPH_MutableCompoundShape_UpcastTo_JPH_CompoundShape(const JPH_MutableCompoundShape *object)
{
    return (const JPH_CompoundShape *)(static_cast<const JPH::CompoundShape *>(
        ((const JPH::MutableCompoundShape *)object)
    ));
}

JPH_CompoundShape *JPH_MutableCompoundShape_MutableUpcastTo_JPH_CompoundShape(JPH_MutableCompoundShape *object)
{
    return (JPH_CompoundShape *)(static_cast<JPH::CompoundShape *>(
        ((JPH::MutableCompoundShape *)object)
    ));
}

const JPH_MutableCompoundShape *JPH_MutableCompoundShape_StaticDowncastFrom_JPH_CompoundShape(const JPH_CompoundShape *object)
{
    return (const JPH_MutableCompoundShape *)(static_cast<const JPH::MutableCompoundShape *>(
        ((const JPH::CompoundShape *)object)
    ));
}

JPH_MutableCompoundShape *JPH_MutableCompoundShape_MutableStaticDowncastFrom_JPH_CompoundShape(JPH_CompoundShape *object)
{
    return (JPH_MutableCompoundShape *)(static_cast<JPH::MutableCompoundShape *>(
        ((JPH::CompoundShape *)object)
    ));
}

void JPH_MutableCompoundShape_Destroy(const JPH_MutableCompoundShape *_this)
{
    delete ((const JPH::MutableCompoundShape *)_this);
}

void JPH_MutableCompoundShape_DestroyArray(const JPH_MutableCompoundShape *_this)
{
    delete[] ((const JPH::MutableCompoundShape *)_this);
}

void *Jolt_new_JPH_MutableCompoundShape_size_t(unsigned long inCount)
{
    return JPH::MutableCompoundShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_MutableCompoundShape_void_ptr(void *inPointer)
{
    JPH::MutableCompoundShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_MutableCompoundShape_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::MutableCompoundShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_MutableCompoundShape_size_t(unsigned long inCount)
{
    return JPH::MutableCompoundShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_MutableCompoundShape_void_ptr(void *inPointer)
{
    JPH::MutableCompoundShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_MutableCompoundShape_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::MutableCompoundShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_MutableCompoundShape_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::MutableCompoundShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_MutableCompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MutableCompoundShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_MutableCompoundShape_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::MutableCompoundShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_MutableCompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MutableCompoundShape::operator delete[](
        inPointer,
        inPlace
    );
}

int JPH_MutableCompoundShape_GetIntersectingSubShapes_JPH_AABox(const JPH_MutableCompoundShape *_this, const JPH_AABox *inBox, unsigned int *outSubShapeIndices, int inMaxSubShapeIndices)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetIntersectingSubShapes(
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        outSubShapeIndices,
        inMaxSubShapeIndices
    );
}

JPH_Shape_Stats *JPH_MutableCompoundShape_GetStats(const JPH_MutableCompoundShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetStats());
}

unsigned int JPH_MutableCompoundShape_AddShape(JPH_MutableCompoundShape *_this, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const JPH_Shape *inShape, const unsigned int *inUserData, const unsigned int *inIndex)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MutableCompoundShape *)(_this)).AddShape(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((const JPH::Shape *)inShape),
        (inUserData ? *inUserData : static_cast<unsigned int>(0)),
        (inIndex ? *inIndex : static_cast<unsigned int>((2147483647 * 2U + 1U)))
    );
}

void JPH_MutableCompoundShape_RemoveShape(JPH_MutableCompoundShape *_this, unsigned int inIndex)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MutableCompoundShape *)(_this)).RemoveShape(
        inIndex
    );
}

void JPH_MutableCompoundShape_ModifyShape_3(JPH_MutableCompoundShape *_this, unsigned int inIndex, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MutableCompoundShape *)(_this)).ModifyShape(
        inIndex,
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation))
    );
}

void JPH_MutableCompoundShape_ModifyShape_4(JPH_MutableCompoundShape *_this, unsigned int inIndex, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const JPH_Shape *inShape)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MutableCompoundShape *)(_this)).ModifyShape(
        inIndex,
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((const JPH::Shape *)inShape)
    );
}

void JPH_MutableCompoundShape_ModifyShapes(JPH_MutableCompoundShape *_this, unsigned int inStartIndex, unsigned int inNumber, const JPH_Vec3 *inPositions, const JPH_Quat *inRotations, const unsigned int *inPositionStride, const unsigned int *inRotationStride)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MutableCompoundShape *)(_this)).ModifyShapes(
        inStartIndex,
        inNumber,
        ((const JPH::Vec3 *)inPositions),
        ((const JPH::Quat *)inRotations),
        (inPositionStride ? *inPositionStride : static_cast<unsigned int>(sizeof(JPH::Vec3))),
        (inRotationStride ? *inRotationStride : static_cast<unsigned int>(sizeof(JPH::Quat)))
    );
}

void JPH_MutableCompoundShape_AdjustCenterOfMass(JPH_MutableCompoundShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MutableCompoundShape *)(_this)).AdjustCenterOfMass();
}

void JPH_MutableCompoundShape_sRegister(void)
{
    JPH::MutableCompoundShape::sRegister();
}

JPH_Vec3 *JPH_MutableCompoundShape_GetCenterOfMass(const JPH_MutableCompoundShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetCenterOfMass());
}

bool JPH_MutableCompoundShape_MustBeStatic(const JPH_MutableCompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).MustBeStatic();
}

JPH_AABox *JPH_MutableCompoundShape_GetLocalBounds(const JPH_MutableCompoundShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetLocalBounds());
}

unsigned int JPH_MutableCompoundShape_GetSubShapeIDBitsRecursive(const JPH_MutableCompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetSubShapeIDBitsRecursive();
}

float JPH_MutableCompoundShape_GetInnerRadius(const JPH_MutableCompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetInnerRadius();
}

const JPH_PhysicsMaterial *JPH_MutableCompoundShape_GetMaterial(const JPH_MutableCompoundShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetMaterial(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

const JPH_Shape *JPH_MutableCompoundShape_GetLeafShape(const JPH_MutableCompoundShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_MutableCompoundShape_GetSubShapeUserData(const JPH_MutableCompoundShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

JPH_Vec3 *JPH_MutableCompoundShape_GetSurfaceNormal(const JPH_MutableCompoundShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

void JPH_MutableCompoundShape_GetTrianglesStart(const JPH_MutableCompoundShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_MutableCompoundShape_GetTrianglesNext(const JPH_MutableCompoundShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

unsigned int JPH_MutableCompoundShape_GetNumSubShapes(const JPH_MutableCompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetNumSubShapes();
}

const JPH_CompoundShape_SubShape *JPH_MutableCompoundShape_GetSubShape(const JPH_MutableCompoundShape *_this, unsigned int inIdx)
{
    return (const JPH_CompoundShape_SubShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetSubShape(
        inIdx
    ));
}

unsigned int JPH_MutableCompoundShape_GetCompoundUserData(const JPH_MutableCompoundShape *_this, unsigned int inIdx)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetCompoundUserData(
        inIdx
    );
}

void JPH_MutableCompoundShape_SetCompoundUserData(JPH_MutableCompoundShape *_this, unsigned int inIdx, unsigned int inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MutableCompoundShape *)(_this)).SetCompoundUserData(
        inIdx,
        inUserData
    );
}

bool JPH_MutableCompoundShape_IsSubShapeIDValid(const JPH_MutableCompoundShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).IsSubShapeIDValid(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)inSubShapeID))
    );
}

unsigned int JPH_MutableCompoundShape_GetSubShapeIndexFromID(const JPH_MutableCompoundShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetSubShapeIndexFromID(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    );
}

float JPH_MutableCompoundShape_GetVolume(const JPH_MutableCompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetVolume();
}

bool JPH_MutableCompoundShape_IsValidScale(const JPH_MutableCompoundShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_MutableCompoundShape_MakeScaleValid(const JPH_MutableCompoundShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

uint64_t JPH_MutableCompoundShape_GetUserData(const JPH_MutableCompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetUserData();
}

void JPH_MutableCompoundShape_SetUserData(JPH_MutableCompoundShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MutableCompoundShape *)(_this)).SetUserData(
        inUserData
    );
}

void JPH_MutableCompoundShape_SetEmbedded(const JPH_MutableCompoundShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).SetEmbedded();
}

unsigned int JPH_MutableCompoundShape_GetRefCount(const JPH_MutableCompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).GetRefCount();
}

void JPH_MutableCompoundShape_AddRef(const JPH_MutableCompoundShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).AddRef();
}

void JPH_MutableCompoundShape_Release(const JPH_MutableCompoundShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MutableCompoundShape *)(_this)).Release();
}

int JPH_MutableCompoundShape_sInternalGetRefCountOffset(void)
{
    return JPH::MutableCompoundShape::sInternalGetRefCountOffset();
}

