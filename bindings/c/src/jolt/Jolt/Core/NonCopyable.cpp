// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Core/NonCopyable.h"

#include <Jolt/Core/NonCopyable.h>

#include <cstddef>
#include <cstring>
#include <new>


JPH_NonCopyable *JPH_NonCopyable_DefaultConstruct(void)
{
    using _mrbind_T = JPH::NonCopyable;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_NonCopyable*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_NonCopyable *JPH_NonCopyable_DefaultConstructArray(size_t num_elems)
{
    return (JPH_NonCopyable *)(new JPH::NonCopyable[num_elems]);
}

const JPH_NonCopyable *JPH_NonCopyable_OffsetPtr(const JPH_NonCopyable *ptr, ptrdiff_t i)
{
    return (const JPH_NonCopyable *)(((const JPH::NonCopyable *)ptr) + i);
}

JPH_NonCopyable *JPH_NonCopyable_OffsetMutablePtr(JPH_NonCopyable *ptr, ptrdiff_t i)
{
    return (JPH_NonCopyable *)(((JPH::NonCopyable *)ptr) + i);
}

void JPH_NonCopyable_Destroy(const JPH_NonCopyable *_this)
{
    delete ((const JPH::NonCopyable *)_this);
}

void JPH_NonCopyable_DestroyArray(const JPH_NonCopyable *_this)
{
    delete[] ((const JPH::NonCopyable *)_this);
}

