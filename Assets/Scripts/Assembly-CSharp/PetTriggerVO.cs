using TableTool;

public class PetTriggerVO : PetVOBase
{
	public enum TriggerEnum
	{
		MonsterCreated = 1,
		LevelFinished = 2,
		HeroHurt = 3,
		HaveEnemy = 4,
		BodyHurt = 5,
		CD = 6,
		HitByBullet = 7,
		HaveBossEnemy = 8
	}

	private Pet_PetBattleSkill battleSkillMeta;

	private ConditionTime CD;

	private FirstEnemyCheck firstEnemyCheck;

	public PetTriggerVO(BattlePetVO battlePetVO)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private void onEntityCreated(EntityBase enemy)
	{
	}

	private void onUpdate(float delta)
	{
	}

	private void initFirstEnemyCheck()
	{
	}

	private void deinitFirstEnemyCheck()
	{
	}

	private void initCD()
	{
	}

	private void updateCD()
	{
	}

	private void deinitCD()
	{
	}

	private void OnChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private void onOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onHitByBullet2(HitStruct hs)
	{
	}

	protected virtual void OnBodyHitEvent(HitStruct hs, EntityBase self)
	{
	}

	private bool isFullEnergy()
	{
		return false;
	}

	private bool isRandomRateSatisfied()
	{
		return false;
	}

	public bool isReleaseTimesSatisfied()
	{
		return false;
	}

	private bool isTriggerTypeSatisfied(TriggerEnum triggerType)
	{
		return false;
	}

	private bool canTriggerPet(TriggerEnum triggerType)
	{
		return false;
	}

	private bool canTriggerPetNoEnergy(TriggerEnum triggerType)
	{
		return false;
	}

	private void haveEnemyTriggerSkill()
	{
	}

	private void haveBossEnemyTriggerSkill()
	{
	}
}
