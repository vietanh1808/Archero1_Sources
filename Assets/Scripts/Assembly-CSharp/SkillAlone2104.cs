public class SkillAlone2104 : SkillAloneWing
{
	private int buffId;

	private int isSkill1Effect;

	private float hpRate;

	private float hitRise;

	private int isSkill2Effect;

	private float extraTime;

	private float extraTimePerPercentage;

	private float extraTimeByLifeLimit;

	private int isSkill3Effect;

	private float attackFactor;

	private float riseAttackRateLimit;

	private int isSkill4Effect;

	private int newBuffId;

	private float effectLifeRate;

	private float mainBuffEndTime;

	private long allAddAttack;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnMonsterCreated(EntityBase entity)
	{
	}

	private void OnHit(EntityBase target, HitStruct hs, HittedData hd)
	{
	}

	private float GetBuffEndTime(int buffId)
	{
		return 0f;
	}

	private float GetBuffAddTime()
	{
		return 0f;
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}
}
