// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/DVec3.inl.h"

#include <Jolt/Math/DVec3.h>
#include <__mrbind_c_details.h>

#include <stdexcept>


JPH_DVec3 *Jolt_mul_double_JPH_DVec3(double inV1, const JPH_DVec3 *inV2)
{
    return (JPH_DVec3 *)new JPH::DVec3(operator*(
        inV1,
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), *(const JPH::DVec3 *)(inV2))
    ));
}

