using System;
using PureMVC.Patterns;

public class Daily128ChooseDifficultyProxy : Proxy
{
	public class Transfer
	{
		public Action<int> onSelectLevel;
	}

	public new const string NAME = "Daily128ChooseDifficultyProxy";

	public Daily128ChooseDifficultyProxy(object data)
	{
	}
}
