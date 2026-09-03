namespace TableTool
{
	public class ShipStage_BagDifficultyModel : LocalModel<ShipStage_BagDifficulty, int>
	{
		private const string _Filename = "ShipStage_BagDifficulty";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipStage_BagDifficulty bean)
		{
			return 0;
		}
	}
}
