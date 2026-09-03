using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TableTool;
using UnityEngine;

public class EntityNetHero : EntityHero
{
	public class NetMoveCmdData
	{
		public string selfID;

		public string otherID;

		public float timeSum;

		public float timeSqSum;

		public int n;

		public float minTime;

		public float maxTime;

		public float variance { get; private set; }

		public float average { get; private set; }

		public void Clear()
		{
		}

		public bool CalData()
		{
			return false;
		}

		public void SendPoint()
		{
		}
	}

	public enum EntityGrassState
	{
		OutsideGrass = 0,
		InsideGrassShow = 1,
		InsideGrassHide = 2
	}

	[CompilerGenerated]
	private sealed class _003CMovePosFun_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EntityNetHero _003C_003E4__this;

		public Vector3 pos;

		private float _003CmovePart_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CMovePosFun_003Ed__39(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private NetMoveControl netMoveControl;

	private List<Skill_slotin_doubleplayer> netSkillList;

	private int WeightAll_PVP;

	private List<Skill_slotin_pvp> m_SkillList_PVP;

	public PVPRadarVO RadarVO;

	public PVPInGrassControl GrassControl;

	private bool isPvpGrassVisible;

	private const string PVP_GRASS_UPDATE = "PVP_GRASS_UPDATE";

	private EntityNetHero opponentEntity;

	public EntityGrassState m_GrassState;

	public Action<CustomJsonDataCommand, CustomJsonActionVO> OnRecvCustomJsonDataCommandAcion;

	public NetMoveCmdData netCmdData { get; private set; }

	public NetHeroAttackControl netAttackControl { get; protected set; }

	public EntityNetHero OpponentEntity => null;

	public override void Init(int id)
	{
	}

	protected override void OnInitBefore()
	{
	}

	protected override void StartInit()
	{
	}

	protected override void InitSkillList()
	{
	}

	protected override void AddInitSkills()
	{
	}

	public void InitPvpSelfSkills()
	{
	}

	public override bool AddSkillInternal(int skillId, params object[] args)
	{
		return false;
	}

	protected override void OnAddSkillInternal(int skillId)
	{
	}

	public override int GetRandomSkill()
	{
		return 0;
	}

	public override void AddSkill(int skillId)
	{
	}

	public override List<int> GetSkill(int num = 9, List<int> blockedList = null)
	{
		return null;
	}

	public override List<int> GetFirstSkill9()
	{
		return null;
	}

	protected override void remove_skill_weight(int skillid)
	{
	}

	protected override void InitEmoji()
	{
	}

	protected override void OnInit()
	{
	}

	private void CreatAttCtl()
	{
	}

	private void CreatCooperationAttackCtl()
	{
	}

	private void CreatPVPAttackCtl()
	{
	}

	protected override void CreateModel()
	{
	}

	private void SendNetCommand(BaseCommand cmd)
	{
	}

	public override void PushCommand(BaseCommand cmd)
	{
	}

	public override void PushJsonCommand(string jsonData)
	{
	}

	private void ExpressionCmd_Exec(ExpressionCommand cmd)
	{
	}

	private void Excute_CreatePartBody(CreatePartBodyCommand cmd)
	{
	}

	protected override void OnPartBodyRemove(EntityPartBodyBase entity, int partbodyid)
	{
	}

	private void Exucte_Attribute(ExcuteAttributeCommand cmd)
	{
	}

	private void UpdateNetCmdData(MoveCommand cmd)
	{
	}

	private void Excute_StartMove(MoveCommand cmd)
	{
	}

	[IteratorStateMachine(typeof(_003CMovePosFun_003Ed__39))]
	private IEnumerator MovePosFun(Vector3 pos)
	{
		return null;
	}

	public override void SetPosition(Vector3 pos)
	{
	}

	public void ForceStopMove()
	{
	}

	private void Excute_StopMove(StopMoveCommand cmd)
	{
	}

	private void Excute_SetTarget(SetTargetCommand cmd)
	{
	}

	private void Excute_ChangeHp(ChangeHpCommand cmd)
	{
	}

	protected override void OnTriggerEnterExtra(Collider o)
	{
	}

	protected override void OnTriggerExitExtra(Collider o)
	{
	}

	private void OnNetHeroAttackPre()
	{
	}

	public override void PlayAttack()
	{
	}

	private void OnRecAttackCommand(AttackCommand pcmd)
	{
	}

	public override void LearnSkill(int skillid)
	{
	}

	public override void ChangeHPMust(EntityBase entity, long HP, HitStruct data = null)
	{
	}

	public void ForceDeadInPvp()
	{
	}

	public override void DeadCallBack()
	{
	}

	public override void Reborn_DeadEnd()
	{
	}

	public override void DoRebornInternal(int pHpPart = 100, bool bSkillReborn = false, bool bNoLogic = false, BattleModuleData.UseRebornType rebornType = BattleModuleData.UseRebornType.None)
	{
	}

	public override void ChangeHPNoLogic(EntityBase entity, long HP)
	{
	}

	public override void DeInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	public override bool CanBeDizzy()
	{
		return false;
	}

	private void InitSkillList_PVE()
	{
	}

	protected override void InitPVPGrass()
	{
	}

	private void initConfig()
	{
	}

	protected override void DeinitPVPGrass()
	{
	}

	private void onCreatePlayer()
	{
	}

	private void OnSelfAnchorChanged()
	{
	}

	private void OnOtherAnchorChanged()
	{
	}

	private void onPvpGrassUpdate(float delta)
	{
	}

	public void SetVisibleInPvpGrass(bool visible)
	{
	}

	public void SetGrassState(EntityGrassState _state)
	{
	}

	public bool IsInsideGrassHideState()
	{
		return false;
	}

	private void ShowInPvpGrass(float alpha, bool visible)
	{
	}

	protected void ChangeGrassState()
	{
	}

	private void onEnterGrass()
	{
	}

	private void onExitGrass()
	{
	}

	protected bool IsInGrass()
	{
		return false;
	}

	public bool IsInRadar(Vector2Int XY)
	{
		return false;
	}

	private void CheckIfEntityInRadar()
	{
	}

	private void CheckPvpGrass()
	{
	}

	private void InitSkillList_PVP()
	{
	}

	public virtual List<int> GetSkill_PVP(int num = 6)
	{
		return null;
	}

	private void OnRecCustomJsonCommand(CustomJsonDataCommand cmd)
	{
	}

	private void addSkillId(CustomJsonDataCommand cmd)
	{
	}

	private void onSyncExplosionEffect(CustomJsonDataCommand cmd)
	{
	}

	private void onSyncMapGoods(CustomJsonDataCommand cmd)
	{
	}

	private void onCreateCatBullet(CustomJsonDataCommand cmd)
	{
	}

	private void onAntiCheatOpponentHp(CustomJsonDataCommand cmd)
	{
	}

	private void onAntiCheatOpponentAttr(CustomJsonDataCommand cmd)
	{
	}

	private void onAntiCheatOpponentHit(CustomJsonDataCommand cmd)
	{
	}

	private void createSocketBullet(CustomJsonDataCommand cmd)
	{
	}

	private void createSocketBullet1194(CustomJsonDataCommand cmd)
	{
	}

	private void createEntityMonster(CustomJsonDataCommand cmd)
	{
	}

	private void addOwlElf(CustomJsonDataCommand cmd)
	{
	}

	private void removeOwlElf(CustomJsonDataCommand cmd)
	{
	}

	private void removeOwlElfByIndex(CustomJsonDataCommand cmd)
	{
	}

	private void addPumpkin(CustomJsonDataCommand cmd)
	{
	}

	private void createThunder(CustomJsonDataCommand cmd)
	{
	}

	private void createFlySword(CustomJsonDataCommand cmd)
	{
	}

	public void CreateCatBullet(int BulletId, Vector3 bulletPos, float angle, int guid, float attackRatio, int debuffId)
	{
	}
}
