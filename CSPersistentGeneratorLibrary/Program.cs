using CSAc4yClass.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPersistentGeneratorLibrary
{
    public class Program
    {
        public static void MainMethod(string _inpath, string _outpath, string _defaultNamespace, string templatesFolder)
        {

            //Date: 2019. 11. 2. 16:48
            if (!Directory.Exists(_outpath + "PersistentMethods"))
                Directory.CreateDirectory(_outpath + "PersistentMethods");

            string[] files =
                Directory.GetFiles(_inpath, "*.xml", SearchOption.TopDirectoryOnly);

            foreach (var _file in files)
            {
                string _filename = Path.GetFileNameWithoutExtension(_file);
                Console.WriteLine(_filename);

                Ac4yClass ac4y = DeserialiseMethod.deser(_file);
            }

                EntityGenerate.entityGenerateMethods(files, _defaultNamespace, _outpath, templatesFolder);
            
        }
    }
}