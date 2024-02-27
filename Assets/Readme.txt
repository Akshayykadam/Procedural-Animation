Environment Interaction State Machine

This project implements a state machine for managing environmental interactions within a Unity environment. The state machine allows the character to transition between different states based on its interaction with the environment.

Classes

EnviormentInteractionContext

- Description: Represents the context for environmental interaction, including constraints, Rigidbody, and Collider.
- Fields:
  - TwoBoneIKConstraint _LeftIkConstraint
  - TwoBoneIKConstraint _RightIkConstraint
  - MultiRotationConstraint _LeftMultiRotationConstraint
  - MultiRotationConstraint _RightMultiRotationConstraint
  - Rigidbody _Rigidbody
  - CapsuleCollider _RootCollider
- Methods:
  - public EnviormentInteractionContext(TwoBoneIKConstraint LeftIkConstraint, TwoBoneIKConstraint RightIkConstraint, MultiRotationConstraint LeftMultiRotationConstraint, MultiRotationConstraint RightMultilotationConstraint, Rigidbody Rigidbody, CapsuleCollider RootCollider)

EnviormentInteractionState

- Description: Abstract base class representing a state for environmental interaction.
- Fields:
  - protected EnviormentInteractionContext Context
- Methods:
  - public EnviormentInteractionState(EnviormentInteractionContext context, EnviormentInteractionStateMachine.EEnviormentInteractionState StateKey)
  - public abstract void EnterState()
  - public abstract void ExitState()
  - public abstract void UpdateState()
  - public abstract EnviormentInteractionStateMachine.EEnviormentInteractionState GetNextState()
  - public abstract void OnTriggerEnter(Collider other)
  - public abstract void OnTriggerStay(Collider other)
  - public abstract void OnTriggerExit(Collider other)

StateManager<Estate>

- Description: Abstract base class representing a state manager for environmental interaction.
- Fields:
  - protected Dictionary<Estate, BaseState<Estate>> States
  - protected BaseState<Estate> CurrentState
  - protected bool IsTransitioningState
- Methods:
  - public void TransitionToState(Estate StateKey)
  - void OnTriggerEnter(Collider other)
  - void OnTriggerStay(Collider other)
  - void OnTriggerExit(Collider other)

ApproachState

- Description: Represents the state where the character is approaching an object/environment.
- Methods:
  - public ApproachState(EnviormentInteractionContext context, EnviormentInteractionStateMachine.EEnviormentInteractionState estate)
  - public override void EnterState()
  - public override void ExitState()
  - public override void UpdateState()
  - public override EnviormentInteractionStateMachine.EEnviormentInteractionState GetNextState()
  - public override void OnTriggerEnter(Collider other)
  - public override void OnTriggerStay(Collider other)
  - public override void OnTriggerExit(Collider other)

ResetState

- Description: Represents the state where the character resets its interaction with the environment.
- Methods:
  - public ResetState(EnviormentInteractionContext context, EnviormentInteractionStateMachine.EEnviormentInteractionState estate)
  - public override void EnterState()
  - public override void ExitState()
  - public override void UpdateState()
  - public override EnviormentInteractionStateMachine.EEnviormentInteractionState GetNextState()
  - public override void OnTriggerEnter(Collider other)
  - public override void OnTriggerStay(Collider other)
  - public override void OnTriggerExit(Collider other)

RiseState

- Description: Represents the state where the character rises in the environment.
- Methods:
  - public RiseState(EnviormentInteractionContext context, EnviormentInteractionStateMachine.EEnviormentInteractionState estate)
  - public override void EnterState()
  - public override void ExitState()
  - public override void UpdateState()
  - public override EnviormentInteractionStateMachine.EEnviormentInteractionState GetNextState()
  - public override void OnTriggerEnter(Collider other)
  - public override void OnTriggerStay(Collider other)
  - public override void OnTriggerExit(Collider other)

SearchState

- Description: Represents the state where the character is searching the environment.
- Methods:
  - public SearchState(EnviormentInteractionContext context, EnviormentInteractionStateMachine.EEnviormentInteractionState estate)
  - public override void EnterState()
  - public override void ExitState()
  - public override void UpdateState()
  - public override EnviormentInteractionStateMachine.EEnviormentInteractionState GetNextState()
  - public override void OnTriggerEnter(Collider other)
  - public override void OnTriggerStay(Collider other)
  - public override void OnTriggerExit(Collider other)

TouchState

- Description: Represents the state where the character is touching an object/environment.
- Methods:
  - public TouchState(EnviormentInteractionContext context, EnviormentInteractionStateMachine.EEnviormentInteractionState estate)
  - public override void EnterState()
  - public override void ExitState()
  - public override void UpdateState()
  - public override EnviormentInteractionStateMachine.EEnviormentInteractionState GetNextState()
  - public override void OnTriggerEnter(Collider other)
  - public override void OnTriggerStay(Collider other)
  - public override void OnTriggerExit(Collider other)

Usage

To use the environment interaction state machine, you can inherit from the provided base classes and implement specific behavior for each state. Additionally, you can create an instance of EnviormentInteractionContext to represent the context of the interaction.
