using todolist.Models;
using todolist.Data;
using Microsoft.EntityFrameworkCore;

namespace todolist.Data.Repository
{
    public class ToDoTaskRepository : IToDoTaskRepository
    {
        private readonly todolistContext context;

        public ToDoTaskRepository(todolistContext context)
        {
            this.context = context;
        }

        public async Task<ToDoTask> CreateTask(ToDoTask task)
        {
            context.ToDoTask.Add(task);
            await context.SaveChangesAsync();
            return task;
        }

        public async Task<List<ToDoTask>> GetTasks()
        {
            return await context.ToDoTask.ToListAsync();
        }
    }
}
