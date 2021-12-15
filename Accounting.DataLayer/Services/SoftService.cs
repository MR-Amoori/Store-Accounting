using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class SoftService : Repository.ISoftService
    {
        AccountingStore_DBEntities db;
        public SoftService(AccountingStore_DBEntities Context)
        {
            db = Context;
        }
        public IEnumerable<SoftService_TB> GetServiceByFilter(string Parameter)
        {
            return db.SoftService_TB.Where(p => p.SoftServiceName.Contains(Parameter) || p.SoftServiceCaption.Contains(Parameter)).ToList();
        }
    }
}
