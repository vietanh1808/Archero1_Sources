using System.Collections.Generic;
using Cooperation.NetData;
using TCPPacket;
using TableTool;
using UnityEngine;

public class TcpNetData
{
	public class RoomData
	{
		public string room_num;

		public string token;
	}

	public struct TcpRoomData
	{
		public int roomId;

		public string tmxId;
	}

	private static TcpNetData _instance;

	public static TcpNetData instance => null;

	public NetProxyBase netProxy { get; private set; }

	public ulong OtherPlayerServerId
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public RoomData roomData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CooperationData cooperationData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public PVPPlayerAttInfo pvpPlayerAttInfo => null;

	public PlayerInfoData infoData => null;

	public bool isEnterTcpRoom => false;

	public void SetProxy(NetProxyBase proxy)
	{
	}

	public void Clear()
	{
	}

	public void Init()
	{
	}

	public void Update()
	{
	}

	public bool IsNeedContinue(EntityBase pOwner, EntityBase pSor)
	{
		return false;
	}

	public void SetInfoData(PlayerInfoData pInfoData)
	{
	}

	public bool IsSyncPlayerData()
	{
		return false;
	}

	public SelfAttributeData GetAttribute()
	{
		return null;
	}

	public int GetClothId()
	{
		return 0;
	}

	public int GetWeapon()
	{
		return 0;
	}

	public int GetWeaponEquipId()
	{
		return 0;
	}

	public int GetWeaponSkinId()
	{
		return 0;
	}

	public int GetWeaponSkinLv()
	{
		return 0;
	}

	public uint GetTotalIapCash()
	{
		return 0u;
	}

	public int GetWeaponIdInPVP1()
	{
		return 0;
	}

	public List<int> GetEquipSkills()
	{
		return null;
	}

	public List<int> GetRefineSkills()
	{
		return null;
	}

	public int GetCharacterId()
	{
		return 0;
	}

	public int GetSkinId()
	{
		return 0;
	}

	public int GetColorId()
	{
		return 0;
	}

	public int GetStar()
	{
		return 0;
	}

	public int GetWingId()
	{
		return 0;
	}

	public LocalSave.WingOne GetMainWing()
	{
		return null;
	}

	public LocalSave.WingOne GetDisplayWing()
	{
		return null;
	}

	public List<LocalSave.WingOne> GetAssisetWings()
	{
		return null;
	}

	public List<ArtifactItemData> GetArtifactItemData()
	{
		return null;
	}

	public List<LocalSave.EquipOne> GetRelics()
	{
		return null;
	}

	public TcpRoomData[] getRoomDataArray()
	{
		return null;
	}

	public long IntegralHitHp(long pHp, int pGuid)
	{
		return 0L;
	}

	public void OnApplicationPause(bool b)
	{
	}

	public void OnConnect()
	{
	}

	public void SetGameState(bool needNet)
	{
	}

	public void OnDisConnect()
	{
	}

	public static GoodData ToGoodDataMessage(Goods_goods.GoodData data)
	{
		return null;
	}

	public static Goods_goods.GoodData ToGoodData(GoodData msg)
	{
		return null;
	}

	public static Vector3Message ToVector3Message(Vector3 v)
	{
		return null;
	}

	public static Vector3 ToVector3(Vector3Message msg)
	{
		return default;
	}

	public static Vector4Message ToQuaternionMessage(Quaternion v)
	{
		return null;
	}

	public static Quaternion ToQuaternion(Vector4Message msg)
	{
		return default;
	}

	public static Vector4Message ToVector4Message(Vector4 v)
	{
		return null;
	}

	public static Vector4 ToVector4(Vector4Message msg)
	{
		return default;
	}

	public void SendCommandMessage(BaseCommand cmd, int guid)
	{
	}

	public void SendRoomData(string tmx, int roomId)
	{
	}

	public void SendGotoNextMessage()
	{
	}

	public void SendRoomLoadComplete()
	{
	}

	public void SendBeginBattle()
	{
	}

	public void SendPublicCommand(BaseCommand cmd)
	{
	}

	public void SendEnterGame(int chapterId)
	{
	}

	public void SDKEventPoint(string step, string result)
	{
	}

	public void SendEvent(object pData)
	{
	}

	public bool IsInPvpEnergyMatch()
	{
		return false;
	}

	public bool IsInPvpEnergyMatchWrapper()
	{
		return false;
	}

	public bool IsInDiamondMatchWrapper()
	{
		return false;
	}
}
