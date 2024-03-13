using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MJGame.TestCommand
{
    public class ViewCommand : MonoBehaviour
    {
        public CommandExcute commandExcute;
        public CommandUndo commandUndo;
        public ObjectCommand objectCommand;

        private void Start()
        {
            objectCommand = new ObjectCommand();
            commandExcute = new CommandExcute(objectCommand);
            commandUndo = new CommandUndo(objectCommand);

        }

        [ContextMenu("Undo")]
        public void OnClickUndo()

        {
            commandUndo.Undo();
        }
        [ContextMenu("Excute")]
        public void OnClickExcute()
        {
            commandExcute.Excute();
        }

    }
}