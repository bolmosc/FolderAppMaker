





















using System.Collections;
using System.Collections.Generic;
using DocoptNet;

namespace FolderAppMaker
{

    // Generated class for Main.usage.txt
	public class MainArgs
	{
		public const string USAGE = @"Example usage for Folder App Maker

Usage:
  folderappmaker  [project] [--rutabase=<ruta>] <name> [--full] [--result | --show]
  folderappmaker  (-h | --help)
  folderappmaker  --version

Options:
  --full        Create full structure.
  -h --help     Show this screen.
  --result  Show result on screen.
  --rutabase=<ruta>  Path base for the structure [detault: current path].
  --show  Show structure on screen.
  --version     Show version.

Ejemplos

    #1
	folderappmaker NombreApp
		Crea carpetas basicas para aplicacion de NombreApp en ruta Base.

     #2
	 folderappmaker project NombreProyecto
		Crea carpetas basicas para el proyecto de NombreProyecto en ruta Base.";
	    private readonly IDictionary<string, ValueObject> _args;
		public MainArgs(ICollection<string> argv, bool help = true,
                                                      object version = null, bool optionsFirst = false, bool exit = false)
		{
			_args = new Docopt().Apply(USAGE, argv, help, version, optionsFirst, exit);
		}

        public IDictionary<string, ValueObject> Args
        {
            get { return _args; }
        }

public bool CmdProject { get { return _args["project"].IsTrue; } }
		public string OptRutabase { get { return null == _args["--rutabase"] ? null : _args["--rutabase"].ToString(); } }
		public string ArgName  { get { return null == _args["<name>"] ? null : _args["<name>"].ToString(); } }
		public bool OptFull { get { return _args["--full"].IsTrue; } }
		public bool OptResult { get { return _args["--result"].IsTrue; } }
		public bool OptShow { get { return _args["--show"].IsTrue; } }
		public bool OptHelp { get { return _args["--help"].IsTrue; } }
		public bool OptVersion { get { return _args["--version"].IsTrue; } }
	
	}

	
}

