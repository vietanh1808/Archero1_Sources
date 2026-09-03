public class AIMove1002 : AIMoveBase
{
	protected float Move_NextTime;

	protected float Move_NextDurationTime;

	protected float Move_NextX;

	protected float Move_NextY;

	protected float Move_NextDurationTimeMin;

	protected float Move_NextDurationTimeMax;

	private int min;

	private int max;

	public AIMove1002(EntityBase entity, int min, int max = -1)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void MoveNormal()
	{
	}

	private void AIMoveStart()
	{
	}

	private void AIMoving()
	{
	}

	private void AIMoveEnd()
	{
	}

	protected virtual void RandomNextMove()
	{
	}

	private void RandomNextMoveOnce()
	{
	}

	protected bool IsRandomValid()
	{
		return false;
	}

	protected override void OnEnd()
	{
	}
}
