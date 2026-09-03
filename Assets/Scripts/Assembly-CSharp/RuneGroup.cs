using System.Collections.Generic;
using TableTool;

public class RuneGroup
{
	public Runes_Runes Data;

	private RuneItemData[] ServerItems;

	private RuneItemData[] ServerTempItems;

	private RuneAchievementData AchievementData;

	private List<RuneTotalRewardItem> totalRewardItems;

	private List<RuneDexItem> dexItems;

	public List<RuneItem> Items;

	public List<RuneItem> TempItems;

	public bool IfUnlock => false;

	public bool IfShowDesc => false;

	public int RuneId => 0;

	public string RuneIcon => null;

	public int UnlockLevel => 0;

	public int GetItemUnlockLevelByIndex(int index)
	{
		return 0;
	}

	public RuneGroup(Runes_Runes data)
	{
	}

	public void SetItemByData(RuneItemData[] datas, bool ifTemp)
	{
	}

	public void AddCountAndUnlockDex(RuneItemData[] datas)
	{
	}

	public void SetAchievementData(RuneAchievementData data)
	{
	}

	private void InitTotalRewardData()
	{
	}

	public void ActivateTotalReward(int rewardId)
	{
	}

	public bool HasUngotTotalReward()
	{
		return false;
	}

	private void InitDexData()
	{
	}

	private void ActivateDex(int storeId)
	{
	}

	private static void DumpToSet(SortedSet<int> hashSet, int[] items)
	{
	}

	public int GetCount()
	{
		return 0;
	}

	public List<RuneTotalRewardItem> GetTotalRewardItems()
	{
		return null;
	}

	public List<RuneDexItem> GetDexItems()
	{
		return null;
	}

	public void ReplaceItem()
	{
	}

	public void DiscardTemp()
	{
	}

	public bool IfReachUnlockLevel(int level)
	{
		return false;
	}

	public int AppendEnhanceData(List<string> dataList)
	{
		return 0;
	}
}
