using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repository
{
  public interface ICustomerRepository
    {
        List<Customer_TB> GetAllCustomers();
        IEnumerable<Customer_TB> GetCustomerByFilter(string Parameter);
        List<string> GetNamesCustomers(string Filter = "");
        Customer_TB GetCustomerbyId(int customerId);
        bool InsertCustomer(Customer_TB customer);
        bool UpdateCustomer(Customer_TB customer);
        bool DeleteCustomer(int customerId);
        bool DeleteCustomer(Customer_TB customer);
        string GetCustomerNameById(int customerId);
    }
}
