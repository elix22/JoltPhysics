// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/NarrowPhaseQuery.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/BodyFilter.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>
#include <Jolt/Physics/Collision/CastResult.h>
#include <Jolt/Physics/Collision/CollideShape.h>
#include <Jolt/Physics/Collision/NarrowPhaseQuery.h>
#include <Jolt/Physics/Collision/ObjectLayer.h>
#include <Jolt/Physics/Collision/RayCast.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/ShapeCast.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <new>
#include <stdexcept>


JPH_NarrowPhaseQuery *JPH_NarrowPhaseQuery_DefaultConstruct(void)
{
    using _mrbind_T = JPH::NarrowPhaseQuery;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_NarrowPhaseQuery*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_NarrowPhaseQuery *JPH_NarrowPhaseQuery_DefaultConstructArray(size_t num_elems)
{
    return (JPH_NarrowPhaseQuery *)(new JPH::NarrowPhaseQuery[num_elems]{});
}

const JPH_NarrowPhaseQuery *JPH_NarrowPhaseQuery_OffsetPtr(const JPH_NarrowPhaseQuery *ptr, ptrdiff_t i)
{
    return (const JPH_NarrowPhaseQuery *)(((const JPH::NarrowPhaseQuery *)ptr) + i);
}

JPH_NarrowPhaseQuery *JPH_NarrowPhaseQuery_OffsetMutablePtr(JPH_NarrowPhaseQuery *ptr, ptrdiff_t i)
{
    return (JPH_NarrowPhaseQuery *)(((JPH::NarrowPhaseQuery *)ptr) + i);
}

const JPH_NonCopyable *JPH_NarrowPhaseQuery_UpcastTo_JPH_NonCopyable(const JPH_NarrowPhaseQuery *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::NarrowPhaseQuery *)object)
    ));
}

JPH_NonCopyable *JPH_NarrowPhaseQuery_MutableUpcastTo_JPH_NonCopyable(JPH_NarrowPhaseQuery *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::NarrowPhaseQuery *)object)
    ));
}

const JPH_NarrowPhaseQuery *JPH_NarrowPhaseQuery_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_NarrowPhaseQuery *)(static_cast<const JPH::NarrowPhaseQuery *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_NarrowPhaseQuery *JPH_NarrowPhaseQuery_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_NarrowPhaseQuery *)(static_cast<JPH::NarrowPhaseQuery *>(
        ((JPH::NonCopyable *)object)
    ));
}

void JPH_NarrowPhaseQuery_Destroy(const JPH_NarrowPhaseQuery *_this)
{
    delete ((const JPH::NarrowPhaseQuery *)_this);
}

void JPH_NarrowPhaseQuery_DestroyArray(const JPH_NarrowPhaseQuery *_this)
{
    delete[] ((const JPH::NarrowPhaseQuery *)_this);
}

bool JPH_NarrowPhaseQuery_CastRay_5(const JPH_NarrowPhaseQuery *_this, const JPH_RRayCast *inRay, JPH_RayCastResult *ioHit, const JPH_BroadPhaseLayerFilter *inBroadPhaseLayerFilter, const JPH_ObjectLayerFilter *inObjectLayerFilter, const JPH_BodyFilter *inBodyFilter)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::NarrowPhaseQuery *)(_this)).CastRay(
        ((inRay ? void() : MRBINDC_THROW("Parameter `inRay` can not be null.", void)), *(const JPH::RRayCast *)(inRay)),
        ((ioHit ? void() : MRBINDC_THROW("Parameter `ioHit` can not be null.", void)), *(JPH::RayCastResult *)(ioHit)),
        (inBroadPhaseLayerFilter ? *(const JPH::BroadPhaseLayerFilter *)(inBroadPhaseLayerFilter) : static_cast<const JPH::BroadPhaseLayerFilter &>(JPH::BroadPhaseLayerFilter{})),
        (inObjectLayerFilter ? *(const JPH::ObjectLayerFilter *)(inObjectLayerFilter) : static_cast<const JPH::ObjectLayerFilter &>(JPH::ObjectLayerFilter{})),
        (inBodyFilter ? *(const JPH::BodyFilter *)(inBodyFilter) : static_cast<const JPH::BodyFilter &>(JPH::BodyFilter{}))
    );
}

