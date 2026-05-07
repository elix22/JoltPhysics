// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Geometry/AABox.h"

#include <Jolt/Geometry/AABox.h>
#include <Jolt/Geometry/Plane.h>
#include <Jolt/Math/DMat44.h>
#include <Jolt/Math/DVec3.h>
#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_AABox_Get_mMin(const JPH_AABox *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).mMin);
}

JPH_Vec3 *JPH_AABox_GetMutable_mMin(JPH_AABox *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::AABox *)(_this)).mMin);
}

const JPH_Vec3 *JPH_AABox_Get_mMax(const JPH_AABox *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).mMax);
}

JPH_Vec3 *JPH_AABox_GetMutable_mMax(JPH_AABox *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::AABox *)(_this)).mMax);
}

JPH_AABox *JPH_AABox_DefaultConstruct(void)
{
    using _mrbind_T = JPH::AABox;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_AABox*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_AABox *JPH_AABox_DefaultConstructArray(size_t num_elems)
{
    return (JPH_AABox *)(new JPH::AABox[num_elems]);
}

const JPH_AABox *JPH_AABox_OffsetPtr(const JPH_AABox *ptr, ptrdiff_t i)
{
    return (const JPH_AABox *)(((const JPH::AABox *)ptr) + i);
}

JPH_AABox *JPH_AABox_OffsetMutablePtr(JPH_AABox *ptr, ptrdiff_t i)
{
    return (JPH_AABox *)(((JPH::AABox *)ptr) + i);
}

JPH_AABox *JPH_AABox_ConstructFromAnother(const JPH_AABox *_other)
{
    return (JPH_AABox *)new JPH::AABox(JPH::AABox(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::AABox(*(JPH::AABox *)_other))
    ));
}

JPH_AABox *JPH_AABox_Construct_const_JPH_Vec3_JPH_Vec3(const JPH_Vec3 *inMin, const JPH_Vec3 *inMax)
{
    return (JPH_AABox *)new JPH::AABox(JPH::AABox(
        ((inMin ? void() : MRBINDC_THROW("Parameter `inMin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inMin)),
        ((inMax ? void() : MRBINDC_THROW("Parameter `inMax` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inMax))
    ));
}

JPH_AABox *JPH_AABox_Construct_const_JPH_DVec3_ref(const JPH_DVec3 *inMin, const JPH_DVec3 *inMax)
{
    return (JPH_AABox *)new JPH::AABox(JPH::AABox(
        ((inMin ? void() : MRBINDC_THROW("Parameter `inMin` can not be null.", void)), *(const JPH::DVec3 *)(inMin)),
        ((inMax ? void() : MRBINDC_THROW("Parameter `inMax` can not be null.", void)), *(const JPH::DVec3 *)(inMax))
    ));
}

JPH_AABox *JPH_AABox_Construct_const_JPH_Vec3_float(const JPH_Vec3 *inCenter, float inRadius)
{
    return (JPH_AABox *)new JPH::AABox(JPH::AABox(
        ((inCenter ? void() : MRBINDC_THROW("Parameter `inCenter` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCenter)),
        inRadius
    ));
}

void JPH_AABox_Destroy(const JPH_AABox *_this)
{
    delete ((const JPH::AABox *)_this);
}

void JPH_AABox_DestroyArray(const JPH_AABox *_this)
{
    delete[] ((const JPH::AABox *)_this);
}

JPH_AABox *JPH_AABox_AssignFromAnother(JPH_AABox *_this, const JPH_AABox *_other)
{
    return (JPH_AABox *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::AABox *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::AABox(*(JPH::AABox *)_other))
    ));
}

void *Jolt_new_JPH_AABox_size_t(size_t inCount)
{
    return JPH::AABox::operator new(
        inCount
    );
}

void Jolt_delete_JPH_AABox_void_ptr(void *inPointer)
{
    JPH::AABox::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_AABox_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::AABox::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_AABox_size_t(size_t inCount)
{
    return JPH::AABox::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_AABox_void_ptr(void *inPointer)
{
    JPH::AABox::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_AABox_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::AABox::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_AABox_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::AABox::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_AABox_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::AABox::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_AABox_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::AABox::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_AABox_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::AABox::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_AABox *JPH_AABox_sFromTwoPoints(const JPH_Vec3 *inP1, const JPH_Vec3 *inP2)
{
    return (JPH_AABox *)new JPH::AABox(JPH::AABox::sFromTwoPoints(
        ((inP1 ? void() : MRBINDC_THROW("Parameter `inP1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inP1)),
        ((inP2 ? void() : MRBINDC_THROW("Parameter `inP2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inP2))
    ));
}

JPH_AABox *JPH_AABox_sBiggest(void)
{
    return (JPH_AABox *)new JPH::AABox(JPH::AABox::sBiggest());
}

bool Jolt_equal_JPH_AABox(const JPH_AABox *_this, const JPH_AABox *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).operator==(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::AABox *)(inRHS))
    );
}

bool Jolt_not_equal_JPH_AABox(const JPH_AABox *_this, const JPH_AABox *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).operator!=(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::AABox *)(inRHS))
    );
}

void JPH_AABox_SetEmpty(JPH_AABox *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::AABox *)(_this)).SetEmpty();
}

bool JPH_AABox_IsValid(const JPH_AABox *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).IsValid();
}

void JPH_AABox_Encapsulate_1_JPH_Vec3(JPH_AABox *_this, const JPH_Vec3 *inPos)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::AABox *)(_this)).Encapsulate(
        ((inPos ? void() : MRBINDC_THROW("Parameter `inPos` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPos))
    );
}

void JPH_AABox_Encapsulate_1_JPH_AABox(JPH_AABox *_this, const JPH_AABox *inRHS)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::AABox *)(_this)).Encapsulate(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::AABox *)(inRHS))
    );
}

JPH_AABox *JPH_AABox_Intersect(const JPH_AABox *_this, const JPH_AABox *inOther)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).Intersect(
        ((inOther ? void() : MRBINDC_THROW("Parameter `inOther` can not be null.", void)), *(const JPH::AABox *)(inOther))
    ));
}

