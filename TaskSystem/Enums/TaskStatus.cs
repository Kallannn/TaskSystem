using System.ComponentModel;

namespace TaskSystem.Enums
{
    public enum TaskStatus
    {
        [Description("To do")]
        ToDo = 1,

        [Description("On Going")]
        OnGoing = 2,
        [Description("Finished")]
        Finished = 3
    }
}
