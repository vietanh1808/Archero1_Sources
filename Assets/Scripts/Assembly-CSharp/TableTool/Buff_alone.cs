using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Buff_alone : LocalBean
	{
		private ObscuredInt _BuffID;

		private ObscuredString _Notes;

		private ObscuredInt _FxId;

		private ObscuredInt _OverType;

		private ObscuredInt _OverTypeArg;

		private ObscuredInt _BuffType;

		private ObscuredInt _DizzyChance;

		private ObscuredString _Attribute;

		private ObscuredString[] _FirstEffects;

		private ObscuredString[] _Effects;

		private ObscuredString[] _Attributes;

		private ObscuredFloat[] _Args;

		private ObscuredString _ArgsContent;

		private ObscuredInt _Time;

		private ObscuredInt _Delay_time;

		private ObscuredInt[] _Cover_Buff;

		private ObscuredInt[] _Refresh_Buff;

		private ObscuredInt _Type;

		public int BuffID => 0;

		public string Notes => null;

		public int FxId => 0;

		public int OverType => 0;

		public int OverTypeArg => 0;

		public int BuffType => 0;

		public int DizzyChance => 0;

		public string Attribute => null;

		public string[] FirstEffects => null;

		public string[] Effects => null;

		public string[] Attributes => null;

		public float[] Args => null;

		public string ArgsContent => null;

		public int Time => 0;

		public int Delay_time => 0;

		public int[] Cover_Buff => null;

		public int[] Refresh_Buff => null;

		public int Type => 0;

		public EBuffOverType BuffOverType => EBuffOverType.eResetTime;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Buff_alone Copy()
		{
			return null;
		}
	}
}
