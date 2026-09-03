using System.Collections.Generic;
using PureMVC.Patterns;
using TableTool;

public class RewardShowProxy : Proxy
{
	public class Transfer
	{
		public List<Drop_DropModel.DropData> list;
	}

	public new const string NAME = "RewardShowProxy";

	public RewardShowProxy(object data)
	{
	}
}