void JPH_AABox_EnsureMinimalEdgeLength(JPH_AABox *_this, float inMinEdgeLength)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::AABox *)(_this)).EnsureMinimalEdgeLength(
        inMinEdgeLength
    );
}

void JPH_AABox_ExpandBy(JPH_AABox *_this, const JPH_Vec3 *inVector)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::AABox *)(_this)).ExpandBy(
        ((inVector ? void() : MRBINDC_THROW("Parameter `inVector` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inVector))
    );
}

JPH_Vec3 *JPH_AABox_GetCenter(const JPH_AABox *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).GetCenter());
}

JPH_Vec3 *JPH_AABox_GetExtent(const JPH_AABox *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).GetExtent());
}

JPH_Vec3 *JPH_AABox_GetSize(const JPH_AABox *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).GetSize());
}

float JPH_AABox_GetSurfaceArea(const JPH_AABox *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).GetSurfaceArea();
}

float JPH_AABox_GetVolume(const JPH_AABox *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).GetVolume();
}

bool JPH_AABox_Contains_JPH_AABox(const JPH_AABox *_this, const JPH_AABox *inOther)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).Contains(
        ((inOther ? void() : MRBINDC_THROW("Parameter `inOther` can not be null.", void)), *(const JPH::AABox *)(inOther))
    );
}

bool JPH_AABox_Contains_JPH_Vec3(const JPH_AABox *_this, const JPH_Vec3 *inOther)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).Contains(
        ((inOther ? void() : MRBINDC_THROW("Parameter `inOther` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOther))
    );
}

bool JPH_AABox_Contains_JPH_DVec3(const JPH_AABox *_this, const JPH_DVec3 *inOther)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).Contains(
        ((inOther ? void() : MRBINDC_THROW("Parameter `inOther` can not be null.", void)), *(const JPH::DVec3 *)(inOther))
    );
}

bool JPH_AABox_Overlaps_JPH_AABox(const JPH_AABox *_this, const JPH_AABox *inOther)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).Overlaps(
        ((inOther ? void() : MRBINDC_THROW("Parameter `inOther` can not be null.", void)), *(const JPH::AABox *)(inOther))
    );
}

bool JPH_AABox_Overlaps_JPH_Plane(const JPH_AABox *_this, const JPH_Plane *inPlane)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).Overlaps(
        ((inPlane ? void() : MRBINDC_THROW("Parameter `inPlane` can not be null.", void)), *(const JPH::Plane *)(inPlane))
    );
}

void JPH_AABox_Translate_JPH_Vec3(JPH_AABox *_this, const JPH_Vec3 *inTranslation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::AABox *)(_this)).Translate(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTranslation))
    );
}

void JPH_AABox_Translate_JPH_DVec3(JPH_AABox *_this, const JPH_DVec3 *inTranslation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::AABox *)(_this)).Translate(
        ((inTranslation ? void() : MRBINDC_THROW("Parameter `inTranslation` can not be null.", void)), *(const JPH::DVec3 *)(inTranslation))
    );
}

JPH_AABox *JPH_AABox_Transformed_JPH_Mat44(const JPH_AABox *_this, const JPH_Mat44 *inMatrix)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).Transformed(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix))
    ));
}

JPH_AABox *JPH_AABox_Transformed_JPH_DMat44(const JPH_AABox *_this, const JPH_DMat44 *inMatrix)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).Transformed(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::DMat44 *)(inMatrix))
    ));
}

JPH_AABox *JPH_AABox_Scaled(const JPH_AABox *_this, const JPH_Vec3 *inScale)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).Scaled(
        ((inScale ? void() : MRBINDC_THROW("Parameter `inScale` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inScale))
    ));
}

JPH_Vec3 *JPH_AABox_GetSupport(const JPH_AABox *_this, const JPH_Vec3 *inDirection)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).GetSupport(
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    ));
}

JPH_Vec3 *JPH_AABox_GetClosestPoint(const JPH_AABox *_this, const JPH_Vec3 *inPoint)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).GetClosestPoint(
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPoint))
    ));
}

float JPH_AABox_GetSqDistanceTo(const JPH_AABox *_this, const JPH_Vec3 *inPoint)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).GetSqDistanceTo(
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPoint))
    );
}

