using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public class Dates : IDates {
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public Dates(DateTime dateStart, DateTime dateEnd ) {
            DateStart = dateStart;
            DateEnd = dateEnd;
        }

    }
}
