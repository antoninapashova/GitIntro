using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.CarProject
{
    internal class TaxiCompany
    {
        public string Name { get; set; }
        //Agregation example
        public List<Car> cars { get; set; }

        public TaxiCompany(string name, List<Car> cars)
        {
            Name = name;
            this.cars = cars;
        }
    }
}
