namespace TableTool
{
	public class ShipBattle_BuffModel : LocalModel<ShipBattle_Buff, int>
	{
		private const string _Filename = "ShipBattle_Buff";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Buff bean)
		{
			return 0;
		}
	}
}
