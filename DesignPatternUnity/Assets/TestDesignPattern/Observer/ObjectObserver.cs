using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MJGame.TestObserver
{
    public class ObjectObserver : MonoBehaviour
    {
        private void OnEnable()
        {
            ActionObserver.addCoint += AddObserverCoin;
        }
        private void OnDisable()
        {
            ActionObserver.addCoint -= AddObserverCoin;
        }
        public void AddObserverCoin()
        {
            Debug.Log(" Nhan coin");
        }
    }
}