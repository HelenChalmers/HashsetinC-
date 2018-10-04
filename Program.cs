using System;
using System.Collections.Generic;

namespace Hashset
{
    class Program
    {
        static void Main()
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Camry");
            Showroom.Add("Civic");
            Showroom.Add("Accord");
            Showroom.Add("CRV");
        
            Console.WriteLine(Showroom.Count);
            Showroom.Add("Civic");
            foreach (string item in Showroom)
            {
                // Console.WriteLine(item);
            }
            HashSet<string>  UsedLot= new HashSet<string>();
            UsedLot.Add("Escape");
            UsedLot.Add("Wrangler");

            Showroom.UnionWith(UsedLot);
            foreach(string item in Showroom)
            {
                // Console.WriteLine(item);
            }

            Showroom.Remove("Wrangler");
            foreach(string item in Showroom)
            {
                // Console.WriteLine(item);
            }

            HashSet<string> JunkYard = new HashSet<string>();
            JunkYard.Add("Wrangler");
            JunkYard.Add("Escape");
            JunkYard.Add("Element");
            JunkYard.Add("Altima");

            HashSet<string> clone = new HashSet<string>(Showroom);
            clone.IntersectWith(JunkYard);
            foreach (string item in clone)
            {
                // Console.WriteLine(item);
            }

            Showroom.UnionWith(JunkYard);
            foreach(string item in Showroom)
            {
                Console.WriteLine(item);
            }

            Showroom.Remove("Wrangler");
            Showroom.Remove("Escape");
            Showroom.Remove("Element");


    }
}
}
