using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.Maxex
{
    class HardwareShop
    {
        int hardwareprice;
        string hardwarename;

        public HardwareShop(int hardwareprice, string hardwarename)
        {
            this.hardwareprice = hardwareprice;
            this.hardwarename = hardwarename;
        }

        static void Main(string[] args)
        {
            Dictionary<string, int> hardware = new Dictionary<string, int>();
            hardware.Add("Tap", 500);
            hardware.Add("Cupbord", 400);
            hardware.Add("SoapCase", 150);
            Console.WriteLine(hardware["Cupbord"]);
            Console.WriteLine(hardware.ContainsKey("SoapCase"));
            hardware.Remove("Cupbord");


            foreach(KeyValuePair<string,int> hardshop in hardware)
            {
                Console.WriteLine(hardshop.Key + "..........>" + hardshop.Value);
            }
            Dictionary<Shopping, long> shophardware = new Dictionary<Shopping, long>();
            shophardware.Add(new Shopping("Shoe", 254), 8524567);
            shophardware.Add(new Shopping("Chai", 460), 555555);
            shophardware.Add(new Shopping("Mat", 500), 5556666);
            shophardware.Add(new Shopping("Box", 987), 5558457);

            foreach(KeyValuePair<Shopping,long> shopinhardware in shophardware)
            {
                Console.WriteLine(shopinhardware.Key + "------------------------>" + shopinhardware.Value);

            }
        }
    }
}
