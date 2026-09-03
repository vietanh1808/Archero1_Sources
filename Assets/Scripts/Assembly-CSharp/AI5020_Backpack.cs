using Dxx.Util;

public class AI5020_Backpack : AIBase_Backpack
{
	public class AI5020BackpackAI : ActionSeqWrapper
	{
		private WeightRandomCount weight;

		private int ran;

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
