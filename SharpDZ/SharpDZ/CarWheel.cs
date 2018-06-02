using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpDZ
{
    class CarWheel
    {
        private float integrity;

        public CarWheel()
        {
            integrity = 1;
        }
        public CarWheel(float integrity)
        {
            this.integrity = integrity;
        }

        public void Update()
        {
            integrity = 1;
        }
        public void Rub(int persent)
        {
            integrity *= (persent / 100.0f);
        }

        public float Integrity { get { return integrity; } }

        public void Display()
        {
            Console.WriteLine("Integrity of wheel: " + integrity.ToString());
        }
    }
}
