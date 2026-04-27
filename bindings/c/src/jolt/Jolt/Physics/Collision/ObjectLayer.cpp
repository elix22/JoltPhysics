// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/ObjectLayer.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Physics/Collision/ObjectLayer.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


JPH_ObjectLayerFilter *JPH_ObjectLayerFilter_DefaultConstruct(void)
{
    return (JPH_ObjectLayerFilter *)new JPH::ObjectLayerFilter(JPH::ObjectLayerFilter());
}

JPH_ObjectLayerFilter *JPH_ObjectLayerFilter_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ObjectLayerFilter *)(new JPH::ObjectLayerFilter[num_elems]{});
}

const JPH_ObjectLayerFilter *JPH_ObjectLayerFilter_OffsetPtr(const JPH_ObjectLayerFilter *ptr, ptrdiff_t i)
{
    return (const JPH_ObjectLayerFilter *)(((const JPH::ObjectLayerFilter *)ptr) + i);
}

JPH_ObjectLayerFilter *JPH_ObjectLayerFilter_OffsetMutablePtr(JPH_ObjectLayerFilter *ptr, ptrdiff_t i)
{
    return (JPH_ObjectLayerFilter *)(((JPH::ObjectLayerFilter *)ptr) + i);
}

const JPH_NonCopyable *JPH_ObjectLayerFilter_UpcastTo_JPH_NonCopyable(const JPH_ObjectLayerFilter *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::ObjectLayerFilter *)object)
    ));
}

JPH_NonCopyable *JPH_ObjectLayerFilter_MutableUpcastTo_JPH_NonCopyable(JPH_ObjectLayerFilter *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::ObjectLayerFilter *)object)
    ));
}

const JPH_ObjectLayerFilter *JPH_ObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_ObjectLayerFilter *)(static_cast<const JPH::ObjectLayerFilter *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_ObjectLayerFilter *JPH_ObjectLayerFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_ObjectLayerFilter *)(static_cast<JPH::ObjectLayerFilter *>(
        ((JPH::NonCopyable *)object)
    ));
}

void JPH_ObjectLayerFilter_Destroy(const JPH_ObjectLayerFilter *_this)
{
    delete ((const JPH::ObjectLayerFilter *)_this);
}

void JPH_ObjectLayerFilter_DestroyArray(const JPH_ObjectLayerFilter *_this)
{
    delete[] ((const JPH::ObjectLayerFilter *)_this);
}

bool JPH_ObjectLayerFilter_ShouldCollide(const JPH_ObjectLayerFilter *_this, unsigned short inLayer)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ObjectLayerFilter *)(_this)).ShouldCollide(
        inLayer
    );
}

JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilter_DefaultConstruct(void)
{
    return (JPH_ObjectLayerPairFilter *)new JPH::ObjectLayerPairFilter(JPH::ObjectLayerPairFilter());
}

JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilter_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ObjectLayerPairFilter *)(new JPH::ObjectLayerPairFilter[num_elems]{});
}

const JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilter_OffsetPtr(const JPH_ObjectLayerPairFilter *ptr, ptrdiff_t i)
{
    return (const JPH_ObjectLayerPairFilter *)(((const JPH::ObjectLayerPairFilter *)ptr) + i);
}

JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilter_OffsetMutablePtr(JPH_ObjectLayerPairFilter *ptr, ptrdiff_t i)
{
    return (JPH_ObjectLayerPairFilter *)(((JPH::ObjectLayerPairFilter *)ptr) + i);
}

const JPH_NonCopyable *JPH_ObjectLayerPairFilter_UpcastTo_JPH_NonCopyable(const JPH_ObjectLayerPairFilter *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::ObjectLayerPairFilter *)object)
    ));
}

JPH_NonCopyable *JPH_ObjectLayerPairFilter_MutableUpcastTo_JPH_NonCopyable(JPH_ObjectLayerPairFilter *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::ObjectLayerPairFilter *)object)
    ));
}

const JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_ObjectLayerPairFilter *)(static_cast<const JPH::ObjectLayerPairFilter *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_ObjectLayerPairFilter *JPH_ObjectLayerPairFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_ObjectLayerPairFilter *)(static_cast<JPH::ObjectLayerPairFilter *>(
        ((JPH::NonCopyable *)object)
    ));
}

void JPH_ObjectLayerPairFilter_Destroy(const JPH_ObjectLayerPairFilter *_this)
{
    delete ((const JPH::ObjectLayerPairFilter *)_this);
}

