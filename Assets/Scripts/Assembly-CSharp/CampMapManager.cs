using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;
using UnityEngine;
using UnityEngine.Tilemaps;
using XLua;

public sealed class CampMapManager : CInstance<CampMapManager>
{
	public GameObject campMapObj;

	public CampMap campMap;

	private bool dataLoading;

	public TileInsPop tileIns;

	public List<uint> attackedTiles;

	public int MapWidth;

	public int MapHeight;

	private const int TotalW = 200;

	private const int TotalH = 200;

	private const int UnitW = 100;

	private const int UnitH = 100;

	private const int RoadDirection = 1070;

	private const int RoadDirectionUp = 1071;

	private const int RoadDirectionDown = 1072;

	private const int RoadDirectionLeft = 1073;

	private const int RoadDirectionRight = 1074;

	private const int CampLandRoad = 1080;

	private const int LandCanSweep = 1087;

	private const int LandTouchID = 1060;

	private const int LandTouchIDBig = 3060;

	private const int LandCanTouch = 1088;

	private const int LandNotTouch = 1089;

	private const int FogID = 1099;

	private const int CampLandRoadLink = 3080;

	private const int CampLandRoadLBLink = 3081;

	private const int CampLandRoadRBLink = 3082;

	private const int CampLandRoadLTLink = 3083;

	private const int CampLandRoadRTLink = 3084;

	private const int LandCanTouchLink = 3088;

	private const int LandNotTouchLink = 3089;

	private const int CityDoorLeft = 2431;

	private const int CityDoorRight = 2441;

	private const int HolyLTileID = 4460;

	private const int HolyRTileID = 4470;

	private const int HolyBTileID = 4480;

	private const int HolyTTileID = 4490;

	public const int HolyLTileX = 37;

	public const int HolyLTileY = 100;

	public const int HolyRTileX = 163;

	public const int HolyRTileY = 100;

	public const int HolyBTileX = 100;

	public const int HolyBTileY = 29;

	public const int HolyTTileX = 100;

	public const int HolyTTileY = 171;

	private const int BossTileID = 6401;

	private const int BossTileIDPic1 = 6401;

	private const int BossTileIDPic2 = 6402;

	private const int BossTileX = 100;

	private const int BossTileY = 100;

	private const int TownDefaultTileID = 1800;

	private const int TownLBTileID = 1801;

	private const int TownRBTileID = 1802;

	private const int TownLTTileID = 1803;

	private const int TownRTTileID = 1804;

	private const int TownLBTileID_Big = 3801;

	private const int TownRBTileID_Big = 3802;

	private const int TownLTTileID_Big = 3803;

	private const int TownRTTileID_Big = 3804;

	private const int FocusTileID = 1080;

	public int selectCameraIndex;

	public int currentCameraIndex;

	public float currentCameraSize;

	public float currentDragRatio;

	public float[] DragRatio;

	public float[] CameraSize;

	private const int CacheTileTime = 300;

	private Dictionary<LayerName, int[,]> tileIDExDict;

	private int[,] cloudData;

	public Dictionary<int, CampTileData> campTileDataDict;

	private Dictionary<int, bool> campRewardBoxOnceDict;

	public Dictionary<int, ulong> campMarkDict;

	public int MyTownPos;

	private Dictionary<int, int> miniMapStateDict;

	public long miniMapLastTime;

	private int maxAttackTileLevel;

	private Dictionary<int, TileLoadState> tileLoadStateDict;

	private int BlockUnitW;

	private int BlockUnitH;

	private int BlockCountW;

	private int BlockCountH;

	private int TownBasicX;

	private int TownBasicY;

	public long TownMoveLastTime;

	public int TownBattleMaxLevel;

	private Dictionary<int, int> tileRoadForceDict;

	private Vector2Int clickTileXY;

	public const int FogPicId = 409900;

	private int[,] FogClickState;

	private int[,] FogValue;

	public Vector2Int FogTargetXY;

	public List<int> campBoxTileList;

	public List<int> campBoxGetList;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_get_DataHaveLoaded;

	private static DelegateBridge __Hotfix0_set_DataHaveLoaded;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_uninit;

