using UnityEngine;

public class ActionBodyAndRemoteAttack : ActionBasic.ActionBase
{
	public AIMeadowBattleBase aiBase;

	private EntityBase attackTarget;

	private AIBase.ActionSequence seq;

	public AIBase.ActionSequence Seq => null;

	public ActionBodyAndRemoteAttack(EntityBase _entity)
	{
	}

	private void initSeq()
	{
	}

	protected override void OnInit()
	{
	}

	public virtual float getAttackDistance()
	{
		return 0f;
	}

	protected virtual ActionBasic.ActionBase getRandomAttackAction()
	{
		return null;
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnForceEnd()
	{
	}

	protected Vector3 GetNearRandomPos(int stepDistance)
	{
		return default;
	}

	protected Vector3 GetDiagonalQuadrantDir()
	{
		return default;
	}

	protected override void OnDeInit()
	{
	}
}
