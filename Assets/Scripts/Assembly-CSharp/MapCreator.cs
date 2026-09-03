using System;
using System.Collections.Generic;
using System.Xml;
using Dxx.Util;
using TableTool;
using UnityEngine;

public class MapCreator
{
	public class CreateData
	{
		public EntityBase parent;

		public int entityid;

		public Vector2Int v;

		public float x;

		public float y;

		private HeroModeData.SOLIDER_TYPE _soliderType;

		public bool bDivide;

		public bool bCall;

		public string path => null;

		public bool m_bElite
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool m_bHell => false;

		public HeroModeData.SOLIDER_TYPE SoliderType
		{
			get
			{
				return HeroModeData.SOLIDER_TYPE.SOLIDER_TYPE_Normal;
			}
			set
			{
			}
		}
	}

	public class Transfer
	{
		public RoomControlBase roomctrl;

		public int roomid;

		public int resourcesid;

		public string tmxid;

		public bool delay;

		public RoomGenerateBase.RoomType roomtype;

		public override string ToString()
		{
			return null;
		}
	}

	public enum MapGoodType
	{
		Empty = 0,
		Goods = 1,
		Soldier = 2,
		Boss = 3,
		Event = 4,
		Tower = 5,
		NetSoldier = 6,
		NetBoss = 7,
		MonsterLair = 8,
		Special = 9,
		TD2023_POINT = 10
	}

	public class GoodsInfo
	{
		public int id;

		public int x;

		public int y;

		public GoodsInfo(int id, int x, int y)
		{
		}
	}

	private class GoodsWeight
	{
		public int id;

		public int weight;

		public GoodsWeight(int id, int weight)
		{
		}
	}

	public class HeroModeData
	{
		public enum SOLIDER_TYPE
		{
			SOLIDER_TYPE_Normal = 0,
			SOLIDER_TYPE_Elite = 1,
			SOLIDER_TYPE_Hell = 2
		}

		public Vector2Int roompos;

		public int entityid;

		private SOLIDER_TYPE _soliderType;

		public bool m_bElite
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SOLIDER_TYPE SoliderType
		{
			get
			{
				return SOLIDER_TYPE.SOLIDER_TYPE_Normal;
			}
			set
			{
			}
		}
	}

	public enum GridDirection
	{
		LeftUp = 0,
		Up = 1,
		RightUp = 2,
		Left = 3,
		Right = 4,
		LeftDown = 5,
		Down = 6,
		RightDown = 7
	}

	public const string DAILY_FOLDER_PREFIX = "Game/Map/Tiled/eDaily/";

	public Action Event_Button1101;

	private static Dictionary<MapGoodType, string> mResList;

	private Dictionary<string, string> mMapStrings;

	private const int TrapUpStart = 2001;

	private const int TrapUpEnd = 2002;

	private const int TrapDownStart = 2003;

	private const int TrapDownEnd = 2004;

	private const int TrapLeftStart = 2005;

	private const int TrapLeftEnd = 2006;

	private const int TrapRightStart = 2007;

	private const int TrapRightEnd = 2008;

	private const int WaterID = 1006;

	private int angleCount;

	private SequencePool mSequencePool;

	private string MapID;

	private RoomGenerateBase.RoomType mRoomType;

	private RoomControlBase mRoomCtrl;

	private int _width;

	private int _height;

	private Vector2 CombineOffset;

	private Dictionary<int, Goods_goods> GoodsList;

	private Dictionary<int, int> TileMap2Goods;

	private int[,] tiledata;

	private int[,] RoomRealRect;

	private int[,] findpathRect;

	private TMXGoodsData[,] TmxGoodsList;

	private int roomid;

	private List<GameObject> mGoodsList;

	private Transfer mTransfer;

	private int GuidGenerate;

	private Dictionary<string, AssetBundle> m_dicAbs;

	private static int count;

	private WeightRandomCount callRandom;

	private const string Tag = "MapCreator";

	private int m_nCurWave;

	private int m_nTotalWave;

