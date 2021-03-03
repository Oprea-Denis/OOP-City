using System;

namespace city
{
    class City
    {
        static void Main(string[] args)
        {
            Street street1 = new Street("Str. Gavril Muzicescu", 16);
            Street street2 = new Street("Str. Vasile Alecsandri", 6);
            Street street3 = new Street("Str. Muzicii", 8);

            Console.WriteLine("Streets details:");
            Console.WriteLine($"#1: {street1.StreetName}, {street1.StreetNumber}");
            Console.WriteLine($"#2: {street2.StreetName}, {street2.StreetNumber}");
            Console.WriteLine($"#3: {street3.StreetName}, {street3.StreetNumber}");

            Building building1 = new Building("Muzeul Tarii Crisurilor");
            Building building2 = new Building("Penitenciar");
            Building building3 = new Building("Colegiul National Emanuil Gojdu");

            Console.WriteLine("\n");
            Console.WriteLine("Buildings details:");
            Console.WriteLine($"#1: {building1.BuildingName}");
            Console.WriteLine($"#2: {building2.BuildingName}");
            Console.WriteLine($"#3: {building3.BuildingName}");

            Car car1 = new Car("Audi", "A6", 2015, "BH-55-RPD");
            Car car2 = new Car("BMW", "M850", 2020, "BH-12-BMW");
            Car car3 = new Car("Subaru", "Impreza", 2002, "BH-15-BOS");
            Car car4 = new Car("Mazda", "Rx8", 2006, "BH-57-MZD");


            Console.WriteLine("\n");
            Console.WriteLine("Cars details:");
            Console.WriteLine($"#1: {car1.Brand}, {car1.Model}, {car1.Year}, {car1.Plate},");
            Console.WriteLine($"#2: {car2.Brand}, {car2.Model}, {car2.Year}, {car2.Plate},");
            Console.WriteLine($"#3: {car3.Brand}, {car3.Model}, {car3.Year}, {car3.Plate},");
            Console.WriteLine($"#4: {car4.Brand}, {car4.Model}, {car4.Year}, {car4.Plate},");


        }
    }
}