using System;
using System.Collections.Generic;

namespace RandallsCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, Dictionary<string, string>>> vehicles = new List<Dictionary<string, Dictionary<string, string>>>();


            Dictionary<string, Dictionary<string, string>> damfresh = new Dictionary<string, Dictionary<string, string>>();
            vehicles.Add(damfresh);

            Dictionary<string, string> vehicle1 = new Dictionary<string, string>();
            damfresh.Add("firstVehicle", vehicle1);
            vehicle1.Add("year", "2008");
            vehicle1.Add("model", "Damfresh");
            vehicle1.Add("make", "Biotraxquote");
            vehicle1.Add("color", "sky magenta");

            Dictionary<string, string> salesAgent1 = new Dictionary<string, string>();
            damfresh.Add("firstSalesAgent", salesAgent1);
            salesAgent1.Add("mobile", "(896) 478-6975");
            salesAgent1.Add("lastName", "Botsford");
            salesAgent1.Add("firstName", "Shaina");

            Dictionary<string, string> credit1 = new Dictionary<string, string>();
            damfresh.Add("firstCredit", credit1);
            credit1.Add("creditProvider", "J.P.Morgan Chase & Co");
            credit1.Add("account", "601109582720302");

            Dictionary<string, Dictionary<string, string>> hotquadtrax = new Dictionary<string, Dictionary<string, string>>();
            vehicles.Add(hotquadtrax);

            Dictionary<string, string> vehicle2 = new Dictionary<string, string>();
            hotquadtrax.Add("secondVehicle", vehicle2);
            vehicle2.Add("year", "2010");
            vehicle2.Add("model", "Hotquadtrax");
            vehicle2.Add("make", "Transtintechno");
            vehicle2.Add("color", "robin egg blue");

            Dictionary<string, string> salesAgent2 = new Dictionary<string, string>();
            hotquadtrax.Add("secondSalesAgent", salesAgent2);
            salesAgent2.Add("mobile", "562.300.2912");
            salesAgent2.Add("lastName", "Davis");
            salesAgent2.Add("firstName", "Gerardo");

            Dictionary<string, string> credit2 = new Dictionary<string, string>();
            hotquadtrax.Add("secondCredit", credit2);
            credit2.Add("creditProvider", "PNC Financial Services");
            credit2.Add("account", "34578280562836");

            foreach(Dictionary<string, Dictionary<string, string>> vehicle in vehicles)
            {
                foreach(KeyValuePair<string, Dictionary<string, string>> vehicleInfo in vehicle)
                {
                    Console.WriteLine(vehicleInfo.Key);
                    foreach(KeyValuePair<string, string> kvp in vehicleInfo.Value)
                    {
                        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    }
                }
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}
