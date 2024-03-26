using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepos
{
    public interface IRepos<T> where T : class
    {
        public ICollection<T> GetAll();
        public T GetByID(dynamic id);
        bool CreateObj(T obj);
        bool UpdateObj(T obj);
        bool DeleteObj(T obj);
    }
}
