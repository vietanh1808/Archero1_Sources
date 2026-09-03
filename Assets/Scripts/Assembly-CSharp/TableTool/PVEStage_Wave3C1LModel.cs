using System.Collections.Generic;

namespace TableTool
{
	public class PVEStage_Wave3C1LModel : LocalModel<PVEStage_Wave3C1L, int>
	{
		private const string _Filename = "PVEStage_Wave3C1L";

		public Dictionary<int, Tower_Defense_Wave101Model.LevelWaveData> LevelWaveDict;

		protected override string Filename => null;

		protected override int GetBeanKey(PVEStage_Wave3C1L bean)
		{
			return 0;
		}

		public void Init(int levelId)
		{
		}
	}
}
