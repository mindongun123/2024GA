using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CommandGame : MonoBehaviour
{
    private void Awake()
    {
        SingletonComponent<CommandController>.Instance.Resgister("coin", typeof(ItemPush));
    }
}
