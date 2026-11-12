// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Math/Vec4.inl.h"

#include <Jolt/Math/Vec4.h>
#include <__mrbind_c_details.h>

#include <stdexcept>


JPH_Vec4 *Jolt_mul_float_JPH_Vec4(float inV1, const JPH_Vec4 *inV2)
{
    return (JPH_Vec4 *)new JPH::Vec4(operator*(
        inV1,
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec4(*(JPH::Vec4 *)inV2))
    ));
}

