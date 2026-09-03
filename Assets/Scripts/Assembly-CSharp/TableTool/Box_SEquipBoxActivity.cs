using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_SEquipBoxActivity : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Version;

		private ObscuredInt _OpenTime;

		private ObscuredInt _EndTime;

		private ObscuredInt _Layer;

		public int ID => 0;

		public int Version => 0;

		public int OpenTime => 0;

		public int EndTime => 0;

		public int Layer => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_SEquipBoxActivity Copy()
		{
			return null;
		}
	}
}
