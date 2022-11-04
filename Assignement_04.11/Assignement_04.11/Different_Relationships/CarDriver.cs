using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_04._11.Different_Relationships
{
    public class CarDriver
    {

        public String Name { get; set; }

        public CarDriver(String name)
        {
            this.Name = name;
        }

        public void driveCar(Car car)
        {
            car.drive(this);
        }
    }
}
