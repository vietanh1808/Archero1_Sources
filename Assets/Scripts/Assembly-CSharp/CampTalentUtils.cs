using GameProtocol;
using XLua;

public static class CampTalentUtils
{
	private static DelegateBridge __Hotfix0_ParsePersonalData;

	private static DelegateBridge __Hotfix0_ParsePersonalProgressData;

	private static DelegateBridge __Hotfix0_ParseTeamData;

	private static DelegateBridge __Hotfix0_ParseTeamProgressData;

	private static DelegateBridge __Hotfix0_ParseTeamTaskData;

	private static DelegateBridge __Hotfix0_ParseTeamTaskProgressData;

	private static DelegateBridge __Hotfix0_GetAttrType;

	private static DelegateBridge __Hotfix0_GetLineDir;

	public static CampTalentPersonalConfigData ParsePersonalData(CCampTalent[] talentData)
	{
		return null;
	}

	public static CampTalentProgressConfigData ParsePersonalProgressData(CCampTalent[] talentData)
	{
		return null;
	}

	public static CampTalentTeamConfigData ParseTeamData(int score)
	{
		return null;
	}

	public static CampTalentTeamProgressConfigData ParseTeamProgressData()
	{
		return null;
	}

	public static CampTalentTeamTaskConfigData ParseTeamTaskData(int score, int curClaimedRewardID)
	{
		return null;
	}

	public static CampTalentTeamTaskProgressConfigData ParseTeamTaskProgressData()
	{
		return null;
	}

	public static int GetAttrType(string atr)
	{
		return 0;
	}

	public static CampTalentLineDir GetLineDir(int id, bool isUpgradeLine)
	{
		return CampTalentLineDir.None;
	}
}
