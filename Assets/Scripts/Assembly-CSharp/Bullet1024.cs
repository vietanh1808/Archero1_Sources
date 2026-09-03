using Dxx.Util;
using UnityEngine;

public class Bullet1024 : BulletBase
{
	protected Transform mStart;

	protected Transform mEnd;

	protected LineRenderer line;

	public const float textureLengthScale = 3f;

	public const float textureScrollSpeed = 8f;

	private int layerMask;

	protected float startwidth;

	protected float starttime;

	protected float line_update_time;

	protected bool bNearEnd;

	protected SequencePool mPool;

	protected bool isStarted;

	protected override void OnInit()
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

	public virtual void CheckBulletLength()
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
}
