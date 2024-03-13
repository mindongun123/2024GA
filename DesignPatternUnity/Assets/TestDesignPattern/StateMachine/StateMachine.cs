using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MJGame.TestStateMachine
{
    [Serializable]
    public abstract class State
    {
        public ObjectCharactor objectCharactor;
        public State(ObjectCharactor objectCharactor)
        {
            this.objectCharactor = objectCharactor;
        }

        public virtual void Exit() { }

        public virtual void Enter() { }

        public abstract void ChangeState();
    }
}
