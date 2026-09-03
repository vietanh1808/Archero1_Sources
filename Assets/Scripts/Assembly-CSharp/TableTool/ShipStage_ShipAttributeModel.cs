namespace TableTool
{
	public class ShipStage_ShipAttributeModel : LocalModel<ShipStage_ShipAttribute, int>
	{
		private const string _Filename = "ShipStage_ShipAttribute";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipStage_ShipAttribute bean)
		{
			return 0;
		}
	}
}
