using System;
using System.Collections.Generic;
using TableTool;

public sealed class ThemeSupplyBoxManager
{
	public static ThemeSupplyBoxManager Instance;

	public ThemeSupplyBoxHero heroBox;

	public ThemeSupplyBoxGem gemBox;

	public long dataTimestamp;

	public long refreshTimestamp;

	public long startTimestamp;

	public long endTimestamp;

	static ThemeSupplyBoxManager()
	{
	}

	public bool IfValid()
	{
		return false;
	}

	private ThemeSupplyBoxManager()
	{
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public static List<Drop_DropModel.DropData> RewardsToList(string rewards)
	{
		return null;
	}

	public void SendRequestShopInfo(Action<bool> callback = null)
	{
	}

	public void SendSelectHero(int index, Action<bool> callback = null)
	{
	}

	public bool QueryIapExtData(string productId, out int[] data)
	{
		data = null;
		return false;
	}
}
