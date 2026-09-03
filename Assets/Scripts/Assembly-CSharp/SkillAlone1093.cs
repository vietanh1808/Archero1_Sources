public class SkillAlone1093 : SkillAloneBase_EffectSkill
{
	private const string String_MissRate = "MissRate%";

	private const string String_Mhp = "Mhp%";

	private int MissRate;

	private string MissRateStr;

	private bool m_bHasAddEffect;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void Excute(string str)
	{
	}

	protected override void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	protected override void OnTrigger(EntityBase entity)
	{
	}
}
