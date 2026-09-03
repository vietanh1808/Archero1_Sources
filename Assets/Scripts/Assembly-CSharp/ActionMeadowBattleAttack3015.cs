using UnityEngine;

public class ActionMeadowBattleAttack3015 : ActionBodyAndRemoteAttack
{
	private int stepDistance;

	public ActionMeadowBattleAttack3015(EntityBase _entity)
		: base(null)
	{
	}

	protected override ActionBasic.ActionBase getRandomAttackAction()
	{
		return null;
	}

	private Vector3 getTargetPos()
	{
		return default;
	}
}
