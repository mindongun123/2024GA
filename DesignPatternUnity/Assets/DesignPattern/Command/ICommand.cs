using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICommand
{
    public object Item;
    public virtual void Excute() { }
}

[Serializable]
public struct ItemCommand
{
    public string _name;
    public ItemCommand(string _name)
    {
        this._name = _name;
    }
}
