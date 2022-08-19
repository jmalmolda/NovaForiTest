
using todolist.Models;

namespace todolist.Data.Repository
{
    public interface IToDoTaskRepository
    {
        Task<List<ToDoTask>> GetTasks();

        Task<ToDoTask> CreateTask(ToDoTask task);
    }
}
