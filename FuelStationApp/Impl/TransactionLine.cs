using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public class TransactionLine {
        public Guid ID { get; set; }
        public Guid TransactionID { get; set; }
        public Guid ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal Value { get; set; }

        public TransactionLine() {

        }

    }
}
