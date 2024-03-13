using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : StateMachine
{
    public Die(Character kCharacter) : base(kCharacter)
    {
    }

    public override void EnterState()
    {
        base.EnterState();
        Debug.Log("Die Enter");
    }

    public override void UpdateState()
    {
    }
}
