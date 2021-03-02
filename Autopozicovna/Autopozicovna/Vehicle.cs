using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopozicovna
{
    class Vehicle
    {
        public Vehicle(Type vehicleType, Brand vehicleBrand, Colour vehicleColour, Engine vehicleEngine, Price vehiclePrice)
        {
            this.vehicleType = vehicleType;
            this.vehicleBrand = vehicleBrand;
            this.vehicleColour = vehicleColour;
            this.vehicleEngine = vehicleEngine;
            this.vehiclePrice = vehiclePrice;

        }

        public Type vehicleType { get; set; }
        public Brand vehicleBrand { get; set; }
        public Colour vehicleColour { get; set; }
        public Engine vehicleEngine { get; set; }
        public Price vehiclePrice { get; set; }
    }
}
