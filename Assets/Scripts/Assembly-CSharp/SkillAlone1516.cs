public class SkillAlone1516 : SkillAloneBase
{
	private const int SHIELD_BULLET_ID = 1505;

	private const int SPEAR_BULLET_ID = 1506;

	private const int PVP_SHIELD_BULLET_ID = 1507;

	private const int PVP_SPEAR_BULLET_ID = 1508;

	private const int SPEAR_COUNT = 6;

	private float shieldBulletRate;

	private float shieldBulletInterval;

	private float spearBulletRate;

	private float spearBulletInterval;

	private int SHIELD_ARROW_EJECT_COUNT;

	private int SHIELD_REBOUNCE_COUNT_IN_PVP;

	private float shieldBulletAttackPercent;

	private float spearBulletAttackPercent;

	private float lastShieldTimestamp;

	private float lastSpearTimestamp;

	public int ShieldBulletID => 0;

	public int SpearBulletID => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void OnAttack()
	{
	}

	private void onHitted(EntityBase entity, long realHit)
	{
	}

	private void createShieldBullet(EntityBase entity)
	{
	}

	private void createSpearBullet(EntityBase entity)
	{
	}

	private void syncShieldBullet(EntityBase entity)
	{
	}

	private void syncSpearBullet(EntityBase entity)
	{
	}
}
