using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_SilverBox : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt[] _Price1;

		private ObscuredInt _Price10;

		private ObscuredInt _Time;

		private ObscuredInt _SingleDrop;

		private ObscuredInt _GiftDrop;

		private ObscuredInt _PurpleDrop;

		public int ID => 0;

		public int Type => 0;

		public int[] Price1 => null;

		public int Price10 => 0;

		public int Time => 0;

		public int SingleDrop => 0;

		public int GiftDrop => 0;

		public int PurpleDrop => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_SilverBox Copy()
		{
			return null;
		}
	}
}
