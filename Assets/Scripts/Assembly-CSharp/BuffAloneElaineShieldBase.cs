public class BuffAloneElaineShieldBase : BuffAloneBase
{
	private int bulletCount;

	private int nonInvincibleBuffId;

	private int maxBulletCount;

	private float bulletFactor;

	protected override void OnStart()
	{
	}

	protected override void OnRemove()
	{
	}

	private void OnHitByBullet()
	{
	}

	private bool canHitByBullet()
	{
		return false;
	}
}
