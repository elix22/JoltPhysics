// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>
#include <jolt/Jolt/Renderer/DebugRenderer.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_AABox JPH_AABox; // Defined in `#include <jolt/Jolt/Geometry/AABox.h>`.
typedef struct JPH_Color JPH_Color; // Defined in `#include <jolt/Jolt/Core/Color.h>`.
typedef struct JPH_DebugRenderer JPH_DebugRenderer; // Defined in `#include <jolt/Jolt/Renderer/DebugRenderer.h>`.
typedef struct JPH_DebugRenderer_Vertex JPH_DebugRenderer_Vertex; // Defined in `#include <jolt/Jolt/Renderer/DebugRenderer.h>`.
typedef struct JPH_Mat44 JPH_Mat44; // Defined in `#include <jolt/Jolt/Math/Mat44.h>`.
typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct Jolt_std_function_JPH_Vec3_from_JPH_Vec3 Jolt_std_function_JPH_Vec3_from_JPH_Vec3; // Defined in `#include <std_function_JPH_Vec3_from_JPH_Vec3.h>`.


/// Inherit from this class to simplify implementing a debug renderer, start with this implementation:
///
///		class MyDebugRenderer : public JPH::DebugRendererSimple
///		{
///		public:
///			virtual void DrawLine(JPH::RVec3Arg inFrom, JPH::RVec3Arg inTo, JPH::ColorArg inColor) override
///			{
///				// Implement
///			}
///
///			virtual void DrawTriangle(JPH::RVec3Arg inV1, JPH::RVec3Arg inV2, JPH::RVec3Arg inV3, JPH::ColorArg inColor, ECastShadow inCastShadow) override
///			{
///				// Implement
///			}
///
///			virtual void DrawText3D(JPH::RVec3Arg inPosition, const string_view &inString, JPH::ColorArg inColor, float inHeight) override
///			{
///				// Implement
///			}
///		};
///
/// Note that this class is meant to be a quick start for implementing a debug renderer, it is not the most efficient way to implement a debug renderer.
/// Generated from class `JPH::DebugRendererSimple`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::DebugRenderer`
///   Indirect: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `RecordingDebugRenderer`
typedef struct JPH_DebugRendererSimple JPH_DebugRendererSimple;

/// Singleton instance
/// Returns a pointer to a member variable of class `JPH::DebugRendererSimple` named `sInstance`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_DebugRenderer *const *JPH_DebugRendererSimple_Get_sInstance(void);

/// Singleton instance
/// Modifies a member variable of class `JPH::DebugRendererSimple` named `sInstance`.
/// The reference to the parameter `value` might be preserved in this object in element `sInstance`.
/// When this function is called, this object will drop object references it held previously in `sInstance`.
JOLT_API void JPH_DebugRendererSimple_Set_sInstance(JPH_DebugRenderer *value);

/// Singleton instance
/// Returns a mutable pointer to a member variable of class `JPH::DebugRendererSimple` named `sInstance`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_DebugRenderer **JPH_DebugRendererSimple_GetMutable_sInstance(void);

/// Destroys a heap-allocated instance of `JPH_DebugRendererSimple`. Does nothing if the pointer is null.
JOLT_API void JPH_DebugRendererSimple_Destroy(const JPH_DebugRendererSimple *_this);

/// Destroys a heap-allocated array of `JPH_DebugRendererSimple`. Does nothing if the pointer is null.
JOLT_API void JPH_DebugRendererSimple_DestroyArray(const JPH_DebugRendererSimple *_this);

/// Generated from method `JPH::DebugRendererSimple::operator new`.
JOLT_API void *Jolt_new_JPH_DebugRendererSimple_size_t(size_t inCount);

/// Generated from method `JPH::DebugRendererSimple::operator delete`.
JOLT_API void Jolt_delete_JPH_DebugRendererSimple_void_ptr(void *inPointer);

/// Generated from method `JPH::DebugRendererSimple::operator delete`.
JOLT_API void Jolt_delete_JPH_DebugRendererSimple_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::DebugRendererSimple::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DebugRendererSimple_size_t(size_t inCount);

/// Generated from method `JPH::DebugRendererSimple::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DebugRendererSimple_void_ptr(void *inPointer);

/// Generated from method `JPH::DebugRendererSimple::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DebugRendererSimple_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::DebugRendererSimple::operator new`.
JOLT_API void *Jolt_new_JPH_DebugRendererSimple_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::DebugRendererSimple::operator delete`.
JOLT_API void Jolt_delete_JPH_DebugRendererSimple_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::DebugRendererSimple::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_DebugRendererSimple_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::DebugRendererSimple::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_DebugRendererSimple_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Should be called every frame by the application to provide the camera position.
/// This is used to determine the correct LOD for rendering.
/// Generated from method `JPH::DebugRendererSimple::SetCameraPos`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCameraPos` can not be null. It is a single object.
JOLT_API void JPH_DebugRendererSimple_SetCameraPos(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inCameraPos);

