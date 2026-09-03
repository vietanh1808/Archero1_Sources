using UnityEngine;

public class BulletFlySwordBase : BulletBase
{
	protected bool bStart;

	[Header("缩放时间")]
	public float scaleTime;

	[Header("等待时间")]
	public float waitTime;

	public float EndScale { get; set; }

	protected override void OnInit()
	{
	}

	protected virtual void SwordFlyStart()
	{
	}

	protected virtual float CalWaitTime()
	{
		return 0f;
	}

	protected override void OnSetBulletAttribute()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void UpdateProcess()
	{
	}
}
