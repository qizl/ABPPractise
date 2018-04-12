namespace SimpleTaskSystem.Tasks
{
    /// <summary>
    /// Possible state of a <see cref="Task"/>
    /// </summary>
    public enum TaskState : byte
    {
        Active = 1,

        Completed = 2
    }
}
