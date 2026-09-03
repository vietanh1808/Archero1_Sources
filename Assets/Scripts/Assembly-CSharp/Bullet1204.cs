using Dxx.Util;
using UnityEngine;

public class Bullet1204 : BulletDragonBase
{
	private const int BULLET_ID = 1204;

	protected Transform mStart;

	protected Transform mEnd;

	protected LineRenderer line;

	public const float textureLengthScale = 3f;

	public const float textureScrollSpeed = 8f;

	private int layerMask;

	protected float startwidth;

	private float starttime;

	private float line_update_time;

	private bool bNearEnd;

	protected SequencePool mPool;

	protected bool isStarted;

	private float reachDistance;

	private Transform BulletNode => null;

	protected override void OnInit()
	{
	}

	private void destroyBullet()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void onAfterStartWidthInitialized()
	{
	}

	protected override void OnDeInit()
	{
	}

	private RaycastHit getNearestHit(RaycastHit[] hits)
	{
		return default;
	}

	public virtual void CheckBulletLength()
	{
	}

	protected override Vector3 getHalfExtents(Vector3 size)
	{
		return default;
	}

	private void updateLineEndPos()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnOverDistance()
	{
	}

	private void UpdateLineWidth()
	{
	}

	protected override void OnHitHero(EntityBase entity)
	{
	}
}
