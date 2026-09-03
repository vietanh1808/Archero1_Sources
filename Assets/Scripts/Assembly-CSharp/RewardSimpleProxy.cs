using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using TableTool;

public class RewardSimpleProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public List<Drop_DropModel.DropData> list;

		public int extraCount;

		public string desc;

		public Action onEventClosed;

		public bool isEndAni;
	}

	public new const string NAME = "RewardSimpleProxy";

	public RewardSimpleProxy(object data)
	{
	}
}
