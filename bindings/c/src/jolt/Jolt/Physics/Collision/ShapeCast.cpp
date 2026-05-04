// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/ShapeCast.h"

#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Collision/ActiveEdgeMode.h>
#include <Jolt/Physics/Collision/BackFaceMode.h>
#include <Jolt/Physics/Collision/CollectFacesMode.h>
#include <Jolt/Physics/Collision/CollideShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/ShapeCast.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Shape *const *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mShape(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this)
{
    return (const JPH_Shape *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)(_this)).mShape);
}

void JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Set_mShape(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this, const JPH_Shape *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)(_this)).mShape = ((const JPH::Shape *)value);
}

const JPH_Shape **JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_GetMutable_mShape(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this)
{
    return (const JPH_Shape **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)(_this)).mShape);
}

const JPH_Vec3 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mScale(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)(_this)).mScale);
}

const JPH_Mat44 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mCenterOfMassStart(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this)
{
    return (const JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)(_this)).mCenterOfMassStart);
}

const JPH_Vec3 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mDirection(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)(_this)).mDirection);
}

const JPH_AABox *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mShapeWorldBounds(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this)
{
    return (const JPH_AABox *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)(_this)).mShapeWorldBounds);
}

JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_ConstructFromAnother(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_other)
{
    return (JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *)new JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>(JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>(*(JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)_other))
    ));
}

const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_OffsetPtr(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *ptr, ptrdiff_t i)
{
    return (const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *)(((const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)ptr) + i);
}

JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_OffsetMutablePtr(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *ptr, ptrdiff_t i)
{
    return (JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *)(((JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)ptr) + i);
}

JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_5(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection, const JPH_AABox *inWorldSpaceBounds)
{
    return (JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *)new JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>(JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>(
        ((const JPH::Shape *)inShape),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inCenterOfMassStart ? void() : MRBINDC_THROW("Parameter `inCenterOfMassStart` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassStart)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection)),
        ((inWorldSpaceBounds ? void() : MRBINDC_THROW("Parameter `inWorldSpaceBounds` can not be null.", void)), *(const JPH::AABox *)(inWorldSpaceBounds))
    ));
}

JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_4(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection)
{
    return (JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *)new JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>(JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>(
        ((const JPH::Shape *)inShape),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inCenterOfMassStart ? void() : MRBINDC_THROW("Parameter `inCenterOfMassStart` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassStart)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    ));
}

void JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Destroy(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this)
{
    delete ((const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)_this);
}

void JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_DestroyArray(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this)
{
    delete[] ((const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)_this);
}

void *Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t(size_t inCount)
{
    return JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr(void *inPointer)
{
    JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t(size_t inCount)
{
    return JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr(void *inPointer)
{
    JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_sFromWorldTransform(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inWorldTransform, const JPH_Vec3 *inDirection)
{
    return (JPH_ShapeCast *)new JPH::ShapeCast(JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::sFromWorldTransform(
        ((const JPH::Shape *)inShape),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inWorldTransform ? void() : MRBINDC_THROW("Parameter `inWorldTransform` can not be null.", void)), *(const JPH::Mat44 *)(inWorldTransform)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    ));
}

JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_PostTransformed(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this, const JPH_Mat44 *inTransform)
{
    return (JPH_ShapeCast *)new JPH::ShapeCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)(_this)).PostTransformed(
        ((inTransform ? void() : MRBINDC_THROW("Parameter `inTransform` can not be null.", void)), *(const JPH::Mat44 *)(inTransform))
    ));
}

JPH_ShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_PostTranslated(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this, const JPH_Vec3 *inTranslation)
{
    return (JPH_ShapeCast *)new JPH::ShapeCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)(_this)).PostTranslated(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTranslation))
    ));
}

JPH_Vec3 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_GetPointOnRay(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *_this, float inFraction)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)(_this)).GetPointOnRay(
        inFraction
    ));
}

const JPH_Shape *const *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mShape(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this)
{
    return (const JPH_Shape *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)(_this)).mShape);
}

void JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Set_mShape(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this, const JPH_Shape *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)(_this)).mShape = ((const JPH::Shape *)value);
}

const JPH_Shape **JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_GetMutable_mShape(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this)
{
    return (const JPH_Shape **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)(_this)).mShape);
}

const JPH_Vec3 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mScale(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)(_this)).mScale);
}

const JPH_Mat44 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mCenterOfMassStart(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this)
{
    return (const JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)(_this)).mCenterOfMassStart);
}

const JPH_Vec3 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mDirection(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)(_this)).mDirection);
}

const JPH_AABox *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mShapeWorldBounds(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this)
{
    return (const JPH_AABox *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)(_this)).mShapeWorldBounds);
}

JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_ConstructFromAnother(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_other)
{
    return (JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *)new JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>(JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>(*(JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)_other))
    ));
}

const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_OffsetPtr(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *ptr, ptrdiff_t i)
{
    return (const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *)(((const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)ptr) + i);
}

JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_OffsetMutablePtr(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *ptr, ptrdiff_t i)
{
    return (JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *)(((JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)ptr) + i);
}

JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_5(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection, const JPH_AABox *inWorldSpaceBounds)
{
    return (JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *)new JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>(JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>(
        ((const JPH::Shape *)inShape),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inCenterOfMassStart ? void() : MRBINDC_THROW("Parameter `inCenterOfMassStart` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassStart)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection)),
        ((inWorldSpaceBounds ? void() : MRBINDC_THROW("Parameter `inWorldSpaceBounds` can not be null.", void)), *(const JPH::AABox *)(inWorldSpaceBounds))
    ));
}

JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_4(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection)
{
    return (JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *)new JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>(JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>(
        ((const JPH::Shape *)inShape),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inCenterOfMassStart ? void() : MRBINDC_THROW("Parameter `inCenterOfMassStart` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassStart)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    ));
}

void JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Destroy(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this)
{
    delete ((const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)_this);
}

void JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_DestroyArray(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this)
{
    delete[] ((const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)_this);
}

void *Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t(size_t inCount)
{
    return JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr(void *inPointer)
{
    JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t(size_t inCount)
{
    return JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr(void *inPointer)
{
    JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_sFromWorldTransform(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inWorldTransform, const JPH_Vec3 *inDirection)
{
    return (JPH_RShapeCast *)new JPH::RShapeCast(JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::sFromWorldTransform(
        ((const JPH::Shape *)inShape),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inWorldTransform ? void() : MRBINDC_THROW("Parameter `inWorldTransform` can not be null.", void)), *(const JPH::Mat44 *)(inWorldTransform)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    ));
}

JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_PostTransformed(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this, const JPH_Mat44 *inTransform)
{
    return (JPH_RShapeCast *)new JPH::RShapeCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)(_this)).PostTransformed(
        ((inTransform ? void() : MRBINDC_THROW("Parameter `inTransform` can not be null.", void)), *(const JPH::Mat44 *)(inTransform))
    ));
}

JPH_RShapeCast *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_PostTranslated(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this, const JPH_Vec3 *inTranslation)
{
    return (JPH_RShapeCast *)new JPH::RShapeCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)(_this)).PostTranslated(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTranslation))
    ));
}

JPH_Vec3 *JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_GetPointOnRay(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *_this, float inFraction)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)(_this)).GetPointOnRay(
        inFraction
    ));
}

const JPH_Shape *const *JPH_ShapeCast_Get_mShape(const JPH_ShapeCast *_this)
{
    return (const JPH_Shape *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCast *)(_this)).mShape);
}

void JPH_ShapeCast_Set_mShape(JPH_ShapeCast *_this, const JPH_Shape *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCast *)(_this)).mShape = ((const JPH::Shape *)value);
}

const JPH_Shape **JPH_ShapeCast_GetMutable_mShape(JPH_ShapeCast *_this)
{
    return (const JPH_Shape **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCast *)(_this)).mShape);
}

const JPH_Vec3 *JPH_ShapeCast_Get_mScale(const JPH_ShapeCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCast *)(_this)).mScale);
}

const JPH_Mat44 *JPH_ShapeCast_Get_mCenterOfMassStart(const JPH_ShapeCast *_this)
{
    return (const JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCast *)(_this)).mCenterOfMassStart);
}

const JPH_Vec3 *JPH_ShapeCast_Get_mDirection(const JPH_ShapeCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCast *)(_this)).mDirection);
}

const JPH_AABox *JPH_ShapeCast_Get_mShapeWorldBounds(const JPH_ShapeCast *_this)
{
    return (const JPH_AABox *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCast *)(_this)).mShapeWorldBounds);
}

JPH_ShapeCast *JPH_ShapeCast_ConstructFromAnother(const JPH_ShapeCast *_other)
{
    return (JPH_ShapeCast *)new JPH::ShapeCast(JPH::ShapeCast(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::ShapeCast(*(JPH::ShapeCast *)_other))
    ));
}

const JPH_ShapeCast *JPH_ShapeCast_OffsetPtr(const JPH_ShapeCast *ptr, ptrdiff_t i)
{
    return (const JPH_ShapeCast *)(((const JPH::ShapeCast *)ptr) + i);
}

JPH_ShapeCast *JPH_ShapeCast_OffsetMutablePtr(JPH_ShapeCast *ptr, ptrdiff_t i)
{
    return (JPH_ShapeCast *)(((JPH::ShapeCast *)ptr) + i);
}

const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *JPH_ShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(const JPH_ShapeCast *object)
{
    return (const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *)(static_cast<const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *>(
        ((const JPH::ShapeCast *)object)
    ));
}

JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *JPH_ShapeCast_MutableUpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(JPH_ShapeCast *object)
{
    return (JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *)(static_cast<JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *>(
        ((JPH::ShapeCast *)object)
    ));
}

const JPH_ShapeCast *JPH_ShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *object)
{
    return (const JPH_ShapeCast *)(static_cast<const JPH::ShapeCast *>(
        ((const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)object)
    ));
}