	private static DelegateBridge __Hotfix0_initForMapEditor;

	private static DelegateBridge __Hotfix0_initCameraData;

	private static DelegateBridge __Hotfix0_LoadData;

	private static DelegateBridge __Hotfix0_initTileData;

	private static DelegateBridge __Hotfix0_enterPre;

	private static DelegateBridge __Hotfix0_enter;

	private static DelegateBridge __Hotfix0_createCampMap;

	private static DelegateBridge __Hotfix0_exit;

	private static DelegateBridge __Hotfix0_requestTileState_Enter;

	private static DelegateBridge __Hotfix0_get_CameraSizeLen;

	private static DelegateBridge __Hotfix0_LoadTileIDEx;

	private static DelegateBridge __Hotfix0_ParseTileText;

	private static DelegateBridge __Hotfix0_GetTileIDExXY;

	private static DelegateBridge __Hotfix0_checkTileIDEx;

	private static DelegateBridge __Hotfix0_checkHolyTileIDEx;

	private static DelegateBridge __Hotfix0_checkBossTileIDEx;

	private static DelegateBridge __Hotfix0_checkTownTileIDEx;

	private static DelegateBridge __Hotfix0_checkTileIsTown;

	private static DelegateBridge __Hotfix0_isInitTownPosition;

	private static DelegateBridge __Hotfix0_GetTileIDXY;

	private static DelegateBridge __Hotfix0_GetTilePicXY;

	private static DelegateBridge __Hotfix0_IsCanSweep;

	private static DelegateBridge __Hotfix0_CheckAroundIsHaveAttackedTile;

	private static DelegateBridge __Hotfix0_SetAttackedTileData;

	private static DelegateBridge __Hotfix0_GetRoadPicFrame;

	private static DelegateBridge __Hotfix0_checkInBounds;

	private static DelegateBridge __Hotfix0_CreateTile;

	private static DelegateBridge __Hotfix1_GetTileIDExXY;

	private static DelegateBridge __Hotfix1_GetTileIDXY;

	private static DelegateBridge __Hotfix0_GetCampXY;

	private static DelegateBridge __Hotfix0_GetCampID;

	private static DelegateBridge __Hotfix0_GetTilePosCampIDByPos;

	private static DelegateBridge __Hotfix0_GetTilePosCampIDByTileID;

	private static DelegateBridge __Hotfix1_GetTilePosCampIDByTileID;

	private static DelegateBridge __Hotfix0_GetTileTileAllPos;

	private static DelegateBridge __Hotfix0_GetTileSize;

	private static DelegateBridge __Hotfix0_GetTileSurroundingPos;

	private static DelegateBridge __Hotfix0_GetCampCode;

	private static DelegateBridge __Hotfix0_isThisCamp;

	private static DelegateBridge __Hotfix0_get_TKeyMin;

	private static DelegateBridge __Hotfix0_get_TKeyMax;

	private static DelegateBridge __Hotfix0_CheckMapX;

	private static DelegateBridge __Hotfix0_CheckMapY;

	private static DelegateBridge __Hotfix0_GetTileXY_Key;

	private static DelegateBridge __Hotfix0_GetTileKey_XY;

	private static DelegateBridge __Hotfix0_checkIsBig;

	private static DelegateBridge __Hotfix0_GetTileIDExSize;

	private static DelegateBridge __Hotfix0_GetTileIDExIndex;

	private static DelegateBridge __Hotfix0_GetTileID;

	private static DelegateBridge __Hotfix0_checkIsBegin;

	private static DelegateBridge __Hotfix0_GetBeginTileIDEx;

	private static DelegateBridge __Hotfix0_GetBeginTileXY;

	private static DelegateBridge __Hotfix0_checkIsResPoint;

	private static DelegateBridge __Hotfix0_GetMiniMapStateOne;

	private static DelegateBridge __Hotfix0_requestMiniMapData;

	private static DelegateBridge __Hotfix0_requestMapData;

	private static DelegateBridge __Hotfix0_TileXY_BlockXY;

	private static DelegateBridge __Hotfix0_BlockXY_TileXY_LB;

