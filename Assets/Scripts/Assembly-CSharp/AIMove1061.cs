using System;
using System.Collections.Generic;
using UnityEngine;

public class AIMove1061 : AIMoveBase
{
	public Action<bool> onShow;

	private int range;

	protected EntityBase target;

	protected List<Grid.NodeItem> findpath;

	protected Vector3 nextpos;

	protected Vector3 endpos;

	private ActionBattle action;

	private Animation ani;

	private bool bDizzy;

	private bool bShowCollider;

	private List<AIMove1061HandCtrl> mHands;

	private Queue<AIMove1061HandCtrl> mHandsCache;

	public AIMove1061(EntityBase entity, int range)
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

	private void create_hands()
	{
	}

	private void create_one_hand(Vector3 pos)
	{
	}

	protected override void OnEnd()
	{
	}
}
