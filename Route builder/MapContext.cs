using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_builder
{
    class MapContext : DbContext
    {
        public MapContext() : base("MapConnectionString")
        {
        }
        public DbSet<Map> Maps { get; set; }
    }
}
