using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_Todos.Models
{
    public class Todo
    {
        private long Id { set; get; }
        private string Title { set; get; }
        private bool IsUrgent { set; get; }
        private bool IsDone { set; get; }
    }
}
