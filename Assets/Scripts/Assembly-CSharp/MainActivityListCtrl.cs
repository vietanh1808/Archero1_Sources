using System.Collections.Generic;
using UnityEngine;

public class MainActivityListCtrl : MonoBehaviour
{
	private const int FirstPurchase = 0;

	private const int GrowthFund = 1;

	private const int Daily = 2;

	private const int Week = 3;

	private const int Month = 4;

	public GameObject copyDailyItem;

	public GameObject copyWeekItem;

	public GameObject copyMonthItem;

	public FirstRewardOneCtrl firstReward;

	public WatchAdRewardOneCtrl watchAdReward;

	public DxxText Text_Empty;

	public RectTransform contentTrans;

	public RectTransform FirstRewardParent;

	public RectTransform GrowthFundParent;

	public RectTransform DailyParent;

	public RectTransform WeekParent;

	public RectTransform MonthParent;

	private List<DailyActivityOneCtrl> dailyList;

	private List<WeekActivityOneCtrl> weekList;

	private List<MonthActivityOneCtrl> monthList;

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void Refresh(int tab, bool isReset)
	{
	}

	private void RefreshFirst()
	{
	}

	private void RefreshGrowthFund()
	{
	}

	private void RefreshDaily()
	{
	}

	private void RefreshWeek()
	{
	}

	private void RefreshMonth()
	{
	}

	private void EmptyShow(bool value)
	{
	}

	public void OnLanguageChange()
	{
	}
}
