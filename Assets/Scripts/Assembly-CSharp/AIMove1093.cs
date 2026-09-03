using System;
using System.Collections.Generic;
using UnityEngine;

public class AIMove1093 : AIMoveBase
{
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

	public AIMove1093(EntityBase entity, int range)
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
