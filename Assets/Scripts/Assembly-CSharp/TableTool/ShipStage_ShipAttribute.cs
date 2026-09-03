using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipStage_ShipAttribute : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _Attributes;

		private ObscuredInt _Weight;

		private ObscuredInt[] _Color;

		public int ID => 0;

		public string[] Attributes => null;

		public int Weight => 0;

		public int[] Color => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipStage_ShipAttribute Copy()
		{
			return null;
		}
	}
}
