// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


JPH_BroadPhaseLayer *JPH_BroadPhaseLayer_DefaultConstruct(void)
{
    using _mrbind_T = JPH::BroadPhaseLayer;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_BroadPhaseLayer*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_BroadPhaseLayer *JPH_BroadPhaseLayer_DefaultConstructArray(size_t num_elems)
{
    return (JPH_BroadPhaseLayer *)(new JPH::BroadPhaseLayer[num_elems]{});
}

const JPH_BroadPhaseLayer *JPH_BroadPhaseLayer_OffsetPtr(const JPH_BroadPhaseLayer *ptr, ptrdiff_t i)
{
    return (const JPH_BroadPhaseLayer *)(((const JPH::BroadPhaseLayer *)ptr) + i);
}

JPH_BroadPhaseLayer *JPH_BroadPhaseLayer_OffsetMutablePtr(JPH_BroadPhaseLayer *ptr, ptrdiff_t i)
{
    return (JPH_BroadPhaseLayer *)(((JPH::BroadPhaseLayer *)ptr) + i);
}

JPH_BroadPhaseLayer *JPH_BroadPhaseLayer_ConstructFromAnother(const JPH_BroadPhaseLayer *_other)
{
    return (JPH_BroadPhaseLayer *)new JPH::BroadPhaseLayer(JPH::BroadPhaseLayer(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::BroadPhaseLayer(*(JPH::BroadPhaseLayer *)_other))
    ));
}

JPH_BroadPhaseLayer *JPH_BroadPhaseLayer_Construct(unsigned char inValue)
{
    return (JPH_BroadPhaseLayer *)new JPH::BroadPhaseLayer(JPH::BroadPhaseLayer(
        inValue
    ));
}

void JPH_BroadPhaseLayer_Destroy(const JPH_BroadPhaseLayer *_this)
{
    delete ((const JPH::BroadPhaseLayer *)_this);
}

void JPH_BroadPhaseLayer_DestroyArray(const JPH_BroadPhaseLayer *_this)
{
    delete[] ((const JPH::BroadPhaseLayer *)_this);
}

unsigned char JPH_BroadPhaseLayer_ConvertTo_unsigned_char(const JPH_BroadPhaseLayer *_this)
{
    return (unsigned char)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseLayer *)(_this)));
}

JPH_BroadPhaseLayer *JPH_BroadPhaseLayer_AssignFromAnother(JPH_BroadPhaseLayer *_this, const JPH_BroadPhaseLayer *_other)
{
    return (JPH_BroadPhaseLayer *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BroadPhaseLayer *)(_this)).operator=(
        mrbindc_details::unmove(((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::BroadPhaseLayer(*(JPH::BroadPhaseLayer *)_other)))
    ));
}

bool Jolt_equal_JPH_BroadPhaseLayer(const JPH_BroadPhaseLayer *_this, const JPH_BroadPhaseLayer *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseLayer *)(_this)).operator==(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::BroadPhaseLayer *)(inRHS))
    );
}

bool Jolt_not_equal_JPH_BroadPhaseLayer(const JPH_BroadPhaseLayer *_this, const JPH_BroadPhaseLayer *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseLayer *)(_this)).operator!=(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::BroadPhaseLayer *)(inRHS))
    );
}

bool Jolt_less_JPH_BroadPhaseLayer(const JPH_BroadPhaseLayer *_this, const JPH_BroadPhaseLayer *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseLayer *)(_this)).operator<(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::BroadPhaseLayer *)(inRHS))
    );
}

unsigned char JPH_BroadPhaseLayer_GetValue(const JPH_BroadPhaseLayer *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseLayer *)(_this)).GetValue();
}

void JPH_BroadPhaseLayerInterface_Destroy(const JPH_BroadPhaseLayerInterface *_this)
{
    delete ((const JPH::BroadPhaseLayerInterface *)_this);
}

void JPH_BroadPhaseLayerInterface_DestroyArray(const JPH_BroadPhaseLayerInterface *_this)
{
    delete[] ((const JPH::BroadPhaseLayerInterface *)_this);
}

unsigned int JPH_BroadPhaseLayerInterface_GetNumBroadPhaseLayers(const JPH_BroadPhaseLayerInterface *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseLayerInterface *)(_this)).GetNumBroadPhaseLayers();
}

