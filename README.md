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

Licencia
======================================================================

	Folder App Maker, Crea estructura de carpetas previamente condiguradas.
	Copyright (C) 2017  Benjamin Olmos <bolmosc1@gmail.com>

	--------------------------------------------------------------------------------
	This program is free software; you can redistribute it and/or
	modify it under the terms of the GNU General Public License
	as published by the Free Software Foundation; either version 2
	of the License, or (at your option) any later version.

	This program is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with this program; if not, write to the Free Software
	Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
	--------------------------------------------------------------------------------

	For more details about license see the file LICENCE.txt.
