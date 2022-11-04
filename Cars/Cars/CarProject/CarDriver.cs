using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.CarProject
{
    public class CarDriver
    {
        public string Name { get; set; }

        public CarDriver(string name)
        {
            Name = name;
        }

        public void driveCar(Car car)
        {
            car.drive(this);
        }
    }
}
