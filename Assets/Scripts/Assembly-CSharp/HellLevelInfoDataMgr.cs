using System.Collections.Generic;
using TableTool;

public class HellLevelInfoDataMgr : CInstance<HellLevelInfoDataMgr>
{
	private Dictionary<int, HellStageConfigData> hellMap;

	private List<Stage_Level_power> powerConfigData;

	private List<Equip_equip> allEquipsConfigData;

	private List<Equip_WeaponSkin> allWeaponSkinConfigData;

	private List<Equip_equip> onlyEquipsConfigData;

	private List<Equip_equip> onlyDragosConfigData;

	private List<Pet_Pet> onlyPetsConfigData;

	private List<Imprint_Imprint> onlyImprintsConfigData;

	private List<Manor_Worker> onlyManorWorkersConfigData;

	private List<PlayerCharacter_Skin> onlyHeroSkinsConfigData;

	private List<Equip_equip> onlyCarvingsConfigData;

	private List<PlayerCharacter_Character> onlyAllHero;

	private List<Artifact_Artifact> onlyArtifact;

	public List<HellLevelData> CrtStageData;

	private float formula_X;

	private float formula_M;

	private float formula_N;

	private bool isOpenTest;

	private float testBless;

	private float testGuard;

	private List<Equip_equip> GetAllEquipsConfigData()
	{
		return null;
	}

	private List<Equip_equip> GetAllCarvingConfigData()
	{
		return null;
	}

	private List<Equip_equip> GetAllDragonConfigData()
	{
		return null;
	}

	public bool IsHellOpen()
	{
		return false;
	}

	public bool isShowHellCard()
	{
		return false;
	}

	public bool isShowHellCardOther(int normal, int hell)
	{
		return false;
	}

	protected override void Init()
	{
	}

	public void SetHellCrtStageData(int chapterID)
	{
	}

	public string GetAttById(int id)
	{
		return null;
	}

	public void SetTestData(bool isTest, float blessCount, float guardCount)
	{
	}

	public string GetAllAttByType(HellBuffType buffType)
	{
		return null;
	}

	public double GetFinalAddById(int id)
	{
		return 0.0;
	}

	private List<HellLevelData> GetHellStageBuffData(int chapterID)
	{
		return null;
	}

	private HellLevelData GetAllAddByHellLevelBuffType(int powerType, int[] moduleTypes)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllEquipAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllRefineAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllCarvingAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllWeaponSkinAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllDragonAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllGemsAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllPetsAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllImprintsAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllManorBuildingsAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllManorWorkersAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllWingsAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllRelicsAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllHeroAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllHeroSkinAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllHeroAssistAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private List<HellSystemItemData> GetAllArtifactAddInfoByPowerType(int powerType)
	{
		return null;
	}

	private void GetHellAddInfo(HellSystemItemData item, HellSystemBuffType type, int powerType, int cRarity, int cPos, int cQuality, int tStar, int tQuality, int tLevel, int tSkill, float hellModeStrength = 0f, bool isWear = false)
	{
	}

	public void GetHellMaxAdd(HellSystemData hsData, int powerType)
	{
	}

	private void GetHellMaxAddInfo(HellSystemItemData item, HellSystemBuffType type, int powerType, int cRarity, int cPos, int cQuality, int tStar, int tQuality, int tLevel, int tSkill, float hellModeStrength = 0f)
	{
	}
}
