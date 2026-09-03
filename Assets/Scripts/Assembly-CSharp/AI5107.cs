using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class AI5107 : AIBase
{
	public const int CHAR_ID = 5107;

	private WeightRandomCount mWeightRandom;

	private int callid;

	private int maxcount;

	private List<Vector3> list;

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private void callBees(int entityId, Vector2Int colRow, int count)
	{
	}

	private void callOddBees(int entityId, Vector2Int colRow, int count)
	{
	}

	private ActionBase GetCall1()
	{
		return null;
	}

	private ActionBase GetCall2()
	{
		return null;
	}

	private void OnMonsterDead()
	{
	}
}
