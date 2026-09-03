using TableTool;

public class RoomGenerateGold1 : RoomGenerateBase
{
	private WaveData mWave;

	private Stage_Level_activitylevel activitydata;

	protected override void OnInit()
	{
	}

	protected override void OnStartGame()
	{
	}

	protected override void OnStartGameEnd()
	{
	}

	protected override void OnEnterDoorBefore()
	{
	}

	protected override void OnEnterDoorAfter()
	{
	}

	private void StartCurrentRoomWave()
	{
	}

	protected override string OnGetTmxID(int roomid)
	{
		return null;
	}

	public override bool CanOpenDoor()
	{
		return false;
	}

	protected override void OnOpenDoor()
	{
	}

	protected override void OnDeInit()
	{
	}

	public void OnCreateWave()
	{
	}

	private void ClearCurrentRoom()
	{
	}

	protected override void OnEventClose(EventCloseTransfer data)
	{
	}

	protected override void OnReceiveEvent(string eventName, object data)
	{
	}
}
