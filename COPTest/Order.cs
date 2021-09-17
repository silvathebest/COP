using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COPTest
{
    public class Order
    {
        public string City { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }
        public override string ToString() => $"{City} {Email} {Id}";
    }
}
