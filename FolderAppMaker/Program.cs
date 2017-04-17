using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;

namespace FolderAppMaker
{
    class Program
    {
        static private string _dirBase;
        static private string _dirPadre;
        static List<string> _dirs = new List<string>();

        static void Main(string[] argv)
        {
            // Automatically exit(1) if invalid arguments
            var args = new MainArgs(argv, version: "Folder App Maker 0.1.0", exit: true);

            string section = args.CmdProject ? "directoriosProject" : "directoriosApp";

            try
            {
                _dirBase = ObtieneDirBase(args.OptRutabase);
                _dirPadre = ObtieneDirPadre(args.ArgName);

                if (!Directory.Exists(_dirBase) && args.OptShow == false)
                    throw new Exception("!Directorio base inexistente!, se aborta proceso.");

                if (Directory.Exists(_dirPadre) && args.OptShow == false)
                    throw new Exception("!Directorio padre existente!, se aborta proceso.");

                NameValueCollection settingCollection = (NameValueCollection)ConfigurationManager.GetSection(section);
                string[] allKeys = settingCollection.AllKeys;

                foreach (string key in allKeys)
                {
                    if (settingCollection[key] == "Base" || args.OptFull)
                        _dirs.Add(key);
                }

                if (args.OptShow)
                    MostrarDirectorios();
                else
                    CrearDirectorios(args.OptResult);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static private string ObtieneDirBase(string ruta)
        {
            string fullPath = "";

            if (ruta == null)
                fullPath = Environment.CurrentDirectory;
            if (Path.IsPathRooted(ruta))
                fullPath = Path.GetFullPath(ruta);

            if (fullPath == "")
                throw new Exception("!No se pudo establecer el directorio base!, se aborta proceso.");

            return fullPath;
        }

        static private string ObtieneDirPadre(string name)
        {
            return Path.Combine(_dirBase, name);
        }

        static private void MostrarDirectorios()
        {
            string subdir = "";

            Console.WriteLine(String.Format("Dir {0}", _dirPadre));

            foreach (string dir in _dirs)
            {
                subdir = Path.Combine(_dirPadre, dir);
                Console.WriteLine(String.Format("Dir {0}", subdir));
            }
        }

        static private void CrearDirectorios(bool bResult)
        {
            //Crea directorio padre
            Directory.CreateDirectory(_dirPadre);
            if (bResult)
                Console.WriteLine(String.Format("Dir {0} Created!.", _dirPadre));

            //Crea directorios hijos
            string subdir = "";
            foreach (string dir in _dirs)
            {
                subdir = Path.Combine(_dirPadre, dir);
                Directory.CreateDirectory(subdir);
                if (bResult)
                    Console.WriteLine(String.Format("Dir {0} Created!.", subdir));
            }
        }
    }
}
