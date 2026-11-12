// machine generated, do not edit
#pragma once

#ifdef __cplusplus
extern "C" {
#endif


/// Motion type of a physics body
typedef unsigned char JPH_EMotionType;
enum // JPH_EMotionType
{
    ///< Non movable
    JPH_EMotionType_Static = 0,
    ///< Movable using velocities only, does not respond to forces
    JPH_EMotionType_Kinematic = 1,
    ///< Responds to forces as a normal physics object
    JPH_EMotionType_Dynamic = 2,
};

#ifdef __cplusplus
} // extern "C"
#endif
