using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Sweep_Sweep : LocalBean
	{
		private ObscuredInt _ChapterId;

		private ObscuredInt _Unlock;

		private ObscuredString[] _DropShow;

		private ObscuredInt _DropId;

		private ObscuredInt _Limit_DropId;

		private ObscuredInt _Year4_DropIDA;

		private ObscuredInt _Year4_DropIDBC;

		private ObscuredInt _ManorItemDropID;

		private ObscuredInt _Red_packet_DropID;

		private ObscuredInt _TradingPost_DropID;

		private ObscuredInt _ActivityItem_DropID;

		private ObscuredInt _ActivityMistItem_DropID;

		private ObscuredInt _Totem_DropID;

		private ObscuredInt _Totem_DropID1;

		private ObscuredInt[] _MonsterId;

		private ObscuredInt[] _MonsterProb;

		private ObscuredInt[] _MonsterMin;

		private ObscuredInt[] _MonsterMax;

		public int ChapterId => 0;

		public int Unlock => 0;

		public string[] DropShow => null;

		public int DropId => 0;

		public int Limit_DropId => 0;

		public int Year4_DropIDA => 0;

		public int Year4_DropIDBC => 0;

		public int ManorItemDropID => 0;

		public int Red_packet_DropID => 0;

		public int TradingPost_DropID => 0;

		public int ActivityItem_DropID => 0;

		public int ActivityMistItem_DropID => 0;

		public int Totem_DropID => 0;

		public int Totem_DropID1 => 0;

		public int[] MonsterId => null;

		public int[] MonsterProb => null;

		public int[] MonsterMin => null;

		public int[] MonsterMax => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Sweep_Sweep Copy()
		{
			return null;
		}
	}
}
