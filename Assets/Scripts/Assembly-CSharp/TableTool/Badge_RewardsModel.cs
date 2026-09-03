namespace TableTool
{
	public class Badge_RewardsModel : LocalModel<Badge_Rewards, int>
	{
		private const string _Filename = "Badge_Rewards";

		protected override string Filename => null;

		protected override int GetBeanKey(Badge_Rewards bean)
		{
			return 0;
		}
	}
}
