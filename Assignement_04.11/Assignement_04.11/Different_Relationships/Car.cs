using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_04._11.Different_Relationships
{
    public class Car
    {
        public String RegistrationNumber { get; set; }
        //Composition exmple
        public List<Tire> tire { get; set; }

        public Car() { }
        public Car(String RegistrationNumber, List<Tire> tire)
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
}
