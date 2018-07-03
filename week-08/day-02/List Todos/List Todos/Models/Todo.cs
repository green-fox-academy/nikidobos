using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_Todos.Models
{
    public class Todo
    {
        public long Id { set; get; }
        public string Title { set; get; }
        public bool IsUrgent { set; get; }
        public bool IsDone { set; get; }
    }
}
