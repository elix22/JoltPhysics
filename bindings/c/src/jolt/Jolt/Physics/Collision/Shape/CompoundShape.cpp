// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/CompoundShape.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/Shape/CompoundShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const uint64_t *JPH_CompoundShapeSettings_Get_mUserData(const JPH_CompoundShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShapeSettings *)(_this)).mUserData);
}

void JPH_CompoundShapeSettings_Set_mUserData(JPH_CompoundShapeSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CompoundShapeSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_CompoundShapeSettings_GetMutable_mUserData(JPH_CompoundShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CompoundShapeSettings *)(_this)).mUserData);
}

void JPH_CompoundShapeSettings_Destroy(const JPH_CompoundShapeSettings *_this)
{
    delete ((const JPH::CompoundShapeSettings *)_this);
}

void JPH_CompoundShapeSettings_DestroyArray(const JPH_CompoundShapeSettings *_this)
{
    delete[] ((const JPH::CompoundShapeSettings *)_this);
}

void *Jolt_new_JPH_CompoundShapeSettings_size_t(unsigned long inCount)
{
    return JPH::CompoundShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CompoundShapeSettings_void_ptr(void *inPointer)
{
    JPH::CompoundShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CompoundShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::CompoundShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CompoundShapeSettings_size_t(unsigned long inCount)
{
    return JPH::CompoundShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr(void *inPointer)
{
    JPH::CompoundShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::CompoundShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CompoundShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::CompoundShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CompoundShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CompoundShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::CompoundShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CompoundShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_CompoundShapeSettings_ClearCachedResult(JPH_CompoundShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CompoundShapeSettings *)(_this)).ClearCachedResult();
}

void JPH_CompoundShapeSettings_SetEmbedded(const JPH_CompoundShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShapeSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_CompoundShapeSettings_GetRefCount(const JPH_CompoundShapeSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShapeSettings *)(_this)).GetRefCount();
}

void JPH_CompoundShapeSettings_AddRef(const JPH_CompoundShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShapeSettings *)(_this)).AddRef();
}

void JPH_CompoundShapeSettings_Release(const JPH_CompoundShapeSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShapeSettings *)(_this)).Release();
}

int JPH_CompoundShapeSettings_sInternalGetRefCountOffset(void)
{
    return JPH::CompoundShapeSettings::sInternalGetRefCountOffset();
}

const JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_OffsetPtr(const JPH_CompoundShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_CompoundShapeSettings *)(((const JPH::CompoundShapeSettings *)ptr) + i);
}

JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_OffsetMutablePtr(JPH_CompoundShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_CompoundShapeSettings *)(((JPH::CompoundShapeSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject(const JPH_CompoundShapeSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::CompoundShapeSettings *)object)
    ));
}

JPH_SerializableObject *JPH_CompoundShapeSettings_MutableUpcastTo_JPH_SerializableObject(JPH_CompoundShapeSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::CompoundShapeSettings *)object)
    ));
}

const JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_CompoundShapeSettings *)(static_cast<const JPH::CompoundShapeSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_CompoundShapeSettings *)(static_cast<JPH::CompoundShapeSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ShapeSettings *JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(const JPH_CompoundShapeSettings *object)
{
    return (const JPH_RefTarget_JPH_ShapeSettings *)(static_cast<const JPH::RefTarget<JPH::ShapeSettings> *>(
        ((const JPH::CompoundShapeSettings *)object)
    ));
}

JPH_RefTarget_JPH_ShapeSettings *JPH_CompoundShapeSettings_MutableUpcastTo_JPH_RefTarget_JPH_ShapeSettings(JPH_CompoundShapeSettings *object)
{
    return (JPH_RefTarget_JPH_ShapeSettings *)(static_cast<JPH::RefTarget<JPH::ShapeSettings> *>(
        ((JPH::CompoundShapeSettings *)object)
    ));
}

const JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(const JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (const JPH_CompoundShapeSettings *)(static_cast<const JPH::CompoundShapeSettings *>(
        ((const JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH_RefTarget_JPH_ShapeSettings *object)
{
    return (JPH_CompoundShapeSettings *)(static_cast<JPH::CompoundShapeSettings *>(
        ((JPH::RefTarget<JPH::ShapeSettings> *)object)
    ));
}

const JPH_ShapeSettings *JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings(const JPH_CompoundShapeSettings *object)
{
    return (const JPH_ShapeSettings *)(static_cast<const JPH::ShapeSettings *>(
        ((const JPH::CompoundShapeSettings *)object)
    ));
}

JPH_ShapeSettings *JPH_CompoundShapeSettings_MutableUpcastTo_JPH_ShapeSettings(JPH_CompoundShapeSettings *object)
{
    return (JPH_ShapeSettings *)(static_cast<JPH::ShapeSettings *>(
        ((JPH::CompoundShapeSettings *)object)
    ));
}

const JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(const JPH_ShapeSettings *object)
{
    return (const JPH_CompoundShapeSettings *)(static_cast<const JPH::CompoundShapeSettings *>(
        ((const JPH::ShapeSettings *)object)
    ));
}

JPH_CompoundShapeSettings *JPH_CompoundShapeSettings_MutableStaticDowncastFrom_JPH_ShapeSettings(JPH_ShapeSettings *object)
{
    return (JPH_CompoundShapeSettings *)(static_cast<JPH::CompoundShapeSettings *>(
        ((JPH::ShapeSettings *)object)
    ));
}

const unsigned int *JPH_CompoundShapeSettings_SubShapeSettings_Get_mUserData(const JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShapeSettings::SubShapeSettings *)(_this)).mUserData);
}

void JPH_CompoundShapeSettings_SubShapeSettings_Set_mUserData(JPH_CompoundShapeSettings_SubShapeSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CompoundShapeSettings::SubShapeSettings *)(_this)).mUserData = value;
}

unsigned int *JPH_CompoundShapeSettings_SubShapeSettings_GetMutable_mUserData(JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CompoundShapeSettings::SubShapeSettings *)(_this)).mUserData);
}

JPH_CompoundShapeSettings_SubShapeSettings *JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstruct(void)
{
    return (JPH_CompoundShapeSettings_SubShapeSettings *)new JPH::CompoundShapeSettings::SubShapeSettings(JPH::CompoundShapeSettings::SubShapeSettings());
}

JPH_CompoundShapeSettings_SubShapeSettings *JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CompoundShapeSettings_SubShapeSettings *)(new JPH::CompoundShapeSettings::SubShapeSettings[num_elems]{});
}

JPH_CompoundShapeSettings_SubShapeSettings *JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CompoundShapeSettings_SubShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CompoundShapeSettings::SubShapeSettings);
    return (JPH_CompoundShapeSettings_SubShapeSettings *)new JPH::CompoundShapeSettings::SubShapeSettings(JPH::CompoundShapeSettings::SubShapeSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::CompoundShapeSettings::SubShapeSettings), JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::CompoundShapeSettings::SubShapeSettings), JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::CompoundShapeSettings::SubShapeSettings))
    ));
}

void JPH_CompoundShapeSettings_SubShapeSettings_Destroy(const JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    delete ((const JPH::CompoundShapeSettings::SubShapeSettings *)_this);
}

void JPH_CompoundShapeSettings_SubShapeSettings_DestroyArray(const JPH_CompoundShapeSettings_SubShapeSettings *_this)
{
    delete[] ((const JPH::CompoundShapeSettings::SubShapeSettings *)_this);
}

JPH_CompoundShapeSettings_SubShapeSettings *JPH_CompoundShapeSettings_SubShapeSettings_AssignFromAnother(JPH_CompoundShapeSettings_SubShapeSettings *_this, Jolt_PassBy _other_pass_by, JPH_CompoundShapeSettings_SubShapeSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CompoundShapeSettings::SubShapeSettings);
    return (JPH_CompoundShapeSettings_SubShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CompoundShapeSettings::SubShapeSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::CompoundShapeSettings::SubShapeSettings), JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::CompoundShapeSettings::SubShapeSettings), JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CompoundShapeSettings::SubShapeSettings) MRBINDC_CLASSARG_END(_other, JPH::CompoundShapeSettings::SubShapeSettings))
    ));
}

