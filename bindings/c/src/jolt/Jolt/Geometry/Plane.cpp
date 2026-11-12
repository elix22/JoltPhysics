// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Geometry/Plane.h"

#include <Jolt/Geometry/Plane.h>
#include <Jolt/Math/DVec3.h>
#include <Jolt/Math/Float4.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Math/Vec4.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


JPH_Plane *JPH_Plane_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Plane;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_Plane*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_Plane *JPH_Plane_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Plane *)(new JPH::Plane[num_elems]);
}

const JPH_Plane *JPH_Plane_OffsetPtr(const JPH_Plane *ptr, ptrdiff_t i)
{
    return (const JPH_Plane *)(((const JPH::Plane *)ptr) + i);
}

JPH_Plane *JPH_Plane_OffsetMutablePtr(JPH_Plane *ptr, ptrdiff_t i)
{
    return (JPH_Plane *)(((JPH::Plane *)ptr) + i);
}

JPH_Plane *JPH_Plane_ConstructFromAnother(const JPH_Plane *_other)
{
    return (JPH_Plane *)new JPH::Plane(JPH::Plane(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::Plane(*(JPH::Plane *)_other))
    ));
}

JPH_Plane *JPH_Plane_Construct_1(const JPH_Vec4 *inNormalAndConstant)
{
    return (JPH_Plane *)new JPH::Plane(JPH::Plane(
        ((inNormalAndConstant ? void() : MRBINDC_THROW("Parameter `inNormalAndConstant` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inNormalAndConstant))
    ));
}

JPH_Plane *JPH_Plane_Construct_2(const JPH_Vec3 *inNormal, float inConstant)
{
    return (JPH_Plane *)new JPH::Plane(JPH::Plane(
        ((inNormal ? void() : MRBINDC_THROW("Parameter `inNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inNormal)),
        inConstant
    ));
}

void JPH_Plane_Destroy(const JPH_Plane *_this)
{
    delete ((const JPH::Plane *)_this);
}

void JPH_Plane_DestroyArray(const JPH_Plane *_this)
{
    delete[] ((const JPH::Plane *)_this);
}

JPH_Plane *JPH_Plane_AssignFromAnother(JPH_Plane *_this, const JPH_Plane *_other)
{
    return (JPH_Plane *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Plane *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::Plane(*(JPH::Plane *)_other))
    ));
}

void *Jolt_new_JPH_Plane_size_t(size_t inCount)
{
    return JPH::Plane::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Plane_void_ptr(void *inPointer)
{
    JPH::Plane::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Plane_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Plane::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Plane_size_t(size_t inCount)
{
    return JPH::Plane::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Plane_void_ptr(void *inPointer)
{
    JPH::Plane::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Plane_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Plane::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Plane_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Plane::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Plane_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Plane::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Plane_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Plane::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Plane_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Plane::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_Plane *JPH_Plane_sFromPointAndNormal_JPH_Vec3(const JPH_Vec3 *inPoint, const JPH_Vec3 *inNormal)
{
    return (JPH_Plane *)new JPH::Plane(JPH::Plane::sFromPointAndNormal(
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPoint)),
        ((inNormal ? void() : MRBINDC_THROW("Parameter `inNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inNormal))
    ));
}

JPH_Plane *JPH_Plane_sFromPointAndNormal_JPH_DVec3(const JPH_DVec3 *inPoint, const JPH_Vec3 *inNormal)
{
    return (JPH_Plane *)new JPH::Plane(JPH::Plane::sFromPointAndNormal(
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), *(const JPH::DVec3 *)(inPoint)),
        ((inNormal ? void() : MRBINDC_THROW("Parameter `inNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inNormal))
    ));
}

JPH_Plane *JPH_Plane_sFromPointsCCW(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3)
{
    return (JPH_Plane *)new JPH::Plane(JPH::Plane::sFromPointsCCW(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2)),
        ((inV3 ? void() : MRBINDC_THROW("Parameter `inV3` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV3))
    ));
}

JPH_Vec3 *JPH_Plane_GetNormal(const JPH_Plane *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Plane *)(_this)).GetNormal());
}

void JPH_Plane_SetNormal(JPH_Plane *_this, const JPH_Vec3 *inNormal)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Plane *)(_this)).SetNormal(
        ((inNormal ? void() : MRBINDC_THROW("Parameter `inNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inNormal))
    );
}

float JPH_Plane_GetConstant(const JPH_Plane *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Plane *)(_this)).GetConstant();
}

void JPH_Plane_SetConstant(JPH_Plane *_this, float inConstant)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Plane *)(_this)).SetConstant(
        inConstant
    );
}

void JPH_Plane_StoreFloat4(const JPH_Plane *_this, JPH_Float4 *outV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Plane *)(_this)).StoreFloat4(
        ((JPH::Float4 *)outV)
    );
}

JPH_Plane *JPH_Plane_Offset(const JPH_Plane *_this, float inDistance)
{
    return (JPH_Plane *)new JPH::Plane(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Plane *)(_this)).Offset(
        inDistance
    ));
}

JPH_Plane *JPH_Plane_GetTransformed(const JPH_Plane *_this, const JPH_Mat44 *inTransform)
{
    return (JPH_Plane *)new JPH::Plane(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Plane *)(_this)).GetTransformed(
        ((inTransform ? void() : MRBINDC_THROW("Parameter `inTransform` can not be null.", void)), *(const JPH::Mat44 *)(inTransform))
    ));
}

JPH_Plane *JPH_Plane_Scaled(const JPH_Plane *_this, const JPH_Vec3 *inScale)
{
    return (JPH_Plane *)new JPH::Plane(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Plane *)(_this)).Scaled(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

float JPH_Plane_SignedDistance(const JPH_Plane *_this, const JPH_Vec3 *inPoint)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Plane *)(_this)).SignedDistance(
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPoint))
    );
}

JPH_Vec3 *JPH_Plane_ProjectPointOnPlane(const JPH_Plane *_this, const JPH_Vec3 *inPoint)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Plane *)(_this)).ProjectPointOnPlane(
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPoint))
    ));
}

bool JPH_Plane_sIntersectPlanes(const JPH_Plane *inP1, const JPH_Plane *inP2, const JPH_Plane *inP3, JPH_Vec3 *outPoint)
{
    return JPH::Plane::sIntersectPlanes(
        ((inP1 ? void() : MRBINDC_THROW("Parameter `inP1` can not be null.", void)), *(const JPH::Plane *)(inP1)),
        ((inP2 ? void() : MRBINDC_THROW("Parameter `inP2` can not be null.", void)), *(const JPH::Plane *)(inP2)),
        ((inP3 ? void() : MRBINDC_THROW("Parameter `inP3` can not be null.", void)), *(const JPH::Plane *)(inP3)),
        ((outPoint ? void() : MRBINDC_THROW("Parameter `outPoint` can not be null.", void)), *(JPH::Vec3 *)(outPoint))
    );
}

