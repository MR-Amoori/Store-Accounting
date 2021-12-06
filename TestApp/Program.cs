using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks ;
using Accounting.DataLayer.Context;


namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var list = db.CustomerReoisitorry.GetAllCustomers().ToList();
            }
        }
    }
}
