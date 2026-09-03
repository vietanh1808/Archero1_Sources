using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_Buff : LocalBean
	{
		private ObscuredInt _BuffID;

		private ObscuredString _Notes;

		private ObscuredInt _BuffType;

		private ObscuredString[] _Attributes;

		private ObscuredInt _Time;

		private ObscuredString _Pic;

		private ObscuredInt _OverlayMethod;

		private ObscuredInt[] _ExtraParam;

		public int BuffID => 0;

		public string Notes => null;

		public int BuffType => 0;

		public string[] Attributes => null;

		public int Time => 0;

		public string Pic => null;

		public int OverlayMethod => 0;

		public int[] ExtraParam => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_Buff Copy()
		{
			return null;
		}
	}
}
