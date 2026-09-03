public class AIMeadowBattle3022 : AIMeadowBattleBase
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
