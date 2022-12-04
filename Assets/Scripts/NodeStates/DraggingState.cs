using UnityEngine;

public class DraggingState : BaseState
{
    public override void EnterState(StateManager stateManager)
    {
        Debug.Log("Test dragging state");
    }

    public override void UpdateState(StateManager stateManager)
    {

    }

    public override void OnCollisionEnter(StateManager stateManager)
    {

    }
}
