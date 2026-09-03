using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PVP_ChangeInfo : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Icon;

		private ObscuredInt _Type;

		public int ID => 0;

		public int Icon => 0;

		public int Type => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PVP_ChangeInfo Copy()
		{
			return null;
		}
	}
}
