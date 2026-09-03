using System.Collections.Generic;
using Cooperation;
using TCPPacket;

public class CooperationNetProxy : NetProxyBase
{
	private bool isSyncPlayerData;

	private List<LocalSave.CardOne> mCardList;

	private int characterId;

	private int skinId;

	private int colorId;

	private int weaponSkinId;

	private int weaponSkinLv;

	private uint totalIapCash;

	private List<LocalSave.EquipOne> wearEquip;

	private List<TcpNetData.TcpRoomData> roomList;

	private bool isNeedNet;

	private bool isRoomOwner;

	private float WaitOtherPlayerTime;

	private Dictionary<int, Queue<BaseCommand>> m_dicCommands;

	private bool isClear;

	private float upadteDataTimer;

	private long lastHeartBeatSendTime;

	private byte[] heartBeatByteArray;

	public CooperationScoreObject selfScoreObject { get; private set; }

	public CooperationScoreObject otherScoreObject { get; private set; }

	private void RegAllEvent()
	{
	}

	private void OnAddScoreObject(object obj)
	{
	}

	public override void Init()
	{
	}

	public override void Clear()
	{
	}

	public override bool IsNeedContinue(EntityBase pOwner, EntityBase pSor)
	{
		return false;
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

	public override int GetWeaponSkinLv()
	{
		return 0;
	}

	public override uint GetTotalIapCash()
	{
		return 0u;
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

	public override void OnApplicationPause(bool b)
	{
	}

	public override void OnConnect()
	{
	}

	public override void OnDisConnect()
	{
	}

	public override void SetGameState(bool needNet)
	{
	}

	public override void SDKEventPoint(string step, string result)
	{
	}

	public override void Update()
	{
	}

	private void UpdateData()
	{
	}

	public override void SendHeartBeat()
	{
	}

	private void SendMyScore(CooperationScoreObject scoreObject)
	{
	}

	public override void SendMyPlayerData()
	{
	}

	public override void SendEnterRoom()
	{
	}

	public override void SendCommandMessage(BaseCommand cmd, int guid)
	{
	}

	public override void SendRoomData(string tmx, int roomId)
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

	private void OnAllPlayerInRec(TcpPacketBase message)
	{
	}

	private void OnHeatbeatRec(TcpPacketBase message)
	{
	}

	private void OnReciveUpdateScore(TcpPacketBase message)
	{
	}

	private void OnReceivePlayerData(TcpPacketBase message)
	{
	}

	private void OnClientReady(TcpPacketBase packet)
	{
	}

	private void OnReceiveEnterRoom(TcpPacketBase packet)
	{
	}

	private void OnMatchRoomEnter(SC_EnterRoom msg)
	{
	}

	private void OnCreatRoomEnter(SC_EnterRoom msg)
	{
	}

	private void OnReceiveEnterGame(TcpPacketBase packet)
	{
	}

	private void OnReceiveRoomData(TcpPacketBase packet)
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

	private void OnReceivePublicCmdMessage(TcpPacketBase packet)
	{
	}

	private void OnReceiveCommandMessage(TcpPacketBase packet)
	{
	}

	public override void PushCachedCommands()
	{
	}

	public void OnOtherPlayerDiscount(TcpPacketBase packet)
	{
	}

	public void OnOtherPlayerApplicationPause(TcpPacketBase packet)
	{
	}

	private void CountDownOtherPlayer(float time)
	{
	}
}
