using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Room_eventdemontext2skill : LocalBean
	{
		private ObscuredInt _EventID;

		private ObscuredString _Notes;

		private ObscuredInt[] _Loses;

		private ObscuredInt _GetID;

		private ObscuredInt _Weight;

		private ObscuredInt _AdvancedWeight;

		private ObscuredInt[] _CloseActivity;

		public int EventID => 0;

		public string Notes => null;

		public int[] Loses => null;

		public int GetID => 0;

		public int Weight => 0;

		public int AdvancedWeight => 0;

		public int[] CloseActivity => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Room_eventdemontext2skill Copy()
		{
			return null;
		}
	}
}
