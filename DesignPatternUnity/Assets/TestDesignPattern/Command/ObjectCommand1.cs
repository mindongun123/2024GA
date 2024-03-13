using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;


namespace MJGame.TestCommand
{
    public class ObjectCommand
    {
        public void OnEx()
        {
            Debug.Log(" EX");
        }

        public void OnUndo()
        {
            Debug.Log(" UN");
        }
    }
}
