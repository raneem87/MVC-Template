using Microsoft.AspNetCore.Mvc;
using MVCTestApplication.Models;
using MVCTestApplication.Services;
using Newtonsoft.Json.Serialization;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCTestApplication.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService service;
        public TodoController(ITodoItemService _service)
        {
            service = _service;
        }
        public async Task<IActionResult> IndexAsync()
        {
             
            // Get to-do items from database
            IEnumerable<TodoItem> items= await service.GetIncompleteItemsAsync();
            TodoViewModel vm=new TodoViewModel () ;
            vm.Items = items;

            // Put items into a model


            // Render view using the model
            ViewBag.Title = "Manage your Todo List";
            return View(vm);
        }
    }
}
