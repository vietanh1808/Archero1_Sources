using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Drop_DropActivitySEquip : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Version;

		private ObscuredInt _Rate;

		private ObscuredInt _OpenTime;

		private ObscuredInt _EndTime;

		private ObscuredString[] _UPshow;

		private ObscuredString[] _UPDrop;

		private ObscuredInt _UPtimes;

		private ObscuredString _Img;

		public int ID => 0;

		public int Version => 0;

		public int Rate => 0;

		public int OpenTime => 0;

		public int EndTime => 0;

		public string[] UPshow => null;

		public string[] UPDrop => null;

		public int UPtimes => 0;

		public string Img => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Drop_DropActivitySEquip Copy()
		{
			return null;
		}
	}
}
