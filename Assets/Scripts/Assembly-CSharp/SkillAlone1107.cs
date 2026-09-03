public class SkillAlone1107 : SkillAloneBase
{
	private new const string Tag = "SkillAlone1107";

	private const string String_BombRate = "BombRate%";

	private const string String_BombDamage = "BombDamage%";

	private const string String_RangeMonster = "RangeMonster";

	private const string String_RangeBoss = "RangeBoss";

	private float bombRate;

	private float bombAttackPercent;

	private float range_monster;

	private float range_boss;

	protected override void OnInstall()
	{
	}

	private void excute(string attr)
	{
	}

	private float get_range(EntityBase entity)
	{
		return 0f;
	}

	private void onMonsterDead(EntityBase entity)
	{
	}

	private void debug(string value, params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}
}
