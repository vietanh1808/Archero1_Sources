using System;

public class BulletLotusReturn : BulletColorModle
{
	private EntityBase heroEntity;

	private bool isReturning;

	private float absorbDistance;

	protected bool bStart;

	public float waitTime;

	public Action<BulletBase> OnAbsorbedByHero;

	public void SetTrackHero(EntityBase hero)
	{
	}

	public void SetAbsorbDistance(float dist)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnBulletTrack()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override EntityBase GetTrackTarget()
	{
		return null;
	}

	protected override void UpdateProcess()
	{
	}
}
