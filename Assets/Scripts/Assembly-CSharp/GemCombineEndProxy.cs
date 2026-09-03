using System.Collections.Generic;
using GameProtocol;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class GemCombineEndProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public bool batch;

		public List<CRewardItem> result;

		public List<int> basic;
	}

	public new const string NAME = "GemCombineEndProxy";

	public GemCombineEndProxy(object data)
	{
	}
}
