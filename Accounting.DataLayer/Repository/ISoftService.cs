using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repository
{
    internal interface ISoftService
    {
        IEnumerable<SoftService_TB> GetServiceByFilter(string Parameter);
    }
}
