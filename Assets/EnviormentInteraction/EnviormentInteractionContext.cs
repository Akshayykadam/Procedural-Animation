using UnityEngine;
using UnityEngine.Animations.Rigging;

// Class representing the context for environmental interaction
public class EnviormentInteractionContext : MonoBehaviour
{
    // Fields to hold references to constraints, Rigidbody, and Collider
    private TwoBoneIKConstraint _LeftIkConstraint;
    private TwoBoneIKConstraint _RightIkConstraint;

    private MultiRotationConstraint _LeftMultiRotationConstraint;
    private MultiRotationConstraint _RightMultiRotationConstraint;

    private Rigidbody _Rigidbody;
    private CapsuleCollider _RootCollider;

    // Constructor to initialize the context with provided components
    public EnviormentInteractionContext(TwoBoneIKConstraint LeftIkConstraint, TwoBoneIKConstraint RightIkConstraint,
        MultiRotationConstraint LeftMultiRotationConstraint, MultiRotationConstraint RightMultiRotationConstraint,
        Rigidbody Rigidbody, CapsuleCollider RootCollider)
    {
        // Assign the provided components to the corresponding fields
        _LeftIkConstraint = LeftIkConstraint;
        _RightIkConstraint = RightIkConstraint;

        _LeftMultiRotationConstraint = LeftMultiRotationConstraint;
        _RightMultiRotationConstraint = RightMultiRotationConstraint;

        _Rigidbody = Rigidbody;
        _RootCollider = RootCollider;
    }

    // Read-only properties to access the components
    public TwoBoneIKConstraint LeftIkConstraint => _LeftIkConstraint;
    public TwoBoneIKConstraint RightIkConstraint => _RightIkConstraint;

    public MultiRotationConstraint LeftMultiRotationConstraint => _LeftMultiRotationConstraint;
    public MultiRotationConstraint RightMultiRotationConstraint => _RightMultiRotationConstraint;

    public Rigidbody Rb => _Rigidbody;
    public CapsuleCollider RootCollider => _RootCollider;
}
