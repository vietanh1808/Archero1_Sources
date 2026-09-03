using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_TDWeekReward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt[] _Layer;

		private ObscuredInt[] _NeedNum;

		private ObscuredInt[] _Times;

		private ObscuredInt[] _DropID;

		private ObscuredString[] _Show;

		private ObscuredString[] _Show2;

		private ObscuredString[] _Show3;

		private ObscuredString[] _Show4;

		private ObscuredString[] _Show5;

		private ObscuredString[] _Show6;

		private ObscuredString[] _Show7;

		private ObscuredString[] _Show8;

		private ObscuredString[] _Show9;

		private ObscuredString[] _Show10;

		public int ID => 0;

		public int Type => 0;

		public int[] Layer => null;

		public int[] NeedNum => null;

		public int[] Times => null;

		public int[] DropID => null;

		public string[] Show => null;

		public string[] Show2 => null;

		public string[] Show3 => null;

		public string[] Show4 => null;

		public string[] Show5 => null;

		public string[] Show6 => null;

		public string[] Show7 => null;

		public string[] Show8 => null;

		public string[] Show9 => null;

		public string[] Show10 => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_TDWeekReward Copy()
		{
			return null;
		}
	}
}
