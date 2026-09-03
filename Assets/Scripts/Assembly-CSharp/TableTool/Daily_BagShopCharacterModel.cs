namespace TableTool
{
	public class Daily_BagShopCharacterModel : LocalModel<Daily_BagShopCharacter, int>
	{
		private const string _Filename = "Daily_BagShopCharacter";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_BagShopCharacter bean)
		{
			return 0;
		}
	}
}
