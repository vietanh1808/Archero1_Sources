using UnityEngine;

public class AIMove1108 : AIMove1008
{
	private float oldSpeedRatio;

	private float rotateDegreesPerSecond;

	private float cumulatedTime;

	private float curDegrees;

	private const int ICE_BULLET_ID = 5310;

	private bool isElite;

	private const int ELITE_BUFF_ID = 1283;

	private float timePerDegrees;

	private const float MAX_SPEED_RATIO = 5f;

	protected override float offsetTime => 0f;

	public AIMove1108(EntityBase entity, float move2playertatio, int time, float speedratio)
		: base(null, 0f, 0, 0f)
	{
	}

	protected override void CustomizeMoveEffect(GameObject moveEffect)
	{
	}

	protected override void OnInitBaseExtra()
	{
	}

	protected override void OnEnd()
	{
	}

	private void OnHitByBullet()
	{
	}

	protected override void AIMoving()
	{
	}

	protected override void RotateHero()
	{
	}

	private void createIceBullet(Vector3 dir)
	{
	}

	private void onCollisionWallEvent()
	{
	}
}