	private static DelegateBridge __Hotfix0_BlockXY_TileXY_RT;

	private static DelegateBridge __Hotfix0_BlockXY_Key;

	private static DelegateBridge __Hotfix0_BlockKey_XY;

	private static DelegateBridge __Hotfix0_GetBlockKeys_TileXY;

	private static DelegateBridge __Hotfix0_GetBlockKeys_BlockXY;

	private static DelegateBridge __Hotfix0_requestMapData_Block;

	private static DelegateBridge __Hotfix0_requestTileMark;

	private static DelegateBridge __Hotfix0_requestTileTown;

	private static DelegateBridge __Hotfix0_checkTileUnlock_Force;

	private static DelegateBridge __Hotfix0_checkTileUnlock;

	private static DelegateBridge __Hotfix0_checkTileUnlock_Side;

	private static DelegateBridge __Hotfix1_checkTileUnlock_Side;

	private static DelegateBridge __Hotfix0_GetCampTileData;

	private static DelegateBridge __Hotfix0_clearTileData;

	private static DelegateBridge __Hotfix0_RefreshSelfResourceData;

	private static DelegateBridge __Hotfix0_RefreshRewardBoxOnceDict;

	private static DelegateBridge __Hotfix0_SetRewardBoxDict_CampTileDict;

	private static DelegateBridge __Hotfix0_GetRewardBoxOnceNoGet;

	private static DelegateBridge __Hotfix0_GetLinePointD;

	private static DelegateBridge __Hotfix0_GetDiffValue_Percent;

	private static DelegateBridge __Hotfix0_GetDiffValue;

	private static DelegateBridge __Hotfix0_GetCursorCampLB;

	private static DelegateBridge __Hotfix0_get_TownBeginPos;

	private static DelegateBridge __Hotfix0_get_TownPosDefault;

	private static DelegateBridge __Hotfix0_initTownPos;

	private static DelegateBridge __Hotfix0_setMapMyTownSkin;

	private static DelegateBridge __Hotfix0_get_TownSkinRangeMax;

	private static DelegateBridge __Hotfix0_GetTownSkinEffectList;

	private static DelegateBridge __Hotfix0_GetTownSkinEffectListNoSame;

	private static DelegateBridge __Hotfix0_setCameraViewData;

	private static DelegateBridge __Hotfix0_get_isInMiniMap;

	private static DelegateBridge __Hotfix0_get_GetTownNeedTimeSpace;

	private static DelegateBridge __Hotfix0_CanPutTownHere;

	private static DelegateBridge __Hotfix0_canPutTownHere;

	private static DelegateBridge __Hotfix0_canMarkTileOne;

	private static DelegateBridge __Hotfix0_CanMarkTileOne;

	private static DelegateBridge __Hotfix0_get_canMeMarkRight;

	private static DelegateBridge __Hotfix0_get_MarkTotalMax;

	private static DelegateBridge __Hotfix0_get_LeftMarkCount;

	private static DelegateBridge __Hotfix0_changeMarkState;

	private static DelegateBridge __Hotfix0_GetTileMarkDataList;

	private static DelegateBridge __Hotfix0_canLookTileOne;

	private static DelegateBridge __Hotfix0_CanLookTileOne;

	private static DelegateBridge __Hotfix0_isBuildingType_Resource;

	private static DelegateBridge __Hotfix0_initForceDict;

	private static DelegateBridge __Hotfix0_GetDayRoadUnlock;

	private static DelegateBridge __Hotfix0_GetTimeTileForceUnlock;

	private static DelegateBridge __Hotfix0_GetDayRoadDirection;

	private static DelegateBridge __Hotfix0_GetRoadPicId;

	private static DelegateBridge __Hotfix0_checkTileUnlockForeList;

	private static DelegateBridge __Hotfix0_checkClickTileXY;

	private static DelegateBridge __Hotfix0_setClickTilePic;

	private static DelegateBridge __Hotfix0_isHavePassOnceReward;

	private static DelegateBridge __Hotfix0_checkOnceRewardFull;

	private static DelegateBridge __Hotfix0_GetTileName;

	private static DelegateBridge __Hotfix0_GetMaxAttackTileLevel;

