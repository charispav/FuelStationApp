using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static FuelStationApp.Impl.Enums;

namespace FuelStationApp.Impl {
    public class Item {
        public IEntity _entity;
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemTypeEnum ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        public Item() {

        }
        public Item(IEntity entity, string code, string description , ItemTypeEnum itemtype,  decimal price, decimal cost)

            {

            _entity = entity;
            Code = code;
            Description = description;
            ItemType = itemtype;
            Price = price;
            Cost = cost;

        }
    }
}
