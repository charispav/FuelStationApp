using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
        //[Flags]    
        public enum ItemTypeEnum {
            Fuel = 0,
            Product = 1,
            Service = 2
        }
        public enum EntityTypeEnum { 
            Transaction,
            TransactionLine,
            Customer,
            Employee,
            Item,
            Ledger
        }
}
