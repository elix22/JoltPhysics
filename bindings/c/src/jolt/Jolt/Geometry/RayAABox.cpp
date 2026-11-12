// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Geometry/RayAABox.h"

#include <Jolt/Geometry/RayAABox.h>
#include <Jolt/Math/UVec4.h>
#include <Jolt/Math/Vec3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_RayInvDirection_Get_mInvDirection(const JPH_RayInvDirection *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayInvDirection *)(_this)).mInvDirection);
}

JPH_Vec3 *JPH_RayInvDirection_GetMutable_mInvDirection(JPH_RayInvDirection *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayInvDirection *)(_this)).mInvDirection);
}

const JPH_UVec4 *JPH_RayInvDirection_Get_mIsParallel(const JPH_RayInvDirection *_this)
{
    return (const JPH_UVec4 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayInvDirection *)(_this)).mIsParallel);
}

JPH_UVec4 *JPH_RayInvDirection_GetMutable_mIsParallel(JPH_RayInvDirection *_this)
{
    return (JPH_UVec4 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayInvDirection *)(_this)).mIsParallel);
}

JPH_RayInvDirection *JPH_RayInvDirection_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RayInvDirection;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RayInvDirection*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RayInvDirection *JPH_RayInvDirection_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RayInvDirection *)(new JPH::RayInvDirection[num_elems]);
}

const JPH_RayInvDirection *JPH_RayInvDirection_OffsetPtr(const JPH_RayInvDirection *ptr, ptrdiff_t i)
{
    return (const JPH_RayInvDirection *)(((const JPH::RayInvDirection *)ptr) + i);
}

JPH_RayInvDirection *JPH_RayInvDirection_OffsetMutablePtr(JPH_RayInvDirection *ptr, ptrdiff_t i)
{
    return (JPH_RayInvDirection *)(((JPH::RayInvDirection *)ptr) + i);
}

JPH_RayInvDirection *JPH_RayInvDirection_ConstructFromAnother(const JPH_RayInvDirection *_other)
{
    return (JPH_RayInvDirection *)new JPH::RayInvDirection(JPH::RayInvDirection(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::RayInvDirection(*(JPH::RayInvDirection *)_other))
    ));
}

JPH_RayInvDirection *JPH_RayInvDirection_Construct(const JPH_Vec3 *inDirection)
{
    return (JPH_RayInvDirection *)new JPH::RayInvDirection(JPH::RayInvDirection(
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    ));
}

void JPH_RayInvDirection_Destroy(const JPH_RayInvDirection *_this)
{
    delete ((const JPH::RayInvDirection *)_this);
}

void JPH_RayInvDirection_DestroyArray(const JPH_RayInvDirection *_this)
{
    delete[] ((const JPH::RayInvDirection *)_this);
}

JPH_RayInvDirection *JPH_RayInvDirection_AssignFromAnother(JPH_RayInvDirection *_this, const JPH_RayInvDirection *_other)
{
    return (JPH_RayInvDirection *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayInvDirection *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::RayInvDirection(*(JPH::RayInvDirection *)_other))
    ));
}

void JPH_RayInvDirection_Set(JPH_RayInvDirection *_this, const JPH_Vec3 *inDirection)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayInvDirection *)(_this)).Set(
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection))
    );
}

