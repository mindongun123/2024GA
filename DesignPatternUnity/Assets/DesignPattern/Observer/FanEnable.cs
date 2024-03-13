using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanEnable : MonoBehaviour, IObserver
{
    private void Start()
    {
        SingletonComponent<ControllerObserver>.Instance.Register(this);
    }
    public void EnableObserver()
    {
        Debug.Log("Observer Fan Enable");
    }

}