JPH_BroadPhaseLayer *JPH_BroadPhaseLayerInterface_GetBroadPhaseLayer(const JPH_BroadPhaseLayerInterface *_this, unsigned short inLayer)
{
    return (JPH_BroadPhaseLayer *)new JPH::BroadPhaseLayer(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseLayerInterface *)(_this)).GetBroadPhaseLayer(
        inLayer
    ));
}

const JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterface_OffsetPtr(const JPH_BroadPhaseLayerInterface *ptr, ptrdiff_t i)
{
    return (const JPH_BroadPhaseLayerInterface *)(((const JPH::BroadPhaseLayerInterface *)ptr) + i);
}

JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterface_OffsetMutablePtr(JPH_BroadPhaseLayerInterface *ptr, ptrdiff_t i)
{
    return (JPH_BroadPhaseLayerInterface *)(((JPH::BroadPhaseLayerInterface *)ptr) + i);
}

const JPH_NonCopyable *JPH_BroadPhaseLayerInterface_UpcastTo_JPH_NonCopyable(const JPH_BroadPhaseLayerInterface *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::BroadPhaseLayerInterface *)object)
    ));
}

JPH_NonCopyable *JPH_BroadPhaseLayerInterface_MutableUpcastTo_JPH_NonCopyable(JPH_BroadPhaseLayerInterface *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::BroadPhaseLayerInterface *)object)
    ));
}

const JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterface_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_BroadPhaseLayerInterface *)(static_cast<const JPH::BroadPhaseLayerInterface *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_BroadPhaseLayerInterface *JPH_BroadPhaseLayerInterface_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_BroadPhaseLayerInterface *)(static_cast<JPH::BroadPhaseLayerInterface *>(
        ((JPH::NonCopyable *)object)
    ));
}

JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilter_DefaultConstruct(void)
{
    using _mrbind_T = JPH::ObjectVsBroadPhaseLayerFilter;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_ObjectVsBroadPhaseLayerFilter*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilter_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ObjectVsBroadPhaseLayerFilter *)(new JPH::ObjectVsBroadPhaseLayerFilter[num_elems]{});
}

const JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilter_OffsetPtr(const JPH_ObjectVsBroadPhaseLayerFilter *ptr, ptrdiff_t i)
{
    return (const JPH_ObjectVsBroadPhaseLayerFilter *)(((const JPH::ObjectVsBroadPhaseLayerFilter *)ptr) + i);
}

JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilter_OffsetMutablePtr(JPH_ObjectVsBroadPhaseLayerFilter *ptr, ptrdiff_t i)
{
    return (JPH_ObjectVsBroadPhaseLayerFilter *)(((JPH::ObjectVsBroadPhaseLayerFilter *)ptr) + i);
}

const JPH_NonCopyable *JPH_ObjectVsBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(const JPH_ObjectVsBroadPhaseLayerFilter *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::ObjectVsBroadPhaseLayerFilter *)object)
    ));
}

JPH_NonCopyable *JPH_ObjectVsBroadPhaseLayerFilter_MutableUpcastTo_JPH_NonCopyable(JPH_ObjectVsBroadPhaseLayerFilter *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::ObjectVsBroadPhaseLayerFilter *)object)
    ));
}

const JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_ObjectVsBroadPhaseLayerFilter *)(static_cast<const JPH::ObjectVsBroadPhaseLayerFilter *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_ObjectVsBroadPhaseLayerFilter *JPH_ObjectVsBroadPhaseLayerFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_ObjectVsBroadPhaseLayerFilter *)(static_cast<JPH::ObjectVsBroadPhaseLayerFilter *>(
        ((JPH::NonCopyable *)object)
    ));
}

void JPH_ObjectVsBroadPhaseLayerFilter_Destroy(const JPH_ObjectVsBroadPhaseLayerFilter *_this)
{
    delete ((const JPH::ObjectVsBroadPhaseLayerFilter *)_this);
}

void JPH_ObjectVsBroadPhaseLayerFilter_DestroyArray(const JPH_ObjectVsBroadPhaseLayerFilter *_this)
{
    delete[] ((const JPH::ObjectVsBroadPhaseLayerFilter *)_this);
}

