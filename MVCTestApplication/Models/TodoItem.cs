using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace MVCTestApplication.Models
{
    public class TodoItem // POCO Plan old c# object
    {
        public Guid Id { get; set; }
        public bool IsDone { get; set; }
        public string Title { get; set; }

        public DateTimeOffset? DueAt { get; set; }
        public List<TodoItem> MyProperty { get; set; }


    }
}
