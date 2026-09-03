using System;
using UnityEngine;

public class BulletFirePath : BulletBase
{
	private bool isMakeFirePath;

	[SerializeField]
	private int debuffId;

	[SerializeField]
	private float FirePathDuration;

	private ActionFirePath firePath;

	private int preHitSelfFrameCount;

	private int frameInterval;

	public Action OnHitSelfEffect;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnSetArgs()
	{
	}

	protected override void OnBulletHitSelf()
	{
	}
}
