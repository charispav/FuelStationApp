using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {


    public class Customer {

        public IPerson _person;
        public int CardNumber { get; set; }
      
        public Customer() { }
        public Customer(IPerson person, int cardnumber) {

            (_person, CardNumber) = (person, cardnumber);
          
        }
    }
}
