// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Geometry/AABox.h"

#include <Jolt/Geometry/AABox.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


JPH_AABox *JPH_AABox_DefaultConstruct(void)
{
    return (JPH_AABox *)new JPH::AABox(JPH::AABox());
}

JPH_AABox *JPH_AABox_DefaultConstructArray(size_t num_elems)
{
    return (JPH_AABox *)(new JPH::AABox[num_elems]{});
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

void *Jolt_new_JPH_AABox_size_t(unsigned long inCount)
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

void Jolt_delete_JPH_AABox_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::AABox::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_AABox_size_t(unsigned long inCount)
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

void Jolt_delete_array_JPH_AABox_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::AABox::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_AABox_size_t_void_ptr(unsigned long inCount, void *inPointer)
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

void *Jolt_new_array_JPH_AABox_size_t_void_ptr(unsigned long inCount, void *inPointer)
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

bool JPH_AABox_Overlaps_JPH_AABox(const JPH_AABox *_this, const JPH_AABox *inOther)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::AABox *)(_this)).Overlaps(
        ((inOther ? void() : MRBINDC_THROW("Parameter `inOther` can not be null.", void)), *(const JPH::AABox *)(inOther))
    );
}

