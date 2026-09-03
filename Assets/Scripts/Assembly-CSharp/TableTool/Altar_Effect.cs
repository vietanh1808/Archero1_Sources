using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Altar_Effect : LocalBean
	{
		private ObscuredInt _EffectID;

		private ObscuredString _Attribute;

		private ObscuredInt _AltarType;

		private ObscuredInt[] _NumMin;

		private ObscuredInt[] _NumMax;

		private ObscuredInt _Duration;

		public int EffectID => 0;

		public string Attribute => null;

		public int AltarType => 0;

		public int[] NumMin => null;

		public int[] NumMax => null;

		public int Duration => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Altar_Effect Copy()
		{
			return null;
		}
	}
}
