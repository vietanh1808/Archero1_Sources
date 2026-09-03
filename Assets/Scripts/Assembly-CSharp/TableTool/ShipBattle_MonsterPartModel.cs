namespace TableTool
{
	public class ShipBattle_MonsterPartModel : LocalModel<ShipBattle_MonsterPart, int>
	{
		private const string _Filename = "ShipBattle_MonsterPart";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_MonsterPart bean)
		{
			return 0;
		}
	}
}
