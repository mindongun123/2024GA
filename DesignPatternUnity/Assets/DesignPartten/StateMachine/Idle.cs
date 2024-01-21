using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : StateMachine
{
    public Idle(Character kCharacter) : base(kCharacter)
    {
    }

    public override void EnterState()
    {
        base.EnterState();
        Debug.Log("Idle Enter");
    }
    public override void ExitState()
    {
        base.ExitState();
        Debug.Log("Idle Exit");
    }

    public override void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //attack 
            character.ChangeState(new Attack(character));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            //die
            character.ChangeState(new Die(character));
        }
    }

}
