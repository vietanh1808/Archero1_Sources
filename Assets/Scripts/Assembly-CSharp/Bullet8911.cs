using DG.Tweening;
using UnityEngine;

public class Bullet8911 : Bullet3DShadowBase
{
	private float factor;

	private float maxFactor;

	private const float DELAY_TIME = 1f;

	private float explodeRadius;

	private float atkPercent;

	private Tween delay;

	private bool isDead;

	private float accelerateSpeed;

	private float maxSpeed;

	private float curFrameDistance;

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

	public void SetArgs(float explodeRadius, float atkPercent)
	{
	}

	private void explode(Vector3 centerPos)
	{
	}
}
