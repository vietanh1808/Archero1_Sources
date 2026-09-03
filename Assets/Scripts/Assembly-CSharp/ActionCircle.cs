using System;
using UnityEngine;

public class ActionCircle
{
	private const string UPDATE_NAME = "ActionCircle-UPDATE";

	public float Radius;

	public float DeltaAnglePerSecond;

	public Transform Trans;

	public Func<Vector3> GetCenterPos;

	private bool started;

	private Vector3 Dir;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void Update(float delta)
	{
	}

	public void Start()
	{
	}
}
