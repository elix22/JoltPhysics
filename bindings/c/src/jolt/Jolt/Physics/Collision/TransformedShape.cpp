// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/TransformedShape.h"

#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Collision/CastResult.h>
#include <Jolt/Physics/Collision/CollideShape.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/RayCast.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/ShapeCast.h>
#include <Jolt/Physics/Collision/TransformedShape.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_TransformedShape_Get_mShapePositionCOM(const JPH_TransformedShape *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).mShapePositionCOM);
}

JPH_Vec3 *JPH_TransformedShape_GetMutable_mShapePositionCOM(JPH_TransformedShape *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TransformedShape *)(_this)).mShapePositionCOM);
}

const JPH_Quat *JPH_TransformedShape_Get_mShapeRotation(const JPH_TransformedShape *_this)
{
    return (const JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).mShapeRotation);
}

JPH_Quat *JPH_TransformedShape_GetMutable_mShapeRotation(JPH_TransformedShape *_this)
{
    return (JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TransformedShape *)(_this)).mShapeRotation);
}

const JPH_Float3 *JPH_TransformedShape_Get_mShapeScale(const JPH_TransformedShape *_this)
{
    return (const JPH_Float3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).mShapeScale);
}

JPH_Float3 *JPH_TransformedShape_GetMutable_mShapeScale(JPH_TransformedShape *_this)
{
    return (JPH_Float3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TransformedShape *)(_this)).mShapeScale);
}

const JPH_BodyID *JPH_TransformedShape_Get_mBodyID(const JPH_TransformedShape *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).mBodyID);
}

void JPH_TransformedShape_Set_mBodyID(JPH_TransformedShape *_this, JPH_BodyID value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TransformedShape *)(_this)).mBodyID = MRBINDC_BIT_CAST((JPH::BodyID), value);
}

JPH_BodyID *JPH_TransformedShape_GetMutable_mBodyID(JPH_TransformedShape *_this)
{
    return (JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TransformedShape *)(_this)).mBodyID);
}

const JPH_SubShapeIDCreator *JPH_TransformedShape_Get_mSubShapeIDCreator(const JPH_TransformedShape *_this)
{
    return (const JPH_SubShapeIDCreator *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).mSubShapeIDCreator);
}

void JPH_TransformedShape_Set_mSubShapeIDCreator(JPH_TransformedShape *_this, const JPH_SubShapeIDCreator *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TransformedShape *)(_this)).mSubShapeIDCreator = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::SubShapeIDCreator(*(JPH::SubShapeIDCreator *)value));
}

JPH_SubShapeIDCreator *JPH_TransformedShape_GetMutable_mSubShapeIDCreator(JPH_TransformedShape *_this)
{
    return (JPH_SubShapeIDCreator *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TransformedShape *)(_this)).mSubShapeIDCreator);
}

JPH_TransformedShape *JPH_TransformedShape_DefaultConstruct(void)
{
    using _mrbind_T = JPH::TransformedShape;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_TransformedShape*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_TransformedShape *JPH_TransformedShape_DefaultConstructArray(size_t num_elems)
{
    return (JPH_TransformedShape *)(new JPH::TransformedShape[num_elems]{});
}

const JPH_TransformedShape *JPH_TransformedShape_OffsetPtr(const JPH_TransformedShape *ptr, ptrdiff_t i)
{
    return (const JPH_TransformedShape *)(((const JPH::TransformedShape *)ptr) + i);
}

JPH_TransformedShape *JPH_TransformedShape_OffsetMutablePtr(JPH_TransformedShape *ptr, ptrdiff_t i)
{
    return (JPH_TransformedShape *)(((JPH::TransformedShape *)ptr) + i);
}

JPH_TransformedShape *JPH_TransformedShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_TransformedShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::TransformedShape);
    return (JPH_TransformedShape *)new JPH::TransformedShape(JPH::TransformedShape(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::TransformedShape) MRBINDC_CLASSARG_COPY(_other, (JPH::TransformedShape), JPH::TransformedShape) MRBINDC_CLASSARG_MOVE(_other, (JPH::TransformedShape), JPH::TransformedShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::TransformedShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::TransformedShape) MRBINDC_CLASSARG_END(_other, JPH::TransformedShape))
    ));
}

JPH_TransformedShape *JPH_TransformedShape_Construct(const JPH_Vec3 *inPositionCOM, const JPH_Quat *inRotation, const JPH_Shape *inShape, const JPH_BodyID *inBodyID, const JPH_SubShapeIDCreator *inSubShapeIDCreator)
{
    using namespace JPH;
    return (JPH_TransformedShape *)new JPH::TransformedShape(JPH::TransformedShape(
        ((inPositionCOM ? void() : MRBINDC_THROW("Parameter `inPositionCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPositionCOM)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((const JPH::Shape *)inShape),
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        (inSubShapeIDCreator ? *(const JPH::SubShapeIDCreator *)(inSubShapeIDCreator) : static_cast<const JPH::SubShapeIDCreator &>(JPH::SubShapeIDCreator()))
    ));
}

void JPH_TransformedShape_Destroy(const JPH_TransformedShape *_this)
{
    delete ((const JPH::TransformedShape *)_this);
}

void JPH_TransformedShape_DestroyArray(const JPH_TransformedShape *_this)
{
    delete[] ((const JPH::TransformedShape *)_this);
}

JPH_TransformedShape *JPH_TransformedShape_AssignFromAnother(JPH_TransformedShape *_this, Jolt_PassBy _other_pass_by, JPH_TransformedShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::TransformedShape);
    return (JPH_TransformedShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TransformedShape *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::TransformedShape) MRBINDC_CLASSARG_COPY(_other, (JPH::TransformedShape), JPH::TransformedShape) MRBINDC_CLASSARG_MOVE(_other, (JPH::TransformedShape), JPH::TransformedShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::TransformedShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::TransformedShape) MRBINDC_CLASSARG_END(_other, JPH::TransformedShape))
    ));
}