void JPH_ObjectLayerPairFilter_DestroyArray(const JPH_ObjectLayerPairFilter *_this)
{
    delete[] ((const JPH::ObjectLayerPairFilter *)_this);
}

bool JPH_ObjectLayerPairFilter_ShouldCollide(const JPH_ObjectLayerPairFilter *_this, unsigned short inLayer1, unsigned short inLayer2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ObjectLayerPairFilter *)(_this)).ShouldCollide(
        inLayer1,
        inLayer2
    );
}

JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_ConstructFromAnother(Jolt_PassBy inRHS_pass_by, JPH_DefaultObjectLayerFilter *inRHS)
{
    MRBINDC_CLASSARG_GUARD(inRHS, JPH::DefaultObjectLayerFilter);
    return (JPH_DefaultObjectLayerFilter *)new JPH::DefaultObjectLayerFilter(JPH::DefaultObjectLayerFilter(
        (MRBINDC_CLASSARG_COPY(inRHS, (JPH::DefaultObjectLayerFilter), JPH::DefaultObjectLayerFilter) MRBINDC_CLASSARG_NO_DEF_ARG(inRHS, Jolt_PassBy_DefaultArgument, JPH::DefaultObjectLayerFilter) MRBINDC_CLASSARG_NO_DEF_ARG(inRHS, Jolt_PassBy_NoObject, JPH::DefaultObjectLayerFilter) MRBINDC_CLASSARG_END(inRHS, JPH::DefaultObjectLayerFilter))
    ));
}

const JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_OffsetPtr(const JPH_DefaultObjectLayerFilter *ptr, ptrdiff_t i)
{
    return (const JPH_DefaultObjectLayerFilter *)(((const JPH::DefaultObjectLayerFilter *)ptr) + i);
}

JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_OffsetMutablePtr(JPH_DefaultObjectLayerFilter *ptr, ptrdiff_t i)
{
    return (JPH_DefaultObjectLayerFilter *)(((JPH::DefaultObjectLayerFilter *)ptr) + i);
}

const JPH_NonCopyable *JPH_DefaultObjectLayerFilter_UpcastTo_JPH_NonCopyable(const JPH_DefaultObjectLayerFilter *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::DefaultObjectLayerFilter *)object)
    ));
}

JPH_NonCopyable *JPH_DefaultObjectLayerFilter_MutableUpcastTo_JPH_NonCopyable(JPH_DefaultObjectLayerFilter *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::DefaultObjectLayerFilter *)object)
    ));
}

const JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_DefaultObjectLayerFilter *)(static_cast<const JPH::DefaultObjectLayerFilter *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_DefaultObjectLayerFilter *)(static_cast<JPH::DefaultObjectLayerFilter *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_ObjectLayerFilter *JPH_DefaultObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter(const JPH_DefaultObjectLayerFilter *object)
{
    return (const JPH_ObjectLayerFilter *)(static_cast<const JPH::ObjectLayerFilter *>(
        ((const JPH::DefaultObjectLayerFilter *)object)
    ));
}

JPH_ObjectLayerFilter *JPH_DefaultObjectLayerFilter_MutableUpcastTo_JPH_ObjectLayerFilter(JPH_DefaultObjectLayerFilter *object)
{
    return (JPH_ObjectLayerFilter *)(static_cast<JPH::ObjectLayerFilter *>(
        ((JPH::DefaultObjectLayerFilter *)object)
    ));
}

const JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter(const JPH_ObjectLayerFilter *object)
{
    return (const JPH_DefaultObjectLayerFilter *)(static_cast<const JPH::DefaultObjectLayerFilter *>(
        ((const JPH::ObjectLayerFilter *)object)
    ));
}

JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_MutableStaticDowncastFrom_JPH_ObjectLayerFilter(JPH_ObjectLayerFilter *object)
{
    return (JPH_DefaultObjectLayerFilter *)(static_cast<JPH::DefaultObjectLayerFilter *>(
        ((JPH::ObjectLayerFilter *)object)
    ));
}

JPH_DefaultObjectLayerFilter *JPH_DefaultObjectLayerFilter_Construct(const JPH_ObjectLayerPairFilter *inObjectLayerPairFilter, unsigned short inLayer)
{
    return (JPH_DefaultObjectLayerFilter *)new JPH::DefaultObjectLayerFilter(JPH::DefaultObjectLayerFilter(
        ((inObjectLayerPairFilter ? void() : MRBINDC_THROW("Parameter `inObjectLayerPairFilter` can not be null.", void)), *(const JPH::ObjectLayerPairFilter *)(inObjectLayerPairFilter)),
        inLayer
    ));
}

void JPH_DefaultObjectLayerFilter_Destroy(const JPH_DefaultObjectLayerFilter *_this)
{
    delete ((const JPH::DefaultObjectLayerFilter *)_this);
}

void JPH_DefaultObjectLayerFilter_DestroyArray(const JPH_DefaultObjectLayerFilter *_this)
{
    delete[] ((const JPH::DefaultObjectLayerFilter *)_this);
}

bool JPH_DefaultObjectLayerFilter_ShouldCollide(const JPH_DefaultObjectLayerFilter *_this, unsigned short inLayer)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DefaultObjectLayerFilter *)(_this)).ShouldCollide(
        inLayer
    );
}

