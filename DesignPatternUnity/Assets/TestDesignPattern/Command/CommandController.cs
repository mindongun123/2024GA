using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MJGame.TestCommand
{

    public class CommandController : MonoBehaviour
    {

        public ICommand commandEx, commandUndo;

        public CommandController(ICommand commandEx, ICommand commandUndo)
        {
            this.commandEx = commandEx;
            this.commandUndo = commandUndo;
        }
        public void OnClickExcute()
        {
            commandEx.Excute();
        }

        public void OnClickUndo()
        {
            commandUndo.Undo();
        }
    }

}