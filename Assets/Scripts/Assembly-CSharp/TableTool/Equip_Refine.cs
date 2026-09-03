using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip_Refine : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Progress;

		private ObscuredInt _Star;

		private ObscuredInt _EquipQuality;

		private ObscuredInt _Item;

		private ObscuredInt _Coin;

		private ObscuredString[] _Open;

		private ObscuredString[] _BreakNeed;

		private ObscuredInt _Quality;

		private ObscuredString[] _Position1;

		private ObscuredString[] _Position2;

		private ObscuredString[] _Position3;

		private ObscuredString[] _Position4;

		private ObscuredString[] _Position5;

		private ObscuredString[] _Position6;

		private ObscuredString[] _Position7;

		private ObscuredString[] _Position8;

		private ObscuredString[] _Position9;

		public int Id => 0;

		public int Progress => 0;

		public int Star => 0;

		public int EquipQuality => 0;

		public int Item => 0;

		public int Coin => 0;

		public string[] Open => null;

		public string[] BreakNeed => null;

		public int Quality => 0;

		public string[] Position1 => null;

		public string[] Position2 => null;

		public string[] Position3 => null;

		public string[] Position4 => null;

		public string[] Position5 => null;

		public string[] Position6 => null;

		public string[] Position7 => null;

		public string[] Position8 => null;

		public string[] Position9 => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip_Refine Copy()
		{
			return null;
		}
	}
}
