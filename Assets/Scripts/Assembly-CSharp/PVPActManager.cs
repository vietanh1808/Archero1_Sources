using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;
using XLua;

public sealed class PVPActManager : CInstance<PVPActManager>
{
	public class ExchangeData
	{
		public int actId;

		public int index;

		public int needType;

		public int needId;

		public int needCount;

		public int getType;

		public int getId;

		public int getCount;

		public int getExpire;

		public int left;

		public int have;

		public bool free;
	}

	public bool isHaveGetServerData;

	private List<ExchangeData> exchangeList;

	public long actTime;

	public int curId;

	private List<CRewardItem> rewardItems;

	private bool isRequesting;

	private static DelegateBridge _c__Hotfix0_ctor;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_requestActList;

	private static DelegateBridge __Hotfix0_RequestExchange;

	private static DelegateBridge __Hotfix0_getExchangeList;

	private static DelegateBridge __Hotfix0_GetExchangeData;

	private static DelegateBridge __Hotfix0_getRewardItems;

	private static DelegateBridge __Hotfix0_isCanExchange;

	private static DelegateBridge __Hotfix0_ShowAutoExchange;

	private void init()
	{
	}

	public void requestActList(int location, Action callback = null)
	{
	}

	public void RequestExchange(int id, int count)
	{
	}

	public List<ExchangeData> getExchangeList()
	{
		return null;
	}

	public ExchangeData GetExchangeData(int id)
	{
		return null;
	}

	public List<CRewardItem> getRewardItems()
	{
		return null;
	}

	public bool isCanExchange(ExchangeData data)
	{
		return false;
	}

	public static void ShowAutoExchange(List<Drop_DropModel.DropData> list)
	{
	}
}
