using UnityEngine;

public class BulletUpWaitBase : BulletBase
{
	protected bool bStart;

	[Header("升起时间")]
	public float upTime;

	[Header("升起高度")]
	public float upHeight;

	[Header("等待时间")]
	public float waitTime;

	protected override void OnInit()
	{
	}

	protected virtual void OnInit1()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void UpdateProcess()
	{
	}
}
