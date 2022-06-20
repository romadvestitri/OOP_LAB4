using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace lab4
{
    public class ArchiveAdapter

    {
        public ArchiveAdapter(string dirname)
        {
            this.dirname = dirname;
        }
        
        public void Compression(string inputFile, string outputFile)
        {
            PluginAdder plugins = new PluginAdder();
            string[] dllnames = plugins.GetDll(dirname);
            Assembly asm = Assembly.LoadFrom(dllnames[0]);
            Type[] archiveManager = asm.GetTypes();
            Type t = archiveManager[3];
            
            object archive = Activator.CreateInstance(t);

            MethodInfo encrypt = t.GetMethod("CompressFile");
            encrypt.Invoke(archive, new object[] { });

        }
        public void Decompression(string inputFile, string outputFile)
        {
            PluginAdder plugins = new PluginAdder();
            string[] dllnames = plugins.GetDll(dirname);
            Assembly asm = Assembly.LoadFrom(dllnames[0]);
            Type[] archiveManager = asm.GetTypes();
            Type t = archiveManager[3];

            object archive = Activator.CreateInstance(t);

            MethodInfo encrypt = t.GetMethod("DecompressFile");
            encrypt.Invoke(archive, new object[] { });

        }

        public string dirname { get; set; }
    }
}
