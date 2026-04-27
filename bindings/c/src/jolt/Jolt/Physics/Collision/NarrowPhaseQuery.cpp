// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/NarrowPhaseQuery.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Physics/Collision/NarrowPhaseQuery.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


JPH_NarrowPhaseQuery *JPH_NarrowPhaseQuery_DefaultConstruct(void)
{
    return (JPH_NarrowPhaseQuery *)new JPH::NarrowPhaseQuery(JPH::NarrowPhaseQuery());
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

