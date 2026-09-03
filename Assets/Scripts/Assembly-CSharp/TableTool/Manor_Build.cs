using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Manor_Build : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Initial;

		private ObscuredInt _Type;

		private ObscuredInt _Repair;

		private ObscuredString _RuinsImg;

		private ObscuredString[] _Img;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _Resource;

		private ObscuredInt _GetTime;

		private ObscuredInt _Time;

		private ObscuredString[] _Material;

		private ObscuredInt _Exp;

		private ObscuredInt _FountainLV;

		private ObscuredInt _Worker;

		private ObscuredInt[] _Dispatch;

		private ObscuredInt[] _Star;

		private ObscuredString[] _Args;

		private ObscuredInt _Stolen;

		public int ID => 0;

		public int Initial => 0;

		public int Type => 0;

		public int Repair => 0;

		public string RuinsImg => null;

		public string[] Img => null;

		public int MaxLevel => 0;

		public int Resource => 0;

		public int GetTime => 0;

		public int Time => 0;

		public string[] Material => null;

		public int Exp => 0;

		public int FountainLV => 0;

		public int Worker => 0;

		public int[] Dispatch => null;

		public int[] Star => null;

		public string[] Args => null;

		public int Stolen => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Manor_Build Copy()
		{
			return null;
		}
	}
}
