using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoDemoApp.Models;

namespace TodoDemoApp.Services
{
    public interface ITodoService
    {
        /// <summary>
        /// This method is used to get todo item by Id.
        /// </summary>
        /// <param name="id">Pass the id of the todo item to be fetched from database.</param>
        /// <returns>Returns the todo item.</returns>
        TodoItem GetTodoItemById(int id);

        /// <summary>
        /// This method is used to save todo item.
        /// </summary>
        /// <param name="todoItem">Pass the todo item to save in database.</param>
        /// <returns>Returns the todo item saved.</returns>
        Task SaveTodoItems(TodoItem todoItem);

        /// <summary>
        /// This method is used to update todo item.
        /// </summary>
        /// <param name="todoItem">Pass the todo item to update in database.</param>
        /// <returns>Returns the todo item saved.</returns>
        Task UpdateTodoItems(TodoItem todoItem);

        /// <summary>
        /// This method is used to delete todo item.
        /// </summary>
        /// <param name="id">Pass the todo item to delete from database.</param>
        /// <returns>Returns the todo item deleted.</returns>
        Task DeleteTodoItems(int id);
    }
}
