using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.CarProject
{
    public class Audi : Car
    {
        public string model;

        public Audi(string model)
        {
            this.model = model;
        }

        public void printNumber()
        {
            Console.WriteLine("Registartion number is: " + RegistrationNumber);
        }

    }
}
