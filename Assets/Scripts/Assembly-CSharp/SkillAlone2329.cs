public class SkillAlone2329 : SkillAloneBase
{
	private int maxFlashTriggerCount;

	private int flashBuffId;

	private float meleeShieldGainPercent;

	private float maxDamageBoostPercent;

	private float rebornHpPercent;

	private int currentFlashTriggerCount;

	private int currentFlashLayerCount;

	private bool isMeleeAttacking;

	private bool hasDamageBonusApplied;

	private float currentDamageBonusPercent;

	private long previousDemonShieldValue;

	private bool extraRebornAdded;

	private bool hasUsedSkinReborn;

	private ActionRebornUpdate rebornUpdate;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnDemonShieldChanged(long current, long max)
	{
	}

	private void TryGainFlashLayer()
	{
	}

	private void OnAttack()
	{
	}

	private void RefreshDamageBonus()
	{
	}

	private void RemoveDamageBonus()
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private bool IsAthenaHero()
	{
		return false;
	}

	private void TryAddAthenaExtraReborn()
	{
	}

	private void RemoveAthenaExtraReborn()
	{
	}
}
