using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public class Person : IPerson {


        public Guid ID { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(IEntity entity, string name,string surname) {

            (this.ID, Name, Surname) = (entity.ID, name, surname);
        }
    }
}