	private float m_fTime;

	private int m_nInterval;

	private int m_nAddMonsterRatio;

	private int m_nMonsterCntPerWave;

	private WeightRandom m_weightRandom;

	public FindPath Bomberman_path;

	private int[,] bomberman_rect;

	private int[,] bomberman_danger;

	private int[,] mCallRect;

	public const int Good_StoneID = 1001;

	public const int Good_GrassID = 1007;

	public const int Good_WoodID = 1009;

	public const int Good_FenceID = 1008;

	private const string WeightString = "1,7;2,1|1,7;2,1|1,1|1,1";

	private Dictionary<int, Dictionary<int, WeightRandom>> mElementData;

	private Dictionary<int, string> mWeightStrings;

	protected Dictionary<Vector2Int, HeroModeData> elitelist;

	protected List<HeroModeData> bosslist;

	protected List<HeroModeData> monsterlist;

	protected List<HeroModeData> monsterLairList;

	public const int SELF_TEAM_ID = 1;

	public const int OPPONENT_TEAM_ID = 2;

	public const int INTERVAL_GRIDS = 3;

	public List<MapGoodBase> PvpGrassList;

	private Vector2Int GetRoundEmpty_v;

	private List<Vector2Int> GetRoundEmpty_list;

	public Dictionary<GridDirection, Vector2Int> GridDirectionDict;

	private List<Vector2Int> sides_resultlist;

	private List<Vector2Int> sides_list;

	private List<Vector2Int> sides_listtemp;

	private List<Vector2Int> line_list;

	private List<Vector2Int> line_listtemp;

	private bool[,] waterchecks;

	public Action<int> OnCurrentWaveCreateEnd;

	public Action<int, RoomGenerateBase.RoomType, int, int> OnWaveCreateStart;

	private Dictionary<RoomGenerateBase.RoomType, int> waveroom_maxwave;

	private Dictionary<RoomGenerateBase.RoomType, int> waveroom_time;

	private Dictionary<RoomGenerateBase.RoomType, int> waveroom_survival;

	private int waveroom_currentwave;

	private bool _waveroom_currentwave_createend;

	private bool waveroom_startwave;

	private List<XmlNode> waveroom_nodelist;

	private SequencePool waveroom_pool;

	private BattleLevelWaveData mWaveData;

	private BattleDailyWaveData dailyWaveData;

	private BattleTowerWaveData mTowerWaveData;

	private BattleEventTowerWaveData mEventTowerWaveData;

	public RoomControlBase RoomCtrl => null;

	public int width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int RoomID => 0;

	private float startX => 0f;

	private float startY => 0f;

	public int MaxRow => 0;

	public int MaxCol => 0;

	public Vector2Int LeftTop => default;

	public Vector2Int RightTop => default;

	public float WorldWidth => 0f;

	public float HalfGridWidth => 0f;

	public float HalfGridHeight => 0f;

	public int HalfWidth => 0;

	public int HalfHeight => 0;

	private bool waveroom_currentwave_createend
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private int GetGuid()
	{
		return 0;
	}

	private void Init()
	{
	}

	protected void OnInit()
	{
	}

	public void Deinit()
	{
	}

	protected void OnDeInit()
	{
	}

	public string GetTmxId()
	{
		return null;
	}

	public void ClearMapInUI()
	{
	}

	public void CreateMapInUI(RoomGenerateBase.Room room, RoomControlBase roomctrl)
	{
	}

	public void SetRoomType(RoomGenerateBase.RoomType _roomType)
	{
	}

	public void CreateMap(Transfer t)
	{
	}

	private bool ShouldUseWaveRoomCreation()
	{
		return false;
	}

	private static bool ShouldUseWaveRoomCreationForTest(bool isWaveRoom, bool isDaily130, bool isBossRoom, Func<int> bossWaveCount, Func<int> bossWaveInterval)
	{
		return false;
	}

	private bool ShouldAutoStartDaily130BossWaveByInterval()
	{
		return false;
	}

