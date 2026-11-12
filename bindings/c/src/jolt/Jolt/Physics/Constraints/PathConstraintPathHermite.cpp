// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/PathConstraintPathHermite.h"

#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Constraints/PathConstraintPath.h>
#include <Jolt/Physics/Constraints/PathConstraintPathHermite.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_DefaultConstruct(void)
{
    using _mrbind_T = JPH::PathConstraintPathHermite;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_PathConstraintPathHermite*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_DefaultConstructArray(size_t num_elems)
{
    return (JPH_PathConstraintPathHermite *)(new JPH::PathConstraintPathHermite[num_elems]);
}

const JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_OffsetPtr(const JPH_PathConstraintPathHermite *ptr, ptrdiff_t i)
{
    return (const JPH_PathConstraintPathHermite *)(((const JPH::PathConstraintPathHermite *)ptr) + i);
}

JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_OffsetMutablePtr(JPH_PathConstraintPathHermite *ptr, ptrdiff_t i)
{
    return (JPH_PathConstraintPathHermite *)(((JPH::PathConstraintPathHermite *)ptr) + i);
}

const JPH_SerializableObject *JPH_PathConstraintPathHermite_UpcastTo_JPH_SerializableObject(const JPH_PathConstraintPathHermite *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::PathConstraintPathHermite *)object)
    ));
}

JPH_SerializableObject *JPH_PathConstraintPathHermite_MutableUpcastTo_JPH_SerializableObject(JPH_PathConstraintPathHermite *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::PathConstraintPathHermite *)object)
    ));
}

const JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_PathConstraintPathHermite *)(static_cast<const JPH::PathConstraintPathHermite *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_PathConstraintPathHermite *)(static_cast<JPH::PathConstraintPathHermite *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_PathConstraintPath *JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(const JPH_PathConstraintPathHermite *object)
{
    return (const JPH_RefTarget_JPH_PathConstraintPath *)(static_cast<const JPH::RefTarget<JPH::PathConstraintPath> *>(
        ((const JPH::PathConstraintPathHermite *)object)
    ));
}

JPH_RefTarget_JPH_PathConstraintPath *JPH_PathConstraintPathHermite_MutableUpcastTo_JPH_RefTarget_JPH_PathConstraintPath(JPH_PathConstraintPathHermite *object)
{
    return (JPH_RefTarget_JPH_PathConstraintPath *)(static_cast<JPH::RefTarget<JPH::PathConstraintPath> *>(
        ((JPH::PathConstraintPathHermite *)object)
    ));
}

const JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_StaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath(const JPH_RefTarget_JPH_PathConstraintPath *object)
{
    return (const JPH_PathConstraintPathHermite *)(static_cast<const JPH::PathConstraintPathHermite *>(
        ((const JPH::RefTarget<JPH::PathConstraintPath> *)object)
    ));
}

JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_MutableStaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath(JPH_RefTarget_JPH_PathConstraintPath *object)
{
    return (JPH_PathConstraintPathHermite *)(static_cast<JPH::PathConstraintPathHermite *>(
        ((JPH::RefTarget<JPH::PathConstraintPath> *)object)
    ));
}

const JPH_PathConstraintPath *JPH_PathConstraintPathHermite_UpcastTo_JPH_PathConstraintPath(const JPH_PathConstraintPathHermite *object)
{
    return (const JPH_PathConstraintPath *)(static_cast<const JPH::PathConstraintPath *>(
        ((const JPH::PathConstraintPathHermite *)object)
    ));
}

JPH_PathConstraintPath *JPH_PathConstraintPathHermite_MutableUpcastTo_JPH_PathConstraintPath(JPH_PathConstraintPathHermite *object)
{
    return (JPH_PathConstraintPath *)(static_cast<JPH::PathConstraintPath *>(
        ((JPH::PathConstraintPathHermite *)object)
    ));
}

const JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_StaticDowncastFrom_JPH_PathConstraintPath(const JPH_PathConstraintPath *object)
{
    return (const JPH_PathConstraintPathHermite *)(static_cast<const JPH::PathConstraintPathHermite *>(
        ((const JPH::PathConstraintPath *)object)
    ));
}

JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_MutableStaticDowncastFrom_JPH_PathConstraintPath(JPH_PathConstraintPath *object)
{
    return (JPH_PathConstraintPathHermite *)(static_cast<JPH::PathConstraintPathHermite *>(
        ((JPH::PathConstraintPath *)object)
    ));
}

JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_PathConstraintPathHermite *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::PathConstraintPathHermite);
    return (JPH_PathConstraintPathHermite *)new JPH::PathConstraintPathHermite(JPH::PathConstraintPathHermite(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::PathConstraintPathHermite) MRBINDC_CLASSARG_COPY(_other, (JPH::PathConstraintPathHermite), JPH::PathConstraintPathHermite) MRBINDC_CLASSARG_MOVE(_other, (JPH::PathConstraintPathHermite), JPH::PathConstraintPathHermite) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::PathConstraintPathHermite) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::PathConstraintPathHermite) MRBINDC_CLASSARG_END(_other, JPH::PathConstraintPathHermite))
    ));
}

