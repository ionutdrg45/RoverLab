using Rover.Model;

namespace Rover.Controller
{
    public class DirectionController
    {
        public Direction GetDirection(string value)
        {
            switch (value)
            {
                default:
                    return Direction.N;
                case "N":
                    return Direction.N;
                case "V":
                    return Direction.V;
                case "S":
                    return Direction.S;
                case "E":
                    return Direction.E;
            }
        }
    }
}
