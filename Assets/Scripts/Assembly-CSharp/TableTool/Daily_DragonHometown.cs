using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_DragonHometown : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _DragonIcon;

		private ObscuredInt _CoinNum;

		private ObscuredInt _FirstSkillWeight;

		private ObscuredInt _NpcSkillWeight;

		public int ID => 0;

		public int DragonIcon => 0;

		public int CoinNum => 0;

		public int FirstSkillWeight => 0;

		public int NpcSkillWeight => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_DragonHometown Copy()
		{
			return null;
		}
	}
}
