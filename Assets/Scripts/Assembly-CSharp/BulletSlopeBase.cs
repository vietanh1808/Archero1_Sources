using System;
using UnityEngine;

public class BulletSlopeBase : BulletBase
{
	public Action<BulletSlopeBase> OverDistanceAction;

	protected Vector3 endpos;

	protected Vector3 dir;

	protected Vector3 OriginalPos;

	protected float hittedAngle;

	public float InnerRadius { get; set; }

	public float InnerHitRatio { get; set; }

	public float OutRadius { get; set; }

	public float OutHitRatio { get; set; }

	public float ExtraRadius { get; set; }

	protected override void OnInit()
	{
	}

	public virtual void SetEndPos(Vector3 endpos)
	{
	}

	public void SetDir(Vector3 dir)
	{
	}

	public Vector3 GetEndPos()
	{
		return default;
	}

	public float GetHittedAngle()
	{
		return 0f;
	}

	protected override void OnUpdate()
	{
	}

	public float GetBulletTime()
	{
		return 0f;
	}
}
