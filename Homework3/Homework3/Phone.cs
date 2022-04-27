using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Phone

    {
        public string Size { get; set; }
        public string Model { get; set; }
        public string Mark { get; set; }

        public void Call()
        {
            Console.WriteLine("Calling");
        }

        public void SendSms()
        {
            Console.WriteLine("SMS sent");
        }

    }
}
