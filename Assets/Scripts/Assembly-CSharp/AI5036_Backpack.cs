using Dxx.Util;

public class AI5036_Backpack : AIBase_Backpack
{
	public class AI5036BackpackAtkWrapper : ActionSeqWrapper
	{
		private WeightRandomCount weightnear;

		private WeightRandomCount weightfar;

		private AIBase m_AI;

		protected override void OnDeInit()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnInit()
		{
		}
	}

	protected override ActionBase GetSelfAI()
	{
		return null;
	}
}
