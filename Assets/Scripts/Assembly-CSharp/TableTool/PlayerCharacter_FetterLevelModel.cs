namespace TableTool
{
	public class PlayerCharacter_FetterLevelModel : LocalModel<PlayerCharacter_FetterLevel, int>
	{
		private const string _Filename = "PlayerCharacter_FetterLevel";

		protected override string Filename => null;

		protected override int GetBeanKey(PlayerCharacter_FetterLevel bean)
		{
			return 0;
		}
	}
}
