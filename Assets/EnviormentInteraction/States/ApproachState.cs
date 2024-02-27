using UnityEngine;

// Represents the state where the character is approaching an object/environment
public class ApproachState : EnviormentInteractionState
{
    // Constructor to initialize the state with its context and key
    public ApproachState(EnviormentInteractionContext context, EnviormentInteractionStateMachine.EEnviormentInteractionState estate) : base(context, estate)
    {
        // Store the provided context in the base class
        EnviormentInteractionContext Context = context;
    }

    // Method called when entering this state
    public override void EnterState() { }

    // Method called when exiting this state
    public override void ExitState() { }

    // Method called to update the state logic
    public override void UpdateState() { }

    // Method called to determine the next state
    public override EnviormentInteractionStateMachine.EEnviormentInteractionState GetNextState()
    {
        return StateKey;
    }

    // Method called when a collider enters the trigger collider of the character
    public override void OnTriggerEnter(Collider other) { }

    // Method called while a collider is inside the trigger collider of the character
    public override void OnTriggerStay(Collider other) { }

    // Method called when a collider exits the trigger collider of the character
    public override void OnTriggerExit(Collider other) { }
}
