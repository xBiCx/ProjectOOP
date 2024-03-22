using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    internal class GPU
    {
        public  int[] price = new int[6];
        public virtual int total(int[] count)
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
