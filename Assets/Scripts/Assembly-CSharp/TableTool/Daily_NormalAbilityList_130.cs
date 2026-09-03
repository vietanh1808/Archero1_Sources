using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_NormalAbilityList_130 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _ActionType;

		private ObscuredInt _AbilityType;

		private ObscuredString[] _AbilityID;

		private ObscuredInt _Duration;

		private ObscuredInt _FxId;

		public int ID => 0;

		public int ActionType => 0;

		public int AbilityType => 0;

		public string[] AbilityID => null;

		public int Duration => 0;

		public int FxId => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_NormalAbilityList_130 Copy()
		{
			return null;
		}
	}
}
