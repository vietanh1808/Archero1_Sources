using TableTool;

public class HeroShowSkillData
{
	public int SkillID { get; set; }

	public HeroExtraSkillCondType CondType { get; set; }

	public int CondValue { get; set; }

	public bool IsValid => false;

	public bool IsDetailSkillValid => false;

	public bool IsUnlock => false;

	public LocalSave.CharacterOne HeroData { get; set; }

	public string SkillDesc => null;

	public string SkillDetailDesc => null;

	public Skill_skill SkillData => null;

	public static HeroShowSkillData Create(int id, int condType, int condValue, LocalSave.CharacterOne heroData)
	{
		return null;
	}

	private bool Unlock()
	{
		return false;
	}
}
