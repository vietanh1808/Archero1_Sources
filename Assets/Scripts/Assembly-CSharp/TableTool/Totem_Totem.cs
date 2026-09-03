using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Totem_Totem : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Name;

		private ObscuredString _TotemIcon;

		private ObscuredInt _Rare;

		private ObscuredInt[] _SlotSubType;

		private ObscuredInt _MaxLevel;

		private ObscuredInt[] _SubAttrLevel;

		private ObscuredString[] _MainAttr;

		private ObscuredString[] _SubAttr;

		private ObscuredString[] _SpecialRefineSubAttr;

		private ObscuredInt _CanRefined;

		private ObscuredInt _RefineMaxLevel;

		private ObscuredInt _RefineMaxLock;

		public int Id => 0;

		public string Name => null;

		public string TotemIcon => null;

		public int Rare => 0;

		public int[] SlotSubType => null;

		public int MaxLevel => 0;

		public int[] SubAttrLevel => null;

		public string[] MainAttr => null;

		public string[] SubAttr => null;

		public string[] SpecialRefineSubAttr => null;

		public int CanRefined => 0;

		public int RefineMaxLevel => 0;

		public int RefineMaxLock => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Totem_Totem Copy()
		{
			return null;
		}
	}
}
