namespace TableTool
{
	public class PlayerCharacter_ExchangeModel : LocalModel<PlayerCharacter_Exchange, int>
	{
		private const string _Filename = "PlayerCharacter_Exchange";

		protected override string Filename => null;

		protected override int GetBeanKey(PlayerCharacter_Exchange bean)
		{
			return 0;
		}
	}
}
