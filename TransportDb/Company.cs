using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportDb
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } 

        public IList<Car> Cars { get; set; } = new List<Car>();
    }
}