/// Fallback implementation that uses DrawLine to draw a triangle (override this if you have a version that renders solid triangles)
/// Generated from method `JPH::DebugRendererSimple::DrawTriangle`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Parameter `inV3` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_DebugRendererSimple_DrawTriangle(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor, JPH_DebugRenderer_ECastShadow inCastShadow);

/// Call once after frame is complete. Releases unused dynamically generated geometry assets.
/// Generated from method `JPH::DebugRendererSimple::NextFrame`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_DebugRendererSimple_NextFrame(JPH_DebugRendererSimple *_this);

/// Draw line
/// Generated from method `JPH::DebugRendererSimple::DrawLine`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inFrom` can not be null. It is a single object.
/// Parameter `inTo` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_DebugRendererSimple_DrawLine(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inFrom, const JPH_Vec3 *inTo, const JPH_Color *inColor);

/// Draw a marker on a position
/// Generated from method `JPH::DebugRendererSimple::DrawMarker`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPosition` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_DebugRendererSimple_DrawMarker(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inPosition, const JPH_Color *inColor, float inSize);

/// Draw an arrow
/// Generated from method `JPH::DebugRendererSimple::DrawArrow`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inFrom` can not be null. It is a single object.
/// Parameter `inTo` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_DebugRendererSimple_DrawArrow(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inFrom, const JPH_Vec3 *inTo, const JPH_Color *inColor, float inSize);

/// Draw coordinate system (3 arrows, x = red, y = green, z = blue)
/// Generated from method `JPH::DebugRendererSimple::DrawCoordinateSystem`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTransform` can not be null. It is a single object.
/// Parameter `inSize` has a default argument: `1.0f`, pass a null pointer to use it.
JOLT_API void JPH_DebugRendererSimple_DrawCoordinateSystem(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inTransform, const float *inSize);

/// Draw a plane through inPoint with normal inNormal
/// Generated from method `JPH::DebugRendererSimple::DrawPlane`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inPoint` can not be null. It is a single object.
/// Parameter `inNormal` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_DebugRendererSimple_DrawPlane(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inPoint, const JPH_Vec3 *inNormal, const JPH_Color *inColor, float inSize);

/// Draw wireframe triangle
/// Generated from method `JPH::DebugRendererSimple::DrawWireTriangle`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inV1` can not be null. It is a single object.
/// Parameter `inV2` can not be null. It is a single object.
/// Parameter `inV3` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
JOLT_API void JPH_DebugRendererSimple_DrawWireTriangle(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor);

/// Draw wireframe sphere
/// Generated from method `JPH::DebugRendererSimple::DrawWireSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenter` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inLevel` has a default argument: `3`, pass a null pointer to use it.
JOLT_API void JPH_DebugRendererSimple_DrawWireSphere(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Color *inColor, const int *inLevel);

/// Generated from method `JPH::DebugRendererSimple::DrawWireUnitSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inLevel` has a default argument: `3`, pass a null pointer to use it.
JOLT_API void JPH_DebugRendererSimple_DrawWireUnitSphere(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inMatrix, const JPH_Color *inColor, const int *inLevel);

