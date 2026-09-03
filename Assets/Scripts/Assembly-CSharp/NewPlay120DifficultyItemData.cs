public class NewPlay120DifficultyItemData
{
	public int DifficultyLevel { get; private set; }

	public int DifficultyQuality { get; private set; }

	public int CondChapterLevel { get; private set; }

	public int CondChapter => 0;

	public int CondDifficultyLevel { get; private set; }

	public int CondBreakChapterLevel { get; private set; }

	public (bool, bool) IsReachSoftCond => default;

	public bool IsReachForceCond => false;

	public bool IsReachLastSeasonCond => false;

	public bool IsReachCond => false;

	public static NewPlay120DifficultyItemData Create(int difficultyLevel, int condChapterLevel, int condDifficultyLevel, int condBreakChapterLevel, int difficultyQuality)
	{
		return null;
	}
}
