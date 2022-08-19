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

        public Task<ToDoTask> CreateTask(ToDoTask task)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ToDoTask>> GetTasks()
        {
            return await context.ToDoTask.ToListAsync();
        }
    }
}
