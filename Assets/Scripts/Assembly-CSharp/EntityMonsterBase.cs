using System;
using System.Collections.Generic;
using Dxx.Util;
using TableTool;
using UnityEngine;

[SelectionBase]
public class EntityMonsterBase : EntityCallBase
{
	public class DropData
	{
		public int GoodID;

		public int Weight;
	}

	public class DropRandomData
	{
		private int DropWeight;

		private List<DropData> mDropList;

		public void InitDrop(string[] s)
		{
		}

		public int GetRandom()
		{
			return 0;
		}
	}

	private bool bDeadDown;

	protected DropBase mDrop;

	private SequencePool mSequencePool;

	private GameObject elite_thunder;

	private const float HittedMax = 30f;

	private float HittedReal;

	private int HittedBackIndex;

	public Action OnEvolved;

	public Action OnAfterAIInitialized;

	public Action OnReady2Attack;

	public Action OnGameStarted;

	public Action OnEnterUnderground;

	public Action OnDead;

	public List<int> mbSkillList;

	protected Dictionary<int, MBSkillBase> mbSkillDict;

	public int TDBirthIndex { get; set; }

	public bool DropFlag { get; set; }

	protected override string ModelPath => null;

	public Soldier_soldier m_SoldierData { get; protected set; }

	private int HittedArgsLength => 0;

	public MeadowBattleMonsterInfo.MonsterLocationInfo LocationInfo => null;

	public Vector2Int OldAnchorGrid { get; set; }

	public bool IsTargetAvailable => false;

	public bool CanBeAttacked => false;

	protected virtual List<BattleDropData> goodsList => null;

	protected override void OnInitBefore()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void InitAnimations()
	{
	}

	protected override void CreateHP()
	{
	}

	protected override void StartInit()
	{
	}

	public DropBase GetDrop()
	{
		return null;
	}

	private void PlayElite()
	{
	}

	private void UpdateElite()
	{
	}

	public override void updateWithSpecialShader()
	{
	}

	public override void updateWithNormalShader()
	{
	}

	protected override void OnDeInitLogic()
	{
	}

	protected override void OnCreateModel()
	{
	}

	protected override void OnChangeHP(EntityBase entity, long HP)
	{
	}

	private void CreateGoods()
	{
	}

	protected virtual void OnCreateDeadGoods()
	{
	}

	private void CreateDeadGoods(List<BattleDropData> list)
	{
	}

	public override void SurvivalDeadCallBack()
	{
	}

	public override void WaveClearDeadCallBack()
	{
	}

	public override void DeadCallBack()
	{
	}

	protected override void UpdateProcess(float delta)
	{
	}

	public override bool SetHitted(HittedData data)
	{
		return false;
	}

	private void StartHittedBack(float backRatio)
	{
	}

	private void UpdateHittedBack()
	{
	}

	public void StartCall()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	public void UpdateAnchorGrid(Vector2Int _anchorGrid)
	{
	}

	private void UpdateModeExtraAttribute(int symbol)
	{
	}

	protected void InitDivideID()
	{
	}

	protected override List<BattleDropData> OnGetGoodList()
	{
		return null;
	}

	protected float GetSelfHPDropPercent()
	{
		return 0f;
	}

	protected int GetHPDrop3Wrapper()
	{
		return 0;
	}

	private bool canAddMPDrop()
	{
		return false;
	}

	private void addMPDrop(List<BattleDropData> list, BattleDropData mpdrop)
	{
	}

	public void AddMBSkill(int skillId, params object[] args)
	{
	}

	public void RemoveMBSkill(int skillId)
	{
	}

	private void uninstallAllMBSkills()
	{
	}

	protected override void CollisionEnterExtra(Collision o)
	{
	}

	protected override void OnTriggerEnterExtra(Collider o)
	{
	}

	protected override void OnTriggerExitExtra(Collider o)
	{
	}

	protected override bool HitEntity(EntityBase e)
	{
		return false;
	}

	protected virtual void OnHitEntity(EntityBase e)
	{
	}
}
