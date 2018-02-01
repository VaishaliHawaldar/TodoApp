namespace TodoDemoApp.Repository.Fake
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
        public Task DeleteTodoItems(int id)
        {
            throw new NotImplementedException();
        }

        public TodoItem GetTodoItemById(int id)
        {
            TodoItem todoItem = new TodoItem
            {
                Id = 1,
                Item = "Stand up meeting",
                IsComplete = false
            };
            return todoItem;
        }

        public Task SaveTodoItems(TodoItem todoItem)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTodoItems(TodoItem todoItem)
        {
            throw new NotImplementedException();
        }
    }
}
