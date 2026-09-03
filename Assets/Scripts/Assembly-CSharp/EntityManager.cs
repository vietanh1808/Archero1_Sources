using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EntityManager : MonoBehaviour
{
	public class DivideTransfer
	{
		public string divedeid;

		public int charid;

		public EntityType entitytype;
	}

	public class DivideData
	{
		public string DivideID;

		public int charid;

		public EntityType entitytype;

		public int count;

		public List<int> goodlist;
	}

	public const float Ground_Bottom_Y = -1f;

	private EntityHero _Self;

	[CompilerGenerated]
	private Action m_OnSetSelfEvent;

	private EntityBase tridentPartTarget;

	private List<EntityBase> m_HeroList;

	private List<EntityBase> m_EntityList;

	private List<EntityPartner> m_PartnerList;

	private Dictionary<ulong, EntityBase> entityMap;

	private Dictionary<int, int> m_dicEntityStatistics;

	private Dictionary<int, EntityBase> entityDic;

	private List<EntityBase> m_listMyTeamMembers;

	private List<EntityBase> m_listEnemyTeamMemebers;

	private Dictionary<GameObject, EntityBase> mObj2EntityList;

	private List<EntityTowerBase> m_TowerList;

	public Action<List<EntityBase>> OnEnemiesCntChangedAction;

	[CompilerGenerated]
	private Action<MapCreator.CreateData> m_OnAddEliteEnemyEvent;

	public Action<EntityBase> OnAddEnemyEvent;

	public Action<EntityBase> OnRemoveEnemyEvent;

	public BaseCommand CacheCommand;

	private bool over;

	private int id;

	private float find_minDis;

	private float find_minDis1;

	private EntityBase find_target;

	private EntityBase find_mintarget;

	private EntityBase find_temp;

	private int find_i;

	private int find_imax;

	private List<EntityBase> findcanattacklist;

	public bool IsCanSelectTarget;

	private List<EntityBase> mCanHitList;

	private List<EntityBase> mRangeList;

	private const float ArrowEjectDistance = 7.5f;

	private EntityBase eject_temp;

	private EntityBase entitybase_temp;

	private List<EntityBase> rounds_list;

	private EntityBase rounds_temp;

	private List<EntityBase> round_list;

	private EntityBase round_temp;

	private float near_min;

	private float near_dis;

	private EntityBase near_entity;

	private EntityBase near_entitytemp;

	private Vector3 v_bullet;

	private Vector3 v_entity;

	private float entity_angle;

	private EntityBase entity_random;

	private EntityBase entity_randomtemp;

	private List<EntityBase> Sector_list;

	private EntityBase Sector_e;

	private EntityBase entity_child;

	private List<EntityBabyBase> m_BabyList;

	private Dictionary<string, DivideData> mDivideList;

	private List<EntityPartBodyBase> m_PartBodyList;

	public EntityBase TridentPartTarget
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public EntityHero Self => null;

	public List<EntityPartner> Partners => null;

	public event Action OnSetSelfEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<MapCreator.CreateData> OnAddEliteEnemyEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void SetSelf(EntityHero self)
	{
	}

	public void AddHero(EntityBase hero)
	{
	}

	public void ClearTeamList()
	{
	}

	public long GetTotalAttackInPvp()
	{
		return 0L;
	}

	public List<EntityBase> GetOtherTeam(EntityBase self)
	{
		return null;
	}

	public List<EntityBase> GetRoundOtherTeam(EntityBase self, float radius)
	{
		return null;
	}

	public bool IsHaveEnermyInArea(EntityBase self, float radius)
	{
		return false;
	}

	public List<EntityBase> GetTeamMembers(EntityBase entity, bool sameTeam)
	{
		return null;
	}

	public List<EntityBase> GetTeamMembersByTeamId(int teamId)
	{
		return null;
	}

	public EntityBase GetEntityInMeadowBattle(int charID, int teamId)
	{
		return null;
	}

	public void ClearMeadowBattleEntities()
	{
	}

	public List<EntityBase> GetMyTeam(EntityBase self, bool bContainSelf = true)
	{
		return null;
	}

	public void SetPVPHeroHPSliderVisible(bool visible)
	{
	}

	public void RemoveOtherHero()
	{
	}

	public void SendPointDataFromNetHero()
	{
	}

	public int GetHeroCount()
	{
		return 0;
	}

	public EntityBase GetHeroByIndex(int index)
	{
		return null;
	}

	public EntityBase GetPVPOtherHero(int guidID)
	{
		return null;
	}

	public void BeforeAdd(MapCreator.CreateData data)
	{
	}

	public void Add(EntityBase entity)
	{
	}

	public void Remove(EntityBase entity)
	{
	}

	public EntityBase GetEntityByGuid(int guid)
	{
		return null;
	}

	public EntityBase GetEntityByIndex(ulong entityIndex)
	{
		return null;
	}

	public void RemoveLogic(EntityBase entity)
	{
	}

	public void BatchAddMonster(int _id = 0)
	{
	}

	public void AddTower(EntityTowerBase tower)
	{
	}

	public void RemoveTower(EntityTowerBase tower)
	{
	}

	public List<EntityBase> GetTargetList(EntityBase self, bool issameteam)
	{
		return null;
	}

	public EntityBase FindTargetExclude(EntityBase exclude)
	{
		return null;
	}

	public EntityBase FindCanAttackRandom(EntityBase self)
	{
		return null;
	}

	public EntityBase FindTargetHeroInCamera()
	{
		return null;
	}

	public bool IsInAttackRange(EntityBase from)
	{
		return false;
	}

	public EntityBase FindTargetAutoPvp()
	{
		return null;
	}

	public EntityBase FindTargetInCamera()
	{
		return null;
	}

	public EntityBase FindArrowEject(EntityBase entity)
	{
		return null;
	}

	public EntityBase FindCustomArrowEject(EntityBase entity, float _ArrowEjectDistance)
	{
		return null;
	}

	public EntityBase GetTarget(EntityBase self)
	{
		return null;
	}

	public int GetEntityCount()
	{
		return 0;
	}

	public List<EntityBase> GetEnemyInCameraView()
	{
		return null;
	}

	public int GetActiveEntityCount(bool onlyVisibile = true)
	{
		return 0;
	}

	public int GetActiveSelfEntityCount()
	{
		return 0;
	}

	public List<EntityBase> GetEntities()
	{
		return null;
	}

	public EntityBase GetEntityBase(GameObject o)
	{
		return null;
	}

	public List<EntityBase> GetRoundEntities(EntityBase entity, float range, bool haveself)
	{
		return null;
	}

	public List<EntityBase> GetRoundEntitiesByFixedPos(Vector3 centerPos, float range, EntityBase entity, bool sameteam)
	{
		return null;
	}

	public List<EntityBase> GetRoundHerosByFixedPos(Vector3 centerPos, float range, EntityBase entity, bool sameteam)
	{
		return null;
	}

	public List<EntityBase> GetInCrossEntitiesByFixedPos(Vector3 centerPos, float range, float crossWide, EntityBase entity, bool sameteam)
	{
		return null;
	}

	public EntityBase GetNearestEnemy(EntityBase entity)
	{
		return null;
	}

	public List<EntityBase> GetSortedAroundEnemies(EntityBase entity)
	{
		return null;
	}

	public List<EntityBase> GetExplodedEntitiesByFixedPos(Vector3 centerPos, float range, EntityBase entity, bool sameteam)
	{
		return null;
	}

	public EntityBase GetNearestEnemyFromAllEnemy(EntityBase entity)
	{
		return null;
	}

	public EntityBase GetNearestActiveEnemyFromAllEnemy(EntityBase entity)
	{
		return null;
	}

	public EntityBase GetNearestEnemyFromAllEnemy(EntityBase entity, float radius)
	{
		return null;
	}

	public List<EntityBase> GetNearestEnemiesInAllModes(EntityBase entity, float radius)
	{
		return null;
	}

	public List<EntityBase> GetAllAroundEnemyList(EntityBase m_Entity, bool sameTeam = false)
	{
		return null;
	}

	public List<EntityBase> GetAllEntity(EntityBase entity, bool needAlive, bool needActive)
	{
		return null;
	}

	public List<EntityBase> GetAllEntity(EntityBase entity, bool isSameTeam, bool needAlive, bool needActive)
	{
		return null;
	}

	public EntityBase GetRandomEnemy(EntityBase entity)
	{
		return null;
	}

	public List<EntityBase> GetAroundEnemyList(EntityBase m_Entity, float radius, bool sameTeam = false)
	{
		return null;
	}

	public List<EntityBase> GetEnemyByPosZ(EntityBase m_Entity, float posX1, float posX2, bool sameTeam = false)
	{
		return null;
	}

	public List<EntityBase> GetAroundEnemyList(Vector3 centerPos, EntityBase m_Entity, float radius, bool sameTeam = false)
	{
		return null;
	}

	public List<EntityBase> GetRoundEntitiesByFixedPosXZ(Vector3 centerPos, float range, EntityBase entity, bool sameteam)
	{
		return null;
	}

	public EntityBase GetEntityInSector(EntityBase self, Vector3 pos, Vector3 forward, float sector)
	{
		return null;
	}

	public List<EntityBase> GetEntitiesInSector(EntityBase self, Vector3 pos, Vector3 forward, float sector)
	{
		return null;
	}

	private Vector3 ResetVector3Y(Vector3 v)
	{
		return default;
	}

	public List<EntityBase> GetRoundTeammates(EntityBase self, float range, bool haveself)
	{
		return null;
	}

	public List<EntityBase> GetRoundEntities(Vector3 pos, EntityBase self, float range, bool haveself)
	{
		return null;
	}

	public List<EntityBase> GetAliveEntities(bool onlyVisible = false)
	{
		return null;
	}

	public int GetAliveEntityCnt()
	{
		return 0;
	}

	public List<EntityBase> GetAliveEntities2()
	{
		return null;
	}

	public List<EntityBase> GetAliveBosses()
	{
		return null;
	}

	public List<EntityBase> GetAliveSoliders()
	{
		return null;
	}

	public List<EntityBase> GetNotCallAliveSoliders()
	{
		return null;
	}

	public EntityBase GetNearestEntity(EntityBase entity)
	{
		return null;
	}

	public EntityBase GetNearestEntityInCamera(EntityBase entity)
	{
		return null;
	}

	public EntityBase GetNearestEntity(Vector3 pos)
	{
		return null;
	}

	public EntityBase GetNearestEntityInCamera(Vector3 pos)
	{
		return null;
	}

	public List<EntityBase> GetAliveEntitiesByDistance(Vector3 pos, float distance)
	{
		return null;
	}

	public List<EntityBase> GetAliveEntitiesByDistanceDescending(Vector3 pos, float distance)
	{
		return null;
	}

	public List<EntityBase> GetAliveEntitiesByDistanceAscending(Vector3 pos, float distance)
	{
		return null;
	}

	public List<EntityBase> GetEntityById(int id)
	{
		return null;
	}

	public EntityBase GetRandomEntity()
	{
		return null;
	}

	public List<EntityBase> GetRoundSelfEntities(EntityBase self, float range, bool sameteam)
	{
		return null;
	}

	public EntityBase GetNearEntity(EntityBase self, float range, bool sameteam)
	{
		return null;
	}

	public EntityBase GetNearTarget(EntityBase self)
	{
		return null;
	}

	public EntityBase GetNearEntity(BulletBase bullet, bool sameteam)
	{
		return null;
	}

	public EntityBase GetAngleEntities(BulletBase bullet, float maxangle, float fardis)
	{
		return null;
	}

	public EntityBase GetRandomEntity(EntityBase self, float range, bool sameteam)
	{
		return null;
	}

	public List<EntityBase> GetSectorEntities(EntityBase self, float range, float middleangle, float offsetangle, bool sameteam)
	{
		return null;
	}

	public EntityBase GetEntityByChild(GameObject o)
	{
		return null;
	}

	public void MonstersClear()
	{
	}

	public void MonstersClearInGameType5()
	{
	}

	public void DeInit()
	{
	}

	public void CampBattleRoundRelease()
	{
	}

	public bool IsSelfObject(GameObject o)
	{
		return false;
	}

	public int GetCntByEntityId(int id)
	{
		return 0;
	}

	public void AddPartner(EntityPartner partner)
	{
	}

	public void RemovePartner(EntityPartner partner)
	{
	}

	public void DealCacheCommand()
	{
	}

	public void SetBaby(EntityBabyBase baby)
	{
	}

	private void DeInitBabies()
	{
	}

	public void RemoveBaby(EntityBabyBase baby)
	{
	}

	public void AddDivide(string divideid, DivideTransfer transfer)
	{
	}

	public void RemoveDivide(string divideid)
	{
	}

	public bool GetDivideDead(string divideid, out List<int> goodlist, out EntityType entitytype)
	{
		goodlist = null;
		entitytype = default;
		return false;
	}

	public void SetPartBody(EntityPartBodyBase partbody)
	{
	}

	public void DeInitPartBodies()
	{
	}

	public void RemovePartBody(EntityPartBodyBase partbody, bool gotonextroom = false)
	{
	}

	public List<EntityPartBodyBase> GetPartBodies()
	{
		return null;
	}

	public IEnumerable<EntityPartBodyBase> GetAroundPartBodyBases(EntityBase entity, float radius)
	{
		return null;
	}

	public List<EntityPartBodyBase> GetMyPartBodyBases(EntityBase me)
	{
		return null;
	}

	public List<EntityPartBodyBase> GetMyPartBodyBasesById(EntityBase me, int partId)
	{
		return null;
	}
}
