using System;
using System.Collections.Generic;
using UnityEngine;

public class Bullet5149 : BulletBase
{
	private bool bDivide;

	[Header("等待时间")]
	public float waitTime;

	[Header("分裂子弹数量")]
	public int DivideCount;

	[Header("分裂石头ID")]
	public int DivideID;

	[Header("子子弹跟父子弹最大距离")]
	public float MaxDistance;

	protected List<BulletBase> SubBullets;

	private int curIndex;

	protected virtual bool AllowMoreTriggerBullet => false;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected virtual void SetFollowBullet(int i, BulletBase bullet, Action<BulletBase> DeInitListener, float fMaxDistance = -1f)
	{
	}

	protected void create_bullets()
	{
	}

	protected virtual void OnDeInitSubBullet(BulletBase bullet)
	{
	}
}
