public class ActionRemoteFlee : ActionBodyAndRemoteAttack
{
	public ActionRemoteFlee(EntityBase m_Entity)
		: base(null)
	{
	}

	protected override ActionBasic.ActionBase getRandomAttackAction()
	{
		return null;
	}
}
