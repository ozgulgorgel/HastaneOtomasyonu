using HastaneOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.BLL.Repositories
{
    public class İllerRepository : IRepositories<Iller>

    {
        HastanelerContext hs = new HastanelerContext();
    
        public void Delete(int itemId)
        {
            hs.Illers.Remove(hs.Illers.Find(itemId));
            hs.SaveChanges();
        }

        public void Insert(Iller item)
        {
            hs.Illers.Add(item);
             hs.SaveChanges();
        }

        public List<Iller> SelectAll()
        {
            return hs.Illers.ToList();
        }

        public List<Iller> SelectAllById(int itemId)
        {
            throw new NotImplementedException();
        }

        public Iller SelectById(int itemId)
        {
            return hs.Illers.Find(itemId);

        }

        public void Update(Iller item)
        {
            Iller updated = hs.Illers.Find(item.IllerID);
            hs.Entry(updated).CurrentValues.SetValues(item);
            hs.SaveChanges();
        }
    }
}
