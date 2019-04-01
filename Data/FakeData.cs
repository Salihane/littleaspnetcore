using System;
using System.Collections.Generic;
using Todo.Models;

namespace Todo.Data
{
    public static class FakeData
    {
        public static TodoItem[] GetTodos()
        {
            return new TodoItem[]
            {
                new TodoItem 
                {
                     Title = "Pique-nique",
                     DueAt = DateTimeOffset.Now.AddDays(-1)
                },
                new TodoItem 
                {
                     Title = "Quit Avanade",
                     DueAt = DateTimeOffset.Now.AddDays(-10)
                },
                new TodoItem 
                {
                     Title = "Learn ASP.NET Core",
                     DueAt = DateTimeOffset.Now.AddDays(1)
                },
                new TodoItem 
                {
                     Title = "Build a todo manager using ASP.NET Core",
                     DueAt = DateTimeOffset.Now.AddDays(2)
                },
                new TodoItem 
                {
                     Title = "Learn Git and GitHub",
                     DueAt = DateTimeOffset.Now.AddDays(5)
                }
            };
        }
    }
}