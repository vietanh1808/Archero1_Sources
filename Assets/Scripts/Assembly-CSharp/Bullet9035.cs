using UnityEngine;

public class Bullet9035 : BulletBase
{
	private float originalRadius;

	private SphereCollider collider;

	protected Transform particleTrans;

	protected override void OnInit()
	{
	}

	protected override Vector3 getRealSphereCenter()
	{
		return default;
	}
}
