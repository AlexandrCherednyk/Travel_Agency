using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByDbId(int id);
        T GetByGuId(Guid id);
        void Create(T item);
        void Update(T item);
        void Update(T item, Guid id);
        void DeleteByDbId(int id);
        void DeleteByGuid(Guid id);
    }
}
