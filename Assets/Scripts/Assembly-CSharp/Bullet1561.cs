using UnityEngine;

public class Bullet1561 : BulletBase
{
	private const int THUNDER_BULLET_ID = 1562;

	private const float THUNDER_BULLET_SPEED_FACTOR = 0.8f;

	private const float MIN_DISTANCE_FOLLOW = 0.2f;

	private float thunderFallInterval;

	private float thunderRadius;

	private float thunderDamageFactor;

	private float preFallThunderTime;

	private bool stopThunderFall;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	public void SetThunderData(float radius, float interval, float factor)
	{
	}

	protected override void OnBulletTrack()
	{
	}

	protected override void UpdateProcess()
	{
	}

	public void CreateThunderFall(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
	}

	protected override void TriggerExtra(Collider o)
	{
	}

	private void HitWalls(BulletBase bullet, Collider o)
	{
	}

	protected virtual int GetThunderFallBulletId()
	{
		return 0;
	}
}
