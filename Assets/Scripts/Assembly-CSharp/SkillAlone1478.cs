public class SkillAlone1478 : SkillAloneBase
{
	private SkillLowerHP skill;

	private SkillMonsterBlackBuff blackSkill;

	private const int wrappBuffId = 9082;

	private float minPercent;

	private int buffId;

	private int blackBuffId;

	private float radius;

	private int maxBuffCount;

	private float timeInterval;

	protected override void OnInstall()
	{
	}

	private void initLowerHPSkill()
	{
	}

	private void initBlackBuffSkill()
	{
	}

	protected override void OnUninstall()
	{
	}

	private bool canUseLowerHP()
	{
		return false;
	}

	private bool canExploitMonsterDark()
	{
		return false;
	}
}
