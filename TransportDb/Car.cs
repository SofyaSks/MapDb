using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportDb
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxSpeed {  get; set; }
        public int CompanyId {  get; set; } 

        public Company Company { get; set; }
    }
}
