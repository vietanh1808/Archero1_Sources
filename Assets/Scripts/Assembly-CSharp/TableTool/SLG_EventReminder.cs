using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_EventReminder : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		private ObscuredString _Names;

		private ObscuredString[] _JumpBuilding;

		public int Id => 0;

		public int StartTime => 0;

		public int EndTime => 0;

		public string Names => null;

		public string[] JumpBuilding => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_EventReminder Copy()
		{
			return null;
		}
	}
}
