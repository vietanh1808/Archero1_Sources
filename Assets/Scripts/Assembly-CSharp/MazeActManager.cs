using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;

public sealed class MazeActManager : CInstance<MazeActManager>
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

	public const int mazeActId = 108;

	private List<ExchangeData> exchangeList;

	public long actTime;

	public int curId;

	private List<CRewardItem> rewardItems;

	public int charTheme;

	private bool isRequesting;

	private void init()
	{
	}

	public void requestActList(int location = 0, Action callback = null)
	{
	}

	public void requsetExchange(int id, int count)
	{
	}

	public List<ExchangeData> getExchangeList_Show()
	{
		return null;
	}

	public List<ExchangeData> getExchangeList()
	{
		return null;
	}

	public ExchangeData getExchangeData(int id)
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
