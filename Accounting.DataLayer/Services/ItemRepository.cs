using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repository;
using Accounting.ViewModels.Category;

namespace Accounting.DataLayer.Services
{
    public class ItemRepository : IItemRepository
    {
        public AccountingStore_DBEntities db;
        public ItemRepository(AccountingStore_DBEntities context)
        {
            db = context;
        }
        public List<CategoriViewModel> GetNameAndIdCategory()
        {
            return db.Item_TB.Select(p => new CategoriViewModel()
            {
                ItemId = p.ItemId,
                ItemName = p.ItemCategory.ToString()
            }
                 ).ToList();
        }

        public List<ItemCategoryType> itemCategoryType()
        {
            return db.ItemCategoryType.ToList();
        }
    }
}
