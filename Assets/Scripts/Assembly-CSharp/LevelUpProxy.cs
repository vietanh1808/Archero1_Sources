using System;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class LevelUpProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public int level;

		public int? oldLevel;

		public int levelType;

		public Action onclose;
	}

	public new const string NAME = "LevelUpProxy";

	public LevelUpProxy(object data)
	{
	}
}
