using System.Collections.Generic;
using Cooperation.NetData;
using TCPPacket;

public class CooperationPVPProxy : NetProxyBase
{
	public class DeltaHPTwisterVO
	{
		public long AtkSum;

		public float DeltaHpTwister;
	}

	public enum ProcessType
	{
		none = 0,
		loading = 1,
		selfReady = 2,
		startBattle = 3,
		LoadComplete = 4
	}

	private bool isSyncPlayerData;

	private bool isRoomOwner;

	private float WaitOtherPlayerTime;

	private bool isBattleStart;

	private ProcessType processType;

	private bool isClear;

	private float selfCoefficient;

	private float otherCoefficient;

	private float selfHitCoefficient;

	private float otherHitCoefficient;

	private float deltaHpTwister;

	private long lastHeartBeatSendTime;

	private long lastHeartBeatRecTime;

	private const float DEFAULT_DELTA_HP_TWISTER = 1f;

	private void RegAllEvent()
	{
	}

	private void trackEvent(int eventId)
	{
	}

	private void MapCreatEndEventCall(object pData)
	{
	}

	private void BattleLoadedEndEventCall(object pData)
	{
	}

	private void CSUserUpdateHpEventCall(object pData)
	{
	}

	private void CSUserDieEventCall(object pData)
	{
	}

	private void CSBattleReadyEventCall(object pData)
	{
	}

	private void C2CEnterDoorEventCall(object pData)
	{
	}

	private void CSEnterDoorRequestEventCall(object pData)
	{
	}

	private void CSEnterMapRequestEventCall(object pData)
	{
	}

	public override void Init()
	{
	}

	public override void Clear()
	{
	}

	public override void SetInfoData(PlayerInfoData pInfoData)
	{
	}

	public override bool IsSyncPlayerData()
	{
		return false;
	}

	public override SelfAttributeData GetAttribute()
	{
		return null;
	}

	public override int GetCharacterId()
	{
		return 0;
	}

	public override int GetClothId()
	{
		return 0;
	}

	public override uint GetTotalIapCash()
	{
		return 0u;
	}

	public override TcpNetData.TcpRoomData[] getRoomDataArray()
	{
		return null;
	}

	public override int GetSkinId()
	{
		return 0;
	}

	public override int GetColorId()
	{
		return 0;
	}

	public override int GetWingId()
	{
		return 0;
	}

	public override LocalSave.WingOne GetMainWing()
	{
		return null;
	}

	public override LocalSave.WingOne GetDisplayWing()
	{
		return null;
	}

	public override List<LocalSave.WingOne> GetAssisetWings()
	{
		return null;
	}

	public override List<ArtifactItemData> GetArtifactItemData()
	{
		return null;
	}

	public override List<LocalSave.EquipOne> GetRelics()
	{
		return null;
	}

	public override int GetWeaponSkinId()
	{
		return 0;
	}

	public override int GetStar()
	{
		return 0;
	}

	public override int GetWeapon()
	{
		return 0;
	}

	public override int GetWeaponEquipId()
	{
		return 0;
	}

	public override List<int> GetEquipSkills()
	{
		return null;
	}

	public override List<int> GetRefineSkills()
	{
		return null;
	}

	public override long IntegralHitHp(long pHp, int pGuid)
	{
		return 0L;
	}

	public override void OnApplicationPause(bool b)
	{
	}

	public override void OnConnect()
	{
	}

	public override void OnDisConnect()
	{
	}

	private void CheckProcessType()
	{
	}

	public override bool IsNeedContinue(EntityBase pOwner, EntityBase pSor)
	{
		return false;
	}

	public override void SDKEventPoint(string step, string result)
	{
	}

	public override float GetCoefficient(bool pIsSelf)
	{
		return 0f;
	}

	public override void Update()
	{
	}

	private void UpdateHeartBeat()
	{
	}

	private SdkManager.MatchPVPData GetMatchPointData(string pStep, string pRessult)
	{
		return null;
	}

	public override void SendHeartBeat()
	{
	}

	public override void SendEnterRoom()
	{
	}

	public override void SendMyPlayerData()
	{
	}

	private void SendMyPlayerAtt()
	{
	}

	private void SendClientReady()
	{
	}

	public override void SendCommandMessage(BaseCommand cmd, int guid)
	{
	}

	private void SendEnterDoorMessage(int pGuid)
	{
	}

	public override void SendGotoNextMessage()
	{
	}

	public override void SendRoomLoadComplete()
	{
	}

	public override void SendBeginBattle()
	{
	}

	public override void SendPublicCommand(BaseCommand cmd)
	{
	}

	public override void SendEnterGame(int chapterId)
	{
	}

	private void SendTcpPacketTransfer(TcpPacketBase pMsg)
	{
	}

	private void SendPacket(TcpPacketBase p)
	{
	}

	private void ShowTransBuffer(TcpPacketBase transPacket, TcpPacketBase protoPacket)
	{
	}

	private void OnPvPEnterRoomResponse(TcpPacketBase p)
	{
	}

	private void OnPvPBattelStartResponse(TcpPacketBase p)
	{
	}

	private void OnPvPUserHeartbeatResponse(TcpPacketBase p)
	{
	}

	private void OnPvPUserDisconnResponse(TcpPacketBase p)
	{
	}

	private void OnPvPBattleOverResponse(TcpPacketBase p)
	{
	}

	private void OnSCAllPlayerEnterDoorResponse(TcpPacketBase p)
	{
	}

	private void OnReceivePlayerData(TcpPacketBase message)
	{
	}

	private float getDeltaHPTwister(List<DeltaHPTwisterVO> list, long atkSum)
	{
		return 0f;
	}

	private List<DeltaHPTwisterVO> createDeltaHPTwisterVOs()
	{
		return null;
	}

	private void CalcCoefficient()
	{
	}

	private void OnRecProofreadingAtt(TcpPacketBase packet)
	{
	}

	private void OnRecC2CEnterDoor(TcpPacketBase packet)
	{
	}

	private void OnClientReady(TcpPacketBase packet)
	{
	}

	private void OnReceiveEnterGame(TcpPacketBase packet)
	{
	}

	private void OnReceiveLoadComplete(TcpPacketBase packet)
	{
	}

	private void OnReceiveBeginBattle(TcpPacketBase packet)
	{
	}

	private void OnReceiveGotoNext(TcpPacketBase packet)
	{
	}

	private void OnReceiveTransferCmdMessage(TcpPacketBase packet)
	{
	}

	private bool OnRecOldMessage(TcpPacketBase packet)
	{
		return false;
	}

	private void OnReceivePublicCmdMessage(TcpPacketBase packet)
	{
	}

	private void OnReceiveCommandMessage(TcpPacketBase packet)
	{
	}

	public void OnOtherPlayerApplicationPause(TcpPacketBase packet)
	{
	}
}
