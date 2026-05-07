// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/StaticCompoundShape.h"

#include <Jolt/Core/Color.h>
#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Core/TempAllocator.h>
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
#include <Jolt/Physics/Collision/Shape/CompoundShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/StaticCompoundShape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/TransformedShape.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *JPH_StaticCompoundShapeSettings_Get_mSubShapes(const JPH_StaticCompoundShapeSettings *_this)
{
    return (const Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShapeSettings *)(_this)).mSubShapes);
}

void JPH_StaticCompoundShapeSettings_Set_mSubShapes(JPH_StaticCompoundShapeSettings *_this, Jolt_PassBy value_pass_by, Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *value)
{
    MRBINDC_CLASSARG_GUARD(value, JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::StaticCompoundShapeSettings *)(_this)).mSubShapes = (MRBINDC_CLASSARG_DEF_CTOR(value, JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>) MRBINDC_CLASSARG_COPY(value, (JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>), JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>) MRBINDC_CLASSARG_MOVE(value, (JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>), JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_NoObject, JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>) MRBINDC_CLASSARG_END(value, JPH::Array<JPH::CompoundShapeSettings::SubShapeSettings>));
}

Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *JPH_StaticCompoundShapeSettings_GetMutable_mSubShapes(JPH_StaticCompoundShapeSettings *_this)
{
    return (Jolt_JPH_Array_JPH_CompoundShapeSettings_SubShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::StaticCompoundShapeSettings *)(_this)).mSubShapes);
}

const uint64_t *JPH_StaticCompoundShapeSettings_Get_mUserData(const JPH_StaticCompoundShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShapeSettings *)(_this)).mUserData);
}

void JPH_StaticCompoundShapeSettings_Set_mUserData(JPH_StaticCompoundShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::StaticCompoundShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_StaticCompoundShapeSettings_GetMutable_mUserData(JPH_StaticCompoundShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::StaticCompoundShapeSettings *)(_this)).mUserData);
}

JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::StaticCompoundShapeSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_StaticCompoundShapeSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_StaticCompoundShapeSettings *)(new JPH::StaticCompoundShapeSettings[num_elems]);
}

const JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_OffsetPtr(const JPH_StaticCompoundShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_StaticCompoundShapeSettings *)(((const JPH::StaticCompoundShapeSettings *)ptr) + i);
}

JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_OffsetMutablePtr(JPH_StaticCompoundShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_StaticCompoundShapeSettings *)(((JPH::StaticCompoundShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_StaticCompoundShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_StaticCompoundShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::StaticCompoundShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_StaticCompoundShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_StaticCompoundShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::StaticCompoundShapeSettings *)object)
    ));
}

const JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_StaticCompoundShapeSettings *)(static_cast<const JPH::StaticCompoundShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_StaticCompoundShapeSettings *)(static_cast<JPH::StaticCompoundShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_StaticCompoundShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::StaticCompoundShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_StaticCompoundShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_StaticCompoundShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::StaticCompoundShapeSettings *)object)
    ));
}

const JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_StaticCompoundShapeSettings *)(static_cast<const JPH::StaticCompoundShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_StaticCompoundShapeSettings *)(static_cast<JPH::StaticCompoundShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_StaticCompoundShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_StaticCompoundShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::StaticCompoundShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_StaticCompoundShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_StaticCompoundShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::StaticCompoundShapeSettings *)object)
    ));
}

const JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_StaticCompoundShapeSettings *)(static_cast<const JPH::StaticCompoundShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_StaticCompoundShapeSettings *)(static_cast<JPH::StaticCompoundShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const JPH_CompoundShapeSettings *JPH_StaticCompoundShapeSettings_UpcastTo_JPH_CompoundShapeSettings(const JPH_StaticCompoundShapeSettings *object)
{
    return (const JPH_CompoundShapeSettings *)(static_cast<const JPH::CompoundShapeSettings *>(
        ((const JPH::StaticCompoundShapeSettings *)object)
    ));
}

JPH_CompoundShapeSettings *JPH_StaticCompoundShapeSettings_MutableUpcastTo_JPH_CompoundShapeSettings(JPH_StaticCompoundShapeSettings *object)
{
    return (JPH_CompoundShapeSettings *)(static_cast<JPH::CompoundShapeSettings *>(
        ((JPH::StaticCompoundShapeSettings *)object)
    ));
}

const JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_StaticDowncastFrom_JPH_CompoundShapeSettings(const JPH_CompoundShapeSettings *object)
{
    return (const JPH_StaticCompoundShapeSettings *)(static_cast<const JPH::StaticCompoundShapeSettings *>(
        ((const JPH::CompoundShapeSettings *)object)
    ));
}

JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_MutableStaticDowncastFrom_JPH_CompoundShapeSettings(JPH_CompoundShapeSettings *object)
{
    return (JPH_StaticCompoundShapeSettings *)(static_cast<JPH::StaticCompoundShapeSettings *>(
        ((JPH::CompoundShapeSettings *)object)
    ));
}

JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_StaticCompoundShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::StaticCompoundShapeSettings);
    return (JPH_StaticCompoundShapeSettings *)new JPH::StaticCompoundShapeSettings(JPH::StaticCompoundShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::StaticCompoundShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::StaticCompoundShapeSettings), JPH::StaticCompoundShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::StaticCompoundShapeSettings), JPH::StaticCompoundShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::StaticCompoundShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::StaticCompoundShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::StaticCompoundShapeSettings))
    ));
}

void JPH_StaticCompoundShapeSettings_Destroy(const JPH_StaticCompoundShapeSettings *_this)
{
    delete ((const JPH::StaticCompoundShapeSettings *)_this);
}

void JPH_StaticCompoundShapeSettings_DestroyArray(const JPH_StaticCompoundShapeSettings *_this)
{
    delete[] ((const JPH::StaticCompoundShapeSettings *)_this);
}

JPH_StaticCompoundShapeSettings *JPH_StaticCompoundShapeSettings_AssignFromAnother(JPH_StaticCompoundShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_StaticCompoundShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::StaticCompoundShapeSettings);
    return (JPH_StaticCompoundShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::StaticCompoundShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::StaticCompoundShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::StaticCompoundShapeSettings), JPH::StaticCompoundShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::StaticCompoundShapeSettings), JPH::StaticCompoundShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::StaticCompoundShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::StaticCompoundShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::StaticCompoundShapeSettings))
    ));
}

void *Jolt_new_JPH_StaticCompoundShapeSettings_size_t(size_t inCount)
{
    return JPH::StaticCompoundShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr(void *inPointer)
{
    JPH::StaticCompoundShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::StaticCompoundShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_StaticCompoundShapeSettings_size_t(size_t inCount)
{
    return JPH::StaticCompoundShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr(void *inPointer)
{
    JPH::StaticCompoundShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::StaticCompoundShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_StaticCompoundShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::StaticCompoundShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::StaticCompoundShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_StaticCompoundShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::StaticCompoundShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::StaticCompoundShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_StaticCompoundShapeSettings_ClearCachedResult(JPH_StaticCompoundShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::StaticCompoundShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_StaticCompoundShapeSettings_SetEmbedded(const JPH_StaticCompoundShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_StaticCompoundShapeSettings_GetRefCount(const JPH_StaticCompoundShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShapeSettings *)(_this)).GetRefCount();
}

void JPH_StaticCompoundShapeSettings_AddRef(const JPH_StaticCompoundShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShapeSettings *)(_this)).AddRef();
}

void JPH_StaticCompoundShapeSettings_Release(const JPH_StaticCompoundShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShapeSettings *)(_this)).Release();
}

int JPH_StaticCompoundShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::StaticCompoundShapeSettings::sInternalGetRefCountOffset();
}

const int *JPH_StaticCompoundShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::StaticCompoundShape::cGetTrianglesMinTrianglesRequested);
}

const bool *JPH_StaticCompoundShape_Get_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::StaticCompoundShape::sDrawSubmergedVolumes);
}

void JPH_StaticCompoundShape_Set_sDrawSubmergedVolumes(bool value)
{
    JPH::StaticCompoundShape::sDrawSubmergedVolumes = value;
}

bool *JPH_StaticCompoundShape_GetMutable_sDrawSubmergedVolumes(void)
{
    return std::addressof(JPH::StaticCompoundShape::sDrawSubmergedVolumes);
}

