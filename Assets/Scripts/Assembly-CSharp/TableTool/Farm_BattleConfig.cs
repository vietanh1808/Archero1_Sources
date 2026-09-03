using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Farm_BattleConfig : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Notes;

		private ObscuredFloat _Value;

		private ObscuredString[] _StringValue;

		public int Id => 0;

		public string Notes => null;

		public float Value => 0f;

		public string[] StringValue => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Farm_BattleConfig Copy()
		{
			return null;
		}
	}
}
