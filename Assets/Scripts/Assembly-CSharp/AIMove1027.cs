using System;
using System.Collections.Generic;
using UnityEngine;

public class AIMove1027 : AIMoveBase
{
	public Action<bool> onShow;

	public float showTimeMin;

	public float showTimeMax;

	private int range;

	protected EntityBase target;

	protected List<Grid.NodeItem> findpath;

	protected Vector3 nextpos;

	protected Vector3 endpos;

	private ActionBattle action;

	private Animation ani;

	private bool bDizzy;

	private bool bShowCollider;

	public AIMove1027(EntityBase entity, int range)
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

	private void ShowCollider(bool value)
	{
	}

	protected override void OnEnd()
	{
	}
}
