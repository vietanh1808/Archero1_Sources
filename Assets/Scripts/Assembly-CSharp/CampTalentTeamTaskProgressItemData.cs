using System.Collections.Generic;
using TableTool;
using XLua;

public class CampTalentTeamTaskProgressItemData
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_CurScore;

	private static DelegateBridge __Hotfix0_get_CurNeedScore;

	private static DelegateBridge __Hotfix0_get_Status;

	private static DelegateBridge __Hotfix0_get_CanGetReward;

	private static DelegateBridge __Hotfix0_get_Rewards;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_GetCuScore;

	private static DelegateBridge __Hotfix0_GetStatus;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTalentTeamTaskProgressItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public int CurScore => 0;

	public int CurNeedScore => 0;

	public CampTalentTeamTaskStatus Status => CampTalentTeamTaskStatus.None;

	public bool CanGetReward => false;

	public List<Drop_DropModel.DropData> Rewards => null;

	public static CampTalentTeamTaskProgressItemData Create(CampTalentTeamTaskProgressItemConfigData configData)
	{
		return null;
	}

	private int GetCuScore()
	{
		return 0;
	}

	private CampTalentTeamTaskStatus GetStatus()
	{
		return CampTalentTeamTaskStatus.None;
	}
}