JPH_ShapeCast *JPH_ShapeCast_MutableStaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast *object)
{
    return (JPH_ShapeCast *)(static_cast<JPH::ShapeCast *>(
        ((JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast> *)object)
    ));
}

JPH_ShapeCast *JPH_ShapeCast_Construct_5(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection, const JPH_AABox *inWorldSpaceBounds)
{
    return (JPH_ShapeCast *)new JPH::ShapeCast(JPH::ShapeCast(
        ((const JPH::Shape *)inShape),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inCenterOfMassStart ? void() : MRBINDC_THROW("Parameter `inCenterOfMassStart` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassStart)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection)),
        ((inWorldSpaceBounds ? void() : MRBINDC_THROW("Parameter `inWorldSpaceBounds` can not be null.", void)), *(const JPH::AABox *)(inWorldSpaceBounds))
    ));
}

JPH_ShapeCast *JPH_ShapeCast_Construct_4(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection)
{
    return (JPH_ShapeCast *)new JPH::ShapeCast(JPH::ShapeCast(
        ((const JPH::Shape *)inShape),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inCenterOfMassStart ? void() : MRBINDC_THROW("Parameter `inCenterOfMassStart` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassStart)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    ));
}

void JPH_ShapeCast_Destroy(const JPH_ShapeCast *_this)
{
    delete ((const JPH::ShapeCast *)_this);
}

void JPH_ShapeCast_DestroyArray(const JPH_ShapeCast *_this)
{
    delete[] ((const JPH::ShapeCast *)_this);
}

JPH_ShapeCast *JPH_ShapeCast_sFromWorldTransform(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inWorldTransform, const JPH_Vec3 *inDirection)
{
    return (JPH_ShapeCast *)new JPH::ShapeCast(JPH::ShapeCast::sFromWorldTransform(
        ((const JPH::Shape *)inShape),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inWorldTransform ? void() : MRBINDC_THROW("Parameter `inWorldTransform` can not be null.", void)), *(const JPH::Mat44 *)(inWorldTransform)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    ));
}

JPH_ShapeCast *JPH_ShapeCast_PostTransformed(const JPH_ShapeCast *_this, const JPH_Mat44 *inTransform)
{
    return (JPH_ShapeCast *)new JPH::ShapeCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCast *)(_this)).PostTransformed(
        ((inTransform ? void() : MRBINDC_THROW("Parameter `inTransform` can not be null.", void)), *(const JPH::Mat44 *)(inTransform))
    ));
}

JPH_ShapeCast *JPH_ShapeCast_PostTranslated(const JPH_ShapeCast *_this, const JPH_Vec3 *inTranslation)
{
    return (JPH_ShapeCast *)new JPH::ShapeCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCast *)(_this)).PostTranslated(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTranslation))
    ));
}

JPH_Vec3 *JPH_ShapeCast_GetPointOnRay(const JPH_ShapeCast *_this, float inFraction)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCast *)(_this)).GetPointOnRay(
        inFraction
    ));
}

const JPH_Shape *const *JPH_RShapeCast_Get_mShape(const JPH_RShapeCast *_this)
{
    return (const JPH_Shape *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RShapeCast *)(_this)).mShape);
}

void JPH_RShapeCast_Set_mShape(JPH_RShapeCast *_this, const JPH_Shape *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RShapeCast *)(_this)).mShape = ((const JPH::Shape *)value);
}

const JPH_Shape **JPH_RShapeCast_GetMutable_mShape(JPH_RShapeCast *_this)
{
    return (const JPH_Shape **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RShapeCast *)(_this)).mShape);
}

const JPH_Vec3 *JPH_RShapeCast_Get_mScale(const JPH_RShapeCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RShapeCast *)(_this)).mScale);
}

const JPH_Mat44 *JPH_RShapeCast_Get_mCenterOfMassStart(const JPH_RShapeCast *_this)
{
    return (const JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RShapeCast *)(_this)).mCenterOfMassStart);
}

const JPH_Vec3 *JPH_RShapeCast_Get_mDirection(const JPH_RShapeCast *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RShapeCast *)(_this)).mDirection);
}

const JPH_AABox *JPH_RShapeCast_Get_mShapeWorldBounds(const JPH_RShapeCast *_this)
{
    return (const JPH_AABox *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RShapeCast *)(_this)).mShapeWorldBounds);
}

JPH_RShapeCast *JPH_RShapeCast_ConstructFromAnother(const JPH_RShapeCast *_other)
{
    return (JPH_RShapeCast *)new JPH::RShapeCast(JPH::RShapeCast(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::RShapeCast(*(JPH::RShapeCast *)_other))
    ));
}

const JPH_RShapeCast *JPH_RShapeCast_OffsetPtr(const JPH_RShapeCast *ptr, ptrdiff_t i)
{
    return (const JPH_RShapeCast *)(((const JPH::RShapeCast *)ptr) + i);
}

