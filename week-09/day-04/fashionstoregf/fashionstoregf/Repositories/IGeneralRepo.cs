using fashionstoregf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fashionstoregf.Repositories
{
    interface IGeneralRepo<Type>
    {
        void Create(Type element);
        List<Type> Read();
        void Update(Type element);
        void Delete(Type element);
    }
}
