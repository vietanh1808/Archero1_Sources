public class AIMeadowBattle3015 : AIMeadowBattleBase
{
	public override MoveStateInAttack CurMoveStateInAttack => MoveStateInAttack.straight;

	public override void RemoveMove()
	{
	}

	protected override ActionBase GetActionMeadowBattleAttack()
	{
		return null;
	}

	public override void AddAttackActions()
	{
	}
}
