using UnityEngine;

public class ActionMoveToDestination5060 : ActionMoveToDestination
{
	private float curDistance;

	private Vector3 oldPosXZ;

	private float stepDistance;

	private float acceleratPercent => 0f;

	private bool isStraightMove { get; set; }

	private Vector3 curVelocity => default;

	private Vector3 acceleratedVelocity => default;

	public ActionMoveToDestination5060(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void TurnOrEvolve(RaycastHit hitInfo)
	{
	}

	public override void MoveForward()
	{
	}

	private void animSpeedHandler(bool isQuickRun)
	{
	}
}
