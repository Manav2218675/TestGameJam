using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{

    BaseState currentState;

    DraggingState draggingState = new DraggingState();
    LinkingState linkingState = new LinkingState();

    // Start is called before the first frame update
    void Start()
    {
        currentState = draggingState;

        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
