using UnityEngine;

public class Bullet1504 : BulletFireLineBase
{
	public Vector3 oldSize;

	private float oldMaxLength;

	private float totalTime;

	private float curTime;

	private float curDeltaFireTime;

	private float colliderScaleTime;

	public override void OnBeforeInit()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnHitEventInternal(EntityBase entity, float hittedAngle)
	{
	}

	protected override void OnDeInit()
	{
	}

	private void onMove(bool isMoving)
	{
	}

	protected override void OnUpdate()
	{
	}

	protected void DOScaleBoxCollider(BoxCollider collider, float percent, float _MaxLength)
	{
	}

	private void updateBoxColliderSize(BoxCollider collider, float scalePercent)
	{
	}

	protected override Vector3 getHalfExtents(Vector3 size)
	{
		return default;
	}
}
