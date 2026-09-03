using System;
using UnityEngine;

public class ActionMovingDis
{
	public const string Tag = "ActionMovingDis";

	public EntityBase m_Entity;

	public float maxDis;

	public Action OnReachMaxDis;

	private bool IsMoving;

	private string updateName;

	protected Vector3 oldPos;

	protected Vector3 originalPos;

	protected float curDistance;

	private float validDistance;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onMove(bool isMoving)
	{
	}

	private void onUpdate(float delta)
	{
	}

	public void ResetDistance()
	{
	}
}
