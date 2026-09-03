using UnityEngine;

public class Bullet5330 : Bullet5329
{
	private enum BulletState
	{
		normal = 0,
		reverse = 1
	}

	private const float ARRIVED_RADIUS = 2f;

	private float squaredArrivedRadius;

	private BulletState state;

	private Vector3 bulletPos => default;

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	private bool OnHitWall(Collider o)
	{
		return false;
	}
}