JPH_RShapeCast *JPH_RShapeCast_OffsetMutablePtr(JPH_RShapeCast *ptr, ptrdiff_t i)
{
    return (JPH_RShapeCast *)(((JPH::RShapeCast *)ptr) + i);
}

const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *JPH_RShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(const JPH_RShapeCast *object)
{
    return (const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *)(static_cast<const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *>(
        ((const JPH::RShapeCast *)object)
    ));
}

JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *JPH_RShapeCast_MutableUpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(JPH_RShapeCast *object)
{
    return (JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *)(static_cast<JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *>(
        ((JPH::RShapeCast *)object)
    ));
}

const JPH_RShapeCast *JPH_RShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(const JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *object)
{
    return (const JPH_RShapeCast *)(static_cast<const JPH::RShapeCast *>(
        ((const JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)object)
    ));
}

JPH_RShapeCast *JPH_RShapeCast_MutableStaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast *object)
{
    return (JPH_RShapeCast *)(static_cast<JPH::RShapeCast *>(
        ((JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast> *)object)
    ));
}

JPH_RShapeCast *JPH_RShapeCast_Construct_5(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection, const JPH_AABox *inWorldSpaceBounds)
{
    return (JPH_RShapeCast *)new JPH::RShapeCast(JPH::RShapeCast(
        ((const JPH::Shape *)inShape),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inCenterOfMassStart ? void() : MRBINDC_THROW("Parameter `inCenterOfMassStart` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassStart)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection)),
        ((inWorldSpaceBounds ? void() : MRBINDC_THROW("Parameter `inWorldSpaceBounds` can not be null.", void)), *(const JPH::AABox *)(inWorldSpaceBounds))
    ));
}

JPH_RShapeCast *JPH_RShapeCast_Construct_4(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inCenterOfMassStart, const JPH_Vec3 *inDirection)
{
    return (JPH_RShapeCast *)new JPH::RShapeCast(JPH::RShapeCast(
        ((const JPH::Shape *)inShape),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inCenterOfMassStart ? void() : MRBINDC_THROW("Parameter `inCenterOfMassStart` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassStart)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    ));
}

JPH_RShapeCast *JPH_RShapeCast_Construct_1(const JPH_ShapeCast *inCast)
{
    return (JPH_RShapeCast *)new JPH::RShapeCast(JPH::RShapeCast(
        ((inCast ? void() : MRBINDC_THROW("Parameter `inCast` can not be null.", void)), *(const JPH::ShapeCast *)(inCast))
    ));
}

void JPH_RShapeCast_Destroy(const JPH_RShapeCast *_this)
{
    delete ((const JPH::RShapeCast *)_this);
}

void JPH_RShapeCast_DestroyArray(const JPH_RShapeCast *_this)
{
    delete[] ((const JPH::RShapeCast *)_this);
}

JPH_ShapeCast *JPH_RShapeCast_ConvertTo_JPH_ShapeCast(const JPH_RShapeCast *_this)
{
    return (JPH_ShapeCast *)new JPH::ShapeCast((JPH::ShapeCast)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RShapeCast *)(_this))));
}

JPH_RShapeCast *JPH_RShapeCast_sFromWorldTransform(const JPH_Shape *inShape, const JPH_Vec3 *inScale, const JPH_Mat44 *inWorldTransform, const JPH_Vec3 *inDirection)
{
    return (JPH_RShapeCast *)new JPH::RShapeCast(JPH::RShapeCast::sFromWorldTransform(
        ((const JPH::Shape *)inShape),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale)),
        ((inWorldTransform ? void() : MRBINDC_THROW("Parameter `inWorldTransform` can not be null.", void)), *(const JPH::Mat44 *)(inWorldTransform)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    ));
}

JPH_RShapeCast *JPH_RShapeCast_PostTransformed(const JPH_RShapeCast *_this, const JPH_Mat44 *inTransform)
{
    return (JPH_RShapeCast *)new JPH::RShapeCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RShapeCast *)(_this)).PostTransformed(
        ((inTransform ? void() : MRBINDC_THROW("Parameter `inTransform` can not be null.", void)), *(const JPH::Mat44 *)(inTransform))
    ));
}

JPH_RShapeCast *JPH_RShapeCast_PostTranslated(const JPH_RShapeCast *_this, const JPH_Vec3 *inTranslation)
{
    return (JPH_RShapeCast *)new JPH::RShapeCast(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RShapeCast *)(_this)).PostTranslated(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTranslation))
    ));
}

JPH_Vec3 *JPH_RShapeCast_GetPointOnRay(const JPH_RShapeCast *_this, float inFraction)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RShapeCast *)(_this)).GetPointOnRay(
        inFraction
    ));
}

const JPH_EBackFaceMode *JPH_ShapeCastSettings_Get_mBackFaceModeTriangles(const JPH_ShapeCastSettings *_this)
{
    return (const JPH_EBackFaceMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastSettings *)(_this)).mBackFaceModeTriangles);
}

void JPH_ShapeCastSettings_Set_mBackFaceModeTriangles(JPH_ShapeCastSettings *_this, JPH_EBackFaceMode value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mBackFaceModeTriangles = ((JPH::EBackFaceMode)value);
}

