namespace TableTool
{
	public class ShipStage_ShipDifficultyWeightModel : LocalModel<ShipStage_ShipDifficultyWeight, int>
	{
		private const string _Filename = "ShipStage_ShipDifficultyWeight";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipStage_ShipDifficultyWeight bean)
		{
			return 0;
		}
	}
}
