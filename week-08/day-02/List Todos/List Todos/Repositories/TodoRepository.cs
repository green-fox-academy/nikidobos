using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_Todos.Repositories
{
    public class TodoRepository
    {
        private TodoDbContext TodoDbContext;
        public TodoRepository(TodoDbContext todoDbContext)
        {
            this.TodoDbContext = todoDbContext;
        }
    }
}
