public class RoomGenerateSailingBagBattle : RoomGenerateBase
{
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

	private bool CanOpenDoorInDaily125()
	{
		return false;
	}

	protected override bool OnIsBattleLoad()
	{
		return false;
	}
}
