using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_Todos.Repositories
{
    public interface IGeneralRepository
    {
        //CRUD
        void Create(Type element);
        List<Type> GetAllElements();
        void Update(Type element);
        void Delete(Type element);
    }
}
