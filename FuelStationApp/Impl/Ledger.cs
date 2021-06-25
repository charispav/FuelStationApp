using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public class Ledger { 
        public Guid ID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }

        public Ledger(Guid id, DateTime dateFrom, DateTime dateTo
            , decimal income, decimal expenses, decimal total) {
            (ID, DateFrom, DateTo,Income,Expenses,Total) = (id,dateFrom, dateTo, income, expenses, total);
        }

       
    }
}
