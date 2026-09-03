using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Farm_BattleAIName : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _HeadIcon;

		private ObscuredInt _HeadFrame;

		public int Id => 0;

		public int HeadIcon => 0;

		public int HeadFrame => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Farm_BattleAIName Copy()
		{
			return null;
		}
	}
}
