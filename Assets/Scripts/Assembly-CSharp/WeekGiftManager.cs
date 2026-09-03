using System;
using System.Collections.Generic;
using GameProtocol;

public sealed class WeekGiftManager : CInstance<WeekGiftManager>
{
	public class GiftData
	{
		public int day;

		public int type;

		public int eid;

		public int count;
	}

	public int weekTag;

	public long timeWeek;

	public int from;

	public int to;

	public int loginDays;

	private List<GiftData> giftList;

	public List<CRewardItem> rewardItems;

	public void requestWeekGift(int type, bool open = true, Action<bool> callback = null)
	{
	}

	public List<GiftData> getGiftData(int day)
	{
		return null;
	}

	public bool isToday(int day)
	{
		return false;
	}

	public bool isEndDay()
	{
		return false;
	}

	public bool canGetGift()
	{
		return false;
	}

	public bool isShow()
	{
		return false;
	}
}
