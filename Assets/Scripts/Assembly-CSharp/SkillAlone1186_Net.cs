public class SkillAlone1186_Net : SkillAlone1033_Net
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

	protected override void Excute(string str, bool bExcute = false)
	{
	}

	protected override bool CanCallOne(EntityBase entity)
	{
		return false;
	}

	protected override void CallOne(EntityBase entity)
	{
	}

	protected override void OnGetRange(ref int range)
	{
	}
}
