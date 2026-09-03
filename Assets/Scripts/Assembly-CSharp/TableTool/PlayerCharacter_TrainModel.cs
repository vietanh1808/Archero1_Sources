namespace TableTool
{
	public class PlayerCharacter_TrainModel : LocalModel<PlayerCharacter_Train, int>
	{
		private const string _Filename = "PlayerCharacter_Train";

		protected override string Filename => null;

		protected override int GetBeanKey(PlayerCharacter_Train bean)
		{
			return 0;
		}
	}
}
