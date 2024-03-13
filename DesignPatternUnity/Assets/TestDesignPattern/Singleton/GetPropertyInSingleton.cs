using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VSCodeEditor;

namespace MJGame.TestSingleton
{
    public class GetPropertyInSingleton : MonoBehaviour
    {
        public string _name;
        private void Start()
        {
            _name = SingletonComponent.instance.GetName();
        }
    }
}