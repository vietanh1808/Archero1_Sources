public class SkillAlone1186 : SkillAlone1033
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

	protected override bool CanCallPlusOne()
	{
		return false;
	}

	protected override EntityPartBodyBase CallOne(EntityBase entity, bool CallPlusOne = false)
	{
		return null;
	}

	protected override void OnGetRange(ref int range)
	{
	}

	private void AddPartNumLimit(int toAdd)
	{
	}
}
