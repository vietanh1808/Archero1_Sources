using DG.Tweening;
using Dxx.Util;
using UnityEngine;

public class AIInstantMovePathFinding : AIMovePathFinding
{
	private GameObject effect;

	private SequencePool mPool;

	private Sequence seq;

	private Sequence seq1;

	private bool isPlayCalling;

	protected virtual int CallingEffectId => 0;

	protected virtual float NearDistance => 0f;

	public AIInstantMovePathFinding(EntityBase entity)
		: base(null)
	{
	}

	protected override void AIMoveStart()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnEnd()
	{
	}

	protected override bool canInterrupt()
	{
		return false;
	}

	private bool instantMove()
	{
		return false;
	}
}
