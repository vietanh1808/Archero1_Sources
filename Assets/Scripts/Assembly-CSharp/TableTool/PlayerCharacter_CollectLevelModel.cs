namespace TableTool
{
	public class PlayerCharacter_CollectLevelModel : LocalModel<PlayerCharacter_CollectLevel, int>
	{
		private const string _Filename = "PlayerCharacter_CollectLevel";

		protected override string Filename => null;

		protected override int GetBeanKey(PlayerCharacter_CollectLevel bean)
		{
			return 0;
		}
	}
}
