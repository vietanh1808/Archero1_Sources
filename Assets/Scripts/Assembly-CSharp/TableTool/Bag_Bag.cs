using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Bag_Bag : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Type;

		private ObscuredInt[] _PropType;

		public int ID => 0;

		public string Type => null;

		public int[] PropType => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Bag_Bag Copy()
		{
			return null;
		}
	}
}
