using DG.Tweening;

public class BulletFallBase : Bullet3DShadowBase
{
	private float radius;

	private float factor;

	private float maxFactor;

	private float accelerateSpeed;

	private float maxSpeed;

	private float curFrameDistance;

	private Tween delay;

	private bool isDead;

	protected virtual float GroudDelayTime => 0f;

	protected override void OnInit()
	{
	}

	private void initSpeed()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void playEffect()
	{
	}
}
