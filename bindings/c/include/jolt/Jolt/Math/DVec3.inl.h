// machine generated, do not edit
#pragma once

#include <exports.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_DVec3 JPH_DVec3; // Defined in `#include <jolt/Jolt/Math/DVec3.h>`.


/// Multiply vector with double
/// Generated from function `JPH::operator*`.
/// Parameter `inV2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DVec3_Destroy()` to free it when you're done using it.
JOLT_API JPH_DVec3 *Jolt_mul_double_JPH_DVec3(double inV1, const JPH_DVec3 *inV2);

#ifdef __cplusplus
} // extern "C"
#endif