bool JPH_ObjectVsBroadPhaseLayerFilter_ShouldCollide(const JPH_ObjectVsBroadPhaseLayerFilter *_this, unsigned short inLayer1, const JPH_BroadPhaseLayer *inLayer2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ObjectVsBroadPhaseLayerFilter *)(_this)).ShouldCollide(
        inLayer1,
        ((inLayer2 ? void() : MRBINDC_THROW("Parameter `inLayer2` can not be null.", void)), JPH::BroadPhaseLayer(*(JPH::BroadPhaseLayer *)inLayer2))
    );
}

JPH_BroadPhaseLayerFilter *JPH_BroadPhaseLayerFilter_DefaultConstruct(void)
{
    using _mrbind_T = JPH::BroadPhaseLayerFilter;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_BroadPhaseLayerFilter*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_BroadPhaseLayerFilter *JPH_BroadPhaseLayerFilter_DefaultConstructArray(size_t num_elems)
{
    return (JPH_BroadPhaseLayerFilter *)(new JPH::BroadPhaseLayerFilter[num_elems]{});
}

const JPH_BroadPhaseLayerFilter *JPH_BroadPhaseLayerFilter_OffsetPtr(const JPH_BroadPhaseLayerFilter *ptr, ptrdiff_t i)
{
    return (const JPH_BroadPhaseLayerFilter *)(((const JPH::BroadPhaseLayerFilter *)ptr) + i);
}

JPH_BroadPhaseLayerFilter *JPH_BroadPhaseLayerFilter_OffsetMutablePtr(JPH_BroadPhaseLayerFilter *ptr, ptrdiff_t i)
{
    return (JPH_BroadPhaseLayerFilter *)(((JPH::BroadPhaseLayerFilter *)ptr) + i);
}

const JPH_NonCopyable *JPH_BroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(const JPH_BroadPhaseLayerFilter *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::BroadPhaseLayerFilter *)object)
    ));
}

JPH_NonCopyable *JPH_BroadPhaseLayerFilter_MutableUpcastTo_JPH_NonCopyable(JPH_BroadPhaseLayerFilter *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::BroadPhaseLayerFilter *)object)
    ));
}

const JPH_BroadPhaseLayerFilter *JPH_BroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_BroadPhaseLayerFilter *)(static_cast<const JPH::BroadPhaseLayerFilter *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_BroadPhaseLayerFilter *JPH_BroadPhaseLayerFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_BroadPhaseLayerFilter *)(static_cast<JPH::BroadPhaseLayerFilter *>(
        ((JPH::NonCopyable *)object)
    ));
}

void JPH_BroadPhaseLayerFilter_Destroy(const JPH_BroadPhaseLayerFilter *_this)
{
    delete ((const JPH::BroadPhaseLayerFilter *)_this);
}

void JPH_BroadPhaseLayerFilter_DestroyArray(const JPH_BroadPhaseLayerFilter *_this)
{
    delete[] ((const JPH::BroadPhaseLayerFilter *)_this);
}

bool JPH_BroadPhaseLayerFilter_ShouldCollide(const JPH_BroadPhaseLayerFilter *_this, const JPH_BroadPhaseLayer *inLayer)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseLayerFilter *)(_this)).ShouldCollide(
        ((inLayer ? void() : MRBINDC_THROW("Parameter `inLayer` can not be null.", void)), JPH::BroadPhaseLayer(*(JPH::BroadPhaseLayer *)inLayer))
    );
}

JPH_DefaultBroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_Construct(const JPH_ObjectVsBroadPhaseLayerFilter *inObjectVsBroadPhaseLayerFilter, unsigned short inLayer)
{
    return (JPH_DefaultBroadPhaseLayerFilter *)new JPH::DefaultBroadPhaseLayerFilter(JPH::DefaultBroadPhaseLayerFilter(
        ((inObjectVsBroadPhaseLayerFilter ? void() : MRBINDC_THROW("Parameter `inObjectVsBroadPhaseLayerFilter` can not be null.", void)), *(const JPH::ObjectVsBroadPhaseLayerFilter *)(inObjectVsBroadPhaseLayerFilter)),
        inLayer
    ));
}

