using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.CarProject
{
    public class Car
    {
        public string RegistrationNumber { get; set; }
        //Composition exmple
        public List<Tire> tire { get; set; }

        public Car() { }
        public Car(string RegistrationNumber, List<Tire> tire)
        {
            this.RegistrationNumber = RegistrationNumber;
            this.tire = tire;
        }

        public void drive(CarDriver carDriver)
        {
            Console.WriteLine("The driver is driving the car");
        }
    }
}
