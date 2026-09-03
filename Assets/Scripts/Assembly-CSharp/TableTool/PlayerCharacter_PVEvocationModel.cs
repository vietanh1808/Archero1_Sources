namespace TableTool
{
	public class PlayerCharacter_PVEvocationModel : LocalModel<PlayerCharacter_PVEvocation, int>
	{
		private const string _Filename = "PlayerCharacter_PVEvocation";

		protected override string Filename => null;

		protected override int GetBeanKey(PlayerCharacter_PVEvocation bean)
		{
			return 0;
		}
	}
}