JPH_StaticCompoundShape *JPH_StaticCompoundShape_DefaultConstruct(void)
{
    using _mrbind_T = JPH::StaticCompoundShape;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_StaticCompoundShape*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_StaticCompoundShape *JPH_StaticCompoundShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_StaticCompoundShape *)(new JPH::StaticCompoundShape[num_elems]);
}

const JPH_StaticCompoundShape *JPH_StaticCompoundShape_OffsetPtr(const JPH_StaticCompoundShape *ptr, ptrdiff_t i)
{
    return (const JPH_StaticCompoundShape *)(((const JPH::StaticCompoundShape *)ptr) + i);
}

JPH_StaticCompoundShape *JPH_StaticCompoundShape_OffsetMutablePtr(JPH_StaticCompoundShape *ptr, ptrdiff_t i)
{
    return (JPH_StaticCompoundShape *)(((JPH::StaticCompoundShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_StaticCompoundShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::StaticCompoundShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_StaticCompoundShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_StaticCompoundShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::StaticCompoundShape *)object)
    ));
}

const JPH_StaticCompoundShape *JPH_StaticCompoundShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_StaticCompoundShape *)(static_cast<const JPH::StaticCompoundShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_StaticCompoundShape *JPH_StaticCompoundShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_StaticCompoundShape *)(static_cast<JPH::StaticCompoundShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_StaticCompoundShape_UpcastTo_JPH_NonCopyable(const JPH_StaticCompoundShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::StaticCompoundShape *)object)
    ));
}

JPH_NonCopyable *JPH_StaticCompoundShape_MutableUpcastTo_JPH_NonCopyable(JPH_StaticCompoundShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::StaticCompoundShape *)object)
    ));
}

const JPH_StaticCompoundShape *JPH_StaticCompoundShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_StaticCompoundShape *)(static_cast<const JPH::StaticCompoundShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_StaticCompoundShape *JPH_StaticCompoundShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_StaticCompoundShape *)(static_cast<JPH::StaticCompoundShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_StaticCompoundShape_UpcastTo_JPH_Shape(const JPH_StaticCompoundShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::StaticCompoundShape *)object)
    ));
}

JPH_Shape *JPH_StaticCompoundShape_MutableUpcastTo_JPH_Shape(JPH_StaticCompoundShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::StaticCompoundShape *)object)
    ));
}

const JPH_StaticCompoundShape *JPH_StaticCompoundShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_StaticCompoundShape *)(static_cast<const JPH::StaticCompoundShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_StaticCompoundShape *JPH_StaticCompoundShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_StaticCompoundShape *)(static_cast<JPH::StaticCompoundShape *>(
        ((JPH::Shape *)object)
    ));
}

const JPH_CompoundShape *JPH_StaticCompoundShape_UpcastTo_JPH_CompoundShape(const JPH_StaticCompoundShape *object)
{
    return (const JPH_CompoundShape *)(static_cast<const JPH::CompoundShape *>(
        ((const JPH::StaticCompoundShape *)object)
    ));
}

JPH_CompoundShape *JPH_StaticCompoundShape_MutableUpcastTo_JPH_CompoundShape(JPH_StaticCompoundShape *object)
{
    return (JPH_CompoundShape *)(static_cast<JPH::CompoundShape *>(
        ((JPH::StaticCompoundShape *)object)
    ));
}

const JPH_StaticCompoundShape *JPH_StaticCompoundShape_StaticDowncastFrom_JPH_CompoundShape(const JPH_CompoundShape *object)
{
    return (const JPH_StaticCompoundShape *)(static_cast<const JPH::StaticCompoundShape *>(
        ((const JPH::CompoundShape *)object)
    ));
}

JPH_StaticCompoundShape *JPH_StaticCompoundShape_MutableStaticDowncastFrom_JPH_CompoundShape(JPH_CompoundShape *object)
{
    return (JPH_StaticCompoundShape *)(static_cast<JPH::StaticCompoundShape *>(
        ((JPH::CompoundShape *)object)
    ));
}

void JPH_StaticCompoundShape_Destroy(const JPH_StaticCompoundShape *_this)
{
    delete ((const JPH::StaticCompoundShape *)_this);
}

