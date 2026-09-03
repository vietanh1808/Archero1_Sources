using UnityEngine;

public class Bullet5225 : BulletBase
{
	private const float DURATION = 0.25f;

	public int DivideId;

	public float DivideAngle;

	public bool DoScale;

	private float startTime;

	protected override void OnInit()
	{
	}

	protected override void UpdateProcess()
	{
	}

	protected override void OnDeInit()
	{
	}

	private bool HitWalls(Collider o)
	{
		return false;
	}
}
