using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Room_eventdemontext2lose : LocalBean
	{
		private ObscuredInt _EventID;

		private ObscuredString _Notes;

		private ObscuredString _Content1;

		private ObscuredString _Content2;

		private ObscuredString _Image1;

		private ObscuredInt _LoseID;

		public int EventID => 0;

		public string Notes => null;

		public string Content1 => null;

		public string Content2 => null;

		public string Image1 => null;

		public int LoseID => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Room_eventdemontext2lose Copy()
		{
			return null;
		}
	}
}
