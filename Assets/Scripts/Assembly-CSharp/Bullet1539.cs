using System.Collections.Generic;
using UnityEngine;

public class Bullet1539 : BulletBase
{
	private const float CLOSE_ANGLE = 1f;

	private const float CLOSE_DISTANCE = 1f;

	private const float ACCELERATE_ROTATE_SPEED = 0.1f;

	private const float ROTATE_SPEED = 8f;

	private const float MAX_ROTATE_SPEED = 100f;

	public float amplitude;

	public float deltaSinAngle;

	private int maxCount;

	private List<GameObject> hitList;

	private EntityBase target;

	private int curCount;

	private Vector3 bulletPosXZ;

	private Vector3 virtualPosXZ;

	private float curRotateSpeed;

	private Vector3 virtualPos;

	private Quaternion virtualRotation;

	private TrailRenderer[] trails;

	private ParticleSystem[] ps_arr;

	private float minHitRatio;

	private int mInkDragonDebuffId;

	private float curSinAngle;

	private CapsuleCollider capsuleCollider;

	protected override void OnInit()
	{
	}

	protected override void OnSetBulletAttribute()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void setPsVisible(bool visible)
	{
	}

	private Quaternion GetCurRotation()
	{
		return default;
	}

	private void updateRotate()
	{
	}

	private void tweenCollider()
	{
	}

	protected override void OnHitEventInternal(EntityBase entity, float hittedAngle)
	{
	}

	private void changeTarget(EntityBase newTarget, string source)
	{
	}

	private EntityBase GetNearestEnemyInBullet1539()
	{
		return null;
	}

	public override float modifyCurHitRatio(EntityBase target)
	{
		return 0f;
	}
}
