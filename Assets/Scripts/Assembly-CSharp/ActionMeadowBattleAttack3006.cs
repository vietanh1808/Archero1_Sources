public class ActionMeadowBattleAttack3006 : ActionBodyAndRemoteAttack
{
	public ActionMeadowBattleAttack3006(EntityBase _entity)
		: base(null)
	{
	}

	protected override void OnInit()
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
