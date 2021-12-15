using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repository;
using Accounting.ViewModels.Category;

namespace Accounting.DataLayer.Services
{
    public class ItemRepository  : IItemRepository
    {
        public AccountingStore_DBEntities db;
        public ItemRepository(AccountingStore_DBEntities context)
        {
            db = context;
        }

        public bool DeleteItem(int Id)
        {
            try
            {
                var item = GetItemById(Id);
                DeleteItem(item);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteItem(Item_TB item)
        {          
                try
                {
                    db.Entry(item).State = EntityState.Deleted;
                    return true;
                }
                catch
                {
                    return false;
                }
        }

        public IEnumerable<Item_TB> GetItemByFilter(string Parameter)
        {        
                return db.Item_TB.Where(p => p.ItemName.Contains(Parameter) || p.ItemBrand.Contains(Parameter)).ToList();
        }

        public Item_TB GetItemById(int Id)
        {
            return db.Item_TB.Find(Id);
        }
    }
}
