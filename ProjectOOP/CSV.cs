using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    internal class CSV
    {
        private string path = @"D:\C#\ProjectOOP\Project.CSV";

        public bool SavetoFile(string brand, List<string> series, int count, int total)
        {
            string content = brand + " , " + String.Join(" : ", series.ToArray()) + " , ";
            content += count + " piece , " + total + "$" + "\n";

            try
            {
                File.WriteAllText(path, content);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
