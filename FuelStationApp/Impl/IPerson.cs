using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public interface IPerson : IEntity {
        string Name { get; set; }
        string Surname { get; set; }
        
    }
}
