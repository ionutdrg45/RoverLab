
using System.ComponentModel;

namespace Rover.Model
{
    public enum Command
    {
        [Description("Left")]
        L,
        [Description("Right")]
        R,
        [Description("Move")]
        M
    }
}
