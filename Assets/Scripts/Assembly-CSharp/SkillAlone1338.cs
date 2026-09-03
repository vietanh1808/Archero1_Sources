using System.Collections.Generic;

public class SkillAlone1338 : SkillAloneBase
{
	private const string UPDATE_NAME = "SkillAlone1338-Update";

	private const float TIME_INTERVAL = 1f;

	private const float PLAYER_RADIUS = 2f;

	private int timerId;

	private int buffId;

	private bool canBounce;

	private float bounceRate;

	private float bounceTime;

	private int maxBounceCount;

	private float curTime;

	private int curBounceCount;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onUpdate(float deltaTime)
	{
	}

	private void bounceBullet(BulletBase bullet)
	{
	}

	private List<BulletBase> getValidBullets()
	{
		return null;
	}

	private void onMiss()
	{
	}
}
