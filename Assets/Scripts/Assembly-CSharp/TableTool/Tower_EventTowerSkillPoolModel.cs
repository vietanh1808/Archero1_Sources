namespace TableTool
{
	public class Tower_EventTowerSkillPoolModel : LocalModel<Tower_EventTowerSkillPool, int>
	{
		private const string _Filename = "Tower_EventTowerSkillPool";

		protected override string Filename => null;

		protected override int GetBeanKey(Tower_EventTowerSkillPool bean)
		{
			return 0;
		}
	}
}