	private static DelegateBridge __Hotfix0_SetMaxAttackTileLevel;

	private static DelegateBridge __Hotfix0_GetTileTimeID;

	private static DelegateBridge __Hotfix0_initFogData;

	private static DelegateBridge __Hotfix1_initFogData;

	private static DelegateBridge __Hotfix0_setFogValue;

	private static DelegateBridge __Hotfix0_setFogValueOne;

	private static DelegateBridge __Hotfix0_setTopTargetFogValue;

	private static DelegateBridge __Hotfix0_GetFogValueOne;

	private static DelegateBridge __Hotfix0_checkTileFogValue;

	private static DelegateBridge __Hotfix0_updateFogValueSide;

	private static DelegateBridge __Hotfix0_updateFogValueOne;

	private static DelegateBridge __Hotfix0_freshTileFogState;

	private static DelegateBridge __Hotfix0_isFogClickState;

	private static DelegateBridge __Hotfix0_isFogXY;

	private static DelegateBridge __Hotfix0_get_TargetVisionValue;

	private static DelegateBridge __Hotfix0_get_MarkVisionValue;

	private static DelegateBridge __Hotfix0_initCampBoxTileList;

	private static DelegateBridge __Hotfix0_findCampBoxGuidePos;

	private static DelegateBridge __Hotfix0_isCampBoxHaveGet;

	private static DelegateBridge __Hotfix0_addCampBoxGetList;

	private static DelegateBridge __Hotfix0_requestCampBox;

	private static DelegateBridge __Hotfix0_GetCampBoxID;

	private static DelegateBridge _c__Hotfix0_ctor;

	public bool DataHaveLoaded { get; private set; }

	public int CameraSizeLen => 0;

	public int TKeyMin => 0;

	public int TKeyMax => 0;

	public Vector2Int TownBeginPos => default;

	public int TownPosDefault => 0;

	public int TownSkinRangeMax => 0;

	public bool isInMiniMap => false;

	public int GetTownNeedTimeSpace => 0;

	public bool canMeMarkRight => false;

	public int MarkTotalMax => 0;

	public int LeftMarkCount => 0;

	public int TargetVisionValue => 0;

	public int MarkVisionValue => 0;

	protected override void Clear()
	{
	}

	protected override void Init()
	{
	}

	public void uninit()
	{
	}

	public void initForMapEditor()
	{
	}

	private void initCameraData()
	{
	}

	public void LoadData(int cx, int cy, Action action)
	{
	}

	private void initTileData()
	{
	}

	public void enterPre(int cx, int cy, Action action)
	{
	}

	public void enter(int cx, int cy)
	{
	}

	private void createCampMap(int cx, int cy)
	{
	}

	public void exit()
	{
	}

	public void requestTileState_Enter(int reqType, int x, int y, Action enterSuccess = null, Action enterFailure = null)
	{
	}

	public void LoadTileIDEx(LayerName layer, bool editor = false)
	{
	}

	private void ParseTileText(string txt, int[,] tileData)
	{
	}

	public int GetTileIDExXY(int layer, int x, int y)
	{
		return 0;
	}

	private int checkTileIDEx(int camp, int tid)
	{
		return 0;
	}

	private int checkHolyTileIDEx(int x, int y)
	{
		return 0;
	}

	private int checkBossTileIDEx(int x, int y)
	{
		return 0;
	}

	private int checkTownTileIDEx(int x, int y)
	{
		return 0;
	}

	public bool checkTileIsTown(int x, int y)
	{
		return false;
	}

	public bool isInitTownPosition(int tileID, int x, int y)
	{
		return false;
	}

	public int GetTileIDXY(int layer, int x, int y)
	{
		return 0;
	}

	public int GetTilePicXY(int layer, int x, int y)
	{
		return 0;
	}

	public bool IsCanSweep(int x, int y)
	{
		return false;
	}

	public (bool, int, int) CheckAroundIsHaveAttackedTile(int type, int x, int y)
	{
		return default;
	}

	public void SetAttackedTileData(uint[] tileData)
	{
	}

	private int GetRoadPicFrame(int picId, int tidex)
	{
		return 0;
	}

