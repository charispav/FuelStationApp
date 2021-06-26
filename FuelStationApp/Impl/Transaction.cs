using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public class Transaction {

        public IEntity _entity;
  
        public DateTime Date { get; set; }

        public Guid CustomerID { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }

      

        public Transaction( IEntity entity, DateTime date, Guid customerID, decimal discountValue, decimal totalValue) {

            (_entity, Date, CustomerID, DiscountValue, TotalValue) =
          (entity, date, customerID, discountValue, totalValue);

        }

    }
}