void JPH_PathConstraintPathHermite_Destroy(const JPH_PathConstraintPathHermite *_this)
{
    delete ((const JPH::PathConstraintPathHermite *)_this);
}

void JPH_PathConstraintPathHermite_DestroyArray(const JPH_PathConstraintPathHermite *_this)
{
    delete[] ((const JPH::PathConstraintPathHermite *)_this);
}

JPH_PathConstraintPathHermite *JPH_PathConstraintPathHermite_AssignFromAnother(JPH_PathConstraintPathHermite *_this, Jolt_PassBy _other_pass_by, JPH_PathConstraintPathHermite *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::PathConstraintPathHermite);
    return (JPH_PathConstraintPathHermite *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PathConstraintPathHermite *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::PathConstraintPathHermite) MRBINDC_CLASSARG_COPY(_other, (JPH::PathConstraintPathHermite), JPH::PathConstraintPathHermite) MRBINDC_CLASSARG_MOVE(_other, (JPH::PathConstraintPathHermite), JPH::PathConstraintPathHermite) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::PathConstraintPathHermite) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::PathConstraintPathHermite) MRBINDC_CLASSARG_END(_other, JPH::PathConstraintPathHermite))
    ));
}

void *Jolt_new_JPH_PathConstraintPathHermite_size_t(size_t inCount)
{
    return JPH::PathConstraintPathHermite::operator new(
        inCount
    );
}

void Jolt_delete_JPH_PathConstraintPathHermite_void_ptr(void *inPointer)
{
    JPH::PathConstraintPathHermite::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_PathConstraintPathHermite_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PathConstraintPathHermite::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_PathConstraintPathHermite_size_t(size_t inCount)
{
    return JPH::PathConstraintPathHermite::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr(void *inPointer)
{
    JPH::PathConstraintPathHermite::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PathConstraintPathHermite::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_PathConstraintPathHermite_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PathConstraintPathHermite::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_PathConstraintPathHermite_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PathConstraintPathHermite::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_PathConstraintPathHermite_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PathConstraintPathHermite::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PathConstraintPathHermite::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_PathConstraintPathHermite_GetPathMaxFraction(const JPH_PathConstraintPathHermite *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPathHermite *)(_this)).GetPathMaxFraction();
}

float JPH_PathConstraintPathHermite_GetClosestPoint(const JPH_PathConstraintPathHermite *_this, const JPH_Vec3 *inPosition, float inFractionHint)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPathHermite *)(_this)).GetClosestPoint(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        inFractionHint
    );
}

