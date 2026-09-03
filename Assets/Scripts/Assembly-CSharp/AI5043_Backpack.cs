using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class AI5043_Backpack : AIBase_Backpack
{
	public class AI5043BackpackAtkWrapper : ActionSeqWrapper
	{
		private WeightRandomCount mWeightRandom;

		private int callid;

		private int maxcount;

		private List<Vector3> list;

		private AIBase m_AI;

		private bool isDataInitialized;

		protected override void OnInit()
		{
		}

		protected override void OnEnd()
		{
		}

		private void initSeq()
		{
		}

		private void initOnce()
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

	protected override ActionBase GetSelfAI()
	{
		return null;
	}
}
