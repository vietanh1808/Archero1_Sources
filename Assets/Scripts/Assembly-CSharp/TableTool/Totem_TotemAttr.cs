using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Totem_TotemAttr : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Rare;

		private ObscuredInt[] _SkillID;

		private ObscuredString _AttrType;

		private ObscuredString[] _AttrValue;

		private ObscuredFloat[] _AttrGrow;

		private ObscuredInt _AttrMaxNum;

		public int ID => 0;

		public int Rare => 0;

		public int[] SkillID => null;

		public string AttrType => null;

		public string[] AttrValue => null;

		public float[] AttrGrow => null;

		public int AttrMaxNum => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Totem_TotemAttr Copy()
		{
			return null;
		}
	}
}
