using System;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class EquipInfoModuleProxy : Proxy, IProxy, INotifier
{
	public enum InfoType
	{
		eNormal = 0,
		eBuy = 1,
		mazeBuy = 2
	}

	public class Transfer
	{
		public LocalSave.EquipOne one;

		public InfoType type;

		public BlackItemOnectrl buy_itemone;

		public Action<BlackItemOnectrl> buy_callback;

		public Action updatecallback;

		public Action wearcallback;

		public MazeCombineItemCtl mazeEquipItem;

		public Action<object> clickBuyAct;

		public int mazeHaveCoin;

		public bool isShowCount;

		public bool isShowGemInfo;

		public int weaponSkinId;

		public bool isPreview;
	}

	public new const string NAME = "EquipInfoModuleProxy";

	public EquipInfoModuleProxy(object data)
	{
	}
}