	private static bool ShouldAutoStartDaily130BossWaveByIntervalForTest(bool isWaveRoom, bool isDaily130, bool isBossRoom, int bossWaveCount, int bossWaveInterval)
	{
		return false;
	}

	public RoomGenerateBase.RoomType CheckTmxID(string TmxID)
	{
		return RoomGenerateBase.RoomType.eInvalid;
	}

	public RoomGenerateBase.RoomType CheckTmxIDType5(string TmxID)
	{
		return RoomGenerateBase.RoomType.eInvalid;
	}

	private int[,] GetTileData(string tmxid)
	{
		return null;
	}

	public int GetRoomResourceID(string tmxid)
	{
		return 0;
	}

	public int GetResourceIdByHeight(int height)
	{
		return 0;
	}

	protected int OnGetRoomResourceID(int height, int id, string tmxid)
	{
		return 0;
	}

	public int GetRoomHeight(string source, string tmxid)
	{
		return 0;
	}

	public void GetRoomHeightAndWidth(string source, string tmxid, out int height, out int width)
	{
		height = default;
		width = default;
	}

	private string GetTmxPath(string tmxid)
	{
		return null;
	}

	public string GetTmxString(string tmxid)
	{
		return null;
	}

	public bool HaveTmx(string tmxid)
	{
		return false;
	}

	private void CreateAllGoodsInUI()
	{
	}

	private void CreateAllGoods()
	{
	}

	private void CreateAllGoodsByPreLoad()
	{
	}

	private void PreLoadPublicRes()
	{
	}

	private void PreLoadRes(Action preLoaded)
	{
	}

	private int PreLoadGoodNotTrap(int GoodsID, int x, int y, Action<GameObject> oneload)
	{
		return 0;
	}

	private int PreLoadGood(int GoodsID, int x, int y, Action<GameObject> oneload)
	{
		return 0;
	}

	public int PreLoadEntity(string path, Action<GameObject> oneload)
	{
		return 0;
	}

	public int PreLoadOneGoods(int GoodsID, int x, int y, Action<GameObject> oneload)
	{
		return 0;
	}

	private List<Vector2Int> GetCreatePositionList()
	{
		return null;
	}

	public GameObject CreateOneGoods(int GoodsID, int x, int y, bool isPreload = false)
	{
		return null;
	}

	private void onHandleTDPoints(int goodsId, int x, int y)
	{
	}

	private GameObject RandomMonster(int GoodsID, int x, int y, bool isPreload)
	{
		return null;
	}

	public GameObject CreateMonster(int GoodsID, int x, int y, bool isPreload, HeroModeData.SOLIDER_TYPE type)
	{
		return null;
	}

	public GameObject CreateMonster(int GoodsID, int x, int y, bool isPreload, bool isElite)
	{
		return null;
	}

	private GameObject CreateMonster(int GoodsID, int x, int y, bool isPreload)
	{
		return null;
	}

	public GameObject CreateGood(int GoodsID, int x, int y, params object[] args)
	{
		return null;
	}

	private GameObject LoadGoodRes(int pGoodsID)
	{
		return null;
	}

	private GameObject CreateGoodByObject(GameObject obj, int GoodsID, int x, int y, object[] args = null)
	{
		return null;
	}

	public GameObject CreateGoodNotTrap(int GoodsID, int x, int y, params object[] args)
	{
		return null;
	}

	public GameObject CreateGoodExtra(int GoodsID, int x, int y)
	{
		return null;
	}

	public EntityBase CreateEntityOneWorld(int entityId, string path)
	{
		return null;
	}

	public EntityBase CreateEntityOneWorld(CreateData data)
	{
		return null;
	}

	public EntityBase CreateEntity(CreateData data, bool isPreload = false)
	{
		return null;
	}

	private EntityBase CreateEntityByObject(GameObject obj, CreateData data, bool isPreload = false)
	{
		return null;
	}

	public EntityBase CreateDivideEntity(EntityBase parent, int entityid, float x, float y, bool inheritRoomType = true)
	{
		return null;
	}

