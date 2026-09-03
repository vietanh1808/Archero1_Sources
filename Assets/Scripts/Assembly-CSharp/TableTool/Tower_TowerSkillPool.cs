using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Tower_TowerSkillPool : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString[] _Skill;

		public int Id => 0;

		public string[] Skill => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Tower_TowerSkillPool Copy()
		{
			return null;
		}
	}
}
