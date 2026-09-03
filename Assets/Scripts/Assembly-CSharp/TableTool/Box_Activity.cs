using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_Activity : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredFloat _PayId;

		private ObscuredString[] _ShowCond;

		private ObscuredString[] _CloseCond;

		private ObscuredString[] _Reward;

		private ObscuredInt _Multiple;

		public int ID => 0;

		public float PayId => 0f;

		public string[] ShowCond => null;

		public string[] CloseCond => null;

		public string[] Reward => null;

		public int Multiple => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_Activity Copy()
		{
			return null;
		}
	}
}