	public void CreateDivideEntityAsync(EntityBase parent, int entityid, float x, float y, Action<EntityBase> onCreated, bool inheritRoomType = true)
	{
	}

	public EntityPartBodyBase CreatePartBodyNet(EntityBase source, CreatePartBodyCommand cmd)
	{
		return null;
	}

	private Goods_goods GetGoods(int GoodsID)
	{
		return null;
	}

	public static MapGoodType GetGoodType(int goodid)
	{
		return MapGoodType.Empty;
	}

	private bool IsMonster(int goodsid)
	{
		return false;
	}

	public EntityMonsterBase CreateEntityCall(int entityid, float x, float y)
	{
		return null;
	}

	public EntityMonsterBase CreateEntityCall(int entityid, float x, float y, bool isElite)
	{
		return null;
	}

	private int GetGoodID(int i, int j)
	{
		return 0;
	}

	public int GetGoodID(int[,] t, int i, int j)
	{
		return 0;
	}

	public void ClearGoods()
	{
	}

	public int GetAngleCount()
	{
		return 0;
	}

	public RoomGenerateBase.RoomType GetRoomType()
	{
		return RoomGenerateBase.RoomType.eInvalid;
	}

	public bool IsAngleRoom()
	{
		return false;
	}

	private void DealTrap()
	{
	}

	private int FindTrapUpEnd(int x, int y)
	{
		return 0;
	}

	private int FindTrapDownEnd(int x, int y)
	{
		return 0;
	}

	private int FindTrapLeftEnd(int x, int y)
	{
		return 0;
	}

	private int FindTrapRightEnd(int x, int y)
	{
		return 0;
	}

	private void InitDailySurvival(int roomId)
	{
	}

	private void DeInitDailySurvival()
	{
	}

	private void CreateAllGoods_Survival()
	{
	}

	private void DailyPlayerMove(Vector3 moveby)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	public bool IsSurvivalWaveEnd()
	{
		return false;
	}

	private void UpdateWaveUI()
	{
	}

	private void OnDailyGetRoomResourceID(int height, ref int id, string tmxid)
	{
	}

	private void OnInitDaily118Elite()
	{
	}

	private void OnDeInitDaily()
	{
	}

	private void InitEnemiesInMazeMode()
	{
	}

	protected void OnMazeInit()
	{
	}

	private void OnEntityCreate(EntityBase entity)
	{
	}

	private void Bomberman_Init()
	{
	}

	public int[,] Bomberman_GetDanger()
	{
		return null;
	}

	public int[,] Bomberman_GetRect()
	{
		return null;
	}

	private void Bomberman_danger_reset()
	{
	}

	public bool Bomberman_is_empty(Vector3 pos)
	{
		return false;
	}

	public void Bomberman_Use(Vector3 pos, int length)
	{
	}

	public void Bomberman_Cache(Vector3 pos)
	{
	}

	public bool Bomberman_is_danger(Vector2Int v)
	{
		return false;
	}

	public bool Bomberman_is_danger(Grid.NodeItem item)
	{
		return false;
	}

	public bool Bomberman_is_danger(int x, int y)
	{
		return false;
	}

	private void Bomberman_update_danger()
	{
	}

	public Vector2Int Bomberman_get_safe_near(Vector3 pos)
	{
		return default;
	}

	private void Bomberman_set_danger(int length, int x, int y)
	{
	}

	public List<Grid.NodeItem> Bomberman_find_path(Vector3 startpos, Vector3 endpos)
	{
		return null;
	}

	public bool GetCanCall(EntityBase entity, int radiusmin, int radiusmax)
	{
		return false;
	}

	public bool RandomCallSide(EntityBase entity, int range, out float endx, out float endz)
	{
		endx = default;
		endz = default;
		return false;
	}

	public bool RandomCallSide(EntityBase entity, int radiusmin, int radiusmax, out float endx, out float endz)
	{
		endx = default;
		endz = default;
		return false;
	}

	public void CallPositionRecover(Vector3 pos)
	{
	}

