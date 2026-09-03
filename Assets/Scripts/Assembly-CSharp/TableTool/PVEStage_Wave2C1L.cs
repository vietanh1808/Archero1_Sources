using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PVEStage_Wave2C1L : LocalBean
	{
		private ObscuredInt _WaveID;

		private ObscuredInt _Time;

		private ObscuredInt[] _Path1;

		private ObscuredInt[] _Path2;

		private ObscuredInt[] _Path3;

		private ObscuredString[] _GroupID;

		private ObscuredInt[] _Num;

		private ObscuredInt _BOSSPathNum;

		private ObscuredString[] _BOSSGroupID;

		private ObscuredString[] _Attributes;

		private ObscuredString[] _MapAttributes;

		private ObscuredFloat _Hard_TimeRatio;

		public int WaveID => 0;

		public int Time => 0;

		public int[] Path1 => null;

		public int[] Path2 => null;

		public int[] Path3 => null;

		public string[] GroupID => null;

		public int[] Num => null;

		public int BOSSPathNum => 0;

		public string[] BOSSGroupID => null;

		public string[] Attributes => null;

		public string[] MapAttributes => null;

		public float Hard_TimeRatio => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PVEStage_Wave2C1L Copy()
		{
			return null;
		}
	}
}
