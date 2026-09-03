using UnityEngine;

public class BulletSlopeCurveBase : BulletBase
{
	private Vector3 endpos;

	private Vector3 dir;

	protected float height;

	private AnimationCurve curve;

	private Vector3 temppos;

	private Vector3 curvepos;

	private float percent;

	private Vector3 startpos;

	protected override void AwakeInit()
	{
	}

	protected override void OnInit()
	{
	}

	public void SetEndPos(Vector3 endpos)
	{
	}

	protected override void OnUpdate()
	{
	}
}
