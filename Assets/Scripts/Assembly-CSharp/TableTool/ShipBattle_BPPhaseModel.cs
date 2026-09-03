namespace TableTool
{
	public class ShipBattle_BPPhaseModel : LocalModel<ShipBattle_BPPhase, int>
	{
		private const string _Filename = "ShipBattle_BPPhase";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_BPPhase bean)
		{
			return 0;
		}
	}
}
