using System;
using UnityEngine;

public class Bullet5150 : BulletBase
{
	protected Vector3 followBulletPos;

	protected Vector3 dir;

	protected BulletBase followBullet;

	protected Action<BulletBase> DeInitListener;

	protected float offset;

	protected Vector3 LineOffset;

	protected float waitTime;

	protected float m_fMaxDistance;

	public void SetFollowBullet(BulletBase bullet, Action<BulletBase> DeInitListener, float fMaxDistance = -1f)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnUpdate()
	{
	}
}
