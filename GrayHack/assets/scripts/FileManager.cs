using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using GrayHack.Properties;

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

        public static List<IconManager> GetFilesInFolder(List<IconManager>, string path)
        {
            List < IconManager > res = new List < IconManager >();
            if (File.Exists(path))
            {
                var files = Directory.GetFiles(path);
                foreach (var file in files)
                {
                    //res.Add(new IconManager( ))
                }
            }

            return res;
        }



    }
}
