public class AI5006_Backpack : AIBase_Backpack
{
	public class AI5006BackpackAtkWrapper : ActionSeqWrapper
	{
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

		private ActionBase GetActionAttacks(int attackid, int attacktime, int attackmaxtime)
		{
			return null;
		}
	}

	protected override ActionBase GetSelfAI()
	{
		return null;
	}
}
