using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_TimeBox : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Time;

		private ObscuredInt _DropId;

		public int ID => 0;

		public int Time => 0;

		public int DropId => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_TimeBox Copy()
		{
			return null;
		}
	}
}
