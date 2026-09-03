using GameProtocol;

public class GamePlayActivityOne_MazeItem : GamePlayActivityOne_Normal
{
	public GoldTextCtrl titleText;

	public GoldTextCtrl titleTextAlone;

	public ButtonCtrl buttonSeason;

	public DxxText seasonRewardText;

	public MazeCardSelectUI dropList;

	protected override void RefreshData()
	{
	}

	private void OnClickSeasonBtn()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void onMaskShow(bool value)
	{
	}

	protected override CDailyPlay GetPacket(int dailyId, ushort type)
	{
		return null;
	}

	protected override int GetKeyCost()
	{
		return 0;
	}

	protected override void RequestSweep()
	{
	}
}
