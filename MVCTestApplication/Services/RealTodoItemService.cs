using Microsoft.EntityFrameworkCore;
using MVCTestApplication.Data;
using MVCTestApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MVCTestApplication.Services
{
    public class RealTodoItemService : ITodoItemService
    {
        //TODO: TodoDBContext bağımlılı gidilecek
        private readonly TodoDBContext _context;

        public RealTodoItemService(TodoDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TodoItem>> GetIncompleteItemsAsync()
        {
            var items = await _context.TodoItems.Where(x => x.IsDone == false).ToArrayAsync();
            
            
            return items;

        }
    }
}