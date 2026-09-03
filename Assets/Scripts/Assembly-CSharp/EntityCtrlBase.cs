using System.Collections.Generic;

public abstract class EntityCtrlBase
{
	public List<EBattleAction> mActionsList;

	protected EntityBase m_Entity;

	private bool bUseUpdate;

	public bool UseUpdate => false;

	public void SetUseUpdate()
	{
	}

	public void SetEntity(EntityBase entity)
	{
	}

	public virtual void OnStart(List<EBattleAction> actIds)
	{
	}

	public virtual void OnRemove()
	{
	}

	public abstract void ExcuteCommend(EBattleAction id, object action);

	public virtual void OnUpdate(float delta)
	{
	}

	public virtual void ExecCommand(BaseCommand cmd)
	{
	}

	public virtual void ExecutecStandaloneBuff(BuffCommand cmd)
	{
	}
}
