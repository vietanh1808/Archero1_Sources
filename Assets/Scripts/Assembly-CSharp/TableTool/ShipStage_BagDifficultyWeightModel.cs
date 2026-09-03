namespace TableTool
{
	public class ShipStage_BagDifficultyWeightModel : LocalModel<ShipStage_BagDifficultyWeight, int>
	{
		private const string _Filename = "ShipStage_BagDifficultyWeight";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipStage_BagDifficultyWeight bean)
		{
			return 0;
		}
	}
}
