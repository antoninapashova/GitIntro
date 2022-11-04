using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_04._11.Different_Relationships
{
    public class Audi : Car
    {
        public String model;

        public Audi(String model)
        {
            this.model = model;
        }

        public void printNumber()
        {
            Console.WriteLine("Registartion number is: " + RegistrationNumber);
        }
    
    }
}
