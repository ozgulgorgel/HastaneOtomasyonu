using HastaneOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.BLL.Repositories
{
    public class CustomerRepository : IRepositories<Customer>
    {
        HastanelerContext hs = new HastanelerContext();

        public void Delete(int itemId)
        {
            hs.Customers.Remove(hs.Customers.Find(itemId));
            hs.SaveChanges();
        }

        public void Insert(Customer item)
        {

            hs.Customers.Add(item);
            hs.SaveChanges();
        }

        public List<Customer> SelectAll()
        {

            return hs.Customers.ToList();
        }

        public List<Customer> SelectAllById(int itemId)
        {
            throw new NotImplementedException();
        }

        public Customer SelectById(int itemId)
        {
            return hs.Customers.Find(itemId);
        }

        public void Update(Customer item)
        {
            Customer updated = hs.Customers.Find(item.CustomerID);
            hs.Entry(updated).CurrentValues.SetValues(item);
            hs.SaveChanges();
        }
    }
}
