using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PlayerCharacter_Exchange : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _UseGroup;

		private ObscuredInt _TargetGroup;

		private ObscuredInt _Proportion;

		private ObscuredInt _Gems;

		public int Id => 0;

		public int UseGroup => 0;

		public int TargetGroup => 0;

		public int Proportion => 0;

		public int Gems => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PlayerCharacter_Exchange Copy()
		{
			return null;
		}
	}
}
