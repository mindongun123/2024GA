using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public abstract class StateMachine
{
    // character dang hien thi trang thai
    public Character character;

    public StateMachine(Character kCharacter)
    {
        character = kCharacter;
    }

    // Cac buoc cua trang thai
    public virtual void EnterState()
    {
    }

    public virtual void ExitState()
    {
    }

    public abstract void UpdateState();
}
