using System;
using System.Collections.Generic;
using DG.Tweening;
using Dxx.Util;
using UnityEngine;

public class AIInstantTransfer : ActionBasic.ActionBase
{
	public Func<Vector3?> GetTargetPos;

	public Action AppearCallback;

	protected Vector3? targetPos;

	protected GameObject effect;

	protected SequencePool mPool;

	protected Sequence seq;

	protected Sequence seq1;

	protected bool isPlayCalling;

	protected List<Grid.NodeItem> findpath;

	protected const float delayTime = 0.1f;

	protected const float duration = 0.2f;

	protected const float targetY = -2f;

	protected float oldY;

	protected virtual int CallingEffectId => 0;

	protected override void OnForceEnd()
	{
	}

	protected override void OnEnd()
	{
	}

	private void onRemove(EntityPartBodyBase arg1, int arg2)
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room obj)
	{
	}

	protected override void OnInit()
	{
	}

	protected virtual void CreateSeq()
	{
	}

	protected override void OnDeInit()
	{
	}
}
