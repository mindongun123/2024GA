using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MJGame.TestObserver
{
    public class ViewObserver : MonoBehaviour
    {

        [ContextMenu("Action")]
        public void OnClickObserver()
        {
            ActionObserver.addCoint?.Invoke();
        }
    }

}