using TableTool;

namespace DailyActivity
{
	public sealed class DailyScoreData
	{
		public int ID { get; private set; }

		public int DailyType { get; private set; }

		public int InitValue { get; private set; }

		public int StandardMin { get; private set; }

		public int StandardMax { get; private set; }

		public int ScoreDrop { get; private set; }

		public int ScoreRise { get; private set; }

		public int InitScore { get; private set; }

		public int ScoreDropLimit { get; private set; }

		public int ScoreRiseLimit { get; private set; }

		public int ScoreNeed { get; private set; }

		public int BufferScore { get; private set; }

		public bool isFirst { get; private set; }

		public bool isLast { get; private set; }

		public int StageLevelLimit { get; private set; }

		public int ScoreToUp { get; private set; }

		public int ScoreToDown { get; private set; }

		public DailyScoreData(Daily_DailyChapter dailyChapter, Daily_DailyChapter lastChapter, Daily_DailyChapter nextChapter)
		{
		}

		public bool CanUp(int score)
		{
			return false;
		}

		public bool CanDown(int score)
		{
			return false;
		}
	}
}
