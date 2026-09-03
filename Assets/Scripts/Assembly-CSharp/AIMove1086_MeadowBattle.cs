using System;
using Dxx.Util;
using UnityEngine;

public class AIMove1086_MeadowBattle : AIJumpMoveBase
{
	private SequencePool mSeqPool;

	private bool m_bStart;

	private int m_nCount;

	private float m_fDistance;

	private Vector3 m_lastPos;

	private float Speed;

	private BulletRedLineCtrl ctrl;

	private bool m_bThrowBomb;

	private Action MoveEndAction;

	private AIMeadowBattleBase aiBase;

	private bool isStart;

	private float times => 0f;

	public AIMove1086_MeadowBattle(EntityBase entity, float speed = 18f, bool bThrowBomb = true, Action moveEndAction = null)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void UpdateDirection()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void MoveNormal()
	{
	}

	protected void AIMoveStart()
	{
	}

	protected void AIMoving()
	{
	}

	protected void AIMoveEnd()
	{
	}

	protected override void OnEnd()
	{
	}

	private bool IsOutOfCamera()
	{
		return false;
	}

	private void ClearLine()
	{
	}
}
