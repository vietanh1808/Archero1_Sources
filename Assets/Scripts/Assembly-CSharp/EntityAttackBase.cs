using System;

public abstract class EntityAttackBase
{
	protected int AttackID;

	protected bool bEnd;

	protected EntityBase m_Entity;

	protected JoyData m_AttackData;

	protected JoyData m_MoveData;

	private bool bInit;

	protected Action OnUnInstall;

	protected bool bRotate;

	private bool bAddActionEnd;

	public void Init(EntityBase entity, int AttackID)
	{
	}

	private void OnAttackActionEnd()
	{
	}

	protected void AttackNotGo()
	{
	}

	public void SetIsEnd(bool isend)
	{
	}

	public bool GetIsEnd()
	{
		return false;
	}

	protected abstract void OnInit();

	public void SetRotate(bool bRotate)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UnregistAttackEnd()
	{
	}

	protected virtual void DeInit()
	{
	}

	public virtual void SetData(params object[] args)
	{
	}

	protected virtual void UpdateAttackAngle()
	{
	}

	public abstract void Install();

	public void UnInstall()
	{
	}

	protected virtual void UpdateProcess(float delta)
	{
	}
}
