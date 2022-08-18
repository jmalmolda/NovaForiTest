using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using todolist.Data;
using todolist.Models;

namespace todolist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoTasksController : ControllerBase
    {
        private readonly todolistContext _context;

        public ToDoTasksController(todolistContext context)
        {
            _context = context;
        }

        // GET: api/ToDoTasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoTask>>> GetToDoTask()
        {
          if (_context.ToDoTask == null)
          {
              return NotFound();
          }
            return await _context.ToDoTask.ToListAsync();
        }
    }
}