/// Draw a sphere
/// Generated from method `JPH::DebugRendererSimple::DrawSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenter` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRendererSimple_DrawSphere(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Generated from method `JPH::DebugRendererSimple::DrawUnitSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRendererSimple_DrawUnitSphere(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inMatrix, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draw a capsule with one half sphere at (0, -inHalfHeightOfCylinder, 0) and the other half sphere at (0, inHalfHeightOfCylinder, 0) and radius inRadius.
/// The capsule will be transformed by inMatrix.
/// Generated from method `JPH::DebugRendererSimple::DrawCapsule`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRendererSimple_DrawCapsule(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inMatrix, float inHalfHeightOfCylinder, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draw a cylinder with top (0, inHalfHeight, 0) and bottom (0, -inHalfHeight, 0) and radius inRadius.
/// The cylinder will be transformed by inMatrix
/// Generated from method `JPH::DebugRendererSimple::DrawCylinder`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRendererSimple_DrawCylinder(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inMatrix, float inHalfHeight, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draw a bottomless cone.
/// @param inTop Top of cone, center of base is at inTop + inAxis.
/// @param inAxis Height and direction of cone
/// @param inPerpendicular Perpendicular vector to inAxis.
/// @param inHalfAngle Specifies the cone angle in radians (angle measured between inAxis and cone surface).
/// @param inLength The length of the cone.
/// @param inColor Color to use for drawing the cone.
/// @param inCastShadow determines if this geometry should cast a shadow or not.
/// @param inDrawMode determines if we draw the geometry solid or in wireframe.
/// Generated from method `JPH::DebugRendererSimple::DrawOpenCone`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inTop` can not be null. It is a single object.
/// Parameter `inAxis` can not be null. It is a single object.
/// Parameter `inPerpendicular` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRendererSimple_DrawOpenCone(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inTop, const JPH_Vec3 *inAxis, const JPH_Vec3 *inPerpendicular, float inHalfAngle, float inLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draws cone rotation limits as used by the SwingTwistConstraintPart.
/// @param inMatrix Matrix that transforms from constraint space to world space
/// @param inSwingYHalfAngle See SwingTwistConstraintPart
/// @param inSwingZHalfAngle See SwingTwistConstraintPart
/// @param inEdgeLength Size of the edge of the cone shape
/// @param inColor Color to use for drawing the cone.
/// @param inCastShadow determines if this geometry should cast a shadow or not.
/// @param inDrawMode determines if we draw the geometry solid or in wireframe.
/// Generated from method `JPH::DebugRendererSimple::DrawSwingConeLimits`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRendererSimple_DrawSwingConeLimits(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inMatrix, float inSwingYHalfAngle, float inSwingZHalfAngle, float inEdgeLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

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
/// Generated from method `JPH::DebugRendererSimple::DrawSwingPyramidLimits`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRendererSimple_DrawSwingPyramidLimits(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inMatrix, float inMinSwingYAngle, float inMaxSwingYAngle, float inMinSwingZAngle, float inMaxSwingZAngle, float inEdgeLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

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
/// Generated from method `JPH::DebugRendererSimple::DrawPie`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inCenter` can not be null. It is a single object.
/// Parameter `inNormal` can not be null. It is a single object.
/// Parameter `inAxis` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRendererSimple_DrawPie(JPH_DebugRendererSimple *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Vec3 *inNormal, const JPH_Vec3 *inAxis, float inMinAngle, float inMaxAngle, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Draw a tapered cylinder
/// @param inMatrix Matrix that transforms the cylinder to world space.
/// @param inTop Top of cylinder (along Y axis)
/// @param inBottom Bottom of cylinder (along Y axis)
/// @param inTopRadius Radius at the top
/// @param inBottomRadius Radius at the bottom
/// @param inColor Color to use for drawing the pie.
/// @param inCastShadow determines if this geometry should cast a shadow or not.
/// @param inDrawMode determines if we draw the geometry solid or in wireframe.
/// Generated from method `JPH::DebugRendererSimple::DrawTaperedCylinder`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inMatrix` can not be null. It is a single object.
/// Parameter `inColor` can not be null. It is a single object.
/// Parameter `inCastShadow` has a default argument: `ECastShadow::On`, pass a null pointer to use it.
/// Parameter `inDrawMode` has a default argument: `EDrawMode::Solid`, pass a null pointer to use it.
JOLT_API void JPH_DebugRendererSimple_DrawTaperedCylinder(JPH_DebugRendererSimple *_this, const JPH_Mat44 *inMatrix, float inTop, float inBottom, float inTopRadius, float inBottomRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode);

/// Calculate bounding box for a batch of triangles
/// Generated from method `JPH::DebugRendererSimple::sCalculateBounds`.
/// Never returns null. Returns an instance allocated on the heap! Must call `JPH_AABox_Destroy()` to free it when you're done using it.
JOLT_API JPH_AABox *JPH_DebugRendererSimple_sCalculateBounds(const JPH_DebugRenderer_Vertex *inVertices, int inVertexCount);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_DebugRendererSimple *JPH_DebugRendererSimple_OffsetPtr(const JPH_DebugRendererSimple *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_DebugRendererSimple *JPH_DebugRendererSimple_OffsetMutablePtr(JPH_DebugRendererSimple *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::DebugRendererSimple` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_DebugRendererSimple_UpcastTo_JPH_NonCopyable(const JPH_DebugRendererSimple *object);

/// Upcasts an instance of `JPH::DebugRendererSimple` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_DebugRendererSimple_MutableUpcastTo_JPH_NonCopyable(JPH_DebugRendererSimple *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::DebugRendererSimple`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DebugRendererSimple *JPH_DebugRendererSimple_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::DebugRendererSimple`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DebugRendererSimple *JPH_DebugRendererSimple_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

/// Upcasts an instance of `JPH::DebugRendererSimple` to its base class `JPH::DebugRenderer`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DebugRenderer *JPH_DebugRendererSimple_UpcastTo_JPH_DebugRenderer(const JPH_DebugRendererSimple *object);

/// Upcasts an instance of `JPH::DebugRendererSimple` to its base class `JPH::DebugRenderer`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DebugRenderer *JPH_DebugRendererSimple_MutableUpcastTo_JPH_DebugRenderer(JPH_DebugRendererSimple *object);

/// Downcasts an instance of `JPH::DebugRenderer` to a derived class `JPH::DebugRendererSimple`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_DebugRendererSimple *JPH_DebugRendererSimple_StaticDowncastFrom_JPH_DebugRenderer(const JPH_DebugRenderer *object);

/// Downcasts an instance of `JPH::DebugRenderer` to a derived class `JPH::DebugRendererSimple`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_DebugRendererSimple *JPH_DebugRendererSimple_MutableStaticDowncastFrom_JPH_DebugRenderer(JPH_DebugRenderer *object);

#ifdef __cplusplus
} // extern "C"
#endif
