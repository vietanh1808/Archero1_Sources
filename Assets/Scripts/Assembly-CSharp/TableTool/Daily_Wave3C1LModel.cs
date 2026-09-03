using System.Collections.Generic;

namespace TableTool
{
	public class Daily_Wave3C1LModel : LocalModel<Daily_Wave3C1L, int>
	{
		private const string _Filename = "Daily_Wave3C1L";

		public Dictionary<int, Tower_Defense_Wave101Model.LevelWaveData> LevelWaveDict;

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_Wave3C1L bean)
		{
			return 0;
		}

		public void Init(int levelId)
		{
		}
	}
}