void *Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t(unsigned long inCount)
{
    return JPH::CompoundShapeSettings::SubShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr(void *inPointer)
{
    JPH::CompoundShapeSettings::SubShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::CompoundShapeSettings::SubShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t(unsigned long inCount)
{
    return JPH::CompoundShapeSettings::SubShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr(void *inPointer)
{
    JPH::CompoundShapeSettings::SubShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::CompoundShapeSettings::SubShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::CompoundShapeSettings::SubShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CompoundShapeSettings::SubShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::CompoundShapeSettings::SubShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CompoundShapeSettings::SubShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

const int *JPH_CompoundShape_Get_cGetTrianglesMinTrianglesRequested(void)
{
    return std::addressof(JPH::CompoundShape::cGetTrianglesMinTrianglesRequested);
}

void JPH_CompoundShape_Destroy(const JPH_CompoundShape *_this)
{
    delete ((const JPH::CompoundShape *)_this);
}

void JPH_CompoundShape_DestroyArray(const JPH_CompoundShape *_this)
{
    delete[] ((const JPH::CompoundShape *)_this);
}

void *Jolt_new_JPH_CompoundShape_size_t(unsigned long inCount)
{
    return JPH::CompoundShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CompoundShape_void_ptr(void *inPointer)
{
    JPH::CompoundShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CompoundShape_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::CompoundShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CompoundShape_size_t(unsigned long inCount)
{
    return JPH::CompoundShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CompoundShape_void_ptr(void *inPointer)
{
    JPH::CompoundShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CompoundShape_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::CompoundShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CompoundShape_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::CompoundShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CompoundShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CompoundShape_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::CompoundShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CompoundShape::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_CompoundShape_MustBeStatic(const JPH_CompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).MustBeStatic();
}

JPH_AABox *JPH_CompoundShape_GetLocalBounds(const JPH_CompoundShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).GetLocalBounds());
}

unsigned int JPH_CompoundShape_GetSubShapeIDBitsRecursive(const JPH_CompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).GetSubShapeIDBitsRecursive();
}

float JPH_CompoundShape_GetInnerRadius(const JPH_CompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).GetInnerRadius();
}

const JPH_PhysicsMaterial *JPH_CompoundShape_GetMaterial(const JPH_CompoundShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).GetMaterial(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

const JPH_Shape *JPH_CompoundShape_GetLeafShape(const JPH_CompoundShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).GetLeafShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

uint64_t JPH_CompoundShape_GetSubShapeUserData(const JPH_CompoundShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

int JPH_CompoundShape_GetIntersectingSubShapes_JPH_AABox(const JPH_CompoundShape *_this, const JPH_AABox *inBox, unsigned int *outSubShapeIndices, int inMaxSubShapeIndices)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).GetIntersectingSubShapes(
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        outSubShapeIndices,
        inMaxSubShapeIndices
    );
}

unsigned int JPH_CompoundShape_GetNumSubShapes(const JPH_CompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).GetNumSubShapes();
}

const JPH_CompoundShape_SubShape *JPH_CompoundShape_GetSubShape(const JPH_CompoundShape *_this, unsigned int inIdx)
{
    return (const JPH_CompoundShape_SubShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).GetSubShape(
        inIdx
    ));
}

unsigned int JPH_CompoundShape_GetCompoundUserData(const JPH_CompoundShape *_this, unsigned int inIdx)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).GetCompoundUserData(
        inIdx
    );
}

void JPH_CompoundShape_SetCompoundUserData(JPH_CompoundShape *_this, unsigned int inIdx, unsigned int inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CompoundShape *)(_this)).SetCompoundUserData(
        inIdx,
        inUserData
    );
}

