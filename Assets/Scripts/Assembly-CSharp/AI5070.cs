using System.Collections.Generic;
using UnityEngine;

public class AI5070 : AIBase
{
	private List<EntityBase> m_listLittleBrothers;

	private List<Vector3> m_listVecs;

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private ActionBase GetCall()
	{
		return null;
	}

	protected virtual ActionBase GetMove2()
	{
		return null;
	}

	private void CallLittleBrother(int id, Vector3 pos)
	{
	}

	private void OnLittleBrotherDead()
	{
	}

	private ActionBase GetAttack_5240()
	{
		return null;
	}

	protected virtual ActionBase GetAttack_5242()
	{
		return null;
	}

	protected virtual ActionBase GetMove()
	{
		return null;
	}

	private ActionBase GetAttack2()
	{
		return null;
	}
}
