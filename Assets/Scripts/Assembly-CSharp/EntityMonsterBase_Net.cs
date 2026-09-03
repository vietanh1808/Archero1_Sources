using System.Collections.Generic;
using UnityEngine;

public class EntityMonsterBase_Net : EntityMonsterBase
{
	private NetMoveControl netMoveControl;

	private AttackControl_NetMonster netAttackControl;

	protected override List<BattleDropData> goodsList => null;

	public bool IsEntityDead { get; private set; }

	public override void Init(int id)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnCreateModel()
	{
	}

	public void SetRoteTarget(bool b)
	{
	}

	public override bool GetSuperArmor()
	{
		return false;
	}

	public override void InitWeapon(int WeaponID, bool isInitAnim = true)
	{
	}

	public override void ChangeHPMust(EntityBase entity, long HP, HitStruct data = null)
	{
	}

	public override void DeadCallBack()
	{
	}

	protected override void OnEntityDead()
	{
	}

	private void OnNetMonsterDead(EntityBase source)
	{
	}

	public override void PushJsonCommand(string jsonData)
	{
	}

	public override void PushCommand(BaseCommand cmd)
	{
	}

	private void Excute_Behavior(BehaviorCommand cmd)
	{
	}

	private void Excute_Rote(RoteCommand cmd)
	{
	}

	private void Excute_StartMove(MoveCommand cmd)
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

	private void Excute_RoteTarget(RoteTargetCommand cmd)
	{
	}

	private void Excute_AttackCommand(AttackCommand cmd)
	{
	}

	private void ExcuteAction(ActionCommand cmd)
	{
	}

	private void Exucte_Attribute(ExcuteAttributeCommand cmd)
	{
	}

	private void OnRecCustomJsonCommand(CustomJsonDataCommand cmd)
	{
	}

	private void onSyncDizzy(CustomJsonDataCommand cmd)
	{
	}

	private void createBullets(CustomJsonDataCommand cmd)
	{
	}

	private void fireBullet(SocketCreateBulletsVO bulletsVO, Vector3 pos)
	{
	}

	private void forceSyncPos(CustomJsonDataCommand cmd)
	{
	}

	private void setObstacleColliderEnable(CustomJsonDataCommand cmd)
	{
	}

	private void callEntity(CustomJsonDataCommand cmd)
	{
	}

	private void createSpecialEntityAtk(CustomJsonDataCommand cmd)
	{
	}

	private void createSocketBullet(CustomJsonDataCommand cmd)
	{
	}
}