JPH_EBackFaceMode *JPH_ShapeCastSettings_GetMutable_mBackFaceModeTriangles(JPH_ShapeCastSettings *_this)
{
    return (JPH_EBackFaceMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mBackFaceModeTriangles);
}

const JPH_EBackFaceMode *JPH_ShapeCastSettings_Get_mBackFaceModeConvex(const JPH_ShapeCastSettings *_this)
{
    return (const JPH_EBackFaceMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastSettings *)(_this)).mBackFaceModeConvex);
}

void JPH_ShapeCastSettings_Set_mBackFaceModeConvex(JPH_ShapeCastSettings *_this, JPH_EBackFaceMode value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mBackFaceModeConvex = ((JPH::EBackFaceMode)value);
}

JPH_EBackFaceMode *JPH_ShapeCastSettings_GetMutable_mBackFaceModeConvex(JPH_ShapeCastSettings *_this)
{
    return (JPH_EBackFaceMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mBackFaceModeConvex);
}

const bool *JPH_ShapeCastSettings_Get_mUseShrunkenShapeAndConvexRadius(const JPH_ShapeCastSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastSettings *)(_this)).mUseShrunkenShapeAndConvexRadius);
}

void JPH_ShapeCastSettings_Set_mUseShrunkenShapeAndConvexRadius(JPH_ShapeCastSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mUseShrunkenShapeAndConvexRadius = value;
}

bool *JPH_ShapeCastSettings_GetMutable_mUseShrunkenShapeAndConvexRadius(JPH_ShapeCastSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mUseShrunkenShapeAndConvexRadius);
}

const bool *JPH_ShapeCastSettings_Get_mReturnDeepestPoint(const JPH_ShapeCastSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastSettings *)(_this)).mReturnDeepestPoint);
}

void JPH_ShapeCastSettings_Set_mReturnDeepestPoint(JPH_ShapeCastSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mReturnDeepestPoint = value;
}

bool *JPH_ShapeCastSettings_GetMutable_mReturnDeepestPoint(JPH_ShapeCastSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mReturnDeepestPoint);
}

const JPH_EActiveEdgeMode *JPH_ShapeCastSettings_Get_mActiveEdgeMode(const JPH_ShapeCastSettings *_this)
{
    return (const JPH_EActiveEdgeMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastSettings *)(_this)).mActiveEdgeMode);
}

void JPH_ShapeCastSettings_Set_mActiveEdgeMode(JPH_ShapeCastSettings *_this, JPH_EActiveEdgeMode value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mActiveEdgeMode = ((JPH::EActiveEdgeMode)value);
}

JPH_EActiveEdgeMode *JPH_ShapeCastSettings_GetMutable_mActiveEdgeMode(JPH_ShapeCastSettings *_this)
{
    return (JPH_EActiveEdgeMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mActiveEdgeMode);
}

const JPH_ECollectFacesMode *JPH_ShapeCastSettings_Get_mCollectFacesMode(const JPH_ShapeCastSettings *_this)
{
    return (const JPH_ECollectFacesMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastSettings *)(_this)).mCollectFacesMode);
}

void JPH_ShapeCastSettings_Set_mCollectFacesMode(JPH_ShapeCastSettings *_this, JPH_ECollectFacesMode value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mCollectFacesMode = ((JPH::ECollectFacesMode)value);
}

JPH_ECollectFacesMode *JPH_ShapeCastSettings_GetMutable_mCollectFacesMode(JPH_ShapeCastSettings *_this)
{
    return (JPH_ECollectFacesMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mCollectFacesMode);
}

const float *JPH_ShapeCastSettings_Get_mCollisionTolerance(const JPH_ShapeCastSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastSettings *)(_this)).mCollisionTolerance);
}

void JPH_ShapeCastSettings_Set_mCollisionTolerance(JPH_ShapeCastSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mCollisionTolerance = value;
}

float *JPH_ShapeCastSettings_GetMutable_mCollisionTolerance(JPH_ShapeCastSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mCollisionTolerance);
}

const float *JPH_ShapeCastSettings_Get_mPenetrationTolerance(const JPH_ShapeCastSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastSettings *)(_this)).mPenetrationTolerance);
}

void JPH_ShapeCastSettings_Set_mPenetrationTolerance(JPH_ShapeCastSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mPenetrationTolerance = value;
}

float *JPH_ShapeCastSettings_GetMutable_mPenetrationTolerance(JPH_ShapeCastSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mPenetrationTolerance);
}

const JPH_Vec3 *JPH_ShapeCastSettings_Get_mActiveEdgeMovementDirection(const JPH_ShapeCastSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastSettings *)(_this)).mActiveEdgeMovementDirection);
}

JPH_Vec3 *JPH_ShapeCastSettings_GetMutable_mActiveEdgeMovementDirection(JPH_ShapeCastSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).mActiveEdgeMovementDirection);
}

