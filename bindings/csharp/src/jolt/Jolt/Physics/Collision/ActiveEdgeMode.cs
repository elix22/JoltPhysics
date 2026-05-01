// machine generated, do not edit
public static partial class JPH
{
    /// How to treat active/inactive edges.
    /// An active edge is an edge that either has no neighbouring edge or if the angle between the two connecting faces is too large, see: ActiveEdges
    public enum EActiveEdgeMode : byte
    {
        ///< Do not collide with inactive edges. For physics simulation, this gives less ghost collisions.
        CollideOnlyWithActive = 0,
        ///< Collide with all edges. Use this when you're interested in all collisions.
        CollideWithAll = 1,
    }
}
