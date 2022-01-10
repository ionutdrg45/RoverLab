using Rover.Model;
using System;

namespace Rover.Controller
{
    public class RoverController
    {
        public void RotateTo(Rover rover, Command command)
        {
            if (command == Command.L)
            {
                switch (rover.AngleTo)
                {
                    case Direction.N:
                        rover.AngleTo = Direction.V;
                        break;
                    case Direction.V:
                        rover.AngleTo = Direction.S;
                        break;
                    case Direction.S:
                        rover.AngleTo = Direction.E;
                        break;
                    case Direction.E:
                        rover.AngleTo = Direction.N;
                        break;
                }
            }
            else if (command == Command.R)
            {
                switch (rover.AngleTo)
                {
                    case Direction.N:
                        rover.AngleTo = Direction.E;
                        break;
                    case Direction.E:
                        rover.AngleTo = Direction.S;
                        break;
                    case Direction.S:
                        rover.AngleTo = Direction.V;
                        break;
                    case Direction.V:
                        rover.AngleTo = Direction.N;
                        break;
                }
            }
        }

        public void Move(Rover rover, int lines, int columns)
        {
            switch (rover.AngleTo)
            {
                case Direction.N:
                    if (rover.Y + 1 < lines) rover.Y++;
                    break;
                case Direction.E:
                    if (rover.X + 1 < columns) rover.X++;
                    break;
                case Direction.S:
                    if (rover.Y - 1 >= 0) rover.Y--;
                    break;
                case Direction.V:
                    if (rover.X - 1 >= 0) rover.X--;
                    break;
            }
        }

        public void MoveRover(Rover rover, int lines, int columns)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Rover #" + rover.Number + " start from (" + rover.X + ", " + rover.Y + ") and is oriented to: " + rover.AngleTo + ": ");

            foreach (var command in rover.Commands)
            {
                if (command == Command.L || command == Command.R)
                {
                    RotateTo(rover, command);
                }
                else if (command == Command.M)
                {
                    Move(rover, lines, columns);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Rover position is now: (" + rover.X + ", " + rover.Y + ") and is oriented to: " + rover.AngleTo + "\n");
        }
    }
}
