using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class AI5083 : AIBase
{
	private SequencePool mSeqPool;

	private bool mFirst;

	private bool mDropEnd;

	private List<EntityBase> mList;

	private bool bShowCollider;

	private const float CDTime = 30f;

	private float m_fCreatPortalTime;

	private Dictionary<Boss5083CallCtrl, Vector3> m_listPortals;

	private bool m_bJoyDisableFlag;

	protected override void OnInitOnce()
	{
	}

	private void OnWillDead()
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

	private void ShowCollider(bool value)
	{
	}

	private ActionBase GetCall()
	{
		return null;
	}

	protected override void OnUpdate(float delta)
	{
	}

	private void OnPortalDeInit(Boss5083CallCtrl ctrl)
	{
	}

	private void OnTranslate(Boss5083CallCtrl ctrl)
	{
	}

	private void CreateSmoke()
	{
	}

	private ActionSequence GetCall2()
	{
		return null;
	}

	private Transform CreateBullet(int id, Vector3 pos, float angle)
	{
		return null;
	}
}
