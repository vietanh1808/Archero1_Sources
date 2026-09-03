public class RoomGenerateDailyTD : RoomGenerateBase
{
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

	protected override string OnGetTmxID(int roomid)
	{
		return null;
	}

	protected override void OnStartGameEnd()
	{
	}

	protected override void OnEnd()
	{
	}

	private void refreshRoomCtrl()
	{
	}

	private void createBase()
	{
	}

	private void createTowers()
	{
	}
}
