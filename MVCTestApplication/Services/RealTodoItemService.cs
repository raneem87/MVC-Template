using MVCTestApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTestApplication.Services
{
    public class RealTodoItemService : ITodoItemService
    {
        public Task<IEnumerable<TodoItem>> GetIncompleteItemsAsync()
        {
            IEnumerable<TodoItem> items = new[]
            {
               new TodoItem
                {
                    Title = "test",
                    DueAt = DateTimeOffset.Now.AddDays(1)
                },
                new TodoItem
                {
                    Title = "test2",
                    DueAt = DateTimeOffset.Now.AddDays(2)
                }

                };
            return Task.FromResult(items);

        }
    }
}