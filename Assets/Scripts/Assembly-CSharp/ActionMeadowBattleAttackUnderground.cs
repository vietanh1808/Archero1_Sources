public class ActionMeadowBattleAttackUnderground : ActionBodyAndRemoteAttack
{
	public virtual float WaitTime => 0f;

	public ActionMeadowBattleAttackUnderground(EntityBase m_Entity)
		: base(null)
	{
	}

	protected override ActionBasic.ActionBase getRandomAttackAction()
	{
		return null;
	}

	private bool canPlayShowAnim()
	{
		return false;
	}
}
