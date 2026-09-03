public class RoomGenerateCampBattle : RoomGenerateBase
{
	protected override void OnEnd()
	{
	}

	protected override void UpdateBattleIn()
	{
	}

	protected override void OnStartGameEnd()
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

	protected override void OnOpenDoor()
	{
	}
}
