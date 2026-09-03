namespace TableTool
{
	public class ShipBattle_AttributeDescModel : LocalModel<ShipBattle_AttributeDesc, int>
	{
		private const string _Filename = "ShipBattle_AttributeDesc";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_AttributeDesc bean)
		{
			return 0;
		}
	}
}