void JPH_StaticCompoundShape_DestroyArray(const JPH_StaticCompoundShape *_this)
{
    delete[] ((const JPH::StaticCompoundShape *)_this);
}

void *Jolt_new_JPH_StaticCompoundShape_size_t(size_t inCount)
{
    return JPH::StaticCompoundShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_StaticCompoundShape_void_ptr(void *inPointer)
{
    JPH::StaticCompoundShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_StaticCompoundShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::StaticCompoundShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_StaticCompoundShape_size_t(size_t inCount)
{
    return JPH::StaticCompoundShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_StaticCompoundShape_void_ptr(void *inPointer)
{
    JPH::StaticCompoundShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_StaticCompoundShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::StaticCompoundShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_StaticCompoundShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::StaticCompoundShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_StaticCompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::StaticCompoundShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_StaticCompoundShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::StaticCompoundShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_StaticCompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::StaticCompoundShape::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_StaticCompoundShape_CastRay_3(const JPH_StaticCompoundShape *_this, const JPH_RayCast *inRay, const JPH_SubShapeIDCreator *inSubShapeIDCreator, JPH_RayCastResult *ioHit)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).CastRay(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RayCast *)(inRay)),
        ((inSubShapeIDCreator ? void() : MRBINDC_THROW("Parameter `inSubShapeIDCreator` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(inSubShapeIDCreator)),
        ((ioHit ? void() : MRBINDC_THROW("Parameter `ioHit` can not be null.", void)), *(JPH::RayCastResult *)(ioHit))
    );
}

int JPH_StaticCompoundShape_GetIntersectingSubShapes_JPH_AABox(const JPH_StaticCompoundShape *_this, const JPH_AABox *inBox, unsigned int *outSubShapeIndices, int inMaxSubShapeIndices)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetIntersectingSubShapes(
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        outSubShapeIndices,
        inMaxSubShapeIndices
    );
}

JPH_Shape_Stats *JPH_StaticCompoundShape_GetStats(const JPH_StaticCompoundShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetStats());
}

void JPH_StaticCompoundShape_sRegister(void)
{
    JPH::StaticCompoundShape::sRegister();
}

JPH_Vec3 *JPH_StaticCompoundShape_GetCenterOfMass(const JPH_StaticCompoundShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetCenterOfMass());
}

bool JPH_StaticCompoundShape_MustBeStatic(const JPH_StaticCompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).MustBeStatic();
}

JPH_AABox *JPH_StaticCompoundShape_GetLocalBounds(const JPH_StaticCompoundShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetLocalBounds());
}

unsigned int JPH_StaticCompoundShape_GetSubShapeIDBitsRecursive(const JPH_StaticCompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetSubShapeIDBitsRecursive();
}

float JPH_StaticCompoundShape_GetInnerRadius(const JPH_StaticCompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetInnerRadius();
}

const JPH_PhysicsMaterial *JPH_StaticCompoundShape_GetMaterial(const JPH_StaticCompoundShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetMaterial(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

const JPH_Shape *JPH_StaticCompoundShape_GetLeafShape(const JPH_StaticCompoundShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_StaticCompoundShape_GetSubShapeUserData(const JPH_StaticCompoundShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

JPH_TransformedShape *JPH_StaticCompoundShape_GetSubShapeTransformedShape(const JPH_StaticCompoundShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale, JPH_SubShapeID *outRemainder)
{
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetSubShapeTransformedShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

JPH_Vec3 *JPH_StaticCompoundShape_GetSurfaceNormal(const JPH_StaticCompoundShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inLocalSurfacePosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inLocalSurfacePosition ? void() : MRBINDC_THROW("Parameter `inLocalSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLocalSurfacePosition))
    ));
}

void JPH_StaticCompoundShape_GetSubmergedVolume(const JPH_StaticCompoundShape *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Plane *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outCenterOfBuoyancy, const JPH_Vec3 *inBaseOffset)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetSubmergedVolume(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inSurface ? void() : MRBINDC_THROW("Parameter `inSurface` can not be null.", void)), *(const JPH::Plane *)(inSurface)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outCenterOfBuoyancy)),
        ((inBaseOffset ? void() : MRBINDC_THROW("Parameter `inBaseOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBaseOffset))
    );
}

void JPH_StaticCompoundShape_Draw(const JPH_StaticCompoundShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inUseMaterialColors, bool inDrawWireframe)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).Draw(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inUseMaterialColors,
        inDrawWireframe
    );
}

void JPH_StaticCompoundShape_DrawGetSupportFunction(const JPH_StaticCompoundShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale, const JPH_Color *inColor, bool inDrawSupportDirection)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).DrawGetSupportFunction(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inDrawSupportDirection
    );
}

