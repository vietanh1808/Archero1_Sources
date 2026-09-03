using Dxx.Util;

public class BattleTowerUICtrl : BattleLevelUICtrl
{
	public DxxText mCdText;

	private int m_nStrenthInterval;

	private float m_fTotalTime;

	private int m_nTimes;

	private SequencePool mSeqPool;

	private BattleModuleData.CD_TIME_TYPE m_emType;

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	protected override void UpdateGold()
	{
	}

	private new void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private new void OnUpdate(float delta)
	{
	}

	protected override int GetRoomId()
	{
		return 0;
	}
}
