using System;

public class AIMove1006 : AIMoveBase
{
	protected float Move_NextX;

	protected float Move_NextY;

	private int min;

	private int max;

	private Func<bool> callback;

	public AIMove1006(EntityBase entity, int min, int max, Func<bool> callback = null)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected virtual void SetHatred()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void Move2Player()
	{
	}

	private void MoveNormal()
	{
	}

	private void AIMoveStart()
	{
	}

	private void UpdateMoveData()
	{
	}

	private void AIMoving()
	{
	}

	private void AIMoveEnd()
	{
	}

	protected override void OnEnd()
	{
	}

	private bool CheckEnd()
	{
		return false;
	}
}
