using System;

public class AIMeadowBattle3028 : AIMeadowBattleBase
{
	public override MoveStateInAttack CurMoveStateInAttack => MoveStateInAttack.straight;

	protected override ActionBase GetActionMeadowBattleAttack()
	{
		return null;
	}

	public override void AddAttackActions()
	{
	}

	public override void ShowAnimFromUnderground(Action showComplete)
	{
	}

	public override void HideAnimToUnderground(Action hideStart, Action hideComplete)
	{
	}
}
