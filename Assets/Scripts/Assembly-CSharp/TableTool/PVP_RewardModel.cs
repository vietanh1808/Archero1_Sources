namespace TableTool
{
	public class PVP_RewardModel : LocalModel<PVP_Reward, int>
	{
		private const string _Filename = "PVP_Reward";

		protected override string Filename => null;

		protected override int GetBeanKey(PVP_Reward bean)
		{
			return 0;
		}
	}
}
