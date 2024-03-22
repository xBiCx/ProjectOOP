using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    internal class AMD : GPU
    {
        public int[] price = new int[] {150,115,222,345,750,570};
        public string[] series = new string[] { "RX 5800 XT", "RX 5700 XT", "RX 6900 XT", "RX 6800 XT", "RX 7900 XT", "RX 7800 XT" };

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
