using Dxx.Util;
using UnityEngine;

public class AIMove1094 : AIMove1008
{
	private int m_nHitWallMax;

	private int m_nHitWallCnt;

	private float m_fCollideWallTime;

	private Vector3 m_EndPos;

	private bool m_bCreateBullet;

	private const float m_fMaxTime = 2f;

	private float m_fStartTime;

	private SequencePool mSeqPool;

	public AIMove1094(EntityBase entity, int nHitWallMax, bool bCreateBullet = true)
		: base(null, 0f, 0, 0f)
	{
	}

	public AIMove1094(EntityBase entity, Vector3 endPos)
		: base(null, 0f, 0, 0f)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void CalDirection()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnEnd()
	{
	}

	private void OnCollideWall()
	{
	}

	private void OnBodyHit(EntityBase entity)
	{
	}
}
