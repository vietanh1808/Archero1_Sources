public class AI1826DynamicAtkAction : ActionBasic.ActionBase
{
	public EntityBase m_HatredTarget;

	private const float CONTINUOUS_SLASH_RATE = 0.5f;

	private AIBase.ActionSequence seq;

	protected override void OnForceEnd()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	private ActionBasic.ActionBase getResultAction(AI1826 aiBase)
	{
		return null;
	}

	private AIBase.ActionAttack getSlashAction()
	{
		return null;
	}

	private AIBase.ActionAttack getWaveAction()
	{
		return null;
	}
}
