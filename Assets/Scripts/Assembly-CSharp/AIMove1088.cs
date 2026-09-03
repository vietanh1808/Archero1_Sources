using System;
using Dxx.Util;
using UnityEngine;

public class AIMove1088 : AIMoveBase
{
	private const string COLLIDER_RESOURCE = "Game/SkillPrefab/CollisionCtrl1007";

	private GameObject mCollision;

	private bool m_bStart;

	private bool m_bEnd;

	private bool m_bMoveStart;

	private float m_fSpeed;

	private float m_fMaxSpeed;

	private float m_fInterval;

	private float m_fAdd;

	private float time;

	private float m_fTotalAngle;

	private const float m_fMaxAngle = 120f;

	private const float m_fAnglePerFrame = 1f;

	private int m_nReboundWallCntMax;

	private int m_nReboundWallCnt;

	private bool m_bFollow;

	private SequencePool mSeqPool;

	private Action OnColliderWallAction;

	public AIMove1088(EntityBase entity, int nReboundWallCnt, float fStartSpeed, float fMaxSpeed, Action OnColliderWallAction = null)
		: base(null)
	{
	}

	public AIMove1088(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void UpdateSpeed()
	{
	}

	private void MoveNormal()
	{
	}

	private void MoveStart()
	{
	}

	private void Moving()
	{
	}

	private void MoveEnd()
	{
	}

	private void UpdateDirection()
	{
	}

	protected override void OnEnd()
	{
	}

	private void CreateCollisionCtrl()
	{
	}

	private void DestroyCollision()
	{
	}

	private void CollisionEnter(Collision c)
	{
	}
}
