using System;
using System.Collections.Generic;
using GameProtocol;

public class GameAchievementManager
{
	public class ServerData
	{
		public int Type;

		public int index;
	}

	public static GameAchievementManager Instance;

	public Dictionary<int, int> AchieveLocalDic;

	public Action UpdateUI;

	public static List<GameAchievementBase> AchievementList;

	public List<GameAchievementBase.GameAchievementElement> ValidList;

	private CGuildAchInfo m_guildAchInfo;

	public int ValidCount => 0;

	public int GuildSignCnt => 0;

	public int GuildDonateCnt => 0;

	public int GuildTaskCnt => 0;

	public int GuildShareCnt => 0;

	public int GuildHelpCnt => 0;

	static GameAchievementManager()
	{
	}

	private void Init()
	{
	}

	private GameAchievementManager()
	{
	}

	private void OnEventGuildUpdate(object pData)
	{
	}

	private void OnGuildLevelUp(object data)
	{
	}

	public void ProcessAchievement()
	{
	}

	public void SendRequestAchievements()
	{
	}

	public void SendGetRewards(int achieveId, GameAchievementBase.GameAchievementElement element)
	{
	}

	public bool IfCanShow()
	{
		return false;
	}

	public bool canShow()
	{
		return false;
	}

	public void OnChangeAchievements(string json)
	{
	}

	public void LoadData()
	{
	}

	public void DeInit()
	{
	}

	public void RefreshValidData()
	{
	}

	public static GameAchievementBase GetOrCreateAchievement(int typeId)
	{
		return null;
	}
}
