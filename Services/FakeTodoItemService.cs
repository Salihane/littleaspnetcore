using System;
using System.Threading.Tasks;
using Todo.Models;
using Todo.Data;

namespace Todo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetOpenTodosAsync()
        {
            return Task.FromResult(FakeData.GetTodos());
        }
    }
}