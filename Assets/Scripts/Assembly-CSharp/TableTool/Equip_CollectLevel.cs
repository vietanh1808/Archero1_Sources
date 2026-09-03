using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip_CollectLevel : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Exp;

		private ObscuredInt _Type;

		private ObscuredString _AttrValue;

		private ObscuredString[] _ItemValue;

		private ObscuredInt _Img;

		public int ID => 0;

		public int Exp => 0;

		public int Type => 0;

		public string AttrValue => null;

		public string[] ItemValue => null;

		public int Img => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip_CollectLevel Copy()
		{
			return null;
		}
	}
}
