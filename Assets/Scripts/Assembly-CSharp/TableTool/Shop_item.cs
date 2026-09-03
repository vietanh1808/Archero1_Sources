using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_item : LocalBean
	{
		private ObscuredInt _ItemID;

		private ObscuredInt _Type;

		private ObscuredInt _Quality;

		private ObscuredInt _EffectType;

		private ObscuredString[] _EffectArgs;

		public int ItemID => 0;

		public int Type => 0;

		public int Quality => 0;

		public int EffectType => 0;

		public string[] EffectArgs => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_item Copy()
		{
			return null;
		}
	}
}
