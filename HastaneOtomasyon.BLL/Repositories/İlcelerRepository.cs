using HastaneOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.BLL.Repositories
{
    public class İlcelerRepository : IRepositories<Ilceler>
    {
        HastanelerContext hs = new HastanelerContext();
        public void Delete(int itemId)
        {
            hs.Ilcelers.Remove(hs.Ilcelers.Find(itemId));
            hs.SaveChanges();
        }

        public void Insert(Ilceler item)
        {
            hs.Ilcelers.Add(item);
            hs.SaveChanges();
        }

        public List<Ilceler> SelectAll()
        {
            return hs.Ilcelers.ToList();
        }

        public List<Ilceler> SelectAllById(int itemId)
        {
            throw new NotImplementedException();
        }

        public Ilceler SelectById(int itemId)
        {
            return hs.Ilcelers.Find(itemId);
        }

        public void Update(Ilceler item)
        {

            Ilceler updated = hs.Ilcelers.Find(item.IlcelerID);
            hs.Entry(updated).CurrentValues.SetValues(item);
            hs.SaveChanges();
        }

        //public List<Ilceler> SelectAllById(int itemId)
        //{
        //    //List<Ilceler> ilcelerList = hs.Ilcelers.Where(x => x.Iller.IllerID == itemId).ToList();
        //    //return ilcelerList;
        //}
    }
}
