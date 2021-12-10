using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels.Category;

namespace Accounting.DataLayer.Repository
{
    internal interface IItemRepository
    {
        List<CategoriViewModel> GetNameAndIdCategory();
        List<ItemCategoryType> itemCategoryType();
    }
}
