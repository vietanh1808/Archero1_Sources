using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Manor_Ability : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Level;

		private ObscuredString _Img;

		private ObscuredInt _IsWorker;

		private ObscuredInt _Target;

		private ObscuredInt _Type;

		private ObscuredInt _IsActiveSkills;

		private ObscuredInt _Uses;

		private ObscuredInt _Restore;

		private ObscuredInt _BuildID;

		private ObscuredString[] _Args;

		public int Id => 0;

		public int Level => 0;

		public string Img => null;

		public int IsWorker => 0;

		public int Target => 0;

		public int Type => 0;

		public int IsActiveSkills => 0;

		public int Uses => 0;

		public int Restore => 0;

		public int BuildID => 0;

		public string[] Args => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Manor_Ability Copy()
		{
			return null;
		}
	}
}
