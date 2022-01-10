using Rover.Model;
using System.Collections.Generic;

namespace Rover.Controller
{
    public class CommandController
    {
        public Command GetCommand(char value)
        {
            switch (value)
            {
                default:
                    return Command.L;
                case 'L':
                    return Command.L;
                case 'R':
                    return Command.R;
                case 'M':
                    return Command.M;
            }
        }

        public List<Command> GetCommands(string value)
        {
            var commandList = new List<Command>();

            var commands = value.ToCharArray();
            foreach (char com in commands)
            {
                commandList.Add(GetCommand(com));
            }
            return commandList;
        }
    }
}
