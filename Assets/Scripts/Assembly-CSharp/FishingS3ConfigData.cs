using System;
using System.Collections.Generic;
using XLua;

[Serializable]
public class FishingS3ConfigData
{
	public List<FishingConfigTimeConfigData> Time;

	public List<FishingConfigFishBaseConfigData> FishBase;

	public List<FishingConfigFishConfigData> Fish;

	public List<FishingConfigFishRodConfigData> FishRod;

	public List<FishingConfigSkillConfigData> Skill;

	public List<FishingConfigFishMoveConfigData> FishMove;

	public List<FishingConfigFishUnlockConfigData> FishUnlock;

	public List<FishingConfigCatalogConfigData> Catalog;

	public List<FishingConfigRankConfigData> Rank;

	private static DelegateBridge __Hotfix0_GetTimeConfigByID;

	private static DelegateBridge __Hotfix0_GetFishBaseConfigByID;

	private static DelegateBridge __Hotfix0_GetFishConfigByID;

	private static DelegateBridge __Hotfix0_GetFishRodConfigByID;

	private static DelegateBridge __Hotfix0_GetFishMoveConfigByID;

	private static DelegateBridge __Hotfix0_GetFishUnlockConfigByID;

	private static DelegateBridge __Hotfix0_GetFishUnlockALlConfig;

	private static DelegateBridge __Hotfix0_GetFishSkillConfigByID;

	private static DelegateBridge _c__Hotfix0_ctor;

	public FishingConfigTimeConfigData GetTimeConfigByID(int tag)
	{
		return null;
	}

	public FishingConfigFishBaseConfigData GetFishBaseConfigByID(int tag)
	{
		return null;
	}

	public FishingConfigFishConfigData GetFishConfigByID(int id)
	{
		return null;
	}

	public FishingConfigFishRodConfigData GetFishRodConfigByID(int id)
	{
		return null;
	}

	public FishingConfigFishMoveConfigData GetFishMoveConfigByID(int id)
	{
		return null;
	}

	public FishingConfigFishUnlockConfigData GetFishUnlockConfigByID(int id)
	{
		return null;
	}

	public List<FishingConfigFishUnlockConfigData> GetFishUnlockALlConfig()
	{
		return null;
	}

	public FishingConfigSkillConfigData GetFishSkillConfigByID(int id)
	{
		return null;
	}
}