bool JPH_CompoundShape_IsSubShapeIDValid(const JPH_CompoundShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).IsSubShapeIDValid(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)inSubShapeID))
    );
}

unsigned int JPH_CompoundShape_GetSubShapeIndexFromID(const JPH_CompoundShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).GetSubShapeIndexFromID(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    );
}

float JPH_CompoundShape_GetVolume(const JPH_CompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).GetVolume();
}

void JPH_CompoundShape_sRegister(void)
{
    JPH::CompoundShape::sRegister();
}

uint64_t JPH_CompoundShape_GetUserData(const JPH_CompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).GetUserData();
}

void JPH_CompoundShape_SetUserData(JPH_CompoundShape *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CompoundShape *)(_this)).SetUserData(
        inUserData
    );
}

JPH_Shape_Stats *JPH_CompoundShape_GetStats(const JPH_CompoundShape *_this)
{
    return (JPH_Shape_Stats *)new JPH::Shape::Stats(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).GetStats());
}

void JPH_CompoundShape_SetEmbedded(const JPH_CompoundShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).SetEmbedded();
}

unsigned int JPH_CompoundShape_GetRefCount(const JPH_CompoundShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).GetRefCount();
}

void JPH_CompoundShape_AddRef(const JPH_CompoundShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).AddRef();
}

void JPH_CompoundShape_Release(const JPH_CompoundShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape *)(_this)).Release();
}

int JPH_CompoundShape_sInternalGetRefCountOffset(void)
{
    return JPH::CompoundShape::sInternalGetRefCountOffset();
}

const JPH_CompoundShape *JPH_CompoundShape_OffsetPtr(const JPH_CompoundShape *ptr, ptrdiff_t i)
{
    return (const JPH_CompoundShape *)(((const JPH::CompoundShape *)ptr) + i);
}

JPH_CompoundShape *JPH_CompoundShape_OffsetMutablePtr(JPH_CompoundShape *ptr, ptrdiff_t i)
{
    return (JPH_CompoundShape *)(((JPH::CompoundShape *)ptr) + i);
}

const JPH_RefTarget_JPH_Shape *JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(const JPH_CompoundShape *object)
{
    return (const JPH_RefTarget_JPH_Shape *)(static_cast<const JPH::RefTarget<JPH::Shape> *>(
        ((const JPH::CompoundShape *)object)
    ));
}

JPH_RefTarget_JPH_Shape *JPH_CompoundShape_MutableUpcastTo_JPH_RefTarget_JPH_Shape(JPH_CompoundShape *object)
{
    return (JPH_RefTarget_JPH_Shape *)(static_cast<JPH::RefTarget<JPH::Shape> *>(
        ((JPH::CompoundShape *)object)
    ));
}

const JPH_CompoundShape *JPH_CompoundShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(const JPH_RefTarget_JPH_Shape *object)
{
    return (const JPH_CompoundShape *)(static_cast<const JPH::CompoundShape *>(
        ((const JPH::RefTarget<JPH::Shape> *)object)
    ));
}

JPH_CompoundShape *JPH_CompoundShape_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH_RefTarget_JPH_Shape *object)
{
    return (JPH_CompoundShape *)(static_cast<JPH::CompoundShape *>(
        ((JPH::RefTarget<JPH::Shape> *)object)
    ));
}

const JPH_NonCopyable *JPH_CompoundShape_UpcastTo_JPH_NonCopyable(const JPH_CompoundShape *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::CompoundShape *)object)
    ));
}

JPH_NonCopyable *JPH_CompoundShape_MutableUpcastTo_JPH_NonCopyable(JPH_CompoundShape *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::CompoundShape *)object)
    ));
}

