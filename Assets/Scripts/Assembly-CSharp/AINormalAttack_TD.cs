using System.Collections.Generic;

public class AINormalAttack_TD : AIDizzyBase
{
	private EntityBase attackTarget;

	protected float AtkRange;

	public int SelectTargetType;

	protected float atkWaitTime;

	public List<EntityBase> aroundEnemies;

	private float deltaSpeed;

	protected virtual int GetWeaponId()
	{
		return 0;
	}

	protected override void OnInitOnce()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private void onTDAtkSpeedChanged()
	{
	}

	public float GetAtkRange()
	{
		return 0f;
	}

	public long GetAtkValue()
	{
		return 0L;
	}

	protected override void PopulateActions()
	{
	}

	protected void UpdateAnimationSpeedWrapper()
	{
	}

	public void UpdateAnimSpeed(float delta)
	{
	}

	private ActionBase getTargetAction()
	{
		return null;
	}

	protected virtual ActionBase getTargetNullAction()
	{
		return null;
	}

	public virtual ActionBase GetActionAttackWrapper()
	{
		return null;
	}

	protected virtual bool CanBeAttacked()
	{
		return false;
	}

	public List<EntityBase> GetSortedAroundEnemies(List<EntityBase> aroundEnemies)
	{
		return null;
	}
}
