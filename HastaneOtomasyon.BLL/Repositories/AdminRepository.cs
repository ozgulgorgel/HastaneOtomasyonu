using HastaneOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.BLL.Repositories
{
   public  class AdminRepository : IRepositories<Admin>
    {
        HastanelerContext hs = new HastanelerContext();

        public void Delete(int itemId)
        {
            hs.Admins.Remove(hs.Admins.Find(itemId));
            hs.SaveChanges();
           
        }

        public void Insert(Admin item)
        {
            hs.Admins.Add(item);
            hs.SaveChanges();
        }

        public List<Admin> SelectAll()
        {
            return hs.Admins.ToList();
        }

        public List<Admin> SelectAllById(int itemId)
        {
            throw new NotImplementedException();
        }

        public Admin SelectById(int itemId)
        {
            return hs.Admins.Find(itemId);
        }

        public void Update(Admin item)
        {
            Admin updated = hs.Admins.Find(item.AdminID);
            hs.Entry(updated).CurrentValues.SetValues(item);
            hs.SaveChanges();
        }
    }
}
