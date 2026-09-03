using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Config_ActivityDeleteItem : LocalBean
	{
		private ObscuredInt _ActivityType;

		private ObscuredInt[] _DeleteItem;

		public int ActivityType => 0;

		public int[] DeleteItem => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Config_ActivityDeleteItem Copy()
		{
			return null;
		}
	}
}
