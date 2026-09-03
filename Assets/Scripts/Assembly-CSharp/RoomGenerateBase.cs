using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.Tweening;
using Dxx.Util;
using TCPPacket;
using UnityEngine;

public class RoomGenerateBase
{
	public enum RoomType
	{
		eInvalid = 0,
		eNormal = 1,
		eEvent = 2,
		eBoss = 3
	}

	public class Room
	{
		protected ObscuredInt _RoomID;

		private List<string> m_listMonsterModelIds;

		private List<int> m_listMonsterIds;

		public string TMXPath;

		public string TMXStr;

		public int RoomID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ResourcesID { get; private set; }

		public int RoomHeight { get; private set; }

		public int RoomWidth { get; private set; }

		public string TMXID { get; private set; }

		public string Style { get; set; }

		public bool IsBossRoom => false;

		public bool IsFirstRoom => false;

		public bool IsBattleRoom => false;

		public RoomType RoomType { get; private set; }

		public float playery { get; private set; }

		public void SetRoomID(int id)
		{
		}

		public void SetTmxUI(string tmxPath, string tmxid)
		{
		}

		private void trySetRoomTypeInGameType5()
		{
		}

		public void SetTmx(string tmxid)
		{
		}

		private void readTileMap()
		{
		}

		public bool ContainsModel(string id)
		{
			return false;
		}

		public bool ContainsMonster(int id)
		{
			return false;
		}

		private void ExcuteTmxName()
		{
		}

		private void InitResource()
		{
		}

		private void InitPlayerY()
		{
		}
	}

	public class EventCloseTransfer
	{
		public WindowID windowid;

		public object data;
	}

	public class WaveData
	{
		public Action OnCreateWave;

		private float firstWaveTime;

		private int maxWave;

		private float waveTime;

		private int currentWave;

		private float wavealivetime;

		private Sequence s_wave;

		public bool IsEnd => false;

		public WaveData(float firstWaveTime, string[] args)
		{
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		private void UpdateActiveData()
		{
		}
	}

	public const string FirstRoomTmx = "firstroom";

	public const string EmptyRoomTmx = "emptyroom";

	public const string reverseKey = "_reverse";

	public const string GameType5TMXID = "Level_M_0_9999";

	public const int GameType5GoodX = 7;

	protected Action mGuidEndAction;

	protected List<string> mUsedMaps;

	protected Dictionary<string, GameObject> mapList;

	protected Dictionary<int, Room> roomList;

	protected ObscuredInt _currentRoomID;

	private Sequence s_absorb;

	protected ObscuredInt _maxRoomID;

	protected ObscuredInt _opendoorIndex;

	protected RoomControlBase roomCtrl;

	private ToxicfogCtrl _toxicfogCtrl;

	private VisionMistCtrlV2 _visionMistCtrlV2;

	protected GameObject currentMap;

	protected float mCurrentRoomTime;

	private SequencePool mSequencePool;

	protected bool bBattleIn;

	protected bool bBattleCacheIn;

	protected NewChapterWaveController newChapterWave;

	public int GameType5WaveCount;

	public int CurGameType5RoomId;

	public int MaxGameType5RoomId;

	public const int FIRST_ROOM_ID = 0;

	public const int GAME_TYPE_5_BATTLE_ROOM_ID = 1;

	private List<int> m_listMonsterIdsInCurRoom;

	private Dictionary<int, List<int>> m_dicMonsterBulletIdsInCurRoom;

	protected const int DemonInitRatio = 100;

	protected int mDemonRatio;

	private Dictionary<Type, Action<object>> objectEventMap;

	protected CameraHellInvironmentCtrl _cameraHellInvironment;

	protected Material curMaterial;

	public bool realThroughDoor;

	protected string Tag => null;

	protected int currentRoomID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string lastNameKey { get; protected set; }

	public bool IsReverse => false;

	public int matchTypeLevel { get; protected set; }

	protected int maxRoomID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected int opendoorIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public RoomControlBase RoomCtrl => null;

	public GameObject CurrentMap => null;

	public bool IsBigMap { get; private set; }

	public Transform GoodsDropParent => null;

	public void Init(DeInitSourceType sourceType = DeInitSourceType.None)
	{
	}

	protected virtual void OnInit()
	{
	}

