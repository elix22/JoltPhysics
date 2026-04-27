// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/BroadPhase/BroadPhaseQuery.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseQuery.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


void JPH_BroadPhaseQuery_Destroy(const JPH_BroadPhaseQuery *_this)
{
    delete ((const JPH::BroadPhaseQuery *)_this);
}

void JPH_BroadPhaseQuery_DestroyArray(const JPH_BroadPhaseQuery *_this)
{
    delete[] ((const JPH::BroadPhaseQuery *)_this);
}

JPH_AABox *JPH_BroadPhaseQuery_GetBounds(const JPH_BroadPhaseQuery *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseQuery *)(_this)).GetBounds());
}

const JPH_BroadPhaseQuery *JPH_BroadPhaseQuery_OffsetPtr(const JPH_BroadPhaseQuery *ptr, ptrdiff_t i)
{
    return (const JPH_BroadPhaseQuery *)(((const JPH::BroadPhaseQuery *)ptr) + i);
}

JPH_BroadPhaseQuery *JPH_BroadPhaseQuery_OffsetMutablePtr(JPH_BroadPhaseQuery *ptr, ptrdiff_t i)
{
    return (JPH_BroadPhaseQuery *)(((JPH::BroadPhaseQuery *)ptr) + i);
}

const JPH_NonCopyable *JPH_BroadPhaseQuery_UpcastTo_JPH_NonCopyable(const JPH_BroadPhaseQuery *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::BroadPhaseQuery *)object)
    ));
}

JPH_NonCopyable *JPH_BroadPhaseQuery_MutableUpcastTo_JPH_NonCopyable(JPH_BroadPhaseQuery *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::BroadPhaseQuery *)object)
    ));
}

const JPH_BroadPhaseQuery *JPH_BroadPhaseQuery_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_BroadPhaseQuery *)(static_cast<const JPH::BroadPhaseQuery *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_BroadPhaseQuery *JPH_BroadPhaseQuery_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_BroadPhaseQuery *)(static_cast<JPH::BroadPhaseQuery *>(
        ((JPH::NonCopyable *)object)
    ));
}

