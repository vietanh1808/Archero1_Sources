public class AIMoveBabyNormal : AIMoveBase
{
	private EntityBase mParent;

	protected float Move_NextTime;

	protected float Move_NextDurationTime;

	protected float Move_NextX;

	protected float Move_NextY;

	private float Move_NextDurationTimeMin;

	private float Move_NextDurationTimeMax;

	private int min;

	private int max;

	private float fardis;

	public AIMoveBabyNormal(EntityBase entity, int min, int max, float fardis)
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
