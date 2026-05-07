// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_Color JPH_Color; // Defined in `#include <jolt/Jolt/Core/Color.h>`.
typedef struct JPH_Float2 JPH_Float2; // Defined in `#include <jolt/Jolt/Math/Float2.h>`.
typedef struct JPH_Float3 JPH_Float3; // Defined in `#include <jolt/Jolt/Math/Float3.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_RefTarget_JPH_DebugRenderer_Geometry JPH_RefTarget_JPH_DebugRenderer_Geometry; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct Jolt_JPH_Array_JPH_DebugRenderer_LOD Jolt_JPH_Array_JPH_DebugRenderer_LOD; // Defined in `#include <JPH_Array_JPH_DebugRenderer_LOD.h>`.
typedef struct Jolt_JPH_Array_JPH_DebugRenderer_Triangle Jolt_JPH_Array_JPH_DebugRenderer_Triangle; // Defined in `#include <JPH_Array_JPH_DebugRenderer_Triangle.h>`.
typedef struct Jolt_JPH_Array_JPH_DebugRenderer_Vertex Jolt_JPH_Array_JPH_DebugRenderer_Vertex; // Defined in `#include <JPH_Array_JPH_DebugRenderer_Vertex.h>`.
typedef struct Jolt_JPH_Array_JPH_Float3 Jolt_JPH_Array_JPH_Float3; // Defined in `#include <JPH_Array_JPH_Float3.h>`.
typedef struct Jolt_JPH_Array_unsigned_int Jolt_JPH_Array_unsigned_int; // Defined in `#include <JPH_Array_unsigned_int.h>`.
typedef struct Jolt_std_function_JPH_Vec3_from_JPH_Vec3 Jolt_std_function_JPH_Vec3_from_JPH_Vec3; // Defined in `#include <std_function_JPH_Vec3_from_JPH_Vec3.h>`.


/// Enum that determines if a shadow should be cast or not
typedef enum JPH_DebugRenderer_ECastShadow
{
    ///< This shape should cast a shadow
    JPH_DebugRenderer_ECastShadow_On = 0,
    ///< This shape should not cast a shadow
    JPH_DebugRenderer_ECastShadow_Off = 1,
} JPH_DebugRenderer_ECastShadow;

/// Determines how triangles are drawn
typedef enum JPH_DebugRenderer_EDrawMode
{
    ///< Draw as a solid shape
    JPH_DebugRenderer_EDrawMode_Solid = 0,
    ///< Draw as wireframe
    JPH_DebugRenderer_EDrawMode_Wireframe = 1,
} JPH_DebugRenderer_EDrawMode;

/// Vertex format used by the triangle renderer
/// Generated from class `JPH::DebugRenderer::Vertex`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_DebugRenderer_Vertex JPH_DebugRenderer_Vertex;

/// A single triangle
/// Generated from class `JPH::DebugRenderer::Triangle`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_DebugRenderer_Triangle JPH_DebugRenderer_Triangle;

/// A single level of detail
/// Generated from class `JPH::DebugRenderer::LOD`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_DebugRenderer_LOD JPH_DebugRenderer_LOD;

/// A geometry primitive containing triangle batches for various lods
/// Generated from class `JPH::DebugRenderer::Geometry`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::RefTarget<JPH::DebugRenderer::Geometry>`
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JPH_DebugRenderer_Geometry JPH_DebugRenderer_Geometry;

/// Determines which polygons are culled
typedef enum JPH_DebugRenderer_ECullMode
{
    ///< Don't draw backfacing polygons
    JPH_DebugRenderer_ECullMode_CullBackFace = 0,
    ///< Don't draw front facing polygons
    JPH_DebugRenderer_ECullMode_CullFrontFace = 1,
    ///< Don't do culling and draw both sides
    JPH_DebugRenderer_ECullMode_Off = 2,
} JPH_DebugRenderer_ECullMode;

