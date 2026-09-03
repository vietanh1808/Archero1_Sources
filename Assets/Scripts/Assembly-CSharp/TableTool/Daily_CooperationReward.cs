using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_CooperationReward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Gold;

		private ObscuredInt _ItemReward;

		private ObscuredInt _Gem;

		private ObscuredInt _Honour;

		private ObscuredInt _Itemnum;

		private ObscuredInt _Gemnum;

		private ObscuredInt _Honournum;

		public int ID => 0;

		public int Gold => 0;

		public int ItemReward => 0;

		public int Gem => 0;

		public int Honour => 0;

		public int Itemnum => 0;

		public int Gemnum => 0;

		public int Honournum => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_CooperationReward Copy()
		{
			return null;
		}
	}
}
