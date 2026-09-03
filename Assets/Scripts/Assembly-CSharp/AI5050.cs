using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class AI5050 : AIBase
{
	private WeightRandomCount weight;

	private int ran;

	private SequencePool mSeqPool;

	private List<Vector2> mPosList1;

	private List<Vector2> mPosList2;

	protected override void OnInit()
	{
	}

	protected override void OnAIDeInit()
	{
	}
}
