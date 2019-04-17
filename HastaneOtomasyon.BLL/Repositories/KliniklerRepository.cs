using HastaneOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.BLL.Repositories
{
    public class KliniklerRepository : IRepositories<Klinikler>
    {
        HastanelerContext hs = new HastanelerContext();
        public void Delete(int itemId)
        {
            hs.Kliniklers.Remove(hs.Kliniklers.Find(itemId));
            hs.SaveChanges();
        }

        public void Insert(Klinikler item)
        {
            hs.Kliniklers.Add(item);
            hs.SaveChanges();
        }

        public List<Klinikler> SelectAll()
        {
            return hs.Kliniklers.ToList();
        }

        public List<Klinikler> SelectAllById(int itemId)
        {
            throw new NotImplementedException();
        }

        public Klinikler SelectById(int itemId)
        {
            return hs.Kliniklers.Find(itemId);

        }

        public void Update(Klinikler item)
        {
            Klinikler updated = hs.Kliniklers.Find(item.KliniklerID);
            hs.Entry(updated).CurrentValues.SetValues(item);
            hs.SaveChanges();
        }
    }
}
