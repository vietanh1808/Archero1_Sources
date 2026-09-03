public class ActionFlee : ActionBasic.ActionBase
{
	private float curFleeDistance;

	private float fleeDistance;

	private float moveSpeed;

	public EntityBase targetEnemy;

	protected override void OnForceEnd()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void OnBodyHit(EntityBase entity)
	{
	}

	protected override void OnDeInit()
	{
	}
}