void JPH_PathConstraintPathHermite_GetPointOnPath(const JPH_PathConstraintPathHermite *_this, float inFraction, JPH_Vec3 *outPathPosition, JPH_Vec3 *outPathTangent, JPH_Vec3 *outPathNormal, JPH_Vec3 *outPathBinormal)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPathHermite *)(_this)).GetPointOnPath(
        inFraction,
        ((outPathPosition ? void() : MRBINDC_THROW("Parameter `outPathPosition` can not be null.", void)), *(JPH::Vec3 *)(outPathPosition)),
        ((outPathTangent ? void() : MRBINDC_THROW("Parameter `outPathTangent` can not be null.", void)), *(JPH::Vec3 *)(outPathTangent)),
        ((outPathNormal ? void() : MRBINDC_THROW("Parameter `outPathNormal` can not be null.", void)), *(JPH::Vec3 *)(outPathNormal)),
        ((outPathBinormal ? void() : MRBINDC_THROW("Parameter `outPathBinormal` can not be null.", void)), *(JPH::Vec3 *)(outPathBinormal))
    );
}

void JPH_PathConstraintPathHermite_AddPoint(JPH_PathConstraintPathHermite *_this, const JPH_Vec3 *inPosition, const JPH_Vec3 *inTangent, const JPH_Vec3 *inNormal)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PathConstraintPathHermite *)(_this)).AddPoint(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inTangent ? void() : MRBINDC_THROW("Parameter `inTangent` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTangent)),
        ((inNormal ? void() : MRBINDC_THROW("Parameter `inNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inNormal))
    );
}

void JPH_PathConstraintPathHermite_SetIsLooping(JPH_PathConstraintPathHermite *_this, bool inIsLooping)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PathConstraintPathHermite *)(_this)).SetIsLooping(
        inIsLooping
    );
}

bool JPH_PathConstraintPathHermite_IsLooping(const JPH_PathConstraintPathHermite *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPathHermite *)(_this)).IsLooping();
}

void JPH_PathConstraintPathHermite_DrawPath(const JPH_PathConstraintPathHermite *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inBaseTransform)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPathHermite *)(_this)).DrawPath(
        ((JPH::DebugRenderer *)inRenderer),
        ((inBaseTransform ? void() : MRBINDC_THROW("Parameter `inBaseTransform` can not be null.", void)), *(const JPH::Mat44 *)(inBaseTransform))
    );
}

void JPH_PathConstraintPathHermite_SetEmbedded(const JPH_PathConstraintPathHermite *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPathHermite *)(_this)).SetEmbedded();
}

unsigned int JPH_PathConstraintPathHermite_GetRefCount(const JPH_PathConstraintPathHermite *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPathHermite *)(_this)).GetRefCount();
}

void JPH_PathConstraintPathHermite_AddRef(const JPH_PathConstraintPathHermite *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPathHermite *)(_this)).AddRef();
}

void JPH_PathConstraintPathHermite_Release(const JPH_PathConstraintPathHermite *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPathHermite *)(_this)).Release();
}

int JPH_PathConstraintPathHermite_sInternalGetRefCountOffset(void)
{
    return JPH::PathConstraintPathHermite::sInternalGetRefCountOffset();
}

const JPH_Vec3 *JPH_PathConstraintPathHermite_Point_Get_mPosition(const JPH_PathConstraintPathHermite_Point *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPathHermite::Point *)(_this)).mPosition);
}

JPH_Vec3 *JPH_PathConstraintPathHermite_Point_GetMutable_mPosition(JPH_PathConstraintPathHermite_Point *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PathConstraintPathHermite::Point *)(_this)).mPosition);
}

const JPH_Vec3 *JPH_PathConstraintPathHermite_Point_Get_mTangent(const JPH_PathConstraintPathHermite_Point *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPathHermite::Point *)(_this)).mTangent);
}

JPH_Vec3 *JPH_PathConstraintPathHermite_Point_GetMutable_mTangent(JPH_PathConstraintPathHermite_Point *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PathConstraintPathHermite::Point *)(_this)).mTangent);
}

const JPH_Vec3 *JPH_PathConstraintPathHermite_Point_Get_mNormal(const JPH_PathConstraintPathHermite_Point *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PathConstraintPathHermite::Point *)(_this)).mNormal);
}

JPH_Vec3 *JPH_PathConstraintPathHermite_Point_GetMutable_mNormal(JPH_PathConstraintPathHermite_Point *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PathConstraintPathHermite::Point *)(_this)).mNormal);
}

