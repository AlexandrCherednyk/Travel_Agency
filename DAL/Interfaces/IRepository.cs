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
        T GetByGuId(Guid id);
        void Create(T item);
        void Update(T item);
        void DeleteByGuid(Guid id);
    }
}
