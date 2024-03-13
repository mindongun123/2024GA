using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MJGame.TestCommand
{

    public abstract class ICommand
    {
        public abstract void Excute();
        public abstract void Undo();
    }


    public class CommandExcute : ICommand
    {
        public ObjectCommand objectCommand;
        public CommandExcute(ObjectCommand objectCommand)
        {
            this.objectCommand = objectCommand;
        }
        public override void Excute()
        {
            objectCommand.OnEx();
        }

        public override void Undo()
        {
            objectCommand.OnUndo();
        }
    }

    public class CommandUndo : ICommand
    {

        public ObjectCommand objectCommand;
        public CommandUndo(ObjectCommand objectCommand)
        {
            this.objectCommand = objectCommand;
        }
        public override void Excute()
        {
            objectCommand.OnEx();
        }

        public override void Undo()
        {
            objectCommand.OnUndo();
        }
    }
}
