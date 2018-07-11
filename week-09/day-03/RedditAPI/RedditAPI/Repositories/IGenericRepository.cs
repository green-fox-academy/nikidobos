using System.Collections.Generic;

namespace RedditAPI.Repositories
{
    public interface IGenericRepository<Type>
    {
        void Create(Type element);
        List<Type> Read();
        void Update(Type element);
        void Delete(Type element);
    }
}