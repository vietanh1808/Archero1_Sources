using System;
using PureMVC.Patterns;

public class ChooseDifficultyProxy : Proxy
{
	public class Transfer
	{
		public Action<int> OnChooseDifficulty;

		public Transfer(Action<int> callback)
		{
		}
	}

	public new const string NAME = "ChooseDifficultyProxy";

	public ChooseDifficultyProxy(object data)
	{
	}
}