/// Simple triangle renderer for debugging purposes.
///
/// Inherit from this class to provide your own implementation.
///
/// Implement the following virtual functions:
/// - DrawLine
/// - DrawTriangle
/// - DrawText3D
/// - CreateTriangleBatch
/// - DrawGeometry
///
/// Make sure you call Initialize() from the constructor of your implementation.
///
/// The CreateTriangleBatch is used to prepare a batch of triangles to be drawn by a single DrawGeometry call,
/// which means that Jolt can render a complex scene much more efficiently than when each triangle in that scene would have been drawn through DrawTriangle.
///
/// Note that an implementation that implements CreateTriangleBatch and DrawGeometry is provided by DebugRendererSimple which can be used to start quickly.
/// Generated from class `JPH::DebugRenderer`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::DebugRendererSimple`
///   Indirect: (non-virtual)
///     `RecordingDebugRenderer`
typedef struct JPH_DebugRenderer JPH_DebugRenderer;

/// Singleton instance
/// Returns a pointer to a member variable of class `JPH::DebugRenderer` named `sInstance`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_DebugRenderer *const *JPH_DebugRenderer_Get_sInstance(void);

/// Singleton instance
/// Modifies a member variable of class `JPH::DebugRenderer` named `sInstance`.
/// The reference to the parameter `value` might be preserved in this object in element `sInstance`.
/// When this function is called, this object will drop object references it held previously in `sInstance`.
JOLT_API void JPH_DebugRenderer_Set_sInstance(JPH_DebugRenderer *value);

/// Singleton instance
/// Returns a mutable pointer to a member variable of class `JPH::DebugRenderer` named `sInstance`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_DebugRenderer **JPH_DebugRenderer_GetMutable_sInstance(void);

/// Destroys a heap-allocated instance of `JPH_DebugRenderer`. Does nothing if the pointer is null.
JOLT_API void JPH_DebugRenderer_Destroy(const JPH_DebugRenderer *_this);

/// Destroys a heap-allocated array of `JPH_DebugRenderer`. Does nothing if the pointer is null.
JOLT_API void JPH_DebugRenderer_DestroyArray(const JPH_DebugRenderer *_this);

/// Generated from method `JPH::DebugRenderer::operator new`.
JOLT_API void *Jolt_new_JPH_DebugRenderer_size_t(size_t inCount);

/// Generated from method `JPH::DebugRenderer::operator delete`.
JOLT_API void Jolt_delete_JPH_DebugRenderer_void_ptr(void *inPointer);

/// Generated from method `JPH::DebugRenderer::operator delete`.
JOLT_API void Jolt_delete_JPH_DebugRenderer_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::DebugRenderer::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DebugRenderer_size_t(size_t inCount);

/// Generated from method `JPH::DebugRenderer::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DebugRenderer_void_ptr(void *inPointer);

/// Generated from method `JPH::DebugRenderer::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DebugRenderer_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::DebugRenderer::operator new`.
JOLT_API void *Jolt_new_JPH_DebugRenderer_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::DebugRenderer::operator delete`.
JOLT_API void Jolt_delete_JPH_DebugRenderer_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::DebugRenderer::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DebugRenderer_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::DebugRenderer::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DebugRenderer_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Call once after frame is complete. Releases unused dynamically generated geometry assets.
/// Generated from method `JPH::DebugRenderer::NextFrame`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DebugRenderer_NextFrame(JPH_DebugRenderer *_this);

/// Draw line
/// Generated from method `JPH::DebugRenderer::DrawLine`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inFrom` can not be null. It is a single object.
/// Parameter `inTo` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_DebugRenderer_DrawLine(JPH_DebugRenderer *_this, const JPH_Vec3 *inFrom, const JPH_Vec3 *inTo, const JPH_Color *inColor);

/// Draw wireframe box
/// Generated from method `JPH::DebugRenderer::DrawWireBox`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_DebugRenderer_DrawWireBox_2_JPH_AABox(JPH_DebugRenderer *_this, const JPH_AABox *inBox, const JPH_Color *inColor);

/// Generated from method `JPH::DebugRenderer::DrawWireBox`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_DebugRenderer_DrawWireBox_3(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, const JPH_AABox *inBox, const JPH_Color *inColor);

/// Draw a marker on a position
/// Generated from method `JPH::DebugRenderer::DrawMarker`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_DebugRenderer_DrawMarker(JPH_DebugRenderer *_this, const JPH_Vec3 *inPosition, const JPH_Color *inColor, float inSize);

/// Draw an arrow
/// Generated from method `JPH::DebugRenderer::DrawArrow`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inFrom` can not be null. It is a single object.
/// Parameter `inTo` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_DebugRenderer_DrawArrow(JPH_DebugRenderer *_this, const JPH_Vec3 *inFrom, const JPH_Vec3 *inTo, const JPH_Color *inColor, float inSize);

