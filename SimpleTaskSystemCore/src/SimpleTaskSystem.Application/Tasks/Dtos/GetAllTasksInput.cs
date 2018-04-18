namespace SimpleTaskSystem.Tasks.Dtos
{
    public class GetAllTasksInput
    {
        public TaskState? State { get; set; }
        public int PageSize { get; set; } = 10;
    }
}
