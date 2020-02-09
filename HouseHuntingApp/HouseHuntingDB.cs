using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace HouseHuntingApp
{
    [Database]
    class HouseHuntingDB : DataContext
    {
        public HouseHuntingDB(string connectionString) : base(connectionString) { }


        public Table<House> Houses;

    }
}
