using System;
using UnityEngine;

public class ActionBezierCurveForObj
{
	private const string UPDATE_NAME = "ActionBezierCurveForObj-Update";

	public GameObject Obj;

	public float height;

	public float deltaT;

	public Func<Vector3> getStartPos;

	public Func<Vector3> getTargetPos;

	public Action onArrived;

	public bool isLocal;

	private float fullPercent;

	private float t;

	private BezierCurve bezierCurve;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	protected void OnUpdate(float deltaTime)
	{
	}

	private void initBezierCurve()
	{
	}

	private Vector3[] getBezierPoints()
	{
		return null;
	}
}
