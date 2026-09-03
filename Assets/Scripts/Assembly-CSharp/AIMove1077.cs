using System;
using System.Collections.Generic;
using UnityEngine;

public class AIMove1077 : AIMoveBase
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

	protected Animation ani;

	private bool bDizzy;

	private bool bShowCollider;

	public AIMove1077(EntityBase entity, int range)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void SetAnimation()
	{
	}

	protected override void OnEnd()
	{
	}

	protected virtual void PlayHide()
	{
	}

	protected virtual void Hide()
	{
	}

	protected virtual void Show(Vector3 endpos)
	{
	}
}
