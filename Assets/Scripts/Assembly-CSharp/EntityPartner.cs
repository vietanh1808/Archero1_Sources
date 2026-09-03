using UnityEngine;

public class EntityPartner : EntityHero
{
	private Coroutine m_Coroutine;

	public EntityHero Parent { get; private set; }

	public void InitPartner(int nPlayerId)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnInitBefore()
	{
	}

	protected override void DeInitSuperSkill()
	{
	}

	public void SetParent(EntityHero entity)
	{
	}

	public override void InitMoveAndAttackControl()
	{
	}

	protected new virtual void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	public override void DeadCallBack()
	{
	}

	protected override void TriggerDoor(GameObject o)
	{
	}

	protected override void InitSkinSkill()
	{
	}

	public override void SaveHP()
	{
	}
}
