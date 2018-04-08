using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remix.Functions
{
    public class System
    {
        public static void println(object[] obj)
        {
            string s = String.Empty;

            for (int i = 0; i < obj.Length; i++)
            {
                s += Convert.ToString(obj[i]).Trim('"');
            }

            Console.WriteLine("> " + s);
        }
    }
}
