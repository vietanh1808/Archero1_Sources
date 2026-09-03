using UnityEngine;

public class ActionBezierMoveToDestination : ActionMoveToDestination
{
	private float stepDistance;

	protected int waitTime;

	protected AIBase.ActionLoop loop;

	public ActionBezierMoveToDestination(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void OnInitBase()
	{
	}

	protected virtual void InitActionLoop()
	{
	}

	public override void MoveForward()
	{
	}

	protected Vector3 getTargetPos()
	{
		return default;
	}

	protected virtual void onArrived(bool isFallingDown, RaycastHit hitInfo)
	{
	}
}
