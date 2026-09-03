using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_GiftBox : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Name;

		private ObscuredInt _Quality;

		private ObscuredString _GiftIcon;

		private ObscuredInt _GiftType;

		private ObscuredInt _Num;

		private ObscuredString[] _Reward;

		private ObscuredInt[] _ShowStep;

		private ObscuredString[] _Show1;

		private ObscuredString[] _Show2;

		private ObscuredString[] _Show3;

		private ObscuredString[] _Show4;

		private ObscuredString[] _Show5;

		private ObscuredString[] _Show6;

		private ObscuredString[] _Show7;

		private ObscuredString[] _Show8;

		private ObscuredString[] _Show9;

		private ObscuredInt _Position;

		private ObscuredInt _Streamer;

		private ObscuredInt _HideBg;

		public int ID => 0;

		public string Name => null;

		public int Quality => 0;

		public string GiftIcon => null;

		public int GiftType => 0;

		public int Num => 0;

		public string[] Reward => null;

		public int[] ShowStep => null;

		public string[] Show1 => null;

		public string[] Show2 => null;

		public string[] Show3 => null;

		public string[] Show4 => null;

		public string[] Show5 => null;

		public string[] Show6 => null;

		public string[] Show7 => null;

		public string[] Show8 => null;

		public string[] Show9 => null;

		public int Position => 0;

		public int Streamer => 0;

		public int HideBg => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_GiftBox Copy()
		{
			return null;
		}
	}
}
