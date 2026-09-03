namespace TableTool
{
	public class Daily_CooperationRewardModel : LocalModel<Daily_CooperationReward, int>
	{
		private const string _Filename = "Daily_CooperationReward";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_CooperationReward bean)
		{
			return 0;
		}
	}
}
