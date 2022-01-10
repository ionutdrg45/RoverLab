using Rover.Model;
using System.Collections.Generic;

namespace Rover
{
    public class Rover
    {
        public int Number { get; set; }
        public int Y { get; set; }
        public int X { get; set; }
        public Direction AngleTo { get; set; }
        public List<Command> Commands { get; set; }

    }
}
