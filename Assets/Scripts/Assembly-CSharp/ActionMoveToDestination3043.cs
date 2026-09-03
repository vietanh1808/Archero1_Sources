using MeadowBattle;

public class ActionMoveToDestination3043 : ActionMoveToDestination
{
	public enum MoveState
	{
		move = 0,
		attack = 1
	}

	private ActionWeaponAttack attackAction;

	private MoveState curMoveState;

	private float curElapsedTime;

	private const float elapsedTime = 2f;

	public ActionMoveToDestination3043(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	public override void MoveForward()
	{
	}

	private void onMove()
	{
	}

	private void onAttack()
	{
	}
}
