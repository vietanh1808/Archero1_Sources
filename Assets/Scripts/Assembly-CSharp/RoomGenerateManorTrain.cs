public class RoomGenerateManorTrain : RoomGenerateBase
{
	protected override void OnInit()
	{
	}

	protected override void OnStartGame()
	{
	}

	protected override void OnStartGameEnd()
	{
	}

	protected override void OnEnd()
	{
	}

	public override bool CanOpenDoor()
	{
		return false;
	}

	protected override string OnGetTmxID(int roomid)
	{
		return null;
	}

	protected override bool gotonextdoor_canopen()
	{
		return false;
	}
}