	public bool checkInBounds(int x, int y)
	{
		return false;
	}

	public Tile CreateTile(int pid)
	{
		return null;
	}

	public int GetTileIDExXY(int x, int y)
	{
		return 0;
	}

	public int GetTileIDXY(int x, int y)
	{
		return 0;
	}

	public Vector2Int GetCampXY(int camp, int x, int y)
	{
		return default;
	}

	public CampID GetCampID(int x, int y)
	{
		return CampID.Unknown;
	}

	public HashSet<CampID> GetTilePosCampIDByPos(int layer, int x, int y)
	{
		return null;
	}

	public HashSet<CampID> GetTilePosCampIDByTileID(int tileID, int x, int y)
	{
		return null;
	}

	public HashSet<CampID> GetTilePosCampIDByTileID(int x, int y)
	{
		return null;
	}

	public List<(int, int)> GetTileTileAllPos(int tileID, int x, int y)
	{
		return null;
	}

	public int GetTileSize(int tileID)
	{
		return 0;
	}

	public List<(int, int)> GetTileSurroundingPos(int tileID, int x, int y)
	{
		return null;
	}

	public int GetCampCode(int x, int y)
	{
		return 0;
	}

	public bool isThisCamp(int camp, int x, int y)
	{
		return false;
	}

	public int CheckMapX(int x)
	{
		return 0;
	}

	public int CheckMapY(int y)
	{
		return 0;
	}

	public int GetTileXY_Key(int x, int y)
	{
		return 0;
	}

	public Vector2Int GetTileKey_XY(int key)
	{
		return default;
	}

	public bool checkIsBig(int tileIDEx)
	{
		return false;
	}

	public int GetTileIDExSize(int tileIDEx)
	{
		return 0;
	}

	public int GetTileIDExIndex(int tileIDEx)
	{
		return 0;
	}

	public int GetTileID(int tileIDEx)
	{
		return 0;
	}

	public bool checkIsBegin(int tileIDEx)
	{
		return false;
	}

	public int GetBeginTileIDEx(int tileIDEx)
	{
		return 0;
	}

	public Vector2Int GetBeginTileXY(int tileIDEx, int x, int y)
	{
		return default;
	}

	public bool checkIsResPoint(int tileIDEx)
	{
		return false;
	}

	public int GetMiniMapStateOne(int x, int y)
	{
		return 0;
	}

	public void requestMiniMapData(int type, Action<bool> action = null)
	{
	}

	public void requestMapData(int type, int lb, int rt, Action<bool> action = null)
	{
	}

	private Vector2Int TileXY_BlockXY(int x, int y)
	{
		return default;
	}

	private Vector2Int BlockXY_TileXY_LB(int x, int y)
	{
		return default;
	}

	private Vector2Int BlockXY_TileXY_RT(int x, int y)
	{
		return default;
	}

	private int BlockXY_Key(int x, int y)
	{
		return 0;
	}

	public Vector2Int BlockKey_XY(int key)
	{
		return default;
	}

	private List<int> GetBlockKeys_TileXY(int fx, int fy, int ex, int ey)
	{
		return null;
	}

	private List<int> GetBlockKeys_BlockXY(int bfx, int bfy, int bex, int bey)
	{
		return null;
	}

	public void requestMapData_Block(int fx, int fy, int ex, int ey)
	{
	}

	public void requestTileMark(int type, int state, int tkey, Action<bool> action = null)
	{
	}

	public void requestTileTown(int type, int tkey, Action<CRespCampBaseBlock, int> action = null)
	{
	}

	public bool checkTileUnlock_Force(int x, int y)
	{
		return false;
	}

	public bool checkTileUnlock(int x, int y, bool camp = true)
	{
		return false;
	}

	public bool checkTileUnlock_Side(TileAnchor anchor, int x, int y, bool camp = true)
	{
		return false;
	}

	public bool checkTileUnlock_Side(int x, int y, bool camp, int offset)
	{
		return false;
	}

	public CampTileData GetCampTileData(int x, int y)
	{
		return null;
	}

	public void clearTileData()
	{
	}

	public void RefreshSelfResourceData(int key, long resetTime)
	{
	}

