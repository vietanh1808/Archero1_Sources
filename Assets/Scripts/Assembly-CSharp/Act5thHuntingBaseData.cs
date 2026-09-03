public class Act5thHuntingBaseData : RecycleData<Act5thHuntingBaseSourceData>
{
	public bool HaveConfig => false;

	public int Tag => 0;

	public int TotalScore => 0;

	public long StartTime => 0L;

	public long EndTime => 0L;

	public bool IsUnStart => false;

	public bool IsEnd => false;

	public bool IsOpen => false;

	public bool IsHuntingOpen => false;

	public bool IsShoppingOpen => false;

	public bool ReachOpenCond => false;

	public int[] SweepCostGrade => null;

	public long LeftTime => 0L;

	public long HuntingLeftTime => 0L;

	public long ShopLeftTime => 0L;

	public int HuntingTicketID => 0;

	public long HuntingTicketCount => 0L;

	public int HuntingCoinID => 0;

	public long HuntingCoinCount => 0L;

	public int GeneFragmentID => 0;

	public long GeneFragmentCount => 0L;

	public bool HavePlayGuide => false;

	public void UseHuntingTicket(int uesCount)
	{
	}

	public void UseGeneFragment(int uesCount)
	{
	}

	public void UpdateTotalScore(int totalScore)
	{
	}

	public void UpdateHavePlayGuide(bool isPlay)
	{
	}
}
