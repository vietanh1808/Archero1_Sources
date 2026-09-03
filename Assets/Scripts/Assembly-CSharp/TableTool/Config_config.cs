using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Config_config : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Notes;

		private ObscuredFloat _Value;

		private ObscuredString[] _StringValue;

		public int ID => 0;

		public string Notes => null;

		public float Value => 0f;

		public string[] StringValue => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Config_config Copy()
		{
			return null;
		}
	}
}
