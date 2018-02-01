namespace TodoDemoApp.Repository.Real
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Services;
    using TodoDemoApp.Models;

    public class TodoRepository : ITodoService
    {
        private TodoContext _todoContext;

        public TodoRepository(TodoContext context)
        {
            _todoContext = context;
        }

        public async Task DeleteTodoItems(int id)
        {
            var todoItem = _todoContext.TodoItems.Where(t => t.Id == id).FirstOrDefault();
            _todoContext.TodoItems.Remove(todoItem);
            await _todoContext.SaveChangesAsync();
        }

        public TodoItem GetTodoItemById(int id)
        {
            var todoItem = _todoContext.TodoItems.Where(t => t.Id == id).FirstOrDefault();           
            return todoItem;
        }

        public async Task SaveTodoItems(TodoItem todoItem)
        {
            await _todoContext.TodoItems.AddAsync(todoItem);
            await _todoContext.SaveChangesAsync();
            return;
        }

        public async Task UpdateTodoItems(TodoItem todoItem)
        {
            var todoItemToUpdate = _todoContext.TodoItems.Where(t => t.Id == todoItem.Id).FirstOrDefault();
            todoItemToUpdate.IsComplete = todoItem.IsComplete;
            await _todoContext.SaveChangesAsync();
            return;
        }
    }
}
