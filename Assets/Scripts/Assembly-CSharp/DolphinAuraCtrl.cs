using System;

public class DolphinAuraCtrl : CommonAuraCtrl
{
	private int DebuffId;

	public Action<EntityBase> AddEntity;

	public Action<EntityBase> RemoveEntity;

	public void SetDebuffId(int debuff)
	{
	}

	protected override void OnEnterAuraCollider(EntityBase e)
	{
	}

	protected override void OnExitAuraCollider(EntityBase e)
	{
	}
}
