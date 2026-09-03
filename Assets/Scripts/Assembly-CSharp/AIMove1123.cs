using System;
using System.Collections.Generic;
using DG.Tweening;
using Dxx.Util;
using UnityEngine;

public class AIMove1123 : AIMoveBase
{
	private const float SHADOW_RATE = 0.5f;

	private const float MOVE_TIME = 1.5f;

	private const float UNDERGROUND_Y = -5f;

	private SequencePool mSeqPool;

	private Sequence moveSeq;

	private Sequence shadowMoveSeq;

	public float DelayTime;

	public Action onDown;

	public Action onUp;

	private AIGroundBase m_AIGroiund;

	private int range;

	protected EntityBase target;

	protected List<Grid.NodeItem> findpath;

	protected Vector3 nextpos;

	protected Vector3 endpos;

	private ActionBattle action;

	private bool bDizzy;

	private bool bShowHP;

	private bool bShowCollider;

	private Vector3 shadowEndPos;

	public AIMove1123(EntityBase entity, int range)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void SetAnimation()
	{
	}

	private new void OnDizzy(bool dizzy)
	{
	}

	private void showhp(bool value)
	{
	}

	private void ShowCollider(bool value)
	{
	}

	protected override void OnEnd()
	{
	}
}
