// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "common.h"

#include <cstddef>


void *Jolt_Alloc(size_t num_bytes)
{
    return operator new(
        num_bytes
    );
}

void Jolt_Free(void *ptr)
{
    operator delete(
        ptr
    );
}

void *Jolt_AllocArray(size_t num_bytes)
{
    return operator new[](
        num_bytes
    );
}

void Jolt_FreeArray(void *ptr)
{
    operator delete[](
        ptr
    );
}

