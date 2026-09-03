using TableTool;

public class RuneItem
{
	public Runes_Store Data;

	public RuneItemData ServerData;

	public int StoreId => 0;

	public bool IfShowVal => false;

	public int Quality => 0;

	public EnhanceEnum EnhanceType => EnhanceEnum.eNone;

	private bool IfEnhanceSkill => false;

	private bool IfEnhanceAttribute => false;

	public string ExtraInfo => null;

	public float ExtraValue => 0f;

	public RuneItem(Runes_Store data, RuneItemData serverData)
	{
	}

	public bool TryGetSkillId(out int skillId)
	{
		skillId = default;
		return false;
	}

	public bool TryGetAttribute(out string att, out float val)
	{
		att = null;
		val = default;
		return false;
	}
}
