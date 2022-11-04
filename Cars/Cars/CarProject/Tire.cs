using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.CarProject
{
    public class Tire
    {
        public string Type { get; set; }

        public Tire()
        {

        }

        public Tire(string type)
        {
            Type = type;
        }
    }
}
