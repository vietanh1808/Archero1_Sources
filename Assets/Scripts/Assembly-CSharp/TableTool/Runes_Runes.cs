using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Runes_Runes : LocalBean
	{
		private ObscuredInt _CharID;

		private ObscuredInt _IconID;

		private ObscuredInt _UnLockLevel;

		private ObscuredInt[] _Rand1;

		private ObscuredInt[] _Rand2;

		private ObscuredInt[] _Rand3;

		private ObscuredInt[] _Rand4;

		private ObscuredInt[] _Rand5;

		private ObscuredInt[] _RandUnLockLevel;

		public int CharID => 0;

		public int IconID => 0;

		public int UnLockLevel => 0;

		public int[] Rand1 => null;

		public int[] Rand2 => null;

		public int[] Rand3 => null;

		public int[] Rand4 => null;

		public int[] Rand5 => null;

		public int[] RandUnLockLevel => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Runes_Runes Copy()
		{
			return null;
		}
	}
}
