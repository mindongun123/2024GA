using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    StateMachine stateCurrent;

    private void Awake()
    {
        ChangeState(new Idle(this));
    }
    private void Update()
    {
        stateCurrent.UpdateState();
    }

    public void ChangeState(StateMachine state)
    {
        if (stateCurrent != null)
        {
            stateCurrent.ExitState();
        }
        stateCurrent = state;
        stateCurrent.EnterState();
    }
}
