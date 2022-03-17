using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_builder
{
    class Map
    {
        public int id { set; get; }
        public string name { set; get; }
        public byte[] mapImg { set; get; }
        public byte[] mapWithRoteImg { set; get; }
        public string cpCoordinates { set; get; }
        public string cpValue { set; get; }
        public string distanseBeetweenCP { set; get; }
        public string cpOrder { set; get; }
    }
}
