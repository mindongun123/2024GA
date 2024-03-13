using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverAction : MonoBehaviour
{
    private void Start()
    {
        ActionGame.actionOpenComputer?.Invoke();
    }
}
