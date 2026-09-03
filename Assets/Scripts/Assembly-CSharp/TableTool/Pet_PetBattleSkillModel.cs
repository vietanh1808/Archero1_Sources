namespace TableTool
{
	public class Pet_PetBattleSkillModel : LocalModel<Pet_PetBattleSkill, int>
	{
		private const string _Filename = "Pet_PetBattleSkill";

		protected override string Filename => null;

		protected override int GetBeanKey(Pet_PetBattleSkill bean)
		{
			return 0;
		}
	}
}
