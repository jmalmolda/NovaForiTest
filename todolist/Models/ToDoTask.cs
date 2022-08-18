namespace todolist.Models
{
    public class ToDoTask
    {
        public Guid? Id { get; set; }
        public string? Description { get; set; }
        public StateEnum? State { get; set; }
    }
}
