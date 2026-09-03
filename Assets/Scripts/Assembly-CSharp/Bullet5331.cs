using UnityEngine;

public class Bullet5331 : BulletDivideBase
{
	public const float FACTOR = 8f;

	public const float RADIUS_FACTOR = 30f;

	public const float MAX_RADIUS = 2.5f;

	private const float DELTA_DEGREES_PER_SECOND = 360f;

	private Vector3 radiusDir;

	private float radius;

	private float deltaRadius;

	private float deltaDegreesPerSecond;

	private float deltaRadiusPerSecond;

	private Vector3 centerPos;

	private float maxRadius;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnUpdate()
	{
	}
}
