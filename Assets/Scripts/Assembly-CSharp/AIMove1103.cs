using UnityEngine;

public class AIMove1103 : AIMoveBase
{
	public float MinTime;

	public float MaxTime;

	private float interval;

	private bool isStart;

	private float movementTime;

	protected virtual Vector3 moveDir => default;

	public AIMove1103(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected virtual void onAfterInit()
	{
	}

	protected virtual void OnCloseEnough()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected virtual bool isCloseEnough()
	{
		return false;
	}

	protected virtual void updateDir()
	{
	}

	private void reset()
	{
	}
}
