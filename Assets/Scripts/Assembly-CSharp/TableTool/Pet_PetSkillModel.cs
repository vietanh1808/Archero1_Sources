namespace TableTool
{
	public class Pet_PetSkillModel : LocalModel<Pet_PetSkill, int>
	{
		private const string _Filename = "Pet_PetSkill";

		protected override string Filename => null;

		protected override int GetBeanKey(Pet_PetSkill bean)
		{
			return 0;
		}
	}
}
