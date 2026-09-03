using System.Collections.Generic;

namespace TableTool
{
	public class Stage_Level_challengeModel : LocalModel<Stage_Level_challenge, int>
	{
		private const string _Filename = "Stage_Level_challenge";

		private Stage_Level_stagechapterModel.EquipExpDropData mEquipExp;

		protected override string Filename => null;

		protected override int GetBeanKey(Stage_Level_challenge bean)
		{
			return 0;
		}

		private void init_equipexp()
		{
		}

		public List<Stage_Level_stagechapterModel.EquipExpRandData> GetScroll(EntityType type)
		{
			return null;
		}

		public int GetCount()
		{
			return 0;
		}
	}
}
