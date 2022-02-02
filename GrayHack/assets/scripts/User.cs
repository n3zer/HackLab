using System;
using System.Collections;
using System.Collections.Generic;

namespace GrayHack.assets.scripts
{
	
	public class User
	{
		public string _name;
		public string _nowPath;
		public string _pcPath;
		public int _exp;

		public List<Quest> _questList;

		public User(string name, string nowPath, string pcPath, int exp, List<Quest> questList)
        {
			_name = name;
			_nowPath = nowPath;
			_pcPath = pcPath;
			_exp = exp;

			_questList = questList;
        }

		public User(string name, string nowPath, string pcPath, int exp)
		{
			_name = name;
			_nowPath = nowPath;
			_pcPath = pcPath;
			_exp = exp;

			_questList = Quest._quests;
		}
	}
}
