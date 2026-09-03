namespace TableTool
{
	public class Skill_slotin_dungeonModel : LocalModel<Skill_slotin_dungeon, int>
	{
		private const string _Filename = "Skill_slotin_dungeon";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_slotin_dungeon bean)
		{
			return 0;
		}
	}
}
