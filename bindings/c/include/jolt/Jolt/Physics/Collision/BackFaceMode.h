// machine generated, do not edit
#pragma once

#ifdef __cplusplus
extern "C" {
#endif


/// How collision detection functions will treat back facing triangles
typedef unsigned char JPH_EBackFaceMode;
enum // JPH_EBackFaceMode
{
    ///< Ignore collision with back facing surfaces/triangles
    JPH_EBackFaceMode_IgnoreBackFaces = 0,
    ///< Collide with back facing surfaces/triangles
    JPH_EBackFaceMode_CollideWithBackFaces = 1,
};

#ifdef __cplusplus
} // extern "C"
#endif
