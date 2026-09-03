using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip_Quality : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _ResetGems;

		public int Id => 0;

		public int ResetGems => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip_Quality Copy()
		{
			return null;
		}
	}
}
