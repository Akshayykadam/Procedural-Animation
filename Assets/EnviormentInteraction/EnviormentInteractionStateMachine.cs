using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.Assertions; // Import Unity Assertions

// Concrete class representing the state machine for environmental interaction
public class EnviormentInteractionStateMachine : StateManager<EnviormentInteractionStateMachine.EEnviormentInteractionState>
{
    // Enum defining the possible states for environmental interaction
    public enum EEnviormentInteractionState
    {
        Search,
        Approrch,
        Rise,
        Touch,
        Reset,
    }

    // Serialized fields for IK constraints, rotation constraints, Rigidbody, and Collider
    [SerializeField] private TwoBoneIKConstraint _LeftIkConstraint;
    [SerializeField] private TwoBoneIKConstraint _RightIkConstraint;

    [SerializeField] private MultiRotationConstraint _LeftMultiRotationConstraint;
    [SerializeField] private MultiRotationConstraint _RightMultiRotationConstraint;

    [SerializeField] private Rigidbody _Rigidbody;
    [SerializeField] private CapsuleCollider _RootCollider;

    // Object holding the context for environmental interaction
    private EnviormentInteractionContext _Context;

    // Awake method called when the script instance is being loaded
    private void Awake()
    {
        // Validate constraints to ensure they are assigned
        ValidateConstraints();

        // Create the interaction context using the constraints and Rigidbody/Collider
        _Context = new EnviormentInteractionContext(_LeftIkConstraint, _RightIkConstraint, _LeftMultiRotationConstraint, _RightMultiRotationConstraint, _Rigidbody, _RootCollider);

        // Initialize the state machine
        InitializeState();
    }

    // Method to validate that all required constraints are assigned
    private void ValidateConstraints()
    {
        // Use Unity's Assert class to ensure that the constraints are assigned
        Assert.IsNotNull(_LeftIkConstraint, "Left Ik Constraint is Not Assigned");
        Assert.IsNotNull(_RightIkConstraint, "Left Ik Constraint is Not Assigned");

        Assert.IsNotNull(_LeftMultiRotationConstraint, "Left Multi Rotation Constraint is Not Assigned");
        Assert.IsNotNull(_RightMultiRotationConstraint, "Right Multi Rotation Constraint is Not Assigned");

        Assert.IsNotNull(_Rigidbody, "Rigidbody is Not Assigned");
        Assert.IsNotNull(_RootCollider, "Root Collider is Not Assigned");
    }

    // Method to initialize the states
    private void InitializeState()
    {
        // Add states to the inherited StateManager "States" dictionary and set initial state
        States.Add(EEnviormentInteractionState.Reset, new ResetState(_Context, EEnviormentInteractionState.Reset));
        States.Add(EEnviormentInteractionState.Search, new ResetState(_Context, EEnviormentInteractionState.Search));
        States.Add(EEnviormentInteractionState.Approrch, new ResetState(_Context, EEnviormentInteractionState.Approrch));
        States.Add(EEnviormentInteractionState.Rise, new ResetState(_Context, EEnviormentInteractionState.Rise));
        States.Add(EEnviormentInteractionState.Touch, new ResetState(_Context, EEnviormentInteractionState.Touch));

        // Set the current state to the "Reset" state
        CurrentState = States[EEnviormentInteractionState.Reset];
    }
}
