using List_Todos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_Todos.Repositories
{
    public class AssigneeRepository : IGeneralRepository<Assignee>
    {
        private TodoDbContext todoDbContext;
        public AssigneeRepository(TodoDbContext todoDbContext)
        {
            this.todoDbContext = todoDbContext;
        }

        public void Create(Assignee element)
        {
            todoDbContext.Assignees.Add(element);
            todoDbContext.SaveChanges();
        }

        public void Delete(Assignee element)
        {
            todoDbContext.Assignees.Remove(element);
        }

        public List<Assignee> GetAllElements()
        {
            return todoDbContext.Assignees.ToList();
        }

        public Assignee GetTodoById(long id)
        {
            return todoDbContext.Assignees.ToList().FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Update(Assignee element)
        {
            todoDbContext.Assignees.Update(element);
            todoDbContext.SaveChanges();
        }
    }
}
