using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class GuildActivity_BossBox_Rewards : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _BossId;

		private ObscuredString _Img;

		private ObscuredInt _Transfer;

		private ObscuredFloat _BodyScale;

		private ObscuredString[] _Reward;

		private ObscuredString[] _Item;

		private ObscuredInt _Score;

		private ObscuredInt[] _Itemstage;

		private ObscuredString[] _ItemDisplay1;

		private ObscuredString[] _ItemDisplay2;

		public int ID => 0;

		public int BossId => 0;

		public string Img => null;

		public int Transfer => 0;

		public float BodyScale => 0f;

		public string[] Reward => null;

		public string[] Item => null;

		public int Score => 0;

		public int[] Itemstage => null;

		public string[] ItemDisplay1 => null;

		public string[] ItemDisplay2 => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public GuildActivity_BossBox_Rewards Copy()
		{
			return null;
		}
	}
}
