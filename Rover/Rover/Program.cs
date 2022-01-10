using Rover.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Rover
{
    class Program
    {
        private static readonly DirectionController directionController = new DirectionController();
        private static readonly RoverController roverController = new RoverController();
        private static readonly CommandController commandController = new CommandController();

        static void Main(string[] args)
        {
            var inputFile = "Input.txt";

            Plateau plateau = new Plateau();
            List<Rover> rovers = new List<Rover>();

            ReadInputFile(inputFile, ref plateau, ref rovers);

            for (int i = 0; i < rovers.Count; i++)
            {
                roverController.MoveRover(rovers[i], plateau.Lines, plateau.Columns);
            }

            Console.ReadLine();
        }

        private static void ReadInputFile(string filePath, ref Plateau plateau, ref List<Rover> rovers)
        {
            var lines = File.ReadAllLines(filePath);

            var pleateau_split = lines[0].Split(' ');

            plateau = new Plateau
            {
                Lines = Convert.ToInt32(pleateau_split[0]),
                Columns = Convert.ToInt32(pleateau_split[1])
            };

            for (int i = 1; i < lines.Count(); i++)
            {
                var roverPostion = lines[i].Split(' ');
                var roverCommands = lines[i + 1];

                rovers.Add(
                    new Rover
                    {
                        Number = rovers.Count + 1,
                        X = Convert.ToInt32(roverPostion[0]),
                        Y = Convert.ToInt32(roverPostion[1]),
                        AngleTo = directionController.GetDirection(roverPostion[2]),
                        Commands = commandController.GetCommands(roverCommands)
                    }
                );
                i++;
            }
        }
    }
}
