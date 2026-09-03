using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_iap_gift_hero : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _IapId;

		private ObscuredString[] _Rewards;

		private ObscuredString[] _HeroFragment;

		public int ID => 0;

		public string IapId => null;

		public string[] Rewards => null;

		public string[] HeroFragment => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_iap_gift_hero Copy()
		{
			return null;
		}
	}
}
