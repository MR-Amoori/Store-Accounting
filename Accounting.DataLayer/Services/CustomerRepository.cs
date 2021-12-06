using Accounting.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        public AccountingStore_DBEntities db;
        public CustomerRepository(AccountingStore_DBEntities dBEntities)
        {
            db = dBEntities;
        }
        
        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var Customer = GetCustomerbyId(customerId);
                DeleteCustomer(Customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(Customer_TB customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Customer_TB> GetAllCustomers()
        {
            return db.Customer_TB.ToList();
        }

        public IEnumerable<Customer_TB> GetCustomerByFilter(string Parameter)
        {
            return db.Customer_TB.Where(p => p.Name.Contains(Parameter) || p.Family.Contains(Parameter) || p.Email.Contains(Parameter) || p.NumberPhone.Contains(Parameter)).ToList();
        }

        public Customer_TB GetCustomerbyId(int customerId)
        {
            return db.Customer_TB.Find(customerId);
        }

        public string GetCustomerNameById(int customerId)
        {
            return db.Customer_TB.Find(customerId).Family;
        }

        public List<string> GetNamesCustomers(string Filter = "")
        {
            throw new NotImplementedException();
        }

        public bool InsertCustomer(Customer_TB customer)
        {
            try
            {
                db.Customer_TB.Add(customer);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customer_TB customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
