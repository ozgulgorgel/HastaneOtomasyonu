using HastaneOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.BLL.Repositories
{
    public class HastanelerRepository : IRepositories<Hastaneler>
    {
        HastanelerContext hs = new HastanelerContext();
        public void Delete(int itemId)
        {
            hs.Hastanelers.Remove(hs.Hastanelers.Find(itemId));
            hs.SaveChanges();
        }

        public void Insert(Hastaneler item)
        {
            hs.Hastanelers.Add(item);
            hs.SaveChanges();
        }

       
        public List<Hastaneler> SelectAll()
        {
            return hs.Hastanelers.ToList();
        }

        public List<Hastaneler> SelectAllById(int itemId)
        {
            throw new NotImplementedException();
        }

        public Hastaneler SelectById(int itemId)
        {
            return hs.Hastanelers.Find(itemId);
        }

        public void Update(Hastaneler item)
        {
            Hastaneler updated = hs.Hastanelers.Find(item.HastanelerID);
            hs.Entry(updated).CurrentValues.SetValues(item);
            hs.SaveChanges();
        }
    }
}
