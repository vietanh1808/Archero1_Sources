using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class AI5061 : AIBase
{
	private SequencePool mSeqPool;

	private bool mFirst;

	private bool mDropEnd;

	private List<EntityBase> mList;

	private bool bShowCollider;

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private ActionBase GetAttack()
	{
		return null;
	}

	private ActionBase GetMove()
	{
		return null;
	}

	private ActionBase GetCall()
	{
		return null;
	}

	private Vector3[] GetCallPos()
	{
		return null;
	}

	private void ShowCollider(bool value)
	{
	}
}
