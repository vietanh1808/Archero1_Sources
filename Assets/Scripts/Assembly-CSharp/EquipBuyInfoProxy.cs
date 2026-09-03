using System;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class EquipBuyInfoProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public BlackItemOnectrl itemone;

		public Action<BlackItemOnectrl> callback;
	}

	public new const string NAME = "EquipBuyInfoProxy";

	public EquipBuyInfoProxy(object data)
	{
	}
}
