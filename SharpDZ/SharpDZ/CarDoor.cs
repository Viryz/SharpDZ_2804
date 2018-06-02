using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpDZ
{
    enum Door { Open, Close }
    enum Window { Open, Close }

    class CarDoor
    {
        Door door;
        Window window;

        public CarDoor()
        {
            door = Door.Close;
            window = Window.Close;
        }
        public CarDoor(Door door, Window window)
        {
            this.door = door;
            this.window = window;
        }

        public void OpenDoor()
        {
            door = Door.Open;
        }
        public void CloseDoor()
        {
            door = Door.Close;
        }
        public void OpenCloseDoor()
        {
            if (door == Door.Open)
                door = Door.Close;
            else door = Door.Open;
        }

        public void OpenWindow()
        {
            window = Window.Open;
        }
        public void CloseWindow()
        {
            window = Window.Close;
        }
        public void OpenCloseWindow()
        {
            if (window == Window.Open)
                window = Window.Close;
            else window = Window.Open;
        }

        public void Display()
        {
            Console.WriteLine("Door: " + door.ToString());
            Console.WriteLine("Window: " + window.ToString());
        }
    }
}
