using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Room_eventangelskill : LocalBean
	{
		private ObscuredInt _EventID;

		private ObscuredString _Notes;

		private ObscuredInt _GetID;

		private ObscuredInt _Weight;

		private ObscuredInt _AdvancedWeight;

		public int EventID => 0;

		public string Notes => null;

		public int GetID => 0;

		public int Weight => 0;

		public int AdvancedWeight => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Room_eventangelskill Copy()
		{
			return null;
		}
	}
}
