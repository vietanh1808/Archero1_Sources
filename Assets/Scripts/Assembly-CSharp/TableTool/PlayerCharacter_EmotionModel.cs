namespace TableTool
{
	public class PlayerCharacter_EmotionModel : LocalModel<PlayerCharacter_Emotion, int>
	{
		private const string _Filename = "PlayerCharacter_Emotion";

		protected override string Filename => null;

		protected override int GetBeanKey(PlayerCharacter_Emotion bean)
		{
			return 0;
		}
	}
}
