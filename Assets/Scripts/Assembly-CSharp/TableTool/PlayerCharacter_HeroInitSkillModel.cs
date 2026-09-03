namespace TableTool
{
	public class PlayerCharacter_HeroInitSkillModel : LocalModel<PlayerCharacter_HeroInitSkill, int>
	{
		private const string _Filename = "PlayerCharacter_HeroInitSkill";

		protected override string Filename => null;

		protected override int GetBeanKey(PlayerCharacter_HeroInitSkill bean)
		{
			return 0;
		}
	}
}
