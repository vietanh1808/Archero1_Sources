using System;

public class EntityPartBodyBase_Net : EntityPartBodyBase
{
	private AttackControl_NetMonster netAttackCtrl;

	public Action<CustomJsonDataCommand, CustomJsonActionVO> OnRecvCustomJsonDataCommandAcion;

	protected override void OnInit()
	{
	}

	protected override void PartBodyUpdate(float delta)
	{
	}

	public override void PushCommand(BaseCommand cmd)
	{
	}

	public override void PushJsonCommand(string jsonData)
	{
	}

	private void OnRecCustomJsonCommand(CustomJsonDataCommand cmd)
	{
	}

	private void Excute_SetTarget(SetTargetCommand cmd)
	{
	}

	private void Excute_RoteTarget(RoteTargetCommand cmd)
	{
	}

	private void Excute_Rote(RoteCommand cmd)
	{
	}

	private void Excute_AttackCommand(AttackCommand cmd)
	{
	}

	private void RemoveLogic()
	{
	}

	protected override void OnCreateModel()
	{
	}

	protected void OnNextRooms(RoomGenerateBase.Room room)
	{
	}
}
