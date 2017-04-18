# FolderAppMaker
Crea estructura de carpetas previamente configuradas

Uso
======================================================================

    Usage:
      folderappmaker  [project] [--rutabase=<ruta>] <name> [--full] [--result | --show]
      folderappmaker  (-h | --help)
      folderappmaker  --version

    Options:
      --full        Create full structure.
      -h --help     Show this screen.
      --result  Show result on screen.
      --rutabase=<ruta>  Path base for the structure [detault: current path].
      --show  Show structure on screen without create it.
      --version     Show version.

Ejemplos

    #1
	folderappmaker NombreApp
		Crea carpetas basicas para aplicacion de NombreApp en ruta Base.

     #2
	 folderappmaker project NombreProyecto
		Crea carpetas basicas para el proyecto de NombreProyecto en ruta Base.
    
     #3
	 folderappmaker NombreApp --rutabase="D:\Carpeta" --full
		Crea listado completo de carpetas en la ruta base especificada para la aplicacion de NombreApp

     #4
	 folderappmaker NombreApp --rutabase="D:\Carpeta" --full --show
		Muestra listado completo de carpetas (sin crearlas) en la ruta base especificada para la aplicacion de NombreApp

Instalación
======================================================================

Copiar el contenido de la carpeta bin y pegar en ``ruta``

    COPYING.txt
    DocoptNet.dll
    FolderAppMaker.exe
    FolderAppMaker.exe.config
    LICENSE-MIT.txt
    README.md
    System.Configuration.dll

Donde ``ruta`` es cualquier directorio dentro del sistema.

Agregar ``ruta`` dentro de las variables de entorno **PATH** de usuario
