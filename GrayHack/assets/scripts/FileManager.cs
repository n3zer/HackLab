using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GrayHack.assets.scripts
{
	internal class FileManager
	{
		public static string GameFilePath = @"gameFile";
		public static string pathToPlayerPc = $@"{GameFilePath}\computers\computer";


		public static void CreateFolder(string path)
        {
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);
		}

		

	}
}
