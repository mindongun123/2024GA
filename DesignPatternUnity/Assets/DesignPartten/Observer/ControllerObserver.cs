using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerObserver : SingletonComponent<ControllerObserver>
{
    List<IObserver> lsObserver;

    private void Start()
    {
        lsObserver = new List<IObserver>();
    }
    public void Register(IObserver observer)
    {
        lsObserver.Add(observer);
    }

    public void Unregister(IObserver observer)
    {
        lsObserver.Remove(observer);
    }


    [ContextMenu("Action Event")]
    public void WhenActionEvent()
    {
        foreach (var item in lsObserver)
        {
            item.EnableObserver();
        }
    }
}

public interface IObserver
{
    public void EnableObserver();
}
