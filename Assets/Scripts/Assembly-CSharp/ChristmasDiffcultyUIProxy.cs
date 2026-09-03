using System;
using PureMVC.Patterns;

public class ChristmasDiffcultyUIProxy : Proxy
{
	public class Transfer
	{
		public Action UpdateLevelAction;
	}

	public new const string NAME = "ChristmasDiffcultyUIProxy";

	public Transfer transfer;
}
