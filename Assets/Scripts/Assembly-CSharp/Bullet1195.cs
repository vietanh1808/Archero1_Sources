using UnityEngine;

public class Bullet1195 : BulletFireLineBase
{
	public Vector3 oldSize;

	public Vector3 oldResistSize;

	private float oldMaxLength;

	private bool showResistFinished;

	public BoxCollider BulletResistCollider;

	private bool isResistEnabled;

	private float totalTime;

	private float curTime;

	private float curDeltaFireTime;

	private float colliderScaleTime;

	private const float resistOffset = 1f;

	public override void OnBeforeInit()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	private void OnEntity3125MoveEnd()
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

	private void runResist()
	{
	}

	protected override Vector3 getHalfExtents(Vector3 size)
	{
		return default;
	}
}
