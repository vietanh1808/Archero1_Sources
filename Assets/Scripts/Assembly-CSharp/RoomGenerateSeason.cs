public class RoomGenerateSeason : RoomGenerateLevel
{
	private const int BIRTH_RADIUS = 2;

	public override void OnBeforeStartGame()
	{
	}

	protected override bool gotonextdoor_canopen()
	{
		return false;
	}

	protected override void OnOpenDoor()
	{
	}

	public override bool CanOpenDoor()
	{
		return false;
	}

	protected override void OnDeInit()
	{
	}

	protected override void UpdateBattleIn()
	{
	}

	protected override string OnGetTmxID(int roomid)
	{
		return null;
	}

	protected override void OnStartGameEnd()
	{
	}

	private void initEmptyGrids()
	{
	}

	protected override void OnEnd()
	{
	}

	private void refreshRoomCtrl()
	{
	}

	private float getBaseCampHPRatio()
	{
		return 0f;
	}

	private void createBase()
	{
	}

	private void createTowers()
	{
	}
}
