using System;

public class Bullet3071 : Bullet3063
{
	public float deltaAngle;

	public float trackTime;

	protected float curDeltaAngle;

	protected bool isEjectCalled;

	public Action<Bullet3071> OnStopTrack;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnSetArgs()
	{
	}

	protected override bool ExcuteCustomEject(EntityBase entity)
	{
		return false;
	}

	protected override void OnBulletTrack()
	{
	}

	protected override void OnUpdate()
	{
	}
}