JPH_SpecifiedObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_Construct(unsigned short inLayer)
{
    return (JPH_SpecifiedObjectLayerFilter *)new JPH::SpecifiedObjectLayerFilter(JPH::SpecifiedObjectLayerFilter(
        inLayer
    ));
}

const JPH_SpecifiedObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_OffsetPtr(const JPH_SpecifiedObjectLayerFilter *ptr, ptrdiff_t i)
{
    return (const JPH_SpecifiedObjectLayerFilter *)(((const JPH::SpecifiedObjectLayerFilter *)ptr) + i);
}

JPH_SpecifiedObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_OffsetMutablePtr(JPH_SpecifiedObjectLayerFilter *ptr, ptrdiff_t i)
{
    return (JPH_SpecifiedObjectLayerFilter *)(((JPH::SpecifiedObjectLayerFilter *)ptr) + i);
}

const JPH_NonCopyable *JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_NonCopyable(const JPH_SpecifiedObjectLayerFilter *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::SpecifiedObjectLayerFilter *)object)
    ));
}

JPH_NonCopyable *JPH_SpecifiedObjectLayerFilter_MutableUpcastTo_JPH_NonCopyable(JPH_SpecifiedObjectLayerFilter *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::SpecifiedObjectLayerFilter *)object)
    ));
}

const JPH_SpecifiedObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_SpecifiedObjectLayerFilter *)(static_cast<const JPH::SpecifiedObjectLayerFilter *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_SpecifiedObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_SpecifiedObjectLayerFilter *)(static_cast<JPH::SpecifiedObjectLayerFilter *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_ObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter(const JPH_SpecifiedObjectLayerFilter *object)
{
    return (const JPH_ObjectLayerFilter *)(static_cast<const JPH::ObjectLayerFilter *>(
        ((const JPH::SpecifiedObjectLayerFilter *)object)
    ));
}

JPH_ObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_MutableUpcastTo_JPH_ObjectLayerFilter(JPH_SpecifiedObjectLayerFilter *object)
{
    return (JPH_ObjectLayerFilter *)(static_cast<JPH::ObjectLayerFilter *>(
        ((JPH::SpecifiedObjectLayerFilter *)object)
    ));
}

const JPH_SpecifiedObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter(const JPH_ObjectLayerFilter *object)
{
    return (const JPH_SpecifiedObjectLayerFilter *)(static_cast<const JPH::SpecifiedObjectLayerFilter *>(
        ((const JPH::ObjectLayerFilter *)object)
    ));
}

JPH_SpecifiedObjectLayerFilter *JPH_SpecifiedObjectLayerFilter_MutableStaticDowncastFrom_JPH_ObjectLayerFilter(JPH_ObjectLayerFilter *object)
{
    return (JPH_SpecifiedObjectLayerFilter *)(static_cast<JPH::SpecifiedObjectLayerFilter *>(
        ((JPH::ObjectLayerFilter *)object)
    ));
}

void JPH_SpecifiedObjectLayerFilter_Destroy(const JPH_SpecifiedObjectLayerFilter *_this)
{
    delete ((const JPH::SpecifiedObjectLayerFilter *)_this);
}

void JPH_SpecifiedObjectLayerFilter_DestroyArray(const JPH_SpecifiedObjectLayerFilter *_this)
{
    delete[] ((const JPH::SpecifiedObjectLayerFilter *)_this);
}

bool JPH_SpecifiedObjectLayerFilter_ShouldCollide(const JPH_SpecifiedObjectLayerFilter *_this, unsigned short inLayer)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SpecifiedObjectLayerFilter *)(_this)).ShouldCollide(
        inLayer
    );
}

