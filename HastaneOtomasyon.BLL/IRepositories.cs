using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.BLL
{
 public  interface IRepositories<T>
    {
        void Insert(T item);
        void Update(T item);
        void Delete(int itemId);
        List<T> SelectAll();
        List<T> SelectAllById(int itemId);
        T SelectById(int itemId);
    }
}
