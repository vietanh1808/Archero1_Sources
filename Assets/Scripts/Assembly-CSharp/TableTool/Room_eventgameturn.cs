using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Room_eventgameturn : LocalBean
	{
		private ObscuredInt _EventID;

		private ObscuredString _Notes;

		private ObscuredInt _GetID;

		private ObscuredInt _Weight;

		public int EventID => 0;

		public string Notes => null;

		public int GetID => 0;

		public int Weight => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Room_eventgameturn Copy()
		{
			return null;
		}
	}
}
