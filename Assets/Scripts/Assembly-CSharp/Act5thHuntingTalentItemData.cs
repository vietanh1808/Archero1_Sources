public class Act5thHuntingTalentItemData
{
	private Act5thHuntingTalentItemSourceData SourceData { get; set; }

	public int ID => 0;

	public int Level => 0;

	public bool IsUnlock => false;

	public bool IsMaxLevel => false;

	public Act5thHuntingTalentType TalentType => Act5thHuntingTalentType.None;

	public int Position => 0;

	public bool IsShow => false;

	public int MaxLevel => 0;

	public int Quality => 0;

	public string AttributeStr => null;

	public float CurLevelValue => 0f;

	public Act5thHuntingTalentAttributeData TalentAttributeData => null;

	public static Act5thHuntingTalentItemData Create(Act5thHuntingTalentItemSourceData sourceData)
	{
		return null;
	}

	public void UpdateTalentLevel(int level)
	{
	}
}
