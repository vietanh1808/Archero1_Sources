using System.Collections.Generic;
using GameProtocol;

public class TreasureLevelData
{
	private STRespActivityAngelPurify mData;

	private HolyLightMgr.TreasurePrivilegeConfig[] mConfigs;

	public int TotalLevels => 0;

	public int CurrentLevel => 0;

	public TreasureLevelData(STRespActivityAngelPurify data, HolyLightMgr.TreasurePrivilegeConfig[] configs)
	{
	}

	public bool IsLevelActivated(int level)
	{
		return false;
	}

	public TreasureTaskInfo GetTasksForLevel(int level)
	{
		return null;
	}

	public List<TreasurePrivilegeInfo> GetPrivilegesForLevel(int level)
	{
		return null;
	}

	public int GetPrivilegeValue(int privilegeType)
	{
		return 0;
	}

	private int GetTaskProgress(int missionId)
	{
		return 0;
	}

	private string GetMissionDesc(int missionType, params object[] args)
	{
		return null;
	}
}
