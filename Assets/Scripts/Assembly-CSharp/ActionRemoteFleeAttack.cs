public class ActionRemoteFleeAttack : ActionRemoteAttack
{
	public override bool CanFlee => false;

	public ActionRemoteFleeAttack(EntityBase entity)
		: base(null)
	{
	}
}
