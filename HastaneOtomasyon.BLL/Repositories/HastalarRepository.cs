using HastaneOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.BLL.Repositories
{
    public class HastalarRepository : IRepositories<Hastalar>
    {
        HastanelerContext hs = new HastanelerContext();
        public void Delete(int itemId)
        {
           

        }

        public void Insert(Hastalar item)
        {
            
        }

        public List<Hastalar> SelectAll()
        {
            throw new NotImplementedException();
        }

        public List<Hastalar> SelectAllById(int itemId)
        {
            throw new NotImplementedException();
        }

        public Hastalar SelectById(int itemId)
        {
            throw new NotImplementedException();
        }

        public void Update(Hastalar item)
        {
            throw new NotImplementedException();
        }
    }
}
