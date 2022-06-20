using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class PluginAdder
    {
        public string[] GetDll(string dirname)
        {
            string[] files = Directory.GetFiles(dirname, "*.dll");
            return files;
        }
    }
}
