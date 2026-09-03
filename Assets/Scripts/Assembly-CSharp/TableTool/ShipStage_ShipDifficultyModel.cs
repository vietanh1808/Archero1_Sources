namespace TableTool
{
	public class ShipStage_ShipDifficultyModel : LocalModel<ShipStage_ShipDifficulty, int>
	{
		private const string _Filename = "ShipStage_ShipDifficulty";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipStage_ShipDifficulty bean)
		{
			return 0;
		}
	}
}
