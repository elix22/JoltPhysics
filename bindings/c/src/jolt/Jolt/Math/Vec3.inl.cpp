// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/Vec3.inl.h"

#include <Jolt/Math/Vec3.h>
#include <__mrbind_c_details.h>

#include <stdexcept>


JPH_Vec3 *Jolt_mul_float_JPH_Vec3(float inV1, const JPH_Vec3 *inV2)
{
    return (JPH_Vec3 *)new JPH::Vec3(operator*(
        inV1,
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2))
    ));
}

