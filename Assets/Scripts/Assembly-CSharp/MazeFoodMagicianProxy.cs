using System;
using PureMVC.Patterns;

public class MazeFoodMagicianProxy : Proxy
{
	public class Transfer
	{
		public Action<int> buySkill;

		public void Call(int skillID)
		{
		}
	}

	public new const string NAME = "MazeFoodMagicianProxy";

	public MazeFoodMagicianProxy(object data)
	{
	}
}
