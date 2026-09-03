namespace TableTool
{
	public class PlayerCharacter_HeadIconModel : LocalModel<PlayerCharacter_HeadIcon, int>
	{
		private const string _Filename = "PlayerCharacter_HeadIcon";

		protected override string Filename => null;

		protected override int GetBeanKey(PlayerCharacter_HeadIcon bean)
		{
			return 0;
		}
	}
}
