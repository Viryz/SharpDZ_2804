using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(DateTime.Now, EngineType.Petrol, 250.0f, 25.0f, 5, 1, 100.0f);
            car.Display();
            car.AddNewPassanger();
            Console.WriteLine();
            car.Display();
            Console.ReadLine();
        }
    }
}
