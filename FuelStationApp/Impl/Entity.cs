using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public class Entity : IEntity {
        public Guid ID { get; }

        public Entity() {
            ID = Guid.NewGuid();
        }
        public Entity(Guid id) {
            ID = id;
        }
    }
}
