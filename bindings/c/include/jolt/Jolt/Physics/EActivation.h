// machine generated, do not edit
#pragma once

#ifdef __cplusplus
extern "C" {
#endif


/// Enum used by AddBody to determine if the body needs to be initially active
typedef enum JPH_EActivation
{
    ///< Activate the body, making it part of the simulation
    JPH_EActivation_Activate = 0,
    ///< Leave activation state as it is (will not deactivate an active body)
    JPH_EActivation_DontActivate = 1,
} JPH_EActivation;

#ifdef __cplusplus
} // extern "C"
#endif
