namespace TableTool
{
	public class PlayerCharacter_HeadFrameModel : LocalModel<PlayerCharacter_HeadFrame, int>
	{
		private const string _Filename = "PlayerCharacter_HeadFrame";

		protected override string Filename => null;

		protected override int GetBeanKey(PlayerCharacter_HeadFrame bean)
		{
			return 0;
		}
	}
}