JPH_ShapeCastSettings *JPH_ShapeCastSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::ShapeCastSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_ShapeCastSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_ShapeCastSettings *JPH_ShapeCastSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ShapeCastSettings *)(new JPH::ShapeCastSettings[num_elems]);
}

const JPH_ShapeCastSettings *JPH_ShapeCastSettings_OffsetPtr(const JPH_ShapeCastSettings *ptr, ptrdiff_t i)
{
    return (const JPH_ShapeCastSettings *)(((const JPH::ShapeCastSettings *)ptr) + i);
}

JPH_ShapeCastSettings *JPH_ShapeCastSettings_OffsetMutablePtr(JPH_ShapeCastSettings *ptr, ptrdiff_t i)
{
    return (JPH_ShapeCastSettings *)(((JPH::ShapeCastSettings *)ptr) + i);
}

const JPH_CollideSettingsBase *JPH_ShapeCastSettings_UpcastTo_JPH_CollideSettingsBase(const JPH_ShapeCastSettings *object)
{
    return (const JPH_CollideSettingsBase *)(static_cast<const JPH::CollideSettingsBase *>(
        ((const JPH::ShapeCastSettings *)object)
    ));
}

JPH_CollideSettingsBase *JPH_ShapeCastSettings_MutableUpcastTo_JPH_CollideSettingsBase(JPH_ShapeCastSettings *object)
{
    return (JPH_CollideSettingsBase *)(static_cast<JPH::CollideSettingsBase *>(
        ((JPH::ShapeCastSettings *)object)
    ));
}

const JPH_ShapeCastSettings *JPH_ShapeCastSettings_StaticDowncastFrom_JPH_CollideSettingsBase(const JPH_CollideSettingsBase *object)
{
    return (const JPH_ShapeCastSettings *)(static_cast<const JPH::ShapeCastSettings *>(
        ((const JPH::CollideSettingsBase *)object)
    ));
}

JPH_ShapeCastSettings *JPH_ShapeCastSettings_MutableStaticDowncastFrom_JPH_CollideSettingsBase(JPH_CollideSettingsBase *object)
{
    return (JPH_ShapeCastSettings *)(static_cast<JPH::ShapeCastSettings *>(
        ((JPH::CollideSettingsBase *)object)
    ));
}

JPH_ShapeCastSettings *JPH_ShapeCastSettings_ConstructFromAnother(const JPH_ShapeCastSettings *_other)
{
    return (JPH_ShapeCastSettings *)new JPH::ShapeCastSettings(JPH::ShapeCastSettings(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::ShapeCastSettings(*(JPH::ShapeCastSettings *)_other))
    ));
}

void JPH_ShapeCastSettings_Destroy(const JPH_ShapeCastSettings *_this)
{
    delete ((const JPH::ShapeCastSettings *)_this);
}

void JPH_ShapeCastSettings_DestroyArray(const JPH_ShapeCastSettings *_this)
{
    delete[] ((const JPH::ShapeCastSettings *)_this);
}

JPH_ShapeCastSettings *JPH_ShapeCastSettings_AssignFromAnother(JPH_ShapeCastSettings *_this, const JPH_ShapeCastSettings *_other)
{
    return (JPH_ShapeCastSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::ShapeCastSettings(*(JPH::ShapeCastSettings *)_other))
    ));
}

void *Jolt_new_JPH_ShapeCastSettings_size_t(size_t inCount)
{
    return JPH::ShapeCastSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ShapeCastSettings_void_ptr(void *inPointer)
{
    JPH::ShapeCastSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ShapeCastSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ShapeCastSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ShapeCastSettings_size_t(size_t inCount)
{
    return JPH::ShapeCastSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ShapeCastSettings_void_ptr(void *inPointer)
{
    JPH::ShapeCastSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ShapeCastSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ShapeCastSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ShapeCastSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ShapeCastSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ShapeCastSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ShapeCastSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ShapeCastSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ShapeCastSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ShapeCastSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ShapeCastSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_ShapeCastSettings_SetBackFaceMode(JPH_ShapeCastSettings *_this, JPH_EBackFaceMode inMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastSettings *)(_this)).SetBackFaceMode(
        ((JPH::EBackFaceMode)inMode)
    );
}

const float *JPH_ShapeCastResult_Get_mFraction(const JPH_ShapeCastResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastResult *)(_this)).mFraction);
}

void JPH_ShapeCastResult_Set_mFraction(JPH_ShapeCastResult *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).mFraction = value;
}

float *JPH_ShapeCastResult_GetMutable_mFraction(JPH_ShapeCastResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).mFraction);
}

const bool *JPH_ShapeCastResult_Get_mIsBackFaceHit(const JPH_ShapeCastResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastResult *)(_this)).mIsBackFaceHit);
}

void JPH_ShapeCastResult_Set_mIsBackFaceHit(JPH_ShapeCastResult *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).mIsBackFaceHit = value;
}

bool *JPH_ShapeCastResult_GetMutable_mIsBackFaceHit(JPH_ShapeCastResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).mIsBackFaceHit);
}

