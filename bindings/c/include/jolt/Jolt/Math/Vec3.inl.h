// machine generated, do not edit
#pragma once

#include <exports.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.


/// Multiply vector with float
/// Generated from function `JPH::operator*`.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_Vec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_Vec3 *Jolt_mul_float_JPH_Vec3(float inV1, const JPH_Vec3 *inV2);

#ifdef __cplusplus
} // extern "C"
#endif
