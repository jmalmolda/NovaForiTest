using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using todolist.Data;
using todolist.Data.Repository;
using todolist.Models;

namespace todolist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoTasksController : ControllerBase
    {
        private readonly IToDoTaskRepository repository;

        public ToDoTasksController(IToDoTaskRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/ToDoTasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoTask>>> GetToDoTasks()
        {
            return await repository.GetTasks();
        }

        // POST: api/ToDoTasks
        [HttpPost]
        public async Task<ActionResult<ToDoTask>> PostToDoTask(ToDoTask toDoTask)
        {
            await repository.CreateTask(toDoTask);

            return CreatedAtAction("PostToDoTask", new { id = toDoTask.Id }, toDoTask);
        }
    }
}
