using System;
using UnityEngine;

public class Bullet5172 : Bullet5149
{
	[Header("跟踪最长时间")]
	public float FollowTime;

	[Header("跟踪最大累计角度")]
	public float FollowTotalAngle;

	private float m_fTotalFollowTime;

	private float m_fTotalFollowAngle;

	private float m_fLastAngle;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnDeInitSubBullet(BulletBase bullet)
	{
	}

	protected override void SetFollowBullet(int i, BulletBase bullet, Action<BulletBase> DeInitListener, float fMaxDistance = -1f)
	{
	}

	protected override void OnBulletTrack()
	{
	}
}
