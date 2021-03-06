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
                if (_CustomerRepository == null)
                {
                    _CustomerRepository = new CustomerRepository(db);
                }
                return _CustomerRepository;
            }
        }

        private GenericRepository<Item_TB> _genericRepositoryItem;
        public GenericRepository<Item_TB> GenericRepositoryItem
        {
            get
            {
                if (_genericRepositoryItem == null)
                {
                    _genericRepositoryItem = new GenericRepository<Item_TB>(db);
                }
                return _genericRepositoryItem;
            }
        }

        private ItemRepository _itemRepository;
        public ItemRepository ItemRepository
        {
            get
            {
                if (_itemRepository==null)
                {
                    _itemRepository = new ItemRepository(db);
                }
                return _itemRepository;
            }
        }

        private GenericRepository<SoftService_TB> _genericRepositorySoftService;
        public GenericRepository<SoftService_TB> GenericRepositorySoftService
        {
            get
            {
                if (_genericRepositorySoftService==null)
                {
                    _genericRepositorySoftService = new GenericRepository<SoftService_TB>(db);
                }
                return _genericRepositorySoftService;
            }
           
        }

        private SoftService _softService;
        public SoftService SoftService
        {
            get
            {
                if (_softService==null)
                {
                    _softService = new SoftService(db);
                }
                return _softService;
            }
        }

        private GenericRepository<HardService_TB> _genericRepositoryHardService;
        public GenericRepository<HardService_TB> GenericRepositoryHardService
        {
            get
            {
                if (_genericRepositoryHardService==null)
                {
                    _genericRepositoryHardService = new GenericRepository<HardService_TB>(db);
                }
                return _genericRepositoryHardService;
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
