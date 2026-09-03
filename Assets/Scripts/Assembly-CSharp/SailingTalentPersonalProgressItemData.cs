using System.Collections.Generic;
using TableTool;

public class SailingTalentPersonalProgressItemData
{
	private SailingTalentPersonalProgressItemConfigData ConfigData { get; set; }

	public ShipBattle_Talent Model => null;

	public int ID => 0;

	public int Level => 0;

	public SailingTalentAttributeType AttributeType => (SailingTalentAttributeType)0;

	public int MaxLevel => 0;

	public bool IsMaxLevel => false;

	public int CurLevelNeedTalentLevel => 0;

	public bool IsUnlock => false;

	public bool IsReachTotalTalentLevelCond => false;

	public bool IsReachTalentCond => false;

	public bool CanUpgrade => false;

	public bool IsHaveEnoughCurrency => false;

	public (int, int) Position => default;

	public CampTalentLineDir LineDir => CampTalentLineDir.None;

	public CampTalentLineDir UpgradeLine => CampTalentLineDir.None;

	public int UpgradeNeedCount => 0;

	public List<Drop_DropModel.DropData> Rewards => null;

	public static SailingTalentPersonalProgressItemData Create(SailingTalentPersonalProgressItemConfigData configData)
	{
		return null;
	}

	private bool ReachTotalTalentLevelCond()
	{
		return false;
	}

	private bool ReachTalentCond()
	{
		return false;
	}

	private bool HaveEnoughCurrency()
	{
		return false;
	}

	private int GetUpgradeNeedCount()
	{
		return 0;
	}
}
