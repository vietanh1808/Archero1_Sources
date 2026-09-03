namespace TableTool
{
	public class Runes_RewardModel : LocalModel<Runes_Reward, int>
	{
		private const string _Filename = "Runes_Reward";

		protected override string Filename => null;

		protected override int GetBeanKey(Runes_Reward bean)
		{
			return 0;
		}
	}
}
