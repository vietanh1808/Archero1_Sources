public class SkillAlone2315 : SkillAloneBase
{
	private float detectionRadius;

	private float[] damageBonus;

	private float hpThreshold;

	private float lowHpBonus;

	private bool isLowHp;

	private long currentDamageBonus;

	private float updateInterval;

	private float lastUpdateTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void UpdateDamageBonus()
	{
	}

	private float GetDamageBonusByEnemyCount(int count)
	{
		return 0f;
	}

	private void ApplyDamageBonus(float bonusPercent)
	{
	}

	private void RemoveDamageBonus()
	{
	}
}
