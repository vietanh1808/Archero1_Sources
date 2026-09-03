using UnityEngine;

public class BulletCallBase : BulletBase
{
	private Vector3 endpos;

	protected float height;

	private AnimationCurve curve;

	private Vector3 temppos;

	private Vector3 curvepos;

	private float percent;

	private Vector3 startpos;

	private Vector3 straightpos;

	public bool bShowCallEffect;

	protected override void AwakeInit()
	{
	}

	public void SetEndPos(Vector3 endpos)
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnOverDistance()
	{
	}
}
