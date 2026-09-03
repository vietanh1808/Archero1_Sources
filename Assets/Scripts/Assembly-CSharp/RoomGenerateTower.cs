public class RoomGenerateTower : RoomGenerateBase
{
	protected override void OnStartGame()
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

	protected override void OnStartGameEnd()
	{
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

	private void refreshRoomCtrl()
	{
	}

	protected override void UpdateBattleIn()
	{
	}
}
