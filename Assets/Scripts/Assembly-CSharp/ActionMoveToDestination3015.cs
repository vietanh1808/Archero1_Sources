using System.Collections.Generic;
using UnityEngine;

public class ActionMoveToDestination3015 : ActionBezierMoveToDestination
{
	private new enum MoveDir
	{
		forward = 0,
		right = 1,
		down = 2,
		left = 3
	}

	private Dictionary<MoveDir, float> dirDict;

	private MoveDir[] dirArr;

	private MoveDir curDir;

	private int curDirIndex;

	private float curDistance;

	private Vector3 oldPos;

	public ActionMoveToDestination3015(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void InitActionLoop()
	{
	}

	protected override void onArrived(bool isFallingDown, RaycastHit hitInfo)
	{
	}

	private void onDirChanged()
	{
	}
}
