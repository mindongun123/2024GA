using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAppFacebook : MonoBehaviour
{
    private void OnEnable()
    {
        ActionGame.actionOpenComputer += OpenApp;
    }
    private void OnDisable()
    {
        ActionGame.actionOpenComputer -= OpenApp;
    }

    public void OpenApp()
    {
        Debug.Log("Discord Facebook Open");
    }
}
