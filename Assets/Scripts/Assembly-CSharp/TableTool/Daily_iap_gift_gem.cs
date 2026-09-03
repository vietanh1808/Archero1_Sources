using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_iap_gift_gem : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _IapId;

		private ObscuredString[] _Rewards;

		public int ID => 0;

		public string IapId => null;

		public string[] Rewards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_iap_gift_gem Copy()
		{
			return null;
		}
	}
}
