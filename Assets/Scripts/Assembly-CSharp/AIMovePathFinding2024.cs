using DG.Tweening;
using Dxx.Util;
using UnityEngine;

public class AIMovePathFinding2024 : AIMovePathFinding
{
	private GameObject effect;

	private SequencePool mPool;

	private Sequence seq;

	private Sequence seq1;

	private bool isPlayCalling;

	protected override float AnimSpeedTimes => 0f;

	public AIMovePathFinding2024(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnForceEnd()
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnEnd()
	{
	}

	public override bool StopRunningOnInit()
	{
		return false;
	}

	protected override bool canInterrupt()
	{
		return false;
	}
}