	public void RefreshRewardBoxOnceDict(Dictionary<uint, bool> dict)
	{
	}

	private void SetRewardBoxDict_CampTileDict()
	{
	}

	public int GetRewardBoxOnceNoGet()
	{
		return 0;
	}

	public Vector2 GetLinePointD(Vector2 pt1, Vector2 pt2, Vector2 pt3)
	{
		return default;
	}

	public float GetDiffValue_Percent(Vector2 v2)
	{
		return 0f;
	}

	public float GetDiffValue(int x, int y)
	{
		return 0f;
	}

	private Vector2Int GetCursorCampLB(int x, int y)
	{
		return default;
	}

	public void initTownPos()
	{
	}

	public void setMapMyTownSkin(int skin)
	{
	}

	public List<TownSkinEffectData> GetTownSkinEffectList(int realx, int realy)
	{
		return null;
	}

	public List<TownSkinEffectData> GetTownSkinEffectListNoSame(int realx, int realy)
	{
		return null;
	}

	public void setCameraViewData()
	{
	}

	public bool CanPutTownHere(int x, int y)
	{
		return false;
	}

	public int canPutTownHere(int x, int y)
	{
		return 0;
	}

	public int canMarkTileOne(int x, int y)
	{
		return 0;
	}

	public bool CanMarkTileOne(int cellx, int celly)
	{
		return false;
	}

	public void changeMarkState(int state, int tkey, ulong userid)
	{
	}

	public List<TileMarkData> GetTileMarkDataList()
	{
		return null;
	}

	public int canLookTileOne(int x, int y)
	{
		return 0;
	}

	public bool CanLookTileOne(int x, int y)
	{
		return false;
	}

	public bool isBuildingType_Resource(BuildingType type)
	{
		return false;
	}

	private void initForceDict()
	{
	}

	private int GetDayRoadUnlock(int x, int y)
	{
		return 0;
	}

	public long GetTimeTileForceUnlock(int x, int y)
	{
		return 0L;
	}

	private int GetDayRoadDirection(int x, int y)
	{
		return 0;
	}

	private int GetRoadPicId(int direction, int camp)
	{
		return 0;
	}

	private void checkTileUnlockForeList()
	{
	}

	public bool checkClickTileXY(int x, int y)
	{
		return false;
	}

	public void setClickTilePic(int ltx, int lty)
	{
	}

	public bool isHavePassOnceReward(int cellx, int celly)
	{
		return false;
	}

	public int checkOnceRewardFull(int tileID)
	{
		return 0;
	}

	public string GetTileName(int type, int level, int number = 0)
	{
		return null;
	}

	public int GetMaxAttackTileLevel()
	{
		return 0;
	}

	public void SetMaxAttackTileLevel(int level)
	{
	}

	public SLG_EventReminder GetTileTimeID()
	{
		return null;
	}

	public void initFogData()
	{
	}

	public void initFogData(int fx, int fy, int tx, int ty)
	{
	}

	public void setFogValue(int fx, int fy, int tx, int ty)
	{
	}

	public void setFogValueOne(int x, int y)
	{
	}

	public void setTopTargetFogValue(int x, int y)
	{
	}

	public int GetFogValueOne(int x, int y)
	{
		return 0;
	}

	public void checkTileFogValue(int x, int y, int size, int view)
	{
	}

	public void updateFogValueSide(int x, int y)
	{
	}

	public void updateFogValueOne(int x, int y, int value)
	{
	}

	public void freshTileFogState(int x, int y, int size, int view)
	{
	}

	public bool isFogClickState(int x, int y)
	{
		return false;
	}

	public bool isFogXY(int x, int y)
	{
		return false;
	}

	private void initCampBoxTileList()
	{
	}

	public int findCampBoxGuidePos()
	{
		return 0;
	}

	public bool isCampBoxHaveGet(int tkey)
	{
		return false;
	}

	public void addCampBoxGetList(int tkey)
	{
	}

	public void requestCampBox(int tkey, Action<CRespCampBlock, int> action = null)
	{
	}

	public int GetCampBoxID(int tid)
	{
		return 0;
	}
}
