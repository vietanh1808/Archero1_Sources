using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_EndlessReward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Gold;

		private ObscuredFloat _Gold_args;

		private ObscuredInt _Exp;

		private ObscuredInt _Stonenum;

		private ObscuredInt _Scrollnum;

		private ObscuredString _Equipnum;

		private ObscuredInt _Scrolldropid;

		private ObscuredInt _EquipDropid;

		public int ID => 0;

		public int Gold => 0;

		public float Gold_args => 0f;

		public int Exp => 0;

		public int Stonenum => 0;

		public int Scrollnum => 0;

		public string Equipnum => null;

		public int Scrolldropid => 0;

		public int EquipDropid => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_EndlessReward Copy()
		{
			return null;
		}
	}
}
