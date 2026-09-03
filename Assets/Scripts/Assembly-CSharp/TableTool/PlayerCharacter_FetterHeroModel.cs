namespace TableTool
{
	public class PlayerCharacter_FetterHeroModel : LocalModel<PlayerCharacter_FetterHero, int>
	{
		private const string _Filename = "PlayerCharacter_FetterHero";

		protected override string Filename => null;

		protected override int GetBeanKey(PlayerCharacter_FetterHero bean)
		{
			return 0;
		}
	}
}
