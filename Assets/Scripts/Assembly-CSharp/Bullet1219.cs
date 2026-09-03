using UnityEngine;

public class Bullet1219 : BulletDragonBase
{
	private const int CONFIG_ID = 3292;

	private const float EXPLODE_RADIUS = 2f;

	private const float EXPLODE_ATK_PERCENT = 1f;

	private int meteorNum;

	public static int[] BULLET_IDS;

	private TrailRenderer[] trails;

	private float meteorFactor;

	private float explodeFactor;

	private GameObject effect;

	protected override void OnInit()
	{
	}

	private void onBulletDestroy()
	{
	}

	private void initConfig()
	{
	}

	private void playFireworks(Vector3 centerPos)
	{
	}

	private void explode(Vector3 centerPos)
	{
	}

	private long GetBodyHit()
	{
		return 0L;
	}

	private void shootMeteor(Vector3 centerPos)
	{
	}
}
