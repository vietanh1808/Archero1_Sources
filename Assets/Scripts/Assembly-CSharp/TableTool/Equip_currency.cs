using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip_currency : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Name;

		private ObscuredInt _DivideVersion;

		private ObscuredInt _DivideVersionLevel;

		public int Id => 0;

		public string Name => null;

		public int DivideVersion => 0;

		public int DivideVersionLevel => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip_currency Copy()
		{
			return null;
		}
	}
}
