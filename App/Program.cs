using App.Business;
using App.Domain.Business;
using App.Domain.Model;
using System;
using System.IO;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ICarService carService = new CarService();
            Car car = new("Red", "Corolla", "Toyta", "1234-532");

            var result = await carService.Save(car);
            Console.WriteLine(result.ToString());


            Console.WriteLine(File.ReadAllText("db.txt"));

        }
    }
}
