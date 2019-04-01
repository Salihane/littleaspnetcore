using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Todo.Services;
using Todo.ViewModels;

namespace Todo.Controllers
{
    public class TodosController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodosController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> Index()
        {
            var todos = await _todoItemService.GetOpenTodosAsync();

            var vm = new TodoViewModel
            {
                Todos = todos
            };

            return View(vm);
        }
    }
}