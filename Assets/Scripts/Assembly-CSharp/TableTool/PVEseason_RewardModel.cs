namespace TableTool
{
	public class PVEseason_RewardModel : LocalModel<PVEseason_Reward, int>
	{
		private const string _Filename = "PVEseason_Reward";

		protected override string Filename => null;

		protected override int GetBeanKey(PVEseason_Reward bean)
		{
			return 0;
		}
	}
}
