namespace TableTool
{
	public class GuildActivity_BossBox_RewardsModel : LocalModel<GuildActivity_BossBox_Rewards, int>
	{
		private const string _Filename = "GuildActivity_BossBox_Rewards";

		protected override string Filename => null;

		protected override int GetBeanKey(GuildActivity_BossBox_Rewards bean)
		{
			return 0;
		}
	}
}
