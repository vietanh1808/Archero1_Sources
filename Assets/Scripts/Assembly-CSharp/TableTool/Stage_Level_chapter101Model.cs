using System.Collections.Generic;

namespace TableTool
{
	public class Stage_Level_chapter101Model : LocalModel<Stage_Level_chapter101, string>
	{
		public class Stage_LevelDataOne
		{
			public string[] Attriutes;

			public string[] MapAttriutes;

			public long StandardDefence;

			public string[] RoomIds;

			public string[] RoomIds1;

			public string[] WaveIDs;

			public string[] WaveIDs1;

			public int[] Several;

			public int[] Nest;

			public string[] GetRoomIds(int count)
			{
				return null;
			}
		}

		public class Stage_LevelData
		{
			private List<Stage_LevelDataOne> mList;

			public int Stage { get; private set; }

			public int Count { get; private set; }

			public Stage_LevelData(int stage, int count)
			{
			}

			public void AddAttributes(string[] value, string[] mapsatt, long defence, string[] roomids, string[] roomids1, string[] waveIDs, string[] waveIDs1, int[] several, int[] Nest)
			{
			}

			public string[] GetAttributes(int level)
			{
				return null;
			}

			public string[] GetMapAttributes(int level)
			{
				return null;
			}

			public long GetDefence(int level)
			{
				return 0L;
			}

			public string[] GetRoomIds(int level, int count)
			{
				return null;
			}

			public string[] GetWaveIDs(int level)
			{
				return null;
			}

			public string[] GetWaveIDs1(int level)
			{
				return null;
			}

			public int[] GetSeveral(int level)
			{
				return null;
			}

			public int[] GetNest(int level)
			{
				return null;
			}
		}

		private class StageLevelDictionary
		{
			private string _sheetPrefix;

			private Dictionary<int, Stage_LevelData> m_dic;

			public Stage_LevelData this[int key] => null;

			public int Count => 0;

			public StageLevelDictionary(string sheetPrefix)
			{
			}

			public bool ContainsKey(int key)
			{
				return false;
			}

			public void Clear()
			{
			}

			private Stage_LevelData InitilizeStageLevelData(int chapterId)
			{
				return null;
			}
		}

		private const string _Filename = "Stage_Level_chapter101";

		private StageLevelDictionary list;

		private StageLevelDictionary m_dicBigMaps;

		private bool bInit;

		private int[] _aryChapterLayer;

		protected override string Filename => null;

		private bool BigMapFlag => false;

		protected override string GetBeanKey(Stage_Level_chapter101 bean)
		{
			return null;
		}

		public Stage_LevelData GetStageLevel(int stage)
		{
			return null;
		}

		public Stage_LevelData GetStageLevelByMode(bool ifNormal, int stage)
		{
			return null;
		}

		public string[] GetStageLevel_Attributes(int stage, int level)
		{
			return null;
		}

		public string[] GetStageLevel_MapAttributes(int stage, int level)
		{
			return null;
		}

		public long GetStageLevel_Defence(int stage, int level)
		{
			return 0L;
		}

		public int GetStageLevel_MaxLevel(int stage)
		{
			return 0;
		}

		public int GetStageLevel_MaxLevel(bool ifNormal, int stage)
		{
			return 0;
		}

		public int GetStageLevel_MaxLevel(GameMode mode, int stage)
		{
			return 0;
		}

		public string[] GetStageLevel_WaveIDs(int stage, int level)
		{
			return null;
		}

		public string[] GetStageLevel_WaveIDs1(int stage, int level)
		{
			return null;
		}

		public int[] GetStageLevel_Several(int stage, int level)
		{
			return null;
		}

		public int[] GetStageLevel_Nest(int stage, int level)
		{
			return null;
		}

		public int GetChapterByLayer(int layer)
		{
			return 0;
		}

		public bool IsMaxLevel(int stage, int level)
		{
			return false;
		}

		public string[] GetStageLevel_RoomIds(int stage, int level, int count)
		{
			return null;
		}

		public int GetMaxStage()
		{
			return 0;
		}

		public void Init()
		{
		}
	}
}
