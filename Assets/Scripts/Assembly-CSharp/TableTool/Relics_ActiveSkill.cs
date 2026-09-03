using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Relics_ActiveSkill : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Type;

		private ObscuredString _Args;

		public int Id => 0;

		public int Type => 0;

		public string Args => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Relics_ActiveSkill Copy()
		{
			return null;
		}
	}
}
