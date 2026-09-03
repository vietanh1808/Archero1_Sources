using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using UnityEngine;

public class SailingShipManager : SingletonNet<SailingShipManager, STReqShipBattleSeasonShipInfo, STRespShipBattleSeasonShipInfo>
{
	public bool IsSyncData;

	private int shipBodyPartID;

	private int shipBodyLevel;

	private int shipBodySkinID;

	private int shipSlotID;

	public const int SailingShipFireSoundID = 6001025;

	public const int SailingShipMissSoundID = 6001026;

	public const int LuckyDriftBottleID = 34108;

	public int Tag;

	protected override string Name => null;

	public SailingShipPartData ShipPartData { get; private set; }

	public SailingShipCrewRoomData ShipCrewRoomData { get; private set; }

	public SailingShipPartSkinData ShipSkinMap { get; private set; }

	private SailingShipGameData ShipGameData { get; set; }

	public int ShipBodySkinID => 0;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override STReqShipBattleSeasonShipInfo RequestPacket()
	{
		return null;
	}

	public override SendRequestTime RequestTime()
	{
		return SendRequestTime.None;
	}

	protected override bool AllowBurstRequest()
	{
		return false;
	}

	protected override bool RequestCond()
	{
		return false;
	}

	protected override void Response(NetResponse response, STRespShipBattleSeasonShipInfo data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	public void RequestShipUpGrade(int partId, Action<bool, bool> callback)
	{
	}

	public void RequestCrewRoomGo(int crewID, int roomID, int type, Action<bool> callback)
	{
	}

	public void RequestShipSkin(Action<bool> callback)
	{
	}

	public void RequestPartChange(int partID, int skinID, Action<bool> callback)
	{
	}

	public string GetPartsInfo()
	{
		return null;
	}

	public string GetAllPartsSkinIds()
	{
		return null;
	}

	public string GetSailorInfo()
	{
		return null;
	}

	public void StartGame(SailingShipBattleRequestType requestType, ulong selfNumber, ulong enemyNumber, uint randomSeed, Action success = null, Action failure = null)
	{
	}

	public void RequestGameStart(SailingShipBattleRequestType requestType, ulong selfNumber, ulong enemyNumber, uint randomSeed, Action<STRespShipBattleSeasonFight> success = null, Action<STRespShipBattleSeasonFight> failure = null)
	{
	}

	public void SetData(STRespShipBattleSeasonShipInfo data)
	{
	}

	public void SetSkinData(STRespShipBattleSeasonShipInfo data)
	{
	}

	public void SyncGameData(STRespShipBattleSeasonFight response, SailingShipBattleRequestType requestType)
	{
	}

	public void AddSkinData(int skinID)
	{
	}

	public SailingShipPartData GetPartPosData(STShipBattleShipInfoProtoData data)
	{
		return null;
	}

	public SailingShipCrewRoomData GetCrewRoomData(STRespShipRoomData[] roomData)
	{
		return null;
	}

	public List<int> GetAllCrewID()
	{
		return null;
	}

	public (Sprite, Vector2, Vector2) GetShipPartIconAndPosInfo(int shipLv, int shipSkinID, int partID, int partLevel, int partSkinID, SailingShipPartPosType type)
	{
		return default;
	}

	public (Sprite, Vector2, Vector2) GetMonsterShipIconAndPosInfo(int shipConfigID, int partConfigID, int partID, SailingShipPartPosType type)
	{
		return default;
	}

	public SailingShipPartData GetMonsterShipByBagDifficultID(int dID)
	{
		return null;
	}

	public SailingShipPartData GetMonsterShipByGhostDifficultID(int dID)
	{
		return null;
	}

	public SailingShipPartData GetShipSkinPreviewData(int skinID, bool isGetAllSkin, bool isEndStage)
	{
		return null;
	}

	private SailingShipPartData GetShowSkinData(bool isEndStage)
	{
		return null;
	}

	public Sprite GetPartIcon(SailingShipPartPosType posType, string iconName)
	{
		return null;
	}

	public int GetShipBodyLevel()
	{
		return 0;
	}

	public int GetShipBodyID()
	{
		return 0;
	}

	public SailingShipPartItemData GetShipPartDataByPartID(int partID)
	{
		return null;
	}

	public List<SailingShipCrewRoomItemData> GetShipCrewRoomsData()
	{
		return null;
	}

	public SailingShipCrewRoomItemData GetShipCrewRoomDataByID(int roomID)
	{
		return null;
	}

	public bool IsCrewHadInOtherRoom(int crewID, int roomID)
	{
		return false;
	}

	public int GetCrtShipPower()
	{
		return 0;
	}

	public List<SailingShipPartSkinItemData> GetSkinPartDataByPartID(int partID)
	{
		return null;
	}

	public List<SailingShipPartSkinItemData> GetLockSkinPartDataByPartID(int partID)
	{
		return null;
	}

	public SailingShipPartSkinItemData GetSkinPartDataByPartAndSkinID(int partID, int skinID)
	{
		return null;
	}

	public bool IsHaveSkin(int skinID)
	{
		return false;
	}

	public Dictionary<string, float> GetShipAllAtt()
	{
		return null;
	}

	public SailingShipGameData GetShipGameData()
	{
		return null;
	}

	public bool IsInShipBattle()
	{
		return false;
	}

	public bool IsHaveRed()
	{
		return false;
	}

	public bool IsHaveCrewToGo()
	{
		return false;
	}

	public bool IsShipCanUpgrade()
	{
		return false;
	}

	public Dictionary<GameObject, Vector2> GetShipEffectBySkinID(int skinID, int partID, int partLevel)
	{
		return null;
	}

	public Dictionary<GameObject, Vector2> GetMonsterEffect(int partConfigID)
	{
		return null;
	}

	public SailingShipBossAttackStyle GetSailingShipBossAttackStyle(SailingShipEntityPartData partData)
	{
		return SailingShipBossAttackStyle.None;
	}
}
