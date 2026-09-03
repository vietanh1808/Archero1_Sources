public class RoomGenerateEventTower : RoomGenerateBase
{
	protected override void OnStartGame()
	{
	}

	protected override void OnStartGameEnd()
	{
	}

	private void refreshRoomCtrl()
	{
	}

	protected override string OnGetTmxID(int roomid)
	{
		return null;
	}

	protected override bool gotonextdoor_canopen()
	{
		return false;
	}

	public override bool CanOpenDoor()
	{
		return false;
	}

	protected override void OnDeInit()
	{
	}

	public override bool IsLastRoom()
	{
		return false;
	}

	protected override void OnEnterDoorAfter()
	{
	}
}
