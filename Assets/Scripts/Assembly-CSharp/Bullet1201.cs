using UnityEngine;

public class Bullet1201 : BulletFireLineBase
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

	private float deltaFireTime;

	private const float ceaseFireTime = 0.5f;

	private float colliderScaleTime;

	private float colliderExistTime;

	private DragonType dragonType;

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

	protected override void OnSetBulletAttribute()
	{
	}

	protected void CheckIfBulletResist()
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
