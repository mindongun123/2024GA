using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MJGame.TestStateMachine
{

[Serializable]

    public class ItemStateDie : State
    {
        public ItemStateDie(ObjectCharactor objectCharactor) : base(objectCharactor)
        {
        }

        public override void Enter()
        {
            base.Enter();
            Debug.Log("Die");
        }
        public override void Exit()
        {
            base.Exit();
        }

        public override void ChangeState()
        {

        }
    }
[Serializable]

    public class ItemStateAttack : State
    {
        public ItemStateAttack(ObjectCharactor objectCharactor) : base(objectCharactor)
        {
        }

        public override void Enter()
        {
            base.Enter();
            Debug.Log("Attack");
        }
        public override void Exit()
        {
            base.Exit();
        }

        public override void ChangeState()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                objectCharactor.UpdateChangeState(new ItemStateFly(objectCharactor));
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                objectCharactor.UpdateChangeState(new ItemStateRun(objectCharactor));
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                objectCharactor.UpdateChangeState(new ItemStateDie(objectCharactor));
            }
        }
    }
[Serializable]

    public class ItemStateRun : State
    {
        public ItemStateRun(ObjectCharactor objectCharactor) : base(objectCharactor)
        {
        }

        public override void Enter()
        {
            base.Enter();
            Debug.Log("Run");
        }
        public override void Exit()
        {
            base.Exit();
        }

        public override void ChangeState()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                objectCharactor.UpdateChangeState(new ItemStateDie(objectCharactor));
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                objectCharactor.UpdateChangeState(new ItemStateAttack(objectCharactor));
            }
        }
    }
[Serializable]

    public class ItemStateFly : State
    {
        public ItemStateFly(ObjectCharactor objectCharactor) : base(objectCharactor)
        {
        }

        public override void Enter()
        {
            base.Enter();
            Debug.Log("Fly");
        }
        public override void Exit()
        {
            base.Exit();
        }

        public override void ChangeState()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                objectCharactor.UpdateChangeState(new ItemStateDie(objectCharactor));
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                objectCharactor.UpdateChangeState(new ItemStateAttack(objectCharactor));
            }
        }
    }
}