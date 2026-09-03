using System;
using System.Collections.Generic;
using GameProtocol;

public class RuneManager
{
	public static readonly int RUNE_NUM;

	public static readonly int MAX_ITEM;

	public static readonly int SKILL_RUNE_ID;

	public static readonly int RuneStoneId;

	public static RuneManager Instance;

	public Dictionary<int, RuneGroup> Groups;

	public Dictionary<int, RuneItemData[]> ServerData;

	public Dictionary<int, RuneItemData[]> ServerTempData;

	public Dictionary<int, RuneAchievementData> AchievementData;

	public int currentRuneIndex;

	public static bool IfRuneUnlockCached { get; private set; }

	static RuneManager()
	{
	}

	private RuneManager()
	{
	}

	public static int GetRuneStoneNum()
	{
		return 0;
	}

	public static bool SetRuneStoneNum(int targetNum)
	{
		return false;
	}

	public void Init()
	{
	}

	public bool IfRuneUnlock()
	{
		return false;
	}

	public bool IfReachUnlockLevel(int level)
	{
		return false;
	}

	public int GetRuneLevel()
	{
		return 0;
	}

	public void RequestRuneInfo(Action<bool, CRespRunePolish> OnResponse = null)
	{
	}

	public void RequestRunePolish(int runeId, Action<bool, int, CRespRunePolish> OnResponse = null)
	{
	}

	public void RequestSavePolish(int runeId, Action<bool, int, CRespRunePolish> OnResponse)
	{
	}

	public void RequestClearPolish(int runeId, Action<bool, int, CRespRunePolish> OnResponse)
	{
	}

	public void RequestActivateReward(int rewardId, Action<bool, int, int, CRespRunePolish> OnResponse)
	{
	}

	public void RequestActivateReward(int runeId, int rewardId, Action<bool, int, int, CRespRunePolish> OnResponse)
	{
	}

	public bool HasUngotTotalRewards()
	{
		return false;
	}

	public void OnRequestInfo(bool ifSuccess, CRespRunePolish data)
	{
	}

	public void OnRequestPolish(bool ifSuccess, int runeId, CRespRunePolish data)
	{
	}

	public void OnRequestSave(bool ifSuccess, int runeId, CRespRunePolish data)
	{
	}

	public void OnRequestClear(bool ifSuccess, int runeId, CRespRunePolish data)
	{
	}

	public void OnRequestActivateReward(bool ifSuccess, int runeId, int rewardId, CRespRunePolish data)
	{
	}

	public void InitFromJson(string itemJson, string tempItemJson)
	{
	}

	public void InitAchievement(string achievementJson)
	{
	}

	public void RefreshTemp(int groupId, string tempJson)
	{
	}

	public void ReplaceTemp(int groupId)
	{
	}

	public void DiscardTemp(int groupId)
	{
	}

	public void SaveRuneInfoToLocal()
	{
	}

	public List<string> GetAllEnhanceData()
	{
		return null;
	}

	public int getNatural_HatchAdd()
	{
		return 0;
	}

	public void Clear()
	{
	}
}