	private void InitElementData(int id)
	{
	}

	private int GetRandomElementID(int elementid)
	{
		return 0;
	}

	public Sprite GetRandomElement(int elementid)
	{
		return null;
	}

	public Sprite GetElementShadow(int elementid)
	{
		return null;
	}

	public bool GetStage3MiddleWater()
	{
		return false;
	}

	public bool isInWater(Vector3 pos)
	{
		return false;
	}

	protected void ClearDatas()
	{
	}

	protected virtual void InitEliteEnemies()
	{
	}

	protected void AddEliteList()
	{
	}

	protected void filterEnemies()
	{
	}

	private int random_elitelist(List<HeroModeData> list, int count)
	{
		return 0;
	}

	private void random_monsterlist(List<HeroModeData> list, int count)
	{
	}

	private bool heromode_can_add(int entityid)
	{
		return false;
	}

	private bool heromode_is_elite(int x, int y)
	{
		return false;
	}

	private HeroModeData.SOLIDER_TYPE SoliderType(int x, int y)
	{
		return HeroModeData.SOLIDER_TYPE.SOLIDER_TYPE_Normal;
	}

	private void heromode_end()
	{
	}

	private void InitTiledMap2Goods()
	{
	}

	private void ReadTiledMapTSX(string name)
	{
	}

	private void readTileMapInUI(RoomGenerateBase.Room room)
	{
	}

	private void readTileMap()
	{
	}

	private XmlNode get_node(XmlNodeList nodes)
	{
		return null;
	}

	public TeamMemberVO CreateTeamMemberVO(int entityId, Vector3 pos, int teamId, MeadowBattleMonsterInfo monsterInfo)
	{
		return null;
	}

	public float GetMapWidth()
	{
		return 0f;
	}

	public float GetMapHeight()
	{
		return 0f;
	}

	public Vector3 GetOriginal()
	{
		return default;
	}

	public Vector3 GetWorldPosByRowCol(int rowZ, int colX)
	{
		return default;
	}

	public TempMonsterMetaVO getTempMonsterVO(int charID)
	{
		return null;
	}

	public void InitTeams()
	{
	}

	public void UpdateEntityByTeamMemberVO(EntityBase entity, TeamMemberVO vo)
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private float getInitAngle(EntityBase entity, ActionMoveToDestination.MeadowBattleMoveType moveType)
	{
		return 0f;
	}

	public void ResetAngle(EntityBase entity, ActionMoveToDestination.MeadowBattleMoveType moveType, bool direct = true)
	{
	}

	public bool IsSelfTeam(int teamId)
	{
		return false;
	}

	private void initRoomRealRectGoods()
	{
	}

	public void SetFindPathRectValue(Vector2Int xy, int value)
	{
	}

	public int GetFindPathRectValue(Vector2Int xy)
	{
		return 0;
	}

	public bool IsPvpGrass(Vector2Int xy)
	{
		return false;
	}

	public Vector2Int GetRoomXY(float x, float z)
	{
		return default;
	}

	public Vector2Int GetRoomXY(Vector3 pos)
	{
		return default;
	}

	public Vector2Int GetRoomXYInside(Vector3 pos)
	{
		return default;
	}

	public Vector2Int ClampXY(Vector2Int xy)
	{
		return default;
	}

	public Vector3 GetWorldPosition(int x, int y)
	{
		return default;
	}

	public Vector3 GetWorldPosition(Vector2Int v2)
	{
		return default;
	}

	public Vector3 GetWorldPositionUnscale(Vector2Int v)
	{
		return default;
	}

	public Vector3 GetWorldPositionUnscale(int x, int y)
	{
		return default;
	}

	public bool IsXMiddle(int x)
	{
		return false;
	}

	public bool IsYMiddle(int y)
	{
		return false;
	}

	public bool IsEmpty(Vector2Int v)
	{
		return false;
	}

	public bool IsEmpty(int x, int y)
	{
		return false;
	}

	public List<Vector2Int> GetWaterPositions()
	{
		return null;
	}

