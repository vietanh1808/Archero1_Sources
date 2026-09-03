using UnityEngine;

public class AIMove1035 : AIJumpMoveBase
{
	protected EntityBase target;

	private AnimationCurve curve;

	private int range;

	private float playerrange;

	private float ratio;

	private Vector3 startpos;

	protected Vector3 endpos;

	private float alltime;

	private float height;

	private float currenttime;

	private float speed;

	public AIMove1035(EntityBase entity, int range, float playerrange, float ratio, float speed = 7f)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void UpdateDirection()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected virtual void CreateBullet()
	{
	}

	protected virtual int GetBulletID()
	{
		return 0;
	}

	protected override void OnEnd()
	{
	}
}
