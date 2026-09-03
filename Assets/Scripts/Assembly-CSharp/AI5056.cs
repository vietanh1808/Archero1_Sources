using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class AI5056 : AIBase
{
	private struct CallST
	{
		public int Id;

		public int cnt;

		public int max;

		public CallST(int id, int cnt, int max)
		{
			Id = 0;
			this.cnt = 0;
			this.max = 0;
		}
	}

	private WeightRandomCount mWeight;

	private float attackadd;

	private float m_fLastUse5174Time;

	private List<CallST> m_listCallIds;

	private List<Vector3> m_listPos;

	private int m_nCallNum;

	private List<EntityBase> m_listCallEntities;

	protected override void OnInitOnce()
	{
	}

	private void InitCall()
	{
	}

	private void CheckPos(int i, int j)
	{
	}

	protected override void OnInit()
	{
	}

	private void OnCallDeInit(EntityBase entity)
	{
	}

	private bool Condition1()
	{
		return false;
	}

	private bool Condition2()
	{
		return false;
	}

	private ActionBase GetActionMoveOne(int waittime, int waitmaxtime)
	{
		return null;
	}

	protected override void OnAIDeInit()
	{
	}
}
