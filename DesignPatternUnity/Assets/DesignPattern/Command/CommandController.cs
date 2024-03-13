using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandController : SingletonComponent<CommandController>
{
    public readonly Dictionary<string, Type> dicCommand = new Dictionary<string, Type>();

    public void Resgister(string _name, Type typeCommand)
    {
        if (!dicCommand.ContainsKey(_name))
        {
            dicCommand[_name] = typeCommand;
        }
    }
    public void Unregister(string _name)
    {
        dicCommand.Remove(_name);
    }
    public void GetCommand(string _name, object item)
    {
        ICommand icommand = (ICommand)Activator.CreateInstance(dicCommand[_name]);
        icommand.Excute();
    }
}