	public virtual void DeInit()
	{
	}

	protected virtual void OnDeInit()
	{
	}

	protected virtual void OnDeinitBefor()
	{
	}

	public void Clear()
	{
	}

	public float GetCurrentRoomTime()
	{
		return 0f;
	}

	public int GetCurrentRoomID()
	{
		return 0;
	}

	public int GetMaxRoomID()
	{
		return 0;
	}

	public Room GetRoomByRoomId(int roomID)
	{
		return null;
	}

	public Room GetCurrentRoom()
	{
		return null;
	}

	public virtual bool IsLastRoom()
	{
		return false;
	}

	public bool IsFirstRoom()
	{
		return false;
	}

	public void PlayerMove()
	{
	}

	public virtual void PlayerDead()
	{
	}

	public virtual void OnBeforeStartGame()
	{
	}

	public virtual void StartGame()
	{
	}

	private void setCurGameType5RoomId(int roomId)
	{
	}

	private void increaseCurGameType5RoomId()
	{
	}

	protected virtual void OnStartGameComplete()
	{
	}

	protected virtual void OnStartGame()
	{
	}

	protected virtual string OnGetFirstRoomTMX()
	{
		return null;
	}

	protected bool CanRandomTmx(string tmxid)
	{
		return false;
	}

	private void AddUsedTmx(string tmxid)
	{
	}

	protected string RandomTmx(string[] tmxids)
	{
		return null;
	}

	protected string RandomTmx(string[] tmxids, XRandom random)
	{
		return null;
	}

	protected virtual void CheckEmptyMap(string[] tmxids, ref List<string> rooms)
	{
	}

	protected virtual void GotoNextDoor()
	{
	}

	protected virtual void SetAbsorb(bool enable)
	{
	}

	private void onSpecialHandler()
	{
	}

	protected virtual void UnloadUnusedMap(Room room)
	{
	}

	private void CheckBigMap(int resourceId)
	{
	}

	public void AddDeadMonster(int id)
	{
	}

	public void AddMonsterBullet(int nMonsterId, int nBulletId)
	{
	}

	private void ReleaseCurRoomMonsterReses(Func<string, bool> canReleaseFunc = null, Func<int, bool> canReleaseFunc2 = null)
	{
	}

	protected virtual void SetBattleInHeroPostion()
	{
	}

	protected virtual void OnStartGameEnd()
	{
	}

	protected virtual bool gotonextdoor_canopen()
	{
		return false;
	}

	public void EnterDoor()
	{
	}

	public virtual void EnterPortalDoor(int line)
	{
	}

	public virtual void EnterDoor(EntityBase entity)
	{
	}

	public virtual void ExitDoor(EntityBase entity)
	{
	}

	protected virtual void RandomNextRoom()
	{
	}

	protected virtual void OnEnterDoorBefore()
	{
	}

	protected virtual void OnEnterDoorAfter()
	{
	}

	protected virtual string OnGetTmxID(int roomid)
	{
		return null;
	}

	public string GetTmxIDInLvProgressTip(int roomid)
	{
		return null;
	}

	public string GetTmxIDInLvProgressTipType5(int roomid)
	{
		return null;
	}

	protected virtual string OnGetTmxID(int line, int roomid)
	{
		return null;
	}

	public void CheckOpenDoor()
	{
	}

	public bool CheckOpenDoorInternal()
	{
		return false;
	}

	protected bool gotonextdoor_canopen_InGameType5()
	{
		return false;
	}

	protected bool CanOpenDoorInGameType5()
	{
		return false;
	}

	public virtual bool CanOpenDoor()
	{
		return false;
	}

	public void OpenDoor(bool delay = true)
	{
	}

	public bool IsDoorOpen()
	{
		return false;
	}

	protected void OpenDoorDelay(float delay)
	{
	}

	private void openDoorWrapper()
	{
	}

	protected virtual void OpenDoorDelayCallBack()
	{
	}

	protected virtual void ShowBossDeadEvent()
	{
	}

	protected virtual bool CheckShowDeadEvent()
	{
		return false;
	}

	protected virtual void OnOpenDoor()
	{
	}

	private void updateBattleInGameType()
	{
	}

	protected virtual void UpdateBattleIn()
	{
	}

