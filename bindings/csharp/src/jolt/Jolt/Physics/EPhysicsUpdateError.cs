// machine generated, do not edit
public static partial class JPH
{
    /// Enum used by PhysicsSystem to report error conditions during the PhysicsSystem::Update call. This is a bit field, multiple errors can trigger in the same update.
    public enum EPhysicsUpdateError : uint
    {
        ///< No errors
        None = 0,
        ///< The manifold cache is full, this means that the total number of contacts between bodies is too high. Some contacts were ignored. Increase inMaxContactConstraints in PhysicsSystem::Init.
        ManifoldCacheFull = 1,
        ///< The body pair cache is full, this means that too many bodies contacted. Some contacts were ignored. Increase inMaxBodyPairs in PhysicsSystem::Init.
        BodyPairCacheFull = 2,
        ///< The contact constraints buffer is full. Some contacts were ignored. Increase inMaxContactConstraints in PhysicsSystem::Init.
        ContactConstraintsFull = 4,
    }
}
