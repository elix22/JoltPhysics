// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/PathConstraintPath.h"

#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Constraints/PathConstraintPath.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


void JPH_PathConstraintPath_Destroy(const JPH_PathConstraintPath *_this)
{
    delete ((const JPH::PathConstraintPath *)_this);
}

void JPH_PathConstraintPath_DestroyArray(const JPH_PathConstraintPath *_this)
{
    delete[] ((const JPH::PathConstraintPath *)_this);
}

void *Jolt_new_JPH_PathConstraintPath_size_t(size_t inCount)
{
    return JPH::PathConstraintPath::operator new(
        inCount
    );
}

void Jolt_delete_JPH_PathConstraintPath_void_ptr(void *inPointer)
{
    JPH::PathConstraintPath::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_PathConstraintPath_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PathConstraintPath::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_PathConstraintPath_size_t(size_t inCount)
{
    return JPH::PathConstraintPath::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_PathConstraintPath_void_ptr(void *inPointer)
{
    JPH::PathConstraintPath::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_PathConstraintPath_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PathConstraintPath::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_PathConstraintPath_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PathConstraintPath::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_PathConstraintPath_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PathConstraintPath::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_PathConstraintPath_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PathConstraintPath::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_PathConstraintPath_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PathConstraintPath::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_PathConstraintPath_GetPathMaxFraction(const JPH_PathConstraintPath *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPath *)(_this)).GetPathMaxFraction();
}

float JPH_PathConstraintPath_GetClosestPoint(const JPH_PathConstraintPath *_this, const JPH_Vec3 *inPosition, float inFractionHint)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPath *)(_this)).GetClosestPoint(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        inFractionHint
    );
}

void JPH_PathConstraintPath_GetPointOnPath(const JPH_PathConstraintPath *_this, float inFraction, JPH_Vec3 *outPathPosition, JPH_Vec3 *outPathTangent, JPH_Vec3 *outPathNormal, JPH_Vec3 *outPathBinormal)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPath *)(_this)).GetPointOnPath(
        inFraction,
        ((outPathPosition ? void() : MRBINDC_THROW("Parameter `outPathPosition` can not be null.", void)), *(JPH::Vec3 *)(outPathPosition)),
        ((outPathTangent ? void() : MRBINDC_THROW("Parameter `outPathTangent` can not be null.", void)), *(JPH::Vec3 *)(outPathTangent)),
        ((outPathNormal ? void() : MRBINDC_THROW("Parameter `outPathNormal` can not be null.", void)), *(JPH::Vec3 *)(outPathNormal)),
        ((outPathBinormal ? void() : MRBINDC_THROW("Parameter `outPathBinormal` can not be null.", void)), *(JPH::Vec3 *)(outPathBinormal))
    );
}

void JPH_PathConstraintPath_SetIsLooping(JPH_PathConstraintPath *_this, bool inIsLooping)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PathConstraintPath *)(_this)).SetIsLooping(
        inIsLooping
    );
}

bool JPH_PathConstraintPath_IsLooping(const JPH_PathConstraintPath *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPath *)(_this)).IsLooping();
}

void JPH_PathConstraintPath_SetEmbedded(const JPH_PathConstraintPath *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPath *)(_this)).SetEmbedded();
}

unsigned int JPH_PathConstraintPath_GetRefCount(const JPH_PathConstraintPath *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPath *)(_this)).GetRefCount();
}

void JPH_PathConstraintPath_AddRef(const JPH_PathConstraintPath *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPath *)(_this)).AddRef();
}

void JPH_PathConstraintPath_Release(const JPH_PathConstraintPath *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPath *)(_this)).Release();
}

int JPH_PathConstraintPath_sInternalGetRefCountOffset(void)
{
    return JPH::PathConstraintPath::sInternalGetRefCountOffset();
}

const JPH_PathConstraintPath *JPH_PathConstraintPath_OffsetPtr(const JPH_PathConstraintPath *ptr, ptrdiff_t i)
{
    return (const JPH_PathConstraintPath *)(((const JPH::PathConstraintPath *)ptr) + i);
}

JPH_PathConstraintPath *JPH_PathConstraintPath_OffsetMutablePtr(JPH_PathConstraintPath *ptr, ptrdiff_t i)
{
    return (JPH_PathConstraintPath *)(((JPH::PathConstraintPath *)ptr) + i);
}

const JPH_SerializableObject *JPH_PathConstraintPath_UpcastTo_JPH_SerializableObject(const JPH_PathConstraintPath *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::PathConstraintPath *)object)
    ));
}

JPH_SerializableObject *JPH_PathConstraintPath_MutableUpcastTo_JPH_SerializableObject(JPH_PathConstraintPath *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::PathConstraintPath *)object)
    ));
}

const JPH_PathConstraintPath *JPH_PathConstraintPath_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_PathConstraintPath *)(static_cast<const JPH::PathConstraintPath *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_PathConstraintPath *JPH_PathConstraintPath_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_PathConstraintPath *)(static_cast<JPH::PathConstraintPath *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_PathConstraintPath *JPH_PathConstraintPath_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(const JPH_PathConstraintPath *object)
{
    return (const JPH_RefTarget_JPH_PathConstraintPath *)(static_cast<const JPH::RefTarget<JPH::PathConstraintPath> *>(
        ((const JPH::PathConstraintPath *)object)
    ));
}

JPH_RefTarget_JPH_PathConstraintPath *JPH_PathConstraintPath_MutableUpcastTo_JPH_RefTarget_JPH_PathConstraintPath(JPH_PathConstraintPath *object)
{
    return (JPH_RefTarget_JPH_PathConstraintPath *)(static_cast<JPH::RefTarget<JPH::PathConstraintPath> *>(
        ((JPH::PathConstraintPath *)object)
    ));
}

const JPH_PathConstraintPath *JPH_PathConstraintPath_StaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath(const JPH_RefTarget_JPH_PathConstraintPath *object)
{
    return (const JPH_PathConstraintPath *)(static_cast<const JPH::PathConstraintPath *>(
        ((const JPH::RefTarget<JPH::PathConstraintPath> *)object)
    ));
}

JPH_PathConstraintPath *JPH_PathConstraintPath_MutableStaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath(JPH_RefTarget_JPH_PathConstraintPath *object)
{
    return (JPH_PathConstraintPath *)(static_cast<JPH::PathConstraintPath *>(
        ((JPH::RefTarget<JPH::PathConstraintPath> *)object)
    ));
}

