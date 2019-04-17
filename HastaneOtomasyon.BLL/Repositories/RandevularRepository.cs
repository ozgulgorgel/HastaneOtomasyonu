using HastaneOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.BLL.Repositories
{
public  class RandevularRepository:IRepositories<Randevular>
    {
    HastanelerContext hs = new HastanelerContext();

    public void Delete(int itemId)
    {
        hs.Randevulars.Remove(hs.Randevulars.Find(itemId));
        hs.SaveChanges();
    }
    public void Insert(Randevular item)
    {
        hs.Randevulars.Add(item);
        hs.SaveChanges();
    }
    public List<Randevular> SelectAll()
    {
        return hs.Randevulars.ToList();
    }

    public List<Randevular> SelectAllById(int itemId)
    {
        throw new NotImplementedException();
    }
    public Randevular SelectById(int itemId)
    {
        return hs.Randevulars.Find(itemId);

    }

    public void Update(Randevular item)
    {
        Randevular updated = hs.Randevulars.Find(item.RandevularID);
        hs.Entry(updated).CurrentValues.SetValues(item);
        hs.SaveChanges();
    }
    }
}
