using System;
using UnityEngine;

public class ActionBezierCurve : ActionBasic.ActionBase
{
	public float height;

	private float fullPercent;

	private float t;

	public float deltaT;

	public Func<Vector3> getTargetPos;

	public Action<RaycastHit> onHitWall;

	public Action<bool, RaycastHit> onArrived;

	public Action OnEnterBezierCurve;

	public AIMeadowBattleBase aiBase;

	private float fallingX;

	private float fallingZ;

	private bool isFallingDown;

	private RaycastHit hitInfo;

	private BezierCurve bezierCurve;

	protected override void OnForceEnd()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void initBezierCurve()
	{
	}

	private Vector3[] getBezierPoints()
	{
		return null;
	}

	protected override void OnDeInit()
	{
	}
}