	public bool IsOutOfMap(Vector3 v)
	{
		return false;
	}

	public Vector3 ClampWorldPos(Vector3 v)
	{
		return default;
	}

	public bool IsOutOfMapLeft(Vector3 v)
	{
		return false;
	}

	public bool IsOutOfMapRight(Vector3 v)
	{
		return false;
	}

	public bool IsOutOfMapUp(Vector3 v)
	{
		return false;
	}

	public bool IsOutOfMapDown(Vector3 v)
	{
		return false;
	}

	public bool IsOutOfMap(int x, int y)
	{
		return false;
	}

	public bool IsOutOfMapExtra(Vector3 v, float extend = 0.5f)
	{
		return false;
	}

	public bool IsOutOfCamera(Vector3 entityPos)
	{
		return false;
	}

	public bool IsEmpty(bool flystone, bool flywater, int x, int y)
	{
		return false;
	}

	private bool GetNearestEmpty(Vector2Int vInt, int count, ref Vector2Int v)
	{
		return false;
	}

	public Vector2Int GetNearestEmpty(Vector2Int vInt)
	{
		return default;
	}

	public List<Vector2Int> GetNearEmptyList(Vector3 pos, ref Vector2Int GoldsCenter, int radius)
	{
		return null;
	}

	public int[,] GetRects()
	{
		return null;
	}

	public int[,] GetFindPathRect()
	{
		return null;
	}

	public List<Vector2Int> GetRoundEmpty(Vector3 pos, int size)
	{
		return null;
	}

	public List<Vector2Int> GetAroundEmpty(Vector3 pos, int size)
	{
		return null;
	}

	public List<Vector2Int> GetRoundEmpty(Vector3 pos, int min, int max)
	{
		return null;
	}

	public List<Vector2Int> GetRoundEmptyGrids(Vector3 pos, int min, int max)
	{
		return null;
	}

	public List<Vector2Int> GetRoundGrids(Vector3 pos, int min, int max)
	{
		return null;
	}

	public List<Vector2Int> GetRoundFly(Vector3 pos, int size)
	{
		return null;
	}

	private bool isObstacleGood(int goodId)
	{
		return false;
	}

	public List<Vector2Int> GetRoundGround(Vector3 pos, int size)
	{
		return null;
	}

	public List<Vector2Int> GetFrontGround(EntityBase entity, int size)
	{
		return null;
	}

	public List<Vector2Int> GetRoundSideEmpty(int[,] rects, Vector3 pos, int size)
	{
		return null;
	}

	private List<Vector2Int> GetHorizontalEmpty(EntityBase entity)
	{
		return null;
	}

	private List<Vector2Int> GetVerticalEmpty(EntityBase entity)
	{
		return null;
	}

	public List<Vector2Int> GetAllEmptyGrids()
	{
		return null;
	}

	public List<Vector3> GetRoundNotSame(Vector3 selfwordpos, int range, int count)
	{
		return null;
	}

	private bool GetRoundNotSame_CheckSame(List<Vector3> list, float endx, float endz)
	{
		return false;
	}

	private Vector2Int get_empty(int xmin, int xmax, int ymin, int ymax)
	{
		return default;
	}

	public List<Vector2Int> GetRandom4XY()
	{
		return null;
	}

	public List<Vector2Int> GetRandom4XYWithoutBorder()
	{
		return null;
	}

	public List<Vector3> GetRandom4()
	{
		return null;
	}

	public List<Vector3> GetRandom4WithoutBorder()
	{
		return null;
	}

	public Vector3 GetRandomInCenter(uint xRange, uint yRange)
	{
		return default;
	}

	public void RandomItem(Vector3 pos, int range, out float endx, out float endz)
	{
		endx = default;
		endz = default;
	}

	public void RandomItem(EntityBase entity, int range, out float endx, out float endz)
	{
		endx = default;
		endz = default;
	}

	public void RandomFly(EntityBase entity, int range, out float endx, out float endz)
	{
		endx = default;
		endz = default;
	}

