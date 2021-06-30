using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
   
        public enum ItemTypeEnum {
            Fuel,
            Product,
            Service
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
