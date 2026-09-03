public class SkillAlone1089 : SkillAloneBase_EffectSkill
{
	private const string String_Weight = "Weight";

	private const string String_AddHp = "AddHp%";

	private int weight;

	private int addHP;

	private long maxHP;

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
