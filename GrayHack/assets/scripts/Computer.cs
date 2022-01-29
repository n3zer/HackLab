using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrayHack.assets.scripts;

namespace GrayHack
{
    internal class Computer
    {
		List<string> _computerFiles = new List<string>
        {
			@"etc\apt\passwd.bin",
			@"etc\apt\xorg.conf",
			@"etc\apt\fstab.bin",
			@"etc\apt\sources.txt",

			@"lib",

			@"sys\xorg.sys",
			@"sys\config.sys",
			@"sys\network.cfg",

			@"home",

			@"var\syslog.var",

			@"usr\bin",

			@"boot\System.map",
			@"boot\initrd.img",
			@"boot\kernel.img"
		};

		public static void CreatUsers(string pc, string userName, string userPassword)
		{
			FileManager.CreateFolder($@"{FileManager.GameFilePath}\{userName}-pc");
		}

		public static void CreatPc(string pcName)
		{
			FileManager.CreateFolder($@"{FileManager.GameFilePath}\{pcName}-pc");

		}
	}
}
