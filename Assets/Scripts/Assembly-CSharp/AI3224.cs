public class AI3224 : AIDizzyBase
{
	protected virtual float MoveSpeedMaxFacotor => 0f;

	protected virtual float MoveSpeedCoeFacotor => 0f;

	private bool CanMoveAttack()
	{
		return false;
	}

	protected override void PopulateActions()
	{
	}

	protected virtual ActionBase GetAction()
	{
		return null;
	}
}
