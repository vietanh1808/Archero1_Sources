public class Act5thHuntingBaseSourceData
{
	public int tag;

	public int totalScore;

	public Act5thHuntingBaseConfigData CurTagHuntingBaseConfigData => null;

	public long StartTime => 0L;

	public long HuntingEndTime => 0L;

	public long ShoppingEndTime => 0L;

	public long EndTime => 0L;

	public int HuntingTicketID => 0;

	public int HuntingCoinID => 0;

	public int GeneFragmentID => 0;

	public int OpenLevel => 0;

	public int[] SweepCost => null;

	public static Act5thHuntingBaseSourceData Create(int tag, int totalScore)
	{
		return null;
	}

	public void UpdateTotalScore(int totalScore)
	{
	}
}
