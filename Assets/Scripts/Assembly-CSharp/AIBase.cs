using System;
using System.Collections.Generic;
using MeadowBattle;
using UnityEngine;

public class AIBase : ActionBasic
{
	public class ActionChoose : ActionBase
	{
		public Func<bool> Condition;

		public ActionBase ResultTrue;

		public ActionBase ResultFalse;

		private bool bResult;

		protected override void OnInit()
		{
		}

		private void ExcuteResultInit()
		{
		}

		private void ExcuteResultUpdate()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionSequence : ActionBase
	{
		public List<ActionBase> list;

		private int count;

		private int index;

		public List<ActionBase> ActionList => null;

		public void Clear()
		{
		}

		protected override void OnInit()
		{
		}

		public override void Reset()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnEnd()
		{
		}

		public void AddAction(ActionBase action)
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionDynamicWaitTime : ActionBase
	{
		private float startTime;

		private float waitTime;

		public Func<float> GetWaitTime;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionWaitRandom : ActionBase
	{
		public int min;

		public int max;

		private float startTime;

		private float waitTime;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		private int GetRandomInt(int min, int max)
		{
			return 0;
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionMove : ActionBase
	{
		public int moveId;

		public Action<int> action;

		protected override void OnInit()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionDivide : ActionBase
	{
		public int entityId;

		public int count;

		public Action<int, int> action;

		protected override void OnInit()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionCall : ActionBase
	{
		public class ActionCallData
		{
			public int entityId;
		}

		private ActionCallData data;

		public Action<ActionCallData> action;

		public void InitData(int entityId)
		{
		}

		protected override void OnInit()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionRotate : ActionBase
	{
		public float angle;

		private bool bRotate;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionRotateToEntity : ActionBase
	{
		public EntityBase target;

		private bool bRotate;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionRotateToPos : ActionBase
	{
		public Vector3 pos;

		private bool bRotate;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionReverseRotateToTarget : ActionBase
	{
		public EntityBase m_Target;

		private bool bRotate;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionRotateTime : ActionBase
	{
		public EntityBase target;

		public float time;

		private float mTime;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionRotateToTarget : ActionBase
	{
		public EntityBase target;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionBabyMeleeAttack : ActionAttack
	{
		private const float offsetAngle = 2f;

		protected override EntityBase HatredTarget => null;

		protected override void Attack()
		{
		}

		protected override void OnUpdate()
		{
		}
	}

	public class ActionAttack : ActionBase
	{
		public int attackId;

		public AIBase m_AIBase;

		public bool bAttackSpecial;

		public bool bRotate;

		protected bool bPlayAttack;

		protected float test_time;

		public EntityBase CustomHatredTarget;

		protected virtual EntityBase HatredTarget => null;

		public virtual float AttackInterval => 0f;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected virtual void Attack()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionAttack_Net : ActionAttack
	{
		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void Attack()
		{
		}

		protected override void OnEnd()
		{
		}
	}

	public class ActionLoop : ActionBase
	{
		private List<ActionBase> actionList;

		private int curIndex;

		public List<ActionBase> ActionList => null;

		private void increaseIndex()
		{
		}

		private void reset()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnEnd()
		{
		}

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		public void AddAction(ActionBase action)
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionChooseRandom : ActionBase
	{
		private List<ActionBase> actionList;

		private List<int> weightList;

		private int allWeight;

		private int actionCount;

		private int currentIndex;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		public void AddAction(int weight, ActionBase action)
		{
		}

		private int GetRandomWeight()
		{
			return 0;
		}

		protected override void OnForceEnd()
		{
		}

		public override void Reset()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionChooseIf : ActionBase
	{
		private List<ActionBase> list;

		private int count;

		private int index;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnForceEnd()
		{
		}

		public void AddAction(ActionBase action)
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class CallData
	{
		public int CallID;

		public int MaxAliveCount;

		public int MaxCount;

		public int perCount;

		public int radiusmin;

		public int radiusmax;

		public int CurAliveCount;

		public int CurAllCount;

		public bool IsElite;

		public bool IsRandom;

		private int PerCountMin;

		private int PerCountMax;

		public CallData(int callid, int alivecount, int count, int percount, int radiusmin, int radiusmax)
		{
		}

		public CallData(int callid, int alivecount, int count, int percount, int radiusmin, int radiusmax, bool isElite = false)
		{
		}

		public CallData(int callid, int alivecount, int count, int percountMin, int percountMax, int radiusmin, int radiusmax, bool isElite = false)
		{
		}

		public void AddCall()
		{
		}

		public void RemoveCall()
		{
		}

		public bool GetCanCall()
		{
			return false;
		}

		public int GetCallCount()
		{
			return 0;
		}

		public virtual int GetCallId()
		{
			return 0;
		}
	}

	public class CallWeightData : CallData
	{
		public class CallWeight
		{
			public int id;

			public int weight;
		}

		private List<CallWeight> m_listCallWeights;

		private int m_nAllWeight;

		public CallWeightData(int callid, int alivecount, int count, int percount, int radiusmin, int radiusmax)
			: base(0, 0, 0, 0, 0, 0)
		{
		}

		public CallWeightData(int callid, int alivecount, int count, int percount, int radiusmin, int radiusmax, bool isElite = false)
			: base(0, 0, 0, 0, 0, 0)
		{
		}

		public CallWeightData(int callid, int[] realCallIds, int[] weights, int alivecount, int count, int percount, int radiusmin, int radiusmax, bool isElite = false)
			: base(0, 0, 0, 0, 0, 0)
		{
		}

		public override int GetCallId()
		{
			return 0;
		}

		public void UpdateWeightDatas(int[] callIds, int[] weights)
		{
		}
	}

	public EntityBase m_Entity;

	public EntityMonsterBase m_MonsterEntity;

	protected string ClassName;

	private int pClassID;

	protected float actionTime;

	public EntityAttackBase mEntityAttack;

	protected float mRoomTime;

	protected float mCreateNewTime;

	private float mStartTime;

	protected bool IsDelayTime;

	protected bool bReRandom;

	protected BattleModuleData m_battleModuleData;

	protected bool m_bOutOfRange;

	protected List<ActionBase> m_listCachedActionList;

	private Dictionary<int, CallData> mCallList;

	public float Speed;

	public MeadowBattleMonsterInfo MonsterInfo;

	protected string Tag => null;

	public int ClassID => 0;

	public EntityBase TargetEnemy { get; set; }

	public Vector3 LastDetectEnemyPos { get; set; }

	public float LastAngleY { get; set; }

	public virtual void SetEntity(EntityBase entity)
	{
	}

	protected sealed override void OnInit1()
	{
	}

	protected virtual void OnInitOnce()
	{
	}

	protected virtual void OnInit()
	{
	}

	protected virtual void OnElite()
	{
	}

	public virtual void DestroyMeadowBattleCircles()
	{
	}

	protected sealed override void OnDeInit()
	{
	}

	protected virtual void OnAIDeInit()
	{
	}

	protected void ReRandomAI()
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	protected ActionBase GetActionRotate(float angle)
	{
		return null;
	}

	public ActionBase GetActionRotateToEntity(EntityBase target)
	{
		return null;
	}

	protected ActionBase GetActionRotateToPos(Vector3 pos)
	{
		return null;
	}

	public ActionWait GetActionWait(string name, int waitTime)
	{
		return null;
	}

	public ActionWaitRandom GetActionWaitRandom(string name, int min, int max)
	{
		return null;
	}

	protected ActionDivide GetActionDivide(string name, int entityId, int count)
	{
		return null;
	}

	public ActionDelegate GetActionDelegate(Action action)
	{
		return null;
	}

	protected ActionBase GetActionWaitDelegate(int time, Action action)
	{
		return null;
	}

	protected ActionDelegate GetActionRemoveMove()
	{
		return null;
	}

	public virtual void RemoveMove()
	{
	}

	protected void RemoveCurrentAction()
	{
	}

	public virtual void AfterExcuteSoldierUp()
	{
	}

	public void Divide(int entityid, int count)
	{
	}

	public void Divide(int entityid, int count, int inherit)
	{
	}

	public void Divide(int entityid, int count, int inherit, bool drop)
	{
	}

	public bool GetIsAlive()
	{
		return false;
	}

	protected bool GetHaveHatred()
	{
		return false;
	}

	public void RemoveCall(RemoveCallData data)
	{
	}

	public void DeadBefore()
	{
	}

	protected virtual void OnDeadBefore()
	{
	}

	protected override void OnActionClear()
	{
	}

	protected bool isTargetNear(EntityBase target, float distance)
	{
		return false;
	}

	protected void RemoveAttack()
	{
	}

	public virtual void Attack(int AttackID, bool bRotate, EntityBase hatredTarget = null)
	{
	}

	public virtual void AttackBabyMelee(int AttackID, bool bRotate)
	{
	}

	public virtual void AttackSpecial(int AttackID, bool bRotate)
	{
	}

	public bool GetAttackEnd()
	{
		return false;
	}

	protected ActionDelegate GetActionRemoveAttack()
	{
		return null;
	}

	public ActionSequence GetActionAttackWait(int attackID, int waittime, int waitmaxtime = -1)
	{
		return null;
	}

	protected ActionSequence GetActionAttackWait_Net(int attackID, int waittime, int waitmaxtime = -1)
	{
		return null;
	}

	public ActionAttack GetActionAttack(string name, int attackId, bool rotate = true)
	{
		return null;
	}

	public ActionBabyMeleeAttack GetActionBabyMeleeAttack(string name, int attackId, bool rotate = true)
	{
		return null;
	}

	public ActionWeaponAttack GetActionAttackInMeadowBattle(string name, int attackId, bool rotate = true, bool bAttackSpecial = false)
	{
		return null;
	}

	public ActionAttack_Net GetActionAttackNet(string name, int attackId, bool rotate = true)
	{
		return null;
	}

	public ActionAttack GetActionAttackSpecial(string name, int attackId, bool rotate = true)
	{
		return null;
	}

	protected ActionAttack_Net GetActionAttackSpecialNet(string name, int attackId, bool rotate = true)
	{
		return null;
	}

	public void ClearCallData()
	{
	}

	public void InitCallData(CallData data)
	{
	}

	public void InitCallData(int callid, int alivecount, int count, int percount, int radiusmin, int radiusmax)
	{
	}

	protected void InitCallData(int callid, int alivecount, int count, int percount, int radiusmin, int radiusmax, bool elite)
	{
	}

	protected void InitCallData(int callid, int alivecount, int count, int percountMin, int percountMax, int radiusmin, int radiusmax)
	{
	}

	protected void InitCallData(int id, int[] callIds, int[] weights, int alivecount, int count, int percount, int radiusmin, int radiusmax, bool elite)
	{
	}

	public void AddCallCount(int callid)
	{
	}

	protected void RemoveCallCount(int callid)
	{
	}

	public bool GetCanCall(object callid)
	{
		return false;
	}

	protected int GetCallCount(int callid)
	{
		return 0;
	}

	public int GetAliveCount(int callid, bool over = false)
	{
		return 0;
	}

	public ActionBase GetActionCall(int entityId, bool playCallAnim = true)
	{
		return null;
	}

	protected ActionBase GetActionCallInternal(int entityId, Action<ActionCall.ActionCallData> call, bool playCallAnim = true)
	{
		return null;
	}

	private Vector3 GetRandomCall(int entityid, CallData data)
	{
		return default;
	}

	protected void AddActionAddCall(int entityId, int bulletid)
	{
	}

	protected ActionBase GetCall(int entityId, int bulletid)
	{
		return null;
	}

	protected ActionBase GetCall(int entityId, int bulletid, Vector3 pos, bool bRotate = true)
	{
		return null;
	}

	public void Call(ActionCall.ActionCallData data)
	{
	}

	private int GetCallId(int id)
	{
		return 0;
	}

	public void CallOne(Vector3 pos)
	{
	}

	public void CallOne(Vector3 pos, bool showeffect)
	{
	}

	private void CallOne(int callid, Vector3 pos)
	{
	}

	public void CallOne(int callid, int entityid, Vector3 pos, bool isElite)
	{
	}

	public EntityBase CallMonster(int callid, Vector3 pos, bool showCallEffect = true)
	{
		return null;
	}

	private bool IsCallStand(int entityid)
	{
		return false;
	}

	private void CallStand(CallData calldata, int entityId)
	{
	}

	private void CallMove(CallData calldata, int entityId)
	{
	}

	public void CallOneInternal(int callid, Vector3 pos, bool showcalleffect)
	{
	}

	protected EntityCallBase CallOneInternal(int callid, Vector3 pos, bool showcalleffect, bool isElite)
	{
		return null;
	}

	private void CallOneInternal(int callid, int entityid, Vector3 pos, bool showcalleffect, bool isElite)
	{
	}

	protected EntityBase CallOneInternal2(int callid, Vector3 pos, bool showcalleffect)
	{
		return null;
	}

	protected void ExcuteAttributes(string name, long value)
	{
	}

	protected void ExcuteWolfhoundPartAttributes(EntityBase parent)
	{
	}

	protected void ExcuteSkullPartAttributes(EntityBase parent)
	{
	}

	public List<Vector2Int> GetSpaceList(int vertical_space, int horizontal_space)
	{
		return null;
	}

	private bool isSameRowOrColAsBodyArea(Vector2Int grid)
	{
		return false;
	}

	private bool isInDiagonalGrids(Vector2Int grid, MeadowBattleMonsterInfo.AttackAreaEnum attackAreaEnum)
	{
		return false;
	}

	private List<Vector2Int> getDiagonalGrids(MeadowBattleMonsterInfo.AttackAreaEnum attackAreaEnum)
	{
		return null;
	}

	private List<Vector2Int> getDiagonalGridsByCornerGrid(Vector2Int cornerGrid, int space, int factorX, int factorY, int len)
	{
		return null;
	}

	private List<Vector2Int> getTriangleGrids(Vector2Int curGrid, Vector4 cornerInfo, int height, int vertical_space)
	{
		return null;
	}

	private bool isInTriangleGrids(Vector2Int curGrid, List<Vector2Int> list)
	{
		return false;
	}

	private bool isFrontRectangeAreas(Vector2Int curGrid, Vector2Int startGrid, Vector2Int range)
	{
		return false;
	}

	private Vector4 getSearchAreaInfo(MeadowBattleMonsterInfo.AttackAreaEnum attackAreaEnum)
	{
		return default;
	}

	public List<Vector2Int> GetAttackingAreas(MeadowBattleMonsterInfo.AttackAreaEnum attackAreaEnum, Vector4 searchInfo)
	{
		return null;
	}

	public List<Vector2Int> GetAttackingAreas(MeadowBattleMonsterInfo.AttackAreaEnum attackAreaEnum)
	{
		return null;
	}

	protected ActionBase GetActionCallNet(int entityId)
	{
		return null;
	}

	protected ActionBase GetActionCallInternalNet(int entityId, Action<ActionCall.ActionCallData> call)
	{
		return null;
	}

	public void CallNet(ActionCall.ActionCallData data)
	{
	}

	private void CallStandNet(CallData calldata, int entityId)
	{
	}

	private void CallMoveNet(CallData calldata, int entityId)
	{
	}

	private void CallOneNet(int callid, int entityid, Vector3 pos, bool isElite)
	{
	}
}
