using HastaneOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.BLL.Repositories
{
  public  class DoktorlarRepository:IRepositories<Doktorlar>
    {
        HastanelerContext hs = new HastanelerContext();

        public void Delete(int itemId)
        {
            hs.Doktorlars.Remove(hs.Doktorlars.Find(itemId));
            hs.SaveChanges();
        }

        public void Insert(Doktorlar item)
        {
            hs.Doktorlars.Add(item);
            hs.SaveChanges();
           
        }

        public List<Doktorlar> SelectAll()
        {
            return hs.Doktorlars.ToList();
          
        }

        public List<Doktorlar> SelectAllById(int itemId)
        {
            throw new NotImplementedException();
        }

        public Doktorlar SelectById(int itemId)
        {
            return hs.Doktorlars.Find(itemId);
          
        }

        public void Update(Doktorlar item)
        {
            Doktorlar updated = hs.Doktorlars.Find(item.DoktorlarId);
            hs.Entry(updated).CurrentValues.SetValues(item);
            hs.SaveChanges();
        }
    }
}
