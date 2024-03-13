using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonExample : MonoBehaviour
{
    public class ObjectA : SingletonComponent<ObjectA>
    {
        public void ShowNameObjectB()
        {
            SingletonComponent<ObjectB>.Instance.GetNameB();
        }
    }

    public class ObjectB : SingletonComponent<ObjectB>
    {
        public void GetNameB()
        {
            Debug.Log(this.gameObject.name);
        }
    }
}
