using TableTool;

public class RoomGenerateChest1 : RoomGenerateBase
{
	public const string Event_TurnTable_Monster = "Event_TurnTable_Monster";

	public const string Event_TurnTable_Boss = "Event_TurnTable_Boss";

	public const string GetEvent_TurnTable_DropID = "GetEvent_TurnTable_DropID";

	private WaveData mWave;

	private Stage_Level_activitylevel activitydata;

	protected override void OnInit()
	{
	}

	protected override void OnStartGame()
	{
	}

	protected override void OnEnterDoorBefore()
	{
	}

	protected override void OnEnterDoorAfter()
	{
	}

	private void UpdateActivityData()
	{
	}

	private void StartWave()
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

	protected override void OnEventClose(EventCloseTransfer data)
	{
	}

	protected override void OnDeInit()
	{
	}

	private new bool IsBossRoom(int roomid)
	{
		return false;
	}

	public override bool IsLastRoom()
	{
		return false;
	}

	protected override void OnMonsterDead(EntityBase entity)
	{
	}

	private new void ShowBossDeadEvent()
	{
	}

	private void ShowEvent()
	{
	}

	protected override void OnPlayerHitted(long changehp)
	{
	}

	public override void PlayerDead()
	{
	}

	protected override void OnReceiveEvent(string eventName, object data)
	{
	}

	public void OnCreateWave()
	{
	}

	protected override object OnGetEvent(string eventName, object data = null)
	{
		return null;
	}
}
