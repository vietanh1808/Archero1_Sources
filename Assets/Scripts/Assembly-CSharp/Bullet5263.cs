using UnityEngine;

public class Bullet5263 : BulletBase
{
	private float _StartAngle;

	private float TotalAngle;

	public float Radius { get; set; }

	public bool Symbol { get; set; }

	public Vector3 Center { get; set; }

	public float StartAngle
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnDeInit()
	{
	}
}
