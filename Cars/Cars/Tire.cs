using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tire
    {
        public String Type { get; set; }

        public Tire()
        {

        }

        public Tire(String type)
        {
            this.Type = type;
        }
    }
}
