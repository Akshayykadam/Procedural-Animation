using System;
using UnityEngine;

// Abstract class representing a base state
public abstract class BaseState<Estate> where Estate : Enum
{
    // Constructor to initialize the state key
    public BaseState(Estate key)
    {
        StateKey = key;
    }

    // Property to get the state key
    public Estate StateKey { get; private set; }

    // Abstract methods to be implemented by derived classes
    public abstract void EnterState(); // Method to enter the state
    public abstract void ExitState(); // Method to exit the state
    public abstract void UpdateState(); // Method to update the state
    public abstract Estate GetNextState(); // Method to get the next state
    public abstract void OnTriggerEnter(Collider other); // Method called when a collider enters the trigger collider of the GameObject
    public abstract void OnTriggerStay(Collider other); // Method called while a collider is inside the trigger collider of the GameObject
    public abstract void OnTriggerExit(Collider other); // Method called when a collider exits the trigger collider of the GameObject
}
