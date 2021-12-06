using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Context
{
     public class UnitOfWork : IDisposable
    {
        AccountingStore_DBEntities db = new AccountingStore_DBEntities();

        private CustomerRepository _CustomerRepository;
        public CustomerRepository CustomerReoisitorry
        {
            get
            {
                if (_CustomerRepository==null)
                {
                    _CustomerRepository = new CustomerRepository(db);
                }
                return _CustomerRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
