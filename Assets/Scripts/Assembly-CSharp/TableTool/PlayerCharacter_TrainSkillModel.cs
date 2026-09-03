namespace TableTool
{
	public class PlayerCharacter_TrainSkillModel : LocalModel<PlayerCharacter_TrainSkill, int>
	{
		private const string _Filename = "PlayerCharacter_TrainSkill";

		protected override string Filename => null;

		protected override int GetBeanKey(PlayerCharacter_TrainSkill bean)
		{
			return 0;
		}
	}
}