const JPH_CompoundShape *JPH_CompoundShape_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_CompoundShape *)(static_cast<const JPH::CompoundShape *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_CompoundShape *JPH_CompoundShape_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_CompoundShape *)(static_cast<JPH::CompoundShape *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Shape *JPH_CompoundShape_UpcastTo_JPH_Shape(const JPH_CompoundShape *object)
{
    return (const JPH_Shape *)(static_cast<const JPH::Shape *>(
        ((const JPH::CompoundShape *)object)
    ));
}

JPH_Shape *JPH_CompoundShape_MutableUpcastTo_JPH_Shape(JPH_CompoundShape *object)
{
    return (JPH_Shape *)(static_cast<JPH::Shape *>(
        ((JPH::CompoundShape *)object)
    ));
}

const JPH_CompoundShape *JPH_CompoundShape_StaticDowncastFrom_JPH_Shape(const JPH_Shape *object)
{
    return (const JPH_CompoundShape *)(static_cast<const JPH::CompoundShape *>(
        ((const JPH::Shape *)object)
    ));
}

JPH_CompoundShape *JPH_CompoundShape_MutableStaticDowncastFrom_JPH_Shape(JPH_Shape *object)
{
    return (JPH_CompoundShape *)(static_cast<JPH::CompoundShape *>(
        ((JPH::Shape *)object)
    ));
}

const unsigned int *JPH_CompoundShape_SubShape_Get_mUserData(const JPH_CompoundShape_SubShape *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape::SubShape *)(_this)).mUserData);
}

void JPH_CompoundShape_SubShape_Set_mUserData(JPH_CompoundShape_SubShape *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CompoundShape::SubShape *)(_this)).mUserData = value;
}

unsigned int *JPH_CompoundShape_SubShape_GetMutable_mUserData(JPH_CompoundShape_SubShape *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CompoundShape::SubShape *)(_this)).mUserData);
}

const bool *JPH_CompoundShape_SubShape_Get_mIsRotationIdentity(const JPH_CompoundShape_SubShape *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CompoundShape::SubShape *)(_this)).mIsRotationIdentity);
}

void JPH_CompoundShape_SubShape_Set_mIsRotationIdentity(JPH_CompoundShape_SubShape *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CompoundShape::SubShape *)(_this)).mIsRotationIdentity = value;
}

bool *JPH_CompoundShape_SubShape_GetMutable_mIsRotationIdentity(JPH_CompoundShape_SubShape *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CompoundShape::SubShape *)(_this)).mIsRotationIdentity);
}

JPH_CompoundShape_SubShape *JPH_CompoundShape_SubShape_DefaultConstruct(void)
{
    return (JPH_CompoundShape_SubShape *)new JPH::CompoundShape::SubShape(JPH::CompoundShape::SubShape());
}

JPH_CompoundShape_SubShape *JPH_CompoundShape_SubShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CompoundShape_SubShape *)(new JPH::CompoundShape::SubShape[num_elems]{});
}

JPH_CompoundShape_SubShape *JPH_CompoundShape_SubShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CompoundShape_SubShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CompoundShape::SubShape);
    return (JPH_CompoundShape_SubShape *)new JPH::CompoundShape::SubShape(JPH::CompoundShape::SubShape(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_COPY(_other, (JPH::CompoundShape::SubShape), JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_MOVE(_other, (JPH::CompoundShape::SubShape), JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_END(_other, JPH::CompoundShape::SubShape))
    ));
}

void JPH_CompoundShape_SubShape_Destroy(const JPH_CompoundShape_SubShape *_this)
{
    delete ((const JPH::CompoundShape::SubShape *)_this);
}

void JPH_CompoundShape_SubShape_DestroyArray(const JPH_CompoundShape_SubShape *_this)
{
    delete[] ((const JPH::CompoundShape::SubShape *)_this);
}

JPH_CompoundShape_SubShape *JPH_CompoundShape_SubShape_AssignFromAnother(JPH_CompoundShape_SubShape *_this, Jolt_PassBy _other_pass_by, JPH_CompoundShape_SubShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CompoundShape::SubShape);
    return (JPH_CompoundShape_SubShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CompoundShape::SubShape *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_COPY(_other, (JPH::CompoundShape::SubShape), JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_MOVE(_other, (JPH::CompoundShape::SubShape), JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CompoundShape::SubShape) MRBINDC_CLASSARG_END(_other, JPH::CompoundShape::SubShape))
    ));
}

