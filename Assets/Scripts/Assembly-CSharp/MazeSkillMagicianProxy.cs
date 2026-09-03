using System;
using PureMVC.Patterns;

public class MazeSkillMagicianProxy : Proxy
{
	public class Transfer
	{
		public Action<int> buySkill;

		public void Call(int skillID)
		{
		}
	}

	public new const string NAME = "MazeSkillMagicianProxy";

	public MazeSkillMagicianProxy(object data)
	{
	}
}
