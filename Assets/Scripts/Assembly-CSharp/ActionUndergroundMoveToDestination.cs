public class ActionUndergroundMoveToDestination : ActionMoveToDestination
{
	private bool canMove;

	private float curElapsedTime;

	protected float elapsedTime;

	protected float stopTime;

	public ActionUndergroundMoveToDestination(EntityBase m_Entity)
		: base(null)
	{
	}

	protected virtual void customTime()
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnEnd()
	{
	}

	public override void MoveForward()
	{
	}

	private void hide()
	{
	}
}
