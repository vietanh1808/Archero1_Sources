namespace TableTool
{
	public class ShipBattle_MCannonEffectModel : LocalModel<ShipBattle_MCannonEffect, int>
	{
		private const string _Filename = "ShipBattle_MCannonEffect";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_MCannonEffect bean)
		{
			return 0;
		}
	}
}
