using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class DragonMagic_MagicConfig : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _Attribute;

		private ObscuredString[] _AttributeDisplay;

		private ObscuredFloat[] _AttributeInit;

		private ObscuredFloat[] _AttributeUpgrade;

		private ObscuredFloat[] _AttributeUpgradeReal;

		private ObscuredInt[] _NeedLevel;

		private ObscuredInt _Type;

		private ObscuredInt _Args;

		private ObscuredInt _Cost;

		public int ID => 0;

		public string[] Attribute => null;

		public string[] AttributeDisplay => null;

		public float[] AttributeInit => null;

		public float[] AttributeUpgrade => null;

		public float[] AttributeUpgradeReal => null;

		public int[] NeedLevel => null;

		public int Type => 0;

		public int Args => 0;

		public int Cost => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public DragonMagic_MagicConfig Copy()
		{
			return null;
		}
	}
}
