using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    internal class Intel : GPU
    {
        public int[] price = new int[] { 100, 110, 250, 380 };
        public string[] series = new string[] { "A310 LP 4G", "A380 ITX 6G", "A750 8G Limited Edition", "A770 OC 16G" };

        public override int total(int[] count)
        {
            int total = 0;
            for (int i = 0; i < count.Length; i++)
            {
                total += price[i] * count[i];
            }
            return total;
        }
    }
}
