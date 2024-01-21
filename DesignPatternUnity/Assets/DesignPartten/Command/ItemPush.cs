using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPush : ICommand
{
    public override void Excute()
    {
        base.Excute();

        var item = (ItemCommand)Item;

        ActionGame.actionPush?.Invoke(item._name);
    }
}