const JPH_Vec3 *JPH_ShapeCastResult_Get_mContactPointOn1(const JPH_ShapeCastResult *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastResult *)(_this)).mContactPointOn1);
}

JPH_Vec3 *JPH_ShapeCastResult_GetMutable_mContactPointOn1(JPH_ShapeCastResult *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).mContactPointOn1);
}

const JPH_Vec3 *JPH_ShapeCastResult_Get_mContactPointOn2(const JPH_ShapeCastResult *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastResult *)(_this)).mContactPointOn2);
}

JPH_Vec3 *JPH_ShapeCastResult_GetMutable_mContactPointOn2(JPH_ShapeCastResult *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).mContactPointOn2);
}

const JPH_Vec3 *JPH_ShapeCastResult_Get_mPenetrationAxis(const JPH_ShapeCastResult *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastResult *)(_this)).mPenetrationAxis);
}

JPH_Vec3 *JPH_ShapeCastResult_GetMutable_mPenetrationAxis(JPH_ShapeCastResult *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).mPenetrationAxis);
}

const float *JPH_ShapeCastResult_Get_mPenetrationDepth(const JPH_ShapeCastResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastResult *)(_this)).mPenetrationDepth);
}

void JPH_ShapeCastResult_Set_mPenetrationDepth(JPH_ShapeCastResult *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).mPenetrationDepth = value;
}

float *JPH_ShapeCastResult_GetMutable_mPenetrationDepth(JPH_ShapeCastResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).mPenetrationDepth);
}

const JPH_SubShapeID *JPH_ShapeCastResult_Get_mSubShapeID1(const JPH_ShapeCastResult *_this)
{
    return (const JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastResult *)(_this)).mSubShapeID1);
}

void JPH_ShapeCastResult_Set_mSubShapeID1(JPH_ShapeCastResult *_this, const JPH_SubShapeID *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).mSubShapeID1 = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)value));
}

JPH_SubShapeID *JPH_ShapeCastResult_GetMutable_mSubShapeID1(JPH_ShapeCastResult *_this)
{
    return (JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).mSubShapeID1);
}

const JPH_SubShapeID *JPH_ShapeCastResult_Get_mSubShapeID2(const JPH_ShapeCastResult *_this)
{
    return (const JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastResult *)(_this)).mSubShapeID2);
}

void JPH_ShapeCastResult_Set_mSubShapeID2(JPH_ShapeCastResult *_this, const JPH_SubShapeID *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).mSubShapeID2 = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)value));
}

JPH_SubShapeID *JPH_ShapeCastResult_GetMutable_mSubShapeID2(JPH_ShapeCastResult *_this)
{
    return (JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).mSubShapeID2);
}

const JPH_BodyID *JPH_ShapeCastResult_Get_mBodyID2(const JPH_ShapeCastResult *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastResult *)(_this)).mBodyID2);
}

void JPH_ShapeCastResult_Set_mBodyID2(JPH_ShapeCastResult *_this, JPH_BodyID value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).mBodyID2 = MRBINDC_BIT_CAST((JPH::BodyID), value);
}

JPH_BodyID *JPH_ShapeCastResult_GetMutable_mBodyID2(JPH_ShapeCastResult *_this)
{
    return (JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).mBodyID2);
}

JPH_ShapeCastResult *JPH_ShapeCastResult_DefaultConstruct(void)
{
    using _mrbind_T = JPH::ShapeCastResult;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_ShapeCastResult*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_ShapeCastResult *JPH_ShapeCastResult_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ShapeCastResult *)(new JPH::ShapeCastResult[num_elems]);
}

const JPH_ShapeCastResult *JPH_ShapeCastResult_OffsetPtr(const JPH_ShapeCastResult *ptr, ptrdiff_t i)
{
    return (const JPH_ShapeCastResult *)(((const JPH::ShapeCastResult *)ptr) + i);
}

JPH_ShapeCastResult *JPH_ShapeCastResult_OffsetMutablePtr(JPH_ShapeCastResult *ptr, ptrdiff_t i)
{
    return (JPH_ShapeCastResult *)(((JPH::ShapeCastResult *)ptr) + i);
}

const JPH_CollideShapeResult *JPH_ShapeCastResult_UpcastTo_JPH_CollideShapeResult(const JPH_ShapeCastResult *object)
{
    return (const JPH_CollideShapeResult *)(static_cast<const JPH::CollideShapeResult *>(
        ((const JPH::ShapeCastResult *)object)
    ));
}

JPH_CollideShapeResult *JPH_ShapeCastResult_MutableUpcastTo_JPH_CollideShapeResult(JPH_ShapeCastResult *object)
{
    return (JPH_CollideShapeResult *)(static_cast<JPH::CollideShapeResult *>(
        ((JPH::ShapeCastResult *)object)
    ));
}

const JPH_ShapeCastResult *JPH_ShapeCastResult_StaticDowncastFrom_JPH_CollideShapeResult(const JPH_CollideShapeResult *object)
{
    return (const JPH_ShapeCastResult *)(static_cast<const JPH::ShapeCastResult *>(
        ((const JPH::CollideShapeResult *)object)
    ));
}

