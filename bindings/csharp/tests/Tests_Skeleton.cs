// Tests for Jolt Skeleton, SkeletalAnimation, SkeletonPose, and SkeletonMapper bindings.
// Note: AddJoint/GetJointIndex use std::string_view and are not exposed — tests that
// require a populated skeleton use SetSkeleton on an empty Skeleton to verify resizing.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_Skeleton
{
    // -------------------------------------------------------------------------
    // Skeleton
    // -------------------------------------------------------------------------

    [Fact]
    public void Skeleton_DefaultConstruct_JointCountZero()
    {
        using var s = new JPH.Skeleton();
        Assert.Equal(0, s.GetJointCount());
    }

    [Fact]
    public void Skeleton_AreJointsCorrectlyOrdered_EmptySkeleton_ReturnsTrue()
    {
        using var s = new JPH.Skeleton();
        Assert.True(s.AreJointsCorrectlyOrdered());
    }

    [Fact]
    public void Skeleton_CalculateParentJointIndices_EmptySkeleton_DoesNotThrow()
    {
        using var s = new JPH.Skeleton();
        s.CalculateParentJointIndices(); // should be a no-op on empty skeleton
    }

    [Fact]
    public void Skeleton_Joint_DefaultParentIndex_IsMinusOne()
    {
        using var joint = new JPH.Skeleton.Joint();
        Assert.Equal(-1, joint.mParentJointIndex);
    }

    [Fact]
    public void Skeleton_Joint_SetParentIndex_RoundTrips()
    {
        using var joint = new JPH.Skeleton.Joint();
        joint.mParentJointIndex = 3;
        Assert.Equal(3, joint.mParentJointIndex);
    }

    // -------------------------------------------------------------------------
    // SkeletalAnimation
    // -------------------------------------------------------------------------

    [Fact]
    public void SkeletalAnimation_DefaultIsLooping_True()
    {
        using var anim = new JPH.SkeletalAnimation();
        Assert.True(anim.IsLooping());
    }

    [Fact]
    public void SkeletalAnimation_SetIsLooping_False_RoundTrips()
    {
        using var anim = new JPH.SkeletalAnimation();
        anim.SetIsLooping(false);
        Assert.False(anim.IsLooping());
    }

    [Fact]
    public void SkeletalAnimation_SetIsLooping_True_RoundTrips()
    {
        using var anim = new JPH.SkeletalAnimation();
        anim.SetIsLooping(false);
        anim.SetIsLooping(true);
        Assert.True(anim.IsLooping());
    }

    [Fact]
    public void SkeletalAnimation_GetDuration_EmptyAnimation_ReturnsZero()
    {
        using var anim = new JPH.SkeletalAnimation();
        Assert.Equal(0f, anim.GetDuration());
    }

    // -------------------------------------------------------------------------
    // JointState
    // -------------------------------------------------------------------------

    [Fact]
    public void JointState_DefaultRotation_IsIdentity()
    {
        using var js = new JPH.SkeletalAnimation.JointState();
        using var rot = js.mRotation;
        using var identity = JPH.Quat.SIdentity();
        Assert.Equal(identity.GetX(), rot.GetX(), precision: 5);
        Assert.Equal(identity.GetY(), rot.GetY(), precision: 5);
        Assert.Equal(identity.GetZ(), rot.GetZ(), precision: 5);
        Assert.Equal(identity.GetW(), rot.GetW(), precision: 5);
    }

    [Fact]
    public void JointState_DefaultTranslation_IsZero()
    {
        using var js = new JPH.SkeletalAnimation.JointState();
        using var t = js.mTranslation;
        Assert.Equal(0f, t.GetX(), precision: 5);
        Assert.Equal(0f, t.GetY(), precision: 5);
        Assert.Equal(0f, t.GetZ(), precision: 5);
    }

    [Fact]
    public void JointState_ToMatrix_DefaultState_IsIdentity()
    {
        using var js = new JPH.SkeletalAnimation.JointState();
        using var m = js.ToMatrix();
        // Identity: column0=(1,0,0), column1=(0,1,0), column2=(0,0,1)
        using var c0 = m.GetColumn3(0);
        using var c1 = m.GetColumn3(1);
        using var c2 = m.GetColumn3(2);
        Assert.Equal(1f, c0.GetX(), precision: 5);
        Assert.Equal(0f, c0.GetY(), precision: 5);
        Assert.Equal(1f, c1.GetY(), precision: 5);
        Assert.Equal(0f, c1.GetZ(), precision: 5);
        Assert.Equal(1f, c2.GetZ(), precision: 5);
    }

    [Fact]
    public void JointState_FromMatrix_IdentityMatrix_LeavesDefaultState()
    {
        using var js = new JPH.SkeletalAnimation.JointState();
        using var identity = JPH.Mat44.SIdentity();
        js.FromMatrix((JPH.Const_Mat44)identity);
        using var t = js.mTranslation;
        Assert.Equal(0f, t.GetX(), precision: 5);
        Assert.Equal(0f, t.GetY(), precision: 5);
        Assert.Equal(0f, t.GetZ(), precision: 5);
    }

    // -------------------------------------------------------------------------
    // Keyframe
    // -------------------------------------------------------------------------

    [Fact]
    public void Keyframe_DefaultTime_IsZero()
    {
        using var kf = new JPH.SkeletalAnimation.Keyframe();
        Assert.Equal(0f, kf.mTime);
    }

    [Fact]
    public void Keyframe_SetTime_RoundTrips()
    {
        using var kf = new JPH.SkeletalAnimation.Keyframe();
        kf.mTime = 1.5f;
        Assert.Equal(1.5f, kf.mTime, precision: 5);
    }

    [Fact]
    public void Keyframe_ToMatrix_DefaultState_IsIdentity()
    {
        using var kf = new JPH.SkeletalAnimation.Keyframe();
        using var m = kf.ToMatrix();
        using var c0 = m.GetColumn3(0);
        using var c1 = m.GetColumn3(1);
        using var c2 = m.GetColumn3(2);
        Assert.Equal(1f, c0.GetX(), precision: 5);
        Assert.Equal(1f, c1.GetY(), precision: 5);
        Assert.Equal(1f, c2.GetZ(), precision: 5);
    }

    // -------------------------------------------------------------------------
    // SkeletonPose
    // -------------------------------------------------------------------------

    [Fact]
    public void SkeletonPose_DefaultConstruct_SkeletonIsNull()
    {
        using var pose = new JPH.SkeletonPose();
        Assert.Null(pose.GetSkeleton());
    }

    [Fact]
    public void SkeletonPose_SetSkeleton_RoundTrips()
    {
        using var skeleton = new JPH.Skeleton();
        using var pose = new JPH.SkeletonPose();
        pose.SetSkeleton((JPH.Const_Skeleton)skeleton);
        Assert.NotNull(pose.GetSkeleton());
    }

    [Fact]
    public void SkeletonPose_SetSkeleton_JointCountMatchesSkeleton()
    {
        using var skeleton = new JPH.Skeleton(); // 0 joints
        using var pose = new JPH.SkeletonPose();
        pose.SetSkeleton((JPH.Const_Skeleton)skeleton);
        Assert.Equal((uint)skeleton.GetJointCount(), pose.GetJointCount());
    }

    [Fact]
    public void SkeletonPose_SetNullSkeleton_JointCountZero()
    {
        using var pose = new JPH.SkeletonPose();
        pose.SetSkeleton(null);
        Assert.Equal(0u, pose.GetJointCount());
    }

    [Fact]
    public void SkeletonPose_DefaultRootOffset_IsZero()
    {
        using var pose = new JPH.SkeletonPose();
        using var offset = pose.GetRootOffset();
        Assert.Equal(0f, offset.GetX(), precision: 5);
        Assert.Equal(0f, offset.GetY(), precision: 5);
        Assert.Equal(0f, offset.GetZ(), precision: 5);
    }

    [Fact]
    public void SkeletonPose_SetRootOffset_RoundTrips()
    {
        using var pose = new JPH.SkeletonPose();
        using var v = new JPH.Vec3(1f, 2f, 3f);
        pose.SetRootOffset((JPH.Const_Vec3)v);
        using var result = pose.GetRootOffset();
        Assert.Equal(1f, result.GetX(), precision: 5);
        Assert.Equal(2f, result.GetY(), precision: 5);
        Assert.Equal(3f, result.GetZ(), precision: 5);
    }

    // -------------------------------------------------------------------------
    // SkeletonPose::DrawSettings
    // -------------------------------------------------------------------------

    [Fact]
    public void DrawSettings_DefaultDrawJoints_True()
    {
        using var ds = new JPH.SkeletonPose.DrawSettings();
        Assert.True(ds.mDrawJoints);
    }

    [Fact]
    public void DrawSettings_DefaultDrawJointOrientations_True()
    {
        using var ds = new JPH.SkeletonPose.DrawSettings();
        Assert.True(ds.mDrawJointOrientations);
    }

    [Fact]
    public void DrawSettings_DefaultDrawJointNames_False()
    {
        using var ds = new JPH.SkeletonPose.DrawSettings();
        Assert.False(ds.mDrawJointNames);
    }

    [Fact]
    public void DrawSettings_SetValues_RoundTrip()
    {
        using var ds = new JPH.SkeletonPose.DrawSettings(
            mDrawJoints: false, mDrawJointOrientations: false, mDrawJointNames: true);
        Assert.False(ds.mDrawJoints);
        Assert.False(ds.mDrawJointOrientations);
        Assert.True(ds.mDrawJointNames);
    }

    // -------------------------------------------------------------------------
    // SkeletonMapper
    // -------------------------------------------------------------------------

    [Fact]
    public void SkeletonMapper_DefaultConstruct_DoesNotThrow()
    {
        using var mapper = new JPH.SkeletonMapper();
        Assert.NotNull(mapper);
    }

    [Fact]
    public void SkeletonMapper_GetMappedJointIdx_EmptyMapper_ReturnsMinusOne()
    {
        using var mapper = new JPH.SkeletonMapper();
        Assert.Equal(-1, mapper.GetMappedJointIdx(0));
    }

    [Fact]
    public void SkeletonMapper_IsJointTranslationLocked_EmptyMapper_ReturnsFalse()
    {
        using var mapper = new JPH.SkeletonMapper();
        Assert.False(mapper.IsJointTranslationLocked(0));
    }

    [Fact]
    public void SkeletonMapper_Mapping_DefaultFields_AreZero()
    {
        using var m = new JPH.SkeletonMapper.Mapping();
        Assert.Equal(0, m.mJointIdx1);
        Assert.Equal(0, m.mJointIdx2);
    }

    [Fact]
    public void SkeletonMapper_Unmapped_ConstructWithIndices_RoundTrips()
    {
        using var u = new JPH.SkeletonMapper.Unmapped(inJointIdx: 5, inParentJointIdx: 2);
        Assert.Equal(5, u.mJointIdx);
        Assert.Equal(2, u.mParentJointIdx);
    }

    [Fact]
    public void SkeletonMapper_Locked_DefaultFields_AreZero()
    {
        using var lk = new JPH.SkeletonMapper.Locked();
        Assert.Equal(0, lk.mJointIdx);
        Assert.Equal(0, lk.mParentJointIdx);
    }
}
