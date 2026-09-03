using System.Collections.Generic;
using TCPPacket;
using UnityEngine;

public class RoomGeneratePVP : RoomGenerateBase
{
	public enum CooperationState
	{
		None = 0,
		WaitingRoomData = 1,
		WaitingRoomCompelte = 2,
		WaitingBeginBattle = 3
	}

	public enum RoomNetState
	{
		none = 0,
		waitStart = 1,
		startBattle = 2,
		endBattle = 3
	}

	private bool isWatching;

	private bool isDispose;

	private CooperationState m_State;

	private CooperationState otherState;

	private RoomNetState roomNetState;

	private float serverStartTime;

	private TextMesh firstRoomGuid;

	private bool isStart;

	private List<int> enterDoorHeroList;

	private float tickTime;

	private bool isCounting;

	protected override void OnInit()
	{
	}

	private void trackEvent(int eventId)
	{
	}

	private void BattleLoadedEndEventCall(object pData)
	{
	}

	private void SockectDisconnectEventCall(object pData)
	{
	}

	private void BattleOverEvent(object pData)
	{
	}

	private void BattelStartEvent(object pData)
	{
	}

	private void OtherDisconnEvent(object pData)
	{
	}

	private void OnAllPlayerEnterDoor(object pData)
	{
	}

	private void OnOtherPlayerEnterDoor(object pData)
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

	private void CheckEnterDoorHero()
	{
	}

	private void StartCountDownEnterDoor()
	{
	}

	private void CountDownEnterDoor(float time)
	{
	}

	private void GoToEnterNextRoom()
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

	private void OnCreatReadRoom()
	{
	}

	private void OnRoomLoaded()
	{
	}

	private void OnReadToBattle()
	{
	}

	private void OpenDoorCall(RoomControlBase sender, bool pShow)
	{
	}

	private void ResetPlayerPos()
	{
	}

	private void RestEntityPos(EntityNetHero entity)
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

	private void StartBattle()
	{
	}

	private void IfCanStartBattle()
	{
	}

	public override void OnReceiveTcpPacket(TcpPacketBase packet)
	{
	}

	public void OnDisconnect()
	{
	}

	private void BattleOverByDisconnect()
	{
	}

	private void SDKSendSkillPoint()
	{
	}

	protected override void OnDeinitBefor()
	{
	}

	protected override bool OnIsBattleLoad()
	{
		return false;
	}

	protected override void OnEnd()
	{
	}

	public override void DeInit()
	{
	}

	private void OnSelfGameOver(bool pISelf)
	{
	}

	private void GoToWatching(bool pISelf)
	{
	}

	public override void NetHeroReborn_DeadEnd(bool pISelf)
	{
	}
}
