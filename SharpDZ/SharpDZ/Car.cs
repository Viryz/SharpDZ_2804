using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpDZ
{
    enum EngineType { Petrol, Diesel }

    class Car
    {
        private readonly DateTime productDate;
        private EngineType engineType;
        private float maxSpeed;
        private float accelerationTimeTo100KmHour;
        private int countPassangers;
        private int countPassangersNow;
        private float speedNow;

        List<CarWheel> wheels = new List<CarWheel>();
        List<CarDoor> doors = new List<CarDoor>();

        public Car(DateTime productDate)
        {
            this.productDate = productDate;
        }
        public Car(DateTime productDate
            , EngineType engineType
            , float maxSpeed
            , float accelerationTimeTo100KmHour
            , int countPassangers
            , int countPassangersNow
            , float speedNow)
        {
            this.productDate = productDate;
            this.engineType = engineType;
            this.maxSpeed = maxSpeed;
            this.accelerationTimeTo100KmHour = accelerationTimeTo100KmHour;
            this.countPassangers = countPassangers;
            this.countPassangersNow = countPassangersNow;
            this.speedNow = speedNow;
        }

        public void SetSpeedNow(float speed)
        {
            if (speed >= 0)
                speedNow = speed;
        }
        public void AddNewPassanger()
        {
            if (countPassangersNow < countPassangers)
                countPassangersNow++;
            else Console.WriteLine("Car is full");
        }
        public void GetPassanger()
        {
            if (countPassangersNow > 0)
                countPassangersNow--;
            else Console.WriteLine("Car is empty");
        }
        public void GetAllPassangers()
        {
            countPassangersNow = 0;
        }
        public CarDoor GetDoor(int index)
        {
            return doors[index];
        }
        public CarWheel GetWheel(int index)
        {
            return wheels[index];
        }
        public void AddNewWheels(int count)
        {
            for (int i = 0; i < count; i++)
                wheels.Add(new CarWheel());
        }
        public float CalculateMaxSpeed()
        {
            if (countPassangersNow == 0)
                return 0.0f;
            float max = wheels.Max(w => w.Integrity);
            return max * maxSpeed;
        }
        public void Display()
        {
            Console.WriteLine("Product date: {0}", productDate);
            Console.WriteLine("EngineType: {0}", engineType);
            Console.WriteLine("Max speed: {0}", maxSpeed);
            Console.WriteLine("Acceleration time to 100 Km/Hour: {0}", accelerationTimeTo100KmHour);
            Console.WriteLine("Count passangers: {0}", countPassangers);
            Console.WriteLine("Count passangers now: {0}", countPassangersNow);
            Console.WriteLine("Speed now: {0}", speedNow);
        }
    }
}
