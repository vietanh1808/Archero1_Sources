using UnityEngine;

public class AIMove1009_Net : AIMoveBase_Net
{
	protected float Move_FrontTime;

	protected float Move_BackTime;

	protected bool bBack;

	protected float runAniSpeed;

	protected string runString;

	private Vector3 dir;

	protected virtual float moveRatio => 0f;

	public AIMove1009_Net(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void InitDir()
	{
	}

	private void MoveBack()
	{
	}

	private void MoveFront()
	{
	}

	private void OnMoveEvent(bool b)
	{
	}

	protected override void OnUpdate()
	{
	}

	protected virtual void OnBackEvent()
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
