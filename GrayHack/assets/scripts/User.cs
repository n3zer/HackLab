using System;
using System.Collections.Generic;

namespace GrayHack.assets.scripts
{
	
	internal class User
	{
		private string _name;
		private string _nowPath;
		private string _pcPath;
		private int _exp;

		Quest _questList;

		public User(string name, string nowPath,string pcPath, int exp, Quest questList)
        {
			_name = name;
			_nowPath = nowPath;
			_pcPath = pcPath;
			_exp = exp;

			_questList = questList;
        }

	}
}