JPH_PathConstraintPathHermite_Point *JPH_PathConstraintPathHermite_Point_DefaultConstruct(void)
{
    using _mrbind_T = JPH::PathConstraintPathHermite::Point;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_PathConstraintPathHermite_Point*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_PathConstraintPathHermite_Point *JPH_PathConstraintPathHermite_Point_DefaultConstructArray(size_t num_elems)
{
    return (JPH_PathConstraintPathHermite_Point *)(new JPH::PathConstraintPathHermite::Point[num_elems]);
}

JPH_PathConstraintPathHermite_Point *JPH_PathConstraintPathHermite_Point_ConstructFrom(const JPH_Vec3 *mPosition, const JPH_Vec3 *mTangent, const JPH_Vec3 *mNormal)
{
    return (JPH_PathConstraintPathHermite_Point *)new JPH::PathConstraintPathHermite::Point(JPH::PathConstraintPathHermite::Point{
        ((mPosition ? void() : MRBINDC_THROW("Parameter `mPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mPosition)),
        ((mTangent ? void() : MRBINDC_THROW("Parameter `mTangent` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mTangent)),
        ((mNormal ? void() : MRBINDC_THROW("Parameter `mNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mNormal))
    });
}

const JPH_PathConstraintPathHermite_Point *JPH_PathConstraintPathHermite_Point_OffsetPtr(const JPH_PathConstraintPathHermite_Point *ptr, ptrdiff_t i)
{
    return (const JPH_PathConstraintPathHermite_Point *)(((const JPH::PathConstraintPathHermite::Point *)ptr) + i);
}

JPH_PathConstraintPathHermite_Point *JPH_PathConstraintPathHermite_Point_OffsetMutablePtr(JPH_PathConstraintPathHermite_Point *ptr, ptrdiff_t i)
{
    return (JPH_PathConstraintPathHermite_Point *)(((JPH::PathConstraintPathHermite::Point *)ptr) + i);
}

JPH_PathConstraintPathHermite_Point *JPH_PathConstraintPathHermite_Point_ConstructFromAnother(const JPH_PathConstraintPathHermite_Point *_other)
{
    return (JPH_PathConstraintPathHermite_Point *)new JPH::PathConstraintPathHermite::Point(JPH::PathConstraintPathHermite::Point(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::PathConstraintPathHermite::Point(*(JPH::PathConstraintPathHermite::Point *)_other))
    ));
}

void JPH_PathConstraintPathHermite_Point_Destroy(const JPH_PathConstraintPathHermite_Point *_this)
{
    delete ((const JPH::PathConstraintPathHermite::Point *)_this);
}

void JPH_PathConstraintPathHermite_Point_DestroyArray(const JPH_PathConstraintPathHermite_Point *_this)
{
    delete[] ((const JPH::PathConstraintPathHermite::Point *)_this);
}

JPH_PathConstraintPathHermite_Point *JPH_PathConstraintPathHermite_Point_AssignFromAnother(JPH_PathConstraintPathHermite_Point *_this, const JPH_PathConstraintPathHermite_Point *_other)
{
    return (JPH_PathConstraintPathHermite_Point *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PathConstraintPathHermite::Point *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::PathConstraintPathHermite::Point(*(JPH::PathConstraintPathHermite::Point *)_other))
    ));
}

void *Jolt_new_JPH_PathConstraintPathHermite_Point_size_t(size_t inCount)
{
    return JPH::PathConstraintPathHermite::Point::operator new(
        inCount
    );
}

void Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr(void *inPointer)
{
    JPH::PathConstraintPathHermite::Point::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PathConstraintPathHermite::Point::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_PathConstraintPathHermite_Point_size_t(size_t inCount)
{
    return JPH::PathConstraintPathHermite::Point::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr(void *inPointer)
{
    JPH::PathConstraintPathHermite::Point::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PathConstraintPathHermite::Point::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_PathConstraintPathHermite_Point_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PathConstraintPathHermite::Point::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PathConstraintPathHermite::Point::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_PathConstraintPathHermite_Point_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PathConstraintPathHermite::Point::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PathConstraintPathHermite::Point::operator delete[](
        inPointer,
        inPlace
    );
}

