using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkstationStudioGarment_WinForm.control
{
    interface IServiceDAO<T> where T : class
    {
        void Add(T entity);
        List<T> All();
        void Delete(T entity);
        void Update(T entity);
    }
}
