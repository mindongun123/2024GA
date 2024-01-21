using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void PushItemInBox(string _name)
    {
        SingletonComponent<CommandController>.Instance.GetCommand("coin", new ItemCommand(_name));
    }
}
