namespace TableTool
{
	public class PlayerCharacter_CardThemeModel : LocalModel<PlayerCharacter_CardTheme, int>
	{
		private const string _Filename = "PlayerCharacter_CardTheme";

		protected override string Filename => null;

		protected override int GetBeanKey(PlayerCharacter_CardTheme bean)
		{
			return 0;
		}
	}
}
