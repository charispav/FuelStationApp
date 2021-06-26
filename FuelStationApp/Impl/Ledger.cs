using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public class Ledger {

        public IEntity _entity;
        public IDates _dates;
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }

        public Ledger(IEntity entity, IDates dates, decimal income, decimal expenses, decimal total) {
            (_entity,_dates, Income, Expenses, Total) = 
             (entity,dates, income, expenses, total);
        }

    }
}