const JPH_DefaultBroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_OffsetPtr(const JPH_DefaultBroadPhaseLayerFilter *ptr, ptrdiff_t i)
{
    return (const JPH_DefaultBroadPhaseLayerFilter *)(((const JPH::DefaultBroadPhaseLayerFilter *)ptr) + i);
}

JPH_DefaultBroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_OffsetMutablePtr(JPH_DefaultBroadPhaseLayerFilter *ptr, ptrdiff_t i)
{
    return (JPH_DefaultBroadPhaseLayerFilter *)(((JPH::DefaultBroadPhaseLayerFilter *)ptr) + i);
}

const JPH_NonCopyable *JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(const JPH_DefaultBroadPhaseLayerFilter *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::DefaultBroadPhaseLayerFilter *)object)
    ));
}

JPH_NonCopyable *JPH_DefaultBroadPhaseLayerFilter_MutableUpcastTo_JPH_NonCopyable(JPH_DefaultBroadPhaseLayerFilter *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::DefaultBroadPhaseLayerFilter *)object)
    ));
}

const JPH_DefaultBroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_DefaultBroadPhaseLayerFilter *)(static_cast<const JPH::DefaultBroadPhaseLayerFilter *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_DefaultBroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_DefaultBroadPhaseLayerFilter *)(static_cast<JPH::DefaultBroadPhaseLayerFilter *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_BroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter(const JPH_DefaultBroadPhaseLayerFilter *object)
{
    return (const JPH_BroadPhaseLayerFilter *)(static_cast<const JPH::BroadPhaseLayerFilter *>(
        ((const JPH::DefaultBroadPhaseLayerFilter *)object)
    ));
}

JPH_BroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_MutableUpcastTo_JPH_BroadPhaseLayerFilter(JPH_DefaultBroadPhaseLayerFilter *object)
{
    return (JPH_BroadPhaseLayerFilter *)(static_cast<JPH::BroadPhaseLayerFilter *>(
        ((JPH::DefaultBroadPhaseLayerFilter *)object)
    ));
}

const JPH_DefaultBroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter(const JPH_BroadPhaseLayerFilter *object)
{
    return (const JPH_DefaultBroadPhaseLayerFilter *)(static_cast<const JPH::DefaultBroadPhaseLayerFilter *>(
        ((const JPH::BroadPhaseLayerFilter *)object)
    ));
}

JPH_DefaultBroadPhaseLayerFilter *JPH_DefaultBroadPhaseLayerFilter_MutableStaticDowncastFrom_JPH_BroadPhaseLayerFilter(JPH_BroadPhaseLayerFilter *object)
{
    return (JPH_DefaultBroadPhaseLayerFilter *)(static_cast<JPH::DefaultBroadPhaseLayerFilter *>(
        ((JPH::BroadPhaseLayerFilter *)object)
    ));
}

void JPH_DefaultBroadPhaseLayerFilter_Destroy(const JPH_DefaultBroadPhaseLayerFilter *_this)
{
    delete ((const JPH::DefaultBroadPhaseLayerFilter *)_this);
}

void JPH_DefaultBroadPhaseLayerFilter_DestroyArray(const JPH_DefaultBroadPhaseLayerFilter *_this)
{
    delete[] ((const JPH::DefaultBroadPhaseLayerFilter *)_this);
}

bool JPH_DefaultBroadPhaseLayerFilter_ShouldCollide(const JPH_DefaultBroadPhaseLayerFilter *_this, const JPH_BroadPhaseLayer *inLayer)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DefaultBroadPhaseLayerFilter *)(_this)).ShouldCollide(
        ((inLayer ? void() : MRBINDC_THROW("Parameter `inLayer` can not be null.", void)), JPH::BroadPhaseLayer(*(JPH::BroadPhaseLayer *)inLayer))
    );
}

JPH_SpecifiedBroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_Construct(const JPH_BroadPhaseLayer *inLayer)
{
    return (JPH_SpecifiedBroadPhaseLayerFilter *)new JPH::SpecifiedBroadPhaseLayerFilter(JPH::SpecifiedBroadPhaseLayerFilter(
        ((inLayer ? void() : MRBINDC_THROW("Parameter `inLayer` can not be null.", void)), JPH::BroadPhaseLayer(*(JPH::BroadPhaseLayer *)inLayer))
    ));
}

