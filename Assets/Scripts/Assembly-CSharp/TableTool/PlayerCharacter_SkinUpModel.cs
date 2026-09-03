namespace TableTool
{
	public class PlayerCharacter_SkinUpModel : LocalModel<PlayerCharacter_SkinUp, int>
	{
		private const string _Filename = "PlayerCharacter_SkinUp";

		protected override string Filename => null;

		protected override int GetBeanKey(PlayerCharacter_SkinUp bean)
		{
			return 0;
		}
	}
}
