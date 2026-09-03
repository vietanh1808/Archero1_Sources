using UnityEngine;

public class Bullet1126 : BulletBase
{
	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	private bool HitWalls(Collider o)
	{
		return false;
	}

	protected virtual BulletBase CreateBullet(int index, Vector3 newDir, float _angel)
	{
		return null;
	}
}
