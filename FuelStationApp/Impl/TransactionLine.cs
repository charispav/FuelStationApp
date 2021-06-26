using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public class TransactionLine {
        public IEntity _entity;
        public Guid TransactionID { get; set; }
        public Guid ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal Value { get; set; }


        public TransactionLine(IEntity entity, Guid transactionID, Guid itemID, int quantity, decimal itemPrice, decimal value) {

            (_entity, TransactionID, ItemID, Quantity, ItemPrice, Value) =
          (entity, transactionID, itemID, quantity, itemPrice, value);

        }

    }
}
