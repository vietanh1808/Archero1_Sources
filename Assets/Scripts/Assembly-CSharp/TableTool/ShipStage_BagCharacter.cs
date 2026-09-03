using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipStage_BagCharacter : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredFloat _BodyScale;

		private ObscuredInt _Speed;

		private ObscuredInt _Range;

		private ObscuredInt[] _Skills;

		private ObscuredInt _HP;

		public int ID => 0;

		public float BodyScale => 0f;

		public int Speed => 0;

		public int Range => 0;

		public int[] Skills => null;

		public int HP => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipStage_BagCharacter Copy()
		{
			return null;
		}
	}
}
