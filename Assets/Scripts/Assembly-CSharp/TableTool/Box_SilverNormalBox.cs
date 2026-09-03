using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_SilverNormalBox : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt[] _Price1;

		private ObscuredInt _Time;

		private ObscuredInt _SingleDrop;

		public int ID => 0;

		public int Type => 0;

		public int[] Price1 => null;

		public int Time => 0;

		public int SingleDrop => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_SilverNormalBox Copy()
		{
			return null;
		}
	}
}
