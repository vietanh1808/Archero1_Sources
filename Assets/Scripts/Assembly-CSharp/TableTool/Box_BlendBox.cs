using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_BlendBox : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt[] _Price1;

		private ObscuredInt _Time;

		private ObscuredInt _SingleDrop;

		private ObscuredInt _JewelryDrop;

		private ObscuredInt _MostDrop;

		private ObscuredInt _NewSingleDrop;

		private ObscuredInt _NewJewelryDrop;

		private ObscuredInt _NewMostDrop;

		private ObscuredInt _Version;

		public int ID => 0;

		public int Type => 0;

		public int[] Price1 => null;

		public int Time => 0;

		public int SingleDrop => 0;

		public int JewelryDrop => 0;

		public int MostDrop => 0;

		public int NewSingleDrop => 0;

		public int NewJewelryDrop => 0;

		public int NewMostDrop => 0;

		public int Version => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_BlendBox Copy()
		{
			return null;
		}
	}
}
