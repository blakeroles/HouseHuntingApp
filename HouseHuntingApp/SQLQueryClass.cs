using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHuntingApp
{
    static class SQLQueryClass
    {
        static public string connectionString = @"Data Source = DESKTOP-T7PKUAC\SQLEXPRESS; Initial Catalog = HouseHuntingDB; Integrated Security = True";
        static public IQueryable<House> updateTable(HouseClassDataContext dc)
        {
            IQueryable<House> SelectQuery =
                from h in dc.GetTable<House>()
                select h;

            return SelectQuery;

        }


        
    }
}
