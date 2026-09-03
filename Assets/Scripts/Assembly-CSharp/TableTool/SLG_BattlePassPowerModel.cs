namespace TableTool
{
	public class SLG_BattlePassPowerModel : LocalModel<SLG_BattlePassPower, int>
	{
		private const string _Filename = "SLG_BattlePassPower";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_BattlePassPower bean)
		{
			return 0;
		}
	}
}
