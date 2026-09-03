using UnityEngine;

public class Bullet9054 : BulletBase
{
	private float originalRadius;

	private BoxCollider collider;

	protected Transform particleTrans;

	protected override void OnInit()
	{
	}

	protected override Vector3 getRealSphereCenter()
	{
		return default;
	}
}
