using System.Collections.Generic;

public class Act5thHuntingTalentData : RecycleData<Act5thHuntingTalentSourceData>
{
	public int HaveUpgradeCount => 0;

	public int CurUpgradeCost => 0;

	public bool IsMaxLevel => false;

	public bool HaveEnoughCurrencyUpgrade => false;

	public List<Act5thHuntingTalentItemData> TalentItemData => null;

	public List<Act5thHuntingTalentAttributeData> AttributeData => null;

	public void UpdateTalentLevel(int talentID, int talentLevel)
	{
	}

	private List<Act5thHuntingTalentAttributeData> GetAttributeData()
	{
		return null;
	}

	private List<Act5thHuntingTalentItemData> GetTalentItemData()
	{
		return null;
	}
}
