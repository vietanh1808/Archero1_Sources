using System.Collections.Generic;

namespace TableTool
{
	public class Tower_Defense_Wave101Model : LocalModel<Tower_Defense_Wave101, int>
	{
		public class WaveOne
		{
			public int WaveId;

			public int Time;

			public int[] Path;

			public string[] GroupID;

			public string[] Attributes;

			public string[] MapAttributes;

			public float HardTimeRatio;

			public int[] Path1;

			public int[] Path2;

			public int[] Path3;

			public int[] Num;

			public int BossPathNum;

			public string[] BossGroupIds;

			public WaveOne(int waveId)
			{
			}
		}

		public class LevelWaveData
		{
			public List<WaveOne> WaveOneList;

			public int LevelId { get; private set; }

			public LevelWaveData(int level)
			{
			}

			public void AddWaveOne(WaveOne waveOne)
			{
			}
		}

		private const string _Filename = "Tower_Defense_Wave101";

		public Dictionary<int, LevelWaveData> LevelWaveDict;

		protected override string Filename => null;

		protected override int GetBeanKey(Tower_Defense_Wave101 bean)
		{
			return 0;
		}

		public void Init()
		{
		}
	}
}
