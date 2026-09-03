using UnityEngine;

public class Bullet5299 : Bullet1032
{
	private enum BulletState
	{
		normal = 0,
		reverse = 1
	}

	private BulletState state;

	private const float ARRIVED_RADIUS = 2f;

	private float squaredArrivedRadius;

	private bool isElite;

	private Vector3 bulletPos => default;

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void updateCurrDis(ref float currdis)
	{
	}

	private void reverseBack2Entity()
	{
	}

	private bool OnHitWall(Collider o)
	{
		return false;
	}

	protected override void overDistance()
	{
	}
}