void *Jolt_new_JPH_TransformedShape_size_t(size_t inCount)
{
    return JPH::TransformedShape::operator new(
        inCount
    );
}

void Jolt_delete_JPH_TransformedShape_void_ptr(void *inPointer)
{
    JPH::TransformedShape::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_TransformedShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TransformedShape::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_TransformedShape_size_t(size_t inCount)
{
    return JPH::TransformedShape::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_TransformedShape_void_ptr(void *inPointer)
{
    JPH::TransformedShape::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_TransformedShape_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TransformedShape::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_TransformedShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TransformedShape::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_TransformedShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TransformedShape::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_TransformedShape_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TransformedShape::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_TransformedShape_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TransformedShape::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_TransformedShape_CastRay_2(const JPH_TransformedShape *_this, const JPH_RRayCast *inRay, JPH_RayCastResult *ioHit)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).CastRay(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RRayCast *)(inRay)),
        ((ioHit ? void() : MRBINDC_THROW("Parameter `ioHit` can not be null.", void)), *(JPH::RayCastResult *)(ioHit))
    );
}

void JPH_TransformedShape_GetTrianglesStart(const JPH_TransformedShape *_this, JPH_Shape_GetTrianglesContext *ioContext, const JPH_AABox *inBox, const JPH_Vec3 *inBaseOffset)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).GetTrianglesStart(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inBaseOffset ? void() : MRBINDC_THROW("Parameter `inBaseOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBaseOffset))
    );
}

int JPH_TransformedShape_GetTrianglesNext(const JPH_TransformedShape *_this, JPH_Shape_GetTrianglesContext *ioContext, int inMaxTrianglesRequested, JPH_Float3 *outTriangleVertices, const JPH_PhysicsMaterial **outMaterials)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).GetTrianglesNext(
        ((ioContext ? void() : MRBINDC_THROW("Parameter `ioContext` can not be null.", void)), *(JPH::Shape::GetTrianglesContext *)(ioContext)),
        inMaxTrianglesRequested,
        ((JPH::Float3 *)outTriangleVertices),
        ((const JPH::PhysicsMaterial **)outMaterials)
    );
}

JPH_Vec3 *JPH_TransformedShape_GetShapeScale(const JPH_TransformedShape *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).GetShapeScale());
}

void JPH_TransformedShape_SetShapeScale(JPH_TransformedShape *_this, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TransformedShape *)(_this)).SetShapeScale(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

JPH_Mat44 *JPH_TransformedShape_GetCenterOfMassTransform(const JPH_TransformedShape *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).GetCenterOfMassTransform());
}

JPH_Mat44 *JPH_TransformedShape_GetInverseCenterOfMassTransform(const JPH_TransformedShape *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).GetInverseCenterOfMassTransform());
}

void JPH_TransformedShape_SetWorldTransform_3(JPH_TransformedShape *_this, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const JPH_Vec3 *inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TransformedShape *)(_this)).SetWorldTransform(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    );
}

void JPH_TransformedShape_SetWorldTransform_1(JPH_TransformedShape *_this, const JPH_Mat44 *inTransform)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TransformedShape *)(_this)).SetWorldTransform(
        ((inTransform ? void() : MRBINDC_THROW("Parameter `inTransform` can not be null.", void)), *(const JPH::Mat44 *)(inTransform))
    );
}

JPH_Mat44 *JPH_TransformedShape_GetWorldTransform(const JPH_TransformedShape *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).GetWorldTransform());
}

JPH_AABox *JPH_TransformedShape_GetWorldSpaceBounds(const JPH_TransformedShape *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).GetWorldSpaceBounds());
}

JPH_SubShapeID *JPH_TransformedShape_MakeSubShapeIDRelativeToShape(const JPH_TransformedShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (JPH_SubShapeID *)new JPH::SubShapeID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).MakeSubShapeIDRelativeToShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

JPH_Vec3 *JPH_TransformedShape_GetWorldSpaceSurfaceNormal(const JPH_TransformedShape *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).GetWorldSpaceSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition))
    ));
}

const JPH_PhysicsMaterial *JPH_TransformedShape_GetMaterial(const JPH_TransformedShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).GetMaterial(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

uint64_t JPH_TransformedShape_GetSubShapeUserData(const JPH_TransformedShape *_this, const JPH_SubShapeID *inSubShapeID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).GetSubShapeUserData(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    );
}

JPH_TransformedShape *JPH_TransformedShape_GetSubShapeTransformedShape(const JPH_TransformedShape *_this, const JPH_SubShapeID *inSubShapeID, JPH_SubShapeID *outRemainder)
{
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TransformedShape *)(_this)).GetSubShapeTransformedShape(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((outRemainder ? void() : MRBINDC_THROW("Parameter `outRemainder` can not be null.", void)), *(JPH::SubShapeID *)(outRemainder))
    ));
}

JPH_BodyID JPH_TransformedShape_sGetBodyID(const JPH_TransformedShape *inTS)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), JPH::TransformedShape::sGetBodyID(
        ((const JPH::TransformedShape *)inTS)
    ));
}

