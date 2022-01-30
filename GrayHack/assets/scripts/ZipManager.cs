using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using GrayHack.Properties;




namespace GrayHack.assets.scripts
{
	internal class ZipManager
	{
		private static string _packagesFormat = ".graypack";
		public static void ExtractFile(string path, byte[]file)
		{
			ExtractFile(path, string.Empty, file);
		}

		public static void ExtractFile(string path, string nameFile, byte[] file)
		{

            string pathZip = $@"{path}\{nameFile}{_packagesFormat}";

            FileManager.CreateFolder(path);
            File.WriteAllBytes(pathZip, file);

            if (Directory.Exists($@"{path}\{nameFile}"))
                Directory.Delete($@"{path}\{nameFile}", true);

            ZipFile.ExtractToDirectory(pathZip, path);
            File.Delete(pathZip);
        }

	}
}
