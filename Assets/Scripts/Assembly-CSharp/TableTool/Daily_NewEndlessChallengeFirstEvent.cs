using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_NewEndlessChallengeFirstEvent : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Skill;

		private ObscuredInt _Weight;

		private ObscuredInt _Layer;

		private ObscuredString _Icon;

		public int ID => 0;

		public int Skill => 0;

		public int Weight => 0;

		public int Layer => 0;

		public string Icon => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_NewEndlessChallengeFirstEvent Copy()
		{
			return null;
		}
	}
}
