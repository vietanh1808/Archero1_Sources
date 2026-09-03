public class ActionMeadowBattleAttack5060 : ActionBodyAndRemoteAttack
{
	private bool m_bRotateEntity;

	public ActionMeadowBattleAttack5060(EntityBase _entity)
		: base(null)
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override ActionBasic.ActionBase getRandomAttackAction()
	{
		return null;
	}

	public bool GetIsAlive()
	{
		return false;
	}

	private ActionBasic.ActionBase GetAttackSeq()
	{
		return null;
	}

	private ActionBasic.ActionBase GetAttack5194()
	{
		return null;
	}

	private ActionBasic.ActionBase GetAttack5198()
	{
		return null;
	}
}