JPH_ShapeCastResult *JPH_ShapeCastResult_MutableStaticDowncastFrom_JPH_CollideShapeResult(JPH_CollideShapeResult *object)
{
    return (JPH_ShapeCastResult *)(static_cast<JPH::ShapeCastResult *>(
        ((JPH::CollideShapeResult *)object)
    ));
}

JPH_ShapeCastResult *JPH_ShapeCastResult_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_ShapeCastResult *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::ShapeCastResult);
    return (JPH_ShapeCastResult *)new JPH::ShapeCastResult(JPH::ShapeCastResult(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::ShapeCastResult) MRBINDC_CLASSARG_COPY(_other, (JPH::ShapeCastResult), JPH::ShapeCastResult) MRBINDC_CLASSARG_MOVE(_other, (JPH::ShapeCastResult), JPH::ShapeCastResult) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::ShapeCastResult) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::ShapeCastResult) MRBINDC_CLASSARG_END(_other, JPH::ShapeCastResult))
    ));
}

JPH_ShapeCastResult *JPH_ShapeCastResult_Construct(float inFraction, const JPH_Vec3 *inContactPoint1, const JPH_Vec3 *inContactPoint2, const JPH_Vec3 *inContactNormalOrPenetrationDepth, bool inBackFaceHit, const JPH_SubShapeID *inSubShapeID1, const JPH_SubShapeID *inSubShapeID2, const JPH_BodyID *inBodyID2)
{
    return (JPH_ShapeCastResult *)new JPH::ShapeCastResult(JPH::ShapeCastResult(
        inFraction,
        ((inContactPoint1 ? void() : MRBINDC_THROW("Parameter `inContactPoint1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactPoint1)),
        ((inContactPoint2 ? void() : MRBINDC_THROW("Parameter `inContactPoint2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactPoint2)),
        ((inContactNormalOrPenetrationDepth ? void() : MRBINDC_THROW("Parameter `inContactNormalOrPenetrationDepth` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactNormalOrPenetrationDepth)),
        inBackFaceHit,
        ((inSubShapeID1 ? void() : MRBINDC_THROW("Parameter `inSubShapeID1` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID1)),
        ((inSubShapeID2 ? void() : MRBINDC_THROW("Parameter `inSubShapeID2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID2)),
        ((inBodyID2 ? void() : MRBINDC_THROW("Parameter `inBodyID2` can not be null.", void)), *(const JPH::BodyID *)(inBodyID2))
    ));
}

void JPH_ShapeCastResult_Destroy(const JPH_ShapeCastResult *_this)
{
    delete ((const JPH::ShapeCastResult *)_this);
}

void JPH_ShapeCastResult_DestroyArray(const JPH_ShapeCastResult *_this)
{
    delete[] ((const JPH::ShapeCastResult *)_this);
}

JPH_ShapeCastResult *JPH_ShapeCastResult_AssignFromAnother(JPH_ShapeCastResult *_this, Jolt_PassBy _other_pass_by, JPH_ShapeCastResult *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::ShapeCastResult);
    return (JPH_ShapeCastResult *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ShapeCastResult *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::ShapeCastResult) MRBINDC_CLASSARG_COPY(_other, (JPH::ShapeCastResult), JPH::ShapeCastResult) MRBINDC_CLASSARG_MOVE(_other, (JPH::ShapeCastResult), JPH::ShapeCastResult) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::ShapeCastResult) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::ShapeCastResult) MRBINDC_CLASSARG_END(_other, JPH::ShapeCastResult))
    ));
}

void *Jolt_new_JPH_ShapeCastResult_size_t(size_t inCount)
{
    return JPH::ShapeCastResult::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ShapeCastResult_void_ptr(void *inPointer)
{
    JPH::ShapeCastResult::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ShapeCastResult_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ShapeCastResult::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ShapeCastResult_size_t(size_t inCount)
{
    return JPH::ShapeCastResult::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ShapeCastResult_void_ptr(void *inPointer)
{
    JPH::ShapeCastResult::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ShapeCastResult_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ShapeCastResult::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ShapeCastResult_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ShapeCastResult::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ShapeCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ShapeCastResult::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ShapeCastResult_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ShapeCastResult::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ShapeCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ShapeCastResult::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_ShapeCastResult_GetEarlyOutFraction(const JPH_ShapeCastResult *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastResult *)(_this)).GetEarlyOutFraction();
}

JPH_ShapeCastResult *JPH_ShapeCastResult_Reversed(const JPH_ShapeCastResult *_this, const JPH_Vec3 *inWorldSpaceCastDirection)
{
    return (JPH_ShapeCastResult *)new JPH::ShapeCastResult(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ShapeCastResult *)(_this)).Reversed(
        ((inWorldSpaceCastDirection ? void() : MRBINDC_THROW("Parameter `inWorldSpaceCastDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inWorldSpaceCastDirection))
    ));
}

