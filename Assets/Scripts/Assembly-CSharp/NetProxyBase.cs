using System;
using System.Collections.Generic;
using Cooperation.NetData;

public abstract class NetProxyBase
{
	public TcpNetData.RoomData roomData;

	public CooperationData cooperationData;

	public int integralFactor;

	protected Dictionary<Type, Action<object>> objectEventMap;

	public virtual ulong OtherPlayerServerId { get; set; }

	public PVPPlayerAttInfo pvpPlayerAttInfo { get; protected set; }

	public PlayerInfoData infoData { get; protected set; }

	public List<string> tmxList { get; protected set; }

	public int matchTypeLevel => 0;

	public bool isEnterTcpRoom { get; protected set; }

	public virtual void Clear()
	{
	}

	public virtual void Init()
	{
	}

	public virtual bool IsSyncPlayerData()
	{
		return false;
	}

	public virtual SelfAttributeData GetAttribute()
	{
		return null;
	}

	public virtual int GetClothId()
	{
		return 0;
	}

	public virtual int GetWeapon()
	{
		return 0;
	}

	public virtual int GetWeaponEquipId()
	{
		return 0;
	}

	public virtual List<int> GetEquipSkills()
	{
		return null;
	}

	public virtual List<int> GetRefineSkills()
	{
		return null;
	}

	public virtual int GetCharacterId()
	{
		return 0;
	}

	public virtual int GetSkinId()
	{
		return 0;
	}

	public virtual int GetColorId()
	{
		return 0;
	}

	public virtual int GetWingId()
	{
		return 0;
	}

	public virtual int GetWeaponSkinId()
	{
		return 0;
	}

	public virtual int GetWeaponSkinLv()
	{
		return 0;
	}

	public virtual uint GetTotalIapCash()
	{
		return 0u;
	}

	public virtual List<LocalSave.EquipOne> GetRelics()
	{
		return null;
	}

	public virtual LocalSave.WingOne GetMainWing()
	{
		return null;
	}

	public virtual List<LocalSave.WingOne> GetAssisetWings()
	{
		return null;
	}

	public virtual List<ArtifactItemData> GetArtifactItemData()
	{
		return null;
	}

	public virtual LocalSave.WingOne GetDisplayWing()
	{
		return null;
	}

	public virtual int GetStar()
	{
		return 0;
	}

	public virtual TcpNetData.TcpRoomData[] getRoomDataArray()
	{
		return null;
	}

	public virtual long IntegralHitHp(long pHp, int pGuid)
	{
		return 0L;
	}

	public virtual void OnApplicationPause(bool b)
	{
	}

	public virtual void OnConnect()
	{
	}

	public virtual void OnDisConnect()
	{
	}

	public virtual void SetGameState(bool needNet)
	{
	}

	public virtual float GetCoefficient(bool pIsSelf)
	{
		return 0f;
	}

	public virtual void SetInfoData(PlayerInfoData pInfoData)
	{
	}

	public virtual bool IsNeedContinue(EntityBase pOwner, EntityBase pSor)
	{
		return false;
	}

	public virtual void SDKEventPoint(string step, string result)
	{
	}

	public virtual void PushCachedCommands()
	{
	}

	public virtual void SendCommandMessage(BaseCommand cmd, int guid)
	{
	}

	public virtual void SendRoomData(string tmx, int roomId)
	{
	}

	public virtual void SendGotoNextMessage()
	{
	}

	public virtual void SendRoomLoadComplete()
	{
	}

	public virtual void SendBeginBattle()
	{
	}

	public virtual void SendPublicCommand(BaseCommand cmd)
	{
	}

	public virtual void SendEnterGame(int chapterId)
	{
	}

	public virtual void SendEnterRoom()
	{
	}

	public virtual void SendMyPlayerData()
	{
	}

	public virtual void SendHeartBeat()
	{
	}

	public virtual void Update()
	{
	}

	public void SendEvent(object pData)
	{
	}

	protected void RegEvent(Type pKey, Action<object> pDelgate)
	{
	}
}
