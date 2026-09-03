using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_GemCostBoxControl : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Chapter;

		private ObscuredInt _Version;

		private ObscuredInt _Type;

		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		private ObscuredInt[] _House;

		public int ID => 0;

		public int Chapter => 0;

		public int Version => 0;

		public int Type => 0;

		public int StartTime => 0;

		public int EndTime => 0;

		public int[] House => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_GemCostBoxControl Copy()
		{
			return null;
		}
	}
}