/// Draw coordinate system (3 arrows, x = red, y = green, z = blue)
/// Generated from method `JPH::DebugRenderer::DrawCoordinateSystem`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTransform` can not be null. It is a single object.
/// Parameter `inSize` has a default argument: `1.0f`, pass a null pointer to use it.
JOLT_API void JPH_DebugRenderer_DrawCoordinateSystem(JPH_DebugRenderer *_this, const JPH_Mat44 *inTransform, const float *inSize);

/// Draw a plane through inPoint with normal inNormal
/// Generated from method `JPH::DebugRenderer::DrawPlane`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPoint` can not be null. It is a single object.
/// Parameter `inNormal` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_DebugRenderer_DrawPlane(JPH_DebugRenderer *_this, const JPH_Vec3 *inPoint, const JPH_Vec3 *inNormal, const JPH_Color *inColor, float inSize);

/// Draw wireframe triangle
/// Generated from method `JPH::DebugRenderer::DrawWireTriangle`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Parameter `inV3` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_DebugRenderer_DrawWireTriangle(JPH_DebugRenderer *_this, const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor);

/// Draw wireframe sphere
/// Generated from method `JPH::DebugRenderer::DrawWireSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenter` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inLevel` has a default argument: `3`, pass a null pointer to use it.
JOLT_API void JPH_DebugRenderer_DrawWireSphere(JPH_DebugRenderer *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Color *inColor, const int *inLevel);

/// Generated from method `JPH::DebugRenderer::DrawWireUnitSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inLevel` has a default argument: `3`, pass a null pointer to use it.
JOLT_API void JPH_DebugRenderer_DrawWireUnitSphere(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, const JPH_Color *inColor, const int *inLevel);

/// Draw a single back face culled triangle
/// Generated from method `JPH::DebugRenderer::DrawTriangle`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Parameter `inV3` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::Off`, pass a null pointer to use it.
JOLT_API void JPH_DebugRenderer_DrawTriangle(JPH_DebugRenderer *_this, const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow);

