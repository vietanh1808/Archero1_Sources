using UnityEngine;

public class ActionMeadowBattleAttack3022 : ActionBodyAndRemoteAttack
{
	private int stayTime;

	private float stepDistance;

	public ActionMeadowBattleAttack3022(EntityBase _entity)
		: base(null)
	{
	}

	protected override ActionBasic.ActionBase getRandomAttackAction()
	{
		return null;
	}

	private void fireBullets()
	{
	}

	private Vector3 getBackTargetPos()
	{
		return default;
	}

	private Vector3 getForwardTargetPos()
	{
		return default;
	}

	private Vector3 GetTargetPos(bool isBack, float stepDistance)
	{
		return default;
	}
}
