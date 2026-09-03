using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class AI5064 : AIBase
{
	private WeightRandomCount weight;

	private List<EntityBase> mList;

	private bool m_bSprint;

	protected float distance;

	protected float updatetime;

	private bool bStart;

	private float starttime;

	private float percent;

	private float x;

	private float y;

	private Vector3 startpos;

	private Vector3 endpos;

	private Vector3 currentmove;

	private float percentbefore;

	private float percentchange;

	private GameObject elite_thunder;

	private SequencePool mSequencePool;

	private bool bShowCollider;

	private int callIndex;

	private Vector3[] poses;

	private bool bCall;

	private List<float> hpBlows;

	private bool bDropDown;

	private int lastRan;

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private ActionBase GetAttackAction_1()
	{
		return null;
	}

	protected override void OnUpdate(float delta)
	{
	}

	private ActionBase GetCall()
	{
		return null;
	}

	private void OnMonsterDead()
	{
	}

	private void GetCallPos()
	{
	}

	private void ShowCollider(bool value)
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}
}
