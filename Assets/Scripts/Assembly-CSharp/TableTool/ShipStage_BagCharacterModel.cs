namespace TableTool
{
	public class ShipStage_BagCharacterModel : LocalModel<ShipStage_BagCharacter, int>
	{
		private const string _Filename = "ShipStage_BagCharacter";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipStage_BagCharacter bean)
		{
			return 0;
		}
	}
}
