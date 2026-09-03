namespace TableTool
{
	public class PlayerCharacter_SkinModel : LocalModel<PlayerCharacter_Skin, int>
	{
		private const string _Filename = "PlayerCharacter_Skin";

		protected override string Filename => null;

		protected override int GetBeanKey(PlayerCharacter_Skin bean)
		{
			return 0;
		}
	}
}