	public bool OnCreateMapObject(string name, object mapRes)
	{
		return false;
	}

	public void ClearMapObjects()
	{
	}

	public static string GetStylePrefix()
	{
		return null;
	}

	protected GameObject CreateMapObject(Room room)
	{
		return null;
	}

	protected GameObject CreateMapObject(int resourcesid)
	{
		return null;
	}

	protected static void CacheMap(GameObject o)
	{
	}

	public static void PreloadMap(int id)
	{
	}

	public void AddGuildToMap(GameObject o)
	{
	}

	public void AddGuildToMap(GameObject o, Vector3 offset)
	{
	}

	public void SetGuideEndAction(Action callback)
	{
	}

	public void EventClose(EventCloseTransfer data)
	{
	}

	protected virtual void OnEventClose(EventCloseTransfer data)
	{
	}

	public void MonsterDead(EntityBase entity)
	{
	}

	public void MonsterDead(EntityBase source, EntityBase target)
	{
	}

	protected virtual void OnMonsterDead(EntityBase source, EntityBase entity)
	{
	}

	protected virtual void OnMonsterDead(EntityBase entity)
	{
	}

	public virtual void OnAddSkill(EntityBase entity, int skillid)
	{
	}

	public void PlayerHitted(long changehp)
	{
	}

	protected virtual void OnPlayerHitted(long changehp)
	{
	}

	public bool IsBattleLoad()
	{
		return false;
	}

	protected virtual bool OnIsBattleLoad()
	{
		return false;
	}

	protected virtual void OnEnd()
	{
	}

	protected virtual void OnReceiveEvent(string eventName, object data)
	{
	}

	public void SendEvent(string eventName, object data = null)
	{
	}

	public object GetEvent(string eventName, object data = null)
	{
		return null;
	}

	protected virtual object OnGetEvent(string eventName, object data = null)
	{
		return null;
	}

	public virtual void OnReceiveTcpPacket(TcpPacketBase packet)
	{
	}

	public virtual void NetHeroReborn_DeadEnd(bool pISelf)
	{
	}

	protected virtual SdkManager.GameOverPointData GetGameOverPointData()
	{
		return null;
	}

	protected virtual void SendSDKGameOverPoint()
	{
	}

	public bool IsFinalRoom()
	{
		return false;
	}

	public bool IsSpecialRoomInSanta2023()
	{
		return false;
	}

	public bool IsSpecialRoomInNewPlay126()
	{
		return false;
	}

	public bool IsBossRoom(int roomId)
	{
		return false;
	}

	public void SendEvent(object pData)
	{
	}

	protected void RegEvent(Type pKey, Action<object> pDelgate)
	{
	}

	public string GetRoomTmx(int roomId)
	{
		return null;
	}

	public bool IncreaseRoomID()
	{
		return false;
	}

	public bool ReachMaxRoomID()
	{
		return false;
	}

	public (Material, CameraHellInvironmentCtrl) ShowEnvironmentEffect(string effectPath)
	{
		return default;
	}

	public void CacheEnvironmentEffect(Material material = null)
	{
	}

	private string getNextRoomTmx(int nextRoomId)
	{
		return null;
	}

	private void RandomNextGameType5Room()
	{
	}

	private void saveBattleInTmx()
	{
	}

	public bool canCreateNewMapInGameType5()
	{
		return false;
	}

	private void tryCreateNewMapInGameType5(Room room)
	{
	}

	private void clearAndHideLastRoom()
	{
	}

	private void tryCacheMap(int lastRoomId, int lastGameType5RoomId)
	{
	}

	private void createMap(Room _room)
	{
	}

	protected virtual void OnCreateMap(Room room)
	{
	}

	private void refreshRoomCtrl(Room room)
	{
	}

	private void setSelfCoreInfo()
	{
	}

	private void releaseMonsters()
	{
	}

	private void releaseMonsters2()
	{
	}

	private void tryBuglyReport()
	{
	}

	private void tryResetCameraPos()
	{
	}

	private void tryUnloadLastRoomMap(Room room)
	{
	}

	private void setHeroPos()
	{
	}

	private void tryInvokeGotoNextRoomEvent()
	{
	}

	private void tryInvokeBossRoomEvent()
	{
	}
}
