using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repository
{
    public interface IItemRepository
    {
        Item_TB GetItemById (int Id);
        bool DeleteItem(int Id);
        bool DeleteItem(Item_TB item);
    }
}
