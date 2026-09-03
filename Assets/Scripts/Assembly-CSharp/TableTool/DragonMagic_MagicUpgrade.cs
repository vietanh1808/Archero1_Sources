using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class DragonMagic_MagicUpgrade : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _NeedLevel;

		private ObscuredInt _ItemNum;

		private ObscuredInt _ItemNumSum;

		public int ID => 0;

		public int NeedLevel => 0;

		public int ItemNum => 0;

		public int ItemNumSum => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public DragonMagic_MagicUpgrade Copy()
		{
			return null;
		}
	}
}
