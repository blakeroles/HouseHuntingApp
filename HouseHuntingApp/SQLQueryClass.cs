using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHuntingApp
{
    static class SQLQueryClass
    {
        static public IQueryable<House> updateTable(HouseClassDataContext dc)
        {
            IQueryable<House> SelectQuery =
                from h in dc.GetTable<House>()
                select h;

            return SelectQuery;

        }
        
    }
}
