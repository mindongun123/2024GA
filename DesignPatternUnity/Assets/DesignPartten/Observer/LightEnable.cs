using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightEnable : MonoBehaviour, IObserver
{
    private void Start()
    {
        SingletonComponent<ControllerObserver>.Instance.Register(this);
    }
    public void EnableObserver()
    {
        Debug.Log("Observer Light Enable");
    }
}
