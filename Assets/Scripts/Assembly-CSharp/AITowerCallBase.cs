using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class AITowerCallBase : AIBase
{
	protected int callid;

	protected int callcount;

	protected int calldelay;

	protected float prev_scale;

	private SequencePool mSeqPool;

	private float delay;

	private List<Vector3> poslist;

	private List<GameObject> prevs;

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnAIDeInit()
	{
	}
}
