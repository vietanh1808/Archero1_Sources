using UnityEngine;

public class BulletFireLineBase : BulletBase
{
	public float maxtime;

	public float endtime;

	public float MaxLength;

	protected BoxCollider mBoxCollider;

	protected float time;

	protected float percent;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected virtual void UpdateBoxColloder(float percent)
	{
	}
}
