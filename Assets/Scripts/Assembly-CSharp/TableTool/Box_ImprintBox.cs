using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_ImprintBox : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt[] _Price1;

		private ObscuredInt _Time;

		private ObscuredInt _SingleDrop;

		private ObscuredInt _AssuranceDrop0;

		private ObscuredInt _AssuranceDrop1;

		private ObscuredInt _AssuranceDrop2;

		private ObscuredInt _AssuranceDrop3;

		public int ID => 0;

		public int Type => 0;

		public int[] Price1 => null;

		public int Time => 0;

		public int SingleDrop => 0;

		public int AssuranceDrop0 => 0;

		public int AssuranceDrop1 => 0;

		public int AssuranceDrop2 => 0;

		public int AssuranceDrop3 => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_ImprintBox Copy()
		{
			return null;
		}
	}
}
