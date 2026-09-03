public class SkillAlone4025 : SkillAlone4013
{
	private const string String_TempLimit = "TempLimit";

	private const string String_SkillId = "SkillId";

	private int m_nPartAliveLimit;

	private int m_nPartSkillId;

	private EntityHero m_self;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void Excute(string str)
	{
	}

	protected override bool CanCallOne(EntityBase entity)
	{
		return false;
	}

	protected override void CallOne(EntityBase entity)
	{
	}
}
