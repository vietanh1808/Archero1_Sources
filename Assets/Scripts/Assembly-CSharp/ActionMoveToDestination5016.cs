using UnityEngine;

internal class ActionMoveToDestination5016 : ActionMoveToDestination
{
	private float stepDistance;

	private float[] randomAngleArr;

	private Vector3 verticalDir;

	private float curDistance;

	private Vector3 oldPosXZ;

	private bool _isQuickRun;

	private bool isQuickRun
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private Vector3 curVelocity => default;

	public ActionMoveToDestination5016(EntityBase m_Entity)
		: base(null)
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void OnInitBase()
	{
	}

	public override void MoveForward()
	{
	}

	private void updateCurDir()
	{
	}
}
