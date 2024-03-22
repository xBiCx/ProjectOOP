using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    internal class Nvidia : GPU
    {
        public int[] price = new int[] { 699, 179, 1625, 620, 2500, 1200 };
        public string[] series = new string[] { "GTX 1080ti", "GTX 1070ti", "RTX 3090ti", "RTX 3080ti", "RTX 4090 OC", "RTX 4080 OC" };

        public override int total(int[] count)
        {
            int total  = 0;
            for (int i = 0; i < count.Length; i++)
            {
                total += price[i] * count[i];
            }
            return total;
        }
    }
}
