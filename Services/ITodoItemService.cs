using System;
using Todo.Models;
using System.Threading.Tasks;

namespace Todo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetOpenTodosAsync();
    }
}