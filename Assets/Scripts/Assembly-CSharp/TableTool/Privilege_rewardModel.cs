namespace TableTool
{
	public class Privilege_rewardModel : LocalModel<Privilege_reward, int>
	{
		private const string _Filename = "Privilege_reward";

		protected override string Filename => null;

		protected override int GetBeanKey(Privilege_reward bean)
		{
			return 0;
		}
	}
}