void JPH_StaticCompoundShape_DrawGetSupportingFace(const JPH_StaticCompoundShape *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).DrawGetSupportingFace(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

void JPH_StaticCompoundShape_GetTrianglesStart(const JPH_StaticCompoundShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

int JPH_StaticCompoundShape_GetTrianglesNext(const JPH_StaticCompoundShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

const Jolt_JPH_Array_JPH_CompoundShape_SubShape *JPH_StaticCompoundShape_GetSubShapes(const JPH_StaticCompoundShape *_this)
{
    return (const Jolt_JPH_Array_JPH_CompoundShape_SubShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetSubShapes());
}

unsigned int JPH_StaticCompoundShape_GetNumSubShapes(const JPH_StaticCompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetNumSubShapes();
}

const JPH_CompoundShape_SubShape *JPH_StaticCompoundShape_GetSubShape(const JPH_StaticCompoundShape *_this, unsigned int inIdx)
{
    return (const JPH_CompoundShape_SubShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetSubShape(
        inIdx
    ));
}

unsigned int JPH_StaticCompoundShape_GetCompoundUserData(const JPH_StaticCompoundShape *_this, unsigned int inIdx)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetCompoundUserData(
        inIdx
    );
}

void JPH_StaticCompoundShape_SetCompoundUserData(JPH_StaticCompoundShape *_this, unsigned int inIdx, unsigned int inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::StaticCompoundShape *)(_this)).SetCompoundUserData(
        inIdx,
        inUserData
    );
}

bool JPH_StaticCompoundShape_IsSubShapeIDValid(const JPH_StaticCompoundShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).IsSubShapeIDValid(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)inSubShapeID))
    );
}

unsigned int JPH_StaticCompoundShape_GetSubShapeIndexFromID(const JPH_StaticCompoundShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetSubShapeIndexFromID(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    );
}

JPH_SubShapeIDCreator *JPH_StaticCompoundShape_GetSubShapeIDFromIndex(const JPH_StaticCompoundShape *_this, int inIdx, const JPH_SubShapeIDCreator *inParentSubShapeID)
{
    return (JPH_SubShapeIDCreator *)new JPH::SubShapeIDCreator(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetSubShapeIDFromIndex(
        inIdx,
        ((inParentSubShapeID ? void() : MRBINDC_THROW("Parameter `inParentSubShapeID` can not be null.", void)), *(const JPH::SubShapeIDCreator *)(inParentSubShapeID))
    ));
}

float JPH_StaticCompoundShape_GetVolume(const JPH_StaticCompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetVolume();
}

bool JPH_StaticCompoundShape_IsValidScale(const JPH_StaticCompoundShape *_this, const JPH_Vec3 *inScale)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).IsValidScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Vec3 *JPH_StaticCompoundShape_MakeScaleValid(const JPH_StaticCompoundShape *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).MakeScaleValid(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

uint64_t JPH_StaticCompoundShape_GetUserData(const JPH_StaticCompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetUserData();
}

void JPH_StaticCompoundShape_SetUserData(JPH_StaticCompoundShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::StaticCompoundShape *)(_this)).SetUserData(
        inUserData
    );
}

void JPH_StaticCompoundShape_SetEmbedded(const JPH_StaticCompoundShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).SetEmbedded();
}

unsigned int JPH_StaticCompoundShape_GetRefCount(const JPH_StaticCompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).GetRefCount();
}

void JPH_StaticCompoundShape_AddRef(const JPH_StaticCompoundShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).AddRef();
}

void JPH_StaticCompoundShape_Release(const JPH_StaticCompoundShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::StaticCompoundShape *)(_this)).Release();
}

int JPH_StaticCompoundShape_sInternalGetRefCountOffset(void)
{
    return JPH::StaticCompoundShape::sInternalGetRefCountOffset();
}

