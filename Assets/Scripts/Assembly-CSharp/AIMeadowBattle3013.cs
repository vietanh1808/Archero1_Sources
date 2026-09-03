public class AIMeadowBattle3013 : AIMeadowBattleBase
{
	public override MoveStateInAttack CurMoveStateInAttack => MoveStateInAttack.straight;

	protected override ActionBase GetActionMeadowBattleAttack()
	{
		return null;
	}

	public override void AddAttackActions()
	{
	}
}
