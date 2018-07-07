using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repository
{
    public interface IReddit<Type>
    {
        void Create(Type element);
        List<Type> Read();
        void Update(Type element);
        void Delete(Type element);
        Type GetElementById(int id);
        void ChangeVote();
    }
}
