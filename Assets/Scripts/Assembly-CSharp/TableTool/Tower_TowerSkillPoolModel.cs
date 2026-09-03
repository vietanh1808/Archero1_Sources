namespace TableTool
{
	public class Tower_TowerSkillPoolModel : LocalModel<Tower_TowerSkillPool, int>
	{
		private const string _Filename = "Tower_TowerSkillPool";

		protected override string Filename => null;

		protected override int GetBeanKey(Tower_TowerSkillPool bean)
		{
			return 0;
		}
	}
}
