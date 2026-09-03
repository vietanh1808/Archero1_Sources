using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_iap_gift_open : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _BeginTime;

		private ObscuredInt _EndTime;

		private ObscuredInt _Version;

		private ObscuredInt _HeroGameLayer;

		private ObscuredInt _GemGameLayer;

		private ObscuredInt[] _HeroConfig;

		private ObscuredInt[] _GemConfig;

		public int ID => 0;

		public int BeginTime => 0;

		public int EndTime => 0;

		public int Version => 0;

		public int HeroGameLayer => 0;

		public int GemGameLayer => 0;

		public int[] HeroConfig => null;

		public int[] GemConfig => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_iap_gift_open Copy()
		{
			return null;
		}
	}
}
