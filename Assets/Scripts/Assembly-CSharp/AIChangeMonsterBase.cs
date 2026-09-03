using TableTool;

public class AIChangeMonsterBase : AIBase
{
	private float lastCasttime;

	private bool canWalk;

	protected Daily_ChangeMonsterConfig Config => null;

	private float FollowPlayerDis => 0f;

	private float FollowEnemyDis => 0f;

	private float AttackRange => 0f;

	protected override void OnInit()
	{
	}

	public override void DeInit()
	{
	}

	private void AddAllAction()
	{
	}

	private bool HaveEnemyTarget()
	{
		return false;
	}

	private bool IsNearFollowEnemyEnough()
	{
		return false;
	}

	private bool IsNearAttackEnemyEnough()
	{
		return false;
	}

	private bool CanCDAttackEnemy()
	{
		return false;
	}

	private bool IsNearFollowPlayerEnough()
	{
		return false;
	}

	private float GetDis(EntityBase target1, EntityBase target2)
	{
		return 0f;
	}

	private float GetRotateAngle(EntityBase target)
	{
		return 0f;
	}

	protected float GetWaitTime()
	{
		return 0f;
	}

	private void SetCastTime(float time)
	{
	}

	private void SetCanWalk(bool canWalk)
	{
	}

	private void OnAttackSpeedChanged(float oldValue, float newValue)
	{
	}
}
