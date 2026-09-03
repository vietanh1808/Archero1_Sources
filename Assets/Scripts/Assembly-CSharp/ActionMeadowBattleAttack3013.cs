using UnityEngine;

public class ActionMeadowBattleAttack3013 : ActionBodyAndRemoteAttack
{
	public ActionMeadowBattleAttack3013(EntityBase _entity)
		: base(null)
	{
	}

	protected override ActionBasic.ActionBase getRandomAttackAction()
	{
		return null;
	}

	public Vector3 GetTargetPos()
	{
		return default;
	}

	private Vector3 getRandomPos(int stepDistance)
	{
		return default;
	}

	public Vector3 GetTargetEnemyPos()
	{
		return default;
	}
}
