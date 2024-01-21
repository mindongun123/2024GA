using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : StateMachine
{
    public Attack(Character kCharacter) : base(kCharacter)
    {
    }
    public override void EnterState()
    {
        base.EnterState();
        Debug.Log("Attack Enter");
    }
    public override void ExitState()
    {
        base.ExitState();
        Debug.Log("Attack Exit");
    }

    public override void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            //idle 
            character.ChangeState(new Idle(character));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            //die
            character.ChangeState(new Die(character));
        }
    }

}
