public class ActionMeadowBattleAttack5021 : ActionBodyAndRemoteAttack
{
	public ActionMeadowBattleAttack5021(EntityBase _entity)
		: base(null)
	{
	}

	public override float getAttackDistance()
	{
		return 0f;
	}

	protected override ActionBasic.ActionBase getRandomAttackAction()
	{
		return null;
	}
}