/// Draw a box
/// Generated from method `JPH::DebugRenderer::DrawBox`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRenderer_DrawBox_4(JPH_DebugRenderer *_this, const JPH_AABox *inBox, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Generated from method `JPH::DebugRenderer::DrawBox`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inBox` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRenderer_DrawBox_5(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, const JPH_AABox *inBox, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draw a sphere
/// Generated from method `JPH::DebugRenderer::DrawSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenter` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRenderer_DrawSphere(JPH_DebugRenderer *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Generated from method `JPH::DebugRenderer::DrawUnitSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRenderer_DrawUnitSphere(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draw a capsule with one half sphere at (0, -inHalfHeightOfCylinder, 0) and the other half sphere at (0, inHalfHeightOfCylinder, 0) and radius inRadius.
/// The capsule will be transformed by inMatrix.
/// Generated from method `JPH::DebugRenderer::DrawCapsule`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRenderer_DrawCapsule(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, float inHalfHeightOfCylinder, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draw a cylinder with top (0, inHalfHeight, 0) and bottom (0, -inHalfHeight, 0) and radius inRadius.
/// The cylinder will be transformed by inMatrix
/// Generated from method `JPH::DebugRenderer::DrawCylinder`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRenderer_DrawCylinder(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, float inHalfHeight, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draw a bottomless cone.
/// @param inTop Top of cone, center of base is at inTop + inAxis.
/// @param inAxis Height and direction of cone
/// @param inPerpendicular Perpendicular vector to inAxis.
/// @param inHalfAngle Specifies the cone angle in radians (angle measured between inAxis and cone surface).
/// @param inLength The length of the cone.
/// @param inColor Color to use for drawing the cone.
/// @param inCastShadow determines if this geometry should cast a shadow or not.
/// @param inDrawMode determines if we draw the geometry solid or in wireframe.
/// Generated from method `JPH::DebugRenderer::DrawOpenCone`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTop` can not be null. It is a single object.
/// Parameter `inAxis` can not be null. It is a single object.
/// Parameter `inPerpendicular` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRenderer_DrawOpenCone(JPH_DebugRenderer *_this, const JPH_Vec3 *inTop, const JPH_Vec3 *inAxis, const JPH_Vec3 *inPerpendicular, float inHalfAngle, float inLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draws cone rotation limits as used by the SwingTwistConstraintPart.
/// @param inMatrix Matrix that transforms from constraint space to world space
/// @param inSwingYHalfAngle See SwingTwistConstraintPart
/// @param inSwingZHalfAngle See SwingTwistConstraintPart
/// @param inEdgeLength Size of the edge of the cone shape
/// @param inColor Color to use for drawing the cone.
/// @param inCastShadow determines if this geometry should cast a shadow or not.
/// @param inDrawMode determines if we draw the geometry solid or in wireframe.
/// Generated from method `JPH::DebugRenderer::DrawSwingConeLimits`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRenderer_DrawSwingConeLimits(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, float inSwingYHalfAngle, float inSwingZHalfAngle, float inEdgeLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draws rotation limits as used by the SwingTwistConstraintPart.
/// @param inMatrix Matrix that transforms from constraint space to world space
/// @param inMinSwingYAngle See SwingTwistConstraintPart
/// @param inMaxSwingYAngle See SwingTwistConstraintPart
/// @param inMinSwingZAngle See SwingTwistConstraintPart
/// @param inMaxSwingZAngle See SwingTwistConstraintPart
/// @param inEdgeLength Size of the edge of the cone shape
/// @param inColor Color to use for drawing the cone.
/// @param inCastShadow determines if this geometry should cast a shadow or not.
/// @param inDrawMode determines if we draw the geometry solid or in wireframe.
/// Generated from method `JPH::DebugRenderer::DrawSwingPyramidLimits`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRenderer_DrawSwingPyramidLimits(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, float inMinSwingYAngle, float inMaxSwingYAngle, float inMinSwingZAngle, float inMaxSwingZAngle, float inEdgeLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draw a pie (part of a circle).
/// @param inCenter The center of the circle.
/// @param inRadius Radius of the circle.
/// @param inNormal The plane normal in which the pie resides.
/// @param inAxis The axis that defines an angle of 0 radians.
/// @param inMinAngle The pie will be drawn between [inMinAngle, inMaxAngle] (in radians).
/// @param inMaxAngle The pie will be drawn between [inMinAngle, inMaxAngle] (in radians).
/// @param inColor Color to use for drawing the pie.
/// @param inCastShadow determines if this geometry should cast a shadow or not.
/// @param inDrawMode determines if we draw the geometry solid or in wireframe.
/// Generated from method `JPH::DebugRenderer::DrawPie`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenter` can not be null. It is a single object.
/// Parameter `inNormal` can not be null. It is a single object.
/// Parameter `inAxis` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRenderer_DrawPie(JPH_DebugRenderer *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Vec3 *inNormal, const JPH_Vec3 *inAxis, float inMinAngle, float inMaxAngle, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draw a tapered cylinder
/// @param inMatrix Matrix that transforms the cylinder to world space.
/// @param inTop Top of cylinder (along Y axis)
/// @param inBottom Bottom of cylinder (along Y axis)
/// @param inTopRadius Radius at the top
/// @param inBottomRadius Radius at the bottom
/// @param inColor Color to use for drawing the pie.
/// @param inCastShadow determines if this geometry should cast a shadow or not.
/// @param inDrawMode determines if we draw the geometry solid or in wireframe.
/// Generated from method `JPH::DebugRenderer::DrawTaperedCylinder`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRenderer_DrawTaperedCylinder(JPH_DebugRenderer *_this, const JPH_Mat44 *inMatrix, float inTop, float inBottom, float inTopRadius, float inBottomRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Calculate bounding box for a batch of triangles
/// Generated from method `JPH::DebugRenderer::sCalculateBounds`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_DebugRenderer_sCalculateBounds(const JPH_DebugRenderer_Vertex *inVertices, int inVertexCount);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_DebugRenderer *JPH_DebugRenderer_OffsetPtr(const JPH_DebugRenderer *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_DebugRenderer *JPH_DebugRenderer_OffsetMutablePtr(JPH_DebugRenderer *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::DebugRenderer` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_DebugRenderer_UpcastTo_JPH_NonCopyable(const JPH_DebugRenderer *object);

