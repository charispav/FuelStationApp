using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public class Employee {
        public IPerson _person;
        
        public IDates _dates;
        public decimal Salary { get; set; }
        public Employee() {

        }
        public Employee(IPerson person,IDates dates, decimal salary) {

            (_person, _dates, Salary) = (person, dates, salary);
        }
    }
}
