using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public interface IDates {
        DateTime DateStart { get; set; }
        DateTime DateEnd { get; set; }
    }
}