/// Upcasts an instance of `JPH::DebugRenderer` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_DebugRenderer_MutableUpcastTo_JPH_NonCopyable(JPH_DebugRenderer *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::DebugRenderer`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DebugRenderer *JPH_DebugRenderer_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::DebugRenderer`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DebugRenderer *JPH_DebugRenderer_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Returns a pointer to a member variable of class `JPH::DebugRenderer::Vertex` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Float3 *JPH_DebugRenderer_Vertex_Get_mPosition(const JPH_DebugRenderer_Vertex *_this);

/// Returns a mutable pointer to a member variable of class `JPH::DebugRenderer::Vertex` named `mPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Float3 *JPH_DebugRenderer_Vertex_GetMutable_mPosition(JPH_DebugRenderer_Vertex *_this);

/// Returns a pointer to a member variable of class `JPH::DebugRenderer::Vertex` named `mNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Float3 *JPH_DebugRenderer_Vertex_Get_mNormal(const JPH_DebugRenderer_Vertex *_this);

/// Returns a mutable pointer to a member variable of class `JPH::DebugRenderer::Vertex` named `mNormal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Float3 *JPH_DebugRenderer_Vertex_GetMutable_mNormal(JPH_DebugRenderer_Vertex *_this);

/// Returns a pointer to a member variable of class `JPH::DebugRenderer::Vertex` named `mUV`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Float2 *JPH_DebugRenderer_Vertex_Get_mUV(const JPH_DebugRenderer_Vertex *_this);

/// Returns a mutable pointer to a member variable of class `JPH::DebugRenderer::Vertex` named `mUV`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Float2 *JPH_DebugRenderer_Vertex_GetMutable_mUV(JPH_DebugRenderer_Vertex *_this);

/// Returns a pointer to a member variable of class `JPH::DebugRenderer::Vertex` named `mColor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_Color *JPH_DebugRenderer_Vertex_Get_mColor(const JPH_DebugRenderer_Vertex *_this);

/// Returns a mutable pointer to a member variable of class `JPH::DebugRenderer::Vertex` named `mColor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_Color *JPH_DebugRenderer_Vertex_GetMutable_mColor(JPH_DebugRenderer_Vertex *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DebugRenderer_Vertex_Destroy()` to free it when you're done using it.
JOLT_API JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Vertex_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_DebugRenderer_Vertex_DestroyArray()`.
/// Use `JPH_DebugRenderer_Vertex_OffsetMutablePtr()` and `JPH_DebugRenderer_Vertex_OffsetPtr()` to access the array elements.
JOLT_API JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Vertex_DefaultConstructArray(size_t num_elems);

/// Constructs `JPH::DebugRenderer::Vertex` elementwise.
/// Parameter `mPosition` can not be null. It is a single object.
/// The reference to the parameter `mPosition` might be preserved in the constructed object.
/// Parameter `mNormal` can not be null. It is a single object.
/// The reference to the parameter `mNormal` might be preserved in the constructed object.
/// Parameter `mUV` can not be null. It is a single object.
/// The reference to the parameter `mUV` might be preserved in the constructed object.
/// Parameter `mColor` can not be null. It is a single object.
/// The reference to the parameter `mColor` might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DebugRenderer_Vertex_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Vertex_ConstructFrom(const JPH_Float3 *mPosition, const JPH_Float3 *mNormal, const JPH_Float2 *mUV, const JPH_Color *mColor);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Vertex_OffsetPtr(const JPH_DebugRenderer_Vertex *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Vertex_OffsetMutablePtr(JPH_DebugRenderer_Vertex *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::DebugRenderer::Vertex::Vertex`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DebugRenderer_Vertex_Destroy()` to free it when you're done using it.
JOLT_API JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Vertex_ConstructFromAnother(const JPH_DebugRenderer_Vertex *_other);

/// Destroys a heap-allocated instance of `JPH_DebugRenderer_Vertex`. Does nothing if the pointer is null.
JOLT_API void JPH_DebugRenderer_Vertex_Destroy(const JPH_DebugRenderer_Vertex *_this);

/// Destroys a heap-allocated array of `JPH_DebugRenderer_Vertex`. Does nothing if the pointer is null.
JOLT_API void JPH_DebugRenderer_Vertex_DestroyArray(const JPH_DebugRenderer_Vertex *_this);

/// Generated from method `JPH::DebugRenderer::Vertex::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Vertex_AssignFromAnother(JPH_DebugRenderer_Vertex *_this, const JPH_DebugRenderer_Vertex *_other);

