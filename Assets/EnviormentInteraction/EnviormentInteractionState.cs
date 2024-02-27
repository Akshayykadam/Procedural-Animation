using UnityEngine;

// Abstract class representing a state for environmental interaction
public abstract class EnviormentInteractionState : BaseState<EnviormentInteractionStateMachine.EEnviormentInteractionState>
{
    // Reference to the environmental interaction context
    protected EnviormentInteractionContext Context;

    // Constructor to initialize the state with its context and key
    public EnviormentInteractionState(EnviormentInteractionContext context, EnviormentInteractionStateMachine.EEnviormentInteractionState StateKey) : base(StateKey)
    {
        // Assign the context
        Context = context;
    }
}
