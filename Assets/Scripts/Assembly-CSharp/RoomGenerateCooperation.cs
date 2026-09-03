using System.Collections.Generic;
using TCPPacket;

public class RoomGenerateCooperation : RoomGenerateBase
{
	public enum CooperationState
	{
		None = 0,
		WaitingRoomData = 1,
		WaitingRoomCompelte = 2,
		WaitingBeginBattle = 3
	}

	private CooperationState m_State;

	private bool isWatching;

	private bool isOtherPlayerLeave;

	private List<int> enterDoorHeroList;

	private float tickTime;

	private bool isCounting;

	protected override void OnInit()
	{
	}

	public override void StartGame()
	{
	}

	public void EnterWatching()
	{
	}

	protected override void OnStartGame()
	{
	}

	private void GenerateNextRoomData()
	{
	}

	protected override string OnGetTmxID(int roomid)
	{
		return null;
	}

	public override void EnterDoor(EntityBase entity)
	{
	}

	public override void ExitDoor(EntityBase entity)
	{
	}

	private void StartCountDownEnterDoor()
	{
	}

	private void CountDownEnterDoor(float time)
	{
	}

	private void AllPlayerEnterDoor()
	{
	}

	protected override void GotoNextDoor()
	{
	}

	private void CreateMap()
	{
	}

	private void ResetPlayerPos()
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

	protected override void OnOpenDoor()
	{
	}

	protected override void OnDeInit()
	{
	}

	private void ClearCurrentRoom()
	{
	}

	protected override void OnEventClose(EventCloseTransfer data)
	{
	}

	public override void OnReceiveTcpPacket(TcpPacketBase packet)
	{
	}

	public void OnDisconnect()
	{
	}

	private void ExcuteRoomData()
	{
	}

	protected override bool OnIsBattleLoad()
	{
		return false;
	}

	protected override void OnEnd()
	{
	}

	private void OnSelfGameOver(bool pISelf)
	{
	}

	public override void NetHeroReborn_DeadEnd(bool pISelf)
	{
	}

	protected override void OnMonsterDead(EntityBase source, EntityBase entity)
	{
	}

	public override void OnAddSkill(EntityBase entity, int skillid)
	{
	}
}