/// Returns a pointer to a member variable of class `JPH::DebugRenderer::Triangle` named `mV`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Triangle_Get_mV(const JPH_DebugRenderer_Triangle *_this);

/// Returns a mutable pointer to a member variable of class `JPH::DebugRenderer::Triangle` named `mV`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_DebugRenderer_Vertex *JPH_DebugRenderer_Triangle_GetMutable_mV(JPH_DebugRenderer_Triangle *_this);

/// Returns the size of the array member of class `JPH::DebugRenderer::Triangle` named `mV`. The size is `3`.
JOLT_API size_t JPH_DebugRenderer_Triangle_GetSize_mV(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DebugRenderer_Triangle_Destroy()` to free it when you're done using it.
JOLT_API JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_DebugRenderer_Triangle_DestroyArray()`.
/// Use `JPH_DebugRenderer_Triangle_OffsetMutablePtr()` and `JPH_DebugRenderer_Triangle_OffsetPtr()` to access the array elements.
JOLT_API JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_OffsetPtr(const JPH_DebugRenderer_Triangle *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_OffsetMutablePtr(JPH_DebugRenderer_Triangle *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::DebugRenderer::Triangle::Triangle`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DebugRenderer_Triangle_Destroy()` to free it when you're done using it.
JOLT_API JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_ConstructFromAnother(const JPH_DebugRenderer_Triangle *_other);

/// Generated from constructor `JPH::DebugRenderer::Triangle::Triangle`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Parameter `inV3` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DebugRenderer_Triangle_Destroy()` to free it when you're done using it.
JOLT_API JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_Construct_4(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor);

/// Generated from constructor `JPH::DebugRenderer::Triangle::Triangle`.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Parameter `inV3` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inUVOrigin` can not be null. It is a single object.
/// Parameter `inUVDirection` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DebugRenderer_Triangle_Destroy()` to free it when you're done using it.
JOLT_API JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_Construct_6(const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor, const JPH_Vec3 *inUVOrigin, const JPH_Vec3 *inUVDirection);

/// Destroys a heap-allocated instance of `JPH_DebugRenderer_Triangle`. Does nothing if the pointer is null.
JOLT_API void JPH_DebugRenderer_Triangle_Destroy(const JPH_DebugRenderer_Triangle *_this);

/// Destroys a heap-allocated array of `JPH_DebugRenderer_Triangle`. Does nothing if the pointer is null.
JOLT_API void JPH_DebugRenderer_Triangle_DestroyArray(const JPH_DebugRenderer_Triangle *_this);

/// Generated from method `JPH::DebugRenderer::Triangle::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_DebugRenderer_Triangle *JPH_DebugRenderer_Triangle_AssignFromAnother(JPH_DebugRenderer_Triangle *_this, const JPH_DebugRenderer_Triangle *_other);

/// Returns a pointer to a member variable of class `JPH::DebugRenderer::LOD` named `mDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const float *JPH_DebugRenderer_LOD_Get_mDistance(const JPH_DebugRenderer_LOD *_this);

/// Modifies a member variable of class `JPH::DebugRenderer::LOD` named `mDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `mDistance`.
JOLT_API void JPH_DebugRenderer_LOD_Set_mDistance(JPH_DebugRenderer_LOD *_this, float value);

/// Returns a mutable pointer to a member variable of class `JPH::DebugRenderer::LOD` named `mDistance`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API float *JPH_DebugRenderer_LOD_GetMutable_mDistance(JPH_DebugRenderer_LOD *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DebugRenderer_LOD_Destroy()` to free it when you're done using it.
JOLT_API JPH_DebugRenderer_LOD *JPH_DebugRenderer_LOD_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JPH_DebugRenderer_LOD_DestroyArray()`.
/// Use `JPH_DebugRenderer_LOD_OffsetMutablePtr()` and `JPH_DebugRenderer_LOD_OffsetPtr()` to access the array elements.
JOLT_API JPH_DebugRenderer_LOD *JPH_DebugRenderer_LOD_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_DebugRenderer_LOD *JPH_DebugRenderer_LOD_OffsetPtr(const JPH_DebugRenderer_LOD *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_DebugRenderer_LOD *JPH_DebugRenderer_LOD_OffsetMutablePtr(JPH_DebugRenderer_LOD *ptr, ptrdiff_t i);

/// Generated from constructor `JPH::DebugRenderer::LOD::LOD`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DebugRenderer_LOD_Destroy()` to free it when you're done using it.
JOLT_API JPH_DebugRenderer_LOD *JPH_DebugRenderer_LOD_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_DebugRenderer_LOD *_other);

/// Destroys a heap-allocated instance of `JPH_DebugRenderer_LOD`. Does nothing if the pointer is null.
JOLT_API void JPH_DebugRenderer_LOD_Destroy(const JPH_DebugRenderer_LOD *_this);

/// Destroys a heap-allocated array of `JPH_DebugRenderer_LOD`. Does nothing if the pointer is null.
JOLT_API void JPH_DebugRenderer_LOD_DestroyArray(const JPH_DebugRenderer_LOD *_this);

/// Generated from method `JPH::DebugRenderer::LOD::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_DebugRenderer_LOD *JPH_DebugRenderer_LOD_AssignFromAnother(JPH_DebugRenderer_LOD *_this, Jolt_PassBy _other_pass_by, JPH_DebugRenderer_LOD *_other);

/// All level of details for this mesh
/// Returns a pointer to a member variable of class `JPH::DebugRenderer::Geometry` named `mLODs`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const Jolt_JPH_Array_JPH_DebugRenderer_LOD *JPH_DebugRenderer_Geometry_Get_mLODs(const JPH_DebugRenderer_Geometry *_this);

/// All level of details for this mesh
/// Modifies a member variable of class `JPH::DebugRenderer::Geometry` named `mLODs`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mLODs`.
/// When this function is called, this object will drop object references it held previously in `mLODs`.
JOLT_API void JPH_DebugRenderer_Geometry_Set_mLODs(JPH_DebugRenderer_Geometry *_this, Jolt_PassBy value_pass_by, Jolt_JPH_Array_JPH_DebugRenderer_LOD *value);

/// All level of details for this mesh
/// Returns a mutable pointer to a member variable of class `JPH::DebugRenderer::Geometry` named `mLODs`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API Jolt_JPH_Array_JPH_DebugRenderer_LOD *JPH_DebugRenderer_Geometry_GetMutable_mLODs(JPH_DebugRenderer_Geometry *_this);

/// Bounding box that encapsulates all LODs
/// Returns a pointer to a member variable of class `JPH::DebugRenderer::Geometry` named `mBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API const JPH_AABox *JPH_DebugRenderer_Geometry_Get_mBounds(const JPH_DebugRenderer_Geometry *_this);

/// Bounding box that encapsulates all LODs
/// Modifies a member variable of class `JPH::DebugRenderer::Geometry` named `mBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `mBounds`.
/// When this function is called, this object will drop object references it held previously in `mBounds`.
JOLT_API void JPH_DebugRenderer_Geometry_Set_mBounds(JPH_DebugRenderer_Geometry *_this, const JPH_AABox *value);

/// Bounding box that encapsulates all LODs
/// Returns a mutable pointer to a member variable of class `JPH::DebugRenderer::Geometry` named `mBounds`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
JOLT_API JPH_AABox *JPH_DebugRenderer_Geometry_GetMutable_mBounds(JPH_DebugRenderer_Geometry *_this);

/// Generated from constructor `JPH::DebugRenderer::Geometry::Geometry`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DebugRenderer_Geometry_Destroy()` to free it when you're done using it.
JOLT_API JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_DebugRenderer_Geometry *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_OffsetPtr(const JPH_DebugRenderer_Geometry *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_OffsetMutablePtr(JPH_DebugRenderer_Geometry *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::DebugRenderer::Geometry` to its base class `JPH::RefTarget<JPH::DebugRenderer::Geometry>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(const JPH_DebugRenderer_Geometry *object);

/// Upcasts an instance of `JPH::DebugRenderer::Geometry` to its base class `JPH::RefTarget<JPH::DebugRenderer::Geometry>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_MutableUpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(JPH_DebugRenderer_Geometry *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::DebugRenderer::Geometry>` to a derived class `JPH::DebugRenderer::Geometry`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_StaticDowncastFrom_JPH_RefTarget_JPH_DebugRenderer_Geometry(const JPH_RefTarget_JPH_DebugRenderer_Geometry *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::DebugRenderer::Geometry>` to a derived class `JPH::DebugRenderer::Geometry`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_MutableStaticDowncastFrom_JPH_RefTarget_JPH_DebugRenderer_Geometry(JPH_RefTarget_JPH_DebugRenderer_Geometry *object);

/// Constructor
/// Generated from constructor `JPH::DebugRenderer::Geometry::Geometry`.
/// Parameter `inBounds` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_DebugRenderer_Geometry_Destroy()` to free it when you're done using it.
JOLT_API JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_Construct_1(const JPH_AABox *inBounds);

/// Destroys a heap-allocated instance of `JPH_DebugRenderer_Geometry`. Does nothing if the pointer is null.
JOLT_API void JPH_DebugRenderer_Geometry_Destroy(const JPH_DebugRenderer_Geometry *_this);

/// Destroys a heap-allocated array of `JPH_DebugRenderer_Geometry`. Does nothing if the pointer is null.
JOLT_API void JPH_DebugRenderer_Geometry_DestroyArray(const JPH_DebugRenderer_Geometry *_this);

/// Generated from method `JPH::DebugRenderer::Geometry::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JPH_DebugRenderer_Geometry *JPH_DebugRenderer_Geometry_AssignFromAnother(JPH_DebugRenderer_Geometry *_this, Jolt_PassBy _other_pass_by, JPH_DebugRenderer_Geometry *_other);

/// Generated from method `JPH::DebugRenderer::Geometry::operator new`.
JOLT_API void *Jolt_new_JPH_DebugRenderer_Geometry_size_t(size_t inCount);

/// Generated from method `JPH::DebugRenderer::Geometry::operator delete`.
JOLT_API void Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr(void *inPointer);

/// Generated from method `JPH::DebugRenderer::Geometry::operator delete`.
JOLT_API void Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::DebugRenderer::Geometry::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DebugRenderer_Geometry_size_t(size_t inCount);

/// Generated from method `JPH::DebugRenderer::Geometry::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr(void *inPointer);

/// Generated from method `JPH::DebugRenderer::Geometry::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::DebugRenderer::Geometry::operator new`.
JOLT_API void *Jolt_new_JPH_DebugRenderer_Geometry_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::DebugRenderer::Geometry::operator delete`.
JOLT_API void Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::DebugRenderer::Geometry::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DebugRenderer_Geometry_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::DebugRenderer::Geometry::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Determine which LOD to render
/// @param inCameraPosition Current position of the camera
/// @param inWorldSpaceBounds World space bounds for this geometry (transform mBounds by model space matrix)
/// @param inLODScaleSq is the squared scale of the model matrix, it is multiplied with the LOD distances in inGeometry to calculate the real LOD distance (so a number > 1 will force a higher LOD).
/// @return The selected LOD.
/// Generated from method `JPH::DebugRenderer::Geometry::GetLOD`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCameraPosition` can not be null. It is a single object.
/// Parameter `inWorldSpaceBounds` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_DebugRenderer_LOD *JPH_DebugRenderer_Geometry_GetLOD(const JPH_DebugRenderer_Geometry *_this, const JPH_Vec3 *inCameraPosition, const JPH_AABox *inWorldSpaceBounds, float inLODScaleSq);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::DebugRenderer::Geometry::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DebugRenderer_Geometry_SetEmbedded(const JPH_DebugRenderer_Geometry *_this);

/// Get current refcount of this object
/// Generated from method `JPH::DebugRenderer::Geometry::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_DebugRenderer_Geometry_GetRefCount(const JPH_DebugRenderer_Geometry *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::DebugRenderer::Geometry::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DebugRenderer_Geometry_AddRef(const JPH_DebugRenderer_Geometry *_this);

/// Generated from method `JPH::DebugRenderer::Geometry::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DebugRenderer_Geometry_Release(const JPH_DebugRenderer_Geometry *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::DebugRenderer::Geometry::sInternalGetRefCountOffset`.
JOLT_API int JPH_DebugRenderer_Geometry_sInternalGetRefCountOffset(void);

#ifdef __cplusplus
} // extern "C"
#endif
