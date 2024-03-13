using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MJGame.TestStateMachine
{
    public class ObjectCharactor : MonoBehaviour
    {
        public State state;

        private void Start()
        {
            state = new ItemStateRun(this);
        }

        private void Update()
        {
            state.ChangeState();
        }

        public void UpdateChangeState(State state)
        {
            if (this.state != null)
            {
                this.state.Exit();
            }
            this.state = state;
            this.state.Enter();
        }


    }

}
