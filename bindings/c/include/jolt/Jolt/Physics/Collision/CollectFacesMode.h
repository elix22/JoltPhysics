// machine generated, do not edit
#pragma once

#ifdef __cplusplus
extern "C" {
#endif


/// Whether or not to collect faces, used by CastShape and CollideShape
typedef unsigned char JPH_ECollectFacesMode;
enum // JPH_ECollectFacesMode
{
    ///< mShape1/2Face is desired
    JPH_ECollectFacesMode_CollectFaces = 0,
    ///< mShape1/2Face is not desired
    JPH_ECollectFacesMode_NoFaces = 1,
};

#ifdef __cplusplus
} // extern "C"
#endif
