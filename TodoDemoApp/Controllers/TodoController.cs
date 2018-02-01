using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoDemoApp.Models;

namespace TodoDemoApp.Controllers
{
    using Services;

    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet("{id}")]
        [Route("GetTodoItemById/{id}")]
        public IActionResult Get(int id)
        {
            if (id <= 0)
                return BadRequest("Id passed should be valid value or greater than 0.");

            TodoItem todoItem = null;
            try
            {
                todoItem = _todoService.GetTodoItemById(id);
            }
            catch
            {
                return StatusCode(500);
            }

            return Ok(todoItem);
        }

        [HttpPost()]
        [Route("SaveTodoItems")]
        public async Task<IActionResult> Post([FromBody]TodoItem todoItem)
        {
            if (todoItem == null || string.IsNullOrEmpty(todoItem.Item))
                return BadRequest("TodoItem object is null or item is not having proper description");

            try
            {
                await _todoService.SaveTodoItems(todoItem);
            }
            catch
            {
                return StatusCode(500);
            }

            return Ok();
        }

        [HttpPut()]
        [Route("UpdateTodoItems")]
        public async Task<IActionResult> Put([FromBody]TodoItem todoItem)
        {
            if (todoItem == null || string.IsNullOrEmpty(todoItem.Item))
                return BadRequest("TodoItem object is null or item is not having proper description");

            await _todoService.UpdateTodoItems(todoItem);

            return Ok(todoItem);
        }

        [HttpDelete("{id}")]
        [Route("DeleteTodoItems/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Id passed should be valid value or greater than 0.");

            await _todoService.DeleteTodoItems(id);

            return Ok(id);
        }
    }
}