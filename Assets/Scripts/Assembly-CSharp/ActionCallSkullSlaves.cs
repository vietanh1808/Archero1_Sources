using System.Collections.Generic;
using UnityEngine;

public class ActionCallSkullSlaves
{
	public EntityBase m_Entity;

	private float PartBodyAliveTime;

	private int PartBodyCount;

	private const int PART_ID = 1826;

	private const int RANGE_IN_GRIDS = 5;

	private const float TIME_INTERVAL = 0.2f;

	private const string UPDATE_NAME = "ActionCallSkullSlaves-update";

	private const float ATK_FACTOR = 1f;

	private const float ATK_SPEED_FACTOR = 0.5f;

	private const float INHERIT_PARENT_CRIT_RATE = 1f;

	private const float SKULL_CRIT_VALUE = 2.5f;

	private int timerId;

	private bool canCall;

	private List<Vector3> posList;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void onUpdate()
	{
	}

	private void tryCallPartBody()
	{
	}

	public void CallSkullSlaves()
	{
	}

	private void CallSingleSkullSlave(Vector3 pos)
	{
	}
}
