using System;
using System.Collections.Generic;
using UnityEngine;

// Abstract class for managing states
public abstract class StateManager<Estate> : MonoBehaviour where Estate : Enum
{
    // Dictionary to hold states and their corresponding keys
    protected Dictionary<Estate, BaseState<Estate>> States = new Dictionary<Estate, BaseState<Estate>>();

    // Current state and flag to check if transitioning state
    protected BaseState<Estate> CurrentState;
    protected bool IsTransitioningState = false;

    // Start method called when the script is enabled
    void Start()
    {
        // Enter the initial state
        CurrentState.EnterState();
    }

    // Update method called once per frame
    void Update()
    {
        // Get the key of the next state
        Estate NextStateKey = CurrentState.GetNextState();

        // If the next state is the same as the current state, update the current state
        if (NextStateKey.Equals(CurrentState.StateKey))
        {
            CurrentState.UpdateState();
        }
        // If not transitioning state and the next state is different, transition to the next state
        else if (!IsTransitioningState)
        {
            TransitionToState(NextStateKey);
        }
    }

    // Method to transition to a new state
    public void TransitionToState(Estate StateKey)
    {
        // Set transitioning flag to true
        IsTransitioningState = true;
        // Exit current state
        CurrentState.ExitState();
        // Set current state to the new state
        CurrentState = States[StateKey];
        // Enter new state
        CurrentState.EnterState();
        // Set transitioning flag to false
        IsTransitioningState = false;
    }

    // Method called when a collider enters this object's trigger collider
    void OnTriggerEnter(Collider other)
    {
        // Call OnTriggerEnter method of the current state
        CurrentState.OnTriggerEnter(other);
    }
    // Method called while a collider is inside this object's trigger collider
    void OnTriggerStay(Collider other)
    {
        // Call OnTriggerStay method of the current state
        CurrentState.OnTriggerStay(other);
    }
    // Method called when a collider exits this object's trigger collider
    void OnTriggerExit(Collider other)
    {
        // Call OnTriggerExit method of the current state
        CurrentState.OnTriggerExit(other);
    }
}