	public void RandomItemSide(EntityBase entity, int range, out float endx, out float endz)
	{
		endx = default;
		endz = default;
	}

	public void RandomItemSide(Vector3 pos, int range, out float endx, out float endz)
	{
		endx = default;
		endz = default;
	}

	public void RandomItemSides(EntityBase entity, int rangemin, int rangemax, out float endx, out float endz)
	{
		endx = default;
		endz = default;
	}

	public bool RandomItemLine(EntityBase entity, bool dir, int rangemin, int rangemax, out float endx, out float endz)
	{
		endx = default;
		endz = default;
		return false;
	}

	public Vector2Int RandomItemSide(Vector3 pos)
	{
		return default;
	}

	public Vector2Int RandomItemSide(EntityBase entity)
	{
		return default;
	}

	public Vector2Int RandomRoomXY()
	{
		return default;
	}

	public Vector2Int RandomRoomXY(int quadrantIndex)
	{
		return default;
	}

	public Vector3 RandomPosition()
	{
		return default;
	}

	public Vector3 RandomOutPosition()
	{
		return default;
	}

	public bool IsInMap(Vector2 pos)
	{
		return false;
	}

	public List<Vector3> RandomOutPositions(int count)
	{
		return null;
	}

	private bool ishave(List<Vector3> list, Vector3 pos)
	{
		return false;
	}

	public Vector3 RandomPositionRange(EntityBase entity, int range)
	{
		return default;
	}

	public Vector3 RandomPosition(int area)
	{
		return default;
	}

	public bool IsValid(Vector2Int v)
	{
		return false;
	}

	public bool IsValid(int x, int y)
	{
		return false;
	}

	public bool ExcuteRelativeDirection(Vector2Int from, Vector2Int to, out Vector2Int dir, bool fly = false)
	{
		dir = default;
		return false;
	}

	public List<Vector2Int> GetValidTDBirthEmptyGrids(Vector3 birthPos, Vector3 targetPos, int radius)
	{
		return null;
	}

	private void DealWater()
	{
	}

	public int GetWaterCount()
	{
		return 0;
	}

	private void CreateWater(int x, int y)
	{
	}

	private int water_checkround(int x, int y)
	{
		return 0;
	}

	private int GetWaterID(bool[,] checks)
	{
		return 0;
	}

	private int checkwaterid(string s)
	{
		return 0;
	}

	private bool IsWater(int x, int y)
	{
		return false;
	}

	private void water_test()
	{
	}

	private bool water_test_iswater(bool[,] checks, int x, int y)
	{
		return false;
	}

	private void water_test(bool[,] checks, int index)
	{
	}

	public void RegisterPlayerMove()
	{
	}

	private void waveroom_init()
	{
	}

	private void waveroom_deinit()
	{
	}

	public void waveroom_killseq()
	{
	}

	public int get_max_wave()
	{
		return 0;
	}

	private int get_time()
	{
		return 0;
	}

	private int get_survival()
	{
		return 0;
	}

	private void waveroom_playermove(Vector3 moveby)
	{
	}

	private void TryStartDaily130BossWaveByInterval()
	{
	}

	private void waveroom_create_good()
	{
	}

	private void waveroom_createmap(XmlNode node)
	{
	}

	private void waveroom_createnext_wave()
	{
	}

	public void waveroom_currentwave_clear()
	{
	}

	public void TryPlayRefMoster()
	{
	}

	public bool waveroom_is_clear()
	{
		return false;
	}

	public void waveroom_battlecache_init()
	{
	}

	private void RemoveNodeFromList(int index)
	{
	}

	private XmlNode waveroom_random_node()
	{
		return null;
	}

	private void send_ui(int time)
	{
	}

	private void send_event_tower_ui(int time)
	{
	}

	private void send_normal_ui(int time)
	{
	}

	private void send_survival_ui(int time)
	{
	}

	private void send_tower_ui(int time)
	{
	}

	private void onBeforeCreateNextWave()
	{
	}
}
