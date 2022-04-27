using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Car
    {
        public string Brand { get; set; }
        public string NumberPlate { get; set; }
        public double Speed { get; set; }

        public void StartDrive()
        {
            Speed = 10;
            Console.WriteLine("Sakam braukšanu");

        }

        public double DriveFaster()
        {
            Speed += 10;
            Console.WriteLine("Ātrums - " + Speed);
            return Speed;

        }

        public void StopDrive()
        {
            Speed = 0;
            Console.WriteLine("Apstāšanās");

        }

        public double DriveSlower()
        {
            Speed -= 10;
            Console.WriteLine("Ātrums - " + Speed);
            return Speed;

        }

        public void Beep()
        {
            Console.WriteLine("BEEP");
        }
    }
}
