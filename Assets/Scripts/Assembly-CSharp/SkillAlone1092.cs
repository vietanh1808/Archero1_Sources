public class SkillAlone1092 : SkillAloneBase_EffectSkill
{
	private const string String_BodyHittedReduce = "BodyHittedReduce%";

	private const string String_Mhp = "Mhp%";

	private int BodyHittedReduce;

	private string BodyHittedReduceStr;

	private long maxHp;

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
