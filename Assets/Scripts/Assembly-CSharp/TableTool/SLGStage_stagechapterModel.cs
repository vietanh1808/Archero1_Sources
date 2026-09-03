using System.Collections.Generic;
using CampBattle;

namespace TableTool
{
	public class SLGStage_stagechapterModel : LocalModel<SLGStage_stagechapter, int>
	{
		private const string _Filename = "SLGStage_stagechapter";

		public Dictionary<int, RoundMeta> RoundMetaDict;

		protected override string Filename => null;

		protected override int GetBeanKey(SLGStage_stagechapter bean)
		{
			return 0;
		}

		public void Init(int levelId)
		{
		}
	}
}