const JPH_SpecifiedBroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_OffsetPtr(const JPH_SpecifiedBroadPhaseLayerFilter *ptr, ptrdiff_t i)
{
    return (const JPH_SpecifiedBroadPhaseLayerFilter *)(((const JPH::SpecifiedBroadPhaseLayerFilter *)ptr) + i);
}

JPH_SpecifiedBroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_OffsetMutablePtr(JPH_SpecifiedBroadPhaseLayerFilter *ptr, ptrdiff_t i)
{
    return (JPH_SpecifiedBroadPhaseLayerFilter *)(((JPH::SpecifiedBroadPhaseLayerFilter *)ptr) + i);
}

const JPH_NonCopyable *JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_NonCopyable(const JPH_SpecifiedBroadPhaseLayerFilter *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::SpecifiedBroadPhaseLayerFilter *)object)
    ));
}

JPH_NonCopyable *JPH_SpecifiedBroadPhaseLayerFilter_MutableUpcastTo_JPH_NonCopyable(JPH_SpecifiedBroadPhaseLayerFilter *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::SpecifiedBroadPhaseLayerFilter *)object)
    ));
}

const JPH_SpecifiedBroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_SpecifiedBroadPhaseLayerFilter *)(static_cast<const JPH::SpecifiedBroadPhaseLayerFilter *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_SpecifiedBroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_SpecifiedBroadPhaseLayerFilter *)(static_cast<JPH::SpecifiedBroadPhaseLayerFilter *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_BroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_UpcastTo_JPH_BroadPhaseLayerFilter(const JPH_SpecifiedBroadPhaseLayerFilter *object)
{
    return (const JPH_BroadPhaseLayerFilter *)(static_cast<const JPH::BroadPhaseLayerFilter *>(
        ((const JPH::SpecifiedBroadPhaseLayerFilter *)object)
    ));
}

JPH_BroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_MutableUpcastTo_JPH_BroadPhaseLayerFilter(JPH_SpecifiedBroadPhaseLayerFilter *object)
{
    return (JPH_BroadPhaseLayerFilter *)(static_cast<JPH::BroadPhaseLayerFilter *>(
        ((JPH::SpecifiedBroadPhaseLayerFilter *)object)
    ));
}

const JPH_SpecifiedBroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_StaticDowncastFrom_JPH_BroadPhaseLayerFilter(const JPH_BroadPhaseLayerFilter *object)
{
    return (const JPH_SpecifiedBroadPhaseLayerFilter *)(static_cast<const JPH::SpecifiedBroadPhaseLayerFilter *>(
        ((const JPH::BroadPhaseLayerFilter *)object)
    ));
}

JPH_SpecifiedBroadPhaseLayerFilter *JPH_SpecifiedBroadPhaseLayerFilter_MutableStaticDowncastFrom_JPH_BroadPhaseLayerFilter(JPH_BroadPhaseLayerFilter *object)
{
    return (JPH_SpecifiedBroadPhaseLayerFilter *)(static_cast<JPH::SpecifiedBroadPhaseLayerFilter *>(
        ((JPH::BroadPhaseLayerFilter *)object)
    ));
}

void JPH_SpecifiedBroadPhaseLayerFilter_Destroy(const JPH_SpecifiedBroadPhaseLayerFilter *_this)
{
    delete ((const JPH::SpecifiedBroadPhaseLayerFilter *)_this);
}

void JPH_SpecifiedBroadPhaseLayerFilter_DestroyArray(const JPH_SpecifiedBroadPhaseLayerFilter *_this)
{
    delete[] ((const JPH::SpecifiedBroadPhaseLayerFilter *)_this);
}

bool JPH_SpecifiedBroadPhaseLayerFilter_ShouldCollide(const JPH_SpecifiedBroadPhaseLayerFilter *_this, const JPH_BroadPhaseLayer *inLayer)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SpecifiedBroadPhaseLayerFilter *)(_this)).ShouldCollide(
        ((inLayer ? void() : MRBINDC_THROW("Parameter `inLayer` can not be null.", void)), JPH::BroadPhaseLayer(*(JPH::BroadPhaseLayer *)inLayer))
    );
}

