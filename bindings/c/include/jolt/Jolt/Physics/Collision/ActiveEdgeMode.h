// machine generated, do not edit
#pragma once

#ifdef __cplusplus
extern "C" {
#endif


/// How to treat active/inactive edges.
/// An active edge is an edge that either has no neighbouring edge or if the angle between the two connecting faces is too large, see: ActiveEdges
typedef unsigned char JPH_EActiveEdgeMode;
enum // JPH_EActiveEdgeMode
{
    ///< Do not collide with inactive edges. For physics simulation, this gives less ghost collisions.
    JPH_EActiveEdgeMode_CollideOnlyWithActive = 0,
    ///< Collide with all edges. Use this when you're interested in all collisions.
    JPH_EActiveEdgeMode_CollideWithAll = 1,
};

#ifdef __cplusplus
} // extern "C"
#endif
