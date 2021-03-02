using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Autopozicovna
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            List < Vehicle > shop = new List<Vehicle>();

            shop.Add(new Vehicle(Type.motorcycle, new Brand("Skoda"), Colour.green, new Engine("diesel"), new Price(14000)));
            shop.Add(new Vehicle(Type.motorcycle, new Brand("Fiat"), Colour.red, new Engine("diesel"), new Price(10000)));
            shop.Add(new Vehicle(Type.motorcycle, new Brand("VW"), Colour.green, new Engine("gasoline"), new Price(18000)));
            shop.Add(new Vehicle(Type.motorcycle, new Brand("Audi"), Colour.black, new Engine("diesel"),new Price(20000)));
            shop.Add(new Vehicle(Type.motorcycle, new Brand("Skoda"), Colour.blue, new Engine("gasoline"), new Price(7500)));
            shop.Add(new Vehicle(Type.personalCar, new Brand("Audi"), Colour.white, new Engine("gasoline"), new Price(30000)));
            shop.Add(new Vehicle(Type.personalCar, new Brand("VW"), Colour.green, new Engine("gasoline"), new Price(28000)));
            shop.Add(new Vehicle(Type.personalCar, new Brand("VW"), Colour.white, new Engine("diesel"), new Price(22000)));
            shop.Add(new Vehicle(Type.personalCar, new Brand("Fiat"), Colour.red, new Engine("gasoline"), new Price(6300)));
            shop.Add(new Vehicle(Type.personalCar, new Brand("BMW"), Colour.black, new Engine("gasoline"), new Price(26000)));
            shop.Add(new Vehicle(Type.van, new Brand("BMW"), Colour.black, new Engine("diesel"), new Price(11000)));
            shop.Add(new Vehicle(Type.van, new Brand("Skoda"), Colour.green, new Engine("diesel"), new Price(7800)));
            shop.Add(new Vehicle(Type.van, new Brand("Fiat"), Colour.green, new Engine("diesel"), new Price(3300)));
            shop.Add(new Vehicle(Type.truck, new Brand("VW"), Colour.black, new Engine("gasoline"), new Price(27000)));
            shop.Add(new Vehicle(Type.truck, new Brand("Skoda"), Colour.red, new Engine("diesel"), new Price(15000)));
            shop.Add(new Vehicle(Type.truck, new Brand("Skoda"), Colour.white, new Engine("diesel"),new Price(5000)));



            //List<Vehicle> sortedList = shop.OrderBy(o => o.vehicleColour).ToList();

            List<Vehicle> sortedVehicles = shop.OrderBy(colour => (int)(colour.vehicleColour)).ToList();

            List<Vehicle> sortedList = shop.OrderByDescending(x => (int)(x.vehicleType)).ToList();



            //shop.Sort(delegate (Vehicle x, Vehicle y)
            //{
            //   return x.vehiclePrice.CompareTo(y.vehiclePrice);
            //});
            Console.WriteLine("Zoradene podla typu");

            foreach (var item in sortedList )
            {
                Console.WriteLine(string.Join(" - ", item.vehicleType, item.vehicleBrand ,item.vehicleColour, item.vehicleEngine, item.vehiclePrice));
            }

            Console.WriteLine();
            Console.WriteLine("Zoradene podla farby");

            foreach (Vehicle item in sortedVehicles)
            {
                Console.WriteLine(string.Join( " - ", item.vehicleType, item.vehicleBrand, item.vehicleColour, item.vehicleEngine, item.vehiclePrice));
            }
            

            Console.ReadLine();


        }
    }
   
        
}
